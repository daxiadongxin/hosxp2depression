﻿Imports System
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Security.Cryptography

Public Class Pn_Framework
    Public Current_ThaiDate As String = Now().Day & "-" & Now().Month & "-" & Now().Year
    Public Current_EngDate As String = Now().Day & "-" & Now().Month & "-" & Now().Year + 543
    Public Shared Sub Set_GridSetting(ByVal MyGrid As DataGridView, ByVal DS As DataSet)
        With MyGrid
            .ReadOnly = True
            .RowHeadersVisible = False
            .AllowDrop = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .DataSource = DS.Tables(0)
            DS.Dispose()
        End With
    End Sub
    Public Shared Sub Set_GridSetting(ByVal MyGrid As DataGridView, ByVal DT As DataTable)
        With MyGrid
            .ReadOnly = True
            .RowHeadersVisible = False
            .AllowDrop = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .DataSource = DT
            DT.Dispose()
        End With
    End Sub
    Public Shared Function Get_IPAddress() As String
        'To get local address
        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        Get_IPAddress = h.AddressList.GetValue(0).ToString
    End Function
    Public Shared Function Get_Computername() As String
        'To get local address
        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        Get_Computername = h.HostName
    End Function
    Public Shared Function Get_PublishVesrion() As String
        Try
            Dim MyPublishVersion As String = ""
            With System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
                MyPublishVersion = .Major & "." & .Minor & "." & .Build & "." & .Revision
            End With

            Get_PublishVesrion = MyPublishVersion
        Catch ex As Exception
            Get_PublishVesrion = String.Format(" {0}", Application.ProductVersion.ToString)
            'MsgBox(ex.Message)
        End Try


    End Function

    Public Shared Function Get_GUID() As String
        Get_GUID = System.Guid.NewGuid.ToString()
    End Function
    Public Shared Function Get_ComputerGuid() As String
        Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Shared Function Thaimonth(ByVal MonthID As Integer) As String
        Try
            Thaimonth = ""
            Select Case MonthID
                Case 1
                    Thaimonth = "มกราคม"
                Case 2
                    Thaimonth = "กุมภาพันธ์"
                Case 3
                    Thaimonth = "มีนาคม"
                Case 4
                    Thaimonth = "เมษายน"
                Case 5
                    Thaimonth = "พฤษภาคม"
                Case 6
                    Thaimonth = "มิถุนายน"
                Case 7
                    Thaimonth = "กรกฏาคม"
                Case 8
                    Thaimonth = "สิงหาคม"
                Case 9
                    Thaimonth = "กันยายน"
                Case 10
                    Thaimonth = "ตุลาคม"
                Case 11
                    Thaimonth = "พฤษจิกายน"
                Case 12
                    Thaimonth = "ธันวาคม"
            End Select
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Function
    Public Shared Function MysqlDateTimeFormat(ByVal CustomeDate As DateTime, Optional ByVal Enable_Time As Boolean = False) As String
        Select Case Enable_Time
            Case True
                MysqlDateTimeFormat = CustomeDate.Year & "-" & CustomeDate.Month & "-" & CustomeDate.Day & " " & CustomeDate.Hour & ":" & CustomeDate.Minute & ":" & CustomeDate.Second
            Case False
                MysqlDateTimeFormat = CustomeDate.Year & "-" & CustomeDate.Month & "-" & CustomeDate.Day
        End Select

    End Function
    'Public Shared Function MsAccessDateTimeFormat(ByVal CustomeDate As DateTime, Optional ByVal Enable_Time As Boolean = False) As String
    '    Select Case Enable_Time
    '        Case True
    '            MsAccessDateTimeFormat = CustomeDate.Year & "-" & CustomeDate.Month & "-" & CustomeDate.Day & " " & CustomeDate.Hour & ":" & CustomeDate.Minute & ":" & CustomeDate.Second
    '        Case False
    '            MsAccessDateTimeFormat = CustomeDate.Year & "-" & CustomeDate.Month & "-" & CustomeDate.Day
    '    End Select

    'End Function
    Public Shared Function Get_OS() As String
        Return System.Environment.OSVersion.ToString
    End Function
    Public Shared Function ConvertNumerictoWord(ByVal num As String) As String
        Try
            Dim i As Integer, r As String, n As String
            ConvertNumerictoWord = ""
            Dim BahtNumber As Integer
            Dim StangNumber As Integer
            Dim BahtString As String = ""
            Dim BahtEndLength As Integer = 0
            Dim StangString As String = ""
            Dim StangStartLength As Integer = 0
            Dim StangEnable As Boolean = False
            If InStr(num, ".", CompareMethod.Text) > 0 Then
                StangEnable = True
                BahtEndLength = InStr(num, ".", CompareMethod.Text) - 1
                BahtNumber = Left(num, BahtEndLength)
                StangStartLength = InStr(num, ".", CompareMethod.Text) + 1
                StangNumber = Mid(num, StangStartLength, 2)

                StangString = Choose(Left(StangNumber.ToString, 1), "สิบ", "ยี่สิบ", "สามสิบ", "สี่สิบ", "ห้าสิบ", "หกสิบ", "เจ็ดสิบ", "แปดสิบ", "เก้าสิบ")
                StangString = StangString & Choose(Right(StangNumber.ToString, 1), "เอ็ด", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า")
                If StangString <> "" Then StangString = StangString & "สตางค์"

            Else
                StangEnable = False
                BahtNumber = num
            End If



            For i = 1 To BahtNumber.ToString.Length
                r = Choose(((BahtNumber.ToString.Length - i + 1) Mod 6) + 1, "แสน", "", "สิบ", "ร้อย", "พัน", "หมื่น")
                n = Choose(Mid(BahtNumber, i, 1) + 1, "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า")
                If r = "สิบ" And n = "หนึ่ง" Then n = ""
                If n = "หนึ่ง" And r = "" And BahtNumber.ToString.Length <> 1 Then n = "เอ็ด"
                If i = 1 And n = "เอ็ด" And BahtNumber.ToString.Length > 1 Then n = "หนึ่ง"
                If r = "สิบ" And n = "สอง" Then n = "ยี่"
                If r = "" And BahtNumber.ToString.Length - i + 1 > 6 Then r = "ล้าน"
                If n <> "ศูนย์" Then
                    BahtString = BahtString & n & r
                Else
                    If r = "ล้าน" Then BahtString = BahtString & r
                End If
            Next

            Return BahtString & "บาท" & StangString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Public Shared Function FormatCID(ByVal CID As String) As String
        Try
            If CID = "" Then
                Return "0-0000-00000-00-0"
            Else
                Return Mid(CID, 1, 1) & "-" & Mid(CID, 2, 4) & "-" & Mid(CID, 6, 5) & "-" & Mid(CID, 11, 2) & "-" & Mid(CID, 13, 1)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Class
