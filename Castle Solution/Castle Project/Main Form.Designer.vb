<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BananaButton = New System.Windows.Forms.Button()
        Me.SundaeButton = New System.Windows.Forms.Button()
        Me.MilkshakeButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PriceDetailsLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BananaButton
        '
        Me.BananaButton.Location = New System.Drawing.Point(12, 12)
        Me.BananaButton.Name = "BananaButton"
        Me.BananaButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BananaButton.Size = New System.Drawing.Size(132, 41)
        Me.BananaButton.TabIndex = 0
        Me.BananaButton.Text = "Banana Split"
        Me.BananaButton.UseVisualStyleBackColor = True
        '
        'SundaeButton
        '
        Me.SundaeButton.Location = New System.Drawing.Point(12, 59)
        Me.SundaeButton.Name = "SundaeButton"
        Me.SundaeButton.Size = New System.Drawing.Size(132, 41)
        Me.SundaeButton.TabIndex = 1
        Me.SundaeButton.Text = "Sundae"
        Me.SundaeButton.UseVisualStyleBackColor = True
        '
        'MilkshakeButton
        '
        Me.MilkshakeButton.Location = New System.Drawing.Point(12, 106)
        Me.MilkshakeButton.Name = "MilkshakeButton"
        Me.MilkshakeButton.Size = New System.Drawing.Size(132, 41)
        Me.MilkshakeButton.TabIndex = 2
        Me.MilkshakeButton.Text = "Milkshake"
        Me.MilkshakeButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 153)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 41)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PriceDetailsLabel
        '
        Me.PriceDetailsLabel.AutoSize = True
        Me.PriceDetailsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceDetailsLabel.Location = New System.Drawing.Point(150, 12)
        Me.PriceDetailsLabel.Name = "PriceDetailsLabel"
        Me.PriceDetailsLabel.Size = New System.Drawing.Size(60, 16)
        Me.PriceDetailsLabel.TabIndex = 4
        Me.PriceDetailsLabel.Text = "Price ($):"
        '
        'PriceLabel
        '
        Me.PriceLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PriceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(150, 37)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(243, 42)
        Me.PriceLabel.TabIndex = 5
        Me.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 204)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.PriceDetailsLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.MilkshakeButton)
        Me.Controls.Add(Me.SundaeButton)
        Me.Controls.Add(Me.BananaButton)
        Me.Name = "Form1"
        Me.Text = "Castle's Ice Cream Parlor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BananaButton As Button
    Friend WithEvents SundaeButton As Button
    Friend WithEvents MilkshakeButton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PriceDetailsLabel As Label
    Friend WithEvents PriceLabel As Label
End Class
