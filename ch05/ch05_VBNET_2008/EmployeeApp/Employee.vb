Public Class Employee
	' Field data.
	Private empName As String
	Private empID As Integer
	Private currPay As Single

	' Constructors
	Public Sub New()
	End Sub

	Public Sub New(ByVal name As String, ByVal id As Integer, ByVal pay As Single)
		empName = name
		empID = id
		currPay = pay
	End Sub

	' Accessor (get method).
	Public Function GetName() As String
		Return empName
	End Function

	Public Sub SetName(ByVal name As String)
		' Remove any illegal characters(!,@,#,$,%)
		' Check maximum length or case before making assignment
		empName = name
	End Sub

	' Methods
	Public Sub GiveBonus(ByVal amount As Single)
		currPay += amount
	End Sub
	Public Sub DisplayStats()
		Console.WriteLine("Name: {0}", empName)
		Console.WriteLine("ID: {0}", empID)
		Console.WriteLine("Pay: {0}", currPay)
	End Sub

End Class
