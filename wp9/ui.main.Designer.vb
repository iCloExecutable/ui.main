<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainui
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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AppbrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FileManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UisettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.KapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.warning = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.MenuStrip1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
		Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 465)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(673, 33)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'AToolStripMenuItem
		'
		Me.AToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AppbrowseToolStripMenuItem, Me.FileManagerToolStripMenuItem, Me.UisettingsToolStripMenuItem, Me.KapatToolStripMenuItem})
		Me.AToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
		Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
		Me.AToolStripMenuItem.Size = New System.Drawing.Size(69, 29)
		Me.AToolStripMenuItem.Text = "Menu"
		'
		'AppbrowseToolStripMenuItem
		'
		Me.AppbrowseToolStripMenuItem.Name = "AppbrowseToolStripMenuItem"
		Me.AppbrowseToolStripMenuItem.Size = New System.Drawing.Size(185, 30)
		Me.AppbrowseToolStripMenuItem.Text = "Browser"
		'
		'FileManagerToolStripMenuItem
		'
		Me.FileManagerToolStripMenuItem.Name = "FileManagerToolStripMenuItem"
		Me.FileManagerToolStripMenuItem.Size = New System.Drawing.Size(185, 30)
		Me.FileManagerToolStripMenuItem.Text = "File manager"
		'
		'UisettingsToolStripMenuItem
		'
		Me.UisettingsToolStripMenuItem.Name = "UisettingsToolStripMenuItem"
		Me.UisettingsToolStripMenuItem.Size = New System.Drawing.Size(185, 30)
		Me.UisettingsToolStripMenuItem.Text = "Settings"
		'
		'KapatToolStripMenuItem
		'
		Me.KapatToolStripMenuItem.Name = "KapatToolStripMenuItem"
		Me.KapatToolStripMenuItem.Size = New System.Drawing.Size(185, 30)
		Me.KapatToolStripMenuItem.Text = "Close"
		'
		'warning
		'
		Me.warning.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.warning.AutoSize = True
		Me.warning.BackColor = System.Drawing.SystemColors.Control
		Me.warning.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		Me.warning.ForeColor = System.Drawing.Color.Red
		Me.warning.Location = New System.Drawing.Point(8, 440)
		Me.warning.Name = "warning"
		Me.warning.Size = New System.Drawing.Size(0, 21)
		Me.warning.TabIndex = 6
		Me.warning.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'Timer1
		'
		'
		'Label1
		'
		Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label1.Location = New System.Drawing.Point(605, 470)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(56, 21)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Label1"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label2.Location = New System.Drawing.Point(13, 94)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(94, 21)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "iCloBrowser"
		Me.ToolTip1.SetToolTip(Me.Label2, "Surf the web!")
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.wp9.My.Resources.Resources.browser
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(90, 78)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 9
		Me.PictureBox1.TabStop = False
		Me.ToolTip1.SetToolTip(Me.PictureBox1, "Surf the web!")
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.wp9.My.Resources.Resources.folder
		Me.PictureBox2.Location = New System.Drawing.Point(12, 126)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(92, 78)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox2.TabIndex = 11
		Me.PictureBox2.TabStop = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label3.Location = New System.Drawing.Point(10, 207)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(100, 21)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "File manager"
		'
		'PictureBox3
		'
		Me.PictureBox3.Image = Global.wp9.My.Resources.Resources.browser
		Me.PictureBox3.Location = New System.Drawing.Point(12, 240)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(92, 78)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox3.TabIndex = 13
		Me.PictureBox3.TabStop = False
		Me.PictureBox3.Visible = False
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label4.Location = New System.Drawing.Point(12, 321)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(90, 21)
		Me.Label4.TabIndex = 12
		Me.Label4.Text = "app.browse"
		Me.Label4.Visible = False
		'
		'Label5
		'
		Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.SystemColors.ControlDark
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		Me.Label5.ForeColor = System.Drawing.Color.Red
		Me.Label5.Location = New System.Drawing.Point(576, 440)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(97, 21)
		Me.Label5.TabIndex = 14
		Me.Label5.Text = "build 1.2222"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'mainui
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDark
		Me.ClientSize = New System.Drawing.Size(673, 498)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.warning)
		Me.Controls.Add(Me.MenuStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "mainui"
		Me.Text = "ui.main"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KapatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents warning As Label
    Friend WithEvents UisettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AppbrowseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FileManagerToolStripMenuItem As ToolStripMenuItem
End Class
