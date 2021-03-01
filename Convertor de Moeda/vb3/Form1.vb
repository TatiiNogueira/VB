Public Class tusdg
    'Button Dollar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Val(TextBox7.Text) * 1.12
    End Sub

    'Button Escudos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Val(TextBox7.Text) * 200.482
    End Sub

    'Button Real
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = Val(TextBox7.Text) * 4.31
    End Sub

    'Button Libra
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = Val(TextBox7.Text) * 0.89
    End Sub

    'Button Clear
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox7.Clear()
    End Sub

    'Button Exit
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class
