<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
		Me.Label2 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label2.Location = New System.Drawing.Point(60, 368)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(52, 21)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "About"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.openmain.My.Resources.Resources.info
		Me.PictureBox1.Location = New System.Drawing.Point(12, 359)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(42, 39)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 10
		Me.PictureBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
		Me.Label1.Location = New System.Drawing.Point(-39, 68)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(648, 42)
		Me.Label1.TabIndex = 11
		Me.Label1.Text = resources.GetString("Label1.Text")
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.openmain.My.Resources.Resources.avatar
		Me.PictureBox2.Location = New System.Drawing.Point(9, 10)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(58, 55)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox2.TabIndex = 12
		Me.PictureBox2.TabStop = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label3.Location = New System.Drawing.Point(73, 10)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(169, 21)
		Me.Label3.TabIndex = 13
		Me.Label3.Text = "Welcome to openmain,"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label4.Location = New System.Drawing.Point(235, 10)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(55, 21)
		Me.Label4.TabIndex = 14
		Me.Label4.Text = "val.usr"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label5.Location = New System.Drawing.Point(73, 31)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(71, 21)
		Me.Label5.TabIndex = 15
		Me.Label5.Text = "val.email"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label6.Location = New System.Drawing.Point(74, 51)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(210, 17)
		Me.Label6.TabIndex = 16
		Me.Label6.Text = "Click here to manage your account"
		'
		'PictureBox3
		'
		Me.PictureBox3.Image = Global.openmain.My.Resources.Resources.updater
		Me.PictureBox3.Location = New System.Drawing.Point(12, 314)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(42, 39)
		Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox3.TabIndex = 18
		Me.PictureBox3.TabStop = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label7.Location = New System.Drawing.Point(60, 323)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(130, 21)
		Me.Label7.TabIndex = 17
		Me.Label7.Text = "Software updater"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label8.ForeColor = System.Drawing.SystemColors.Control
		Me.Label8.Location = New System.Drawing.Point(417, 35)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(55, 21)
		Me.Label8.TabIndex = 19
		Me.Label8.Text = "val.usr"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label9.ForeColor = System.Drawing.SystemColors.Control
		Me.Label9.Location = New System.Drawing.Point(415, 10)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(55, 21)
		Me.Label9.TabIndex = 20
		Me.Label9.Text = "val.usr"
		'
		'settings
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(482, 410)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label2)
		Me.Name = "settings"
		Me.Text = "Settings"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
