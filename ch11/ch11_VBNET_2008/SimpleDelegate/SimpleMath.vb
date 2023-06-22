
' Our delegate type can point to  any method
' taking two Integers and returning an Integer.

Public Delegate Function BinaryOp(ByVal x As Integer, ByVal y As Integer) As Integer

Public Class SimpleMath
	Public Shared Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
		Return x + y
	End Function

	Public Shared Function Subtract(ByVal x As Integer, ByVal y As Integer) As Integer
		Return x - y
	End Function

End Class
