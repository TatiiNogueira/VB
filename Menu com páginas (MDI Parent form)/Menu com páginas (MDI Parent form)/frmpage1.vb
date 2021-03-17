Public Class frmpage1
    Private Sub frmpage1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rnd As New Random

        Me.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Sub
End Class
