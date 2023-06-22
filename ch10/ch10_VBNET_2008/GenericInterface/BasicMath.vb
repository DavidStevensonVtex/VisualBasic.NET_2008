Public Class BasicMath
	Implements IBasicMath(Of Integer)

	Public Function Add(a As Integer, b As Integer) As Integer Implements IBasicMath(Of Integer).Add
		Return a + b
	End Function

	Public Function Subtract(a As Integer, b As Integer) As Integer Implements IBasicMath(Of Integer).Subtract
		Return a - b
	End Function

	Public Function Multiply(a As Integer, b As Integer) As Integer Implements IBasicMath(Of Integer).Multiply
		Return a * b
	End Function

	Public Function Divide(a As Integer, b As Integer) As Integer Implements IBasicMath(Of Integer).Divide
		Return a / b
	End Function
End Class
