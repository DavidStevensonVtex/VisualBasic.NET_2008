Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Dispose *****")
		Dim rw As New MyResourceWrapper
		Try
			' Call members of rw.
		Finally
			rw.Dispose()
		End Try
	End Sub
End Module
