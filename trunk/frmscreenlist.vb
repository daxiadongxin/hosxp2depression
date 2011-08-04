Public Class frmscreenlist
    Dim Strsql As String
    Dim _mssql As New ClsSQLhelper
    Dim MyConn As New SqlClient.SqlConnection
#Region "Function"
    Sub Load_Data()
        Try
            Strsql = "select [tbScreen].cid,[tbPerson].Prename,[tbPerson].firstname ,[tbPerson].lastname ,datediff(YY, [tbPerson].birthday, getdate())  as age"
            Strsql = Strsql & " ,[tbPerson].cardtype,[tbcardtype].ctypename ,[tbPerson].cardid ,[tbPerson].mfgdate ,[tbPerson].expdate ,[tbPerson].birthday ,"
            Strsql = Strsql & " [tbScreen].screendate,[tbScreen].score2q, tbFollowup.score9q, tbFollowup.score8q  "
            Strsql = Strsql & " from [tbScreen] "
            Strsql = Strsql & " left join [tbPerson] on [tbScreen].cid = [tbPerson].cid  "
            Strsql = Strsql & " left join tbcardtype on [tbPerson].cardtype  = [tbcardtype].cardtype  "
            Strsql = Strsql & " left join tbFollowup ON tbScreen.screendate = tbFollowup.screendate AND tbScreen.cid = tbFollowup.cid"
            Strsql = Strsql & " where datediff(d, [tbPerson].birthday, getdate()) >=60 and expdate is not null and cardid is not null and cardid <> '' order by [tbPerson].firstname ,[tbPerson].lastname,screendate"

            Dim DT_Person As New DataTable
            DT_Person = _mssql.GetMSSQLDataTable(Strsql, MyConn, "Person")
            With GridPerson
                .DataSource = Nothing
                .DataSource = DT_Person
                TxtTotalCompleteRows.Text = DT_Person.Rows.Count
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Sub Load_UncomplateData()
    '    Try
    '        Strsql = "select [tbScreen].cid,[tbPerson].Prename,[tbPerson].firstname ,[tbPerson].lastname ,datediff(YY, [tbPerson].birthday, getdate())  as age,[tbPerson].cardtype,[tbcardtype].ctypename ,[tbPerson].cardid ,[tbPerson].mfgdate ,[tbPerson].expdate ,[tbPerson].birthday ,[tbScreen].screendate     from [tbScreen] left join [tbPerson] on [tbScreen].cid = [tbPerson].cid  left join tbcardtype on [tbPerson].cardtype  = [tbcardtype].cardtype  where datediff(d, [tbPerson].birthday, getdate()) <60 "
    '        Dim DT_UnCompletePerson As New DataTable
    '        DT_UnCompletePerson = _mssql.GetMSSQLDataTable(Strsql, MyConn, "Person")
    '        With GridPersonUncomplete
    '            .DataSource = Nothing
    '            .DataSource = DT_UnCompletePerson
    '            Me.TxtTotalUnCompleteRows.Text = DT_UnCompletePerson.Rows.Count
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
#End Region
    Private Sub frmscreenlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyConn.ConnectionString = My.Settings.ConnStr
        Load_Data()
        '(Load_UncomplateData())
    End Sub

  
    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        If e.Column.FieldName = "" Then
            e.DisplayText = e.RowHandle.ToString + 1
        End If
    End Sub

    Private Sub BtnNotCompleteExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotCompleteExcel.Click
        If MsgBox("คุณต้องการส่งออกข้อมูลเป็น Excel หรือไม่", MsgBoxStyle.Question + vbYesNo, "ยืนยันการส่งออก") = vbYesNo Then Exit Sub

        With SaveFileDialog1
            .Title = "Save As"
            .FileName = "ExportData"
            .Filter = "Excel Files (*.xls)|*.xls"
            If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub


            GridPerson.ExportToXls(.FileName)
        End With
    End Sub

    Private Sub LabelControl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl3.Click

    End Sub

    Private Sub LabelControl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl2.Click

    End Sub

    Private Sub TxtTotalCompleteRows_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotalCompleteRows.EditValueChanged

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Dispose()
    End Sub
End Class