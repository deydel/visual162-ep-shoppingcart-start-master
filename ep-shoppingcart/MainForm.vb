Public Class MainForm

    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzad.ForeColor = Color.Black
        btnAcces.ForeColor = Color.Black

        btnHombre.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzad.ForeColor = Color.Black
        btnAcces.ForeColor = Color.Black

        lblTitulo.Text = "Cotton Line V-neck Jumper"
        PictureBox1.Image = ImgPH.Images.Item(0)
        PictureBox2.Image = ImgPH.Images.Item(1)
        PictureBox3.Image = ImgPH.Images.Item(2)
        PictureBox4.Image = ImgPH.Images.Item(3)
    End Sub

    Private Sub btnHombre_Click(sender As Object, e As EventArgs) Handles btnHombre.Click
        btnHombre.ForeColor = Color.SteelBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzad.ForeColor = Color.Black
        btnAcces.ForeColor = Color.Black

        lblTitulo.Text = "Cotton Line V-neck Jumper"
        PictureBox1.Image = ImgPH.Images.Item(0)
        PictureBox2.Image = ImgPH.Images.Item(1)
        PictureBox3.Image = ImgPH.Images.Item(2)
        PictureBox4.Image = ImgPH.Images.Item(3)
    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.SteelBlue
        btnCalzad.ForeColor = Color.Black
        btnAcces.ForeColor = Color.Black

        lblTitulo.Text = "Nicola Blouse"
        PictureBox1.Image = ImgPM.Images.Item(0)
        PictureBox2.Image = ImgPM.Images.Item(1)
        PictureBox3.Image = ImgPM.Images.Item(2)
        PictureBox4.Image = ImgPM.Images.Item(3)


    End Sub

    Private Sub btnCalzad_Click(sender As Object, e As EventArgs) Handles btnCalzad.Click
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzad.ForeColor = Color.SteelBlue
        btnAcces.ForeColor = Color.Black

        lblTitulo.Text = "Phillipe 1d Trainers"
        PictureBox1.Image = ImgCalzaP.Images.Item(0)
        PictureBox2.Image = ImgCalzaP.Images.Item(1)
        PictureBox3.Image = ImgCalzaP.Images.Item(2)
        PictureBox4.Image = ImgCalzaP.Images.Item(3)
    End Sub

    Private Sub btnAcces_Click(sender As Object, e As EventArgs) Handles btnAcces.Click
        btnHombre.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzad.ForeColor = Color.Black
        btnAcces.ForeColor = Color.SteelBlue

        lblTitulo.Text = "Strap Watch 1791"
        PictureBox1.Image = ImgAccP.Images.Item(0)
        PictureBox2.Image = ImgAccP.Images.Item(1)
        PictureBox3.Image = ImgAccP.Images.Item(2)
        PictureBox4.Image = ImgAccP.Images.Item(2)
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        lblTitulo.Text = "Eng Poplin Shirt"
        lblTitulo.Text = "Plaited Sub Cashemer Blend Jumper"

    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        lblTitulo.Text = "Eng Poplin Shirt"
        lblTitulo.Text = "Cotton Line V-neck Jumper"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox5.Image = ImgGH.Images.Item(0)
        lblPrecio.Text = "$95"

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox5.Image = ImgGH.Images.Item(1)
        lblPrecio.Text = "$95"
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox5.Image = ImgGH.Images.Item(2)
        lblPrecio.Text = "$95"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox5.Image = ImgGH.Images.Item(3)
        lblPrecio.Text = "$95"
    End Sub


End Class