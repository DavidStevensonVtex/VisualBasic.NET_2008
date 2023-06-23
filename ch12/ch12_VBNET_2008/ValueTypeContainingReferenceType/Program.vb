Imports System

Module Program
	Sub Main(args As String())
		' Create the first MyRectangle
		Console.WriteLine("-> Creating r1")
		Dim r1 As New MyRectangle("This is my first rectangle")

		' Now assign a new MyRectangle to r1
		Console.WriteLine("-> Assigning r1 to r2")
		Dim r2 As MyRectangle
		r2 = r1

		Console.WriteLine("-> Values before change: ")
		Console.WriteLine($"-> r1.RectInfo.InfoString: {r1.RectInfo.InfoString}")
		Console.WriteLine($"-> r2.RectInfo.InfoString: {r2.RectInfo.InfoString}")
		Console.WriteLine($"-> r1.Bottom: {r1.Bottom}")
		Console.WriteLine($"-> r2.Bottom: {r2.Bottom}")
		Console.WriteLine()


		' Change the values of r2.
		Console.WriteLine("-> Changing all values of r2")
		r2.RectInfo.InfoString = "This is new info!"
		r2.Bottom = 4444
		Console.WriteLine()

		' Print Values
		Console.WriteLine("-> Values after change: ")
		Console.WriteLine($"-> r1.RectInfo.InfoString: {r1.RectInfo.InfoString}")
		Console.WriteLine($"-> r2.RectInfo.InfoString: {r2.RectInfo.InfoString}")
		Console.WriteLine($"-> r1.Bottom: {r1.Bottom}")
		Console.WriteLine($"-> r2.Bottom: {r2.Bottom}")

		Console.WriteLine()
		Console.WriteLine("Since the Structure contains reference types (RectInfo), which are copied, the values pointed to are shared by r1 and r2 (RectInfo.InfoString")
	End Sub
End Module
