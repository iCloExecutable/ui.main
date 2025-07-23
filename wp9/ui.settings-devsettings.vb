Public Class devmenu
    Private Sub devmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recent.Text = My.Settings.recntver
        current.Text = My.Resources.version
    End Sub
End Class