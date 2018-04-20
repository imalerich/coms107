' Project name:         WKRK Project
' Project purpose:      Keeps track of the number of votesfor each Super Bowl commercial. The voting information is saved in a sequential access file.
'  Your Name :

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
	' Sub procedure to define MainForm load event (Fill the commericalListBox with values Budweiser,FedEx,E*Trade,Pepsi and then selects the first value)
	Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		commercialListBox.Items.Add("Budweiser")
		commercialListBox.Items.Add("FedEx")
		commercialListBox.Items.Add("E*Trade")
		commercialListBox.Items.Add("Pepsi")

		commercialListBox.SelectedIndex = 0
	End Sub

	' Sub procedure to define exitButton click event.
	Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
		Me.Close()
	End Sub

	' Sub procedure to define saveButton click event (Saves each vote in a sequential access file).
	Private Sub saveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles saveButton.Click

		'1.	Write code to declare a StreamWriter variable called outFile within the following space.
		Dim outFile As System.IO.StreamWriter

		'2.	Write code to open the votes.txt file for append; create StreamWriter object and assign it to the outFile variable within the following space.
		outFile = My.Computer.FileSystem.OpenTextFileWriter("votes.txt", True)

		'3.	Write code to write the selected index of commercialListBox as a new line to the file "votes.txt" within the following space.
		outFile.WriteLine(commercialListBox.SelectedIndex.ToString)

		'4.	Write code to close the file associates with  outFile variable within the following space.
		outFile.Close()

		' Clear the label controls that display the votes for each commericial
		budweiserLabel.Text = String.Empty
		fedexLabel.Text = String.Empty
		eTradeLabel.Text = String.Empty
		pepsiLabel.Text = String.Empty

	End Sub

	' Sub procedure to define displayButton click event (Reads the contents of a sequential access file, then totals and displays the number of votes per commercial).
	Private Sub displayButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles displayButton.Click

		'5.	Write code to declare a StreamReader variable called inFile within the following space.
		Dim inFile As System.IO.StreamReader

		' Declare variables
		Dim vote As Integer
		Dim budweiserTotal As Integer
		Dim fedexTotal As Integer
		Dim mastercardTotal As Integer
		Dim pepsiTotal As Integer

		'Check whether "votes.txt" is exist.
		If IO.File.Exists("votes.txt") Then

			'6. Write code to open the votes.txt file for input; create a StreamReader object and assign it to the inFile variable within the following space.
			inFile = My.Computer.FileSystem.OpenTextFileReader("votes.txt")

			'Calculate the total for each type

			'7.	Fill the blank so that the following loop statement exits when there is no more characters to be read in votes.txt file. Use Peek method.
			Do Until inFile.Peek() < 0
				'8.	Fill the blank so that the following statement read a line of text from the votes.txt file and convert it to an integer value and save in the variable vote.
				vote = Convert.ToInt32(inFile.ReadLine())

				' Update the appropriate counter
				Select Case vote
					Case 0
						budweiserTotal = budweiserTotal + 1
					Case 1
						fedexTotal = fedexTotal + 1
					Case 2
						mastercardTotal = mastercardTotal + 1
					Case 3
						pepsiTotal = pepsiTotal + 1
				End Select

			Loop

			inFile.Close()

			' Display the counter values in the interface
			budweiserLabel.Text = Convert.ToString(budweiserTotal)
			fedexLabel.Text = Convert.ToString(fedexTotal)
			eTradeLabel.Text = Convert.ToString(mastercardTotal)
			pepsiLabel.Text = Convert.ToString(pepsiTotal)

		Else
			MessageBox.Show("The votes.txt file does not exist.",
				"WKRK-Radio", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If

	End Sub

End Class

