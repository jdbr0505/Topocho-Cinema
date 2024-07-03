Public Class Persona 'Comenzamos poniendo la clase de la persona'
    'Luego ponemos las propiedades o mejor dicho los atributos de la clase, los tres atributos los consideramos textos que el usuario colocara'
    Private nombre As String
    Private apellido As String
    Private cedula As String

    'Luego reconocemos los atributos de la persona'
    Public Sub New(nombre As String, apellido As String, cedula As String)
        Me.nombre = nombre
        Me.apellido = apellido
        Me.cedula = cedula
    End Sub

    'Y por ultimo activamos las funciones utilizando el get de por medio para activar los datos que tendra la persona'
    Public Function GetNombre() As String
        Return nombre
    End Function

    Public Function GetApellido() As String
        Return apellido
    End Function

    Public Function GetCedula() As String
        Return cedula
    End Function
End Class  'Cerramos la clase de la Persona'

