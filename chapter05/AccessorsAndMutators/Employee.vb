Public Class Employee
    ' Field data.
    Private empName As String
    Private empID As Integer
    Private currPay As Single

    ' Constructors
    Public Sub New()
    End Sub
    Public Sub New(ByVal name As String, ByVal id As Integer, ByVal pay As Single)
        empName = name
        empID = id
        currPay = pay
    End Sub

    ' Accessor (get method).
    Public Function GetName() As String
        Return empName
    End Function

    ' Mutator (set method)
    Public Sub SetName(ByVal name As String)
        ' Remove any illegal characters
        ' check maximum length or case before making assignment
        empName = name
    End Sub

    ' Methods.
    Public Sub GiveBonus(ByVal amount As Single)
        currPay += amount
    End Sub
    Public Sub DisplayStats()
        Console.WriteLine($"Name: {empName}")
        Console.WriteLine($"ID:   {empID}")
        Console.WriteLine($"Pay:  {currPay}")
    End Sub

End Class
