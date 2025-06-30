Namespace CalculatorExample
    Module Program

        Public Sub Main()
            Dim ans As Integer
            Dim c As New Calc()
            ans = c.Add(10, 84)

            Console.WriteLine("10 + 84 is {0}.", ans)
            Console.ReadLine()

        End Sub

    End Module
End Namespace

