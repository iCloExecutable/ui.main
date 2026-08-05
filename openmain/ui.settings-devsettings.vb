
' ui.settings-devsettings
' written by micraia @ webmaster@iclostudios.ml for 
' 2025 iCloCorp. All rights reserved.

Public Class devmenu
    Private Sub devmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recent.Text = My.Settings.recntver
        current.Text = My.Resources.version
        Label2.Text = My.Settings.buildnumber
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            My.Settings.buildtextenable = 1
            My.Settings.Save()
        Else
            My.Settings.buildtextenable = 0
            My.Settings.Save()
        End If
        If CheckBox2.Checked Then
            My.Settings.premainappsupport = 1
            My.Settings.Save()
        Else
            My.Settings.premainappsupport = 0
            My.Settings.Save()
        End If
        MsgBox("Settings saved. Please refresh the ui.main to apply changes.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        mainui.Refresh()


        Me.Show()



    End Sub
End Class