Module NonGenericMethods
	Public Sub Swap(ByRef a As Integer, ByRef b As Integer)
		Dim temp As Integer
		temp = a
		a = b
		b = temp
	End Sub

End Module
