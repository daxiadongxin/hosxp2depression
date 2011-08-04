Public Class frmDebug

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click

        Me.Dispose()

    End Sub

    Private Sub frmDebug_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCopySQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopySQL.Click
        Try
            Clipboard.SetText(Me.MemoSQL.Text)
        Catch ex As Exception

        End Try


    End Sub
End Class