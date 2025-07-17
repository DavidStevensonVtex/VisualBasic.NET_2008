' Car event sink.
Public Class CarEventSink
    Implements IEngineEvents

    Private name As String

    Public Sub New(ByVal sinkName As String)
        name = sinkName
    End Sub

    Public Sub AboutToBlow(msg As String) Implements IEngineEvents.AboutToBlow
        Console.WriteLine($"{name} reporting: {msg}")
    End Sub

    Public Sub Exploded(msg As String) Implements IEngineEvents.Exploded
        Console.WriteLine($"{name} reporting: {msg}")
    End Sub
End Class
