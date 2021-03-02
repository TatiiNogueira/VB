Public Class Form1
    Private objBanco As New Acesso
    'Button Consultar
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        objBanco.Conectar()

        'Indicação da tabela que quero retirar os dados e que dados
        Dim ds As DataSet = objBanco.ExecuteQuery("select * from Categories")
        dgvDados.DataSource = ds.Tables(0)
        'Fechar
        objBanco.Fechar()

    End Sub
End Class
