<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class register_amt
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
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents reg_OK As System.Windows.Forms.Button
    Friend WithEvents reg_Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.reg_OK = New System.Windows.Forms.Button()
        Me.reg_Cancel = New System.Windows.Forms.Button()
        Me.reg_Num1_Button = New System.Windows.Forms.Button()
        Me.reg_Num2_Button = New System.Windows.Forms.Button()
        Me.reg_Num3_Button = New System.Windows.Forms.Button()
        Me.reg_Num6_Button = New System.Windows.Forms.Button()
        Me.reg_Num5_Button = New System.Windows.Forms.Button()
        Me.reg_Num4_Button = New System.Windows.Forms.Button()
        Me.reg_Num9_Button = New System.Windows.Forms.Button()
        Me.reg_NUm8_Button = New System.Windows.Forms.Button()
        Me.reg_Num7_Button = New System.Windows.Forms.Button()
        Me.reg_Num0_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(12, 9)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Enter Amount"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(15, 35)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(159, 26)
        Me.AmountTextBox.TabIndex = 3
        '
        'reg_OK
        '
        Me.reg_OK.BackColor = System.Drawing.Color.LimeGreen
        Me.reg_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_OK.Location = New System.Drawing.Point(124, 235)
        Me.reg_OK.Name = "reg_OK"
        Me.reg_OK.Size = New System.Drawing.Size(50, 50)
        Me.reg_OK.TabIndex = 4
        Me.reg_OK.Text = "&OK"
        Me.reg_OK.UseVisualStyleBackColor = False
        '
        'reg_Cancel
        '
        Me.reg_Cancel.BackColor = System.Drawing.Color.Red
        Me.reg_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.reg_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_Cancel.Location = New System.Drawing.Point(11, 235)
        Me.reg_Cancel.Name = "reg_Cancel"
        Me.reg_Cancel.Size = New System.Drawing.Size(50, 50)
        Me.reg_Cancel.TabIndex = 5
        Me.reg_Cancel.Text = "Esc"
        Me.reg_Cancel.UseVisualStyleBackColor = False
        '
        'reg_Num1_Button
        '
        Me.reg_Num1_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_Num1_Button.Location = New System.Drawing.Point(12, 67)
        Me.reg_Num1_Button.Name = "reg_Num1_Button"
        Me.reg_Num1_Button.Size = New System.Drawing.Size(50, 50)
        Me.reg_Num1_Button.TabIndex = 6
        Me.reg_Num1_Button.Text = "1"
        Me.reg_Num1_Button.UseVisualStyleBackColor = True
        '
        'reg_Num2_Button
        '
        Me.reg_Num2_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_Num2_Button.Location = New System.Drawing.Point(68, 67)
        Me.reg_Num2_Button.Name = "reg_Num2_Button"
        Me.reg_Num2_Button.Size = New System.Drawing.Size(50, 50)
        Me.reg_Num2_Button.TabIndex = 7
        Me.reg_Num2_Button.Text = "2"
        Me.reg_Num2_Button.UseVisualStyleBackColor = True
        '
        'reg_Num3_Button
        '
        Me.reg_Num3_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_Num3_Button.Location = New System.Drawing.Point(124, 67)
        Me.reg_Num3_Button.Name = "reg_Num3_Button"
        Me.reg_Num3_Button.Size = New System.Drawing.Size(50, 50)
        Me.reg_Num3_Button.TabIndex = 8
        Me.reg_Num3_Button.Text = "3"
        Me.reg_Num3_Button.UseVisualStyleBackColor = True
        '
        'reg_Num6_Button
        '
        Me.reg_Num6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_Num6_Button.Location = New System.Drawing.Point(124, 123)
        Me.reg_Num6_Button.Name = "reg_Num6_Button"
        Me.reg_Num6_Button.Size = New System.Drawing.Size(50, 50)
        Me.reg_Num6_Button.TabIndex = 11
        Me.reg_Num6_Button.Text = "6"
        Me.reg_Num6_Button.UseVisualStyleBackColor = True
        '
        'reg_Num5_Button
        '
        Me.reg_Num5_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_Num5_Button.Location = New System.Drawing.Point(68, 123)
        Me.reg_Num5_Button.Name = "reg_Num5_Button"
        Me.reg_Num5_Button.Size = New System.Drawing.Size(50, 50)
        Me.reg_Num5_Button.TabIndex = 10
        Me.reg_Num5_Button.Text = "5"
        Me.reg_Num5_Button.UseVisualStyleBackColor = True
        '
        'reg_Num4_Button
        '
        Me.reg_Num4_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_Num4_Button.Location = New System.Drawing.Point(12, 123)
        Me.reg_Num4_Button.Name = "reg_Num4_Button"
        Me.reg_Num4_Button.Size = New System.Drawing.Size(50, 50)
        Me.reg_Num4_Button.TabIndex = 9
        Me.reg_Num4_Button.Text = "4"
        Me.reg_Num4_Button.UseVisualStyleBackColor = True
        '
        'reg_Num9_Button
        '
        Me.reg_Num9_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_Num9_Button.Location = New System.Drawing.Point(124, 179)
        Me.reg_Num9_Button.Name = "reg_Num9_Button"
        Me.reg_Num9_Button.Size = New System.Drawing.Size(50, 50)
        Me.reg_Num9_Button.TabIndex = 14
        Me.reg_Num9_Button.Text = "9"
        Me.reg_Num9_Button.UseVisualStyleBackColor = True
        '
        'reg_NUm8_Button
        '
        Me.reg_NUm8_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_NUm8_Button.Location = New System.Drawing.Point(68, 179)
        Me.reg_NUm8_Button.Name = "reg_NUm8_Button"
        Me.reg_NUm8_Button.Size = New System.Drawing.Size(50, 50)
        Me.reg_NUm8_Button.TabIndex = 13
        Me.reg_NUm8_Button.Text = "8"
        Me.reg_NUm8_Button.UseVisualStyleBackColor = True
        '
        'reg_Num7_Button
        '
        Me.reg_Num7_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_Num7_Button.Location = New System.Drawing.Point(12, 179)
        Me.reg_Num7_Button.Name = "reg_Num7_Button"
        Me.reg_Num7_Button.Size = New System.Drawing.Size(50, 50)
        Me.reg_Num7_Button.TabIndex = 12
        Me.reg_Num7_Button.Text = "7"
        Me.reg_Num7_Button.UseVisualStyleBackColor = True
        '
        'reg_Num0_Button
        '
        Me.reg_Num0_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reg_Num0_Button.Location = New System.Drawing.Point(68, 235)
        Me.reg_Num0_Button.Name = "reg_Num0_Button"
        Me.reg_Num0_Button.Size = New System.Drawing.Size(50, 50)
        Me.reg_Num0_Button.TabIndex = 15
        Me.reg_Num0_Button.Text = "0"
        Me.reg_Num0_Button.UseVisualStyleBackColor = True
        '
        'register_amt
        '
        Me.AcceptButton = Me.reg_OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.reg_Cancel
        Me.ClientSize = New System.Drawing.Size(189, 296)
        Me.Controls.Add(Me.reg_Num0_Button)
        Me.Controls.Add(Me.reg_Num9_Button)
        Me.Controls.Add(Me.reg_NUm8_Button)
        Me.Controls.Add(Me.reg_Num7_Button)
        Me.Controls.Add(Me.reg_Num6_Button)
        Me.Controls.Add(Me.reg_Num5_Button)
        Me.Controls.Add(Me.reg_Num4_Button)
        Me.Controls.Add(Me.reg_Num3_Button)
        Me.Controls.Add(Me.reg_Num2_Button)
        Me.Controls.Add(Me.reg_Num1_Button)
        Me.Controls.Add(Me.reg_Cancel)
        Me.Controls.Add(Me.reg_OK)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "register_amt"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter Amount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents reg_Num1_Button As System.Windows.Forms.Button
    Friend WithEvents reg_Num2_Button As System.Windows.Forms.Button
    Friend WithEvents reg_Num3_Button As System.Windows.Forms.Button
    Friend WithEvents reg_Num6_Button As System.Windows.Forms.Button
    Friend WithEvents reg_Num5_Button As System.Windows.Forms.Button
    Friend WithEvents reg_Num4_Button As System.Windows.Forms.Button
    Friend WithEvents reg_Num9_Button As System.Windows.Forms.Button
    Friend WithEvents reg_NUm8_Button As System.Windows.Forms.Button
    Friend WithEvents reg_Num7_Button As System.Windows.Forms.Button
    Friend WithEvents reg_Num0_Button As System.Windows.Forms.Button

End Class
