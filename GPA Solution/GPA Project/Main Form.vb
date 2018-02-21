Public Class Form1
	' What is the current gender the user has selected in the list box?
	Dim currentGender As String = ""
	' What is the current GPA the user has selected in the list box?
	Dim currentGPA As Decimal = -1.0

	' How many total students have been entered?
	Dim studentCount As Integer = 0
	' How many male students have been entered?
	Dim maleCount As Integer = 0
	' How many female students have been entered?
	Dim femaleCount As Integer = 0

	' What is the total GPA of all students entered?
	Dim totalStudentGPA As Decimal = 0.0
	' What is the total GPA of all male students entered?
	Dim totalMaleGPA As Decimal = 0.0
	' What is the total GPA of all female students entered?
	Dim totalFemaleGPA As Decimal = 0.0

	' What is the average GPA of all students entered?
	Dim avgStudentGPA As Decimal = 0.0
	' What is the average GPA of all male students entered?
	Dim avgMaleGPA As Decimal = 0.0
	' What is the average GPA of all female students entered?
	Dim avgFemaleGPA As Decimal = 0.0

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Generate the list of GPA's cause typing this in would be bad.
		For GPA As Double = 0 To 4.1 Step 0.1 ' 4.1 because exclusive
			gpaListBox.Items.Add(GPA.ToString("0.0"))
		Next
	End Sub

	Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
		Me.Close()
	End Sub

	Private Sub genderListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles genderListBox.SelectedIndexChanged
		currentGender = genderListBox.SelectedItem
	End Sub

	Private Sub gpaListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gpaListBox.SelectedIndexChanged
		Decimal.TryParse(gpaListBox.SelectedItem, currentGPA)
	End Sub

	Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
		' The user hasn't entered any data yet.
		If currentGender = "" Or currentGPA < 0.0 Then
			MessageBox.Show(Me, "Please select Gender and GPA data.", "Error")
			Return
		End If

		' Entered new information, update totals
		studentCount += 1
		totalStudentGPA += currentGPA
		avgStudentGPA = totalStudentGPA / studentCount

		' Depending on whether this is a male or female
		' update data for that gender.
		If currentGender = "M" Then
			maleCount += 1
			totalMaleGPA += currentGPA
			avgMaleGPA = totalMaleGPA / maleCount
		Else
			femaleCount += 1
			totalFemaleGPA += currentGPA
			avgFemaleGPA = totalFemaleGPA / femaleCount
		End If

		' Now that we have all data calculated, we can update our labels.
		allStudentsLabel.Text = avgStudentGPA.ToString("0.0")
		' Keep male/female averages empty until we have actual data to show.
		If maleCount > 0 Then
			maleStudentsLabel.Text = avgMaleGPA.ToString("0.0")
		End If
		If femaleCount > 0 Then
			femaleStudentsLabel.Text = avgFemaleGPA.ToString("0.0")
		End If
	End Sub
End Class
