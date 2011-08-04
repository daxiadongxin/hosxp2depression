<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsql
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsql))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.CboTablelist = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.BtnRun = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnExcute = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnTableInfo = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnStructure = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnResetDB = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnBrowse = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnSaveSQL = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnExcelExport = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.MemoSql = New ICSharpCode.TextEditor.TextEditorControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.TabResults = New DevExpress.XtraTab.XtraTabControl()
        Me.TabpageGrid = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabpageMessage = New DevExpress.XtraTab.XtraTabPage()
        Me.MemoSQLEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.TabResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabResults.SuspendLayout()
        Me.TabpageGrid.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabpageMessage.SuspendLayout()
        CType(Me.MemoSQLEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImageCollection1
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.CboTablelist, Me.BtnRun, Me.BtnExcute, Me.BtnClose, Me.BtnStructure, Me.BtnTableInfo, Me.BtnResetDB, Me.BtnSaveSQL, Me.BtnExcelExport, Me.BtnBrowse})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 13
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemComboBox1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(216, 127)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.CboTablelist), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnRun, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnExcute, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnTableInfo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnStructure, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnResetDB, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnBrowse, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnSaveSQL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnExcelExport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "  Table  "
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'CboTablelist
        '
        Me.CboTablelist.Caption = "BarEditItem1"
        Me.CboTablelist.Edit = Me.RepositoryItemComboBox1
        Me.CboTablelist.Id = 3
        Me.CboTablelist.Name = "CboTablelist"
        Me.CboTablelist.Width = 200
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'BtnRun
        '
        Me.BtnRun.Caption = "Run"
        Me.BtnRun.Id = 4
        Me.BtnRun.ImageIndex = 1
        Me.BtnRun.Name = "BtnRun"
        '
        'BtnExcute
        '
        Me.BtnExcute.Caption = "Execute"
        Me.BtnExcute.Id = 5
        Me.BtnExcute.ImageIndex = 0
        Me.BtnExcute.Name = "BtnExcute"
        '
        'BtnTableInfo
        '
        Me.BtnTableInfo.Caption = "Table Info"
        Me.BtnTableInfo.Id = 8
        Me.BtnTableInfo.ImageIndex = 4
        Me.BtnTableInfo.Name = "BtnTableInfo"
        '
        'BtnStructure
        '
        Me.BtnStructure.Caption = "Table Structure"
        Me.BtnStructure.Id = 7
        Me.BtnStructure.ImageIndex = 3
        Me.BtnStructure.Name = "BtnStructure"
        '
        'BtnResetDB
        '
        Me.BtnResetDB.Caption = "Reset DB"
        Me.BtnResetDB.Id = 9
        Me.BtnResetDB.ImageIndex = 5
        Me.BtnResetDB.Name = "BtnResetDB"
        '
        'BtnBrowse
        '
        Me.BtnBrowse.Caption = "Browse"
        Me.BtnBrowse.Id = 12
        Me.BtnBrowse.ImageIndex = 8
        Me.BtnBrowse.Name = "BtnBrowse"
        '
        'BtnSaveSQL
        '
        Me.BtnSaveSQL.Caption = "Save SQL"
        Me.BtnSaveSQL.Id = 10
        Me.BtnSaveSQL.ImageIndex = 6
        Me.BtnSaveSQL.Name = "BtnSaveSQL"
        '
        'BtnExcelExport
        '
        Me.BtnExcelExport.Caption = "Excel Export"
        Me.BtnExcelExport.Id = 11
        Me.BtnExcelExport.ImageIndex = 7
        Me.BtnExcelExport.Name = "BtnExcelExport"
        '
        'BtnClose
        '
        Me.BtnClose.Caption = "Close"
        Me.BtnClose.Id = 6
        Me.BtnClose.ImageIndex = 2
        Me.BtnClose.Name = "BtnClose"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1032, 46)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 427)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1032, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 46)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 381)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1032, 46)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 381)
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "flash.png")
        Me.ImageCollection1.Images.SetKeyName(1, "bullet_triangle_green.png")
        Me.ImageCollection1.Images.SetKeyName(2, "delete.png")
        Me.ImageCollection1.Images.SetKeyName(3, "branch_view.png")
        Me.ImageCollection1.Images.SetKeyName(4, "text_italics.png")
        Me.ImageCollection1.Images.SetKeyName(5, "data_replace.png")
        Me.ImageCollection1.Images.SetKeyName(6, "disk_green.png")
        Me.ImageCollection1.Images.SetKeyName(7, "Excel.jpg")
        Me.ImageCollection1.Images.SetKeyName(8, "folder.png")
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.MemoSql)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 46)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1032, 112)
        Me.PanelControl1.TabIndex = 4
        '
        'MemoSql
        '
        Me.MemoSql.AllowDrop = True
        Me.MemoSql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoSql.IsReadOnly = False
        Me.MemoSql.Location = New System.Drawing.Point(2, 2)
        Me.MemoSql.Name = "MemoSql"
        Me.MemoSql.Size = New System.Drawing.Size(1028, 108)
        Me.MemoSql.TabIndex = 2
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Gray
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Controls.Add(Me.TabResults)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 158)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1032, 269)
        Me.PanelControl2.TabIndex = 5
        '
        'TabResults
        '
        Me.TabResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabResults.Location = New System.Drawing.Point(2, 2)
        Me.TabResults.Name = "TabResults"
        Me.TabResults.SelectedTabPage = Me.TabpageGrid
        Me.TabResults.Size = New System.Drawing.Size(1028, 265)
        Me.TabResults.TabIndex = 1
        Me.TabResults.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabpageGrid, Me.TabpageMessage})
        '
        'TabpageGrid
        '
        Me.TabpageGrid.Controls.Add(Me.GridControl1)
        Me.TabpageGrid.Image = Global.Depression.My.Resources.Resources.column
        Me.TabpageGrid.Name = "TabpageGrid"
        Me.TabpageGrid.Size = New System.Drawing.Size(1022, 236)
        Me.TabpageGrid.Text = "Results"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1022, 236)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        '
        'TabpageMessage
        '
        Me.TabpageMessage.Controls.Add(Me.MemoSQLEdit)
        Me.TabpageMessage.Image = Global.Depression.My.Resources.Resources.document_text
        Me.TabpageMessage.Name = "TabpageMessage"
        Me.TabpageMessage.Size = New System.Drawing.Size(1022, 236)
        Me.TabpageMessage.Text = "Message"
        '
        'MemoSQLEdit
        '
        Me.MemoSQLEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoSQLEdit.Location = New System.Drawing.Point(0, 0)
        Me.MemoSQLEdit.MenuManager = Me.BarManager1
        Me.MemoSQLEdit.Name = "MemoSQLEdit"
        Me.MemoSQLEdit.Size = New System.Drawing.Size(1022, 236)
        Me.MemoSQLEdit.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmsql
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 450)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmsql"
        Me.Text = "SQL Tools"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.TabResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabResults.ResumeLayout(False)
        Me.TabpageGrid.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabpageMessage.ResumeLayout(False)
        CType(Me.MemoSQLEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents CboTablelist As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BtnRun As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnExcute As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents BtnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TabResults As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabpageGrid As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabpageMessage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MemoSQLEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents BtnStructure As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnTableInfo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnResetDB As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnSaveSQL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnExcelExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnBrowse As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MemoSql As ICSharpCode.TextEditor.TextEditorControl

End Class
