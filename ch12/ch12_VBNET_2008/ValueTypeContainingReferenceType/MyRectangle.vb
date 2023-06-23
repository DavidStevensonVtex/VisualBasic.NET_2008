Public Structure MyRectangle
	' The MyRectangle structure contains a reference type member.
	Public Property RectInfo As ShapeInfo

	Public Property Top As Integer
	Public Property Left As Integer
	Public Property Bottom As Integer
	Public Property Right As Integer

	Public Sub New(ByVal info As String)
		RectInfo = New ShapeInfo(info)
		Top = 10 : Left = 10 : Bottom = 10 : Right = 100
	End Sub
End Structure