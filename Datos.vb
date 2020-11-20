Public Class Datos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Module1.apellidos = TextBoxSurname.Text
        Module1.nombre = TextBoxName.Text
        Module1.telefono = TextBoxTelephone.Text
        If RadioButton1.Checked Then
            Module1.sexo = "Hombre"
        End If
        If RadioButton2.Checked Then
            Module1.sexo = "Mujer"
        End If
        Form1.DataGridView1.Rows.Add(Module1.nombre, Module1.apellidos, Module1.sexo, Module1.telefono, Module1.Icono)

        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName())
            Module1.Icono = Image.FromFile(OpenFileDialog1.FileName())
        End If
    End Sub

    Private Sub Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show(bandera)
        If bandera Then
            ButtonSave.Hide()
            TextBoxSurname.Text = Module1.apellidos
            TextBoxName.Text = Module1.nombre
            TextBoxTelephone.Text = Module1.telefono

            If Module1.sexo = "Hombre" Then
                RadioButton1.Select()
            End If
            If Module1.sexo = "Mujer" Then
                RadioButton2.Select()
            End If
            PictureBox1.Image = Module1.Icono
        End If

        bandera = False
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub
End Class