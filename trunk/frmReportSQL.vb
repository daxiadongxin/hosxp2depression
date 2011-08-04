'Imports FastReport.Utils
Imports System.IO
Imports FastReport
Imports FastReport.Utils

Public Class frmReportSQL
    Dim strsql As String
    Dim _mysql As New mysqlhelper
    Public Report_ID As Integer
    Dim Rpt_Form As String
#Region "Function"
    Function Varidate_SQL() As Boolean
        Try
            If Me.MemoSQL.Text = "" Then
                Varidate_SQL = False
                MsgBox("กรุณาใส่คำสั่ง SQL", MsgBoxStyle.Critical, "ขออภัย")
                Exit Function
            End If
            If InStr(Me.MemoSQL.Text, "insert ", CompareMethod.Text) > 0 Then
                Varidate_SQL = False
                MsgBox("อนุญาติให้ใช้เฉพาะคำสั่ง Select เท่านั้น", MsgBoxStyle.Critical, "ขออภัย")
                Exit Function
            End If

            If InStr(Me.MemoSQL.Text, "Delete ", CompareMethod.Text) > 0 Then
                Varidate_SQL = False
                MsgBox("อนุญาติให้ใช้เฉพาะคำสั่ง Select เท่านั้น", MsgBoxStyle.Critical, "ขออภัย")
                Exit Function
            End If

            If InStr(Me.MemoSQL.Text, "Update ", CompareMethod.Text) > 0 Then
                Varidate_SQL = False
                MsgBox("อนุญาติให้ใช้เฉพาะคำสั่ง Select เท่านั้น", MsgBoxStyle.Critical, "ขออภัย")
                Exit Function
            End If

            If InStr(Me.MemoSQL.Text, "Select ", CompareMethod.Text) = 0 Then
                Varidate_SQL = False
                MsgBox("อนุญาติให้ใช้เฉพาะคำสั่ง Select เท่านั้น", MsgBoxStyle.Critical, "ขออภัย")
                Exit Function
            End If

            If Report_ID = -1 Then
                strsql = "Select count(*) as cc from report_template where report_name = '" & Me.TxtRptName.Text & "'"
                If _mysql.MySQLExecuteScalar(strsql) > 0 Then
                    Varidate_SQL = False
                    MsgBox("ชื่อ Report นี้มีอยู่แล้ว", MsgBoxStyle.Critical, "ขออภัย")
                    Exit Function
                End If
            End If


            Dim DT_Test As New DataTable
            DT_Test = _mysql.GetMYSQLDataTable(Me.MemoSQL.Text, "test")
            If DT_Test.Rows.Count >= 0 Then
                With GridControl1
                    .DataSource = Nothing
                    GridView1.Columns.Clear()
                    .Refresh()
                    .DataSource = DT_Test
                    .Refresh()
                End With
                strsql = Me.MemoSQL.Text
                Varidate_SQL = True
            Else
                Varidate_SQL = False
                MsgBox("อนุญาติให้ใช้เฉพาะคำสั่ง Select เท่านั้น", MsgBoxStyle.Critical, "ขออภัย")
                Exit Function

            End If
        Catch ex As Exception
            Varidate_SQL = False
            If Err.Number = 60002 Then

                MsgBox("คำสั่ง sql ไม่ถูกต้อง", MsgBoxStyle.Critical, "ขออภัย")
                Exit Function
            End If
            MsgBox(Err.Number & " : " & ex.Message)
        End Try
    End Function

    Sub Load_SQL()
        Try
            strsql = "SELECT report_id,report_name,report_formname,report_filename,report_group,report_sql from report_template where report_id = " & Report_ID
            Dim DT_Report As New DataTable
            DT_Report = _mysql.GetMYSQLDataTable(strsql, "report_list")
            With MemoSQL
                .Text = DT_Report.Rows(0).Item("report_sql").ToString
                Rpt_Form = DT_Report.Rows(0).Item("report_filename").ToString
                strsql = DT_Report.Rows(0).Item("report_sql").ToString
            End With

            Dim DT_Test As New DataTable
            DT_Test = _mysql.GetMYSQLDataTable(strsql, "test")
            If DT_Test.Rows.Count >= 0 Then

                With GridControl1
                    .DataSource = DT_Test

                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub frmReportSQL_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Me.TxtRptName.Text = "" Or Me.MemoSQL.Text = "" Or Me.BtnDesign.Enabled = False Then Exit Sub



            Select Case Report_ID
                Case -1
                    If MsgBox("คุณต้องเพิ่ม Report นี้เข้าในระบบหรือไม่ ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยันการเพิ่ม Report") = MsgBoxResult.No Then



                        Dim fName As String = Me.TxtRptName.Text & ".frx"
                        If File.Exists(fName) Then
                            File.Delete(fName)
                        End If

                        e.Cancel = True

                    Else
                        e.Cancel = False
                        Dim TempSQL As String
                        TempSQL = Replace(Me.MemoSQL.Text, "`", "")
                        TempSQL = Replace(Me.MemoSQL.Text, "'", "''")
                        strsql = "Insert into report_template (report_name,report_filename,report_group,report_sql) values ('" & Me.TxtRptName.Text & "','" & Me.TxtRptName.Text & ".frx" & "',1,'" & TempSQL & "')"
                        _mysql.MySQLExecute(strsql)

                    End If
                Case Is > 0

                    If MsgBox("คุณต้องแก้ไข Report นี้หรือไม่ ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยันการแก้ไข Report") = MsgBoxResult.No Then
                        Me.Dispose()
                        e.Cancel = True
                    Else
                        e.Cancel = False
                        Dim TempSQL As String
                        TempSQL = Replace(Me.MemoSQL.Text, "`", "")
                        TempSQL = Replace(Me.MemoSQL.Text, "'", "''")
                        strsql = "Update report_template set report_name='" & Me.TxtRptName.Text & "',report_filename = '" & Me.TxtRptName.Text & ".frx" & "',report_group = 1,report_sql= '" & TempSQL & "' where report_id = " & Report_ID
                        _mysql.MySQLExecute(strsql)
                    End If
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub frmReportSQL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Report_ID <> -1 Then
            Load_SQL()
            Me.TxtRptName.ReadOnly = True
        End If
    End Sub


    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub



    Private Sub BtnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTest.Click
        If Varidate_SQL() = False Then Exit Sub

        Me.BtnDesign.Enabled = True
    End Sub



    Private Sub BtnDesign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDesign.Click
        Try

            If Me.TxtRptName.Text = "" Then
                MsgBox("กรุณาใส่ชื่อรายงาน", MsgBoxStyle.Critical, "คำเตือน")
                Exit Sub
            End If

            Dim DS_Documents As New DataSet
            DS_Documents = _mysql.GetMYSQLDataset(strsql, "IDM", "reporttemplate")


            If Report_ID = -1 Then
                Dim ReportPage As New FastReport.ReportPage
                With ReportPage
                    '  .CreateUniqueName()
                    .Name = "Page1"
                    Report1.Pages.Add(ReportPage)
                    ReportPage.ReportTitle = New FastReport.ReportTitleBand
                    ReportPage.ReportTitle.CreateUniqueName()
                    ReportPage.ReportTitle.Height = 1 * Units.Centimeters

                    ReportPage.PageHeader = New FastReport.PageHeaderBand
                    ReportPage.PageHeader.CreateUniqueName()
                    ReportPage.PageHeader.Height = 0.75 * Units.Centimeters

                    Dim Band As New FastReport.DataBand
                    ReportPage.Bands.Add(Band)
                    Band.CreateUniqueName()
                    Band.Height = 2 * Units.Centimeters

                    ReportPage.PageFooter = New FastReport.PageFooterBand
                    ReportPage.PageFooter.CreateUniqueName()
                    ReportPage.PageFooter.Height = 0.5 * Units.Centimeters

                    Report1.Save(My.Settings.ReportPath & Me.TxtRptName.Text & ".frx")
                    Rpt_Form = Me.TxtRptName.Text & ".frx"

                End With
            End If

            If Report_ID <> -1 Then
                Report1.Load(My.Settings.ReportPath & Rpt_Form)
            End If

            Report1.AutoFillDataSet = True

            Report1.RegisterData(DS_Documents)
            ' If Report_ID = -1 Then
            Report1.GetDataSource("reporttemplate").Enabled = True
            ' End If
            Report1.Refresh()
            Report1.Design()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MemoSQL_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.BtnDesign.Enabled = False
    End Sub


End Class