' MiniVan derives from Car.
Public Class MiniVan
    Inherits Car
    ' He, we can now define members that are unique to
    ' the MiniVan type.

    Public Sub TestMethod()
        ' OK! Can use public Car memebers within the derived type.
        Speed = 10
    End Sub

End Class
