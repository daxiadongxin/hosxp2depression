Imports System.IO
Imports System.Data.OleDb
Imports System.Text
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmChkPerson
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
                DR = DS.Tables("person").NewRow
                Icount = 1
                For Each sItem As String In sValues
                    ' Debug.Print(sItem)
                    If Icount <= DS.Tables("person").Columns.Count - 1 Then
                        DR(Icount) = sItem
                        Icount = Icount + 1
                    End If
                Next
                DS.Tables("person").Rows.Add(DR)
            Next
            Return DS
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Sub Show_Data(ByVal Filename As String)
        With DataGridView1
            '.DataSource = ReadCSVintoDataSet(OpenFileDialog1.FileName).Tables(0)
            .DataSource = ReadPipedata(Filename).Tables("person")
            .AllowUserToAddRows = False
            .ReadOnly = True
            .Columns(0).HeaderText = "ลำดับ"
            .Columns(1).HeaderText = "PCUCODE"
            .Columns(2).HeaderText = "CID"
            .Columns(3).HeaderText = "PID"
            .Columns(4).HeaderText = "HID"
            .Columns(5).HeaderText = "PRENAME"
            .Columns(6).HeaderText = "NAME"
            .Columns(7).HeaderText = "LNAME"
            .Columns(8).HeaderText = "HN"
            .Columns(9).HeaderText = "SEX"
            .Columns(10).HeaderText = "BIRTH"
            .Columns(11).HeaderText = "HOUSE"
            .Columns(12).HeaderText = "VILAGE"
            .Columns(13).HeaderText = "TAMBON"
            .Columns(14).HeaderText = "AMPUR"
            .Columns(15).HeaderText = "CHANGWAT"
            .Columns(16).HeaderText = "MSTATUS"
            .Columns(17).HeaderText = "OCCUPA"
            .Columns(18).HeaderText = "RACE"
            .Columns(19).HeaderText = "RNATION"
            .Columns(20).HeaderText = "RELIGION"
            .Columns(21).HeaderText = "EDUCATE"
            .Columns(22).HeaderText = "FSTATUS"
            .Columns(23).HeaderText = "FATHER"
            .Columns(24).HeaderText = "MOTHER"
            .Columns(25).HeaderText = "COUPLE"
            .Columns(26).HeaderText = "MOVEIN"
            .Columns(27).HeaderText = "DISCHAR"
            .Columns(28).HeaderText = "DDISCH"
            .Columns(29).HeaderText = "BLOODGROUP"
            .Columns(30).HeaderText = "LABOR"
            .Columns(31).HeaderText = "VHID"
            .Columns(32).HeaderText = "TYPEAREA"
            .Columns(33).HeaderText = "LASTUPDATE"
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

    Private Sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        With Me.OpenFileDialog1
            .FileName = "PERSON.TXT"
            .Filter = "TXT files (*.TXT)|*.TXT"
            .Title = "เปิดไฟล์ Person"
            .InitialDirectory = "C:\"
        End With
        If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.OK Then Exit Sub
        If Path.GetFileName(OpenFileDialog1.FileName) <> "PERSON.TXT" Then
            MsgBox("โปรแกรม Depression office จะไม่สามารถใช้ไฟล์ในรูปแบบ OPPP ได้", MsgBoxStyle.Critical, "กรุณาเลือกไฟล์ที่ชื่อ PERSON.TXT เท่านั้น")
            Exit Sub
        End If
        Show_Data(OpenFileDialog1.FileName)
    End Sub

    Private Sub frmChkPerson_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Dispose()
    End Sub
End Class