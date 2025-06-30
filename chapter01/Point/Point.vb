Public Structure Point
    Public xPos As Integer
    Public yPos As Integer

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        xPos = x
        yPos = y
    End Sub

    Public Sub Display()
        Console.WriteLine("({0}, {1])", xPos, yPos)
    End Sub

End Structure
