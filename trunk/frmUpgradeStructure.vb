Public Class frmUpgradeStructure
    Dim strsql As String
    Dim _mysql As New ClsSQLhelper
    Private Sub BtnUpgrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpgrade.Click
        MsgBox("การ Upgrade โครงสร้างฐานข้อมูลนี้ใช้เฉพาะกับ Depress 2011 ไม่มีผลใดๆกับ HOSxP", MsgBoxStyle.Information, "ข้อความ")
        If MsgBox("กรุณายืนยันการ upgrade โครงสร้างฐานข้อมูล", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน") = MsgBoxResult.No Then Exit Sub
        If _mysql.Execute(Me.MemoEdit1.Text) <> -1 Then
            MsgBox("การปรับโครงสร้างไม่สำเร็จ กรุณาตรวจสอบคำสั่ง", MsgBoxStyle.Critical, "ผลการปรับปรุงโครงสร้าง")
        Else
            MsgBox("การปรับปรุงโครงสร้างสำเร็จแล้ว", MsgBoxStyle.Information, "ผลการปรับปรุงโครงสร้าง")
        End If

    End Sub

    Private Sub frmUpgradeStructure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MemoEdit1.Text = "Alter table tbPerson ADD inregion varchar(1)"
    End Sub
End Class