' Multiple interfaces with a comma-delimited list.
Public Class Hexagon
    Inherits Shape
    Implements IPointy, ICloneable, IDraw3D

    Public Sub New()
    End Sub

    Public Sub New(ByVal name As String)
        MyBase.New(name)
    End Sub

    Public ReadOnly Property Points As Byte Implements IPointy.Points
        Get
            Return 6
        End Get
    End Property

    Public Overrides Sub Draw()
        Console.WriteLine($"Drawing {shapeName} the Hexagon")
    End Sub

    Public Sub Draw3D() Implements IDraw3D.Draw3D
        Console.WriteLine("Drawing Hexagon in 3D!")
    End Sub

    Public Function Clone() As Object Implements ICloneable.Clone
        Throw New NotImplementedException()
    End Function
End Class
