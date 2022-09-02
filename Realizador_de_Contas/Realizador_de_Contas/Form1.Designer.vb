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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Soma = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Valor1 = New System.Windows.Forms.TextBox()
        Me.txt_Valor2 = New System.Windows.Forms.TextBox()
        Me.txt_Resultado = New System.Windows.Forms.TextBox()
        Me.btn_Subtracao = New System.Windows.Forms.Button()
        Me.btn_Divisao = New System.Windows.Forms.Button()
        Me.btn_Multiplicacao = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Valor3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Limpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(83, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Primeiro Valor"
        '
        'btn_Soma
        '
        Me.btn_Soma.BackColor = System.Drawing.Color.Blue
        Me.btn_Soma.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Soma.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Soma.Location = New System.Drawing.Point(514, 82)
        Me.btn_Soma.Name = "btn_Soma"
        Me.btn_Soma.Size = New System.Drawing.Size(151, 40)
        Me.btn_Soma.TabIndex = 2
        Me.btn_Soma.Text = "Soma"
        Me.btn_Soma.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(83, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Segundo Valor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(83, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Resultado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(188, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(335, 34)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Bora lá fazer Contas (:"
        '
        'txt_Valor1
        '
        Me.txt_Valor1.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_Valor1.ForeColor = System.Drawing.Color.Azure
        Me.txt_Valor1.Location = New System.Drawing.Point(83, 106)
        Me.txt_Valor1.Name = "txt_Valor1"
        Me.txt_Valor1.Size = New System.Drawing.Size(132, 23)
        Me.txt_Valor1.TabIndex = 1
        '
        'txt_Valor2
        '
        Me.txt_Valor2.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_Valor2.ForeColor = System.Drawing.Color.Azure
        Me.txt_Valor2.Location = New System.Drawing.Point(83, 156)
        Me.txt_Valor2.Name = "txt_Valor2"
        Me.txt_Valor2.Size = New System.Drawing.Size(132, 23)
        Me.txt_Valor2.TabIndex = 6
        '
        'txt_Resultado
        '
        Me.txt_Resultado.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_Resultado.ForeColor = System.Drawing.Color.Azure
        Me.txt_Resultado.Location = New System.Drawing.Point(83, 316)
        Me.txt_Resultado.Name = "txt_Resultado"
        Me.txt_Resultado.ReadOnly = True
        Me.txt_Resultado.Size = New System.Drawing.Size(159, 23)
        Me.txt_Resultado.TabIndex = 7
        '
        'btn_Subtracao
        '
        Me.btn_Subtracao.BackColor = System.Drawing.Color.Blue
        Me.btn_Subtracao.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Subtracao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Subtracao.Location = New System.Drawing.Point(514, 132)
        Me.btn_Subtracao.Name = "btn_Subtracao"
        Me.btn_Subtracao.Size = New System.Drawing.Size(151, 40)
        Me.btn_Subtracao.TabIndex = 8
        Me.btn_Subtracao.Text = "Subtração"
        Me.btn_Subtracao.UseVisualStyleBackColor = False
        '
        'btn_Divisao
        '
        Me.btn_Divisao.BackColor = System.Drawing.Color.Blue
        Me.btn_Divisao.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Divisao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Divisao.Location = New System.Drawing.Point(514, 178)
        Me.btn_Divisao.Name = "btn_Divisao"
        Me.btn_Divisao.Size = New System.Drawing.Size(151, 40)
        Me.btn_Divisao.TabIndex = 9
        Me.btn_Divisao.Text = "Divisão"
        Me.btn_Divisao.UseVisualStyleBackColor = False
        '
        'btn_Multiplicacao
        '
        Me.btn_Multiplicacao.BackColor = System.Drawing.Color.Blue
        Me.btn_Multiplicacao.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Multiplicacao.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Multiplicacao.Location = New System.Drawing.Point(514, 224)
        Me.btn_Multiplicacao.Name = "btn_Multiplicacao"
        Me.btn_Multiplicacao.Size = New System.Drawing.Size(151, 40)
        Me.btn_Multiplicacao.TabIndex = 10
        Me.btn_Multiplicacao.Text = "Multiplicação"
        Me.btn_Multiplicacao.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(83, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Terceiro Valor"
        '
        'txt_Valor3
        '
        Me.txt_Valor3.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_Valor3.ForeColor = System.Drawing.Color.Azure
        Me.txt_Valor3.Location = New System.Drawing.Point(83, 206)
        Me.txt_Valor3.Name = "txt_Valor3"
        Me.txt_Valor3.Size = New System.Drawing.Size(132, 23)
        Me.txt_Valor3.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(-1, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(679, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'btn_Limpar
        '
        Me.btn_Limpar.BackColor = System.Drawing.Color.Red
        Me.btn_Limpar.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Limpar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_Limpar.Location = New System.Drawing.Point(515, 292)
        Me.btn_Limpar.Name = "btn_Limpar"
        Me.btn_Limpar.Size = New System.Drawing.Size(151, 40)
        Me.btn_Limpar.TabIndex = 14
        Me.btn_Limpar.Text = "Limpar"
        Me.btn_Limpar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(678, 354)
        Me.Controls.Add(Me.btn_Limpar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_Valor3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_Multiplicacao)
        Me.Controls.Add(Me.btn_Divisao)
        Me.Controls.Add(Me.btn_Subtracao)
        Me.Controls.Add(Me.txt_Resultado)
        Me.Controls.Add(Me.txt_Valor2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Soma)
        Me.Controls.Add(Me.txt_Valor1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Realizador de Contas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Soma As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Valor1 As TextBox
    Friend WithEvents txt_Valor2 As TextBox
    Friend WithEvents txt_Resultado As TextBox
    Friend WithEvents btn_Subtracao As Button
    Friend WithEvents btn_Divisao As Button
    Friend WithEvents btn_Multiplicacao As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Valor3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_Limpar As Button
End Class
