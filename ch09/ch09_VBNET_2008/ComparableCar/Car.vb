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

	' This helper class is used to sort an array of Cars by pet name.
	Public Class PetNameComparer
		Implements IComparer

		Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
			Dim c1 As Car = CType(x, Car)
			Dim c2 As Car = CType(y, Car)
			Return String.Compare(c1.PetName, c2.PetName)
		End Function
	End Class

	' Property to return the pet name comparer

	Public Shared ReadOnly Property SortByPetName() As IComparer
		Get
			Return New PetNameComparer()
		End Get
	End Property
End Class
