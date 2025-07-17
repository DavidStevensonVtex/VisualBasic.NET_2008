' Make a car and listen to the events.
Module Program
    Sub Main()
        Console.WriteLine("***** Interfaces as event enablers *****")
        Dim myCar As New Car("SlugBug", 10)

        ' Make sink object
        Console.WriteLine("***** Creating Sinks! *****")
        Dim sink As New CarEventSink("First Sink")
        Dim otherSink As New CarEventSink("Second Sink")

        ' Path both sinks to car.
        myCar.Connect(sink)
        myCar.Connect(otherSink)

        ' Speed up (this will trigger the events).
        For i As Integer = 0 To 5
            myCar.Accelerate(20)
        Next

        ' Detach from the first sink.
        myCar.Disconnect(sink)

        ' Speed up again (only otherSink will be called).
        For i As Integer = 0 To 5
            myCar.Accelerate(20)
        Next

        ' Detach from other sinl.
        myCar.Disconnect(otherSink)
    End Sub

    Sub OldMain()
        Console.WriteLine("***** Interfaces as event enablers *****")
        Dim myCar As New Car("SlugBug", 10)

        ' Make sink object
        Dim sink As New CarEventSink("MySink")

        ' Register the sink with the Car.
        myCar.Connect(sink)

        ' Speed up (this will trigger the event notifications).
        For i As Integer = 0 To 5
            myCar.Accelerate(20)
        Next

        ' Detach from event source.
        myCar.Disconnect(sink)

    End Sub

End Module
