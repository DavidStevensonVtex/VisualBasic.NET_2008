Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Nullable Data *****" & vbCrLf)

		Dim dr As New DatabaseReader()

		' GEt Integer from "database".
		Dim i As Nullable(Of Integer) = dr.GetIntFromDatabase()
		If (i.HasValue) Then
			Console.WriteLine($"Value of 'i' is: {i.Value}")
		Else
			Console.WriteLine("Value of 'i' is undefined")
		End If

		' Get boolean from "database".
		Dim b As Nullable(Of Boolean) = dr.GetBoolFromDatabase()
		If (b.HasValue) Then
			Console.WriteLine($"Value of 'b' is : {b.Value}")
		Else
			Console.WriteLine("Value of 'b' is undefined.")
		End If
	End Sub
End Module
