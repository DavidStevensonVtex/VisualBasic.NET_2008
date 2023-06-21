Imports System

Module Program
	Sub Main(args As String())
		ArrayListTest()
		QueueTest()
		StackTest()
	End Sub
	Sub ArrayListTest()
		' Make ArrayList and add a range of Cars.
		Dim carArrayList As New ArrayList()
		carArrayList.AddRange(New Car() {New Car("Fred", 90, 10), New Car("Mary", 100, 50), New Car("MB", 190, 11)})
		Console.WriteLine($"Items in carArrayList: {carArrayList.Count}")

		For Each c As Car In carArrayList
			Console.WriteLine($"Car pet name: {c.PetName}")
		Next

		' Insert New car
		Console.WriteLine("-> Inserting new Car.")
		carArrayList.Insert(2, New Car("TheNewCar", 0, 12))
		Console.WriteLine($"Items in carArrayList: {carArrayList.Count}")

		' Get the subobjects as an array.
		Dim arrayOfCars As Object() = carArrayList.ToArray()
		Dim i As Integer = 0

		' Now iterate over array using While loop/Length property.
		While i < arrayOfCars.Length
			Console.WriteLine($"Car pet name: {CType(arrayOfCars(i), Car).PetName}")
			i = i + 1
		End While
	End Sub

	Sub WashCar(ByVal c As Car)
		Console.WriteLine($"Cleaning {c.PetName}")
	End Sub

	Sub QueueTest()
		Console.WriteLine()
		Console.WriteLine("QueueTest")
		' Make a Q with three items.
		Dim carWashQ As New Queue
		carWashQ.Enqueue(New Car("FirstCar", 0, 1))
		carWashQ.Enqueue(New Car("SecondCar", 0, 2))
		carWashQ.Enqueue(New Car("ThirdCar", 0, 3))

		' Peek at first car in Q.
		Console.WriteLine("First in Q is {0}", CType(carWashQ.Peek(), Car).PetName)

		' Remove each item from Q
		WashCar(CType(carWashQ.Dequeue(), Car))
		WashCar(CType(carWashQ.Dequeue(), Car))
		WashCar(CType(carWashQ.Dequeue(), Car))

		' Try to de-Q again?
		Try
			WashCar(CType(carWashQ.Dequeue(), Car))
		Catch ex As Exception
			Console.WriteLine($"Error!! {ex.Message}")
		End Try
	End Sub

	Sub StackTest()
		Console.WriteLine()
		Console.WriteLine("StackTest")

		Dim stringStack As New Stack
		stringStack.Push("One")
		stringStack.Push("Two")
		stringStack.Push("Three")

		' Now look at the top item, pop it, and look again.
		Console.WriteLine($"Top item is: {stringStack.Peek()}")
		Console.WriteLine($"Popped off {stringStack.Pop()}")
		Console.WriteLine($"Top item is: {stringStack.Peek()}")
		Console.WriteLine($"Popped off {stringStack.Pop()}")
		Console.WriteLine($"Top item is: {stringStack.Peek()}")
		Console.WriteLine($"Popped off {stringStack.Pop()}")

		Try
			Console.WriteLine($"Top item is: {stringStack.Peek()}")
			Console.WriteLine($"Popped off {stringStack.Pop()}")
		Catch ex As Exception
			Console.WriteLine($"Error!! {ex.Message}")
		End Try
	End Sub
End Module
