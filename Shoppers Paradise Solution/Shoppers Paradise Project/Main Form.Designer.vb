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
		Me.monthlyPurchaseLabel = New System.Windows.Forms.Label()
		Me.rewardPointsDescrLabel = New System.Windows.Forms.Label()
		Me.rewardPointsText = New System.Windows.Forms.Label()
		Me.purchaseInput = New System.Windows.Forms.TextBox()
		Me.membershipBox = New System.Windows.Forms.GroupBox()
		Me.radioBasic = New System.Windows.Forms.RadioButton()
		Me.radioStandard = New System.Windows.Forms.RadioButton()
		Me.radioPremium = New System.Windows.Forms.RadioButton()
		Me.exitButton = New System.Windows.Forms.Button()
		Me.calcButton = New System.Windows.Forms.Button()
		Me.membershipBox.SuspendLayout()
		Me.SuspendLayout()
		'
		'monthlyPurchaseLabel
		'
		Me.monthlyPurchaseLabel.AutoSize = True
		Me.monthlyPurchaseLabel.Location = New System.Drawing.Point(10, 108)
		Me.monthlyPurchaseLabel.Name = "monthlyPurchaseLabel"
		Me.monthlyPurchaseLabel.Size = New System.Drawing.Size(120, 13)
		Me.monthlyPurchaseLabel.TabIndex = 0
		Me.monthlyPurchaseLabel.Text = "Total monthly purchase:"
		'
		'rewardPointsDescrLabel
		'
		Me.rewardPointsDescrLabel.AutoSize = True
		Me.rewardPointsDescrLabel.Location = New System.Drawing.Point(219, 9)
		Me.rewardPointsDescrLabel.Name = "rewardPointsDescrLabel"
		Me.rewardPointsDescrLabel.Size = New System.Drawing.Size(78, 13)
		Me.rewardPointsDescrLabel.TabIndex = 1
		Me.rewardPointsDescrLabel.Text = "Reward points:"
		'
		'rewardPointsText
		'
		Me.rewardPointsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.rewardPointsText.Location = New System.Drawing.Point(222, 22)
		Me.rewardPointsText.Name = "rewardPointsText"
		Me.rewardPointsText.Size = New System.Drawing.Size(161, 122)
		Me.rewardPointsText.TabIndex = 2
		'
		'purchaseInput
		'
		Me.purchaseInput.Location = New System.Drawing.Point(12, 124)
		Me.purchaseInput.Name = "purchaseInput"
		Me.purchaseInput.Size = New System.Drawing.Size(201, 20)
		Me.purchaseInput.TabIndex = 3
		'
		'membershipBox
		'
		Me.membershipBox.Controls.Add(Me.radioPremium)
		Me.membershipBox.Controls.Add(Me.radioStandard)
		Me.membershipBox.Controls.Add(Me.radioBasic)
		Me.membershipBox.Location = New System.Drawing.Point(13, 13)
		Me.membershipBox.Name = "membershipBox"
		Me.membershipBox.Size = New System.Drawing.Size(200, 92)
		Me.membershipBox.TabIndex = 4
		Me.membershipBox.TabStop = False
		Me.membershipBox.Text = "Membership type"
		'
		'radioBasic
		'
		Me.radioBasic.AutoSize = True
		Me.radioBasic.Checked = True
		Me.radioBasic.Location = New System.Drawing.Point(7, 20)
		Me.radioBasic.Name = "radioBasic"
		Me.radioBasic.Size = New System.Drawing.Size(51, 17)
		Me.radioBasic.TabIndex = 0
		Me.radioBasic.TabStop = True
		Me.radioBasic.Text = "Basic"
		Me.radioBasic.UseVisualStyleBackColor = True
		'
		'radioStandard
		'
		Me.radioStandard.AutoSize = True
		Me.radioStandard.Location = New System.Drawing.Point(7, 44)
		Me.radioStandard.Name = "radioStandard"
		Me.radioStandard.Size = New System.Drawing.Size(68, 17)
		Me.radioStandard.TabIndex = 1
		Me.radioStandard.TabStop = True
		Me.radioStandard.Text = "Standard"
		Me.radioStandard.UseVisualStyleBackColor = True
		'
		'radioPremium
		'
		Me.radioPremium.AutoSize = True
		Me.radioPremium.Location = New System.Drawing.Point(7, 68)
		Me.radioPremium.Name = "radioPremium"
		Me.radioPremium.Size = New System.Drawing.Size(65, 17)
		Me.radioPremium.TabIndex = 2
		Me.radioPremium.TabStop = True
		Me.radioPremium.Text = "Premium"
		Me.radioPremium.UseVisualStyleBackColor = True
		'
		'exitButton
		'
		Me.exitButton.Location = New System.Drawing.Point(222, 150)
		Me.exitButton.Name = "exitButton"
		Me.exitButton.Size = New System.Drawing.Size(161, 23)
		Me.exitButton.TabIndex = 5
		Me.exitButton.Text = "Exit"
		Me.exitButton.UseVisualStyleBackColor = True
		'
		'calcButton
		'
		Me.calcButton.Location = New System.Drawing.Point(12, 150)
		Me.calcButton.Name = "calcButton"
		Me.calcButton.Size = New System.Drawing.Size(201, 23)
		Me.calcButton.TabIndex = 6
		Me.calcButton.Text = "Calculate Reward Points"
		Me.calcButton.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AcceptButton = Me.calcButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(393, 181)
		Me.Controls.Add(Me.calcButton)
		Me.Controls.Add(Me.exitButton)
		Me.Controls.Add(Me.membershipBox)
		Me.Controls.Add(Me.purchaseInput)
		Me.Controls.Add(Me.rewardPointsText)
		Me.Controls.Add(Me.rewardPointsDescrLabel)
		Me.Controls.Add(Me.monthlyPurchaseLabel)
		Me.Name = "Form1"
		Me.Text = "Shoppers Paradise"
		Me.membershipBox.ResumeLayout(False)
		Me.membershipBox.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents monthlyPurchaseLabel As Label
    Friend WithEvents rewardPointsDescrLabel As Label
    Friend WithEvents rewardPointsText As Label
    Friend WithEvents purchaseInput As TextBox
    Friend WithEvents membershipBox As GroupBox
    Friend WithEvents radioPremium As RadioButton
    Friend WithEvents radioStandard As RadioButton
    Friend WithEvents radioBasic As RadioButton
    Friend WithEvents exitButton As Button
    Friend WithEvents calcButton As Button
End Class
