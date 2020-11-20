Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Datos.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Referenciamos la fila actual del control DataGridView
        '
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        ' Obtenemos el valor de la columna Nombre
        '
        Module1.nombre = row.Cells("Column2").Value
        Module1.apellidos = row.Cells("Column3").Value
        Module1.sexo = row.Cells("Column4").Value
        Module1.telefono = row.Cells("Column5").Value
        Module1.Icono = row.Cells("Column6").Value

        bandera = True
        Datos.Show()

    End Sub
End Class
