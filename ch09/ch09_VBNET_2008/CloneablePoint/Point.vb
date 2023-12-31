﻿' A class named Point.
Public Class Point
	Implements ICloneable
	' Public for easy access, freel free to add properties
	' to wrap private data if you choose.
	Public Property X As Integer
	Public Property Y As Integer

	Public Property Description As New PointDescription

	Public Sub New()
	End Sub
	Public Sub New(ByVal xpos As Integer, ByVal ypos As Integer, ByVal name As String)
		X = xpos
		Y = ypos
		Description.PetName = name
	End Sub

	Public Overrides Function ToString() As String
		Return $"X = {X}, Y = {Y}, Name = {Description.PetName}, ID = {Description.PointID}"
	End Function

	Public Function Clone() As Object Implements ICloneable.Clone
		'Return New Point(X, Y)
		' The following returns a shallow copy, not a deep copy.
		'Return Me.MemberwiseClone()
		Dim newPoint As Point = CType(Me.MemberwiseClone(), Point)

		Dim currentDesc = New PointDescription()
		currentDesc.PetName = New String(Me.Description.PetName)
		currentDesc.PointID = Me.Description.PointID

		newPoint.Description = currentDesc
		Return newPoint
	End Function
End Class
