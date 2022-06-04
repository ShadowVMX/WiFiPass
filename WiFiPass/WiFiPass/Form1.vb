Public Class FrmWIFI

    Private Sub CMDLEAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDLEAVE.Click
        End
    End Sub

    Private Sub CMDSTART_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSTART.Click
        Process.Start("cmd", "/k C:\Users\%username%\Desktop\WiPass.bat")
    End Sub
End Class
