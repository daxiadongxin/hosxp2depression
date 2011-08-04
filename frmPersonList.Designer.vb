<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonList))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.BtnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnShowAll = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtFullname = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtCID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GridPerson = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TxtFullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BtnExit)
        Me.PanelControl1.Controls.Add(Me.BtnShowAll)
        Me.PanelControl1.Controls.Add(Me.BtnSearch)
        Me.PanelControl1.Controls.Add(Me.TxtFullname)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.TxtCID)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(756, 55)
        Me.PanelControl1.TabIndex = 12
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(659, 6)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(62, 23)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "ออก"
        '
        'BtnShowAll
        '
        Me.BtnShowAll.Location = New System.Drawing.Point(591, 6)
        Me.BtnShowAll.Name = "BtnShowAll"
        Me.BtnShowAll.Size = New System.Drawing.Size(62, 23)
        Me.BtnShowAll.TabIndex = 11
        Me.BtnShowAll.Text = "ดูทั้งหมด"
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(523, 6)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(62, 23)
        Me.BtnSearch.TabIndex = 10
        Me.BtnSearch.Text = "ค้นหา"
        '
        'TxtFullname
        '
        Me.TxtFullname.Location = New System.Drawing.Point(290, 9)
        Me.TxtFullname.Name = "TxtFullname"
        Me.TxtFullname.Size = New System.Drawing.Size(227, 20)
        Me.TxtFullname.TabIndex = 9
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(237, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "ชื่อ - สกุล"
        '
        'TxtCID
        '
        Me.TxtCID.Location = New System.Drawing.Point(109, 9)
        Me.TxtCID.Name = "TxtCID"
        Me.TxtCID.Properties.MaxLength = 13
        Me.TxtCID.Size = New System.Drawing.Size(122, 20)
        Me.TxtCID.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "รหัสบัตรประชาชน"
        '
        'GridPerson
        '
        Me.GridPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPerson.Location = New System.Drawing.Point(0, 55)
        Me.GridPerson.MainView = Me.GridView1
        Me.GridPerson.Name = "GridPerson"
        Me.GridPerson.Size = New System.Drawing.Size(756, 424)
        Me.GridPerson.TabIndex = 13
        Me.GridPerson.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GridView1.GridControl = Me.GridPerson
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "เลขที่บัตรประชาชน"
        Me.GridColumn1.FieldName = "cid"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "คำนำหน้า"
        Me.GridColumn2.FieldName = "Prename"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ชื่อ"
        Me.GridColumn3.FieldName = "firstname"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "นามสกุล"
        Me.GridColumn4.FieldName = "lastname"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "อายุ"
        Me.GridColumn5.FieldName = "age"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "รหัสสิทธิ์"
        Me.GridColumn6.FieldName = "cardtype"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "สิทธิ์การรักษา"
        Me.GridColumn7.FieldName = "ctypename"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "เลขที่สิทธิ์"
        Me.GridColumn8.FieldName = "cardid"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "วันที่เริ่มใช้"
        Me.GridColumn9.FieldName = "mfgdate"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "วันหมดอายุ"
        Me.GridColumn10.FieldName = "expdate"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "วันเกิด"
        Me.GridColumn11.FieldName = "birthday"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 10
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "โรคเรื้อรัง"
        Me.GridColumn12.FieldName = "r1"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        '
        'frmPersonList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 479)
        Me.Controls.Add(Me.GridPerson)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPersonList"
        Me.Text = "รายชื่อประชาชน"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TxtFullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridPerson As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtCID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtFullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnShowAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
End Class
