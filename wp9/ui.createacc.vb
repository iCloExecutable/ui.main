Public Class createacc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.usrnme = TextBox1.Text
        My.Settings.passwd = TextBox2.Text
        My.Settings.email = TextBox3.Text

        My.Settings.Save()
        MsgBox("Ayarlar kaydedildi.")


    End Sub

    Private Sub createacc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class