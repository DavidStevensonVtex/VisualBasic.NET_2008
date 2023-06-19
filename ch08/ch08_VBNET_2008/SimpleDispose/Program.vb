Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Dispose *****")
		Dim rw As New MyResourceWrapper
		If (TypeOf rw Is IDisposable) Then
			rw.Dispose()
		End If
	End Sub
End Module
