' This helper class is used to sort an array of Cars by pet name.
Public Class PetNameComparer
	Implements IComparer

	Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
		Dim c1 As Car = CType(x, Car)
		Dim c2 As Car = CType(y, Car)
		Return String.Compare(c1.PetName, c2.PetName)
	End Function
End Class
