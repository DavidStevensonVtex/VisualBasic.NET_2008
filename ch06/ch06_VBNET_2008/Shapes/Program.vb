Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Polymorphism *****")
		Console.WriteLine()

		Dim hex As New Hexagon("Beth")
		hex.Draw()

		Dim cir As New Circle("Cindy")
		' Calls base class implementation!
		cir.Draw()
		Console.WriteLine()

		' Make an array of Shape compatible objects.
		Dim myShapes() As Shape = {New Hexagon(), New Circle(), New Hexagon("Mick"), New Circle("Beth"), New Hexagon("Linda")}

		' Loop over each item and interact with the polymorphic interface.
		For Each s As Shape In myShapes
			s.Draw()
		Next

		Console.WriteLine()

		' Fun with shadowing.
		Dim o As New ThreeDCircle
		o.Draw()
		CType(o, Circle).Draw()
		Console.WriteLine()
	End Sub
End Module
