Imports System.IO
Imports System.Text
Imports System.Net

' ui.login
' written by micraia @ webmaster@iclostudios.ml
' 2025 iCloCorp. All rights reserved.

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' build numara ayarı
        My.Settings.buildnumber = My.Resources.build_number + "." + My.Resources.build_cpu + "." + My.Resources.build_channel + "." + My.Resources.build_sku
        My.Settings.Save()

        ' saati baslatın
        My.Forms.mainui.Timer1.Start()

        ' internet kontroli
        If My.Computer.Network.IsAvailable Then
            Dim address As String = "https://os.iclostudios.ml/api-v1/update-checker/latestversion.txt"
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            My.Settings.recntver = reader.ReadToEnd
            My.Settings.ishaveint = "1"
            My.Settings.Save()
        Else
            My.Settings.ishaveint = "0"
            My.Settings.Save()
        End If

        ' yeni surum kontrolu
        If My.Settings.recntver > My.Resources.version Then
            My.Settings.isupdateavailable = "1"
            My.Settings.Save()
        Else
            My.Settings.isupdateavailable = "0"
            My.Settings.Save()

        End If
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
