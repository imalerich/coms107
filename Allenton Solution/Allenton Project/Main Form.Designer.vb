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
        Me.currentReadingLabel = New System.Windows.Forms.Label()
        Me.previousReadingLabel = New System.Windows.Forms.Label()
        Me.gallonsUsedLabel = New System.Windows.Forms.Label()
        Me.totalChargeLabel = New System.Windows.Forms.Label()
        Me.currentReading = New System.Windows.Forms.TextBox()
        Me.previousReading = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.gallonsUsed = New System.Windows.Forms.Label()
        Me.totalCharge = New System.Windows.Forms.Label()
        Me.errorMessages = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'currentReadingLabel
        '
        Me.currentReadingLabel.AutoSize = True
        Me.currentReadingLabel.Location = New System.Drawing.Point(16, 15)
        Me.currentReadingLabel.Name = "currentReadingLabel"
        Me.currentReadingLabel.Size = New System.Drawing.Size(82, 13)
        Me.currentReadingLabel.TabIndex = 0
        Me.currentReadingLabel.Text = "Current reading:"
        '
        'previousReadingLabel
        '
        Me.previousReadingLabel.AutoSize = True
        Me.previousReadingLabel.Location = New System.Drawing.Point(9, 41)
        Me.previousReadingLabel.Name = "previousReadingLabel"
        Me.previousReadingLabel.Size = New System.Drawing.Size(89, 13)
        Me.previousReadingLabel.TabIndex = 1
        Me.previousReadingLabel.Text = "Previous reading:"
        '
        'gallonsUsedLabel
        '
        Me.gallonsUsedLabel.AutoSize = True
        Me.gallonsUsedLabel.Location = New System.Drawing.Point(27, 71)
        Me.gallonsUsedLabel.Name = "gallonsUsedLabel"
        Me.gallonsUsedLabel.Size = New System.Drawing.Size(71, 13)
        Me.gallonsUsedLabel.TabIndex = 2
        Me.gallonsUsedLabel.Text = "Gallons used:"
        '
        'totalChargeLabel
        '
        Me.totalChargeLabel.AutoSize = True
        Me.totalChargeLabel.Location = New System.Drawing.Point(27, 106)
        Me.totalChargeLabel.Name = "totalChargeLabel"
        Me.totalChargeLabel.Size = New System.Drawing.Size(70, 13)
        Me.totalChargeLabel.TabIndex = 3
        Me.totalChargeLabel.Text = "Total charge:"
        '
        'currentReading
        '
        Me.currentReading.Location = New System.Drawing.Point(104, 12)
        Me.currentReading.Name = "currentReading"
        Me.currentReading.Size = New System.Drawing.Size(100, 20)
        Me.currentReading.TabIndex = 4
        '
        'previousReading
        '
        Me.previousReading.Location = New System.Drawing.Point(104, 38)
        Me.previousReading.Name = "previousReading"
        Me.previousReading.Size = New System.Drawing.Size(100, 20)
        Me.previousReading.TabIndex = 5
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(210, 12)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(119, 46)
        Me.calculateButton.TabIndex = 6
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(210, 64)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(119, 46)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'gallonsUsed
        '
        Me.gallonsUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gallonsUsed.Location = New System.Drawing.Point(104, 64)
        Me.gallonsUsed.Name = "gallonsUsed"
        Me.gallonsUsed.Size = New System.Drawing.Size(99, 26)
        Me.gallonsUsed.TabIndex = 8
        Me.gallonsUsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalCharge
        '
        Me.totalCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalCharge.Location = New System.Drawing.Point(104, 99)
        Me.totalCharge.Name = "totalCharge"
        Me.totalCharge.Size = New System.Drawing.Size(99, 26)
        Me.totalCharge.TabIndex = 9
        Me.totalCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'errorMessages
        '
        Me.errorMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.errorMessages.Location = New System.Drawing.Point(12, 134)
        Me.errorMessages.Name = "errorMessages"
        Me.errorMessages.Size = New System.Drawing.Size(317, 69)
        Me.errorMessages.TabIndex = 10
        '
        'Form1
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 212)
        Me.Controls.Add(Me.errorMessages)
        Me.Controls.Add(Me.totalCharge)
        Me.Controls.Add(Me.gallonsUsed)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.previousReading)
        Me.Controls.Add(Me.currentReading)
        Me.Controls.Add(Me.totalChargeLabel)
        Me.Controls.Add(Me.gallonsUsedLabel)
        Me.Controls.Add(Me.previousReadingLabel)
        Me.Controls.Add(Me.currentReadingLabel)
        Me.Name = "Form1"
        Me.Text = "Allenton Water Department"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents currentReadingLabel As Label
    Friend WithEvents previousReadingLabel As Label
    Friend WithEvents gallonsUsedLabel As Label
    Friend WithEvents totalChargeLabel As Label
    Friend WithEvents currentReading As TextBox
    Friend WithEvents previousReading As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents gallonsUsed As Label
    Friend WithEvents totalCharge As Label
    Friend WithEvents errorMessages As Label
End Class
