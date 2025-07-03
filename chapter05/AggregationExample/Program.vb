Public Class Radio
    Public Sub PowerUp(ByVal turnOn As Boolean)
        Console.WriteLine($"Radio on: {turnOn}")
    End Sub
End Class

Public Class Car
    ' Car "has-a" Radio
    Private myRadio As New Radio()

    Public Sub TurnOnRadio(ByVal onOff As Boolean)
        ' Delegate call to inner object.
        myRadio.PowerUp(onOff)
    End Sub
End Class

Module Program

    Sub Main()
        ' Cal is forwarded to Radio internally
        Dim viper As New Car()
        viper.TurnOnRadio(False)
    End Sub

End Module
