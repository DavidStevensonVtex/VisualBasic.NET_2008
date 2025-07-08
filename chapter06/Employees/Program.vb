Module Program
    Sub Main()
        Console.WriteLine("***** The Employee Class Hierarhchy")
        Console.WriteLine()
        ' Give each employee a bonus
        Dim chucky As New Manager("Chucky", 45, 101, 100000, "222-22-2222", 90)
        chucky.GiveBonus(300)
        chucky.DisplayStats()
        Console.WriteLine()

        Dim fran As New SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31)
        fran.GiveBonus(200)
        fran.DisplayStats()
    End Sub

    Sub OldMain()
        ' Assume we now have the following constructor for the Manager.
        ' (name, age, ID, pay, SSN, number of stock options).
        Dim chucky As New Manager("Chucky", 45, 101, 30000, "222-22-2222", 90)
        Dim cost As Double = chucky.GetBenefitCost()
        Console.WriteLine($"Chucky's benefit cost: {cost:C}")

    End Sub

End Module
