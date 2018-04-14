<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.firstFourTextBox = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.creditNumberLabel = New System.Windows.Forms.Label()
		Me.creditNumberButton = New System.Windows.Forms.Button()
		Me.exitButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 20)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(147, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "&Enter first four digits:"
		'
		'firstFourTextBox
		'
		Me.firstFourTextBox.Location = New System.Drawing.Point(165, 17)
		Me.firstFourTextBox.Name = "firstFourTextBox"
		Me.firstFourTextBox.Size = New System.Drawing.Size(101, 27)
		Me.firstFourTextBox.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 63)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(140, 20)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Credit card number:"
		'
		'creditNumberLabel
		'
		Me.creditNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.creditNumberLabel.Location = New System.Drawing.Point(158, 63)
		Me.creditNumberLabel.Name = "creditNumberLabel"
		Me.creditNumberLabel.Size = New System.Drawing.Size(108, 27)
		Me.creditNumberLabel.TabIndex = 5
		Me.creditNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'creditNumberButton
		'
		Me.creditNumberButton.Location = New System.Drawing.Point(16, 110)
		Me.creditNumberButton.Name = "creditNumberButton"
		Me.creditNumberButton.Size = New System.Drawing.Size(169, 29)
		Me.creditNumberButton.TabIndex = 2
		Me.creditNumberButton.Text = "&Credit Card Number"
		Me.creditNumberButton.UseVisualStyleBackColor = True
		'
		'exitButton
		'
		Me.exitButton.Location = New System.Drawing.Point(191, 110)
		Me.exitButton.Name = "exitButton"
		Me.exitButton.Size = New System.Drawing.Size(75, 29)
		Me.exitButton.TabIndex = 3
		Me.exitButton.Text = "E&xit"
		Me.exitButton.UseVisualStyleBackColor = True
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 176)
		Me.Controls.Add(Me.exitButton)
		Me.Controls.Add(Me.creditNumberButton)
		Me.Controls.Add(Me.creditNumberLabel)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.firstFourTextBox)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MaximizeBox = False
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Vita Credit"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents firstFourTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents creditNumberLabel As System.Windows.Forms.Label
    Friend WithEvents creditNumberButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
