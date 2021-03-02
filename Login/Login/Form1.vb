'Link do video -> https://www.youtube.com/watch?v=Vx_U7gj4syU

'Importações
Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    'Button Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Ligação à Base de dados
        Dim con As SqlConnection = New SqlConnection("Data Source = LAPTOP-TN8OGODS; INITIAL CATALOG = VB_Testes/Estudo;Integrated Security = True")
        'Indicação dos dados e a que tabela vamos retirar
        Dim cmd As SqlCommand = New SqlCommand("select * from Logins where username ='" + txtUser.Text + "'and password='" + txtPass.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        'Retorna as linhas da Tabela
        sda.Fill(dt)

        'Se o utilizador inserir os dados corretos
        If (dt.Rows.Count > 0) Then
            'Mensagem que queremos que apareça
            MessageBox.Show("Login realizado com sucesso", "Informação do Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'Se o utilizador inserir os dados incorretos ou não inserir nada
            'Mensagem que queremos que apareça
            MessageBox.Show("Login inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
