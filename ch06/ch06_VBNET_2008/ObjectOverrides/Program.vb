Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with System.Object ******")
		Dim p1 As New Person

		' Use inherited members of System.Object
		Console.WriteLine("ToString: {0}", p1.ToString())
		Console.WriteLine("Hash code: {0}", p1.GetHashCode())
		Console.WriteLine("Type: {0}", p1.GetType())

		' Make some other references to hc.
		Dim p2 As Person = p1
		Dim o As Object = p2

		' Are the references pointing to the same objet in memory
		If o.Equals(p1) AndAlso p2.Equals(o) Then
			Console.WriteLine("Same instance!")
		End If

		Console.WriteLine()
	End Sub
End Module
