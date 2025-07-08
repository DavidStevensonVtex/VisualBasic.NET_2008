' Hexagon DOES override Draw().
Public Class Hexagon
    Inherits Shape

    Public Sub New()
    End Sub

    Public Sub New(ByVal name As String)
        MyBase.New(name)
    End Sub

    Public Overrides Sub Draw()
        Console.WriteLine($"Drawing {shapeName} the Hexagon")
    End Sub

End Class
