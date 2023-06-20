Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Info about my Cars *****")
		Dim myCars As New Garage

		' Hand over each car in the collection?
		For Each c As Car In myCars
			Console.WriteLine($"{c.Name} is going {c.Speed}")
		Next

		' Get IEnumerable directly.
		Dim iEnum As IEnumerator
		iEnum = myCars.GetEnumerator()
		iEnum.Reset()
		iEnum.MoveNext()

		Dim firstCar As Car = CType(iEnum.Current, Car)
		Console.WriteLine($"First car in collection is: {firstCar.Name}")
		Console.WriteLine()

	End Sub
End Module
