' Remember! Person extends Object.
Public Class Person
	' Public only for simplicity. Properties and Private data
	' would obviously be preferred.
	Public fName As String
	Public lName As String
	Public personAge As Byte

	Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal age As Byte)
		fName = firstName
		lName = lastName
		personAge = age
	End Sub
	Public Sub New()
	End Sub

	Public Overrides Function ToString() As String
		Return String.Format("[First Name: {0}; Last Name: {1} Age: {2}]", fName, lName, personAge)
	End Function

	'Public Overrides Function Equals(obj As Object) As Boolean
	'	If TypeOf obj Is Person AndAlso obj IsNot Nothing Then
	'		Dim temp As Person = CType(obj, Person)
	'		If temp.fName = Me.fName AndAlso temp.lName = Me.lName AndAlso temp.personAge = Me.personAge Then
	'			Return True
	'		Else
	'			Return False
	'		End If
	'	End If
	'	Return False
	'End Function

	Public Overrides Function Equals(obj As Object) As Boolean
		' No need to cast "obj" to a Person anymore,
		' as everything has a ToString() method.
		Return obj.ToString() = Me.ToString()
	End Function

	Public Overrides Function GetHashCode() As Integer
		Return Me.ToString().GetHashCode()
	End Function
End Class