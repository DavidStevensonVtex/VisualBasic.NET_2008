' A class named Point
Public Class Point
    Implements ICloneable
    Public Property X As Integer
    Public Property Y As Integer
    Public Desc As New PointDescription()

    Public Sub New()
    End Sub
    Public Sub New(ByVal xPos As Integer, ByVal yPos As Integer)
        X = xPos
        Y = yPos
    End Sub
    Public Sub New(ByVal xPos As Integer, ByVal yPos As Integer, ByVal name As String)
        X = xPos
        Y = yPos
        Desc.PetName = name
    End Sub

    Public Overrides Function ToString() As String
        Return $"X = {X} ; Y = {Y} ; Name = {Desc.PetName} : ID = {Desc.PointID}"
    End Function

    ' This version of Clone() returns a deep copy.
    Public Function Clone() As Object Implements ICloneable.Clone
        Dim newPoint As Point = CType(Me.MemberwiseClone(), Point)

        Dim currentDesc = New PointDescription()
        currentDesc.PetName = Me.Desc.PetName
        currentDesc.PointID = Me.Desc.PointID

        newPoint.Desc = currentDesc
        Return newPoint
    End Function
End Class
