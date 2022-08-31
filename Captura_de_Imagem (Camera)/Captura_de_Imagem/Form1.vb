'Link do Video -> https://www.youtube.com/watch?v=UerRxfj7qyM
'Link do Código do Video -> https://laptrinhvb.net/index.php?/bai-viet/chuyen-de-vb-net/Huong-dan-chup-anh-tu-camera-su-dung-thu-vien-AForge-NET/1d5d0248cf4bfb26.html

'NOTAS
'Bitmap é Pixel
'ShowDialog() - Mostra o formulário como uma caixa de diálogo modal.
'Diálogo modal - É aquele que aparece na parte superior do conteúdo principal e move
'o sistema para um modo especial que requer interação do usuário. Esta caixa de diálogo
'desativa o conteúdo principal até
'que o usuário interaja explicitamente com a caixa de diálogo modal 


'Importações
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class Form1
    'Variáveis
    Dim Camera As VideoCaptureDevice
    Dim bmp As Bitmap

    'Liga a camera do Computador
    Private Sub iniciar_camera_Click(sender As Object, e As EventArgs) Handles iniciar_camera.Click
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Camera = cameras.VideoDevice
            AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf Capture)
            Camera.Start()
        End If
    End Sub

    'Faz com que o video funcione
    Private Sub Capture(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    'Tira a fotografia
    Private Sub capturar_imagem_Click(sender As Object, e As EventArgs) Handles capturar_imagem.Click
        PictureBox2.Image = PictureBox1.Image
    End Sub

    'Salvar a Imagem no computador
    'A imagem nós é que decidimos onde queremos guardar no computador
    Private Sub salvar_Click(sender As Object, e As EventArgs) Handles salvar.Click
        'Formato pré definido por nós da imagem
        SaveFileDialog1.DefaultExt = ".jpg"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Abre a Janela para indicarmos onde queremos guardar a nossa fotografia
            PictureBox2.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
        End If
    End Sub

End Class
