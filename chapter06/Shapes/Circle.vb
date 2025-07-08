' Circle DOES NOT override Draw()
Public Class Circle
    Inherits Shape

    Public Sub New()
    End Sub

    Public Sub New(ByVal name As String)
        MyBase.New(name)
    End Sub

    Public Overrides Sub Draw()
        Console.WriteLine($"Drawing {shapeName} the Circle")
    End Sub
End Class
