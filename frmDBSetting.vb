Imports MySql.Data.MySqlClient
Imports System.Xml
Imports System.IO
Public Class frmDBSetting
    Private MyClsConn As ClsSQLhelper
    Dim XmlFileLocation As String = Application.StartupPath & "/DatabaseSetting.xml"
#Region "XML"
    Sub Update_Current_Q(ByVal TxtLastNumber As Integer, ByVal TxtChNumber As Integer)
        Try
            'Create the XML Document
            Dim m_xmld As New XmlDocument
            Dim m_nodelist As XmlNodeList
            Dim m_node As XmlNode
            Dim MyFunc As New Pn_Framework
            'Load the Xml file

            m_xmld.Load(XmlFileLocation)
            'Get the list of name nodes 

            m_nodelist = m_xmld.SelectNodes("/Settings")
            'Loop through the nodes
            Dim CurrentQValue As String = 0
            Dim NextQValue As String = 0
            For Each m_node In m_nodelist
                m_node.ChildNodes.Item(2).InnerText = TxtLastNumber
                m_node.ChildNodes.Item(3).InnerText = TxtChNumber
                m_node.ChildNodes.Item(7).InnerText = MyFunc.Current_EngDate.ToString
                Select Case TxtChNumber
                    Case 1
                        m_node.ChildNodes.Item(8).InnerText = TxtLastNumber
                    Case 2
                        m_node.ChildNodes.Item(9).InnerText = TxtLastNumber
                    Case 3
                        m_node.ChildNodes.Item(10).InnerText = TxtLastNumber
                    Case 4
                        m_node.ChildNodes.Item(11).InnerText = TxtLastNumber
                End Select


            Next
            m_xmld.Save(XmlFileLocation)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Sub Write_XML()

        Try
            Dim Crypto As New Crypto.Crypto
            With SaveFileDialog1
                .Title = "ส่งออกไฟล์ XML"
                .Filter = "XML | *.xml"
                .FileName = "DatabaseSetting.xml"
                If .ShowDialog() <> DialogResult.OK Then Exit Sub
                Using sw As StreamWriter = New StreamWriter(.FileName, False, System.Text.Encoding.UTF8)
                    sw.WriteLine("<?xml version='1.0' encoding='windows-874'?>")
                    sw.WriteLine("<Settings>")
                    sw.WriteLine("      <HOSxPDB>" & Me.TxtHOSxPDatabase.Text & "</HOSxPDB>")
                    sw.WriteLine("      <HOSxPUser>" & Me.TxtHOSxPUser.Text & "</HOSxPUser>")
                    sw.WriteLine("      <HOSxPPass>" & Crypto.Encrypt(Me.TxtHOSxPPassword.Text, "sys11266") & "</HOSxPPass>")
                    sw.WriteLine("      <HOSxPPort>" & Me.TxtHOSxPPort.Text & "</HOSxPPort>")
                    sw.WriteLine("      <HOSxPServer>" & Me.TxtHOSxPHost.Text & "</HOSxPServer>")

                    sw.WriteLine("</Settings>")
                    sw.Close()

                End Using

            End With
        Catch ex As Exception
            MsgBox(Err.Number & " : " & ex.Message.ToString)
        End Try


    End Sub
    Sub Read_XML()
        Try
            With OpenFileDialog1
                .Title = "นำเข้าไฟล์ XML"
                .Filter = "XML | *.xml"
                .FileName = "DatabaseSetting.xml"
                If .ShowDialog() <> DialogResult.OK Then Exit Sub

                'Create the XML Document
                Dim m_xmld As New XmlDocument
                Dim m_nodelist As XmlNodeList
                Dim m_node As XmlNode
                Dim MyFunc As New Pn_Framework
                'Load the Xml file

                m_xmld.Load(OpenFileDialog1.FileName)
                'Get the list of name nodes 

                m_nodelist = m_xmld.SelectNodes("/Settings")
                'Loop through the nodes

                '<HOSxPDB>hos</HOSxPDB>
                '<HOSxPUser>sa</HOSxPUser>
                '<HOSxPPass>zX9hHiJeH7E=</HOSxPPass>
                '<HOSxPPort>3306</HOSxPPort>
                '<HOSxPServer>127.0.0.1</HOSxPServer>
                '<NHSO_OPPPDB>oppp2554</NHSO_OPPPDB>
                '<NHSO_OPPPUser>sa</NHSO_OPPPUser>
                '<NHSO_OPPPPass>+wnMDSdTwhc=</NHSO_OPPPPass>
                '<NHSO_OPPPPort>3306</NHSO_OPPPPort>
                '<NHSO_OPPPServer>localhost</NHSO_OPPPServer>
                Dim Crypto As New Crypto.Crypto
                For Each m_node In m_nodelist
                    'Get the Chanel Attribute Value
                    Me.TxtHOSxPDatabase.Text = m_node.ChildNodes.Item(0).InnerText
                    Me.TxtHOSxPUser.Text = m_node.ChildNodes.Item(1).InnerText
                    Me.TxtHOSxPPassword.Text = Crypto.Decrypt(m_node.ChildNodes.Item(2).InnerText, "sys11266")
                    Me.TxtHOSxPPort.Text = m_node.ChildNodes.Item(3).InnerText
                    Me.TxtHOSxPHost.Text = m_node.ChildNodes.Item(4).InnerText
                   
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Sub Update_ScreenText()
    '    Try
    '        'Create the XML Document
    '        Dim m_xmld As New XmlDocument
    '        Dim m_nodelist As XmlNodeList
    '        Dim m_node As XmlNode

    '        'Load the Xml file

    '        m_xmld.Load(XmlFileLocation)
    '        'Get the list of name nodes 

    '        m_nodelist = m_xmld.SelectNodes("/Settings")
    '        'Loop through the nodes
    '        Dim CurrentQValue As String = 0
    '        Dim NextQValue As String = 0
    '        For Each m_node In m_nodelist
    '            'Get the Chanel Attribute Value
    '            m_node.ChildNodes.Item(0).InnerText = Me.TxtNotice.Text
    '            m_node.ChildNodes.Item(1).InnerText = Me.TxtLocationName.Text
    '            If (Me.ChkAutoReset.Checked = True) Then
    '                m_node.ChildNodes.Item(6).InnerText = 1
    '            Else
    '                m_node.ChildNodes.Item(6).InnerText = 0
    '            End If


    '        Next
    '        m_xmld.Save(XmlFileLocation)
    '        'MsgBox("ปรับปรุงข้อความเรียบร้อยแล้ว")

    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    End Try
    'End Sub
    'Sub Read_Current_Q()
    '    Try
    '        'Create the XML Document
    '        Dim m_xmld As New XmlDocument
    '        Dim m_nodelist As XmlNodeList
    '        Dim m_node As XmlNode
    '        Dim MyFunc As New ClsCustomfunction
    '        'Load the Xml file

    '        m_xmld.Load(XmlFileLocation)
    '        'Get the list of name nodes 

    '        m_nodelist = m_xmld.SelectNodes("/Settings")
    '        'Loop through the nodes
    '        Dim CurrentQValue As String = 0
    '        Dim NextQValue As String = 0
    '        For Each m_node In m_nodelist
    '            'Get the Chanel Attribute Value
    '            StrMaqueeText = m_node.ChildNodes.Item(0).InnerText
    '            StrLocationName = m_node.ChildNodes.Item(1).InnerText
    '            StrCurrentQ = m_node.ChildNodes.Item(2).InnerText
    '            TxtLastNumber.Text = m_node.ChildNodes.Item(2).InnerText
    '            StrCurrentCH = m_node.ChildNodes.Item(3).InnerText
    '            TxtChNumber.Text = m_node.ChildNodes.Item(3).InnerText
    '            StrNextQ = m_node.ChildNodes.Item(4).InnerText
    '            TotalCH = m_node.ChildNodes.Item(5).InnerText
    '            TxtCh1.Text = m_node.ChildNodes.Item(8).InnerText
    '            TxtCh2.Text = m_node.ChildNodes.Item(9).InnerText
    '            TxtCh3.Text = m_node.ChildNodes.Item(10).InnerText
    '            TxtCh4.Text = m_node.ChildNodes.Item(11).InnerText

    '            If (m_node.ChildNodes.Item(6).InnerText = 1) Then
    '                Chk_AutoReset = True
    '            Else
    '                Chk_AutoReset = False
    '            End If

    '            Curr_XML_Date = m_node.ChildNodes.Item(7).InnerText

    '            TxtNotice.Text = StrMaqueeText
    '            TxtLocationName.Text = StrLocationName
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    End Try
    'End Sub
    'Sub Reset_Q(Optional ByVal FixQ As Integer = 0)
    '    Try
    '        'Create the XML Document
    '        Dim m_xmld As New XmlDocument
    '        Dim m_nodelist As XmlNodeList
    '        Dim m_node As XmlNode

    '        'Load the Xml file

    '        m_xmld.Load(XmlFileLocation)
    '        'Get the list of name nodes 

    '        m_nodelist = m_xmld.SelectNodes("/Settings")
    '        'Loop through the nodes
    '        Dim CurrentQValue As String = 0
    '        Dim NextQValue As String = 0
    '        For Each m_node In m_nodelist
    '            m_node.ChildNodes.Item(2).InnerText = FixQ
    '            m_node.ChildNodes.Item(3).InnerText = 0
    '            m_node.ChildNodes.Item(8).InnerText = 0
    '            m_node.ChildNodes.Item(9).InnerText = 0
    '            m_node.ChildNodes.Item(10).InnerText = 0
    '            m_node.ChildNodes.Item(11).InnerText = 0
    '            m_node.ChildNodes.Item(7).InnerText = Curr_XML_Date
    '        Next
    '        m_xmld.Save(XmlFileLocation)
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    End Try
    'End Sub
    'Sub Add_Stat()
    '    Try
    '        'Create the XML Document
    '        Dim m_xmld As New XmlDocument
    '        Dim m_nodelist As XmlNodeList
    '        Dim m_node As XmlNode

    '        'Load the Xml file

    '        m_xmld.Load(XmlFileLocation)
    '        'Get the list of name nodes 

    '        m_nodelist = m_xmld.SelectNodes("/Stat")
    '        'Loop through the nodes
    '        Dim CurrentQValue As String = 0
    '        Dim NextQValue As String = 0
    '        For Each m_node In m_nodelist
    '            m_node.ChildNodes.Item(2).InnerText = 0
    '            m_node.ChildNodes.Item(3).InnerText = 0
    '            m_node.ChildNodes.Item(8).InnerText = 0
    '            m_node.ChildNodes.Item(9).InnerText = 0
    '            m_node.ChildNodes.Item(10).InnerText = 0
    '            m_node.ChildNodes.Item(11).InnerText = 0
    '            m_node.ChildNodes.Item(7).InnerText = Curr_XML_Date
    '        Next
    '        m_xmld.Save(XmlFileLocation)
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    End Try
    'End Sub
