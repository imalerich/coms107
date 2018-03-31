<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bankPayLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.termListBox = New System.Windows.Forms.ListBox()
        Me.bankRateListBox = New System.Windows.Forms.ListBox()
        Me.dealerRateListBox = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rebateTextBox = New System.Windows.Forms.TextBox()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.dealerPayLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bankPayLabel
        '
        Me.bankPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bankPayLabel.Location = New System.Drawing.Point(306, 204)
        Me.bankPayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bankPayLabel.Name = "bankPayLabel"
        Me.bankPayLabel.Size = New System.Drawing.Size(150, 25)
        Me.bankPayLabel.TabIndex = 6
        Me.bankPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(303, 183)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Bank monthly payment:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.termListBox)
        Me.GroupBox1.Controls.Add(Me.bankRateListBox)
        Me.GroupBox1.Controls.Add(Me.dealerRateListBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rebateTextBox)
        Me.GroupBox1.Controls.Add(Me.priceTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(550, 145)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'termListBox
        '
        Me.termListBox.FormattingEnabled = True
        Me.termListBox.ItemHeight = 17
        Me.termListBox.Location = New System.Drawing.Point(433, 50)
        Me.termListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.termListBox.Name = "termListBox"
        Me.termListBox.Size = New System.Drawing.Size(55, 72)
        Me.termListBox.TabIndex = 9
        '
        'bankRateListBox
        '
        Me.bankRateListBox.FormattingEnabled = True
        Me.bankRateListBox.ItemHeight = 17
        Me.bankRateListBox.Location = New System.Drawing.Point(347, 50)
        Me.bankRateListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.bankRateListBox.Name = "bankRateListBox"
        Me.bankRateListBox.Size = New System.Drawing.Size(70, 72)
        Me.bankRateListBox.TabIndex = 7
        '
        'dealerRateListBox
        '
        Me.dealerRateListBox.FormattingEnabled = True
        Me.dealerRateListBox.ItemHeight = 17
        Me.dealerRateListBox.Location = New System.Drawing.Point(257, 50)
        Me.dealerRateListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.dealerRateListBox.Name = "dealerRateListBox"
        Me.dealerRateListBox.Size = New System.Drawing.Size(70, 72)
        Me.dealerRateListBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(430, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Term (years):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 31)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Bank rate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Rebate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Dealer rate:"
        '
        'rebateTextBox
        '
        Me.rebateTextBox.Location = New System.Drawing.Point(134, 50)
        Me.rebateTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.rebateTextBox.Name = "rebateTextBox"
        Me.rebateTextBox.Size = New System.Drawing.Size(90, 25)
        Me.rebateTextBox.TabIndex = 3
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(11, 50)
        Me.priceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(90, 25)
        Me.priceTextBox.TabIndex = 1
        '
        'dealerPayLabel
        '
        Me.dealerPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dealerPayLabel.Location = New System.Drawing.Point(136, 204)
        Me.dealerPayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dealerPayLabel.Name = "dealerPayLabel"
        Me.dealerPayLabel.Size = New System.Drawing.Size(150, 25)
        Me.dealerPayLabel.TabIndex = 4
        Me.dealerPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(133, 183)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Dealer monthly payment:"
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(368, 252)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(88, 32)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(136, 252)
        Me.calcButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(186, 32)
        Me.calcButton.TabIndex = 1
        Me.calcButton.Text = "&Calculate Monthly Payments"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 307)
        Me.Controls.Add(Me.bankPayLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dealerPayLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Shoppers Inc."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bankPayLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rebateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dealerPayLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents termListBox As System.Windows.Forms.ListBox
    Friend WithEvents bankRateListBox As System.Windows.Forms.ListBox
    Friend WithEvents dealerRateListBox As System.Windows.Forms.ListBox

End Class
