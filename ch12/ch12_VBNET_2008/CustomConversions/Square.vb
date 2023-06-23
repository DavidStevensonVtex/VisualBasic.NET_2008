Public Class Square
	Public Property Length As Integer

	Public Sub Draw()
		Console.WriteLine("Drawing a square.")
	End Sub

	Public Overrides Function ToString() As String
		Return $"[Length = {Length}]"
	End Function

	' Rectangles can be explicitly converted into squares.
	Public Shared Narrowing Operator CType(ByVal r As Rectangle) As Square
		Dim s As New Square
		s.Length = r.Width
		Return s
	End Operator

	Public Shared Narrowing Operator CType(ByVal sideLength As Integer) As Square
		Dim newSq As New Square
		newSq.Length = sideLength
		Return newSq
	End Operator

	Public Shared Narrowing Operator CType(ByVal s As Square) As Integer
		Return s.Length
	End Operator
End Class