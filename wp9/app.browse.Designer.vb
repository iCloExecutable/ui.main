<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class browser
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GoBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GoForwardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DownloadsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		CType(Me.WebView21, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'WebView21
		'

		Me.WebView21.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WebView21.BackColor = System.Drawing.SystemColors.Control
		Me.WebView21.CreationProperties = Nothing
		Me.WebView21.DefaultBackgroundColor = System.Drawing.Color.White
		Me.WebView21.Location = New System.Drawing.Point(0, 33)
		Me.WebView21.Name = "WebView21"
		Me.WebView21.Size = New System.Drawing.Size(1080, 571)
		Me.WebView21.TabIndex = 0
		Me.WebView21.ZoomFactor = 1.0R
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
		Me.TextBox1.Location = New System.Drawing.Point(68, 4)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(960, 27)
		Me.TextBox1.TabIndex = 1
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
		Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.GoToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1079, 33)
		Me.MenuStrip1.TabIndex = 2
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'MenuToolStripMenuItem
		'
		Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToolStripMenuItem, Me.GoForwardToolStripMenuItem, Me.DownloadsToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.AboutToolStripMenuItem})
		Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
		Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(62, 29)
		Me.MenuToolStripMenuItem.Text = "Menu"
		'
		'GoBackToolStripMenuItem
		'
		Me.GoBackToolStripMenuItem.Name = "GoBackToolStripMenuItem"
		Me.GoBackToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
		Me.GoBackToolStripMenuItem.Text = "Go Back"
		'
		'GoForwardToolStripMenuItem
		'
		Me.GoForwardToolStripMenuItem.Name = "GoForwardToolStripMenuItem"
		Me.GoForwardToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
		Me.GoForwardToolStripMenuItem.Text = "Go Forward"
		'
		'DownloadsToolStripMenuItem
		'
		Me.DownloadsToolStripMenuItem.Name = "DownloadsToolStripMenuItem"
		Me.DownloadsToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
		Me.DownloadsToolStripMenuItem.Text = "Downloads"
		'
		'HistoryToolStripMenuItem
		'
		Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
		Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
		Me.HistoryToolStripMenuItem.Text = "History"
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
		Me.AboutToolStripMenuItem.Text = "About"
		'
		'GoToolStripMenuItem
		'
		Me.GoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
		Me.GoToolStripMenuItem.Name = "GoToolStripMenuItem"
		Me.GoToolStripMenuItem.Size = New System.Drawing.Size(53, 29)
		Me.GoToolStripMenuItem.Text = "Go!"
		'
		'browser
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(1079, 603)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.WebView21)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "browser"
		Me.Text = "iCloBrowser"
		CType(Me.WebView21, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout()
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout()
		Me.PerformLayout()

	End Sub

	Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GoBackToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GoForwardToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DownloadsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolTip1 As ToolTip
End Class
