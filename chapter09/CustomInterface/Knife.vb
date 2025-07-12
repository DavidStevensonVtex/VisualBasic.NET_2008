Public Class Knife
    Implements IPointy

    Public ReadOnly Property Points As Byte Implements IPointy.Points
        Get
            Return 0
        End Get
    End Property
End Class
