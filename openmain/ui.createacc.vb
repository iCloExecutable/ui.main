
' ui.createacc
' written by micraia @ webmaster@iclostudios.ml, ported from iCloOS 1.0
' 2025 iCloCorp. All rights reserved.

Public Class createacc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' ayarları kaydet

        My.Settings.usrnme = TextBox1.Text
        My.Settings.passwd = TextBox2.Text
        My.Settings.email = TextBox3.Text

        My.Settings.Save()
        MsgBox("Ayarlar kaydedildi.")
        Me.Close()

    End Sub

    Private Sub createacc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class