Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Delegates as event enablers *****")
		Dim c1 As New Car("SlugBug", 10)

		' Pass the address of the methods that will be maintained
		' by the delegate member variables of the Car type.

		' Register multiple event handlers!
		c1.OnAboutToBlow(AddressOf CarAboutToBlow)
		c1.OnAboutToBlow(AddressOf CarIsAlmostDoomed)
		c1.OnExploded(AddressOf CarExploded)

		Console.WriteLine("***** Speeding Up *****")
		For i As Integer = 0 To 5
			c1.Accelerate(20)
		Next
		Console.WriteLine()

		' Remove CarExploded from invocation list.
		c1.RemoveExploded(AddressOf CarExploded)

		' This will not fire the Exploded event.
		For i As Integer = 0 To 5
			c1.Accelerate(20)
		Next

		Console.WriteLine()
	End Sub

	' These are called by the Car object.
	Public Sub CarAboutToBlow(ByVal msg As String)
		Console.WriteLine(msg)
	End Sub

	Public Sub CarIsAlmostDoomed(ByVal msg As String)
		Console.WriteLine(msg)
	End Sub

	Public Sub CarExploded(ByVal msg As String)
		Console.WriteLine(msg)
	End Sub
End Module
