Public Class Form1
	Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
		Dim text1 As String
		Dim Text2 As Integer
		Dim text3 As String

		text1 = "Visual"
		Text2 = 22
		text3 = text1 & Text2
		MsgBox(text3)
	End Sub
End Class
