Imports FastReport.Report
Public Class frmPreviewReport
    Dim Strsql As String
    Dim _mysql As New mysqlhelper
    Public Report_Name As String
    Public Primary_Key As Integer
    Private Sub frmPreviewReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Strsql = "select * from report_template where report_id = " & Primary_Key
            Dim DT_RptTemplate As New DataTable
            DT_RptTemplate = _mysql.GetMYSQLDataTable(Strsql, "report_template")
            If DT_RptTemplate.Rows.Count = 0 Then
                MsgBox("ไม่พบ Report ที่ต้องการ", MsgBoxStyle.Critical, "กรุณาติดต่อ Admin")
                Exit Sub

            End If

            Strsql = DT_RptTemplate.Rows(0).Item("report_sql").ToString

            Dim DS_Documents As New DataSet
            DS_Documents = _mysql.GetMYSQLDataset(Strsql, "IDM", "reporttemplate")
            Dim report1 As New FastReport.Report


            report1.Preview = PreviewControl2
            report1.Load(My.Settings.ReportPath & Report_Name & ".frx")


            report1.AutoFillDataSet = True

            report1.RegisterData(DS_Documents)

            report1.GetDataSource("reporttemplate").Enabled = True

            report1.Refresh()
            report1.Show()

            Me.Text = Report_Name


        Catch ex As Exception
            With frmDebug
                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "BtnPrint_Click"
                .MemoErr_Description.Text = ex.Message
                .MemoSQL.Text = Strsql
                .ShowDialog()
            End With
        End Try

    End Sub

End Class