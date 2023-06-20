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

			' Is this item IDraw3D aware?
			If TypeOf s Is IDraw3D Then
				'DrawIn3D(s)
				DrawIn3D(CType(s, IDraw3D))
			End If
		Next

		' Can we extracxt IPointy from an Array of Integers?
		Dim myInts() As Integer = {10, 20, 30}
		Dim i As IPointy = ExtractPointyness(myInts)

		' Nope!
		If i Is Nothing Then
			Console.WriteLine("Sorry, this object was not IPointy compatible.")
		End If

		Console.WriteLine()
	End Sub

	' This method can receive anything implemetning IDraw3D
	Sub DrawIn3D(ByVal itf3d As IDraw3D)
		Console.WriteLine("-> Drawing IDraw3D compatible type")
		itf3d.Draw3D()
	End Sub

	'This method tests for IPointy compatibility and,
	' if able, returns an interface reference.
	Function ExtractPointyness(ByVal o As Object) As IPointy
		If TypeOf o Is IPointy Then
			Return CType(o, IPointy)
		Else
			Return Nothing
		End If
	End Function
End Module
