Public Class ProductoServicio
    Public Shared Function Listar() As List(Of Producto)
        Dim productos = New List(Of Producto)
        Using con = New basevb()
            productos = con.Productos.ToList()
        End Using
        Return productos
    End Function
    Public Shared Function Insertar(prod As Producto)
        Using con = New basevb()
            con.Productos.Add(prod)
            con.SaveChanges()
        End Using
    End Function

End Class
