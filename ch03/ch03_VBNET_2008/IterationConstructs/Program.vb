Imports System

Module Program
	Sub Main(args As String())
		' Prints out the numbers 5 - 25 inclusive.
		For i = 5 To 25
			Console.Write("{0} ", i)
		Next
		Console.WriteLine()

		For i As Integer = 5 To 25
			Console.Write("{0} ", i)
		Next
		Console.WriteLine()

		For i As Integer = 5 To 25 Step 5
			Console.Write("{0} ", i)
		Next
		Console.WriteLine()

		Dim myStrings() As String = {"Fun", "with", "VB 2008"}

		For Each str As String In myStrings
			Console.Write(str & " ")
		Next
		Console.WriteLine()

		For Each item In myStrings
			Console.Write(item & " ")
		Next
		Console.WriteLine()


		Dim j As Integer
		While j < 20
			Console.Write(j & ", ")
			j = j + 1
		End While
		Console.WriteLine()

		Dim myStuff As New ArrayList()
		myStuff.Add(100)
		myStuff.Add("Hello")
		Console.WriteLine("Size Is: {0}", myStuff.Count)

		With myStuff
			.Add(200)
			.Add("Goodbye")
			Console.WriteLine("Size is: {0}", .Count)
		End With
	End Sub
End Module
