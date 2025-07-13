' We now support a custom property to return the correct IComparer interface.
Public Class Car
    Implements IComparable

    ' This helper class is used to sort an array of Cars by pet name.
    Private Class PetNameComparer
        Implements IComparer

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim c1 As Car = CType(x, Car)
            Dim c2 As Car = CType(y, Car)
            Return String.Compare(c1.Name, c2.Name)
        End Function
    End Class

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

    ' Assume PetNameCcomparer has been nested within the Car Type.

    ' Property to return the pet name comparer.
    Public Shared ReadOnly Property SortByPetName() As IComparer
        Get
            Return New PetNameComparer()
        End Get
    End Property
End Class
