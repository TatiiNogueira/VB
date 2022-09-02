'Link do Video - https://www.youtube.com/watch?v=K6dFDtyVnqI

Public Class Form1
    Dim Num1 As Integer
    Dim Num2 As Integer
    Dim Num3 As Integer
    Dim Resultado As Integer

    'Limpar os Campos todos
    Private Sub btn_Limpar_Click(sender As Object, e As EventArgs) Handles btn_Limpar.Click
        txt_Valor1.Text = ""
        txt_Valor2.Text = ""
        txt_Valor3.Text = ""
        txt_Resultado.Text = ""
    End Sub

    'SOMA
    Private Sub btn_Soma_Click(sender As Object, e As EventArgs) Handles btn_Soma.Click
        Num1 = txt_Valor1.Text
        Num2 = txt_Valor2.Text
        Num3 = txt_Valor3.Text

        'Conta
        Resultado = Num1 + Num2 + Num3

        txt_Resultado.Text = Resultado
    End Sub

    'SUBTRAÇÃO
    Private Sub btn_Subtracao_Click(sender As Object, e As EventArgs) Handles btn_Subtracao.Click
        Num1 = txt_Valor1.Text
        Num2 = txt_Valor2.Text
        Num3 = txt_Valor3.Text

        'Conta
        Resultado = Num1 - Num2 - Num3

        txt_Resultado.Text = Resultado
    End Sub

    'DIVISÃO
    Private Sub btn_Divisao_Click(sender As Object, e As EventArgs) Handles btn_Divisao.Click
        Num1 = txt_Valor1.Text
        Num2 = txt_Valor2.Text
        Num3 = txt_Valor3.Text

        'Conta
        Resultado = Num1 / Num2 / Num3

        txt_Resultado.Text = Resultado
    End Sub

    'MULTIPLICAÇÃO
    Private Sub btn_Multiplicacao_Click(sender As Object, e As EventArgs) Handles btn_Multiplicacao.Click
        Num1 = txt_Valor1.Text
        Num2 = txt_Valor2.Text
        Num3 = txt_Valor3.Text

        'Conta
        Resultado = Num1 * Num2 * Num3

        txt_Resultado.Text = Resultado
    End Sub
End Class
