Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Generic Interfaces *****")
		Dim m As New BasicMath()
		Console.WriteLine($"1 + 1 = {m.Add(1, 1)}")
		Console.WriteLine()
	End Sub
End Module
