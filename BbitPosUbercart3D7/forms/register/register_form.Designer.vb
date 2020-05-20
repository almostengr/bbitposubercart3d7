<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register_form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register_form))
        Me.enterSKUTextBox = New System.Windows.Forms.TextBox()
        Me.regStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.regOrderListBox = New System.Windows.Forms.ListBox()
        Me.regDiscountButton = New System.Windows.Forms.Button()
        Me.regVoidButton = New System.Windows.Forms.Button()
        Me.regAttachCustButton = New System.Windows.Forms.Button()
        Me.regNum1Button = New System.Windows.Forms.Button()
        Me.regNum2Button = New System.Windows.Forms.Button()
        Me.regNum3Button = New System.Windows.Forms.Button()
        Me.regNum4Button = New System.Windows.Forms.Button()
        Me.regNum5Button = New System.Windows.Forms.Button()
        Me.regNum6Button = New System.Windows.Forms.Button()
        Me.regNum9Button = New System.Windows.Forms.Button()
        Me.regNum8Button = New System.Windows.Forms.Button()
        Me.regNum7Button = New System.Windows.Forms.Button()
        Me.regNum0Button = New System.Windows.Forms.Button()
        Me.regAddProductButton = New System.Windows.Forms.Button()
        Me.regCustTextBox = New System.Windows.Forms.TextBox()
        Me.itemTextBox = New System.Windows.Forms.TextBox()
        Me.regAdjPriceButton = New System.Windows.Forms.Button()
        Me.adjTaxButton = New System.Windows.Forms.Button()
        Me.regNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.regBkspButton = New System.Windows.Forms.Button()
        Me.regTimer = New System.Windows.Forms.Timer(Me.components)
        Me.regSubtotalLabel = New System.Windows.Forms.Label()
        Me.regTaxLabel = New System.Windows.Forms.Label()
        Me.regPayButton = New System.Windows.Forms.Button()
        Me.regSubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.regTaxTextBox = New System.Windows.Forms.TextBox()
        Me.regMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateFTPSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateStoreInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateLocalProductDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunEndOfBusinessDayProcessingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeAdministratorPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutBBITPOSForUbercart3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.regTimeTextBox = New System.Windows.Forms.TextBox()
        Me.statusTextBox = New System.Windows.Forms.TextBox()
        Me.regIdTextBox = New System.Windows.Forms.TextBox()
        Me.regTotalTextBox = New System.Windows.Forms.TextBox()
        Me.regQtyTextBox = New System.Windows.Forms.TextBox()
        Me.regQtyLabel = New System.Windows.Forms.Label()
        Me.regEnterSkuLabel = New System.Windows.Forms.Label()
        Me.OnlineHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.regMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'enterSKUTextBox
        '
        Me.enterSKUTextBox.AllowDrop = True
        Me.enterSKUTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.enterSKUTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterSKUTextBox.Location = New System.Drawing.Point(558, 99)
        Me.enterSKUTextBox.MaxLength = 25
        Me.enterSKUTextBox.Name = "enterSKUTextBox"
        Me.enterSKUTextBox.Size = New System.Drawing.Size(146, 26)
        Me.enterSKUTextBox.TabIndex = 7
        Me.enterSKUTextBox.Text = "Enter SKU"
        Me.enterSKUTextBox.WordWrap = False
        '
        'regStatusStrip
        '
        Me.regStatusStrip.Location = New System.Drawing.Point(0, 666)
        Me.regStatusStrip.Name = "regStatusStrip"
        Me.regStatusStrip.Size = New System.Drawing.Size(792, 22)
        Me.regStatusStrip.SizingGrip = False
        Me.regStatusStrip.TabIndex = 17
        Me.regStatusStrip.Text = "StatusStrip1"
        '
        'regOrderListBox
        '
        Me.regOrderListBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regOrderListBox.FormattingEnabled = True
        Me.regOrderListBox.Location = New System.Drawing.Point(268, 72)
        Me.regOrderListBox.Name = "regOrderListBox"
        Me.regOrderListBox.ScrollAlwaysVisible = True
        Me.regOrderListBox.Size = New System.Drawing.Size(284, 589)
        Me.regOrderListBox.TabIndex = 1
        '
        'regDiscountButton
        '
        Me.regDiscountButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regDiscountButton.BackColor = System.Drawing.Color.Yellow
        Me.regDiscountButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regDiscountButton.Location = New System.Drawing.Point(182, 158)
        Me.regDiscountButton.Name = "regDiscountButton"
        Me.regDiscountButton.Size = New System.Drawing.Size(80, 80)
        Me.regDiscountButton.TabIndex = 4
        Me.regDiscountButton.Text = "Item Discount"
        Me.regDiscountButton.UseVisualStyleBackColor = False
        '
        'regVoidButton
        '
        Me.regVoidButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regVoidButton.BackColor = System.Drawing.Color.Yellow
        Me.regVoidButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regVoidButton.Location = New System.Drawing.Point(182, 72)
        Me.regVoidButton.Name = "regVoidButton"
        Me.regVoidButton.Size = New System.Drawing.Size(80, 80)
        Me.regVoidButton.TabIndex = 3
        Me.regVoidButton.Text = "Void Item"
        Me.regVoidButton.UseVisualStyleBackColor = False
        '
        'regAttachCustButton
        '
        Me.regAttachCustButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regAttachCustButton.BackColor = System.Drawing.Color.Aqua
        Me.regAttachCustButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regAttachCustButton.ForeColor = System.Drawing.Color.Black
        Me.regAttachCustButton.Location = New System.Drawing.Point(12, 72)
        Me.regAttachCustButton.Name = "regAttachCustButton"
        Me.regAttachCustButton.Size = New System.Drawing.Size(80, 80)
        Me.regAttachCustButton.TabIndex = 2
        Me.regAttachCustButton.Text = "Attach Cust"
        Me.regAttachCustButton.UseVisualStyleBackColor = False
        '
        'regNum1Button
        '
        Me.regNum1Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regNum1Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum1Button.ForeColor = System.Drawing.Color.White
        Me.regNum1Button.Location = New System.Drawing.Point(558, 131)
        Me.regNum1Button.Name = "regNum1Button"
        Me.regNum1Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum1Button.TabIndex = 23
        Me.regNum1Button.Text = "1"
        Me.regNum1Button.UseVisualStyleBackColor = False
        '
        'regNum2Button
        '
        Me.regNum2Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regNum2Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum2Button.ForeColor = System.Drawing.Color.White
        Me.regNum2Button.Location = New System.Drawing.Point(634, 131)
        Me.regNum2Button.Name = "regNum2Button"
        Me.regNum2Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum2Button.TabIndex = 24
        Me.regNum2Button.Text = "2"
        Me.regNum2Button.UseVisualStyleBackColor = False
        '
        'regNum3Button
        '
        Me.regNum3Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regNum3Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum3Button.ForeColor = System.Drawing.Color.White
        Me.regNum3Button.Location = New System.Drawing.Point(710, 131)
        Me.regNum3Button.Name = "regNum3Button"
        Me.regNum3Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum3Button.TabIndex = 25
        Me.regNum3Button.Text = "3"
        Me.regNum3Button.UseVisualStyleBackColor = False
        '
        'regNum4Button
        '
        Me.regNum4Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regNum4Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum4Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum4Button.ForeColor = System.Drawing.Color.White
        Me.regNum4Button.Location = New System.Drawing.Point(558, 207)
        Me.regNum4Button.Name = "regNum4Button"
        Me.regNum4Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum4Button.TabIndex = 26
        Me.regNum4Button.Text = "4"
        Me.regNum4Button.UseVisualStyleBackColor = False
        '
        'regNum5Button
        '
        Me.regNum5Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regNum5Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum5Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum5Button.ForeColor = System.Drawing.Color.White
        Me.regNum5Button.Location = New System.Drawing.Point(634, 207)
        Me.regNum5Button.Name = "regNum5Button"
        Me.regNum5Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum5Button.TabIndex = 27
        Me.regNum5Button.Text = "5"
        Me.regNum5Button.UseVisualStyleBackColor = False
        '
        'regNum6Button
        '
        Me.regNum6Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regNum6Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum6Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum6Button.ForeColor = System.Drawing.Color.White
        Me.regNum6Button.Location = New System.Drawing.Point(710, 207)
        Me.regNum6Button.Name = "regNum6Button"
        Me.regNum6Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum6Button.TabIndex = 28
        Me.regNum6Button.Text = "6"
        Me.regNum6Button.UseVisualStyleBackColor = False
        '
        'regNum9Button
        '
        Me.regNum9Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regNum9Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum9Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum9Button.ForeColor = System.Drawing.Color.White
        Me.regNum9Button.Location = New System.Drawing.Point(710, 283)
        Me.regNum9Button.Name = "regNum9Button"
        Me.regNum9Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum9Button.TabIndex = 31
        Me.regNum9Button.Text = "9"
        Me.regNum9Button.UseVisualStyleBackColor = False
        '
        'regNum8Button
        '
        Me.regNum8Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regNum8Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum8Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum8Button.ForeColor = System.Drawing.Color.White
        Me.regNum8Button.Location = New System.Drawing.Point(634, 283)
        Me.regNum8Button.Name = "regNum8Button"
        Me.regNum8Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum8Button.TabIndex = 30
        Me.regNum8Button.Text = "8"
        Me.regNum8Button.UseVisualStyleBackColor = False
        '
        'regNum7Button
        '
        Me.regNum7Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regNum7Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum7Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum7Button.ForeColor = System.Drawing.Color.White
        Me.regNum7Button.Location = New System.Drawing.Point(558, 283)
        Me.regNum7Button.Name = "regNum7Button"
        Me.regNum7Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum7Button.TabIndex = 29
        Me.regNum7Button.Text = "7"
        Me.regNum7Button.UseVisualStyleBackColor = False
        '
        'regNum0Button
        '
        Me.regNum0Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regNum0Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum0Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum0Button.ForeColor = System.Drawing.Color.White
        Me.regNum0Button.Location = New System.Drawing.Point(634, 359)
        Me.regNum0Button.Name = "regNum0Button"
        Me.regNum0Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum0Button.TabIndex = 32
        Me.regNum0Button.Text = "0"
        Me.regNum0Button.UseVisualStyleBackColor = False
        '
        'regAddProductButton
        '
        Me.regAddProductButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regAddProductButton.BackColor = System.Drawing.Color.Maroon
        Me.regAddProductButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regAddProductButton.ForeColor = System.Drawing.Color.White
        Me.regAddProductButton.Location = New System.Drawing.Point(710, 359)
        Me.regAddProductButton.Name = "regAddProductButton"
        Me.regAddProductButton.Size = New System.Drawing.Size(70, 70)
        Me.regAddProductButton.TabIndex = 33
        Me.regAddProductButton.Text = "Add Item"
        Me.regAddProductButton.UseVisualStyleBackColor = False
        '
        'regCustTextBox
        '
        Me.regCustTextBox.AllowDrop = True
        Me.regCustTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regCustTextBox.BackColor = System.Drawing.Color.Black
        Me.regCustTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regCustTextBox.ForeColor = System.Drawing.Color.Aqua
        Me.regCustTextBox.Location = New System.Drawing.Point(12, 29)
        Me.regCustTextBox.MaxLength = 25
        Me.regCustTextBox.Multiline = True
        Me.regCustTextBox.Name = "regCustTextBox"
        Me.regCustTextBox.ReadOnly = True
        Me.regCustTextBox.Size = New System.Drawing.Size(166, 39)
        Me.regCustTextBox.TabIndex = 39
        Me.regCustTextBox.Text = "Walk-In Customer"
        Me.regCustTextBox.WordWrap = False
        '
        'itemTextBox
        '
        Me.itemTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.itemTextBox.BackColor = System.Drawing.Color.Black
        Me.itemTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.itemTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemTextBox.ForeColor = System.Drawing.Color.Yellow
        Me.itemTextBox.Location = New System.Drawing.Point(184, 29)
        Me.itemTextBox.Multiline = True
        Me.itemTextBox.Name = "itemTextBox"
        Me.itemTextBox.ReadOnly = True
        Me.itemTextBox.ShortcutsEnabled = False
        Me.itemTextBox.Size = New System.Drawing.Size(601, 39)
        Me.itemTextBox.TabIndex = 40
        Me.itemTextBox.Text = "ITEM NAME, PRICE, QTY, LINE TOTAL"
        Me.itemTextBox.WordWrap = False
        '
        'regAdjPriceButton
        '
        Me.regAdjPriceButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regAdjPriceButton.BackColor = System.Drawing.Color.Yellow
        Me.regAdjPriceButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regAdjPriceButton.Location = New System.Drawing.Point(182, 242)
        Me.regAdjPriceButton.Name = "regAdjPriceButton"
        Me.regAdjPriceButton.Size = New System.Drawing.Size(80, 80)
        Me.regAdjPriceButton.TabIndex = 42
        Me.regAdjPriceButton.Text = "Adj. Price"
        Me.regAdjPriceButton.UseVisualStyleBackColor = False
        '
        'adjTaxButton
        '
        Me.adjTaxButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.adjTaxButton.BackColor = System.Drawing.Color.Yellow
        Me.adjTaxButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjTaxButton.Location = New System.Drawing.Point(182, 328)
        Me.adjTaxButton.Name = "adjTaxButton"
        Me.adjTaxButton.Size = New System.Drawing.Size(80, 80)
        Me.adjTaxButton.TabIndex = 43
        Me.adjTaxButton.Text = "Adj. Sales Tax"
        Me.adjTaxButton.UseVisualStyleBackColor = False
        '
        'regNotifyIcon
        '
        Me.regNotifyIcon.Icon = CType(resources.GetObject("regNotifyIcon.Icon"), System.Drawing.Icon)
        Me.regNotifyIcon.Text = "BBIT POS for Ubercart 3"
        '
        'regBkspButton
        '
        Me.regBkspButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regBkspButton.BackColor = System.Drawing.Color.Maroon
        Me.regBkspButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regBkspButton.ForeColor = System.Drawing.Color.White
        Me.regBkspButton.Location = New System.Drawing.Point(558, 359)
        Me.regBkspButton.Name = "regBkspButton"
        Me.regBkspButton.Size = New System.Drawing.Size(70, 70)
        Me.regBkspButton.TabIndex = 45
        Me.regBkspButton.Text = "Clear"
        Me.regBkspButton.UseVisualStyleBackColor = False
        '
        'regTimer
        '
        Me.regTimer.Enabled = True
        Me.regTimer.Interval = 1000
        '
        'regSubtotalLabel
        '
        Me.regSubtotalLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regSubtotalLabel.AutoSize = True
        Me.regSubtotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regSubtotalLabel.Location = New System.Drawing.Point(556, 480)
        Me.regSubtotalLabel.Name = "regSubtotalLabel"
        Me.regSubtotalLabel.Size = New System.Drawing.Size(77, 24)
        Me.regSubtotalLabel.TabIndex = 46
        Me.regSubtotalLabel.Text = "Subtotal"
        '
        'regTaxLabel
        '
        Me.regTaxLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regTaxLabel.AutoSize = True
        Me.regTaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regTaxLabel.Location = New System.Drawing.Point(556, 505)
        Me.regTaxLabel.Name = "regTaxLabel"
        Me.regTaxLabel.Size = New System.Drawing.Size(42, 24)
        Me.regTaxLabel.TabIndex = 47
        Me.regTaxLabel.Text = "Tax"
        '
        'regPayButton
        '
        Me.regPayButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regPayButton.BackColor = System.Drawing.Color.DarkGreen
        Me.regPayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regPayButton.ForeColor = System.Drawing.Color.White
        Me.regPayButton.Location = New System.Drawing.Point(558, 581)
        Me.regPayButton.Name = "regPayButton"
        Me.regPayButton.Size = New System.Drawing.Size(222, 80)
        Me.regPayButton.TabIndex = 49
        Me.regPayButton.Text = "Pay"
        Me.regPayButton.UseVisualStyleBackColor = False
        '
        'regSubtotalTextBox
        '
        Me.regSubtotalTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regSubtotalTextBox.BackColor = System.Drawing.Color.Black
        Me.regSubtotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regSubtotalTextBox.ForeColor = System.Drawing.Color.LimeGreen
        Me.regSubtotalTextBox.Location = New System.Drawing.Point(639, 480)
        Me.regSubtotalTextBox.Name = "regSubtotalTextBox"
        Me.regSubtotalTextBox.ReadOnly = True
        Me.regSubtotalTextBox.Size = New System.Drawing.Size(141, 26)
        Me.regSubtotalTextBox.TabIndex = 50
        Me.regSubtotalTextBox.Text = "$000000.00"
        Me.regSubtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'regTaxTextBox
        '
        Me.regTaxTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regTaxTextBox.BackColor = System.Drawing.Color.Black
        Me.regTaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regTaxTextBox.ForeColor = System.Drawing.Color.LimeGreen
        Me.regTaxTextBox.Location = New System.Drawing.Point(639, 505)
        Me.regTaxTextBox.Name = "regTaxTextBox"
        Me.regTaxTextBox.ReadOnly = True
        Me.regTaxTextBox.Size = New System.Drawing.Size(141, 26)
        Me.regTaxTextBox.TabIndex = 51
        Me.regTaxTextBox.Text = "$000000.00"
        Me.regTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'regMenuStrip
        '
        Me.regMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.regMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.regMenuStrip.Name = "regMenuStrip"
        Me.regMenuStrip.Size = New System.Drawing.Size(792, 24)
        Me.regMenuStrip.TabIndex = 53
        Me.regMenuStrip.Text = "regMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateFTPSettingsToolStripMenuItem, Me.UpdateStoreInformationToolStripMenuItem, Me.UpdateLocalProductDatabaseToolStripMenuItem, Me.RunEndOfBusinessDayProcessingToolStripMenuItem, Me.ChangeAdministratorPasswordToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'UpdateFTPSettingsToolStripMenuItem
        '
        Me.UpdateFTPSettingsToolStripMenuItem.Name = "UpdateFTPSettingsToolStripMenuItem"
        Me.UpdateFTPSettingsToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.UpdateFTPSettingsToolStripMenuItem.Text = "Update SFTP Settings"
        '
        'UpdateStoreInformationToolStripMenuItem
        '
        Me.UpdateStoreInformationToolStripMenuItem.Name = "UpdateStoreInformationToolStripMenuItem"
        Me.UpdateStoreInformationToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.UpdateStoreInformationToolStripMenuItem.Text = "Update Store Information"
        '
        'UpdateLocalProductDatabaseToolStripMenuItem
        '
        Me.UpdateLocalProductDatabaseToolStripMenuItem.Name = "UpdateLocalProductDatabaseToolStripMenuItem"
        Me.UpdateLocalProductDatabaseToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.UpdateLocalProductDatabaseToolStripMenuItem.Text = "Update Local Product Database"
        '
        'RunEndOfBusinessDayProcessingToolStripMenuItem
        '
        Me.RunEndOfBusinessDayProcessingToolStripMenuItem.Name = "RunEndOfBusinessDayProcessingToolStripMenuItem"
        Me.RunEndOfBusinessDayProcessingToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.RunEndOfBusinessDayProcessingToolStripMenuItem.Text = "Run End of Business Day Processing"
        '
        'ChangeAdministratorPasswordToolStripMenuItem
        '
        Me.ChangeAdministratorPasswordToolStripMenuItem.Name = "ChangeAdministratorPasswordToolStripMenuItem"
        Me.ChangeAdministratorPasswordToolStripMenuItem.Size = New System.Drawing.Size(258, 22)
        Me.ChangeAdministratorPasswordToolStripMenuItem.Text = "Change Administrator Password"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineHelpToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutBBITPOSForUbercart3ToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutBBITPOSForUbercart3ToolStripMenuItem
        '
        Me.AboutBBITPOSForUbercart3ToolStripMenuItem.Name = "AboutBBITPOSForUbercart3ToolStripMenuItem"
        Me.AboutBBITPOSForUbercart3ToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.AboutBBITPOSForUbercart3ToolStripMenuItem.Text = "About BBIT POS for Ubercart 3"
        '
        'regTimeTextBox
        '
        Me.regTimeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.regTimeTextBox.Location = New System.Drawing.Point(0, 668)
        Me.regTimeTextBox.Name = "regTimeTextBox"
        Me.regTimeTextBox.ReadOnly = True
        Me.regTimeTextBox.Size = New System.Drawing.Size(137, 20)
        Me.regTimeTextBox.TabIndex = 54
        Me.regTimeTextBox.Text = "00/00/0000 00:00:00 PM"
        Me.regTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'statusTextBox
        '
        Me.statusTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.statusTextBox.Location = New System.Drawing.Point(143, 668)
        Me.statusTextBox.Name = "statusTextBox"
        Me.statusTextBox.ReadOnly = True
        Me.statusTextBox.Size = New System.Drawing.Size(235, 20)
        Me.statusTextBox.TabIndex = 55
        Me.statusTextBox.Text = "Starting up..."
        '
        'regIdTextBox
        '
        Me.regIdTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.regIdTextBox.Location = New System.Drawing.Point(691, 668)
        Me.regIdTextBox.Name = "regIdTextBox"
        Me.regIdTextBox.ReadOnly = True
        Me.regIdTextBox.Size = New System.Drawing.Size(94, 20)
        Me.regIdTextBox.TabIndex = 56
        Me.regIdTextBox.TabStop = False
        Me.regIdTextBox.Text = "Reg 01"
        Me.regIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'regTotalTextBox
        '
        Me.regTotalTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regTotalTextBox.BackColor = System.Drawing.Color.Black
        Me.regTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regTotalTextBox.ForeColor = System.Drawing.Color.LimeGreen
        Me.regTotalTextBox.Location = New System.Drawing.Point(558, 537)
        Me.regTotalTextBox.Name = "regTotalTextBox"
        Me.regTotalTextBox.ReadOnly = True
        Me.regTotalTextBox.Size = New System.Drawing.Size(222, 38)
        Me.regTotalTextBox.TabIndex = 44
        Me.regTotalTextBox.Text = "$000000.00"
        Me.regTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'regQtyTextBox
        '
        Me.regQtyTextBox.AllowDrop = True
        Me.regQtyTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regQtyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regQtyTextBox.Location = New System.Drawing.Point(710, 99)
        Me.regQtyTextBox.MaxLength = 25
        Me.regQtyTextBox.Name = "regQtyTextBox"
        Me.regQtyTextBox.ReadOnly = True
        Me.regQtyTextBox.Size = New System.Drawing.Size(70, 26)
        Me.regQtyTextBox.TabIndex = 57
        Me.regQtyTextBox.Text = "1"
        Me.regQtyTextBox.WordWrap = False
        '
        'regQtyLabel
        '
        Me.regQtyLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regQtyLabel.AutoSize = True
        Me.regQtyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regQtyLabel.Location = New System.Drawing.Point(730, 72)
        Me.regQtyLabel.Name = "regQtyLabel"
        Me.regQtyLabel.Size = New System.Drawing.Size(38, 24)
        Me.regQtyLabel.TabIndex = 58
        Me.regQtyLabel.Text = "Qty"
        '
        'regEnterSkuLabel
        '
        Me.regEnterSkuLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.regEnterSkuLabel.AutoSize = True
        Me.regEnterSkuLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regEnterSkuLabel.Location = New System.Drawing.Point(587, 72)
        Me.regEnterSkuLabel.Name = "regEnterSkuLabel"
        Me.regEnterSkuLabel.Size = New System.Drawing.Size(97, 24)
        Me.regEnterSkuLabel.TabIndex = 59
        Me.regEnterSkuLabel.Text = "Enter SKU"
        '
        'OnlineHelpToolStripMenuItem
        '
        Me.OnlineHelpToolStripMenuItem.Name = "OnlineHelpToolStripMenuItem"
        Me.OnlineHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.OnlineHelpToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.OnlineHelpToolStripMenuItem.Text = "Online Help"
        Me.OnlineHelpToolStripMenuItem.ToolTipText = "Get online help for BBIT POS for Ubercart 3."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(230, 6)
        '
        'register_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 688)
        Me.Controls.Add(Me.regEnterSkuLabel)
        Me.Controls.Add(Me.regQtyLabel)
        Me.Controls.Add(Me.regQtyTextBox)
        Me.Controls.Add(Me.regIdTextBox)
        Me.Controls.Add(Me.statusTextBox)
        Me.Controls.Add(Me.regTimeTextBox)
        Me.Controls.Add(Me.regTaxTextBox)
        Me.Controls.Add(Me.regSubtotalTextBox)
        Me.Controls.Add(Me.regSubtotalLabel)
        Me.Controls.Add(Me.regTaxLabel)
        Me.Controls.Add(Me.regPayButton)
        Me.Controls.Add(Me.regBkspButton)
        Me.Controls.Add(Me.regTotalTextBox)
        Me.Controls.Add(Me.adjTaxButton)
        Me.Controls.Add(Me.regAdjPriceButton)
        Me.Controls.Add(Me.itemTextBox)
        Me.Controls.Add(Me.regCustTextBox)
        Me.Controls.Add(Me.regAddProductButton)
        Me.Controls.Add(Me.regNum0Button)
        Me.Controls.Add(Me.regNum9Button)
        Me.Controls.Add(Me.regNum8Button)
        Me.Controls.Add(Me.regNum7Button)
        Me.Controls.Add(Me.regNum6Button)
        Me.Controls.Add(Me.regNum5Button)
        Me.Controls.Add(Me.regNum4Button)
        Me.Controls.Add(Me.regNum3Button)
        Me.Controls.Add(Me.regNum2Button)
        Me.Controls.Add(Me.regNum1Button)
        Me.Controls.Add(Me.regAttachCustButton)
        Me.Controls.Add(Me.regVoidButton)
        Me.Controls.Add(Me.regDiscountButton)
        Me.Controls.Add(Me.regStatusStrip)
        Me.Controls.Add(Me.regMenuStrip)
        Me.Controls.Add(Me.enterSKUTextBox)
        Me.Controls.Add(Me.regOrderListBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.regMenuStrip
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "register_form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "BBIT POS for Ubercart 3"
        Me.regMenuStrip.ResumeLayout(False)
        Me.regMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents enterSKUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents regStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents regOrderListBox As System.Windows.Forms.ListBox
    Friend WithEvents regDiscountButton As System.Windows.Forms.Button
    Friend WithEvents regVoidButton As System.Windows.Forms.Button
    Friend WithEvents regAttachCustButton As System.Windows.Forms.Button
    Friend WithEvents regNum1Button As System.Windows.Forms.Button
    Friend WithEvents regNum2Button As System.Windows.Forms.Button
    Friend WithEvents regNum3Button As System.Windows.Forms.Button
    Friend WithEvents regNum4Button As System.Windows.Forms.Button
    Friend WithEvents regNum5Button As System.Windows.Forms.Button
    Friend WithEvents regNum6Button As System.Windows.Forms.Button
    Friend WithEvents regNum9Button As System.Windows.Forms.Button
    Friend WithEvents regNum8Button As System.Windows.Forms.Button
    Friend WithEvents regNum7Button As System.Windows.Forms.Button
    Friend WithEvents regNum0Button As System.Windows.Forms.Button
    Friend WithEvents regAddProductButton As System.Windows.Forms.Button
    Friend WithEvents regCustTextBox As System.Windows.Forms.TextBox
    Friend WithEvents itemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents regAdjPriceButton As System.Windows.Forms.Button
    Friend WithEvents adjTaxButton As System.Windows.Forms.Button
    Friend WithEvents regNotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents regBkspButton As System.Windows.Forms.Button
    Friend WithEvents regTimer As System.Windows.Forms.Timer
    Friend WithEvents regSubtotalLabel As System.Windows.Forms.Label
    Friend WithEvents regTaxLabel As System.Windows.Forms.Label
    Friend WithEvents regPayButton As System.Windows.Forms.Button
    Friend WithEvents regSubtotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents regTaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents regMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutBBITPOSForUbercart3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents regTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents statusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents regIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateFTPSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateStoreInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateLocalProductDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunEndOfBusinessDayProcessingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents regTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents regQtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents regQtyLabel As System.Windows.Forms.Label
    Friend WithEvents regEnterSkuLabel As System.Windows.Forms.Label
    Friend WithEvents ChangeAdministratorPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
