<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(configWizard))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.configCancelButton = New System.Windows.Forms.Button()
        Me.programLabel = New System.Windows.Forms.Label()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(-1, -1)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(122, 240)
        Me.LogoPictureBox.TabIndex = 2
        Me.LogoPictureBox.TabStop = False
        '
        'nextButton
        '
        Me.nextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nextButton.Location = New System.Drawing.Point(214, 241)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(75, 23)
        Me.nextButton.TabIndex = 1
        Me.nextButton.Text = "Next >"
        '
        'configCancelButton
        '
        Me.configCancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.configCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.configCancelButton.Location = New System.Drawing.Point(327, 241)
        Me.configCancelButton.Name = "configCancelButton"
        Me.configCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.configCancelButton.TabIndex = 2
        Me.configCancelButton.Text = "Cancel"
        '
        'programLabel
        '
        Me.programLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programLabel.Location = New System.Drawing.Point(128, 13)
        Me.programLabel.Name = "programLabel"
        Me.programLabel.Size = New System.Drawing.Size(274, 37)
        Me.programLabel.TabIndex = 5
        Me.programLabel.Text = "BBIT POS for Ubercart 3"
        '
        'descriptionLabel
        '
        Me.descriptionLabel.Location = New System.Drawing.Point(127, 50)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(275, 188)
        Me.descriptionLabel.TabIndex = 6
        Me.descriptionLabel.Text = "Loading..."
        '
        'backButton
        '
        Me.backButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.backButton.Enabled = False
        Me.backButton.Location = New System.Drawing.Point(133, 241)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(75, 23)
        Me.backButton.TabIndex = 7
        Me.backButton.Text = "< Back"
        '
        'configWizard
        '
        Me.AcceptButton = Me.nextButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 276)
        Me.ControlBox = False
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.descriptionLabel)
        Me.Controls.Add(Me.programLabel)
        Me.Controls.Add(Me.configCancelButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "configWizard"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BBIT POS for Ubercart 3 Configruation Wizard"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents configCancelButton As System.Windows.Forms.Button
    Friend WithEvents programLabel As System.Windows.Forms.Label
    Friend WithEvents descriptionLabel As System.Windows.Forms.Label
    Friend WithEvents backButton As System.Windows.Forms.Button

End Class
