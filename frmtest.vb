Public Class frmtest
    Dim str As String
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        str = (ChrW(3588) & ChrW(3635) & ChrW(3609) & ChrW(3635) & ChrW(3627) & ChrW(3609) & ChrW(3657) & ChrW(3634) & ChrW(3594) & ChrW(3639) & ChrW(3656) & ChrW(3629) & ChrW(10))
        MsgBox(str)
    End Sub
End Class