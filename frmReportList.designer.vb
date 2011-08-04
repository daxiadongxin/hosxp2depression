<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportList))
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ListGroup = New DevExpress.XtraEditors.ListBoxControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnNewGroup = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditGroup = New System.Windows.Forms.ToolStripButton()
        Me.BtnDeleteGroup = New System.Windows.Forms.ToolStripButton()
        Me.BtnRefreshGroup = New System.Windows.Forms.ToolStripButton()
        Me.ListReport = New DevExpress.XtraEditors.ListBoxControl()
        Me.Report1 = New FastReport.Report()
        Me.BtnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnView = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.BtnNewReport = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ListGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ListReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnRefresh)
        Me.Panel1.Controls.Add(Me.BtnView)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.PictureEdit1)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.BtnNewReport)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 54)
        Me.Panel1.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Appearance.Options.UseFont = True
        Me.BtnClose.Image = Global.Depression.My.Resources.Resources.breakpoint
        Me.BtnClose.Location = New System.Drawing.Point(799, 5)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(77, 37)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "ปิด"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(45, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 25)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "ระบบรายงาน"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 54)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ListGroup)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ListReport)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(881, 447)
        Me.SplitContainerControl1.SplitterPosition = 380
        Me.SplitContainerControl1.TabIndex = 1
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ListGroup
        '
        Me.ListGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListGroup.Location = New System.Drawing.Point(0, 25)
        Me.ListGroup.Name = "ListGroup"
        Me.ListGroup.Size = New System.Drawing.Size(380, 422)
        Me.ListGroup.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.BtnNewGroup, Me.BtnEditGroup, Me.BtnDeleteGroup, Me.BtnRefreshGroup})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(380, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel1.Text = "Group : "
        '
        'BtnNewGroup
        '
        Me.BtnNewGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewGroup.Name = "BtnNewGroup"
        Me.BtnNewGroup.Size = New System.Drawing.Size(31, 22)
        Me.BtnNewGroup.Text = "เพิ่ม"
        '
        'BtnEditGroup
        '
        Me.BtnEditGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditGroup.Name = "BtnEditGroup"
        Me.BtnEditGroup.Size = New System.Drawing.Size(39, 22)
        Me.BtnEditGroup.Text = "แก้ไข"
        '
        'BtnDeleteGroup
        '
        Me.BtnDeleteGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteGroup.Name = "BtnDeleteGroup"
        Me.BtnDeleteGroup.Size = New System.Drawing.Size(24, 22)
        Me.BtnDeleteGroup.Text = "ลบ"
        '
        'BtnRefreshGroup
        '
        Me.BtnRefreshGroup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefreshGroup.Name = "BtnRefreshGroup"
        Me.BtnRefreshGroup.Size = New System.Drawing.Size(50, 22)
        Me.BtnRefreshGroup.Text = "Refresh"
        '
        'ListReport
        '
        Me.ListReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListReport.Location = New System.Drawing.Point(0, 0)
        Me.ListReport.Name = "ListReport"
        Me.ListReport.Size = New System.Drawing.Size(496, 447)
        Me.ListReport.TabIndex = 1
        '
        'Report1
        '
        Me.Report1.ReportResourceString = resources.GetString("Report1.ReportResourceString")
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefresh.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.Appearance.Options.UseFont = True
        Me.BtnRefresh.Image = Global.Depression.My.Resources.Resources.document_refresh
        Me.BtnRefresh.Location = New System.Drawing.Point(467, 5)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(77, 37)
        Me.BtnRefresh.TabIndex = 7
        Me.BtnRefresh.Text = "Refresh"
        '
        'BtnView
        '
        Me.BtnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnView.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.Appearance.Options.UseFont = True
        Me.BtnView.Image = Global.Depression.My.Resources.Resources.document_view
        Me.BtnView.Location = New System.Drawing.Point(384, 5)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(77, 37)
        Me.BtnView.TabIndex = 6
        Me.BtnView.Text = "เรียกดู"
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Appearance.Options.UseFont = True
        Me.BtnEdit.Image = Global.Depression.My.Resources.Resources.document_edit
        Me.BtnEdit.Location = New System.Drawing.Point(633, 5)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(77, 37)
        Me.BtnEdit.TabIndex = 3
        Me.BtnEdit.Text = "แก้ไข"
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Appearance.Options.UseFont = True
        Me.BtnDelete.Image = Global.Depression.My.Resources.Resources.document_error
        Me.BtnDelete.Location = New System.Drawing.Point(716, 5)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(77, 37)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "ลบ"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.Depression.My.Resources.Resources.document_48
        Me.PictureEdit1.Location = New System.Drawing.Point(5, 5)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(34, 44)
        Me.PictureEdit1.TabIndex = 2
        '
        'BtnNewReport
        '
        Me.BtnNewReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewReport.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewReport.Appearance.Options.UseFont = True
        Me.BtnNewReport.Image = Global.Depression.My.Resources.Resources.document_add
        Me.BtnNewReport.Location = New System.Drawing.Point(550, 5)
        Me.BtnNewReport.Name = "BtnNewReport"
        Me.BtnNewReport.Size = New System.Drawing.Size(77, 37)
        Me.BtnNewReport.TabIndex = 0
        Me.BtnNewReport.Text = "เพิ่ม"
        '
        'frmReportList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 501)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReportList"
        Me.Text = "ระบบรายงาน"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ListGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ListReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BtnNewReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ListReport As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents BtnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListGroup As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BtnNewGroup As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnEditGroup As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnDeleteGroup As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnRefreshGroup As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnView As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Report1 As FastReport.Report
    Friend WithEvents BtnRefresh As DevExpress.XtraEditors.SimpleButton
End Class
