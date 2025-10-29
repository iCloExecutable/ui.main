
' app.browse
' written by micraia @ webmaster@iclostudios.ml, ported from iCloOS 3.0
' 2025 iCloCorp. All rights reserved.
' Chromium is a trademark of Google LLC. Used with permission under the BSD license.


Public Class browser


	Private Sub WebView21_Click(sender As Object, e As EventArgs) Handles WebView21.Click

	End Sub

	Private Sub app_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' set webview2 source to google.com
		WebView21.Source = New Uri("https://google.com")

	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

	End Sub

	Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
		' detecting enter key press
		If Asc(e.KeyChar) = 13 Then
			WebView21.Source = New Uri("https://" + TextBox1.Text)
			e.Handled = True
		End If
	End Sub

	Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
		WebView21.Source = New Uri("edge://history/")
	End Sub

	Private Sub DownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadsToolStripMenuItem.Click
		WebView21.Source = New Uri("edge://downloads/")
	End Sub

	Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
		WebView21.GoBack()
	End Sub

	Private Sub WebView21_SourceChanged(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs) Handles WebView21.SourceChanged
		TextBox1.Text = WebView21.Source.ToString()
	End Sub

	Private Sub GoForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoForwardToolStripMenuItem.Click
		WebView21.GoForward()

	End Sub

	Private Sub WebView21_NavigationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs) Handles WebView21.NavigationCompleted
		My.Forms.browser.Text = WebView21.CoreWebView2.DocumentTitle + " - OpenBrowser"
	End Sub

	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		browserabout.ShowDialog()

	End Sub

	Private Sub WebView21_CoreWebView2InitializationCompleted(sender As Object, e As Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs) Handles WebView21.CoreWebView2InitializationCompleted

		' configure user agent for OpenBrowser 
		WebView21.CoreWebView2.Settings.UserAgent = "TreCore/3.0 (openmain build 2300 Win64; x64) iCloWebKit/1.2 (KHTML, like Gecko) OpenBrowser/2.0.150.1"

		' indirme klasörünü ayarla
		WebView21.CoreWebView2.Profile.DefaultDownloadFolderPath = "C:\uimain\fs\home\downloads"
		WebView21.Name = "OpenBrowser"



	End Sub
End Class