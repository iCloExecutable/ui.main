<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class filemanager
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
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'WebBrowser1
		'
		Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.WebBrowser1.Location = New System.Drawing.Point(139, 27)
		Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.WebBrowser1.Size = New System.Drawing.Size(474, 341)
		Me.WebBrowser1.TabIndex = 0
		Me.WebBrowser1.Url = New System.Uri("file://C:\", System.UriKind.Absolute)
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(139, 0)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(474, 27)
		Me.TextBox1.TabIndex = 1
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(11, 4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(41, 23)
		Me.Button1.TabIndex = 3
		Me.Button1.Text = "<-"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(92, 4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(41, 23)
		Me.Button2.TabIndex = 3
		Me.Button2.Text = "->"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'ListBox1
		'
		Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.Items.AddRange(New Object() {"My ui.main Downloads", "My ui.main Files", "My ui.main Music", "", "------------------------------------------------", "", "C:\", "", "D:\", "", "E:\"})
		Me.ListBox1.Location = New System.Drawing.Point(11, 33)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(120, 329)
		Me.ListBox1.TabIndex = 5
		'
		'filemanager
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(613, 369)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.WebBrowser1)
		Me.Name = "filemanager"
		Me.Text = "File manager"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
