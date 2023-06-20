Public Class Car
	Implements IComparable

	Public Property CarID As Integer
	Public Property CurrentSpeed As Integer
	Public Property PetName As String

	Public Sub New(ByVal name As String, ByVal currSp As Integer, ByVal id As Integer)
		PetName = name
		CurrentSpeed = currSp
		Me.CarID = id
	End Sub

	Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
		Dim temp As Car = CType(obj, Car)
		If Me.CarID < temp.CarID Then
			Return -1
		ElseIf Me.CarID > temp.CarID Then
			Return 1
		Else
			Return 0
		End If
	End Function
End Class
