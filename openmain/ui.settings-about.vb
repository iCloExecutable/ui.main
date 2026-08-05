Public Class aboutpopup
    Private Sub aboutpopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.premainappsupport = "1" Then
            compatmode.Text = "Compatibility mode enabled. Apps might be unsecure"
        Else
            compatmode.Text = ""
        End If
        Label2.Text = "build " + My.Resources.build_number

        Label4.Text = "channel " + My.Resources.build_channel
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        devmenu.ShowDialog()

    End Sub
End Class