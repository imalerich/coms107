Public Class Form1
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub colorBtn_Click(sender As Object, e As EventArgs) Handles colorBtn.Click
        calcLabel.BackColor = Color.Red
    End Sub

    Private Sub fontBtn_Click(sender As Object, e As EventArgs) Handles fontBtn.Click
        priceLabel.Font = New Font(calcLabel.Font, FontStyle.Bold)
    End Sub
End Class
