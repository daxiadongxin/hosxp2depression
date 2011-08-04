Imports System.IO
Public Class frmReportList
    Dim Flg_Onload As Boolean = True
    Dim strsql As String
    Dim _mysql As New mysqlhelper
    Dim Report_ID As Integer = 1
    Dim Report_Name As String
    Dim Group_ID As Integer = 1
    Dim Report_GroupName As String
    Dim Old_Group_ID As Integer
    Dim DT_Reportlist As New DataTable

#Region "Function"
    Sub Load_Group()
        Try
            strsql = "SELECT report_group_id,report_group_name from report_group"
            Dim DT_Report As New DataTable
            DT_Report = _mysql.GetMYSQLDataTable(strsql, "report_group")
            With Me.ListGroup
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = DT_Report
                .DisplayMember = "report_group_name"
                .ValueMember = "report_group_id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            strsql = "SELECT report_id,report_name,report_formname,report_filename,report_group from report_template where report_group = 1"
            ' Dim DT_Reportlist As New DataTable
            DT_Reportlist = _mysql.GetMYSQLDataTable(strsql, "report_template")
            With Me.ListReport
                .DataSource = Nothing
                .Items.Clear()
                .DataSource = DT_Reportlist
                .DisplayMember = "report_name"
                .ValueMember = "report_id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub Load_Report()
        Try
            strsql = "SELECT report_id,report_name,report_formname,report_filename,report_group from report_template where report_group = 1"

            DT_Reportlist = _mysql.GetMYSQLDataTable(strsql, "report_template")
            With Me.ListReport
                .DataSource = DT_Reportlist
                .DisplayMember = "report_name"
                .ValueMember = "report_id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
#End Region
    Private Sub frmReportList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Group()
        Flg_Onload = False
        Report_Name = ListReport.Text
        Report_GroupName = Me.ListGroup.Text
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Dispose()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        With frmReportSQL

            ' MsgBox(Report_ID & " " & ListReport.Text)
            If DT_Reportlist.Rows.Count = 0 Then Exit Sub

            If Report_ID <> -1 Then

            Else
                Report_ID = DT_Reportlist.Rows(0).Item("report_id")
                Report_Name = DT_Reportlist.Rows(0).Item("report_name").ToString
            End If

            .Report_ID = Report_ID
            .TxtRptName.Text = Report_Name

            .MdiParent = frmmain
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub ListReport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListReport.SelectedIndexChanged
        If Flg_Onload = True Then Exit Sub
        Report_ID = Me.ListReport.SelectedValue
        Report_Name = ListReport.Text

    End Sub

    Private Sub ListGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListGroup.SelectedIndexChanged
        If Flg_Onload = True Then Exit Sub
        Old_Group_ID = Group_ID
        Report_GroupName = Me.ListGroup.Text
        Group_ID = Me.ListGroup.SelectedValue
        Try
            If Old_Group_ID <> Group_ID Then
                Load_Group()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnNewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewReport.Click
        With frmReportSQL
            .Report_ID = -1
            .MdiParent = frmmain
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub


    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            If DT_Reportlist.Rows.Count = 0 Then Exit Sub
            If Report_ID <> -1 Then

            Else

                Report_ID = DT_Reportlist.Rows(0).Item("report_id")
                Report_Name = DT_Reportlist.Rows(0).Item("report_name").ToString
            End If

            Dim fName As String = ""
            strsql = "SELECT report_id,report_name,report_formname,report_filename,report_group from report_template where report_id = " & Report_ID
            'Dim DT_Reportlist As New DataTable
            DT_Reportlist = _mysql.GetMYSQLDataTable(strsql, "report_template")

            fName = DT_Reportlist.Rows(0).Item("report_filename").ToString()

            If File.Exists(fName) Then
                File.Delete(fName)
            End If


            If (MsgBox("คุณต้องการลบ รายงาน " & Report_Name & " หรือไม่", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยันการลบ")) = MsgBoxResult.No Then Exit Sub
            strsql = "Delete from report_template where report_id = " & Report_ID
            _mysql.MySQLExecute(strsql)
            MsgBox("ลบรายงานเรียบร้อยแล้ว", MsgBoxStyle.Information)

            Load_Report()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        Try


            If DT_Reportlist.Rows.Count = 0 Then Exit Sub
            If Report_ID <> -1 Then

            Else
                Report_ID = DT_Reportlist.Rows(0).Item("report_id")
                Report_Name = DT_Reportlist.Rows(0).Item("report_name").ToString
            End If

            With frmPreviewReport
                .Primary_Key = Report_ID
                .Report_Name = Report_Name
                .MdiParent = frmmain
                .WindowState = FormWindowState.Maximized
                .Show()
            End With
        Catch ex As Exception
            With frmDebug
                .lblFormName.Text = Me.Name
                .lblFunctionName.Text = "BtnView_Click"
                .MemoErr_Description.Text = "กรุณาตรวจสอบคำสั่ง sql"
                .MemoSQL.Text = strsql
                .ShowDialog()
            End With
        End Try
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        Load_Report()

    End Sub
End Class