﻿Public Class Car
    Implements IDisposable

    Private currSpeed As Integer
    Private petName As String
    Private disposedValue As Boolean

    Public Sub New()
    End Sub
    Public Sub New(ByVal name As String, ByVal speed As Integer)
        petName = name
        currSpeed = speed
    End Sub

    Public Overrides Function ToString() As String
        Return $"{petName} is going {currSpeed} MPH"
    End Function

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects)
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            Console.WriteLine("Disposing Car instance")
            disposedValue = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
