Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class basevb
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=basevb")
    End Sub

    Public Overridable Property Productos As DbSet(Of Producto)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Producto)() _
            .Property(Function(e) e.Nombre) _
            .IsUnicode(False)
    End Sub
End Class
