<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PicBird = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicBird, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBird
        '
        Me.PicBird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicBird.Image = Global.Animation.My.Resources.Resources.bird1
        Me.PicBird.Location = New System.Drawing.Point(108, 66)
        Me.PicBird.Name = "PicBird"
        Me.PicBird.Size = New System.Drawing.Size(177, 150)
        Me.PicBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBird.TabIndex = 0
        Me.PicBird.TabStop = False
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Animation.My.Resources.Resources.Céu
        Me.ClientSize = New System.Drawing.Size(418, 301)
        Me.Controls.Add(Me.PicBird)
        Me.Name = "Form1"
        Me.Text = "BIRD"
        CType(Me.PicBird, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicBird As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
