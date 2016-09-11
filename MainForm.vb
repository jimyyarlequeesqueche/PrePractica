Public Class MainForm
    'Hombres
    Dim p1 As String = "Camisa de Algodon" : Dim p2 As String = "$ 120.00"
    Dim p3 As String = "Blazer Mezda de Lana"
    Dim p4 As String = "$ 240.00"
    Dim p5 As String = "Camisa Jersey"
    Dim p6 As String = "$ 160.00"
    Dim p7 As String = "Polo Cuello Redondo"
    Dim p8 As String = "$ 75.00"
    'Mujeres
    Dim p9 As String = "Polo Rayas Cuello"
    Dim p10 As String = "$ 80.00"
    Dim p11 As String = "Chompa de Lana"
    Dim p12 As String = "$ 150.00"
    Dim p13 As String = "Casaca de Jean"
    Dim p14 As String = "$ 220.00"
    Dim p15 As String = "Abrigo de Lana"
    Dim p16 As String = "$ 270.00"
    'Calzado
    Dim p17 As String = "Zapatos Oxfords"
    Dim p18 As String = "$ 120.00"
    Dim p19 As String = "Zapatos Derby"
    Dim p20 As String = "$ 130.00"
    Dim p21 As String = "Botines"
    Dim p22 As String = "$ 160.00"
    Dim p23 As String = "Loafers"
    Dim p24 As String = "$ 75.00"
    'Accesorios
    Dim p25 As String = "Reloj de Acero"
    Dim p26 As String = "$ 380.00"
    Dim p27 As String = "Cinturon de Cuero"
    Dim p28 As String = "$ 70.00"
    Dim p29 As String = "Billetera de Cuero"
    Dim p30 As String = "$ 190.00"
    Dim p31 As String = "Gorra Clasica"
    Dim p32 As String = "$ 75.00"

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Hombre.Click

        'Hombres cargador "
        PictureBox1.Image = Image.FromFile("C:\Users\Daniel\Desktop\visual162-p01shoppingcart-start-master\p01shoppingcart\img\hombres\hombres-01.jpg")
        'Hombres()
        item1.Text = p1.ToString() : item2.Text = p2.ToString() : item3.Text = p3.ToString() : item4.Text = p4.ToString()
        item5.Text = p5.ToString() : item6.Text = p6.ToString() : item7.Text = p7.ToString() : item8.Text = p8.ToString()
    End Sub
    Private Sub Mujeres_Click(sender As Object, e As EventArgs) Handles Mujeres.Click
        PictureBox1.Image = Image.FromFile("C:\Users\Daniel\Desktop\visual162-p01shoppingcart-start-master\p01shoppingcart\img\mujeres\mujeres-01.jpg")
        'Mujeres()
        item1.Text = p9.ToString() : item2.Text = p10.ToString() : item3.Text = p11.ToString() : item4.Text = p12.ToString()
        item5.Text = p13.ToString() : item6.Text = p14.ToString() : item7.Text = p15.ToString() : item8.Text = p16.ToString()
    End Sub

    Private Sub Calzado_Click(sender As Object, e As EventArgs) Handles Calzado.Click
        PictureBox1.Image = Image.FromFile("C:\Users\Daniel\Desktop\visual162-p01shoppingcart-start-master\p01shoppingcart\img\calzado\calzado-01.jpg")
        'Calzado()
        item1.Text = p17.ToString() : item2.Text = p18.ToString() : item3.Text = p19.ToString() : item4.Text = p20.ToString()
        item5.Text = p21.ToString() : item6.Text = p22.ToString() : item7.Text = p23.ToString() : item8.Text = p24.ToString()
    End Sub

    Private Sub Accecsorios_Click(sender As Object, e As EventArgs) Handles Accecsorios.Click
        PictureBox1.Image = Image.FromFile("C:\Users\Daniel\Desktop\visual162-p01shoppingcart-start-master\p01shoppingcart\img\accesorios\accesorios-01.jpg")
        'Accesoris()
        item1.Text = p25.ToString() : item2.Text = p26.ToString() : item3.Text = p27.ToString() : item4.Text = p28.ToString()
        item5.Text = p30.ToString() : item6.Text = p30.ToString() : item7.Text = p31.ToString() : item8.Text = p32.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CasiaA.Click

        PictureBox1.Image = Image.FromFile("C:\Users\Daniel\Desktop\visual162-p01shoppingcart-start-master\p01shoppingcart\img\hombres\hombres-01.jpg")
        item1.Text = p1.ToString() : item2.Text = p2.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CasiaB.Click
        Dim prenda3 As String = "Camisa de Algodon"
        Dim prenda4 As String = "$ 120.00"
        PictureBox1.Image = Image.FromFile("C:\Users\Daniel\Desktop\visual162-p01shoppingcart-start-master\p01shoppingcart\img\hombres\hombres-02.jpg")
        item3.Text = prenda3.ToString()
        item4.Text = prenda4.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CasiaC.Click
        PictureBox1.Image = Image.FromFile("C:\Users\Daniel\Desktop\visual162-p01shoppingcart-start-master\p01shoppingcart\img\hombres\hombres-03.jpg")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CasiaD.Click
        PictureBox1.Image = Image.FromFile("C:\Users\Daniel\Desktop\visual162-p01shoppingcart-start-master\p01shoppingcart\img\hombres\hombres-04.jpg")

    End Sub


End Class