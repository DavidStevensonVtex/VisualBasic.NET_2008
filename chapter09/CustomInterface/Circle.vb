' Circle DOES NOT override Draw()
Public Class Circle
    Inherits Shape
    Implements IDraw3D

    Public Sub New()
    End Sub

    Public Sub New(ByVal name As String)
        MyBase.New(name)
    End Sub

    Public Overrides Sub Draw()
        Console.WriteLine($"Drawing {shapeName} the Circle")
    End Sub

    Public Sub Draw3D() Implements IDraw3D.Draw3D
        Console.WriteLine("Drawing circle in 3D!")
    End Sub
End Class
