<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devmenu
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
		Me.recent = New System.Windows.Forms.Label()
		Me.current = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.CheckBox3 = New System.Windows.Forms.CheckBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'recent
		'
		Me.recent.AutoSize = True
		Me.recent.Location = New System.Drawing.Point(294, 26)
		Me.recent.Name = "recent"
		Me.recent.Size = New System.Drawing.Size(39, 13)
		Me.recent.TabIndex = 0
		Me.recent.Text = "Label1"
		'
		'current
		'
		Me.current.AutoSize = True
		Me.current.Location = New System.Drawing.Point(297, 53)
		Me.current.Name = "current"
		Me.current.Size = New System.Drawing.Size(39, 13)
		Me.current.TabIndex = 1
		Me.current.Text = "Label2"
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Button1.Location = New System.Drawing.Point(12, 278)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(124, 23)
		Me.Button1.TabIndex = 5
		Me.Button1.Text = "Save settings"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Button2.Location = New System.Drawing.Point(142, 278)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(124, 23)
		Me.Button2.TabIndex = 6
		Me.Button2.Text = "Restart UI (broken)"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.CheckBox1.Location = New System.Drawing.Point(12, 202)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(121, 21)
		Me.CheckBox1.TabIndex = 7
		Me.CheckBox1.Text = "Enable buildinfo"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.CheckBox2.Location = New System.Drawing.Point(12, 225)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(141, 21)
		Me.CheckBox2.TabIndex = 8
		Me.CheckBox2.Text = "iCloOS app compat"
		Me.CheckBox2.UseVisualStyleBackColor = True
		'
		'CheckBox3
		'
		Me.CheckBox3.AutoSize = True
		Me.CheckBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.CheckBox3.Location = New System.Drawing.Point(12, 248)
		Me.CheckBox3.Name = "CheckBox3"
		Me.CheckBox3.Size = New System.Drawing.Size(89, 21)
		Me.CheckBox3.TabIndex = 9
		Me.CheckBox3.Text = "CheckBox3"
		Me.CheckBox3.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label1.Location = New System.Drawing.Point(8, 179)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(54, 17)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "Options"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Label3.Location = New System.Drawing.Point(12, 9)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(123, 17)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "kernel version 2.4lts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'devmenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(345, 313)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.CheckBox3)
		Me.Controls.Add(Me.CheckBox2)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.current)
		Me.Controls.Add(Me.recent)
		Me.Name = "devmenu"
		Me.Text = "Developer Options"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents recent As Label
    Friend WithEvents current As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents CheckBox3 As CheckBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
End Class
