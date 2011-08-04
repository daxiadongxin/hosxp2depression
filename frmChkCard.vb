Imports System.IO
Imports System.Data.OleDb
Imports System.Text
Public Class frmChkCard
#Region "Function"
    Function ReadPipedata(ByVal Filename As String) As DataSet
        Try
            Dim lines As String()
            Dim DS As New DSPerson


            Dim Icount As Integer = 1
            Dim DR As DataRow



            lines = System.IO.File.ReadAllLines(Filename, Encoding.GetEncoding("TIS-620"))
            For Each sLine As String In lines
                Dim sValues As String()
                sValues = sLine.Split("|")
                DR = DS.Tables("card").NewRow
                Icount = 1
                For Each sItem As String In sValues
                    'Debug.Print(sItem)
                    If Icount <= DS.Tables("card").Columns.Count - 1 Then
                        DR(Icount) = sItem
                        Icount = Icount + 1
                    End If
                Next
                DS.Tables("card").Rows.Add(DR)
            Next
            Return DS
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Sub Show_Data(ByVal Filename As String)
        With DataGridView1

            .DataSource = ReadPipedata(Filename).Tables("card")
            .AllowUserToAddRows = False
            .ReadOnly = True
            .Columns(0).HeaderText = "ลำดับ"
            .Columns(1).HeaderText = "PCUCODE"
            .Columns(2).HeaderText = "CID"
            .Columns(3).HeaderText = "PID"
            .Columns(4).HeaderText = "INSTYPE"
            .Columns(5).HeaderText = "INSID"
            .Columns(6).HeaderText = "START"
            .Columns(7).HeaderText = "EXPIR"
            .Columns(8).HeaderText = "MAIN"
            .Columns(9).HeaderText = "SUB"
            .Columns(10).HeaderText = "D_UPDATE"

            .RowHeadersVisible = False
            .ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
            .AllowDrop = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        End With
        Me.TSTotalRows.Text = DataGridView1.Rows.Count
    End Sub

#End Region

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Dispose()
    End Sub

    Private Sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        With Me.OpenFileDialog1
            .FileName = "CARD.TXT"
            .Filter = "TXT files (*.TXT)|*.TXT"
            .Title = "เปิดไฟล์  SERVICE.TXT"
            .InitialDirectory = "C:\"
        End With
        If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.OK Then Exit Sub
        If Path.GetFileName(OpenFileDialog1.FileName) <> "CARD.TXT" Then
            MsgBox("โปรแกรม Depression office จะไม่สามารถใช้ไฟล์ในรูปแบบ OPPP ได้", MsgBoxStyle.Critical, "กรุณาเลือกไฟล์ที่ชื่อ CARD.TXT เท่านั้น")
            Exit Sub
        End If
        Show_Data(OpenFileDialog1.FileName)
    End Sub
End Class