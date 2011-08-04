<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MsgBoxImport
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.lbltotalrows = New DevExpress.XtraEditors.LabelControl
        Me.lblUncomplete = New DevExpress.XtraEditors.LabelControl
        Me.lblComplete = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.MemoCID = New DevExpress.XtraEditors.MemoEdit
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoCID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 275)
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
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(50, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "ผ่านทั้งสิ้น"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(50, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "ไม่ผ่านทั้งสิ้น"
        '
        'PictureEdit3
        '
        Me.PictureEdit3.EditValue = Global.Depression.My.Resources.Resources.column1
        Me.PictureEdit3.Location = New System.Drawing.Point(14, 65)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit3.Size = New System.Drawing.Size(30, 20)
        Me.PictureEdit3.TabIndex = 6
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = Global.Depression.My.Resources.Resources.delete
        Me.PictureEdit2.Location = New System.Drawing.Point(12, 38)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Size = New System.Drawing.Size(30, 20)
        Me.PictureEdit2.TabIndex = 3
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.Depression.My.Resources.Resources.check
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Size = New System.Drawing.Size(30, 20)
        Me.PictureEdit1.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(50, 69)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "รวมทั้งสิ้น"
        '
        'lbltotalrows
        '
        Me.lbltotalrows.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalrows.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbltotalrows.Appearance.Options.UseFont = True
        Me.lbltotalrows.Appearance.Options.UseForeColor = True
        Me.lbltotalrows.Location = New System.Drawing.Point(140, 69)
        Me.lbltotalrows.Name = "lbltotalrows"
        Me.lbltotalrows.Size = New System.Drawing.Size(7, 13)
        Me.lbltotalrows.TabIndex = 10
        Me.lbltotalrows.Text = "0"
        '
        'lblUncomplete
        '
        Me.lblUncomplete.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUncomplete.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblUncomplete.Appearance.Options.UseFont = True
        Me.lblUncomplete.Appearance.Options.UseForeColor = True
        Me.lblUncomplete.Location = New System.Drawing.Point(140, 41)
        Me.lblUncomplete.Name = "lblUncomplete"
        Me.lblUncomplete.Size = New System.Drawing.Size(7, 13)
        Me.lblUncomplete.TabIndex = 9
        Me.lblUncomplete.Text = "0"
        '
        'lblComplete
        '
        Me.lblComplete.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplete.Appearance.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblComplete.Appearance.Options.UseFont = True
        Me.lblComplete.Appearance.Options.UseForeColor = True
        Me.lblComplete.Location = New System.Drawing.Point(140, 16)
        Me.lblComplete.Name = "lblComplete"
        Me.lblComplete.Size = New System.Drawing.Size(7, 13)
        Me.lblComplete.TabIndex = 8
        Me.lblComplete.Text = "0"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(179, 69)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "แถว"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(179, 41)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl8.TabIndex = 12
        Me.LabelControl8.Text = "แถว"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(179, 16)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl9.TabIndex = 11
        Me.LabelControl9.Text = "แถว"
        '
        'MemoCID
        '
        Me.MemoCID.Location = New System.Drawing.Point(14, 91)
        Me.MemoCID.Name = "MemoCID"
        Me.MemoCID.Size = New System.Drawing.Size(409, 177)
        Me.MemoCID.TabIndex = 14
        '
        'MsgBoxImport
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 316)
        Me.Controls.Add(Me.MemoCID)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.lbltotalrows)
        Me.Controls.Add(Me.lblUncomplete)
        Me.Controls.Add(Me.lblComplete)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.PictureEdit3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PictureEdit2)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MsgBoxImport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HOSxP2Depression"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoCID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbltotalrows As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUncomplete As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblComplete As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoCID As DevExpress.XtraEditors.MemoEdit

End Class
