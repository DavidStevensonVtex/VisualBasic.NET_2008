Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Finalizers *****")
		Console.WriteLine("Hit the retur key to shut down this app")
		Console.WriteLine("and force the GC to invoke Finalize()")
		Console.WriteLine("for finalizable objects created in this AppDomain")
		Dim rw As New MyResourceWrapper

	End Sub
End Module
