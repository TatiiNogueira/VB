'Link do Video -> https://www.youtube.com/watch?v=nQIhfXi_8dY

'Importações
Imports System.Drawing.Drawing2D
Imports System.Drawing

Public Class Form1
    Dim backbuffer As New Bitmap(Width, Height)
    'Faz um degradé
    Dim grandientBrush As New LinearGradientBrush(New PointF(100, 100), New Point(200, 200), Color.Blue, Color.Red)
    Dim imageMatrix As New Matrix()

    Dim isMouseDown As Boolean = False
    Dim mousePoint As Point

    'Button Timer (Relógio)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim g As Graphics
        g = Graphics.FromImage(backbuffer)
        'Indicação de que queremos a janela preta
        g.Clear(Color.Black)
        g.Transform = imageMatrix
        'Desenha um Retangulo/Quadrado com a cores que indicamos em "Pens", o ponto onde o queremos "Point"
        'e com o tamanho que indicamos "Size"
        g.DrawRectangle(Pens.Blue, New Rectangle(New Point(10, 10), New Size(100, 100)))
        'Desenha uma bola
        g.FillEllipse(grandientBrush, New Rectangle(New Point(10, 10), New Size(100, 100)))
        'Escreve uma frase/palavra/texto
        '"Hello World!!" -> É o texto que quisermos
        'Brushes é a cor e Point é a posição
        g.DrawString("Hello World!!", Font, Brushes.Black, New Point(25, 50))

        Me.CreateGraphics.DrawImage(backbuffer, New Point(0, 0))
    End Sub

    'Atribuição de movimento às figuras
    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            'Quando clicar na tecla D
            Case Keys.D
                imageMatrix.RotateAt(-10, New Point(2, 2))
           'Quando clicar na tecla A
            Case Keys.A
                imageMatrix.RotateAt(10, New Point(2, 2))
           'Quando clicar na tecla espaço
            Case Keys.Space
                'As figuras voltam para o sitio e tamanho inicial
                imageMatrix.Reset()
           'Quando clicar na tecla +
            Case Keys.Add
                'As figuras aumentam de tamanho
                imageMatrix.Scale(1.01, 1.01)
            'Quando clicar na tecla -
            Case Keys.Subtract
                'As figuras diminuem de tamanho
                imageMatrix.Scale(0.99, 0.99)
        End Select
    End Sub

    'Movimento com o rato para baixo
    Private Sub Form1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        isMouseDown = True
        mousePoint = e.Location
    End Sub

    'Movimento com o rato para cima
    Private Sub Form1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        isMouseDown = False
    End Sub

    'Permite andarmos com as figuras
    Private Sub Form1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If isMouseDown = True Then
            imageMatrix.Translate(e.X - mousePoint.X, e.Y - mousePoint.Y)
            mousePoint = e.Location
        End If
    End Sub
End Class
