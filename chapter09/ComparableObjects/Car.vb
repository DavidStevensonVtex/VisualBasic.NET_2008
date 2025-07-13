Public Class Car
    Implements IComparable

    Public Property Name As String
    Public Property Speed As Integer
    Public Property ID As Integer

    Public Sub New()
    End Sub
    Public Sub New(ByVal name As String, ByVal speed As Integer, ByVal id As Integer)
        Me.Name = name
        Me.Speed = speed
        Me.ID = id
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Name} is going {Speed} MPH"
    End Function

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Dim temp As Car = CType(obj, Car)
        If Me.ID > temp.ID Then
            Return 1
        ElseIf Me.ID < temp.ID Then
            Return -1
        Else
            Return 0
        End If
    End Function
End Class
