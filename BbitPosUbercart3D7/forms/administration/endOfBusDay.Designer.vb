<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class endOfBusDay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(endOfBusDay))
        Me.endOfBusDayLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'endOfBusDayLabel
        '
        Me.endOfBusDayLabel.AutoSize = True
        Me.endOfBusDayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endOfBusDayLabel.Location = New System.Drawing.Point(12, 9)
        Me.endOfBusDayLabel.Name = "endOfBusDayLabel"
        Me.endOfBusDayLabel.Size = New System.Drawing.Size(77, 20)
        Me.endOfBusDayLabel.TabIndex = 0
        Me.endOfBusDayLabel.Text = "Starting..."
        '
        'endOfBusDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 77)
        Me.Controls.Add(Me.endOfBusDayLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "endOfBusDay"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "End of Business Day Process"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents endOfBusDayLabel As System.Windows.Forms.Label

End Class
