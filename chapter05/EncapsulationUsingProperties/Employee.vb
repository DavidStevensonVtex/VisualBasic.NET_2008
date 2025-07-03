Public Class Employee
    ' Using Automatic Properties
    Public Property Name As String
    Public Property ID As Integer
    Public Property Pay As Single

    ' Constructors
    Public Sub New()
    End Sub
    Public Sub New(ByVal name As String, ByVal id As Integer, ByVal pay As Single)
        Me.Name = name
        Me.ID = id
        Me.Pay = pay
    End Sub

    ' Methods.
    Public Sub GiveBonus(ByVal amount As Single)
        Pay += amount
    End Sub
    Public Sub DisplayStats()
        Console.WriteLine($"Name: {Name}")
        Console.WriteLine($"ID:   {ID}")
        Console.WriteLine($"Pay:  {Pay}")
    End Sub

End Class
