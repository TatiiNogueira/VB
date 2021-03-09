'Link do Video -> https://www.youtube.com/watch?v=LBIpg1tS454

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tempo de intervalo
        Timer.Interval = 25
        Timer.Start()
    End Sub

    'Timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        'Movimento do avião
        aviao.Left += 3
    End Sub

    'LocationChange (Fica no raio)
    Private Sub aviao_LocationChanged(sender As Object, e As EventArgs) Handles aviao.LocationChanged
        If aviao.Left >= Me.Width Then
            aviao.Left = 0 - aviao.Width
        End If
    End Sub
End Class
