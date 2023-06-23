Public Class Person
	Public Property FullName As String
	Public Property Age As Integer

	Public Sub New(ByVal name As String, ByVal currentAge As Integer)
		FullName = name : Age = currentAge
	End Sub

	Public Overrides Function ToString() As String
		Return $"Name: {FullName} Age: {Age}"
	End Function
End Class
