Imports System

Module Program
	Sub Main(args As String())
		' Make a value type.
		Dim s As Short = 25

		' Because "s" is passed into a 
		' method prototyped to take an Object
		' it is boxed automatically.
		UseThisObject(s)
		Console.WriteLine()

		Dim myData As New ArrayList()
		myData.Add(88)
		myData.Add(3.33)
		myData.Add(False)
		' Unbox first item from ArrayList.
		Dim firstItem As Integer = CType(myData(0), Integer)
		Console.WriteLine($"First item is {firstItem}")
		Console.WriteLine()

		Dim p As MyPoint
		p.x = 10
		p.y = 20
		UseBoxedMyPoint(p)
		Console.WriteLine()

	End Sub

	Sub UseThisObject(ByVal o As Object)
		Console.WriteLine($"Value of o is: {o}")
	End Sub

	Sub UseBoxedMyPoint(ByVal o As Object)
		' Error! System.Object does not have
		' member variables named "x" or "y".
		' In this new version of Visual Basic.NET, structures can be "boxed" or converted to objects.
		Console.WriteLine($"MyPoint: {o.x}, {o.y}")
	End Sub
End Module
