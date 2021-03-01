'Link do Tutorial -> https://www.youtube.com/watch?v=3FkWddODLno

'NOTAS: 
'Dim - Serve para declarar variáveis

'Tipo de valores e a sua respetiva conversão de string para o tipo de valor
'Entre parenteses fica o valor que queremos converter
'Integer -> Números inteiros -> CInt()
'Long -> Números Longos/compridos -> CLong()
'Decimal -> Números Decimais -> CDec()
'Double -> Tipo de dados fornece as maiores e menores magnitudes possíveis para um número -> CDbl()
'Boolean -> True or False -> CBool()

Public Class Form1
    'Button Message
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles txtMessage.Click
        'Quando clicar no botão Message irá aparecer uma janela com a mensgem "Hi"
        'mais o/s valores que colocar na textBox
        'O "Name Window" é o texto que quero que apareça como nome da janela
        'mais o/s valores que colocar na textBox
        MessageBox.Show("Hi " & txtName.Text, "Name window " & txtName.Text)
    End Sub

    'Button OK
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Quando clicar no botão OK o programa irá escrever o texto que indiquei (Hello)
        'No inicio da textBox, independentemente de existiram lá dados ou não
        txtName.Text = "Hello " & txtName.Text
    End Sub

    'Button Exit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Sair da janela
        Me.Close()
    End Sub

    'Button +
    Private Sub btnAddValues_Click(sender As Object, e As EventArgs) Handles btnAddValues.Click
        'Só irá executar a conta se os valores forem do tipo que foi indicado 
        'Neste caso "Integer"(Inteiro)
        Try
            Dim firstNum As Integer = CInt(txtAddVal1.Text)
            Dim secondNum As Integer = CInt(txtAddVal2.Text)
            'Realização da soma
            Dim sum = firstNum + secondNum

            'Mostrar o Resultado
            'Conversão do valor para string
            txtSumAnswer.Text = CStr(sum)
        Catch ex As System.InvalidCastException
            'Mensagem que quero que apareça quando introduzir um valor que não seja um númeor inteiro
            '"Error" é o nome da janela (Posso mudar para o que quiser)
            MessageBox.Show("Please enter numbers to sum", "Error")
            'Mensagem que quero que apareça na consola quando introduzir um valor que não seja um númeor inteiro
            Console.WriteLine("An error occurred")
        Catch ex As Exception
            'Mensagem que quero que apareça quando um erro inesperado/desconhecido acontecer
            '"Error" é o nome da janela (Posso mudar para o que quiser)
            MessageBox.Show("An unknow error occurred", "Error")
        End Try
    End Sub

    'Button /
    Private Sub btnDivideValues_Click(sender As Object, e As EventArgs) Handles btnDivideValues.Click
        'Só irá executar a conta se os valores forem do tipo que foi indicado 
        'Neste caso "Decimal"
        Try
            Dim firstNum As Decimal = CDec(txtDivideVal1.Text)
            Dim secondNum As Decimal = CDec(txtDivideVal2.Text)
            'Realização da Divisão
            Dim intSolution As Integer = CType(firstNum / secondNum, Integer)

            'Mostrar o Resultado
            'Conversão do valor para string
            txtDivisionAnswer.Text = CStr(intSolution)
        Catch ex As System.InvalidCastException
            'Mensagem que quero que apareça quando introduzir um valor que não seja um númeor inteiro
            '"Error" é o nome da janela (Posso mudar para o que quiser)
            MessageBox.Show("Please enter numbers to sum", "Error")
            'Mensagem que quero que apareça na consola quando introduzir um valor que não seja um númeor inteiro
            Console.WriteLine("An error occurred")
        Catch ex As Exception
            'Mensagem que quero que apareça quando um erro inesperado/desconhecido acontecer
            '"Error" é o nome da janela (Posso mudar para o que quiser)
            MessageBox.Show("An unknow error occurred", "Error")
        End Try
    End Sub

End Class
