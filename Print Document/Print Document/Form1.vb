'Link do Video -> https://www.youtube.com/watch?v=95ZE9gmaYEU

'NOTA: O programa mostra a pré visualização do ficheiro que criamos

Public Class form1

    'Element PrintDocument1
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Indicação do tipo de letra e do tamanho para o título e para o texto
        Dim ReportFont As Font = New Drawing.Font("Time New Roman", 20)
        Dim ReportBodyFont As Font = New Drawing.Font("Time New Roman", 15)
        'Indicação do titulo, da cor e da localização
        'Titulo
        e.Graphics.DrawString("My Title", ReportFont, Brushes.Chocolate, 150, 100)
        'Texto
        e.Graphics.DrawString("O meu texto experimental", ReportBodyFont, Brushes.CornflowerBlue, 100, 125)
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewControl1.Document = PrintDocument1
    End Sub
End Class
