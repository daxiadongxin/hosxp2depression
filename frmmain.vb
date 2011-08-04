Public Class frmmain
    Dim Strsql As String
    Dim _mysql As New mysqlhelper
    Dim _mssql As New ClsSQLhelper


    Private Sub BtnSqlTool_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSqlTool.ItemClick
        With frmsql
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub




    Private Sub BtnExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnExit.ItemClick
        If (MsgBox("คุณต้องการออกจากระบบหรือไม่", MsgBoxStyle.Question + vbYesNo, "ยืนยันออกจากระบบ")) = MsgBoxResult.No Then Exit Sub
        Me.Dispose()

    End Sub

    Private Sub frmmain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If (MsgBox("คุณต้องการออกจากระบบหรือไม่", MsgBoxStyle.Question + vbYesNo, "ยืนยันออกจากระบบ")) = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If

        Me.Dispose()
    End Sub



    Private Sub MnQueryTools_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MnQueryTools.ItemClick
        With frmsql
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

   

  

    Private Sub MnPassScreen_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MnPassScreen.ItemClick
        With frmscreenlist
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub BtnPassScreen_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPassScreen.ItemClick
        With frmscreenlist
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub MnDBSetting_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MnDBSetting.ItemClick
        With frmDBSetting
            .MdiParent = Me
            .Show()

        End With
    End Sub


    Private Sub MnHOSxPScreen_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MnHOSxPScreen.ItemClick
        With frmHOSxPScreen
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub BtnPersonList_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPersonList.ItemClick
        With frmPersonList
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        DlgAbout.ShowDialog()
    End Sub

    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnUpgradeStructure_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnUpgradeStructure.ItemClick
        frmUpgradeStructure.ShowDialog()
    End Sub

    Private Sub BtnCheckOnlinePatient_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCheckOnlinePatient.ItemClick
        frmCheckOnlinePatient.ShowDialog()
    End Sub





    Private Sub MnChkPerson_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MnChkPerson.ItemClick
        With frmChkPerson

            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub MnChkService_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MnChkService.ItemClick
        With frmChkService
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub MnChkCard_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MnChkCard.ItemClick
        With frmChkCard
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub BtnUpdateServer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnUpdateServer.ItemClick
        Try
            Strsql = "Update tbProgrameValue set ipaddress = '110.164.197.220',serveruser = 'root',serverpass='depression_prasri',dbname='Depression_54'"
            _mssql.Execute(Strsql)
            MsgBox("ปรับปรุงข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "ผลการปรับปรุงข้อมูล")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdateOffice_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnUpdateOffice.ItemClick

        With frmOffice
            .MdiParent = Me
            .Show()


        End With
    End Sub

    Private Sub BtnDepression_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnDepression.ItemClick
        Process.Start("C:\Program Files\Depression\Depress 2011\Depression2.exe")

    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick

    End Sub

    Private Sub MnManual_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MnManual.ItemClick
        Process.Start(Application.StartupPath & "\Manual.pdf")
    End Sub

    Private Sub BtnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub BtnHOSxP_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnHOSxP.ItemClick
        With frmHOSxPScreen
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub BtnRemote_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRemote.ItemClick
        System.Diagnostics.Process.Start("http://www.teamviewer.com/th/index.aspx")
    End Sub

    Private Sub BtnWebsite_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnWebsite.ItemClick
        System.Diagnostics.Process.Start("https://sites.google.com/site/hosxp2depression2011/")
    End Sub
End Class