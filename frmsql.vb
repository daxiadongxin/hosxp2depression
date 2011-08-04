Imports System.IO
Public Class frmsql
    Dim _MSSql As New ClsSQLhelper
    Dim Strsql As String
    Dim MyConn As New SqlClient.SqlConnection
    Private Sub BtnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnClose.ItemClick
        Me.Dispose()

    End Sub

    Private Sub frmsql_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyConn.ConnectionString = My.Settings.ConnStr
        'Strsql = "show table"
        MemoSql.SetHighlighting("MySQL")
        MemoSql.AllowDrop = True

        With RepositoryItemComboBox1.Items

            Strsql = "sp_tables  'tb%'"

            Dim DT_Sqltable As New DataTable
            DT_Sqltable = _MSSql.GetMSSQLDataTable(Strsql, MyConn, "TempTable")
            If DT_Sqltable.Rows.Count > 0 Then
                For i As Integer = 0 To DT_Sqltable.Rows.Count - 1
                    .Add(DT_Sqltable.Rows(i).Item("TABLE_NAME").ToString)
                Next
            End If

            '.Add("tbCardtype")
            '.Add("tbCares")
            '.Add("tbChronicDesc")
            '.Add("tbDiag")
            '.Add("tbDistrict")
            '.Add("tbDoctor")
            '.Add("tbFollowup")
            '.Add("tbPcu")
            '.Add("tbPerson")
            '.Add("tbPrename")
            '.Add("tbProgrameValue")
            '.Add("tbProvince")
            '.Add("tbQuestion2Q")
            '.Add("tbQuestion8Q")
            '.Add("tbQuestion9Q")
            '.Add("tbRisk")
            '.Add("tbRiskLevel")
            '.Add("tbScreen")
            '.Add("tbSubdistrict")
            '.Add("tbUser")
            '.Add("tbVillage")
            '.Add("tbDepressStatus")
        End With

    End Sub

    Private Sub CboTablelist_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles CboTablelist.ItemClick

    End Sub

    Private Sub CboTablelist_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTablelist.EditValueChanged
        Me.MemoSql.Text = "Select * from " & CboTablelist.EditValue
    End Sub

    Private Sub BtnRun_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRun.ItemClick
        Try
            With GridControl1
                .DataSource = Nothing
                GridView1.Columns.Clear()

                Strsql = Me.MemoSql.Text


                Dim DT_Sqltemp As New DataTable
                DT_Sqltemp = _MSSql.GetMSSQLDataTable(Strsql, MyConn, "TempTable")
                .DataSource = DT_Sqltemp
                .Refresh()


                If DT_Sqltemp.Rows.Count >= 0 Then
                    Me.MemoSQLEdit.Text = "(" & DT_Sqltemp.Rows.Count & " row(s) affected)"
                Else
                    Me.TabResults.SelectedTabPage = TabpageMessage
                    Me.MemoSQLEdit.Text = "(0 row(s) affected)"
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnExcute_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnExcute.ItemClick
        Dim X As Integer
        X = _MSSql.Execute(Me.MemoSql.Text)

        If X >= 0 Then
            Me.TabResults.SelectedTabPage = TabpageMessage

            Me.MemoSQLEdit.Text = "(" & X & " row(s) affected)"
        Else
            Me.MemoSQLEdit.Text = "(0 row(s) affected)"
        End If
    End Sub


    Private Sub BtnStructure_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnStructure.ItemClick
        If Me.CboTablelist.EditValue = "" Then Exit Sub


        Me.MemoSql.Text = "sp_columns  " & CboTablelist.EditValue
        BtnRun_ItemClick(sender, e)

    End Sub

    Private Sub BtnTableInfo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnTableInfo.ItemClick
        If Me.CboTablelist.EditValue = "" Then Exit Sub


        Me.MemoSql.Text = "sp_tables  " & CboTablelist.EditValue
        BtnRun_ItemClick(sender, e)
    End Sub

    Private Sub BtnResetDB_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnResetDB.ItemClick
        If MsgBox("คุณต้องการจะ Reset ฐานข้อมูลโปรแรกม Depress ใช่หรือไม่", MsgBoxStyle.Question + vbYesNo, "ยืนยัน") = MsgBoxResult.No Then Exit Sub
        Strsql = "Delete from tbPerson"
        _MSSql.Execute(Strsql)

        Strsql = "Delete from tbScreen"
        _MSSql.Execute(Strsql)

        Strsql = "Delete from tbFollowup"
        _MSSql.Execute(Strsql)
        MsgBox("เรียบร้อยแล้ว", MsgBoxStyle.Information, "ผลการ Reset")
    End Sub

    Private Sub BtnSaveSQL_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSaveSQL.ItemClick
        If MsgBox("คุณต้องการบันทึกคำสั่ง SQL หรือไม่", MsgBoxStyle.Question + vbYesNo, "ยืนยันการเปิด") = vbYesNo Then Exit Sub
        With SaveFileDialog1
            .Title = "Save As"
            .FileName = "ExportSQL"
            .Filter = "SQL Files (*.sql)|*.sql"
            If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub

            '  If System.IO.File.Exists(.FileName) = True Then
            MemoSql.SaveFile(.FileName)

            'Dim objWriter As New System.IO.StreamWriter(.FileName)
            'objWriter.Write(MemoSql.Text)
            'objWriter.Close()
            MsgBox("บันทึกคำสั่ง sql เรียบร้อยแล้ว", MsgBoxStyle.Information, "ผลการบันทึกคำสั่ง sql")
            ' Else
            '  MsgBox("File Does Not Exist")
            '  End If

        End With
    End Sub

    Private Sub BtnBrowse_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnBrowse.ItemClick

        With OpenFileDialog1
            .Title = "Save As"
            .FileName = "ExportSQL"
            .Filter = "SQL Files (*.sql)|*.sql"
            If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Dim strContents As String
            Dim objReader As StreamReader
            Try

                objReader = New StreamReader(.FileName)
                strContents = objReader.ReadToEnd()
                objReader.Close()
         
                MemoSql.Text = strContents

            Catch Ex As Exception
                MsgBox(Ex.Message)
            End Try

        End With
    End Sub

    Private Sub BtnExcelExport_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnExcelExport.ItemClick
        If MsgBox("คุณต้องการส่งออกข้อมูลเป็น Excel หรือไม่", MsgBoxStyle.Question + vbYesNo, "ยืนยันการส่งออก") = vbYesNo Then Exit Sub

        With SaveFileDialog1
            .Title = "Save As"
            .FileName = "ExportData"
            .Filter = "Excel Files (*.xls)|*.xls"
            If .ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub


            GridControl1.ExportToXls(.FileName)
        End With
    End Sub
End Class
