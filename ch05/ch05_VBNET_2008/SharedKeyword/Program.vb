Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Shared Methods *****")
		For i As Integer = 0 To 5
			Console.WriteLine(Teenager.Complain())
		Next
		Console.WriteLine()

		Dim bob As New Teenager()
		For i As Integer = 0 To 5
			'Console.WriteLine(bob.Complain())
			' Warning BC42025	Access Of Shared member, constant member, enum member Or nested type through an instance;
			' qualifying expression will Not be evaluated.
			Console.WriteLine(Teenager.Complain())
		Next

	End Sub
End Module
