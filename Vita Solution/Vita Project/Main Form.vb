' Project name:         Vita Project
' Project purpose:      Determine the fifth digit in a credit card number
' Your Name :

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

	' Sub procedure to define exitButton click event.
	Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
		Me.Close()
	End Sub

	' Sub procedure to select existing text of the firstFourTextBox.

	Private Sub firstFourTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles firstFourTextBox.Enter
		firstFourTextBox.SelectAll()
	End Sub

	' Sub procedure to allows only numbers and the Backspace key for the firstFourTextBox.
	Private Sub firstFourTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles firstFourTextBox.KeyPress
		If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
			e.Handled = True
		End If
	End Sub

	' Sub procedure clear the content of the firstFourTextBox.
	Private Sub firstFourTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles firstFourTextBox.TextChanged
		creditNumberLabel.Text = String.Empty
	End Sub

	' Sub procedure to define creditNumberButton click event (Determines the fifth digit in a credit card number).
	Private Sub creditNumberButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles creditNumberButton.Click
		' 1. Declare two String variables called creditNum, fifthDigit and an integer variable called sumOfDigits within the following space.
		Dim creditNum As String
		Dim fifthDigit As String
		Dim sumOfDigits As Integer

		' 2. Write code to get the value at firstFourTextBox to the variable creditNum within the following space.
		creditNum = firstFourTextBox.Text

		' 3. Fill the two blanks in following statement to check whether the creditNum is a four digit string. 
		If creditNum.Length = 4 Then

			' 4. Write code to get the summation of four digits in variable creditNum to the variable sumOfDigit within the following space.

			' Steps: 
			' Take each string digit using Substring function.
			Dim s0 As String = creditNum.Substring(0, 1)
			Dim s1 As String = creditNum.Substring(1, 1)
			Dim s2 As String = creditNum.Substring(2, 1)
			Dim s3 As String = creditNum.Substring(3, 1)

			' Use Convert.ToInt32 function to convert each string digit to an integer. Syntax of Convert.ToInt32 is as follows.
			' int a = Convert.ToInt32(string)
			Dim d0 As Integer = Convert.ToInt32(s0)
			Dim d1 As Integer = Convert.ToInt32(s1)
			Dim d2 As Integer = Convert.ToInt32(s2)
			Dim d3 As Integer = Convert.ToInt32(s3)

			' Get the summation according to the given scenario (First digit + 2*Second digit + Third digit + 2*Fourth digit)
			' NOTE! I am following the PDF here. The original comment above used 3 instead of 2.
			sumOfDigits = d0 + (2 * d1) + d2 + (2 * d3)

			' 5. Write code to find the fifth digit and store in the variable fifthDigit within the following space.
			fifthDigit = (sumOfDigits Mod 10).ToString

			' 6. Write code to append fifth digit to first four digits in the variable creditNum within the following space.
			creditNum = creditNum & fifthDigit

			' !!! Update the creditNumberLabel --- The original code didn't actually ask for this, but I assume it's what you want.
			creditNumberLabel.Text = creditNum

		Else ' processed when the user does not enter four digits
			MessageBox.Show("Please enter a four-digit number.", "Georgetown Credit", MessageBoxButtons.OK, MessageBoxIcon.Information)

		End If

		firstFourTextBox.Focus()
	End Sub

End Class
