'Link do Video Designe da App Restaurante -> https://www.youtube.com/watch?v=znANTJNf8wI
'Link do Video Imprimir Recibo -> https://www.youtube.com/watch?v=_hHIm-TNsD8

Public Class formMain

    'Button Foods
    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        pnlOnButtonFood.Height = btnFoods.Height
        pnlOnButtonFood.Top = btnFoods.Top
        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    'Button Drinks
    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        pnlDrinks.Height = btnDrinks.Height
        pnlDrinks.Top = btnDrinks.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = True
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    'Button Deserts
    Private Sub btnDeserts_Click(sender As Object, e As EventArgs) Handles btnDeserts.Click
        pnlDeserts.Height = btnDeserts.Height
        pnlDeserts.Top = btnDeserts.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = True
        pnlMyCart.Visible = False
        pnlAbout.Visible = False
    End Sub

    'Button MyCart
    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
        pnlMyCart.Height = btnMyCart.Height
        pnlMyCart.Top = btnMyCart.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = True
        pnlAbout.Visible = False
    End Sub

    'Button About
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        pnlAbout.Height = btnAbout.Height
        pnlAbout.Top = btnAbout.Top
        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAbout.Visible = True
    End Sub

    'Button "X"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Fechar a janela
        Me.Close()
    End Sub

    'Button "-"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Minimizar janela
        Me.WindowState = WindowState.Minimized
    End Sub

    'Button "+"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    'Comidas
    'Frango
    Private Sub btnFrango_Click(sender As Object, e As EventArgs) Handles btnFrango.Click
        txtFoods.Text = txtFoods.Text & "
        Frango ----- 50€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("50")
        MessageBox.Show("Um prato de frango foi adicionado ao seu pedido")
    End Sub

    'Arroz
    Private Sub btnArroz_Click(sender As Object, e As EventArgs) Handles btnArroz.Click
        txtFoods.Text = txtFoods.Text & "
        Arroz ----- 10€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("10")
        MessageBox.Show("Um prato de arroz foi adicionado ao seu pedido")
    End Sub

    'Massa
    Private Sub btnMassa_Click(sender As Object, e As EventArgs) Handles btnMassa.Click
        txtFoods.Text = txtFoods.Text & "
        Massa ----- 60€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("60")
        MessageBox.Show("Um prato de massa foi adicionado ao seu pedido")
    End Sub

    'Sopa
    Private Sub btnSopa_Click(sender As Object, e As EventArgs) Handles btnSopa.Click
        txtFoods.Text = txtFoods.Text & "
        Sopa ----- 80€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("80")
        MessageBox.Show("Um prato de sopa foi adicionado ao seu pedido")
    End Sub

    'Carangejo
    Private Sub btnCaranguejo_Click(sender As Object, e As EventArgs) Handles btnCaranguejo.Click
        txtFoods.Text = txtFoods.Text & "
        Carangejo ----- 150€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("150")
        MessageBox.Show("Um prato de carangejo foi adicionado ao seu pedido")
    End Sub

    'Peixe
    Private Sub btnOutro_Click(sender As Object, e As EventArgs) Handles btnOutro.Click
        txtFoods.Text = txtFoods.Text & "
        Peixe ----- 80€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("80")
        MessageBox.Show("Um prato de peixe foi adicionado ao seu pedido")
    End Sub

    'Button Cancelar Pedido
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtTOTAL.Clear()
        txtInvisivel.Clear()
        txtFoods.Clear()
    End Sub

    'Button Fazer o Pedido
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnPedir.Click
        If txtFoods.Text = Nothing Then
            MessageBox.Show("Ainda não fez nenhum pedido")
        Else
            txtTOTAL.Text = txtInvisivel.Text + "€"
            MessageBox.Show("Recibo" & vbCrLf & txtFoods.Text & vbCrLf & vbCrLf & "Total a pagar: " + txtInvisivel.Text + (" €"))
        End If
    End Sub

    'Bebidas
    'Café
    Private Sub btnCafe_Click(sender As Object, e As EventArgs) Handles btnCafe.Click
        txtFoods.Text = txtFoods.Text & "
        Café ----- 10€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("10")
        MessageBox.Show("Um café foi adicionado ao seu pedido")
    End Sub

    'Chá
    Private Sub btnCha_Click(sender As Object, e As EventArgs) Handles btnCha.Click
        txtFoods.Text = txtFoods.Text & "
        Chá ----- 20€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("20")
        MessageBox.Show("Um chá foi adicionado ao seu pedido")
    End Sub

    'Milkshake
    Private Sub btnMilkshake_Click(sender As Object, e As EventArgs) Handles btnMilkshake.Click
        txtFoods.Text = txtFoods.Text & "
        Milkshake ----- 50€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("50")
        MessageBox.Show("Um milkshake foi adicionado ao seu pedido")
    End Sub

    'Sumo
    Private Sub btnSumo_Click(sender As Object, e As EventArgs) Handles btnSumo.Click
        txtFoods.Text = txtFoods.Text & "
        Sumo ----- 100€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("100")
        MessageBox.Show("Um sumo foi adicionado ao seu pedido")
    End Sub

    'Softdrink
    Private Sub btnSoftdrink_Click(sender As Object, e As EventArgs) Handles btnSoftdrink.Click
        txtFoods.Text = txtFoods.Text & "
        Softdrink ----- 250€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("250")
        MessageBox.Show("Um softdrink foi adicionado ao seu pedido")
    End Sub

    'Coca Cola
    Private Sub btnOutroS_Click(sender As Object, e As EventArgs) Handles btnOutroS.Click
        txtFoods.Text = txtFoods.Text & "
        Coca Cola ----- 120€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("120")
        MessageBox.Show("Uma coca cola foi adicionado ao seu pedido")
    End Sub

    'Sobremesas
    'Pudim
    Private Sub btnPudim_Click(sender As Object, e As EventArgs) Handles btnPudim.Click
        txtFoods.Text = txtFoods.Text & "
        Pudim ----- 400€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("400")
        MessageBox.Show("Um pudim foi adicionado ao seu pedido")
    End Sub

    'Bolo
    Private Sub btnBolo_Click(sender As Object, e As EventArgs) Handles btnBolo.Click
        txtFoods.Text = txtFoods.Text & "
        Bolo ----- 1500€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("1500")
        MessageBox.Show("Uma fatia de bolo foi adicionado ao seu pedido")
    End Sub

    'Gelado
    Private Sub btnGelado_Click(sender As Object, e As EventArgs) Handles btnGelado.Click
        txtFoods.Text = txtFoods.Text & "
        Gelado ----- 40€"
        If txtInvisivel.Text = Nothing Then
            txtInvisivel.Text = 0
        End If
        txtInvisivel.Text = txtInvisivel.Text + CInt("40")
        MessageBox.Show("Uma tigela de gelado foi adicionado ao seu pedido")
    End Sub

    'Button Recibo
    Private Sub btnRecibo_Click(sender As Object, e As EventArgs) Handles btnRecibo.Click
        If txtFoods.Text = Nothing Then
            MessageBox.Show("Ainda não fez nenhum pedido")
        Else
            Dim strPrint As String
            strPrint = "My App Restaurante" & vbCrLf
            strPrint = strPrint & "----------------------------------" & vbCrLf
            strPrint = strPrint & txtFoods.Text & vbCrLf
            strPrint = strPrint & "----------------------------------" & vbCrLf
            strPrint = strPrint & txtTOTAL.Text + " €" & vbCrLf
            Printer.Print(strPrint)
        End If
    End Sub
End Class
