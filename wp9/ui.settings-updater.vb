Imports System.IO
Imports System.Text
Imports System.Net
Public Class updater
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If My.Resources.compatmode = 1 Then
            MsgBox("Updates disabled.")
        Else
            Try
                My.Computer.Network.DownloadFile("https://api.iclostudios.ml/updsrv/mos/release/release.exe", "C:\uimain\kernel.main.exe", "", "", True, 500, True)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class