Public Class browser
    Private Sub GoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToolStripMenuItem.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Resources.browsercompatwarn = "1" Then
            warning.Text = "This browser is built on TreCore 2.5. HTTPS connections might not be secure."
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            WebBrowser1.Navigate(TextBox1.Text)
            e.Handled = True
        End If
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        My.Forms.browserabout.ShowDialog()

    End Sub

    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        WebBrowser1.GoBack()

    End Sub

    Private Sub GoForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoForwardToolStripMenuItem.Click
        WebBrowser1.GoForward()

    End Sub

    Private Sub GoToHomePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToHomePageToolStripMenuItem.Click
        WebBrowser1.Navigate("https://google.com")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class