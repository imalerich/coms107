Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub BananaButton_Click(sender As Object, e As EventArgs) Handles BananaButton.Click
        PriceLabel.Text = "3.79"
    End Sub

    Private Sub SundaeButton_Click(sender As Object, e As EventArgs) Handles SundaeButton.Click
        PriceLabel.Text = "0.99"
    End Sub

    Private Sub MilkshakeButton_Click(sender As Object, e As EventArgs) Handles MilkshakeButton.Click
        PriceLabel.Text = "2.25"
    End Sub
End Class
