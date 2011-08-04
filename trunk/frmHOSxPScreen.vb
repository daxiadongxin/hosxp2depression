Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Public Class frmHOSxPScreen
    Dim strsql As String
    Dim strsql_complete As String
    Dim strsql_uncomplete As String
    Dim _mysql As New mysqlhelper
    Dim Selected_CID As String
    Dim DT_depression_screen As New DataTable
    Dim DT_depression_screenUncomplete As New DataTable
    Dim DT_ProgramValue As New DataTable
    Dim _mssql As New ClsSQLhelper
    Dim MyConn As New SqlClient.SqlConnection
    Dim CompletePersonCount As Integer = 0
    Dim UNCompletePersonCount As Integer = 0
    Dim CIDList As String = ""
    Dim CompleteCount As Integer = 0
    Dim UncompleteCount As Integer = 0
#Region "Function"
    Sub Load_data()
        Dim Strsql_Exist_CID As String
        Dim StrExistCIDCriteria As String
        Dim DT_ExistCID As New DataTable
        Try
            Me.Cursor = Cursors.WaitCursor
            MyConn.ConnectionString = My.Settings.ConnStr

            Strsql_Exist_CID = "select * from tbPerson"
            DT_ExistCID = _mssql.GetMSSQLDataTable(Strsql_Exist_CID, MyConn)

            StrExistCIDCriteria = ""
            For ExistCID = 0 To DT_ExistCID.Rows.Count - 1
                StrExistCIDCriteria = StrExistCIDCriteria & "'" & DT_ExistCID.Rows(ExistCID).Item("cid").ToString & "',"
            Next
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            With frmDebug
                Me.Cursor = Cursors.Arrow
                .MemoErr_Description.Text = "Load_Exit_CID"
                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "Load_Data"
                .MemoSQL.Text = strsql_complete
                .ShowDialog()
                Exit Sub
            End With
        End Try
        Try
            strsql_complete = "select depression_screen.screen_datetime,patient.cid,patient.hn,patient.pname,patient.fname,patient.lname,birthday,(datediff(now(),birthday) div 365) as age,pttype.nhso_code,pttype.name,vn_stat.pttypeno,vn_stat.pttype_begin,vn_stat.pttype_expire,patient.sex,patient.addrpart,patient.moopart,patient.tmbpart,patient.amppart,patient.chwpart,patient.clinic,vn_stat.pdx,patient.inregion,vn_stat.dx0,vn_stat.dx1,vn_stat.dx2,vn_stat.dx3,vn_stat.dx4,vn_stat.dx5 from depression_screen "
            strsql_complete = strsql_complete & " left outer join ovst on  depression_screen.vn = ovst.vn "
            strsql_complete = strsql_complete & " left outer join patient on ovst.hn = patient.hn"
            strsql_complete = strsql_complete & " left outer join pttype on patient.pttype = pttype.pttype"
            strsql_complete = strsql_complete & " left outer join vn_stat on depression_screen.vn = vn_stat.vn"
            strsql_complete = strsql_complete & " where screen_datetime between '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpFrom.DateTime, False) & " 00:00:00' and '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpTo.DateTime, False) & " 23:59:59' and  ((datediff(now(),birthday) div 365) >= " & NUDAGE.EditValue & ") "
            If Me.ChkNonRightCheck.Checked = False Then
                strsql_complete = strsql_complete & " and pttype_begin <> ''  and pttype_begin is not null "
            End If
            If Me.NonRightBeginDate.Checked = False Then
                strsql_complete = strsql_complete & " and vn_stat.pttypeno is not  null  and vn_stat.pttypeno <> ''  "
            End If
            If NonRightEndDate.Checked = False Then
                strsql_complete = strsql_complete & " and pttype_expire <> ''  and pttype_expire is not null  "
            End If

            'Check PDX for Chronic Diag
            strsql_complete = strsql_complete & " and left(pdx,3) in ("
            strsql_complete = strsql_complete & "'C00','C01','C02','C03','C04','C05','C06','C07','C08','C09','C10',"
            strsql = strsql_complete & "'C11','C12','C13','C14','C15','C16','C17','C18','C19','C20','C21',"
            strsql = strsql_complete & "'C22','C23','C24','C25','C26','C30','C31','C32','C33','C34','C37',"
            strsql_complete = strsql_complete & "'C38','C39','C40','C41','C43','C44','C45','C46','C47','C48','C49',"
            strsql_complete = strsql_complete & "'C50','C51','C52','C53','C54','C55','C56','C57','C58','C60','C61',"
            strsql_complete = strsql_complete & "'C62','C63','C64','C65','C66','C67','C68','C69','C70','C71','C72',"
            strsql_complete = strsql_complete & "'C73','C74','C75','C76','C77','C78','C79','C80','C81','C82','C83',"
            strsql_complete = strsql_complete & "'C84','C85','C88','C90','C91','C92','C93','C94','C95','C96','C97',"
            strsql_complete = strsql_complete & "'E10','E11','E12','E13','E14','I05','I06','I07','I08','I09','I25',"
            strsql_complete = strsql_complete & "'I27','I28','I31','I32','I34','I35','I36','I37','I38','I39','I41',"
            strsql_complete = strsql_complete & "'I42','I43','I44','I45','I47','I49','I50','I51','I52','I10','I11',"
            strsql_complete = strsql_complete & "'I12','I13','I15','I60','I61','I62','I63','I64','I65','I66','I67',"
            strsql_complete = strsql_complete & "'I68','I69','N18','N19')"

            If DT_ExistCID.Rows.Count <> 0 Then
                StrExistCIDCriteria = Mid(StrExistCIDCriteria, 1, Len(StrExistCIDCriteria) - 1)
                strsql_complete = strsql_complete & " and patient.cid not in ( " & StrExistCIDCriteria & ")"
            End If


            DT_depression_screen = _mysql.GetMYSQLDataTable(strsql_complete, "depression_screen")


            With GridPerson

                .DataSource = DT_depression_screen


            End With
            BSSTCompleteRecords.Caption = DT_depression_screen.Rows.Count

        Catch ex As Exception
            With frmDebug
                .MemoErr_Description.Text = " ex.Message"
                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "Load_Data"
                .MemoSQL.Text = strsql_complete
                .ShowDialog()
                Exit Sub
            End With
        End Try

        Try
            strsql_uncomplete = "select depression_screen.screen_datetime,patient.cid,patient.hn,patient.pname,patient.fname,patient.lname,birthday,(datediff(now(),birthday) div 365) as age,pttype.nhso_code,pttype.name,vn_stat.pttypeno,vn_stat.pttype_begin,vn_stat.pttype_expire,patient.sex,patient.addrpart,patient.moopart,patient.tmbpart,patient.amppart,patient.chwpart,patient.clinic,vn_stat.pdx,patient.inregion from depression_screen "
            strsql_uncomplete = strsql_uncomplete & " left outer join ovst on  depression_screen.vn = ovst.vn "
            strsql_uncomplete = strsql_uncomplete & " left outer join patient on ovst.hn = patient.hn"
            strsql_uncomplete = strsql_uncomplete & " left outer join pttype on patient.pttype = pttype.pttype"
            strsql_uncomplete = strsql_uncomplete & " left outer join vn_stat on depression_screen.vn = vn_stat.vn"
            strsql_uncomplete = strsql_uncomplete & " where (screen_datetime between '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpFrom.DateTime, False) & " 00:00:00' and '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpTo.DateTime, False) & " 23:59:59' and  ((datediff(now(),birthday) div 365) < " & NUDAGE.EditValue & ") )"
            If Me.ChkNonRightCheck.Checked = False Then
                'vn_stat.pttypeno  is null  
                strsql_uncomplete = strsql_uncomplete & " or  (screen_datetime between '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpFrom.DateTime, False) & " 00:00:00' and '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpTo.DateTime, False) & " 23:59:59' and  ((datediff(now(),birthday) div 365) < " & NUDAGE.EditValue & ") and  vn_stat.pttypeno  is null  )"
                'vn_stat.pttypeno = ''
                strsql_uncomplete = strsql_uncomplete & " or  (screen_datetime between '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpFrom.DateTime, False) & " 00:00:00' and '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpTo.DateTime, False) & " 23:59:59' and  ((datediff(now(),birthday) div 365) < " & NUDAGE.EditValue & ") and vn_stat.pttypeno  = ''  )"
            End If

            If Me.NonRightBeginDate.Checked = False Then
                'pttype_begin is null
                strsql_uncomplete = strsql_uncomplete & " or  (screen_datetime between '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpFrom.DateTime, False) & " 00:00:00' and '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpTo.DateTime, False) & " 23:59:59' and  ((datediff(now(),birthday) div 365) < " & NUDAGE.EditValue & ") and pttype_begin is null  )"
                'pttype_begin = ''
                strsql_uncomplete = strsql_uncomplete & " or  (screen_datetime between '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpFrom.DateTime, False) & " 00:00:00' and '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpTo.DateTime, False) & " 23:59:59' and  ((datediff(now(),birthday) div 365) < " & NUDAGE.EditValue & ") and pttype_begin  = ''  )"
            End If

            If NonRightEndDate.Checked = False Then

                'pttype_expire is null
                strsql_uncomplete = strsql_uncomplete & " or  (screen_datetime between '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpFrom.DateTime, False) & " 00:00:00' and '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpTo.DateTime, False) & " 23:59:59' and  ((datediff(now(),birthday) div 365) < " & NUDAGE.EditValue & ") and pttype_expire is null  )"
                'pttype_expire = '' 
                strsql_uncomplete = strsql_uncomplete & " or  (screen_datetime between '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpFrom.DateTime, False) & " 00:00:00' and '" & Pn_Framework.MysqlDateTimeFormat(Me.DtpTo.DateTime, False) & " 23:59:59' and  ((datediff(now(),birthday) div 365) < " & NUDAGE.EditValue & ") and pttype_expire = ''  )"
            End If

            'Check PDX for Chronic Diag
            strsql_complete = strsql_complete & " and left(pdx,3) not in ("
            strsql_complete = strsql_complete & "'C00','C01','C02','C03','C04','C05','C06','C07','C08','C09','C10',"
            strsql = strsql_complete & "'C11','C12','C13','C14','C15','C16','C17','C18','C19','C20','C21',"
            strsql = strsql_complete & "'C22','C23','C24','C25','C26','C30','C31','C32','C33','C34','C37',"
            strsql_complete = strsql_complete & "'C38','C39','C40','C41','C43','C44','C45','C46','C47','C48','C49',"
            strsql_complete = strsql_complete & "'C50','C51','C52','C53','C54','C55','C56','C57','C58','C60','C61',"
            strsql_complete = strsql_complete & "'C62','C63','C64','C65','C66','C67','C68','C69','C70','C71','C72',"
            strsql_complete = strsql_complete & "'C73','C74','C75','C76','C77','C78','C79','C80','C81','C82','C83',"
            strsql_complete = strsql_complete & "'C84','C85','C88','C90','C91','C92','C93','C94','C95','C96','C97',"
            strsql_complete = strsql_complete & "'E10','E11','E12','E13','E14','I05','I06','I07','I08','I09','I25',"
            strsql_complete = strsql_complete & "'I27','I28','I31','I32','I34','I35','I36','I37','I38','I39','I41',"
            strsql_complete = strsql_complete & "'I42','I43','I44','I45','I47','I49','I50','I51','I52','I10','I11',"
            strsql_complete = strsql_complete & "'I12','I13','I15','I60','I61','I62','I63','I64','I65','I66','I67',"
            strsql_complete = strsql_complete & "'I68','I69','N18','N19')"


            If DT_ExistCID.Rows.Count <> 0 Then
                'StrExistCIDCriteria = Mid(StrExistCIDCriteria, 1, Len(StrExistCIDCriteria) - 1)
                strsql_uncomplete = strsql_uncomplete & " and patient.cid not in ( " & StrExistCIDCriteria & ")"
            End If
            DT_depression_screenUncomplete = _mysql.GetMYSQLDataTable(strsql_uncomplete, "depression_screen")


            With GridPersonUncomplete

                .DataSource = DT_depression_screenUncomplete

            End With
            BSSTUnCompleteRecords.Caption = DT_depression_screenUncomplete.Rows.Count

        Catch ex As Exception
            With frmDebug
                .MemoErr_Description.Text = " ex.Message"
                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "Load_Data"
                .MemoSQL.Text = strsql_uncomplete
                .ShowDialog()
                Exit Sub
            End With
        End Try

        Try
            Dim Strsql_Programvalues As String = ""
            Strsql_Programvalues = "select * from tbProgrameValue"
            DT_ProgramValue = _mssql.GetMSSQLDataTable(Strsql_Programvalues, MyConn)
        Catch ex As Exception
            With frmDebug
                .MemoErr_Description.Text = ex.Message
                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "Load_Depression_Offline_Setting"
                .MemoSQL.Text = strsql_uncomplete
                .ShowDialog()
                Exit Sub
            End With
        End Try
       
        MsgBox("ดึงข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information)

    End Sub
    Function Check_Depress_Status(ByVal HN As String) As Integer
        Dim i As Integer
        Dim Curr_DS As Integer
        Try
            Dim DT_DSStatus As DataTable


            strsql = "select if(isnull(patient_depression.depression_status_id),8,patient_depression.depression_status_id) as depression_status_id from patient_depression where hn = '" & HN & "'"
            DT_DSStatus = _mysql.GetMYSQLDataTable(strsql, "patient_depression")

            If DT_DSStatus.Rows.Count <> 0 Then
                Curr_DS = _mysql.MySQLExecuteScalar(strsql)
                '  If IsDBNull(DT_DSStatus.Rows(0).Item("depression_status_id")) <> True Then

                Select Case Curr_DS
                    Case 1
                        Check_Depress_Status = 1
                    Case 2
                        Check_Depress_Status = 2
                    Case 3
                        Check_Depress_Status = 3
                    Case 4
                        Check_Depress_Status = 4
                    Case 5
                        Check_Depress_Status = 5
                    Case 6
                        Check_Depress_Status = 7
                    Case 7
                        Check_Depress_Status = 8
                    Case Else
                        Check_Depress_Status = 8

                End Select

                '  Else
                '    DepressOffline_Status = 8
                '  End If
            Else
                Check_Depress_Status = 0
            End If
        Catch ex As Exception
            With frmDebug
                .MemoErr_Description.Text = ex.Message
                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "Check_Depress_Status"
                .MemoSQL.Text = strsql
                .ShowDialog()
                Exit Function
            End With
        End Try
    End Function
    Sub Insert_Followup(ByVal ScTime As Integer, ByVal cid As String, ByVal Screendate As String, ByVal Detail9q As String, _
                        ByVal score9q As Integer, ByVal Detail8q As String, ByVal Score8q As Integer, ByVal DepressOffline_Status As Integer)
        Try
            strsql = "Insert into tbFollowup (time,cid,screendate,detail9q,score9q,detail8q,score8q,caresdetail,diag,dstatus) values "
            strsql = strsql & " (" & ScTime & ",'" & cid & "'"
            strsql = strsql & ",CONVERT(DATETIME, '" & Pn_Framework.MysqlDateTimeFormat(Screendate, False) & " 00:00:00', 102)"
            strsql = strsql & ",'" & Detail9q & "'"
            strsql = strsql & "," & score9q
            strsql = strsql & ",'" & Detail8q & "'"
            strsql = strsql & "," & Score8q & ",'110000001',0," & DepressOffline_Status & " )"
            If _mssql.Execute(strsql) > 0 Then
                CompleteCount = CompleteCount + 1
            Else
                UncompleteCount = UncompleteCount + 1
                CIDList = CIDList & cid & vbCrLf
            End If
        Catch ex As Exception
            With frmDebug
                .MemoErr_Description.Text = ex.Message
                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "Insert_Followup"
                .MemoSQL.Text = strsql
                .ShowDialog()
                Exit Sub
            End With
        End Try
    End Sub
    Function CHeck_ICD10_Chronic(ByVal ICDCode As String) As Integer
        Dim strchronicsql As String
        Try

            strchronicsql = "Select * from tbChronicDesc where chroniccode = '" & ICDCode & "'"
            MyConn.ConnectionString = My.Settings.ConnStr
            Dim DT_ICD10 As DataTable
            DT_ICD10 = _mssql.GetMSSQLDataTable(strchronicsql, MyConn, "ChronicDesc")
            If DT_ICD10.Rows.Count = 0 Then
                CHeck_ICD10_Chronic = 0
                Exit Function
            Else
                CHeck_ICD10_Chronic = DT_ICD10.Rows(0).Item("chronicid")

            End If


        Catch ex As Exception
            With frmDebug
                .MemoErr_Description.Text = ex.Message
                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "CHeck_ICD10_Chronic"
                .MemoSQL.Text = strchronicsql
                .ShowDialog()
                Exit Function
            End With
        End Try
    End Function
#End Region
    Private Sub frmHOSxPScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DtpFrom.DateTime = Now
        Me.DtpTo.DateTime = Now
    End Sub


    Private Sub GridPerson_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GridPersonUncomplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPersonUncomplete.Click

    End Sub

    Private Sub BtnImporttoDepress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImporttoDepress.Click
        Try
            If DT_ProgramValue.Rows.Count = 0 Then
                MsgBox("กรุณาตั้งค่าสถานบริการในโปรแกรม Depression Office ก่อน", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If DT_depression_screen.Rows.Count = 0 Then
                MsgBox("ไม่พบข้อมูลนำเข้า", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If (MsgBox("คุณต้องการนำเข้าข้อมูลจาก HOSxP ใช่หรือไม่", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")) = MsgBoxResult.No Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            'Dim BirthDate As Date = DT_depression_screen.Rows(0).Item("birthday").ToString
            'Dim Pttype_Begin As Date = DT_depression_screen.Rows(0).Item("pttype_begin").ToString()
            'Dim Pttype_Expire As Date = DT_depression_screen.Rows(0).Item("pttype_expire").ToString()
            Dim CompleteCount As Integer = 0
            Dim CIDList As String = ""

            Dim UncompleteCount As Integer = 0
            'strsql = "select [tbScreen].cid,prename,[tbPerson].firstname ,[tbPerson].lastname ,datediff(d, [tbPerson].birthday, getdate())  as age,[tbPerson].cardtype ,[tbPerson].cardid ,[tbPerson].mfgdate ,[tbPerson].expdate ,[tbPerson].birthday ,[tbPerson].province ,[tbScreen].score2q,[tbScreen].screendate ,[tbScreen].detail2q,onserver    from [tbScreen] left join [tbPerson] on [tbScreen].cid = [tbPerson].cid where datediff(d, [tbPerson].birthday, getdate()) >=60 and expdate is not null and cardid is not null and cardid <> '' AND onserver='1'"


            Dim Curr_CID As String = ""

            For i As Integer = 0 To DT_depression_screen.Rows.Count - 1
                If Curr_CID <> DT_depression_screen.Rows(i).Item("cid").ToString Then

                    Curr_CID = DT_depression_screen.Rows(i).Item("cid").ToString
                    strsql = "insert into tbPerson (pcucode,cid,prename,firstname,lastname,cardtype,cardid,mfgdate,expdate,birthday,gender,village,address,subdistrict,district,province,r1,r2,r3,r4,r5,ro,lastupdate,onserver) values "
                    strsql = strsql & " ('" & DT_ProgramValue.Rows(0).Item("pcucode").ToString & "'"
                    strsql = strsql & " ,'" & DT_depression_screen.Rows(i).Item("cid").ToString & "'"
                    strsql = strsql & " ,'" & DT_depression_screen.Rows(i).Item("pname").ToString() & "'"
                    strsql = strsql & " ,'" & DT_depression_screen.Rows(i).Item("fname").ToString() & "'"
                    strsql = strsql & " ,'" & DT_depression_screen.Rows(i).Item("lname").ToString() & "'"
                    strsql = strsql & " ,'" & DT_depression_screen.Rows(i).Item("nhso_code").ToString() & "'"
                    strsql = strsql & " ,'" & DT_depression_screen.Rows(i).Item("pttypeno").ToString() & "'"
                    strsql = strsql & " ,CONVERT(DATETIME, '" & Pn_Framework.MysqlDateTimeFormat(DT_depression_screen.Rows(i).Item("pttype_begin").ToString, False) & " 00:00:00', 102)"
                    strsql = strsql & " ,CONVERT(DATETIME, '" & Pn_Framework.MysqlDateTimeFormat(DT_depression_screen.Rows(i).Item("pttype_expire").ToString, False) & " 00:00:00', 102)"
                    strsql = strsql & " ,CONVERT(DATETIME, '" & Pn_Framework.MysqlDateTimeFormat(DT_depression_screen.Rows(i).Item("birthday").ToString, False) & " 00:00:00', 102)"
                    strsql = strsql & " ," & DT_depression_screen.Rows(i).Item("sex").ToString() & ""
                    strsql = strsql & " ,'" & DT_depression_screen.Rows(i).Item("moopart").ToString() & "'"
                    strsql = strsql & " ,'" & DT_depression_screen.Rows(i).Item("addrpart").ToString() & "'"
                    strsql = strsql & " ,'" & DT_depression_screen.Rows(i).Item("tmbpart").ToString() & "'"
                    strsql = strsql & " ,'" & DT_depression_screen.Rows(i).Item("amppart").ToString() & "'"
                    strsql = strsql & " ,'" & DT_depression_screen.Rows(i).Item("chwpart").ToString() & "'"
                    Dim Chronicid As String = Mid(DT_depression_screen.Rows(i).Item("pdx").ToString(), 1, 3) & "."
                    Select Case CHeck_ICD10_Chronic(Chronicid)
                        Case 3
                            'r1
                            strsql = strsql & " ,'" & Mid(DT_depression_screen.Rows(i).Item("pdx").ToString(), 1, 3) & ".','0','0','0','0'"
                        Case 7

                            'r2
                            strsql = strsql & ",'0','" & Mid(DT_depression_screen.Rows(i).Item("pdx").ToString(), 1, 3) & ".','0','0','0'"
                        Case 2
                            'r3
                            strsql = strsql & ",'0','0','" & Mid(DT_depression_screen.Rows(i).Item("pdx").ToString(), 1, 3) & ".','0','0'"
                        Case 4
                            'r4
                            strsql = strsql & ",'0','0','0','" & Mid(DT_depression_screen.Rows(i).Item("pdx").ToString(), 1, 3) & ".','0'"
                        Case 6
                            'r5
                            strsql = strsql & ",'0','0','0','0','" & Mid(DT_depression_screen.Rows(i).Item("pdx").ToString(), 1, 3) & ".'"
                        Case Else
                            strsql = strsql & ",'0','0','0','0','0'"
                    End Select


                    strsql = strsql & ",'0000001' "
                    strsql = strsql & ",CONVERT(DATETIME, '" & Pn_Framework.MysqlDateTimeFormat(Now.Date, False) & " 00:00:00', 102),1)"

                    Dim ResualSQL As String = _mssql.Execute(strsql, True)

                    If ResualSQL = "1" Then
                        CompleteCount = CompleteCount + 1
                    Else
                        UncompleteCount = UncompleteCount + 1
                        CIDList = CIDList & DT_depression_screen.Rows(i).Item("cid").ToString & vbCrLf & " Desc : " & ResualSQL & vbCrLf

                    End If
                End If
            Next

            MsgBoxImport.lblComplete.Text = CompleteCount
            MsgBoxImport.lblUncomplete.Text = UncompleteCount
            MsgBoxImport.lbltotalrows.Text = DT_depression_screen.Rows.Count
            MsgBoxImport.MemoCID.Text = CIDList
            MsgBoxImport.ShowDialog()
            Me.BtnImporttoDepress.Enabled = False
            Me.Cursor = Cursors.Arrow
            'MsgBox("เพิ่มข้อมูลสำเร็จ " & CompleteCount & " คน จากทั้งหมด" & DT_depression_screen.Rows.Count & " คน", MsgBoxStyle.Information)
            ' Debug.Print(strsql)

        Catch ex As Exception
            With frmDebug
                Me.Cursor = Cursors.Arrow
                .MemoErr_Description.Text = ex.Message
                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "BtnImporttoDepress_Click"
                .MemoSQL.Text = strsql
                .ShowDialog()
                Exit Sub
            End With
        End Try





    End Sub

    Private Sub GridPerson_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPerson.Click

    End Sub

    Private Sub GridView1_CustomRowCellEdit(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles GridView1.CustomRowCellEdit

    End Sub

    Private Sub GridView1_CustomRowCellEditForEditing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles GridView1.CustomRowCellEditForEditing
        Try
            'If e.Column.FieldName = "Totalrows" Then Return
            Dim Gv As GridView = sender
            Dim CodeName As String = Gv.GetRowCellValue(e.RowHandle, _
              Gv.Columns("cid")).ToString()
            Selected_CID = CodeName


        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnImport2Q_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImport2Q.Click
        Dim CompleteCount As Integer = 0
        Dim CIDList As String = ""
        Dim DT2Q As New DataTable
        Dim UncompleteCount As Integer = 0
        Dim Strsql2Q As String
        Dim StrCID As String = ""
        If DT_ProgramValue.Rows.Count = 0 Then
            MsgBox("กรุณาตั้งค่าสถานบริการในโปรแกรม Depression Office ก่อน", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If DT_depression_screen.Rows.Count = 0 Then
            MsgBox("ไม่พบข้อมูลนำเข้า", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If (MsgBox("คุณต้องการนำเข้าข้อมูลจาก HOSxP ใช่หรือไม่", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")) = MsgBoxResult.No Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Try

            Strsql2Q = "select depression_screen_evaluate_id as time,patient.cid,screen_datetime as screendate,concat(if(feel_depression_2_week='Y','1','0'),if(feel_boring_2_week='Y','1','0')) as detail2q, (if(feel_depression_2_week='Y',1,0)+if(feel_boring_2_week='Y',1,0))  as score2q "
            Strsql2Q = Strsql2Q & " from(depression_screen)"
            Strsql2Q = Strsql2Q & " left join vn_stat on depression_screen.vn = vn_stat.vn"
            Strsql2Q = Strsql2Q & " left join patient on vn_stat.hn = patient.hn"
            Strsql2Q = Strsql2Q & " where patient.cid in ("
            For j As Integer = 0 To DT_depression_screen.Rows.Count - 1
                StrCID = StrCID & "'" & DT_depression_screen.Rows(j).Item("cid").ToString() & "'"
                If j <> DT_depression_screen.Rows.Count - 1 Then StrCID = StrCID & ","
            Next

            Strsql2Q = Strsql2Q & StrCID & ") order by patient.cid,depression_screen_evaluate_id"


            DT2Q = _mysql.GetMYSQLDataTable(Strsql2Q, "depression_screen")
        Catch ex As Exception

            With frmDebug
                Me.Cursor = Cursors.Arrow
                .MemoErr_Description.Text = ex.Message

                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "BtnImport2Q_Click"
                .MemoSQL.Text = strsql
                .ShowDialog()
            End With
        End Try

      
        Try
            For i As Integer = 0 To DT2Q.Rows.Count - 1
                strsql = "Insert into tbScreen (time,cid,screendate,detail2q,score2q) values "
                strsql = strsql & " (" & DT2Q.Rows(i).Item("time") & ",'" & DT2Q.Rows(i).Item("cid") & "'"
                strsql = strsql & ",CONVERT(DATETIME, '" & Pn_Framework.MysqlDateTimeFormat(DT2Q.Rows(i).Item("screendate").ToString, False) & " 00:00:00', 102)"
                strsql = strsql & ",'" & DT2Q.Rows(i).Item("detail2q").ToString & "'"
                strsql = strsql & "," & DT2Q.Rows(i).Item("score2q") & ")"
                If _mssql.Execute(strsql) > 0 Then
                    CompleteCount = CompleteCount + 1
                Else
                    UncompleteCount = UncompleteCount + 1
                    CIDList = CIDList & DT_depression_screen.Rows(i).Item("cid").ToString & vbCrLf

                End If
            Next

            MsgBoxImport.lblComplete.Text = CompleteCount
            MsgBoxImport.lblUncomplete.Text = UncompleteCount
            MsgBoxImport.lbltotalrows.Text = DT2Q.Rows.Count
            MsgBoxImport.MemoCID.Text = CIDList
            MsgBoxImport.ShowDialog()
            Me.BtnImport2Q.Enabled = False
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            With frmDebug
                Me.Cursor = Cursors.Arrow
                .MemoErr_Description.Text = ex.Message

                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "BtnImport2Q_Click"
                .MemoSQL.Text = strsql
                .ShowDialog()
            End With
        End Try
    End Sub

    Private Sub BtnImportFollowup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportFollowup.Click


        Dim DT89Q As New DataTable

        Dim Strsql89Q As String
        Dim HOSxPDepress_Status As String
        Dim DepressOffline_Status As Integer
        Dim i As Integer
        Dim j As Integer
        Dim Mydetail9q As String
        frmDebug.MemoCallStack.Text = ""


        If DT_ProgramValue.Rows.Count = 0 Then
            MsgBox("กรุณาตั้งค่าสถานบริการในโปรแกรม Depression Office ก่อน", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If DT_depression_screen.Rows.Count = 0 Then
            MsgBox("ไม่พบข้อมูลนำเข้า", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If (MsgBox("คุณต้องการนำเข้าข้อมูลจาก HOSxP ใช่หรือไม่", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")) = MsgBoxResult.No Then Exit Sub

        Me.Cursor = Cursors.WaitCursor
        Try
            Dim StrCID As String = ""
            Strsql89Q = "SELECT depression_screen.depression_screen_evaluate_id as time,"
            Strsql89Q = Strsql89Q & " patient.cid,"
            Strsql89Q = Strsql89Q & " depression_screen.screen_datetime as screendate,"
            Strsql89Q = Strsql89Q & " concat(depression_screen.score_9q_1,"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_2,"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_3,"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_4,"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_5,"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_6,"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_7,"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_8,"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_9) as detail9q,"
            Strsql89Q = Strsql89Q & " (depression_screen.score_9q_1+"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_2+"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_3+"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_4+"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_5+"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_6+"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_7+"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_8+"
            Strsql89Q = Strsql89Q & " depression_screen.score_9q_9) as score9q,"
            Strsql89Q = Strsql89Q & " concat(if(depression_screen.score_8q_1>0,'1','0'),if(depression_screen.score_8q_2>0,'1','0'),if(depression_screen.score_8q_4>0,'1','0'),if(depression_screen.score_8q_5>0,'1','0'),if(depression_screen.score_8q_6>0,'1','0'),if(depression_screen.score_8q_7>0,'1','0'),if(depression_screen.score_8q_8>0,'1','0'),if(depression_screen.score_8q_9>0,'1','0')) AS detail8q,"
            Strsql89Q = Strsql89Q & " (if(depression_screen.score_8q_1>0,1,0)+if(depression_screen.score_8q_2>0,2,0)+if(depression_screen.score_8q_4>0,6,0)+if(depression_screen.score_8q_5>0,8,0)+if(depression_screen.score_8q_6>0,9,0)+if(depression_screen.score_8q_7>0,4,0)+if(depression_screen.score_8q_8>0,10,0)+if(depression_screen.score_8q_9>0,4,0)) AS score8q,"
            Strsql89Q = Strsql89Q & " '110000001' as caresdetail,"
            Strsql89Q = Strsql89Q & " 0 as diag,"
            Strsql89Q = Strsql89Q & " 8 as dstatus"
            Strsql89Q = Strsql89Q & " from (depression_screen)"
            Strsql89Q = Strsql89Q & " left join vn_stat on depression_screen.vn = vn_stat.vn"
            Strsql89Q = Strsql89Q & " left join patient on vn_stat.hn = patient.hn"
            Strsql89Q = Strsql89Q & "  where patient.cid in ("
            For j = 0 To DT_depression_screen.Rows.Count - 1
                StrCID = StrCID & "'" & DT_depression_screen.Rows(j).Item("cid").ToString() & "'"
                If j <> DT_depression_screen.Rows.Count - 1 Then StrCID = StrCID & ","
            Next

            Strsql89Q = Strsql89Q & StrCID & ") order by patient.cid,depression_screen_evaluate_id"
            DT89Q = _mysql.GetMYSQLDataTable(Strsql89Q, "depression_screen")

        Catch ex As Exception
            With frmDebug
                Me.Cursor = Cursors.Arrow
                .MemoErr_Description.Text = ex.Message

                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "BtnImportFollowup_Click"
                .MemoSQL.Text = Strsql89Q
                .ShowDialog()
            End With
        End Try

        If DT89Q.Rows.Count = 0 Then
            MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try

       
        For i = 0 To DT89Q.Rows.Count - 1
            If i = DT89Q.Rows.Count Then Exit For

            DepressOffline_Status = Check_Depress_Status(DT_depression_screen.Rows(i).Item("hn").ToString)

            With DT89Q.Rows(i)

                    frmDebug.MemoCallStack.Text = " i = (" & i & "/" & DT89Q.Rows.Count - 1 & ")" & vbCrLf


                    frmDebug.MemoCallStack.Text = frmDebug.MemoCallStack.Text & " time = " & .Item("time").ToString & vbCrLf
                frmDebug.MemoCallStack.Text = frmDebug.MemoCallStack.Text & " cid = " & .Item("cid").ToString & vbCrLf
                frmDebug.MemoCallStack.Text = frmDebug.MemoCallStack.Text & " screendate = " & .Item("screendate").ToString & vbCrLf
                frmDebug.MemoCallStack.Text = frmDebug.MemoCallStack.Text & " detail9q = " & .Item("detail9q").ToString & vbCrLf
                frmDebug.MemoCallStack.Text = frmDebug.MemoCallStack.Text & " score9q = " & .Item("score9q") & vbCrLf
                frmDebug.MemoCallStack.Text = frmDebug.MemoCallStack.Text & " detail8q = " & .Item("detail8q").ToString & vbCrLf
                frmDebug.MemoCallStack.Text = frmDebug.MemoCallStack.Text & " score8q = " & .Item("score8q").ToString & vbCrLf
                frmDebug.MemoCallStack.Text = frmDebug.MemoCallStack.Text & " DepressOffline_Status = " & DepressOffline_Status & vbCrLf
                Insert_Followup(.Item("time"), .Item("cid").ToString, .Item("screendate").ToString, .Item("detail9q").ToString, .Item("score9q"), .Item("detail8q").ToString, .Item("score8q"), DepressOffline_Status)
            End With
        Next
        Catch ex As Exception
            With frmDebug
                Me.Cursor = Cursors.Arrow
                .MemoErr_Description.Text = ex.Message
                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "BtnImportFollowup_Click (Loop FOr DT89Q)"
                .MemoSQL.Text = Strsql89Q
                .ShowDialog()
            End With
        End Try
        MsgBoxImport.lblComplete.Text = CompleteCount
        MsgBoxImport.lblUncomplete.Text = UncompleteCount
        MsgBoxImport.lbltotalrows.Text = DT89Q.Rows.Count
        MsgBoxImport.MemoCID.Text = CIDList
        MsgBoxImport.ShowDialog()
        Me.BtnImportFollowup.Enabled = False
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        If e.Column.FieldName = "" Then
            e.DisplayText = e.RowHandle.ToString + 1
        End If
    End Sub

    Private Sub BtnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoad.Click
        Load_data()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub PanelControl2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelControl2.Paint

    End Sub

    Private Sub SpinEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUDAGE.EditValueChanged

    End Sub

    Private Sub BtnNotCompleteExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotCompleteExcel.Click

        If MsgBox("คุณต้องการส่งออกข้อมูลเป็น Excel หรือไม่", MsgBoxStyle.Question + vbYesNo, "ยืนยันการส่งออก") = vbYesNo Then Exit Sub

        With SaveFileDialog1
            .Title = "Save As"
            .FileName = "ExportData"
            .Filter = "Excel Files (*.xls)|*.xls"
            If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
            GridPersonUncomplete.ExportToXls(.FileName)
        End With
    End Sub

    Private Sub BtnExportCompleteExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportCompleteExcel.Click
        If MsgBox("คุณต้องการส่งออกข้อมูลเป็น Excel หรือไม่", MsgBoxStyle.Question + vbYesNo, "ยืนยันการส่งออก") = vbYesNo Then Exit Sub

        With SaveFileDialog1
            .Title = "Save As"
            .FileName = "ExportData"
            .Filter = "Excel Files (*.xls)|*.xls"
            If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
            GridPerson.ExportToXls(.FileName)
        End With
    End Sub
End Class