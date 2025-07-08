' Remember! Person extends Object!
Public Class Person
    ' Public only for simplicity. Properties and Private data would obviously be preferred.
    Public fName As String
    Public lName As String
    Public personAge As Byte

    Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal age As Byte)
        fName = firstName
        lName = lastName
        personAge = age
    End Sub
    Public Sub New()
    End Sub

    Public Overrides Function ToString() As String
        Dim myState As String
        myState = String.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", fName, lName, personAge)
        Return myState
    End Function

    'Public Overrides Function Equals(obj As Object) As Boolean
    '    If TypeOf obj Is Person AndAlso IsNot Nothing Then
    '        Dim temp As Person = CType(obj, Person)
    '        If temp.fName = Me.fName AndAlso
    '                temp.lName = Me.fName AndAlso
    '                temp.personAge = Me.personAge Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    End If
    '    Return False
    'End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return obj.ToString() = Me.ToString()
    End Function

    ' Return a hash code based on the person's ToString() value.
    Public Overrides Function GetHashCode() As Integer
        Return Me.ToString().GetHashCode()
    End Function


End Class
