Public Class Form2

    Private Sub GhostButton1_Click(sender As Object, e As EventArgs) Handles GhostButton1.Click
        Clipboard.Clear()
        Clipboard.SetText(TextBox1.Text)
        MsgBox("Copied", MsgBoxStyle.Information, "Information")
    End Sub
End Class