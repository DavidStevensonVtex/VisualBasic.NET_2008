Module NonGenericDelegateTest
	Sub TestMethod()
		' Register target with "traditional" delegate syntax.
		Dim d As New MyDelegate(AddressOf MyTarget)
		d("More string data")

		' Regiter target using method group conversion.
		Dim d2 As New MyDelegate(AddressOf MyTarget)
		d2(9)       ' Boxing penalty
	End Sub

	' Due to a lack of type safety, we must determine the underlying type before casting.
	Sub MyTarget(ByVal arg As Object)
		If TypeOf arg Is Integer Then
			Dim i As Integer = CType(arg, Integer)      ' Unboxing penalty!
			i += 1
			Console.WriteLine($"++arg is {i}")
		End If

		If TypeOf arg Is String Then
			Dim s As String = CType(arg, String)
			Console.WriteLine($"arg in uppercase is: {s.ToUpper()}")
		End If
	End Sub

End Module
