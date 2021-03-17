'Link do Video -> https://www.youtube.com/watch?v=vQxu3ApaAMQ

Public Class Form1

    'pl1 = panel1 heigh
    Dim pl1 As Integer = 60
    'pl2 = panel2 heigh
    Dim pl2 As Integer = 60
    'pl3 = panel3 heigh
    Dim pl3 As Integer = 60

    'Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Timer 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '250 = panel height
        If pl1 > 250 Then
            Timer1.Stop()
        Else
            Me.Panel1.Size = New Size(Me.Panel1.Size.Width, pl1)
            pl1 += 10
        End If
    End Sub

    'Timer 2
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        '250 = panel height
        If pl2 > 250 Then
            Timer1.Stop()
        Else
            Me.Panel2.Size = New Size(Me.Panel2.Size.Width, pl2)
            pl2 += 10
        End If
    End Sub

    'Timer 3
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        '250 = panel height
        If pl3 > 250 Then
            Timer1.Stop()
        Else
            Me.Panel3.Size = New Size(Me.Panel3.Size.Width, pl3)
            pl3 += 10
        End If
    End Sub

    'Opção Mouse Hover - Fica no Raio
    '1º Conjunto de botões
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        'Quando o rato estiver no primeiro conjunto de botões os outros fecham se
        Me.Panel2.Size = New Size(Me.Panel2.Width, pl2)
        Me.Panel3.Size = New Size(Me.Panel3.Width, pl3)
        Timer1.Start()
    End Sub

    '2º Conjunto de botões
    Private Sub Button8_MouseHover(sender As Object, e As EventArgs) Handles Button8.MouseHover
        'Quando o rato estiver no segundo conjunto de botões os outros fecham se
        Me.Panel1.Size = New Size(Me.Panel1.Width, pl1)
        Me.Panel3.Size = New Size(Me.Panel3.Width, pl3)
        Timer2.Start()
    End Sub

    '3º Conjunto de botões
    Private Sub Button12_MouseHover(sender As Object, e As EventArgs) Handles Button12.MouseHover
        'Quando o rato estiver no terceiro conjunto de botões os outros fecham se
        Me.Panel1.Size = New Size(Me.Panel1.Width, pl1)
        Me.Panel2.Size = New Size(Me.Panel2.Width, pl2)
        Timer3.Start()
    End Sub

    'Opção Mouse Leave - Fica no Raio
    '1º Conjunto de botões
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Timer1.Stop()
        pl1 = 60
    End Sub

    '2º Conjunto de botões
    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Timer2.Stop()
        pl2 = 60
    End Sub

    '3º Conjunto de botões
    Private Sub Button12_MouseLeave(sender As Object, e As EventArgs) Handles Button12.MouseLeave
        Timer3.Stop()
        pl3 = 60
    End Sub
End Class
