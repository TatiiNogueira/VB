'Link do Video -> https://www.youtube.com/watch?v=U9XuT9FDQYU

Public Class Form1
    Dim BirdCount As Integer = 1

    'Timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case BirdCount
            Case 1
                PicBird.Image = My.Resources.bird1
                BirdCount += 1
            Case 2
                PicBird.Image = My.Resources.bird2
                BirdCount += 1
            Case 3
                PicBird.Image = My.Resources.bird3
                BirdCount += 1
            Case 4
                PicBird.Image = My.Resources.bird4
                BirdCount += 1
            Case 5
                PicBird.Image = My.Resources.bird5
                BirdCount += 1
            Case 6
                PicBird.Image = My.Resources.bird6
                BirdCount += 1
            Case 7
                PicBird.Image = My.Resources.bird7
                BirdCount += 1
            Case 8
                PicBird.Image = My.Resources.bird8
                BirdCount += 1
            Case 9
                PicBird.Image = My.Resources.bird9
                BirdCount += 1
            Case 10
                PicBird.Image = My.Resources.bird10
                BirdCount += 1
            Case 11
                PicBird.Image = My.Resources.bird11
                BirdCount += 1
            Case 12
                PicBird.Image = My.Resources.birdLast
                BirdCount = 1


        End Select
    End Sub

    'Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class
