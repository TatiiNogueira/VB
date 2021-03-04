'Link -> https://www.youtube.com/watch?v=a76p7eHdvNw

Public Class Acesso
    Private objConexao As SqlClient.SqlConnection

    'Função conectar à Base de dados
    Public Sub Conectar()
        Try
            'Dados para a ligação à base de dados
            'Data Source -> Servidor
            'INITIAL CATALOG -> Base de dados
            'USER ID -> Username
            'Password -> Palavra Passe
            objConexao = New SqlClient.SqlConnection("Data Source = LAPTOP-TN8OGODS; INITIAL CATALOG = Northwind; USER ID = sa; PASSWORD = 1234")

            'Abrir a ligação à Base de Dados
            objConexao.Open()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Função fechar conecção à base de dados
    Public Sub Fechar()
        Try
            'Se a conexão não for "nada"(IsNothing)
            If Not IsNothing(objConexao) Then
                'Se a conexão estiver aberta (ConnectionState.Open)
                If objConexao.State = ConnectionState.Open Then
                    'Fechar a conexão
                    objConexao.Close()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Função SELECT (Vai buscar os dados desejados)
    Public Function ExecuteQuery(ByVal Command As String) As DataSet
        'Variáveis
        Dim ds As New DataSet
        Dim objDataAdapter As New SqlClient.SqlDataAdapter
        Dim objCommand As New SqlClient.SqlCommand

        Try
            objCommand = objConexao.CreateCommand
            objCommand.CommandText = Command
            objDataAdapter = New SqlClient.SqlDataAdapter(objCommand)
            'Retorna as linhas da uma fonte de dados usando a declaração SELECT
            'definida por uma propriedade SelectCommand associada 
            objDataAdapter.Fill(ds)
        Catch ex As Exception
            Throw ex
        End Try
        'Retorna o ds(dados da base ded dados)
        Return ds
    End Function
End Class
