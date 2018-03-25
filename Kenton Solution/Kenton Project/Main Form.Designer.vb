<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.amountsGroupBox = New System.Windows.Forms.GroupBox()
		Me.infoStore1 = New System.Windows.Forms.Label()
		Me.infoStore2 = New System.Windows.Forms.Label()
		Me.infoCompany = New System.Windows.Forms.Label()
		Me.infoStore3 = New System.Windows.Forms.Label()
		Me.store1Amount = New System.Windows.Forms.Label()
		Me.store2Amount = New System.Windows.Forms.Label()
		Me.store3Amount = New System.Windows.Forms.Label()
		Me.totalAmount = New System.Windows.Forms.Label()
		Me.calculateButton = New System.Windows.Forms.Button()
		Me.exitButton = New System.Windows.Forms.Button()
		Me.amountsGroupBox.SuspendLayout()
		Me.SuspendLayout()
		'
		'amountsGroupBox
		'
		Me.amountsGroupBox.Controls.Add(Me.totalAmount)
		Me.amountsGroupBox.Controls.Add(Me.store3Amount)
		Me.amountsGroupBox.Controls.Add(Me.store2Amount)
		Me.amountsGroupBox.Controls.Add(Me.store1Amount)
		Me.amountsGroupBox.Controls.Add(Me.infoStore3)
		Me.amountsGroupBox.Controls.Add(Me.infoCompany)
		Me.amountsGroupBox.Controls.Add(Me.infoStore2)
		Me.amountsGroupBox.Controls.Add(Me.infoStore1)
		Me.amountsGroupBox.Location = New System.Drawing.Point(12, 12)
		Me.amountsGroupBox.Name = "amountsGroupBox"
		Me.amountsGroupBox.Size = New System.Drawing.Size(178, 154)
		Me.amountsGroupBox.TabIndex = 0
		Me.amountsGroupBox.TabStop = False
		Me.amountsGroupBox.Text = "Payroll amounts"
		'
		'infoStore1
		'
		Me.infoStore1.AutoSize = True
		Me.infoStore1.Location = New System.Drawing.Point(6, 21)
		Me.infoStore1.Name = "infoStore1"
		Me.infoStore1.Size = New System.Drawing.Size(44, 13)
		Me.infoStore1.TabIndex = 0
		Me.infoStore1.Text = "Store 1:"
		Me.infoStore1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'infoStore2
		'
		Me.infoStore2.AutoSize = True
		Me.infoStore2.Location = New System.Drawing.Point(6, 54)
		Me.infoStore2.Name = "infoStore2"
		Me.infoStore2.Size = New System.Drawing.Size(44, 13)
		Me.infoStore2.TabIndex = 1
		Me.infoStore2.Text = "Store 2:"
		Me.infoStore2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'infoCompany
		'
		Me.infoCompany.AutoSize = True
		Me.infoCompany.Location = New System.Drawing.Point(6, 124)
		Me.infoCompany.Name = "infoCompany"
		Me.infoCompany.Size = New System.Drawing.Size(54, 13)
		Me.infoCompany.TabIndex = 2
		Me.infoCompany.Text = "Company:"
		Me.infoCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'infoStore3
		'
		Me.infoStore3.AutoSize = True
		Me.infoStore3.Location = New System.Drawing.Point(6, 90)
		Me.infoStore3.Name = "infoStore3"
		Me.infoStore3.Size = New System.Drawing.Size(44, 13)
		Me.infoStore3.TabIndex = 3
		Me.infoStore3.Text = "Store 3:"
		Me.infoStore3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'store1Amount
		'
		Me.store1Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.store1Amount.Location = New System.Drawing.Point(66, 16)
		Me.store1Amount.Name = "store1Amount"
		Me.store1Amount.Size = New System.Drawing.Size(100, 23)
		Me.store1Amount.TabIndex = 4
		Me.store1Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'store2Amount
		'
		Me.store2Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.store2Amount.Location = New System.Drawing.Point(66, 49)
		Me.store2Amount.Name = "store2Amount"
		Me.store2Amount.Size = New System.Drawing.Size(100, 23)
		Me.store2Amount.TabIndex = 5
		Me.store2Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'store3Amount
		'
		Me.store3Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.store3Amount.Location = New System.Drawing.Point(66, 85)
		Me.store3Amount.Name = "store3Amount"
		Me.store3Amount.Size = New System.Drawing.Size(100, 23)
		Me.store3Amount.TabIndex = 6
		Me.store3Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'totalAmount
		'
		Me.totalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.totalAmount.Location = New System.Drawing.Point(66, 119)
		Me.totalAmount.Name = "totalAmount"
		Me.totalAmount.Size = New System.Drawing.Size(100, 23)
		Me.totalAmount.TabIndex = 7
		Me.totalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'calculateButton
		'
		Me.calculateButton.Location = New System.Drawing.Point(196, 92)
		Me.calculateButton.Name = "calculateButton"
		Me.calculateButton.Size = New System.Drawing.Size(111, 33)
		Me.calculateButton.TabIndex = 1
		Me.calculateButton.Text = "Calculate"
		Me.calculateButton.UseVisualStyleBackColor = True
		'
		'exitButton
		'
		Me.exitButton.Location = New System.Drawing.Point(196, 131)
		Me.exitButton.Name = "exitButton"
		Me.exitButton.Size = New System.Drawing.Size(111, 33)
		Me.exitButton.TabIndex = 2
		Me.exitButton.Text = "Exit"
		Me.exitButton.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(319, 174)
		Me.Controls.Add(Me.exitButton)
		Me.Controls.Add(Me.calculateButton)
		Me.Controls.Add(Me.amountsGroupBox)
		Me.Name = "Form1"
		Me.Text = "Kenton Incorporated"
		Me.amountsGroupBox.ResumeLayout(False)
		Me.amountsGroupBox.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents amountsGroupBox As GroupBox
	Friend WithEvents totalAmount As Label
	Friend WithEvents store3Amount As Label
	Friend WithEvents store2Amount As Label
	Friend WithEvents store1Amount As Label
	Friend WithEvents infoStore3 As Label
	Friend WithEvents infoCompany As Label
	Friend WithEvents infoStore2 As Label
	Friend WithEvents infoStore1 As Label
	Friend WithEvents calculateButton As Button
	Friend WithEvents exitButton As Button
End Class
