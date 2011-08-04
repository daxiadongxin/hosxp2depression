<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOffice))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtOfficeCode = New DevExpress.XtraEditors.TextEdit()
        Me.TxtProvince = New DevExpress.XtraEditors.TextEdit()
        Me.TxtTumbon = New DevExpress.XtraEditors.TextEdit()
        Me.TxtAmph = New DevExpress.XtraEditors.TextEdit()
        Me.CboOffice = New System.Windows.Forms.ComboBox()
        Me.CboProvince = New System.Windows.Forms.ComboBox()
        Me.CboAmp = New System.Windows.Forms.ComboBox()
        Me.CboTumbon = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnNew = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TxtOfficeCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtProvince.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTumbon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAmph.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(139, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "รหัสหน่วยงาน"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(172, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "จังหวัด"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(175, 73)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "อำเภอ"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(175, 102)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "ตำบล"
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.Location = New System.Drawing.Point(284, 125)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 8
        Me.BtnOK.Text = "บันทึก"
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Location = New System.Drawing.Point(446, 124)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 9
        Me.BtnCancel.Text = "ยกเลิก"
        '
        'TxtOfficeCode
        '
        Me.TxtOfficeCode.Location = New System.Drawing.Point(224, 12)
        Me.TxtOfficeCode.Name = "TxtOfficeCode"
        Me.TxtOfficeCode.Properties.Mask.EditMask = "00000"
        Me.TxtOfficeCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtOfficeCode.Properties.MaxLength = 5
        Me.TxtOfficeCode.Size = New System.Drawing.Size(54, 20)
        Me.TxtOfficeCode.TabIndex = 10
        '
        'TxtProvince
        '
        Me.TxtProvince.Location = New System.Drawing.Point(224, 41)
        Me.TxtProvince.Name = "TxtProvince"
        Me.TxtProvince.Properties.Mask.EditMask = "00"
        Me.TxtProvince.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.TxtProvince.Properties.MaxLength = 2
        Me.TxtProvince.Size = New System.Drawing.Size(34, 20)
        Me.TxtProvince.TabIndex = 12
        '
        'TxtTumbon
        '
        Me.TxtTumbon.Location = New System.Drawing.Point(224, 99)
        Me.TxtTumbon.Name = "TxtTumbon"
        Me.TxtTumbon.Properties.Mask.EditMask = "00"
        Me.TxtTumbon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtTumbon.Properties.MaxLength = 2
        Me.TxtTumbon.Size = New System.Drawing.Size(34, 20)
        Me.TxtTumbon.TabIndex = 16
        '
        'TxtAmph
        '
        Me.TxtAmph.Location = New System.Drawing.Point(224, 70)
        Me.TxtAmph.Name = "TxtAmph"
        Me.TxtAmph.Properties.Mask.EditMask = "00"
        Me.TxtAmph.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TxtAmph.Properties.MaxLength = 2
        Me.TxtAmph.Size = New System.Drawing.Size(34, 20)
        Me.TxtAmph.TabIndex = 14
        '
        'CboOffice
        '
        Me.CboOffice.FormattingEnabled = True
        Me.CboOffice.Location = New System.Drawing.Point(284, 12)
        Me.CboOffice.Name = "CboOffice"
        Me.CboOffice.Size = New System.Drawing.Size(237, 21)
        Me.CboOffice.TabIndex = 18
        '
        'CboProvince
        '
        Me.CboProvince.FormattingEnabled = True
        Me.CboProvince.Location = New System.Drawing.Point(284, 40)
        Me.CboProvince.Name = "CboProvince"
        Me.CboProvince.Size = New System.Drawing.Size(237, 21)
        Me.CboProvince.TabIndex = 19
        '
        'CboAmp
        '
        Me.CboAmp.FormattingEnabled = True
        Me.CboAmp.Location = New System.Drawing.Point(284, 70)
        Me.CboAmp.Name = "CboAmp"
        Me.CboAmp.Size = New System.Drawing.Size(235, 21)
        Me.CboAmp.TabIndex = 20
        '
        'CboTumbon
        '
        Me.CboTumbon.FormattingEnabled = True
        Me.CboTumbon.Location = New System.Drawing.Point(284, 97)
        Me.CboTumbon.Name = "CboTumbon"
        Me.CboTumbon.Size = New System.Drawing.Size(235, 21)
        Me.CboTumbon.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Depression.My.Resources.Resources.moph4
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 120)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNew.Location = New System.Drawing.Point(365, 124)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 23)
        Me.BtnNew.TabIndex = 23
        Me.BtnNew.Text = "เริ่มใหม่"
        '
        'frmOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(528, 157)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CboTumbon)
        Me.Controls.Add(Me.CboAmp)
        Me.Controls.Add(Me.CboProvince)
        Me.Controls.Add(Me.CboOffice)
        Me.Controls.Add(Me.TxtTumbon)
        Me.Controls.Add(Me.TxtAmph)
        Me.Controls.Add(Me.TxtProvince)
        Me.Controls.Add(Me.TxtOfficeCode)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOffice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตั้งค่าหน่วยงาน"
        CType(Me.TxtOfficeCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtProvince.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTumbon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAmph.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtOfficeCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtProvince As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTumbon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtAmph As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CboOffice As System.Windows.Forms.ComboBox
    Friend WithEvents CboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents CboAmp As System.Windows.Forms.ComboBox
    Friend WithEvents CboTumbon As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnNew As DevExpress.XtraEditors.SimpleButton
End Class
