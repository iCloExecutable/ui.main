Imports System.IO
Imports System.Text
Imports System.Net
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Forms.mainui.Timer1.Start()
        If My.Computer.Network.IsAvailable Then
            Dim address As String = "https://api.iclostudios.ml/updsrv/mos/uiver.txt"
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            My.Settings.recntver = reader.ReadToEnd
            My.Settings.ishaveint = "1"
            My.Settings.Save()
        Else
            My.Settings.ishaveint = "0"
            My.Settings.Save()
        End If
        Label3.Text = My.Settings.recntver
        Label4.Text = My.Resources.version
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Forms.createacc.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.usrnme And TextBox2.Text = My.Settings.passwd Then
            mainui.ShowDialog()

        Else
            MsgBox("Girilen bilgiler yanlıştır!")

        End If
    End Sub
End Class
