Public Class PitchFork
    Implements IPointy

    Public ReadOnly Property Points As Byte Implements IPointy.Points
        Get
            Return 3
        End Get
    End Property
End Class
