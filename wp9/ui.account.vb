
' ui.account
' written by micraia @ webmaster@iclostudios.ml, ported from iCloOS 3.0
' 2025 iCloCorp. All rights reserved.

Public Class accountui
    Private Sub accountui_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = My.Settings.usrnme
        Label2.Text = My.Settings.email

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.usrnme = TextBox1.Text
        My.Settings.Save()
        MsgBox("Username has been changed.")
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.passwd = TextBox2.Text
        My.Settings.Save()
        MsgBox("Password has been changed.")
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.email = TextBox3.Text
        My.Settings.Save()
        MsgBox("Email has been changed.")
        TextBox3.Text = ""
    End Sub
End Class