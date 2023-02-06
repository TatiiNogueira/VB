
'Videos:
'https://www.youtube.com/watch?v=nMnQmiZ9H4s
'https://www.youtube.com/watch?v=73sVW_NgmMc

'Importações
Imports System.IO

Public Class Upload_File
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click
        'Abir a Dialog
        OpenFileDialog1.ShowDialog()
        Dim N_Elementos As Integer = OpenFileDialog1.FileName.Split("\"c).Count()
        Dim filename As String = OpenFileDialog1.FileName.Split("\"c)(N_Elementos - 1)
        txt_Files.Text = filename
        Try
            'Colocar o ficheiro na pasta do IN
            File.Copy(OpenFileDialog1.FileName, System.AppContext.BaseDirectory & "Ficheiros\Ficheiros_In\" & filename)
            'Apagar o ficheiro de onde ele estava
            IO.File.Delete(OpenFileDialog1.FileName)
            MessageBox.Show("Upload do Ficheiro realizado com sucesso")
        Catch ex As Exception
            MessageBox.Show("Ficheiro já existente")
        End Try
    End Sub
End Class
