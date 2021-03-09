'Link do Video -> https://www.youtube.com/watch?v=K31g-D7GaMM

Public Class Form1

    'Button Load Chart
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Introdução dos dados que queremos que apareçam no gráfico
        Me.Chart1.Series("Age").Points.AddXY("Mark", 33)
        Me.Chart1.Series("Nº de Filhos").Points.AddXY("Mark", 8)

        Me.Chart1.Series("Age").Points.AddXY("Julia", 50)
        Me.Chart1.Series("Nº de Filhos").Points.AddXY("Julia", 10)

        Me.Chart1.Series("Age").Points.AddXY("António", 33)
        Me.Chart1.Series("Nº de Filhos").Points.AddXY("António", 7)

        Me.Chart1.Series("Age").Points.AddXY("Maria", 33)
        Me.Chart1.Series("Nº de Filhos").Points.AddXY("Maria", 5)
    End Sub
End Class

