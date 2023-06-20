Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with IComparable *****")
		' Make an array of Car objects.
		Dim myAutos(4) As Car
		myAutos(0) = New Car("Rusty", 80, 1)
		myAutos(1) = New Car("Mary", 40, 234)
		myAutos(2) = New Car("Viper", 40, 34)
		myAutos(3) = New Car("Mel", 40, 4)
		myAutos(4) = New Car("Chucky", 40, 5)

		' print the name and id of each car.
		For Each c As Car In myAutos
			Console.WriteLine($"Car {c.CarID,3} is named {c.PetName}")
		Next

		' Sort my cars!
		Array.Sort(myAutos)

		Console.WriteLine()
		Console.WriteLine("-> After Sorting:")
		For Each c As Car In myAutos
			Console.WriteLine($"Car {c.CarID,3} is named {c.PetName}")
		Next

		' Now sort by Pet Name.
		Array.Sort(myAutos, New Car.PetNameComparer())

		Console.WriteLine()
		Console.WriteLine("-> Ordering by pet name:")
		For Each c As Car In myAutos
			Console.WriteLine($"Car {c.CarID,3} is named {c.PetName}")
		Next


		Console.WriteLine()
	End Sub
End Module
