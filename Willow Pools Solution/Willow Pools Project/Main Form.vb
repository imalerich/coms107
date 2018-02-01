Public Class Form1
    ' Store integer versions of the users input sizes.
    Dim givenLength As Integer = 0
    Dim givenWidth As Integer = 0
    Dim givenHeight As Integer = 0
    ' Store the computed result of the above three sizes when 
    ' the user clicks on the calculate button.
    Dim calculatedVolume As Integer = 0

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LengthText_TextChanged(sender As Object, e As EventArgs) Handles LengthText.TextChanged
        Integer.TryParse(LengthText.Text, givenLength)
    End Sub

    Private Sub WidthText_TextChanged(sender As Object, e As EventArgs) Handles WidthText.TextChanged
        Integer.TryParse(WidthText.Text, givenWidth)
    End Sub

    Private Sub HeightText_TextChanged(sender As Object, e As EventArgs) Handles HeightText.TextChanged
        Integer.TryParse(HeightText.Text, givenHeight)
    End Sub

    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        ' Calculate the volume by multiplying the width, height, and length.
        calculatedVolume = givenHeight * givenWidth * givenLength
        ' Then update the calculate volume label with the string version of the calculated Integer.
        CalcVolumeLabel.Text = calculatedVolume.ToString
    End Sub
End Class
