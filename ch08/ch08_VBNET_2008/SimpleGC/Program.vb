Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with System.GC *****")
		' Print out estimated number of bytes on heap.
		Console.WriteLine($"Estimated bytes on heap: {GC.GetTotalMemory(False)}")

		' MaxGeneration is zero based, so add 1 for display purposes.
		Console.WriteLine($"This OS has {GC.MaxGeneration + 1} object generations.")

		' Create a new Car object on the managed heap.
		' We are returned a reference to this object that we store in the
		' 'refToMyCar' local variable.
		Dim refToMyCar As New Car("Zippy", 50)

		' The VB 2008 dot operator (.) is used to invoke members on the object
		' using our reference variable.
		Console.WriteLine(refToMyCar.ToString())

		' Print out generation of refToMyCar object.
		Console.WriteLine($"Generation of refToMyCar is: {GC.GetGeneration(refToMyCar)}")

		' Make a ton of objects for testing purposes.
		Dim tonsOfObjects(5000) As Object
		For i As Integer = 0 To UBound(tonsOfObjects)
			tonsOfObjects(i) = New Object
		Next

		' Force a garbage collection and wait for each object to be finalized.
		' Collect only gen 0 objets.
		GC.Collect(0)
		GC.WaitForPendingFinalizers()

		' Print out generation of refToMyCar object.
		Console.WriteLine($"Generation of refToMyCar is: {GC.GetGeneration(refToMyCar)}")

		' See if tonsOfObjects(4000) is still alive.
		If (tonsOfObjects(4000) IsNot Nothing) Then
			Console.WriteLine($"Generation of tonsOfObjects(4000) is: {GC.GetGeneration(tonsOfObjects(4000))}")
		Else
			Console.WriteLine("tonsOfObjects(4000) is no longer alive.")
		End If

		Console.WriteLine($"Gen 0 has been swept {GC.CollectionCount(0)} times")
		Console.WriteLine($"Gen 1 has been swept {GC.CollectionCount(1)} times")
		Console.WriteLine($"Gen 2 has been swept {GC.CollectionCount(2)} times")

		Console.WriteLine()
	End Sub

	Sub MakeACar()
		' If myCar is the only reference to the Car object,
		' it may be destroyed when the method returns.
		Dim myCar As New Car
	End Sub
End Module
