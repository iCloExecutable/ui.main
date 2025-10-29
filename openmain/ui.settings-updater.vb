Imports System.IO
Imports System.Text
Imports System.Net

' ui.settings-updater
' written by micraia @ webmaster@iclostudios.ml, ported from iCloOS 3.0d
' disabled in opencore, optional feature
' 2025 iCloCorp. All rights reserved.

Public Class updater
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If My.Settings.premainappsupport = "1" Then
            MsgBox("Updates disabled.")
        Else
            Try
                My.Computer.Network.DownloadFile("PUT SERVER LINK HERE :d", "C:\uimain\kernel.main.exe", "", "", True, 500, True)
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