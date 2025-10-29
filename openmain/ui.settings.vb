Imports System.IO
Imports System.Text
Imports System.Net

' ui.settings
' written by micraia @ webmaster@iclostudios.ml, iCloAccount portions ported from iCloOS 3.0
' 2025 iCloCorp. All rights reserved.

Public Class settings


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Forms.aboutpopup.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        My.Forms.aboutpopup.ShowDialog()
    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = My.Settings.usrnme
        Label5.Text = My.Settings.email
        Label8.Text = My.Settings.recntver
        Label9.Text = My.Resources.version

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        My.Forms.accountui.ShowDialog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        If My.Settings.isupdateavailable = "1" Then

            My.Forms.update.ShowDialog()
        Else
            MsgBox("No updates found")
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        If My.Settings.isupdateavailable = "1" Then


            My.Forms.update.ShowDialog()
        Else
            MsgBox("No updates found")
        End If

    End Sub
End Class