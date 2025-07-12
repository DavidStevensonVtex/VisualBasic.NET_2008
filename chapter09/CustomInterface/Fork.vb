Public Class Fork
    Implements IPointy

    Public ReadOnly Property Points As Byte Implements IPointy.Points
        Get
            Return 4
        End Get
    End Property
End Class
