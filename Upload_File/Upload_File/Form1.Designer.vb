<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Upload_File
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
        Me.btn_Upload = New System.Windows.Forms.Button()
        Me.txt_Files = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btn_Upload
        '
        Me.btn_Upload.Location = New System.Drawing.Point(232, 32)
        Me.btn_Upload.Name = "btn_Upload"
        Me.btn_Upload.Size = New System.Drawing.Size(96, 23)
        Me.btn_Upload.TabIndex = 0
        Me.btn_Upload.Text = "Upload Ficheiro"
        Me.btn_Upload.UseVisualStyleBackColor = True
        '
        'txt_Files
        '
        Me.txt_Files.Location = New System.Drawing.Point(12, 35)
        Me.txt_Files.Name = "txt_Files"
        Me.txt_Files.ReadOnly = True
        Me.txt_Files.Size = New System.Drawing.Size(214, 20)
        Me.txt_Files.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Upload_File
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 79)
        Me.Controls.Add(Me.txt_Files)
        Me.Controls.Add(Me.btn_Upload)
        Me.Name = "Upload_File"
        Me.Text = "Upload File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Upload As Button
    Friend WithEvents txt_Files As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
