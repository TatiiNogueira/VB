Public Class Calculadora
    'Declarar as Variaveis
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean
    Dim DATO As Double

    Private Sub txtResultado_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged

    End Sub

    'Botão 1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "1"
    End Sub

    'Botão 2
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "2"
    End Sub

    'Botão 3
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "3"
    End Sub

    'Botão 4
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "4"
    End Sub

    'Botão 5
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "5"
    End Sub

    'Botão 6
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "6"
    End Sub

    'Botão 7
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "7"
    End Sub

    'Botão 8
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "8"
    End Sub

    'Botão 9
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        EvaluaRestriccionesParaConcatenar()
        txtResultado.Text &= "9"
    End Sub

    'Botão 0
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtResultado.Text &= "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    'Botão Soma
    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        Operacion = "+"
        DATO = Val(txtResultado.Text)
        txtResultado.Clear()
    End Sub

    'Botão Menos
    Private Sub btnSubtracao_Click(sender As Object, e As EventArgs) Handles btnSubtracao.Click
        Operacion = "-"
        DATO = Val(txtResultado.Text)
        txtResultado.Clear()
    End Sub

    'Botão Vezes
    Private Sub btnMultiplicacao_Click(sender As Object, e As EventArgs) Handles btnMultiplicacao.Click
        Operacion = "*"
        DATO = Val(txtResultado.Text)
        txtResultado.Clear()
    End Sub

    'Botão Dividir
    Private Sub btnDivisao_Click(sender As Object, e As EventArgs) Handles btnDivisao.Click
        Operacion = "/"
        DATO = Val(txtResultado.Text)
        txtResultado.Clear()

    End Sub

    'Botão Ponto
    Private Sub btnPonto_Click(sender As Object, e As EventArgs) Handles btnPonto.Click
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
        End If
    End Sub

    'Função -> Indicação das contas a serem feitas
    Public Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        'SePresionaOperador = True
        Valor2 = Val(txtResultado.Text)
        If Operacion = "/" Then
            txtResultado.Text = DATO / Valor2
        Else
            If Operacion = "*" Then
                txtResultado.Text = DATO * Valor2
            Else
                If Operacion = "-" Then
                    txtResultado.Text = DATO - Valor2
                Else
                    If Operacion = "+" Then
                        txtResultado.Text = DATO + Valor2
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        'Se clicarmos num núemro é verdadeiro
        If SePresionaOperador = True Then
            txtResultado.Text = ""
            'Apaga o que temos na txt
            SePresionaOperador = False
        ElseIf txtResultado.Text = "0" Then
            txtResultado.Text = ""
        End If
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtResultado.Clear()
    End Sub

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
