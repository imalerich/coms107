' Project name:         JM Sales Project
' Project purpose:      Display a report that shows each salesperson's ID
'                       and total sales, as well as the total company sales 
' Your Name :




Public Class MainForm

    '1.	Declare five- element one dimensional Integer array named sales within the following space (Use Private as the access modifier).






    '-------------------------------------------------------------------------------------------------------------------------------------------------

    ' Sub procedure to define exitButton click event.

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub







    '-------------------------------------------------------------------------------------------------------------------------------------------------

    ' Sub procedure to fills the list boxes with values, then selects the first item.

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '2.	Write code to fill the idListBox list with values 101,112,203,301,302 within the following space.







        idListBox.SelectedIndex = 0
    End Sub







    '-------------------------------------------------------------------------------------------------------------------------------------------------

    ' Sub procedure to define addButton click event (accumulates the sales amounts).

    Private Sub addButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles addButton.Click


        'declare variables.
        Dim salesperson As Integer
        Dim salesAmt As Integer

        reportTextBox.Text = String.Empty


        '3.	Write code to get the value at salesAmtTextBox to the variable salesAmt within the following space.






        '4.	Write code to get the index of selected value at idListBox to the variable salesperson within the following space. 






        '5.	Write code to add the new sales amount (value of variable salesAmt) to the relevent person's total sales amount in sales array.
        '   Use the index found in part 4 to access the corresponding element to that particular person in array sales.
        '   Use the following space to write your code.






        salesAmtTextBox.Focus()
        salesAmtTextBox.Text = String.Empty
    End Sub






    '-------------------------------------------------------------------------------------------------------------------------------------------------

    ' Sub procedure to select existing text of the salesAmtTextBox.

    Private Sub salesAmtTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles salesAmtTextBox.Enter
        salesAmtTextBox.SelectAll()
    End Sub






    '-------------------------------------------------------------------------------------------------------------------------------------------------

    ' Sub procedure to allows only numbers, the period, and the Backspace key for the salesAmtTextBox.

    Private Sub salesAmtTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles salesAmtTextBox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub







    '-------------------------------------------------------------------------------------------------------------------------------------------------

    ' Sub procedure clear report.

    Private Sub salesAmtTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles salesAmtTextBox.TextChanged
        reportTextBox.Text = String.Empty
    End Sub






    '-------------------------------------------------------------------------------------------------------------------------------------------------

    ' Sub procedure to define createButton click event ( displays a report containing each salesperson's ID and total sales, as well as the total company sales).

    Private Sub createButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles createButton.Click
       
        'declare variable to store total company sales.
        Dim companySales As Integer
  
        reportTextBox.Text = String.Empty


        '6. Each salesperson's ID and total sales is display using the following loop. Fill the blanks according to the given instructions.

        'a. The loop should terminate when the salesperson variable value is reach to the upper bound of the array sales. Fill the termination condition in following line (_ _ _ _).
        For salesperson As Integer = 0 To _ _ _ _


            'b. Write code to add the salesperson's total sales to the total company sales within the following space.





            'Display the salesperson's ID and total sales in reportTextBox. 
            reportTextBox.Text = reportTextBox.Text & "   " &
                idListBox.Items(salesperson).ToString & "  " &
                sales(salesperson).ToString("N0") & ControlChars.NewLine
        Next salesperson


        '7. Write code to display the total company sales in reportTextBox. 






    End Sub
End Class
