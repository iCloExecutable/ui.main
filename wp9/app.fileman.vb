Public Class filemanager
    Private Sub filemanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("C:\uimain\config\fschk.ini") Then
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
            My.Computer.FileSystem.CreateDirectory("C:\uimain\")
            My.Computer.FileSystem.CreateDirectory("C:\uimain\config")
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
            PrintLine(1, "fs.rev = 1.2000")
            PrintLine(1, "---------------------------------------------")
            PrintLine(1, "Anything manually edited will be removed")
            FileClose(1)
        End If

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            WebBrowser1.Navigate(TextBox1.Text)
            e.Handled = True
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "My ui.main Files" Then
            WebBrowser1.Navigate("file://C:\uimain\fs\home")
        End If
        If ListBox1.SelectedItem = "My ui.main Downloads" Then
            WebBrowser1.Navigate("file://C:\uimain\fs\home\downloads")
        End If
        If ListBox1.SelectedItem = "My ui.main Music" Then
            WebBrowser1.Navigate("file://C:\uimain\fs\home\music")
        End If
        If ListBox1.SelectedItem = "C:\" Then
            WebBrowser1.Navigate("file://C:\")
        End If
        If ListBox1.SelectedItem = "D:\" Then
            WebBrowser1.Navigate("file://D:\")
        End If
        If ListBox1.SelectedItem = "E:\" Then
            WebBrowser1.Navigate("file://E:\")
        End If
    End Sub
End Class