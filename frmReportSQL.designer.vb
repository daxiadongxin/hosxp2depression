<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportSQL
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportSQL))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnTest = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDesign = New DevExpress.XtraEditors.SimpleButton()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.MemoSQL = New DevExpress.XtraEditors.MemoEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.TxtRptName = New System.Windows.Forms.TextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Report1 = New FastReport.Report()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.MemoSQL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnTest)
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.BtnClose)
        Me.PanelControl1.Controls.Add(Me.BtnDesign)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1120, 71)
        Me.PanelControl1.TabIndex = 0
        '
        'BtnTest
        '
        Me.BtnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTest.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTest.Appearance.Options.UseFont = True
        Me.BtnTest.Image = Global.Depression.My.Resources.Resources.bullet_triangle_green
        Me.BtnTest.Location = New System.Drawing.Point(795, 12)
        Me.BtnTest.Name = "BtnTest"
        Me.BtnTest.Size = New System.Drawing.Size(122, 37)
        Me.BtnTest.TabIndex = 12
        Me.BtnTest.Text = "ยืนยันคำสั่ง SQL"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.Depression.My.Resources.Resources.document_48
        Me.PictureEdit1.Location = New System.Drawing.Point(10, 17)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(34, 44)
        Me.PictureEdit1.TabIndex = 11
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(50, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 25)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "คำสั่ง SQL"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Appearance.Options.UseFont = True
        Me.BtnClose.Image = Global.Depression.My.Resources.Resources.breakpoint
        Me.BtnClose.Location = New System.Drawing.Point(1026, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(77, 37)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.Text = "ปิด"
        '
        'BtnDesign
        '
        Me.BtnDesign.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDesign.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDesign.Appearance.Options.UseFont = True
        Me.BtnDesign.Enabled = False
        Me.BtnDesign.Image = Global.Depression.My.Resources.Resources.contract
        Me.BtnDesign.Location = New System.Drawing.Point(923, 12)
        Me.BtnDesign.Name = "BtnDesign"
        Me.BtnDesign.Size = New System.Drawing.Size(97, 37)
        Me.BtnDesign.TabIndex = 8
        Me.BtnDesign.Text = "Design"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 71)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.MemoSQL)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1120, 420)
        Me.SplitContainerControl1.SplitterPosition = 170
        Me.SplitContainerControl1.TabIndex = 2
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'MemoSQL
        '
        Me.MemoSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoSQL.Location = New System.Drawing.Point(0, 28)
        Me.MemoSQL.Name = "MemoSQL"
        Me.MemoSQL.Size = New System.Drawing.Size(1120, 142)
        Me.MemoSQL.TabIndex = 3
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.TxtRptName)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1120, 28)
        Me.PanelControl2.TabIndex = 0
        '
        'TxtRptName
        '
        Me.TxtRptName.Location = New System.Drawing.Point(75, 3)
        Me.TxtRptName.Name = "TxtRptName"
        Me.TxtRptName.Size = New System.Drawing.Size(408, 21)
        Me.TxtRptName.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "ชื่อ Report"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1120, 245)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'Report1
        '
        Me.Report1.ReportResourceString = resources.GetString("Report1.ReportResourceString")
        '
        'frmReportSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 491)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmReportSQL"
        Me.Text = "คำสั่ง SQL"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.MemoSQL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDesign As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnTest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Report1 As FastReport.Report
    Friend WithEvents MemoSQL As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtRptName As System.Windows.Forms.TextBox
End Class
