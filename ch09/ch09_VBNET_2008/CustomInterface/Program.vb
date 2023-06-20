Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Interfaces ******")
		Dim hex As New Hexagon()
		Console.WriteLine("Number of Points: {0}", hex.Points)
		Console.WriteLine()

		' Circle does not implement IPointy interface.
		Dim c As New Circle
		Dim itfPointy As IPointy
		' Try to get IPointy from Circle
		Try
			itfPointy = CType(c, IPointy)
			Console.WriteLine($"Number of Points: {itfPointy.Points}")
		Catch ex As Exception
			Console.WriteLine($"{c} does not implement IPointy!")
		End Try

		' See which objects support IPointy.
		Console.WriteLine($"Circle implements IPointy?: {TypeOf c Is IPointy}")
		Console.WriteLine($"Hexagon implements IPointy?: {TypeOf hex Is IPointy}")

		Dim myShapes() As Shape = {New Hexagon("Fred"), New Circle("Angie"), New ThreeDCircle(), New Triangle("Adam")}
		For Each s As Shape In myShapes
			If TypeOf s Is IPointy Then
				itfPointy = CType(s, IPointy)
				Console.WriteLine($"{s.PetName} has {itfPointy.Points} points.")
			Else
				Console.WriteLine($"{s.PetName} does not implement IPointy!")
			End If
		Next
	End Sub
End Module
