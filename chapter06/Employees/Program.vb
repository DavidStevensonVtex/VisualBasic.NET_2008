Module Program

    Sub Main()
        ' Assume we now have the following constructor for the Manager.
        ' (name, age, ID, pay, SSN, number of stock options).
        Dim chucky As New Manager("Chucky", 45, 101, 30000, "222-22-2222", 90)
        Dim cost As Double = chucky.GetBenefitCost()
        Console.WriteLine($"Chucky's benefit cost: {cost:C}")

    End Sub

End Module
