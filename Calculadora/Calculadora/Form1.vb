'Videos'
'https://www.youtube.com/watch?v=FzPy7cpSb-8
'https://www.youtube.com/watch?v=-JYAyYpwylE

Public Class Form1
    'Variáveis
    Dim DATO As Double
    Dim DATO2 As Double
    Dim RESUL As Double
    Dim OPE As Double

    'Button 0
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Result.Text &= "0" '& Result.Text
    End Sub

    'Button 1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Result.Text &= "1"
    End Sub

    'Button 2
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Result.Text &= "2"
    End Sub

    'Button 3
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Result.Text &= "3"
    End Sub

    'Button 4
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Result.Text &= "4"
    End Sub

    'Button 5
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Result.Text &= "5"
    End Sub

    'Button 6
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Result.Text &= "6"
    End Sub

    'Button 7
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Result.Text &= "7"
    End Sub

    'Button 8
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Result.Text &= "8"
    End Sub

    'Button 9
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Result.Text &= "9"
    End Sub

    'Button Dividir
    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        OPE = 1
        DATO = Val(Result.Text)
        Result.Clear()
    End Sub

    'Button Vezes
    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        OPE = 2
        DATO = Val(Result.Text)
        Result.Clear()
    End Sub

    'Button Menos
    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        OPE = 3
        DATO = Val(Result.Text)
        Result.Clear()
    End Sub

    'Button Mais
    Private Sub btnMais_Click(sender As Object, e As EventArgs) Handles btnMais.Click
        OPE = 4
        DATO = Val(Result.Text)
        Result.Clear()
    End Sub

    'Button Igual "="
    'Onde serão indicadas as contas a ser executadas
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        DATO2 = Val(Result.Text)
        If OPE = 1 Then
            RESUL = DATO / DATO2
            Result.Text = RESUL
        Else
            If OPE = 2 Then
                RESUL = DATO * DATO2
                Result.Text = RESUL
            Else
                If OPE = 3 Then
                    RESUL = DATO - DATO2
                    Result.Text = RESUL
                Else
                    If OPE = 4 Then
                        RESUL = DATO + DATO2
                        Result.Text = RESUL
                    Else
                        If OPE = 5 Then
                            RESUL = DATO ^ DATO2
                            Result.Text = RESUL
                        End If
                    End If
                End If
            End If
            End If

    End Sub

    'Button Clear
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Result.Clear()
    End Sub

    'Button x^2
    Private Sub btnQuadrado_Click(sender As Object, e As EventArgs) Handles btnQuadrado.Click
        Try
            RESUL = Result.Text * Result.Text
            Result.Text = RESUL
        Catch ex As Exception
            MsgBox("Por favor insira um Valor Valido")
        End Try

    End Sub

    'Button 10^x
    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        Try
            RESUL = 10 ^ Result.Text
            Result.Text = RESUL
        Catch
            MsgBox("Por favor insira um Valor Valido")
        End Try
    End Sub

    'Button x^y
    Private Sub btnxy_Click(sender As Object, e As EventArgs) Handles btnxy.Click
        OPE = 5
        DATO = Val(Result.Text)
        Result.Clear()
    End Sub

    'Button x^3
    Private Sub btnx3_Click(sender As Object, e As EventArgs) Handles btnx3.Click
        RESUL = Result.Text ^ 3
        Result.Text = RESUL
    End Sub

    'Button 1/x
    Private Sub btn1x_Click(sender As Object, e As EventArgs) Handles btn1x.Click
        RESUL = 1 / Result.Text
        Result.Text = RESUL
    End Sub

    'Button 2^x
    Private Sub btn2x_Click(sender As Object, e As EventArgs) Handles btn2x.Click
        RESUL = 2 ^ Result.Text
        Result.Text = RESUL
    End Sub

End Class