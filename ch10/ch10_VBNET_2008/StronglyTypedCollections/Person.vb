Public Class Person
	Public Property CurrentAge As Integer
	Public Property FirstName As String
	Public Property LastName As String

	Public Sub New()
	End Sub
	Public Sub New(ByVal fName As String, ByVal lName As String, ByVal age As Integer)
		FirstName = fName
		LastName = lName
		CurrentAge = age
	End Sub

	Public Overrides Function ToString() As String
		Return $"{LastName}, {FirstName} is {CurrentAge} years old."
	End Function
End Class
