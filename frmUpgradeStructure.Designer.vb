<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpgradeStructure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpgradeStructure))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.BtnUpgrade = New DevExpress.XtraEditors.SimpleButton
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.BtnUpgrade)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(466, 58)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "ปรับโครงสร้าง"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.MemoEdit1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 58)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(466, 235)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "คำสั่ง SQL"
        '
        'BtnUpgrade
        '
        Me.BtnUpgrade.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnUpgrade.Location = New System.Drawing.Point(379, 29)
        Me.BtnUpgrade.Name = "BtnUpgrade"
        Me.BtnUpgrade.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpgrade.TabIndex = 0
        Me.BtnUpgrade.Text = "Upgarde"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoEdit1.EditValue = "ALTER TABLE tbPerson ADD inregion varchar(1) "
        Me.MemoEdit1.Location = New System.Drawing.Point(2, 22)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(462, 211)
        Me.MemoEdit1.TabIndex = 0
        '
        'frmUpgradeStructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 293)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUpgradeStructure"
        Me.Text = "ปรับโครงสร้างฐานข้อมูล"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnUpgrade As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
End Class
