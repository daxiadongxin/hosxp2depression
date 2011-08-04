<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviewReport
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
        Me.PreviewControl2 = New FastReport.Preview.PreviewControl()
        Me.SuspendLayout()
        '
        'PreviewControl2
        '
        Me.PreviewControl2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PreviewControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PreviewControl2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.PreviewControl2.Location = New System.Drawing.Point(0, 0)
        Me.PreviewControl2.Name = "PreviewControl2"
        Me.PreviewControl2.Size = New System.Drawing.Size(719, 490)
        Me.PreviewControl2.TabIndex = 1
        Me.PreviewControl2.UIStyle = FastReport.Utils.UIStyle.Office2007Black
        '
        'frmPreviewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 490)
        Me.Controls.Add(Me.PreviewControl2)
        Me.Name = "frmPreviewReport"
        Me.Text = "รายงาน"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PreviewControl2 As FastReport.Preview.PreviewControl
End Class
