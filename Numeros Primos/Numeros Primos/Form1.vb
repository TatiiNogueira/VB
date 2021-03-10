'Link do Video -> https://www.youtube.com/watch?v=Y3JhlixZ8Tc

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim checkprime = 1, i, primenumber As Integer
        For primenumber = TextBox1.Text To TextBox2.Text
            For i = 2 To primenumber - 1
                If primenumber Mod i = 0 Then
                    checkprime = 0
                    Exit For
                Else
                    checkprime = 1
                End If
            Next
            If checkprime = 1 Then
                ListBox1.Items.Add(primenumber)
            End If
        Next
    End Sub
End Class
