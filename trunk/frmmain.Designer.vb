<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BtnHOSxP = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnPersonList = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnPassScreen = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnSqlTool = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCheckOnlinePatient = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.MnChkPerson = New DevExpress.XtraBars.BarButtonItem()
        Me.MnChkService = New DevExpress.XtraBars.BarButtonItem()
        Me.MnChkCard = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnUpdateOffice = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnUpdateServer = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnDepression = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.MnPassScreen = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnExit = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.MnDBSetting = New DevExpress.XtraBars.BarButtonItem()
        Me.MnQueryTools = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnUpgradeStructure = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.MnHOSxPScreen = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.MnManual = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnRemote = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BtnChkPerson = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnChkService = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnWebsite = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "flash.png")
        Me.ImageCollection1.Images.SetKeyName(1, "plug.png")
        Me.ImageCollection1.Images.SetKeyName(2, "house.png")
        Me.ImageCollection1.Images.SetKeyName(3, "businessman_preferences.png")
        Me.ImageCollection1.Images.SetKeyName(4, "data.png")
        Me.ImageCollection1.Images.SetKeyName(5, "businessmen.png")
        Me.ImageCollection1.Images.SetKeyName(6, "lifebelt.png")
        Me.ImageCollection1.Images.SetKeyName(7, "document_certificate.png")
        Me.ImageCollection1.Images.SetKeyName(8, "data_replace.png")
        Me.ImageCollection1.Images.SetKeyName(9, "cus24X24.png")
        Me.ImageCollection1.Images.SetKeyName(10, "icon-diagnostic.png")
        Me.ImageCollection1.Images.SetKeyName(11, "credit_card.png")
        Me.ImageCollection1.Images.SetKeyName(12, "books.png")
        Me.ImageCollection1.Images.SetKeyName(13, "data_disk.png")
        Me.ImageCollection1.Images.SetKeyName(14, "id_card.png")
        Me.ImageCollection1.Images.SetKeyName(15, "Security.jpg")
        Me.ImageCollection1.Images.SetKeyName(16, "businessman_find.png")
        Me.ImageCollection1.Images.SetKeyName(17, "bullet_square_red.png")
        Me.ImageCollection1.Images.SetKeyName(18, "addons32.png")
        Me.ImageCollection1.Images.SetKeyName(19, "monitor2.png")
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImageCollection1
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BtnSqlTool, Me.BarSubItem1, Me.BarSubItem2, Me.BtnExit, Me.MnQueryTools, Me.MnPassScreen, Me.BtnPassScreen, Me.MnDBSetting, Me.BarSubItem3, Me.MnHOSxPScreen, Me.BtnPersonList, Me.BarSubItem4, Me.BarButtonItem2, Me.BarButtonItem3, Me.BtnUpgradeStructure, Me.BtnCheckOnlinePatient, Me.BarSubItem5, Me.BtnChkPerson, Me.BtnChkService, Me.BarSubItem6, Me.MnChkPerson, Me.MnChkService, Me.MnChkCard, Me.BtnUpdateServer, Me.BtnUpdateOffice, Me.BtnDepression, Me.MnManual, Me.BtnHOSxP, Me.BtnClose, Me.BtnRemote, Me.BtnWebsite})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 45
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnHOSxP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.Caption Or DevExpress.XtraBars.BarLinkUserDefines.PaintStyle), DevExpress.XtraBars.BarLinkUserDefines), Me.BtnPersonList, "รายชื่อ", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnPassScreen, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnSqlTool, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnCheckOnlinePatient, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnUpdateOffice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnUpdateServer, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnDepression, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
        '
        'BtnHOSxP
        '
        Me.BtnHOSxP.Caption = "ดูข้อมูล HOSxP"
        Me.BtnHOSxP.Id = 40
        Me.BtnHOSxP.ImageIndex = 16
        Me.BtnHOSxP.Name = "BtnHOSxP"
        '
        'BtnPersonList
        '
        Me.BtnPersonList.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPersonList.Appearance.Options.UseFont = True
        Me.BtnPersonList.Caption = "รายชื่อทั้งหมด"
        Me.BtnPersonList.Id = 22
        Me.BtnPersonList.ImageIndex = 5
        Me.BtnPersonList.Name = "BtnPersonList"
        '
        'BtnPassScreen
        '
        Me.BtnPassScreen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPassScreen.Appearance.Options.UseFont = True
        Me.BtnPassScreen.Caption = "ผลการคัดกรอง"
        Me.BtnPassScreen.Id = 17
        Me.BtnPassScreen.ImageIndex = 3
        Me.BtnPassScreen.Name = "BtnPassScreen"
        '
        'BtnSqlTool
        '
        Me.BtnSqlTool.Caption = "Query Tool"
        Me.BtnSqlTool.Id = 1
        Me.BtnSqlTool.ImageIndex = 0
        Me.BtnSqlTool.Name = "BtnSqlTool"
        '
        'BtnCheckOnlinePatient
        '
        Me.BtnCheckOnlinePatient.Appearance.Options.UseFont = True
        Me.BtnCheckOnlinePatient.Caption = "ตรวจสอบรายชื่อใน Online"
        Me.BtnCheckOnlinePatient.Id = 27
        Me.BtnCheckOnlinePatient.ImageIndex = 5
        Me.BtnCheckOnlinePatient.Name = "BtnCheckOnlinePatient"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "ตรวจสอบ 18 แฟ้ม"
        Me.BarSubItem6.Id = 32
        Me.BarSubItem6.ImageIndex = 12
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.MnChkPerson), New DevExpress.XtraBars.LinkPersistInfo(Me.MnChkService), New DevExpress.XtraBars.LinkPersistInfo(Me.MnChkCard)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'MnChkPerson
        '
        Me.MnChkPerson.Caption = "Person"
        Me.MnChkPerson.Id = 33
        Me.MnChkPerson.ImageIndex = 9
        Me.MnChkPerson.Name = "MnChkPerson"
        '
        'MnChkService
        '
        Me.MnChkService.Caption = "Service"
        Me.MnChkService.Id = 34
        Me.MnChkService.ImageIndex = 10
        Me.MnChkService.Name = "MnChkService"
        '
        'MnChkCard
        '
        Me.MnChkCard.Caption = "Card"
        Me.MnChkCard.Id = 35
        Me.MnChkCard.ImageIndex = 11
        Me.MnChkCard.Name = "MnChkCard"
        '
        'BtnUpdateOffice
        '
        Me.BtnUpdateOffice.Caption = "ปรับปรุงสถานบริการ"
        Me.BtnUpdateOffice.Id = 37
        Me.BtnUpdateOffice.ImageIndex = 14
        Me.BtnUpdateOffice.Name = "BtnUpdateOffice"
        '
        'BtnUpdateServer
        '
        Me.BtnUpdateServer.Caption = "ปรับปรุง IP เครื่องแม่ข่าย"
        Me.BtnUpdateServer.Id = 36
        Me.BtnUpdateServer.ImageIndex = 13
        Me.BtnUpdateServer.Name = "BtnUpdateServer"
        '
        'BtnDepression
        '
        Me.BtnDepression.Caption = "เปิดโปรแกรม Depress"
        Me.BtnDepression.Id = 38
        Me.BtnDepression.ImageIndex = 15
        Me.BtnDepression.Name = "BtnDepression"
        '
        'BtnClose
        '
        Me.BtnClose.Caption = "ออกจากโปรแกรม"
        Me.BtnClose.Id = 42
        Me.BtnClose.ImageIndex = 17
        Me.BtnClose.Name = "BtnClose"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "File"
        Me.BarSubItem1.Id = 2
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.MnPassScreen), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnExit)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'MnPassScreen
        '
        Me.MnPassScreen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnPassScreen.Appearance.Options.UseFont = True
        Me.MnPassScreen.Caption = "รายชื่อผู้ผ่านการคัดกรอง"
        Me.MnPassScreen.Id = 16
        Me.MnPassScreen.ImageIndex = 3
        Me.MnPassScreen.Name = "MnPassScreen"
        '
        'BtnExit
        '
        Me.BtnExit.Caption = "ออกจากโปรแกรม"
        Me.BtnExit.Id = 10
        Me.BtnExit.ImageIndex = 1
        Me.BtnExit.Name = "BtnExit"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Tool"
        Me.BarSubItem2.Id = 3
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.MnDBSetting), New DevExpress.XtraBars.LinkPersistInfo(Me.MnQueryTools), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnUpgradeStructure)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'MnDBSetting
        '
        Me.MnDBSetting.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnDBSetting.Appearance.Options.UseFont = True
        Me.MnDBSetting.Caption = "ฐานข้อมูล"
        Me.MnDBSetting.Id = 18
        Me.MnDBSetting.ImageIndex = 4
        Me.MnDBSetting.Name = "MnDBSetting"
        '
        'MnQueryTools
        '
        Me.MnQueryTools.Caption = "Query Tools"
        Me.MnQueryTools.Id = 14
        Me.MnQueryTools.ImageIndex = 0
        Me.MnQueryTools.Name = "MnQueryTools"
        '
        'BtnUpgradeStructure
        '
        Me.BtnUpgradeStructure.Caption = "Upgrade Structure (Depress 2011)"
        Me.BtnUpgradeStructure.Id = 26
        Me.BtnUpgradeStructure.ImageIndex = 8
        Me.BtnUpgradeStructure.Name = "BtnUpgradeStructure"
        Me.BtnUpgradeStructure.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "HOSxP"
        Me.BarSubItem3.Id = 20
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.MnHOSxPScreen)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'MnHOSxPScreen
        '
        Me.MnHOSxPScreen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnHOSxPScreen.Appearance.Options.UseFont = True
        Me.MnHOSxPScreen.Caption = "รายชื่อผูู้ที่ได้รับการคัดกรองจาก HOsP"
        Me.MnHOSxPScreen.Id = 21
        Me.MnHOSxPScreen.ImageIndex = 3
        Me.MnHOSxPScreen.Name = "MnHOSxPScreen"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Help"
        Me.BarSubItem4.Id = 23
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.MnManual), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnRemote), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnWebsite)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Register"
        Me.BarButtonItem3.Id = 25
        Me.BarButtonItem3.ImageIndex = 7
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "About"
        Me.BarButtonItem2.Id = 24
        Me.BarButtonItem2.ImageIndex = 6
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'MnManual
        '
        Me.MnManual.Caption = "คู่มือการใช้งาน"
        Me.MnManual.Id = 39
        Me.MnManual.ImageIndex = 18
        Me.MnManual.Name = "MnManual"
        '
        'BtnRemote
        '
        Me.BtnRemote.Caption = "Teamviewer"
        Me.BtnRemote.Id = 43
        Me.BtnRemote.ImageIndex = 19
        Me.BtnRemote.Name = "BtnRemote"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1269, 53)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 444)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1269, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 53)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 391)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1269, 53)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 391)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "File"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "ตรวจสอบ 18 แฟ้ม ก่อนนำเข้า"
        Me.BarSubItem5.Id = 29
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BtnChkPerson), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnChkService)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BtnChkPerson
        '
        Me.BtnChkPerson.Caption = "Person"
        Me.BtnChkPerson.Id = 30
        Me.BtnChkPerson.Name = "BtnChkPerson"
        '
        'BtnChkService
        '
        Me.BtnChkService.Caption = "Service"
        Me.BtnChkService.Id = 31
        Me.BtnChkService.Name = "BtnChkService"
        '
        'BtnWebsite
        '
        Me.BtnWebsite.Caption = "Website"
        Me.BtnWebsite.Id = 44
        Me.BtnWebsite.Name = "BtnWebsite"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 467)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmmain"
        Me.Text = "HOSxP 2 Depress 2011"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BtnSqlTool As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MnQueryTools As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MnPassScreen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnPassScreen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MnDBSetting As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents MnHOSxPScreen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnPersonList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnUpgradeStructure As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCheckOnlinePatient As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BtnChkPerson As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnChkService As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents MnChkPerson As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MnChkService As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MnChkCard As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnUpdateServer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnUpdateOffice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnDepression As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MnManual As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnHOSxP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnRemote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnWebsite As DevExpress.XtraBars.BarButtonItem
End Class
