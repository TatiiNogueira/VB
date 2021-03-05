'Link do Video -> https://www.youtube.com/watch?v=gNWQlKMHEOI

'Ativar o que está à frente de Option
Option Explicit On
Option Strict On

Public Class Form1

    Private Const myPage1 As String = "1. Code A Minute"
    Private Const myPage2 As String = "2. iBasskung Tutorial"

    'Button Resultados
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringScore As String = txtScore.Text.Trim()
        Dim stringLetra As String = ""
        Dim stringNota As String = String.Empty
        Dim stringMessage As String = ""
        Dim intScore As Integer
        'Caminho da pasta onde estão as imgs
        Dim stringImg As String = "C:\Users\nogue\Desktop\Work\VB\Notas Escolares EUA\Select_Case_WinForms\Fotos_Letras\"

        'Se o utilizador introduzir números
        If Integer.TryParse(stringScore, intScore) Then
            If (intScore >= 0) And (intScore <= 100) Then
                Select Case intScore
                    'A
                    Case 90 To 100
                        stringImg &= "A.png"
                        stringLetra = "A"
                        stringNota = "4.0"
                        stringMessage = "Parabéns!!"
                    'B
                    Case 80 To 89
                        stringImg &= "B.png"
                        stringLetra = "B"
                        stringNota = "3.0"
                        stringMessage = "Boa, tiveste uma boa nota"
                    'C
                    Case 74 To 79
                        stringImg &= "C.png"
                        stringLetra = "C"
                        stringNota = "2.0"
                        stringMessage = "Foi por pouco, mas passas te"
                    'D
                    Case 71 To 73
                        stringImg &= "D.png"
                        stringLetra = "D"
                        stringNota = "1.0"
                        stringMessage = "Não correu muito bem. Para a próxima estuda mais"
                    Case Else 'E
                        stringImg &= "F.png"
                        stringLetra = "F"
                        stringNota = "0.0"
                        stringMessage = "Foste um desastre. Para a próxima vê se estudas"

                End Select

                'Exibir a img na PictureBox
                Dim imgIcon As Image = Image.FromFile(stringImg)
                PictureBox1.Image = imgIcon

                'Exibir os resulatdos nas Texboxs
                txtletra.Text = stringLetra
                txtnota.Text = stringNota
                txtmessage.Text = stringMessage

            Else
                Dim caption As String = "VB.NET: Validating User INPUT"
                Dim button As MessageBoxButtons = MessageBoxButtons.OK
                Dim icon As MessageBoxIcon = MessageBoxIcon.Information

                'Mensagem
                MessageBox.Show(Me, "Por favor apenas introduza um número ente 0 e 100" &
                                Environment.NewLine & vbNewLine &
                                "Faceboo pages: " & vbNewLine & myPage1 & Environment.NewLine &
                                myPage2, caption, button, icon)

                'Chamar a função Clear
                ClearControlValues()

                Return
            End If
        Else
            'Se o utilizar introduzir algo que não seja números
            Dim caption As String = "VB.NET: Validating User INPUT"
            Dim button As MessageBoxButtons = MessageBoxButtons.OK
            Dim icon As MessageBoxIcon = MessageBoxIcon.Exclamation

            'Mensagem
            MessageBox.Show(Me, "Por favor apenas introduza números" &
                            Environment.NewLine & vbNewLine &
                            "Faceboo pages: " & vbNewLine & myPage1 & Environment.NewLine &
                            myPage2, caption, button, icon)

            'Chamar a função Clear
            ClearControlValues()
        End If
    End Sub

    'Cabeçalho, onde fica o nome da página
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chamar o Method Clear
        ClearControlValues()
    End Sub

    'Create Method Clear
    Private Sub ClearControlValues()
        Try
            'Limpar a img
            PictureBox1.Image = Nothing
            'Limpar os valores das textboxs
            txtScore.Clear()
            txtletra.Text = ""
            txtnota.Text = String.Empty
            txtmessage.Text = ""

            txtScore.Select()

        Catch ex As Exception
            MessageBox.Show("Erro")
        End Try
    End Sub
End Class
