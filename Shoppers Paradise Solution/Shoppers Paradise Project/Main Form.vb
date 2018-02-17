Public Class Form1
	Dim monthlyPurchasesVal As Double = 0.0
	Dim rewardPointsVal As Double = 0.0

	Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
		Me.Close()
	End Sub

	Private Sub purchaseInput_TextChanged(sender As Object, e As EventArgs) Handles purchaseInput.TextChanged
		Double.TryParse(purchaseInput.Text, monthlyPurchasesVal)
	End Sub

	Private Sub calcRewardsValue()
		If radioBasic.Checked Then
			' User is a basic rewards member.
			If monthlyPurchasesVal < 100 Then
				rewardPointsVal = monthlyPurchasesVal * 0.03
			ElseIf monthlyPurchasesVal <= 199.99 Then
				rewardPointsVal = monthlyPurchasesVal * 0.05
			Else
				rewardPointsVal = monthlyPurchasesVal * 0.08
			End If

		ElseIf radioStandard.Checked Then
			' User is a standard rewards member.
			If monthlyPurchasesVal < 299 Then
				rewardPointsVal = monthlyPurchasesVal * 0.08
			Else
				rewardPointsVal = monthlyPurchasesVal * 0.1
			End If

		ElseIf radioPremium.Checked Then
			' User is a premium rewards member.
			If monthlyPurchasesVal < 399 Then
				rewardPointsVal = monthlyPurchasesVal * 0.1
			Else
				rewardPointsVal = monthlyPurchasesVal * 0.15
			End If

		End If
	End Sub

	Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
		calcRewardsValue()
		rewardPointsText.Text = rewardPointsVal.ToString
	End Sub
End Class
