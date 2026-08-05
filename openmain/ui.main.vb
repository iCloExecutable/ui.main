
' ui.main - main UI form for iCloOS 4.0
' written by micraia @ webmaster@iclostudios.ml
' 2025 iCloCorp. All rights reserved.

Public Class mainui
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)

    End Sub

	Private Sub KapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem.Click
		' End the application
		My.Forms.Form1.Close()

    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.buildtextenable = "1" Then
            Label5.Text = My.Resources.public_sku + " version " + My.Resources.version + " build " + My.Settings.buildnumber
        Else
            Label5.Text = ""
        End If
        If My.Resources.devwarn = "1" Then
            warning.Text = "Warning: This is a dev build. Proceed with caution."
        Else
            warning.Text = ""
        End If
		If My.Computer.FileSystem.FileExists("C:\uimain\config\fschk.ini") Then
			' editing the filesystem config file 

			FileOpen(1, "C:\uimain\config\fschk.ini", OpenMode.Output)
			PrintLine(1, "iCloFS - autocreated by ui.main - do not edit")
			PrintLine(1, "---------------------------------------------")
			PrintLine(1, "My-Files = uimain\fs\home")
			PrintLine(1, "My-Downloads = uimain\fs\home\downloads")
			PrintLine(1, "My-Music = uimain\fs\home\music")
			PrintLine(1, "fs.rev = 1.2000")
			PrintLine(1, "---------------------------------------------")
			PrintLine(1, "Anything manually edited will be removed")
			FileClose(1)
		Else
            ' if not exist, create fs structure 
            My.Computer.FileSystem.CreateDirectory("C:\uimain\")
            My.Computer.FileSystem.CreateDirectory("C:\uimain\config")
            My.Computer.FileSystem.CreateDirectory("C:\uimain\iCloBrowser")
            My.Computer.FileSystem.CreateDirectory("C:\uimain\fs")
            My.Computer.FileSystem.CreateDirectory("C:\uimain\fs\home")
            My.Computer.FileSystem.CreateDirectory("C:\uimain\fs\home\music")
            My.Computer.FileSystem.CreateDirectory("C:\uimain\fs\home\downloads")
            System.IO.File.Create("C:\uimain\config\fschk.ini").Dispose()
            FileOpen(1, "C:\uimain\config\fschk.ini", OpenMode.Output)
            PrintLine(1, "iCloFS - autocreated by ui.main - do not edit")
            PrintLine(1, "---------------------------------------------")
            PrintLine(1, "My-Files = uimain\fs\home")
            PrintLine(1, "My-Downloads = uimain\fs\home\downloads")
            PrintLine(1, "My-Music = uimain\fs\home\music")
            PrintLine(1, "Browser Profile = uimain\iCloBrowser")
            PrintLine(1, "fs.rev = 1.2300")
            PrintLine(1, "---------------------------------------------")
            PrintLine(1, "Anything manually edited will be removed")
            FileClose(1)
        End If


    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click

    End Sub

    Private Sub UisettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UisettingsToolStripMenuItem.Click
        My.Forms.settings.ShowDialog()

    End Sub

    Private Sub AppbrowseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppbrowseToolStripMenuItem.Click
        My.Forms.browser.ShowDialog()
    End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' clockkkkk
        Label1.Text = TimeString
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Forms.browser.ShowDialog()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        My.Forms.browser.ShowDialog()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Forms.filemanager.ShowDialog()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        My.Forms.filemanager.ShowDialog()
    End Sub

    Private Sub FileManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileManagerToolStripMenuItem.Click
        My.Forms.filemanager.ShowDialog()
    End Sub
End Class