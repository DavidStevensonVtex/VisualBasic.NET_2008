Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Dispose *****")
		Using rw As New MyResourceWrapper,
				rw2 As New MyResourceWrapper
			' Use the object, Dispose() is automatically called.
		End Using
	End Sub
End Module
