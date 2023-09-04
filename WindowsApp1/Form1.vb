Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = ProductoServicio.Listar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prod As New Producto()
        prod.Nombre = TextBox1.Text
        prod.Precio = NumericUpDown1.Value
        ProductoServicio.Insertar(prod)
        DataGridView1.DataSource = ProductoServicio.Listar()
    End Sub
End Class
