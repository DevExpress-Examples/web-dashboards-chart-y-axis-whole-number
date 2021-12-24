Imports System
Imports System.Collections.Generic

Namespace ScaleIntegerSpacing
	Public Class ViewModel
		Public Property [Date]() As Date
		Public Property Value() As Double

		Public Shared Function CreateData() As List(Of ViewModel)
			Dim data As New List(Of ViewModel)()
			Dim rnd = New Random(100)
			For i As Integer = 0 To 11
				Dim record As New ViewModel()
				record.Date = Date.Now.AddDays(i)
				record.Value = rnd.Next(0, 5)
				data.Add(record)
			Next i
			Return data
		End Function
	End Class
End Namespace