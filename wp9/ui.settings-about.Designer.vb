<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aboutpopup
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.compatmode = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ui.main"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "version 1.2111"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "kernel version 2.3"
        '
        'compatmode
        '
        Me.compatmode.AutoSize = True
        Me.compatmode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.compatmode.ForeColor = System.Drawing.Color.Red
        Me.compatmode.Location = New System.Drawing.Point(279, 128)
        Me.compatmode.Name = "compatmode"
        Me.compatmode.Size = New System.Drawing.Size(136, 17)
        Me.compatmode.TabIndex = 5
        Me.compatmode.Text = "mention.compatmode"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.wp9.My.Resources.Resources.osicon
        Me.PictureBox1.Location = New System.Drawing.Point(63, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'aboutpopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 261)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.compatmode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "aboutpopup"
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents compatmode As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
