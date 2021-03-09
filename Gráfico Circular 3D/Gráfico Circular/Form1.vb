'Link do Video -> https://www.youtube.com/watch?v=GoYVw6swo68

Public Class Form1
    'Button Gerar Gráfico
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GerarGrafico()
    End Sub

    Private Sub GerarGrafico()
        'Nomes dos produtos
        Dim produtos() As String = {"Fruta", "Doces", "Salgados", "Vegetais", "Bebidas"}
        'Quantidade dos produtos
        Dim valores() As Double = {36798, 56587, 67842, 84987, 43254}

        'Inserir Titulo Principal
        Dim title = New DataVisualization.Charting.Title()
        title.Font = New Font("Elephsnt", 22, FontStyle.Bold)
        title.ForeColor = Color.BlueViolet
        title.Text = "Vendas de Fevereiro de 2021"
        Chart1.Titles.Add(title)

        'Inserir Sub Titulo
        Dim title2 = New DataVisualization.Charting.Title()
        title2.Font = New Font("Arial", 16, FontStyle.Bold Or FontStyle.Italic)
        title2.ForeColor = Color.Red
        title2.Text = "Vendas em Euros"
        Chart1.Titles.Add(title2)

        'Inserir legenda
        Dim legend = New DataVisualization.Charting.Legend()
        Chart1.Legends.Add(legend)
        Chart1.Legends(0).Title = "Produtos"

        'Vendas reais
        Chart1.Series.Add("Vendas")
        With Chart1
            .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie

            .ChartAreas(0).Area3DStyle.Enable3D = True
            'Inclinação do gráfico
            .ChartAreas(0).Area3DStyle.Inclination = 60
            .ChartAreas(0).Area3DStyle.Rotation = 60

            .Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

            'Mostrar os valores sobre as fatias do gráfico circular
            .Series(0).IsValueShownAsLabel = True
            'Valores a serem colcoados no gráfico
            .Series(0).Points.DataBindXY(produtos, valores)
        End With
    End Sub

End Class
