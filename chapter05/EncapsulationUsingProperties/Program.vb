Module Program

    Sub Main()
        Dim emp As New Employee("Marvin", 456, 30000)

        emp.GiveBonus(1000)
        emp.DisplayStats()

        ' Use the get/set methods to interact with the object's name.
        emp.Name = "Marv"
        Console.WriteLine($"Employee is named: {emp.Name}")
    End Sub

End Module
