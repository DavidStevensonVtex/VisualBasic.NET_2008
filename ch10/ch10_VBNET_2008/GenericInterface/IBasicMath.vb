Public Interface IBasicMath(Of T)
	Function Add(ByVal a As T, ByVal b As T) As T
	Function Subtract(ByVal a As T, ByVal b As T) As T
	Function Multiply(ByVal a As T, ByVal b As T) As T
	Function Divide(ByVal a As T, ByVal b As T) As T
End Interface
