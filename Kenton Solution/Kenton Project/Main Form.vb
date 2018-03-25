Public Class Form1
	Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
		Me.Close()
	End Sub

	Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
		' Store the total payroll for each individual store, we can then sum these together
		' to get the total payroll across all stores.
		Dim payroll1 As Double = 0.0
		Dim payroll2 As Double = 0.0
		Dim payroll3 As Double = 0.0

		' Show pop up input dialog box to get payroll amount
		' Do this five times for each of the 3 stores
		For storeNumber As Integer = 1 To 3
			For payrollNumber As Integer = 1 To 5
				Dim head As String = "Enter Payroll " & payrollNumber
				Dim tail As String = (" for Store #" & storeNumber) & ":"
				Dim prompt As String = head & tail

				' Get user input a s a string from the input box, then convert it to a double.
				Dim strValue As String = InputBox(prompt, "Kenton Project", "")
				Dim dblValue As Double = 0.0
				Double.TryParse(strValue, dblValue)

				' Figure out which store we need to add the payroll numbers to.
				If storeNumber = 1 Then
					payroll1 += dblValue
				ElseIf storeNumber = 2 Then
					payroll2 += dblValue
				Else
					payroll3 += dblValue
				End If
			Next
		Next

		' Now we have all the info we need, go ahead and update our labels.
		store1Amount.Text = payroll1.ToString
		store2Amount.Text = payroll2.ToString
		store3Amount.Text = payroll3.ToString
		totalAmount.Text = (payroll1 + payroll2 + payroll3).ToString
	End Sub
End Class
