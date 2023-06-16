Class MathUtils
	' The Overloads keyword is optional and can only be used within
	' a class or structure without compiler warnings.
	Overloads Shared Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
		Return x + y
	End Function

	Overloads Shared Function Add(ByVal x As Double, ByVal y As Double) As Double
		Return x + y
	End Function

	Overloads Shared Function Add(ByVal x As Long, ByVal y As Long) As Long
		Return x + y
	End Function

End Class
