' A class named Point
Public Class Point
    Implements ICloneable
    Public Property X As Integer
    Public Property Y As Integer

    Public Sub New()
    End Sub
    Public Sub New(ByVal xPos As Integer, ByVal yPos As Integer)
        X = xPos
        Y = yPos
    End Sub

    Public Overrides Function ToString() As String
        Return $"X = {X} ; Y = {Y}"
    End Function

    Public Function Clone() As Object Implements ICloneable.Clone
        Return New Point(X, Y)
    End Function
End Class
