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
        Me.SuspendLayout()
        '
        'recent
        '
        Me.recent.AutoSize = True
        Me.recent.Location = New System.Drawing.Point(35, 22)
        Me.recent.Name = "recent"
        Me.recent.Size = New System.Drawing.Size(39, 13)
        Me.recent.TabIndex = 0
        Me.recent.Text = "Label1"
        '
        'current
        '
        Me.current.AutoSize = True
        Me.current.Location = New System.Drawing.Point(38, 49)
        Me.current.Name = "current"
        Me.current.Size = New System.Drawing.Size(39, 13)
        Me.current.TabIndex = 1
        Me.current.Text = "Label2"
        '
        'devmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.current)
        Me.Controls.Add(Me.recent)
        Me.Name = "devmenu"
        Me.Text = "ui"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents recent As Label
    Friend WithEvents current As Label
End Class
