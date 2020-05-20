<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class storeInfoDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(storeInfoDialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.storeWebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.storeNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.addr1TextBox = New System.Windows.Forms.TextBox()
        Me.addr1Label = New System.Windows.Forms.Label()
        Me.addr2TextBox = New System.Windows.Forms.TextBox()
        Me.addr2Label = New System.Windows.Forms.Label()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.cityLabel = New System.Windows.Forms.Label()
        Me.stateTextBox = New System.Windows.Forms.TextBox()
        Me.stateLabel = New System.Windows.Forms.Label()
        Me.postalTextBox = New System.Windows.Forms.TextBox()
        Me.postalCodeLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.phoneTextBox = New System.Windows.Forms.TextBox()
        Me.phoneNumberLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 456)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 33)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(3, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 2
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 3
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Store Website"
        '
        'storeWebsiteTextBox
        '
        Me.storeWebsiteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.storeWebsiteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storeWebsiteTextBox.Location = New System.Drawing.Point(12, 29)
        Me.storeWebsiteTextBox.Name = "storeWebsiteTextBox"
        Me.storeWebsiteTextBox.Size = New System.Drawing.Size(411, 23)
        Me.storeWebsiteTextBox.TabIndex = 1
        Me.storeWebsiteTextBox.WordWrap = False
        '
        'storeNameTextBox
        '
        Me.storeNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.storeNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storeNameTextBox.Location = New System.Drawing.Point(12, 97)
        Me.storeNameTextBox.Name = "storeNameTextBox"
        Me.storeNameTextBox.ReadOnly = True
        Me.storeNameTextBox.Size = New System.Drawing.Size(411, 23)
        Me.storeNameTextBox.TabIndex = 4
        Me.storeNameTextBox.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Store Name"
        '
        'addr1TextBox
        '
        Me.addr1TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addr1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addr1TextBox.Location = New System.Drawing.Point(12, 153)
        Me.addr1TextBox.Name = "addr1TextBox"
        Me.addr1TextBox.ReadOnly = True
        Me.addr1TextBox.Size = New System.Drawing.Size(411, 23)
        Me.addr1TextBox.TabIndex = 6
        Me.addr1TextBox.WordWrap = False
        '
        'addr1Label
        '
        Me.addr1Label.AutoSize = True
        Me.addr1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addr1Label.Location = New System.Drawing.Point(9, 133)
        Me.addr1Label.Name = "addr1Label"
        Me.addr1Label.Size = New System.Drawing.Size(103, 17)
        Me.addr1Label.TabIndex = 5
        Me.addr1Label.Text = "Address Line 1"
        '
        'addr2TextBox
        '
        Me.addr2TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addr2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addr2TextBox.Location = New System.Drawing.Point(12, 210)
        Me.addr2TextBox.Name = "addr2TextBox"
        Me.addr2TextBox.ReadOnly = True
        Me.addr2TextBox.Size = New System.Drawing.Size(411, 23)
        Me.addr2TextBox.TabIndex = 8
        Me.addr2TextBox.WordWrap = False
        '
        'addr2Label
        '
        Me.addr2Label.AutoSize = True
        Me.addr2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addr2Label.Location = New System.Drawing.Point(9, 190)
        Me.addr2Label.Name = "addr2Label"
        Me.addr2Label.Size = New System.Drawing.Size(103, 17)
        Me.addr2Label.TabIndex = 7
        Me.addr2Label.Text = "Address Line 2"
        '
        'cityTextBox
        '
        Me.cityTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityTextBox.Location = New System.Drawing.Point(12, 266)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.ReadOnly = True
        Me.cityTextBox.Size = New System.Drawing.Size(411, 23)
        Me.cityTextBox.TabIndex = 10
        Me.cityTextBox.WordWrap = False
        '
        'cityLabel
        '
        Me.cityLabel.AutoSize = True
        Me.cityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityLabel.Location = New System.Drawing.Point(9, 246)
        Me.cityLabel.Name = "cityLabel"
        Me.cityLabel.Size = New System.Drawing.Size(31, 17)
        Me.cityLabel.TabIndex = 9
        Me.cityLabel.Text = "City"
        '
        'stateTextBox
        '
        Me.stateTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stateTextBox.Location = New System.Drawing.Point(12, 322)
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.ReadOnly = True
        Me.stateTextBox.Size = New System.Drawing.Size(411, 23)
        Me.stateTextBox.TabIndex = 12
        Me.stateTextBox.WordWrap = False
        '
        'stateLabel
        '
        Me.stateLabel.AutoSize = True
        Me.stateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stateLabel.Location = New System.Drawing.Point(12, 302)
        Me.stateLabel.Name = "stateLabel"
        Me.stateLabel.Size = New System.Drawing.Size(41, 17)
        Me.stateLabel.TabIndex = 11
        Me.stateLabel.Text = "State"
        '
        'postalTextBox
        '
        Me.postalTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.postalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postalTextBox.Location = New System.Drawing.Point(12, 377)
        Me.postalTextBox.Name = "postalTextBox"
        Me.postalTextBox.ReadOnly = True
        Me.postalTextBox.Size = New System.Drawing.Size(411, 23)
        Me.postalTextBox.TabIndex = 14
        Me.postalTextBox.WordWrap = False
        '
        'postalCodeLabel
        '
        Me.postalCodeLabel.AutoSize = True
        Me.postalCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.postalCodeLabel.Location = New System.Drawing.Point(9, 357)
        Me.postalCodeLabel.Name = "postalCodeLabel"
        Me.postalCodeLabel.Size = New System.Drawing.Size(84, 17)
        Me.postalCodeLabel.TabIndex = 13
        Me.postalCodeLabel.Text = "Postal Code"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Enter ""http://"" as part of the URL."
        '
        'phoneTextBox
        '
        Me.phoneTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.phoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneTextBox.Location = New System.Drawing.Point(12, 423)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.ReadOnly = True
        Me.phoneTextBox.Size = New System.Drawing.Size(411, 23)
        Me.phoneTextBox.TabIndex = 17
        Me.phoneTextBox.WordWrap = False
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.AutoSize = True
        Me.phoneNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNumberLabel.Location = New System.Drawing.Point(9, 403)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(103, 17)
        Me.phoneNumberLabel.TabIndex = 16
        Me.phoneNumberLabel.Text = "Phone Number"
        '
        'storeInfoDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 501)
        Me.Controls.Add(Me.phoneTextBox)
        Me.Controls.Add(Me.phoneNumberLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.postalTextBox)
        Me.Controls.Add(Me.postalCodeLabel)
        Me.Controls.Add(Me.stateTextBox)
        Me.Controls.Add(Me.stateLabel)
        Me.Controls.Add(Me.cityTextBox)
        Me.Controls.Add(Me.cityLabel)
        Me.Controls.Add(Me.addr2TextBox)
        Me.Controls.Add(Me.addr2Label)
        Me.Controls.Add(Me.addr1TextBox)
        Me.Controls.Add(Me.addr1Label)
        Me.Controls.Add(Me.storeNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.storeWebsiteTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "storeInfoDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Store Information"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents storeWebsiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents storeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents addr1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents addr1Label As System.Windows.Forms.Label
    Friend WithEvents addr2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents addr2Label As System.Windows.Forms.Label
    Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cityLabel As System.Windows.Forms.Label
    Friend WithEvents stateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents stateLabel As System.Windows.Forms.Label
    Friend WithEvents postalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents postalCodeLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents phoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents phoneNumberLabel As System.Windows.Forms.Label

End Class
