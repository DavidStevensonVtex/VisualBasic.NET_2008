Module Module1

    Sub Main()
        Console.WriteLine("***** Fun with Arrays *****")
        ArrayOfObjects()
    End Sub

    Sub SimpleArrays()
        ' Create and fill an array of three Integers
        Dim myInts(2) As Integer
        myInts(0) = 100
        myInts(1) = 200
        myInts(2) = 300

        ' Now print each value
        For Each i As Integer In myInts
            Console.WriteLine(i)
        Next

        ' String array with assigned data.
        Dim myStrs(2) As String
        myStrs(0) = "Cerebus"
        myStrs(1) = "Jake"
        myStrs(2) = "Astoria"
        For Each s As String In myStrs
            Console.WriteLine(s)
        Next
    End Sub

    Sub SimpleArrays2()
        Console.WriteLine("=> Simple Array Creation.")
        ' An array of 11 Strings
        Dim myStrings(10) As String

        ' An array of 3 integers    .
        Dim myInts(2) As Integer

        ' An array of 5 objects
        Dim myObjs(4) As Object
    End Sub

    Sub SimpleArrays3()
        ' An array of 3 Integers
        Dim myInts() As Integer = {100, 200, 300}
        For Each i As Integer In myInts
            Console.WriteLine(i)
        Next
    End Sub

    Sub ArrayOfObjects()
        Console.WriteLine("=> Array of Objects.")
        ' An array of Objects can be anything at all.
        Dim myObjects(3) As Object
        myObjects(0) = 10
        myObjects(1) = False
        myObjects(2) = New DateTime(1969, 3, 24)
        myObjects(3) = "Form & Void"

        For Each obj As Object In myObjects
            ' Print the type and value for each item in array.
            Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj)
        Next
    End Sub

End Module