#End Region

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Dispose()
        'If mysqlhelper.MyShowDBSetting = "1" Then

        '    frmmain.Dispose()

        'End If

    End Sub
    Private Sub frmDBSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadDefaultConfig()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Try



            If MsgBox("คุณต้องการแก้ไขค่า connection ใช่หรือไม่", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

          

            'HOSxP Validate
            If Me.TxtHOSxPDatabase.Text.Trim.Equals("") Then
                MsgBox("กรุณาใส่ชื่อฐานข้อมูล HOSxP", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If Me.TxtHOSxPUser.Text.Trim.Equals("") Then
                MsgBox("กรุณาใส่ชื่อผู้ใช้ HOSxP", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If Me.TxtHOSxPPassword.Text.Trim.Equals("") Then
                MsgBox("กรุณาใส่รหัสผ่าน HOSxP", MsgBoxStyle.Exclamation)
            End If

            If Me.TxtHOSxPPort.Text = "" Then
                MsgBox("กรุณาใส่พ็อต HOSxP", MsgBoxStyle.Exclamation)
            ElseIf IsNumeric(Me.TxtHOSxPPort.Text) = False Then
                MsgBox("กรุณาใส่เป็นตัวเลขเท่านั้น", MsgBoxStyle.Exclamation)
            End If

            If Me.TxtHOSxPHost.Text.Trim.Equals("") Then
                MsgBox("กรุณาใส่ชื่อ Server HOSxP", MsgBoxStyle.Exclamation)
            End If

            '(LoadDefaultConfig())
            If TestConnectionResult() = False Then
                MsgBox("ค่าที่ตั้งไม่สามารถติดต่อฐานข้อมูลได้ กรุณากรอกข้อมูลใหม่อีกครั้ง", MsgBoxStyle.Information, "ไม่สามารถปรับปรุงการตั้งค่าได้")
                Exit Sub
            Else
                'If (ClsSQLhelper.MySQLDatabase = Me.TxtDatabase.Text) And (ClsSQLhelper.MySQLUser = Me.TxtUser.Text) And (ClsSQLhelper.MySQLPassword = Me.TxtPassword.Text) And (ClsSQLhelper.MySQLPort = Me.TxtPort.Text) And (ClsSQLhelper.MySQLServer = Me.TxtHost.Text) Then
                '    MsgBox("บันทึกค่าสำเร็จ", MsgBoxStyle.Information)
                'Else

                'End If

                Dim Crypto As New Crypto.Crypto
                mysqlhelper.MySQLDatabase = Me.TxtHOSxPDatabase.Text
                mysqlhelper.MySQLUser = Me.TxtHOSxPUser.Text
                mysqlhelper.MySQLPassword = Crypto.Encrypt(Me.TxtHOSxPPassword.Text, "sys11266")
                mysqlhelper.MySQLPort = Me.TxtHOSxPPort.Text
                mysqlhelper.MySQLServer = Me.TxtHOSxPHost.Text


                MsgBox("บันทึกค่าสำเร็จ กรุณาเปิดใหม่เพื่อให้โปรแกรมใช้ค่าที่ตั้งใหม่", MsgBoxStyle.Information)

                Me.Dispose()
                frmmain.Dispose()
            End If

            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Sub LoadDefaultConfig()
        Try

            Dim Crypto As New Crypto.Crypto
            Me.TxtHOSxPDatabase.Text = mysqlhelper.MySQLDatabase
            Me.TxtHOSxPUser.Text = mysqlhelper.MySQLUser
            Me.TxtHOSxPPassword.Text = Crypto.Decrypt(mysqlhelper.MySQLPassword, "sys11266")
            Me.TxtHOSxPPort.Text = mysqlhelper.MySQLPort
            Me.TxtHOSxPHost.Text = mysqlhelper.MySQLServer
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub BtnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTest.Click

        TestConnectionResult()

    End Sub

    Private Sub TxtHost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Asc(e.KeyChar) = 13 Then
                TestConnectionResult()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub TxtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Asc(e.KeyChar) = 13 Then
                TestConnectionResult()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Asc(e.KeyChar) = 13 Then
                TestConnectionResult()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub TxtDatabase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Asc(e.KeyChar) = 13 Then
                TestConnectionResult()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub TxtPort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Asc(e.KeyChar) = 13 Then
                TestConnectionResult()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Function TestConnectionResult() As Boolean

            ' MyClsConn.TestConnectionResult()
            TestConnectionResult = False

            Dim TestHOSxPConnstr As String = "server=" & TxtHOSxPHost.Text & ";user=" & TxtHOSxPUser.Text & ";database=" & TxtHOSxPDatabase.Text & ";port=" & TxtHOSxPPort.Text & ";password=" & TxtHOSxPPassword.Text & ";"
            Dim TestConn As New MySqlConnection
            Dim TestHOSxPConn As New MySqlConnection
            Try
                TestConn.ConnectionString = TestHOSxPConnstr
                TestConn.Open()

            MessageBox.Show("ติดต่อฐานข้อมูล HOSxP สำเร็จ")

                TestConnectionResult = True
                TestConn.Close()
            Catch myerror As MySqlException
                TestConnectionResult = False
            MsgBox(Err.Number & " : " & myerror.Message, MsgBoxStyle.Critical, "ไม่สามารถติดต่อฐานข้อมูลได้ HOSxP ได้")

            End Try

         
    End Function

    Private Sub BtnExportSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportSetting.Click
        Write_XML()
    End Sub

    Private Sub BtnImportSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportSetting.Click
        Read_XML()

    End Sub
End Class