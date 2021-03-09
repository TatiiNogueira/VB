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
        Me.aviao = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.aviao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'aviao
        '
        Me.aviao.BackColor = System.Drawing.Color.Transparent
        Me.aviao.BackgroundImage = Global.Moving_Object_on_forms_and_looping_to_start.My.Resources.Resources.q__1__removebg_preview
        Me.aviao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.aviao.Location = New System.Drawing.Point(97, 74)
        Me.aviao.Name = "aviao"
        Me.aviao.Size = New System.Drawing.Size(195, 171)
        Me.aviao.TabIndex = 0
        Me.aviao.TabStop = False
        '
        'Timer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Moving_Object_on_forms_and_looping_to_start.My.Resources.Resources.d__1_
        Me.ClientSize = New System.Drawing.Size(409, 316)
        Me.Controls.Add(Me.aviao)
        Me.Name = "Form1"
        Me.Text = "Loop Avião"
        CType(Me.aviao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents aviao As PictureBox
    Friend WithEvents Timer As Timer
End Class
