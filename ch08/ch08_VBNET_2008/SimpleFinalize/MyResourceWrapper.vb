﻿Public Class MyResourceWrapper
	Protected Overrides Sub Finalize()
		Try
			' Clean up any unmanaged resources here!

			' Beep when destroyed (testing purposes only).
			Console.Beep()
		Catch ex As Exception
		Finally
			MyBase.Finalize()
		End Try
	End Sub
End Class
