Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Productos")>
Partial Public Class Producto

    Public Property Id As Integer

    <StringLength(50)>
    Public Property Nombre As String

    Public Property Precio As Integer?
End Class
