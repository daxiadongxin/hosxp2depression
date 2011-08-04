<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBSetting
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDBSetting))
        Me.BtnOK = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnTest = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtHOSxPDatabase = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtHOSxPPassword = New System.Windows.Forms.TextBox
        Me.TxtHOSxPUser = New System.Windows.Forms.TextBox
        Me.TxtHOSxPPort = New System.Windows.Forms.TextBox
        Me.TxtHOSxPHost = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnExportSetting = New System.Windows.Forms.Button
        Me.BtnImportSetting = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.MySQLLogo = New System.Windows.Forms.PictureBox
        Me.GroupBox2.SuspendLayout()
        CType(Me.MySQLLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(224, 225)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(70, 25)
        Me.BtnOK.TabIndex = 11
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(300, 225)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(70, 25)
        Me.BtnCancel.TabIndex = 12
        Me.BtnCancel.Text = "Close"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnTest
        '
        Me.BtnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnTest.Location = New System.Drawing.Point(243, 55)
        Me.BtnTest.Name = "BtnTest"
        Me.BtnTest.Size = New System.Drawing.Size(115, 72)
        Me.BtnTest.TabIndex = 10
        Me.BtnTest.Text = "Test"
        Me.BtnTest.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtHOSxPDatabase)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtHOSxPPassword)
        Me.GroupBox2.Controls.Add(Me.BtnTest)
        Me.GroupBox2.Controls.Add(Me.TxtHOSxPUser)
        Me.GroupBox2.Controls.Add(Me.TxtHOSxPPort)
        Me.GroupBox2.Controls.Add(Me.TxtHOSxPHost)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 142)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Connect to HOSxP Database Server"
        '
        'TxtHOSxPDatabase
        '
        Me.TxtHOSxPDatabase.Location = New System.Drawing.Point(104, 107)
        Me.TxtHOSxPDatabase.Name = "TxtHOSxPDatabase"
        Me.TxtHOSxPDatabase.Size = New System.Drawing.Size(126, 20)
        Me.TxtHOSxPDatabase.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Database:"
        '
        'TxtHOSxPPassword
        '
        Me.TxtHOSxPPassword.Location = New System.Drawing.Point(103, 81)
        Me.TxtHOSxPPassword.Name = "TxtHOSxPPassword"
        Me.TxtHOSxPPassword.Size = New System.Drawing.Size(126, 20)
        Me.TxtHOSxPPassword.TabIndex = 8
        Me.TxtHOSxPPassword.UseSystemPasswordChar = True
        '
        'TxtHOSxPUser
        '
        Me.TxtHOSxPUser.Location = New System.Drawing.Point(103, 55)
        Me.TxtHOSxPUser.Name = "TxtHOSxPUser"
        Me.TxtHOSxPUser.Size = New System.Drawing.Size(127, 20)
        Me.TxtHOSxPUser.TabIndex = 7
        '
        'TxtHOSxPPort
        '
        Me.TxtHOSxPPort.Location = New System.Drawing.Point(275, 29)
        Me.TxtHOSxPPort.Name = "TxtHOSxPPort"
        Me.TxtHOSxPPort.Size = New System.Drawing.Size(46, 20)
        Me.TxtHOSxPPort.TabIndex = 6
        '
        'TxtHOSxPHost
        '
        Me.TxtHOSxPHost.Location = New System.Drawing.Point(103, 29)
        Me.TxtHOSxPHost.Name = "TxtHOSxPHost"
        Me.TxtHOSxPHost.Size = New System.Drawing.Size(127, 20)
        Me.TxtHOSxPHost.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Port:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Username:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Server Host:"
        '
        'BtnExportSetting
        '
        Me.BtnExportSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnExportSetting.Location = New System.Drawing.Point(66, 227)
        Me.BtnExportSetting.Name = "BtnExportSetting"
        Me.BtnExportSetting.Size = New System.Drawing.Size(52, 24)
        Me.BtnExportSetting.TabIndex = 14
        Me.BtnExportSetting.Text = "Export"
        Me.BtnExportSetting.UseVisualStyleBackColor = True
        '
        'BtnImportSetting
        '
        Me.BtnImportSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.BtnImportSetting.Location = New System.Drawing.Point(7, 227)
        Me.BtnImportSetting.Name = "BtnImportSetting"
        Me.BtnImportSetting.Size = New System.Drawing.Size(53, 24)
        Me.BtnImportSetting.TabIndex = 13
        Me.BtnImportSetting.Text = "Import"
        Me.BtnImportSetting.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MySQLLogo
        '
        Me.MySQLLogo.Image = CType(resources.GetObject("MySQLLogo.Image"), System.Drawing.Image)
        Me.MySQLLogo.Location = New System.Drawing.Point(-4, -1)
        Me.MySQLLogo.Name = "MySQLLogo"
        Me.MySQLLogo.Size = New System.Drawing.Size(374, 72)
        Me.MySQLLogo.TabIndex = 6
        Me.MySQLLogo.TabStop = False
        '
        'frmDBSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 263)
        Me.Controls.Add(Me.BtnImportSetting)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnExportSetting)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.MySQLLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDBSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตั้งค่า connection"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MySQLLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents MySQLLogo As System.Windows.Forms.PictureBox
    Friend WithEvents BtnTest As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtHOSxPDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtHOSxPPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtHOSxPUser As System.Windows.Forms.TextBox
    Friend WithEvents TxtHOSxPPort As System.Windows.Forms.TextBox
    Friend WithEvents TxtHOSxPHost As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnExportSetting As System.Windows.Forms.Button
    Friend WithEvents BtnImportSetting As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
