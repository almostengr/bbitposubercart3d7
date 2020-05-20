<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_form))
        Me.updateStoreInfo_Button = New System.Windows.Forms.Button()
        Me.endOfDayProcessing_Button = New System.Windows.Forms.Button()
        Me.updateProducts_Button = New System.Windows.Forms.Button()
        Me.cngFtpSettings_Button = New System.Windows.Forms.Button()
        Me.exit_Button = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.adminFormToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'updateStoreInfo_Button
        '
        Me.updateStoreInfo_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateStoreInfo_Button.Location = New System.Drawing.Point(12, 12)
        Me.updateStoreInfo_Button.Name = "updateStoreInfo_Button"
        Me.updateStoreInfo_Button.Size = New System.Drawing.Size(145, 102)
        Me.updateStoreInfo_Button.TabIndex = 0
        Me.updateStoreInfo_Button.Text = "Update Store Information"
        Me.updateStoreInfo_Button.UseVisualStyleBackColor = True
        '
        'endOfDayProcessing_Button
        '
        Me.endOfDayProcessing_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endOfDayProcessing_Button.Location = New System.Drawing.Point(313, 12)
        Me.endOfDayProcessing_Button.Name = "endOfDayProcessing_Button"
        Me.endOfDayProcessing_Button.Size = New System.Drawing.Size(145, 102)
        Me.endOfDayProcessing_Button.TabIndex = 1
        Me.endOfDayProcessing_Button.Text = "Run End of Business Day Processing"
        Me.endOfDayProcessing_Button.UseVisualStyleBackColor = True
        '
        'updateProducts_Button
        '
        Me.updateProducts_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateProducts_Button.Location = New System.Drawing.Point(163, 12)
        Me.updateProducts_Button.Name = "updateProducts_Button"
        Me.updateProducts_Button.Size = New System.Drawing.Size(145, 102)
        Me.updateProducts_Button.TabIndex = 2
        Me.updateProducts_Button.Text = "Update Local Product Database"
        Me.updateProducts_Button.UseVisualStyleBackColor = True
        '
        'cngFtpSettings_Button
        '
        Me.cngFtpSettings_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cngFtpSettings_Button.Location = New System.Drawing.Point(11, 120)
        Me.cngFtpSettings_Button.Name = "cngFtpSettings_Button"
        Me.cngFtpSettings_Button.Size = New System.Drawing.Size(145, 102)
        Me.cngFtpSettings_Button.TabIndex = 3
        Me.cngFtpSettings_Button.Text = "Change FTP Settings"
        Me.cngFtpSettings_Button.UseVisualStyleBackColor = True
        '
        'exit_Button
        '
        Me.exit_Button.BackColor = System.Drawing.Color.Red
        Me.exit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_Button.Location = New System.Drawing.Point(313, 120)
        Me.exit_Button.Name = "exit_Button"
        Me.exit_Button.Size = New System.Drawing.Size(145, 102)
        Me.exit_Button.TabIndex = 4
        Me.exit_Button.Text = "Exit"
        Me.exit_Button.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.adminFormToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 268)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(470, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'adminFormToolStripStatusLabel
        '
        Me.adminFormToolStripStatusLabel.Name = "adminFormToolStripStatusLabel"
        Me.adminFormToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.adminFormToolStripStatusLabel.Text = "Ready."
        '
        'admin_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 290)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.exit_Button)
        Me.Controls.Add(Me.cngFtpSettings_Button)
        Me.Controls.Add(Me.updateProducts_Button)
        Me.Controls.Add(Me.endOfDayProcessing_Button)
        Me.Controls.Add(Me.updateStoreInfo_Button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "admin_form"
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.Text = "Adminstration - BBIT POS for Ubercart 3"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents updateStoreInfo_Button As System.Windows.Forms.Button
    Friend WithEvents endOfDayProcessing_Button As System.Windows.Forms.Button
    Friend WithEvents updateProducts_Button As System.Windows.Forms.Button
    Friend WithEvents cngFtpSettings_Button As System.Windows.Forms.Button
    Friend WithEvents exit_Button As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents adminFormToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
End Class
