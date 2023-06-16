Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** A First Look at Structures ******")
		' Create an initial Point.
		Dim myPoint As New Point()
		myPoint.X = 349
		myPoint.Y = 76
		myPoint.Display()

		' Adjust the X and Y values
		myPoint.Increment()
		myPoint.Display()
		Console.WriteLine("Point in hex: {0}", myPoint.PointAsHexString())
	End Sub
End Module
