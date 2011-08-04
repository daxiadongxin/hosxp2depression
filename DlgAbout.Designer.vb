<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgAbout
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(257, 250)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.Depression.My.Resources.Resources.Security
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(57, 58)
        Me.PictureEdit1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Location = New System.Drawing.Point(86, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(183, 30)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "HOSxP2Depression"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LabelControl2.Location = New System.Drawing.Point(275, 21)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 30)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "2011"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(84, 57)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Version 1.0.0"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.LabelControl4.Location = New System.Drawing.Point(86, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(90, 11)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Wichianburi Hospital@"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(84, 76)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(125, 13)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "ผู้พัฒนา : ปิยะณัฐ นิ่มขุนทด"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(84, 95)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(221, 13)
        Me.LabelControl6.TabIndex = 8
        Me.LabelControl6.Text = "สถานที่ทำงาน : โรงพยาบาลวิเชียรบุรี จ.เพชรบูรณ์"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(86, 114)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl7.TabIndex = 9
        '
        'MemoEdit1
        '
        Me.MemoEdit1.EditValue = "คำเตือน : โปรแกรมนี้ทำขึ้นเพื่ออำนวยความสะดวกในการใช้งาน HOSxP ร่วมกับโปรแกรมคัดก" & _
            "รองโรคซึมเศร้าเท่านั้น ผู้ที่สนใจสามารถนำไปใช้งานได้โดยไม่เสียค่าใช้จ่ายแต่อย่าง" & _
            "ใด"
        Me.MemoEdit1.Location = New System.Drawing.Point(86, 168)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(314, 73)
        Me.MemoEdit1.TabIndex = 10
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(84, 128)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl8.TabIndex = 11
        Me.LabelControl8.Text = "Email :"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(84, 147)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl9.TabIndex = 12
        Me.LabelControl9.Text = "Blog :"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(121, 128)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(113, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "farmonline@gmail.com"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(121, 147)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(152, 13)
        Me.LinkLabel2.TabIndex = 14
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "http://farmonline.blogspot.com"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(121, 111)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(126, 13)
        Me.LinkLabel3.TabIndex = 16
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "wichianhos.thaiddns.com"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(84, 111)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl10.TabIndex = 15
        Me.LabelControl10.Text = "URL :"
        '
        'DlgAbout
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(415, 291)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.MemoEdit1)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl

End Class
