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
        Dim LengthLabel As System.Windows.Forms.Label
        Me.LengthText = New System.Windows.Forms.TextBox()
        Me.WidthText = New System.Windows.Forms.TextBox()
        Me.WidthLabel = New System.Windows.Forms.Label()
        Me.HeightText = New System.Windows.Forms.TextBox()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.VolumeLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.CalcVolumeLabel = New System.Windows.Forms.Label()
        LengthLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LengthLabel
        '
        LengthLabel.AutoSize = True
        LengthLabel.Location = New System.Drawing.Point(12, 15)
        LengthLabel.Name = "LengthLabel"
        LengthLabel.Size = New System.Drawing.Size(43, 13)
        LengthLabel.TabIndex = 0
        LengthLabel.Text = "Length:"
        '
        'LengthText
        '
        Me.LengthText.Location = New System.Drawing.Point(57, 12)
        Me.LengthText.Name = "LengthText"
        Me.LengthText.Size = New System.Drawing.Size(100, 20)
        Me.LengthText.TabIndex = 1
        '
        'WidthText
        '
        Me.WidthText.Location = New System.Drawing.Point(57, 38)
        Me.WidthText.Name = "WidthText"
        Me.WidthText.Size = New System.Drawing.Size(100, 20)
        Me.WidthText.TabIndex = 3
        '
        'WidthLabel
        '
        Me.WidthLabel.AutoSize = True
        Me.WidthLabel.Location = New System.Drawing.Point(12, 41)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(38, 13)
        Me.WidthLabel.TabIndex = 2
        Me.WidthLabel.Text = "Width:"
        '
        'HeightText
        '
        Me.HeightText.Location = New System.Drawing.Point(57, 64)
        Me.HeightText.Name = "HeightText"
        Me.HeightText.Size = New System.Drawing.Size(100, 20)
        Me.HeightText.TabIndex = 5
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(12, 67)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(41, 13)
        Me.HeightLabel.TabIndex = 4
        Me.HeightLabel.Text = "Height:"
        '
        'VolumeLabel
        '
        Me.VolumeLabel.AutoSize = True
        Me.VolumeLabel.Location = New System.Drawing.Point(10, 100)
        Me.VolumeLabel.Name = "VolumeLabel"
        Me.VolumeLabel.Size = New System.Drawing.Size(45, 13)
        Me.VolumeLabel.TabIndex = 6
        Me.VolumeLabel.Text = "Volume:"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(164, 97)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(108, 23)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(164, 68)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(108, 23)
        Me.CalcButton.TabIndex = 9
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'CalcVolumeLabel
        '
        Me.CalcVolumeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CalcVolumeLabel.Location = New System.Drawing.Point(57, 93)
        Me.CalcVolumeLabel.Name = "CalcVolumeLabel"
        Me.CalcVolumeLabel.Size = New System.Drawing.Size(100, 27)
        Me.CalcVolumeLabel.TabIndex = 10
        Me.CalcVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 129)
        Me.Controls.Add(Me.CalcVolumeLabel)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.VolumeLabel)
        Me.Controls.Add(Me.HeightText)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.WidthText)
        Me.Controls.Add(Me.WidthLabel)
        Me.Controls.Add(Me.LengthText)
        Me.Controls.Add(LengthLabel)
        Me.Name = "Form1"
        Me.Text = "Willow Pools"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LengthText As TextBox
    Friend WithEvents WidthText As TextBox
    Friend WithEvents WidthLabel As Label
    Friend WithEvents HeightText As TextBox
    Friend WithEvents HeightLabel As Label
    Friend WithEvents VolumeLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents CalcButton As Button
    Friend WithEvents CalcVolumeLabel As Label
End Class
