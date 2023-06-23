Public Structure Rectangle
	Public Property Width As Integer
	Public Property Height As Integer

	Public Sub Draw()
		Console.WriteLine("Drawing a rectangle")
	End Sub

	Public Overrides Function ToString() As String
		Return $"[Width = {Width}, Height = {Height}]"
	End Function

	Public Shared Widening Operator CType(ByVal s As Square) As Rectangle
		Dim r As Rectangle
		r.Height = s.Length

		' Assume the length of the new Rectangle with (Length x 2)
		r.Width = s.Length * 2
		Return r
	End Operator
End Structure
