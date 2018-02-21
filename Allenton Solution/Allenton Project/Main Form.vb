Public Class Form1
    ' Store the integer versions of the users input.
    Dim currentReadingValue As Integer = 0
    Dim previousReadingValue As Integer = 0
    Dim gallonsUsedValue As Integer = 0
    Dim totalChargeValue As Double = 0.0

	Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
		Me.Close()
	End Sub

	Private Sub currentReading_TextChanged(sender As Object, e As EventArgs) Handles currentReading.TextChanged
        Dim valAsDouble As Double = 0 ' Allow the user to input double values...
        Double.TryParse(currentReading.Text, valAsDouble)
        currentReadingValue = Math.Round(valAsDouble) ' but round that value to the nearest integer.
    End Sub

    Private Sub previousReading_TextChanged(sender As Object, e As EventArgs) Handles previousReading.TextChanged
        Dim valAsDouble As Double = 0 ' Allow the user to input double values...
        Double.TryParse(previousReading.Text, valAsDouble)
        previousReadingValue = Math.Round(valAsDouble) ' but round that value to the nearest integer.
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        If currentReadingValue >= previousReadingValue Then
            ' Calcualte gallons used.
            gallonsUsedValue = currentReadingValue - previousReadingValue
            ' Calculate total charge.
            totalChargeValue = 0.00129 * gallonsUsedValue
            ' Display calculated gallons and total charge.
            gallonsUsed.Text = gallonsUsedValue.ToString
            totalCharge.Text = totalChargeValue.ToString
            ' Clear the error message if there was one.
            errorMessages.Text = ""
        Else
            ' Display Error Message.
            errorMessages.Text = "Current must be greater than or equal to previous."
            gallonsUsed.Text = "ERROR"
            totalCharge.Text = "ERROR"
        End If
    End Sub
End Class
