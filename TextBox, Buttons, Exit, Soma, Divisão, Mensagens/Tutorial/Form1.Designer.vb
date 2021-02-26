<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.IbIName = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAddValues = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddVal1 = New System.Windows.Forms.TextBox()
        Me.txtSumAnswer = New System.Windows.Forms.TextBox()
        Me.txtAddVal2 = New System.Windows.Forms.TextBox()
        Me.txtDivideVal2 = New System.Windows.Forms.TextBox()
        Me.txtDivisionAnswer = New System.Windows.Forms.TextBox()
        Me.txtDivideVal1 = New System.Windows.Forms.TextBox()
        Me.DivideEqual = New System.Windows.Forms.Label()
        Me.btnDivideValues = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IbIName
        '
        Me.IbIName.AutoSize = True
        Me.IbIName.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IbIName.Location = New System.Drawing.Point(9, 32)
        Me.IbIName.Name = "IbIName"
        Me.IbIName.Size = New System.Drawing.Size(36, 14)
        Me.IbIName.TabIndex = 0
        Me.IbIName.Text = "Name"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(23, 67)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(73, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(102, 67)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(73, 23)
        Me.txtMessage.TabIndex = 2
        Me.txtMessage.Text = "&Message"
        Me.txtMessage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(181, 67)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(73, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(51, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 20)
        Me.txtName.TabIndex = 4
        '
        'btnAddValues
        '
        Me.btnAddValues.Location = New System.Drawing.Point(73, 123)
        Me.btnAddValues.Name = "btnAddValues"
        Me.btnAddValues.Size = New System.Drawing.Size(23, 23)
        Me.btnAddValues.TabIndex = 5
        Me.btnAddValues.Text = "+"
        Me.btnAddValues.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "="
        '
        'txtAddVal1
        '
        Me.txtAddVal1.Location = New System.Drawing.Point(12, 125)
        Me.txtAddVal1.Name = "txtAddVal1"
        Me.txtAddVal1.Size = New System.Drawing.Size(55, 20)
        Me.txtAddVal1.TabIndex = 9
        '
        'txtSumAnswer
        '
        Me.txtSumAnswer.Location = New System.Drawing.Point(188, 125)
        Me.txtSumAnswer.Name = "txtSumAnswer"
        Me.txtSumAnswer.Size = New System.Drawing.Size(55, 20)
        Me.txtSumAnswer.TabIndex = 11
        '
        'txtAddVal2
        '
        Me.txtAddVal2.Location = New System.Drawing.Point(102, 125)
        Me.txtAddVal2.Name = "txtAddVal2"
        Me.txtAddVal2.Size = New System.Drawing.Size(55, 20)
        Me.txtAddVal2.TabIndex = 12
        '
        'txtDivideVal2
        '
        Me.txtDivideVal2.Location = New System.Drawing.Point(102, 171)
        Me.txtDivideVal2.Name = "txtDivideVal2"
        Me.txtDivideVal2.Size = New System.Drawing.Size(55, 20)
        Me.txtDivideVal2.TabIndex = 17
        '
        'txtDivisionAnswer
        '
        Me.txtDivisionAnswer.Location = New System.Drawing.Point(188, 171)
        Me.txtDivisionAnswer.Name = "txtDivisionAnswer"
        Me.txtDivisionAnswer.Size = New System.Drawing.Size(55, 20)
        Me.txtDivisionAnswer.TabIndex = 16
        '
        'txtDivideVal1
        '
        Me.txtDivideVal1.Location = New System.Drawing.Point(12, 171)
        Me.txtDivideVal1.Name = "txtDivideVal1"
        Me.txtDivideVal1.Size = New System.Drawing.Size(55, 20)
        Me.txtDivideVal1.TabIndex = 15
        '
        'DivideEqual
        '
        Me.DivideEqual.AutoSize = True
        Me.DivideEqual.Location = New System.Drawing.Point(163, 174)
        Me.DivideEqual.Name = "DivideEqual"
        Me.DivideEqual.Size = New System.Drawing.Size(13, 13)
        Me.DivideEqual.TabIndex = 14
        Me.DivideEqual.Text = "="
        '
        'btnDivideValues
        '
        Me.btnDivideValues.Location = New System.Drawing.Point(73, 169)
        Me.btnDivideValues.Name = "btnDivideValues"
        Me.btnDivideValues.Size = New System.Drawing.Size(23, 23)
        Me.btnDivideValues.TabIndex = 13
        Me.btnDivideValues.Text = "/"
        Me.btnDivideValues.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 212)
        Me.Controls.Add(Me.txtDivideVal2)
        Me.Controls.Add(Me.txtDivisionAnswer)
        Me.Controls.Add(Me.txtDivideVal1)
        Me.Controls.Add(Me.DivideEqual)
        Me.Controls.Add(Me.btnDivideValues)
        Me.Controls.Add(Me.txtAddVal2)
        Me.Controls.Add(Me.txtSumAnswer)
        Me.Controls.Add(Me.txtAddVal1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAddValues)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.IbIName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IbIName As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents txtMessage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAddValues As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddVal1 As TextBox
    Friend WithEvents txtSumAnswer As TextBox
    Friend WithEvents txtAddVal2 As TextBox
    Friend WithEvents txtDivideVal2 As TextBox
    Friend WithEvents txtDivisionAnswer As TextBox
    Friend WithEvents txtDivideVal1 As TextBox
    Friend WithEvents DivideEqual As Label
    Friend WithEvents btnDivideValues As Button
End Class
