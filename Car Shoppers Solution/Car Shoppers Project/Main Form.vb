' Project name:         Car Shoppers Project
' Project purpose:      Displays the monthly payments on a loan
' Your Name :			Ian Malerich (imm@iastate.edu)

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

	'Function to calculates a monthly payment on a loan
	'1. Complete the CalcPayment function header
	Private Function CalcPayment(ByVal rate As Double, ByVal years As Double, ByVal principal As Double) As Double
		Dim payment As Double
		'Calculate the payment using Financial.Pmt function.
		payment = -Financial.Pmt(rate / 12, years * 12, principal)
		Return payment
	End Function

	' Sub procedure to fills the list boxes with values, then selects the first item
	Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		For rate As Double = 0.02 To 0.15 Step 0.01
			dealerRateListBox.Items.Add(rate.ToString)
			bankRateListBox.Items.Add(rate.ToString)
		Next rate

		'2.	Write code to fill the termListBox with values from 2 to 5 (Integer type) within the following space
		For year As Integer = 2 To 5
			termListBox.Items.Add(year.ToString)
		Next

		dealerRateListBox.SelectedIndex = 0
		bankRateListBox.SelectedIndex = 0
		termListBox.SelectedIndex = 0
	End Sub

	' Sub procedure to clear the content of the labels
	Private Sub ClearPayments(ByVal sender As Object, ByVal e As System.EventArgs
        ) Handles priceTextBox.TextChanged, rebateTextBox.TextChanged,
        dealerRateListBox.SelectedValueChanged, bankRateListBox.SelectedValueChanged,
        termListBox.SelectedValueChanged

		'3.	Write code to clear the content of dealerPayLabel and bankPayLabel within the following space
		dealerPayLabel.Text = ""
		bankPayLabel.Text = ""

	End Sub

	' Sub procedure to define calcButton click event
	Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click

		'declare variables
		Dim price As Double
        Dim rebate As Double
        Dim dealerRate As Double
        Dim bankRate As Double
        Dim term As Double
        Dim dealerPayment As Double
		Dim bankPayment As Double

		'4.	Write code to get the values at priceTextBox, rebateTextBox to the variables price, rebate respectively within the following space
		Double.TryParse(priceTextBox.Text, price)
		Double.TryParse(rebateTextBox.Text, rebate)

		'5.	Write code to get the selected values at dealerRateListBox, bankRateListBox and termListBox to the variables dealerRate, bankRate and term respectively within the following space
		Double.TryParse(CType(dealerRateListBox.SelectedItem, String), dealerRate)
		Double.TryParse(CType(bankRateListBox.SelectedItem, String), bankRate)
		Double.TryParse(CType(termListBox.SelectedItem, String), term)

		'6.	Invoke the function CalcPayment to get the value to the variable dealerPayment by passing the values dealerRate, term and price within the following space
		dealerPayment = CalcPayment(dealerRate, term, price)

		'7.	Invoke the function CalcPayment to get the value to the variable bankPayment by passing the values bankRate, term and (price – rebate) within the following space
		bankPayment = CalcPayment(bankRate, term, (price - rebate))

		dealerPayLabel.Text = dealerPayment.ToString("C2")
        bankPayLabel.Text = bankPayment.ToString("C2")

    End Sub

	' Sub procedure to define exitButton click event
	Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'ends the application
        Me.Close()
    End Sub

	' Sub procedure to select all the content of the priceTextBox
	Private Sub priceTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles priceTextBox.Enter
		priceTextBox.SelectAll()
	End Sub

	' Sub procedure to select all the content of the rebateTextBox
	Private Sub rebateTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles rebateTextBox.Enter
        rebateTextBox.SelectAll()
    End Sub

End Class
