Module Program

    Sub Main()
        Console.WriteLine("***** Fun with IComparable *****")
        ' Make an array of Car objects
        Dim myAutos(4) As Car
        myAutos(0) = New Car("Rusty", 80, 1)
        myAutos(1) = New Car("Mary", 40, 234)
        myAutos(2) = New Car("Viper", 40, 34)
        myAutos(3) = New Car("Mel", 40, 4)
        myAutos(4) = New Car("Chucky", 40, 5)

        ' Print the name and ID of each car.
        For Each c As Car In myAutos
            Console.WriteLine($"Car {c.ID} is named {c.Name}.")
        Next
        Console.WriteLine()

        ' Sort my cars?
        Array.Sort(myAutos)


        ' Print the name and ID of each car.
        Console.WriteLine("-> After sorting")
        For Each c As Car In myAutos
            Console.WriteLine($"Car {c.ID} is named {c.Name}.")
        Next
        Console.WriteLine()

        Array.Sort(myAutos, Car.SortByPetName())
        ' Print the name and ID of each car.
        Console.WriteLine("-> Ordering by pet name")
        For Each c As Car In myAutos
            Console.WriteLine($"Car {c.ID} is named {c.Name}.")
        Next


    End Sub

End Module
