<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerForm))
        Me.customerDisplayTextBox = New System.Windows.Forms.TextBox()
        Me.discountButton = New System.Windows.Forms.Button()
        Me.voidButton = New System.Windows.Forms.Button()
        Me.adjPriceButton = New System.Windows.Forms.Button()
        Me.adjTaxButton = New System.Windows.Forms.Button()
        Me.adjQtyButton = New System.Windows.Forms.Button()
        Me.itemTextBox = New System.Windows.Forms.TextBox()
        Me.regNum1Button = New System.Windows.Forms.Button()
        Me.regNum2Button = New System.Windows.Forms.Button()
        Me.regNum3Button = New System.Windows.Forms.Button()
        Me.regNum4Button = New System.Windows.Forms.Button()
        Me.regNum5Button = New System.Windows.Forms.Button()
        Me.regNum6Button = New System.Windows.Forms.Button()
        Me.regNum7Button = New System.Windows.Forms.Button()
        Me.regNum8Button = New System.Windows.Forms.Button()
        Me.regNum9Button = New System.Windows.Forms.Button()
        Me.regNum0Button = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.netStatusToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.regTimeToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.machineToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.regTabControl = New System.Windows.Forms.TabControl()
        Me.browseItems = New System.Windows.Forms.TabPage()
        Me.productsViewAllButton = New System.Windows.Forms.Button()
        Me.customers = New System.Windows.Forms.TabPage()
        Me.customersViewAllButton = New System.Windows.Forms.Button()
        Me.checkout = New System.Windows.Forms.TabPage()
        Me.amtTenderGroupBox = New System.Windows.Forms.GroupBox()
        Me.amountsTenderedLabel = New System.Windows.Forms.Label()
        Me.amt5Button = New System.Windows.Forms.Button()
        Me.amt10Button = New System.Windows.Forms.Button()
        Me.discountsLabel = New System.Windows.Forms.Label()
        Me.taxLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.subtotalLabel = New System.Windows.Forms.Label()
        Me.amtCurButton = New System.Windows.Forms.Button()
        Me.amt20Button = New System.Windows.Forms.Button()
        Me.discountsTextBox = New System.Windows.Forms.TextBox()
        Me.subtotalTextBox = New System.Windows.Forms.TextBox()
        Me.taxTextBox = New System.Windows.Forms.TextBox()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.coCheckButton = New System.Windows.Forms.Button()
        Me.coCashButton = New System.Windows.Forms.Button()
        Me.coCreditButton = New System.Windows.Forms.Button()
        Me.coStoreCreditButton = New System.Windows.Forms.Button()
        Me.totalLargeTextBox = New System.Windows.Forms.TextBox()
        Me.percentButton = New System.Windows.Forms.Button()
        Me.regNumDecButton = New System.Windows.Forms.Button()
        Me.orderListBox = New System.Windows.Forms.ListBox()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.keypadTextBox = New System.Windows.Forms.TextBox()
        Me.clearOrderButton = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.regTabControl.SuspendLayout()
        Me.browseItems.SuspendLayout()
        Me.customers.SuspendLayout()
        Me.checkout.SuspendLayout()
        Me.amtTenderGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'customerDisplayTextBox
        '
        Me.customerDisplayTextBox.AllowDrop = True
        Me.customerDisplayTextBox.BackColor = System.Drawing.Color.Black
        Me.customerDisplayTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerDisplayTextBox.ForeColor = System.Drawing.Color.Aqua
        Me.customerDisplayTextBox.Location = New System.Drawing.Point(12, 12)
        Me.customerDisplayTextBox.MaxLength = 25
        Me.customerDisplayTextBox.Name = "customerDisplayTextBox"
        Me.customerDisplayTextBox.ReadOnly = True
        Me.customerDisplayTextBox.Size = New System.Drawing.Size(305, 26)
        Me.customerDisplayTextBox.TabIndex = 39
        Me.customerDisplayTextBox.Text = "Store Customer"
        Me.customerDisplayTextBox.WordWrap = False
        '
        'discountButton
        '
        Me.discountButton.BackColor = System.Drawing.Color.OrangeRed
        Me.discountButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.discountButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountButton.Location = New System.Drawing.Point(406, 427)
        Me.discountButton.Name = "discountButton"
        Me.discountButton.Size = New System.Drawing.Size(70, 70)
        Me.discountButton.TabIndex = 4
        Me.discountButton.Text = "Product Disc"
        Me.discountButton.UseVisualStyleBackColor = False
        '
        'voidButton
        '
        Me.voidButton.BackColor = System.Drawing.Color.Yellow
        Me.voidButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.voidButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voidButton.Location = New System.Drawing.Point(406, 501)
        Me.voidButton.Name = "voidButton"
        Me.voidButton.Size = New System.Drawing.Size(70, 70)
        Me.voidButton.TabIndex = 3
        Me.voidButton.Text = "Void Product"
        Me.voidButton.UseVisualStyleBackColor = False
        '
        'adjPriceButton
        '
        Me.adjPriceButton.BackColor = System.Drawing.Color.Yellow
        Me.adjPriceButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adjPriceButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjPriceButton.Location = New System.Drawing.Point(330, 427)
        Me.adjPriceButton.Name = "adjPriceButton"
        Me.adjPriceButton.Size = New System.Drawing.Size(70, 70)
        Me.adjPriceButton.TabIndex = 42
        Me.adjPriceButton.Text = "Change Price"
        Me.adjPriceButton.UseVisualStyleBackColor = False
        '
        'adjTaxButton
        '
        Me.adjTaxButton.BackColor = System.Drawing.Color.Yellow
        Me.adjTaxButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adjTaxButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjTaxButton.Location = New System.Drawing.Point(330, 577)
        Me.adjTaxButton.Name = "adjTaxButton"
        Me.adjTaxButton.Size = New System.Drawing.Size(70, 70)
        Me.adjTaxButton.TabIndex = 43
        Me.adjTaxButton.Text = "Change Tax"
        Me.adjTaxButton.UseVisualStyleBackColor = False
        '
        'adjQtyButton
        '
        Me.adjQtyButton.BackColor = System.Drawing.Color.Yellow
        Me.adjQtyButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adjQtyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adjQtyButton.Location = New System.Drawing.Point(330, 501)
        Me.adjQtyButton.Name = "adjQtyButton"
        Me.adjQtyButton.Size = New System.Drawing.Size(70, 70)
        Me.adjQtyButton.TabIndex = 64
        Me.adjQtyButton.Text = "Change Qty"
        Me.adjQtyButton.UseVisualStyleBackColor = False
        '
        'itemTextBox
        '
        Me.itemTextBox.BackColor = System.Drawing.Color.Black
        Me.itemTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemTextBox.ForeColor = System.Drawing.Color.Yellow
        Me.itemTextBox.Location = New System.Drawing.Point(12, 44)
        Me.itemTextBox.Multiline = True
        Me.itemTextBox.Name = "itemTextBox"
        Me.itemTextBox.ReadOnly = True
        Me.itemTextBox.ShortcutsEnabled = False
        Me.itemTextBox.Size = New System.Drawing.Size(305, 55)
        Me.itemTextBox.TabIndex = 40
        Me.itemTextBox.Text = "Item Name ""\r\n"" Price"
        Me.itemTextBox.WordWrap = False
        '
        'regNum1Button
        '
        Me.regNum1Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum1Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regNum1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum1Button.ForeColor = System.Drawing.Color.White
        Me.regNum1Button.Location = New System.Drawing.Point(482, 503)
        Me.regNum1Button.Name = "regNum1Button"
        Me.regNum1Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum1Button.TabIndex = 23
        Me.regNum1Button.Text = "1"
        Me.regNum1Button.UseVisualStyleBackColor = False
        '
        'regNum2Button
        '
        Me.regNum2Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum2Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regNum2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum2Button.ForeColor = System.Drawing.Color.White
        Me.regNum2Button.Location = New System.Drawing.Point(558, 503)
        Me.regNum2Button.Name = "regNum2Button"
        Me.regNum2Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum2Button.TabIndex = 24
        Me.regNum2Button.Text = "2"
        Me.regNum2Button.UseVisualStyleBackColor = False
        '
        'regNum3Button
        '
        Me.regNum3Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum3Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regNum3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum3Button.ForeColor = System.Drawing.Color.White
        Me.regNum3Button.Location = New System.Drawing.Point(634, 503)
        Me.regNum3Button.Name = "regNum3Button"
        Me.regNum3Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum3Button.TabIndex = 25
        Me.regNum3Button.Text = "3"
        Me.regNum3Button.UseVisualStyleBackColor = False
        '
        'regNum4Button
        '
        Me.regNum4Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum4Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regNum4Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum4Button.ForeColor = System.Drawing.Color.White
        Me.regNum4Button.Location = New System.Drawing.Point(482, 427)
        Me.regNum4Button.Name = "regNum4Button"
        Me.regNum4Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum4Button.TabIndex = 26
        Me.regNum4Button.Text = "4"
        Me.regNum4Button.UseVisualStyleBackColor = False
        '
        'regNum5Button
        '
        Me.regNum5Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum5Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regNum5Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum5Button.ForeColor = System.Drawing.Color.White
        Me.regNum5Button.Location = New System.Drawing.Point(558, 427)
        Me.regNum5Button.Name = "regNum5Button"
        Me.regNum5Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum5Button.TabIndex = 27
        Me.regNum5Button.Text = "5"
        Me.regNum5Button.UseVisualStyleBackColor = False
        '
        'regNum6Button
        '
        Me.regNum6Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum6Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regNum6Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum6Button.ForeColor = System.Drawing.Color.White
        Me.regNum6Button.Location = New System.Drawing.Point(634, 427)
        Me.regNum6Button.Name = "regNum6Button"
        Me.regNum6Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum6Button.TabIndex = 28
        Me.regNum6Button.Text = "6"
        Me.regNum6Button.UseVisualStyleBackColor = False
        '
        'regNum7Button
        '
        Me.regNum7Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum7Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regNum7Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum7Button.ForeColor = System.Drawing.Color.White
        Me.regNum7Button.Location = New System.Drawing.Point(482, 351)
        Me.regNum7Button.Name = "regNum7Button"
        Me.regNum7Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum7Button.TabIndex = 29
        Me.regNum7Button.Text = "7"
        Me.regNum7Button.UseVisualStyleBackColor = False
        '
        'regNum8Button
        '
        Me.regNum8Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum8Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regNum8Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum8Button.ForeColor = System.Drawing.Color.White
        Me.regNum8Button.Location = New System.Drawing.Point(558, 351)
        Me.regNum8Button.Name = "regNum8Button"
        Me.regNum8Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum8Button.TabIndex = 30
        Me.regNum8Button.Text = "8"
        Me.regNum8Button.UseVisualStyleBackColor = False
        '
        'regNum9Button
        '
        Me.regNum9Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum9Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regNum9Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum9Button.ForeColor = System.Drawing.Color.White
        Me.regNum9Button.Location = New System.Drawing.Point(634, 351)
        Me.regNum9Button.Name = "regNum9Button"
        Me.regNum9Button.Size = New System.Drawing.Size(70, 70)
        Me.regNum9Button.TabIndex = 31
        Me.regNum9Button.Text = "9"
        Me.regNum9Button.UseVisualStyleBackColor = False
        '
        'regNum0Button
        '
        Me.regNum0Button.BackColor = System.Drawing.Color.Maroon
        Me.regNum0Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regNum0Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNum0Button.ForeColor = System.Drawing.Color.White
        Me.regNum0Button.Location = New System.Drawing.Point(482, 579)
        Me.regNum0Button.Name = "regNum0Button"
        Me.regNum0Button.Size = New System.Drawing.Size(146, 70)
        Me.regNum0Button.TabIndex = 32
        Me.regNum0Button.Text = "0"
        Me.regNum0Button.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.Maroon
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.ForeColor = System.Drawing.Color.White
        Me.clearButton.Location = New System.Drawing.Point(710, 427)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(70, 70)
        Me.clearButton.TabIndex = 45
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.netStatusToolStripStatusLabel, Me.regTimeToolStripStatusLabel, Me.machineToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 683)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(793, 24)
        Me.StatusStrip.TabIndex = 65
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'netStatusToolStripStatusLabel
        '
        Me.netStatusToolStripStatusLabel.AutoSize = False
        Me.netStatusToolStripStatusLabel.BackColor = System.Drawing.Color.Black
        Me.netStatusToolStripStatusLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.netStatusToolStripStatusLabel.ForeColor = System.Drawing.Color.OrangeRed
        Me.netStatusToolStripStatusLabel.Name = "netStatusToolStripStatusLabel"
        Me.netStatusToolStripStatusLabel.Size = New System.Drawing.Size(50, 19)
        Me.netStatusToolStripStatusLabel.Text = "Offline"
        '
        'regTimeToolStripStatusLabel
        '
        Me.regTimeToolStripStatusLabel.AutoSize = False
        Me.regTimeToolStripStatusLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.regTimeToolStripStatusLabel.Name = "regTimeToolStripStatusLabel"
        Me.regTimeToolStripStatusLabel.Size = New System.Drawing.Size(135, 19)
        Me.regTimeToolStripStatusLabel.Text = "00/00/0000 00:00:00 PM"
        '
        'machineToolStripStatusLabel
        '
        Me.machineToolStripStatusLabel.AutoSize = False
        Me.machineToolStripStatusLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.machineToolStripStatusLabel.Name = "machineToolStripStatusLabel"
        Me.machineToolStripStatusLabel.Size = New System.Drawing.Size(150, 19)
        Me.machineToolStripStatusLabel.Text = "Reg: MACHINE"
        '
        'regTabControl
        '
        Me.regTabControl.Controls.Add(Me.browseItems)
        Me.regTabControl.Controls.Add(Me.customers)
        Me.regTabControl.Controls.Add(Me.checkout)
        Me.regTabControl.ItemSize = New System.Drawing.Size(55, 30)
        Me.regTabControl.Location = New System.Drawing.Point(323, 1)
        Me.regTabControl.Name = "regTabControl"
        Me.regTabControl.SelectedIndex = 0
        Me.regTabControl.Size = New System.Drawing.Size(464, 344)
        Me.regTabControl.TabIndex = 66
        '
        'browseItems
        '
        Me.browseItems.Controls.Add(Me.productsViewAllButton)
        Me.browseItems.Location = New System.Drawing.Point(4, 34)
        Me.browseItems.Name = "browseItems"
        Me.browseItems.Padding = New System.Windows.Forms.Padding(3)
        Me.browseItems.Size = New System.Drawing.Size(456, 306)
        Me.browseItems.TabIndex = 0
        Me.browseItems.Text = "Products"
        Me.browseItems.UseVisualStyleBackColor = True
        '
        'productsViewAllButton
        '
        Me.productsViewAllButton.BackColor = System.Drawing.Color.Yellow
        Me.productsViewAllButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.productsViewAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productsViewAllButton.Location = New System.Drawing.Point(303, 6)
        Me.productsViewAllButton.Name = "productsViewAllButton"
        Me.productsViewAllButton.Size = New System.Drawing.Size(150, 38)
        Me.productsViewAllButton.TabIndex = 74
        Me.productsViewAllButton.Text = "View All"
        Me.productsViewAllButton.UseVisualStyleBackColor = False
        '
        'customers
        '
        Me.customers.Controls.Add(Me.customersViewAllButton)
        Me.customers.Location = New System.Drawing.Point(4, 34)
        Me.customers.Name = "customers"
        Me.customers.Size = New System.Drawing.Size(456, 306)
        Me.customers.TabIndex = 2
        Me.customers.Text = "Customers"
        Me.customers.UseVisualStyleBackColor = True
        '
        'customersViewAllButton
        '
        Me.customersViewAllButton.BackColor = System.Drawing.Color.Yellow
        Me.customersViewAllButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.customersViewAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customersViewAllButton.Location = New System.Drawing.Point(303, 6)
        Me.customersViewAllButton.Name = "customersViewAllButton"
        Me.customersViewAllButton.Size = New System.Drawing.Size(150, 38)
        Me.customersViewAllButton.TabIndex = 75
        Me.customersViewAllButton.Text = "View All"
        Me.customersViewAllButton.UseVisualStyleBackColor = False
        '
        'checkout
        '
        Me.checkout.Controls.Add(Me.amtTenderGroupBox)
        Me.checkout.Controls.Add(Me.amt5Button)
        Me.checkout.Controls.Add(Me.amt10Button)
        Me.checkout.Controls.Add(Me.discountsLabel)
        Me.checkout.Controls.Add(Me.taxLabel)
        Me.checkout.Controls.Add(Me.totalLabel)
        Me.checkout.Controls.Add(Me.subtotalLabel)
        Me.checkout.Controls.Add(Me.amtCurButton)
        Me.checkout.Controls.Add(Me.amt20Button)
        Me.checkout.Controls.Add(Me.discountsTextBox)
        Me.checkout.Controls.Add(Me.subtotalTextBox)
        Me.checkout.Controls.Add(Me.taxTextBox)
        Me.checkout.Controls.Add(Me.totalTextBox)
        Me.checkout.Controls.Add(Me.coCheckButton)
        Me.checkout.Controls.Add(Me.coCashButton)
        Me.checkout.Controls.Add(Me.coCreditButton)
        Me.checkout.Controls.Add(Me.coStoreCreditButton)
        Me.checkout.Location = New System.Drawing.Point(4, 34)
        Me.checkout.Name = "checkout"
        Me.checkout.Padding = New System.Windows.Forms.Padding(3)
        Me.checkout.Size = New System.Drawing.Size(456, 306)
        Me.checkout.TabIndex = 1
        Me.checkout.Text = "Checkout"
        Me.checkout.UseVisualStyleBackColor = True
        '
        'amtTenderGroupBox
        '
        Me.amtTenderGroupBox.Controls.Add(Me.amountsTenderedLabel)
        Me.amtTenderGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtTenderGroupBox.Location = New System.Drawing.Point(7, 131)
        Me.amtTenderGroupBox.Name = "amtTenderGroupBox"
        Me.amtTenderGroupBox.Size = New System.Drawing.Size(197, 169)
        Me.amtTenderGroupBox.TabIndex = 92
        Me.amtTenderGroupBox.TabStop = False
        Me.amtTenderGroupBox.Text = "Amounts Tendered"
        '
        'amountsTenderedLabel
        '
        Me.amountsTenderedLabel.Location = New System.Drawing.Point(6, 12)
        Me.amountsTenderedLabel.Name = "amountsTenderedLabel"
        Me.amountsTenderedLabel.Size = New System.Drawing.Size(185, 154)
        Me.amountsTenderedLabel.TabIndex = 0
        '
        'amt5Button
        '
        Me.amt5Button.BackColor = System.Drawing.Color.Maroon
        Me.amt5Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.amt5Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt5Button.ForeColor = System.Drawing.Color.White
        Me.amt5Button.Location = New System.Drawing.Point(383, 82)
        Me.amt5Button.Name = "amt5Button"
        Me.amt5Button.Size = New System.Drawing.Size(70, 70)
        Me.amt5Button.TabIndex = 90
        Me.amt5Button.Text = "5"
        Me.amt5Button.UseVisualStyleBackColor = False
        '
        'amt10Button
        '
        Me.amt10Button.BackColor = System.Drawing.Color.Maroon
        Me.amt10Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.amt10Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt10Button.ForeColor = System.Drawing.Color.White
        Me.amt10Button.Location = New System.Drawing.Point(383, 158)
        Me.amt10Button.Name = "amt10Button"
        Me.amt10Button.Size = New System.Drawing.Size(70, 70)
        Me.amt10Button.TabIndex = 84
        Me.amt10Button.Text = "10"
        Me.amt10Button.UseVisualStyleBackColor = False
        '
        'discountsLabel
        '
        Me.discountsLabel.AutoSize = True
        Me.discountsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountsLabel.Location = New System.Drawing.Point(3, 35)
        Me.discountsLabel.Name = "discountsLabel"
        Me.discountsLabel.Size = New System.Drawing.Size(92, 24)
        Me.discountsLabel.TabIndex = 79
        Me.discountsLabel.Text = "Discounts"
        '
        'taxLabel
        '
        Me.taxLabel.AutoSize = True
        Me.taxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxLabel.Location = New System.Drawing.Point(3, 67)
        Me.taxLabel.Name = "taxLabel"
        Me.taxLabel.Size = New System.Drawing.Size(42, 24)
        Me.taxLabel.TabIndex = 78
        Me.taxLabel.Text = "Tax"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(3, 99)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(51, 24)
        Me.totalLabel.TabIndex = 77
        Me.totalLabel.Text = "Total"
        '
        'subtotalLabel
        '
        Me.subtotalLabel.AutoSize = True
        Me.subtotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotalLabel.Location = New System.Drawing.Point(3, 3)
        Me.subtotalLabel.Name = "subtotalLabel"
        Me.subtotalLabel.Size = New System.Drawing.Size(77, 24)
        Me.subtotalLabel.TabIndex = 76
        Me.subtotalLabel.Text = "Subtotal"
        '
        'amtCurButton
        '
        Me.amtCurButton.BackColor = System.Drawing.Color.Maroon
        Me.amtCurButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.amtCurButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtCurButton.ForeColor = System.Drawing.Color.White
        Me.amtCurButton.Location = New System.Drawing.Point(383, 6)
        Me.amtCurButton.Name = "amtCurButton"
        Me.amtCurButton.Size = New System.Drawing.Size(70, 70)
        Me.amtCurButton.TabIndex = 91
        Me.amtCurButton.Text = "0"
        Me.amtCurButton.UseVisualStyleBackColor = False
        '
        'amt20Button
        '
        Me.amt20Button.BackColor = System.Drawing.Color.Maroon
        Me.amt20Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.amt20Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amt20Button.ForeColor = System.Drawing.Color.White
        Me.amt20Button.Location = New System.Drawing.Point(383, 234)
        Me.amt20Button.Name = "amt20Button"
        Me.amt20Button.Size = New System.Drawing.Size(70, 70)
        Me.amt20Button.TabIndex = 85
        Me.amt20Button.Text = "20"
        Me.amt20Button.UseVisualStyleBackColor = False
        '
        'discountsTextBox
        '
        Me.discountsTextBox.BackColor = System.Drawing.Color.Black
        Me.discountsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountsTextBox.ForeColor = System.Drawing.Color.LimeGreen
        Me.discountsTextBox.Location = New System.Drawing.Point(101, 32)
        Me.discountsTextBox.Name = "discountsTextBox"
        Me.discountsTextBox.ReadOnly = True
        Me.discountsTextBox.Size = New System.Drawing.Size(103, 29)
        Me.discountsTextBox.TabIndex = 75
        Me.discountsTextBox.Text = "$000000.00"
        Me.discountsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'subtotalTextBox
        '
        Me.subtotalTextBox.BackColor = System.Drawing.Color.Black
        Me.subtotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotalTextBox.ForeColor = System.Drawing.Color.LimeGreen
        Me.subtotalTextBox.Location = New System.Drawing.Point(101, 0)
        Me.subtotalTextBox.Name = "subtotalTextBox"
        Me.subtotalTextBox.ReadOnly = True
        Me.subtotalTextBox.Size = New System.Drawing.Size(103, 29)
        Me.subtotalTextBox.TabIndex = 74
        Me.subtotalTextBox.Text = "$000000.00"
        Me.subtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'taxTextBox
        '
        Me.taxTextBox.BackColor = System.Drawing.Color.Black
        Me.taxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxTextBox.ForeColor = System.Drawing.Color.LimeGreen
        Me.taxTextBox.Location = New System.Drawing.Point(101, 64)
        Me.taxTextBox.Name = "taxTextBox"
        Me.taxTextBox.ReadOnly = True
        Me.taxTextBox.Size = New System.Drawing.Size(103, 29)
        Me.taxTextBox.TabIndex = 73
        Me.taxTextBox.Text = "$000000.00"
        Me.taxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'totalTextBox
        '
        Me.totalTextBox.BackColor = System.Drawing.Color.Black
        Me.totalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalTextBox.ForeColor = System.Drawing.Color.LimeGreen
        Me.totalTextBox.Location = New System.Drawing.Point(101, 96)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(103, 29)
        Me.totalTextBox.TabIndex = 72
        Me.totalTextBox.Text = "$000000.00"
        Me.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'coCheckButton
        '
        Me.coCheckButton.BackColor = System.Drawing.Color.Maroon
        Me.coCheckButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coCheckButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coCheckButton.ForeColor = System.Drawing.Color.White
        Me.coCheckButton.Location = New System.Drawing.Point(231, 234)
        Me.coCheckButton.Name = "coCheckButton"
        Me.coCheckButton.Size = New System.Drawing.Size(70, 70)
        Me.coCheckButton.TabIndex = 81
        Me.coCheckButton.Text = "Check"
        Me.coCheckButton.UseVisualStyleBackColor = False
        '
        'coCashButton
        '
        Me.coCashButton.BackColor = System.Drawing.Color.Maroon
        Me.coCashButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coCashButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coCashButton.ForeColor = System.Drawing.Color.White
        Me.coCashButton.Location = New System.Drawing.Point(231, 6)
        Me.coCashButton.Name = "coCashButton"
        Me.coCashButton.Size = New System.Drawing.Size(70, 70)
        Me.coCashButton.TabIndex = 73
        Me.coCashButton.Text = "Cash"
        Me.coCashButton.UseVisualStyleBackColor = False
        '
        'coCreditButton
        '
        Me.coCreditButton.BackColor = System.Drawing.Color.Maroon
        Me.coCreditButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coCreditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coCreditButton.ForeColor = System.Drawing.Color.White
        Me.coCreditButton.Location = New System.Drawing.Point(231, 82)
        Me.coCreditButton.Name = "coCreditButton"
        Me.coCreditButton.Size = New System.Drawing.Size(70, 70)
        Me.coCreditButton.TabIndex = 82
        Me.coCreditButton.Text = "Credit"
        Me.coCreditButton.UseVisualStyleBackColor = False
        '
        'coStoreCreditButton
        '
        Me.coStoreCreditButton.BackColor = System.Drawing.Color.Maroon
        Me.coStoreCreditButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coStoreCreditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coStoreCreditButton.ForeColor = System.Drawing.Color.White
        Me.coStoreCreditButton.Location = New System.Drawing.Point(231, 158)
        Me.coStoreCreditButton.Name = "coStoreCreditButton"
        Me.coStoreCreditButton.Size = New System.Drawing.Size(70, 70)
        Me.coStoreCreditButton.TabIndex = 83
        Me.coStoreCreditButton.Text = "Store Credit"
        Me.coStoreCreditButton.UseVisualStyleBackColor = False
        '
        'totalLargeTextBox
        '
        Me.totalLargeTextBox.BackColor = System.Drawing.Color.Black
        Me.totalLargeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLargeTextBox.ForeColor = System.Drawing.Color.LimeGreen
        Me.totalLargeTextBox.Location = New System.Drawing.Point(102, 609)
        Me.totalLargeTextBox.Name = "totalLargeTextBox"
        Me.totalLargeTextBox.ReadOnly = True
        Me.totalLargeTextBox.Size = New System.Drawing.Size(215, 38)
        Me.totalLargeTextBox.TabIndex = 67
        Me.totalLargeTextBox.Text = "$000000.00"
        Me.totalLargeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'percentButton
        '
        Me.percentButton.BackColor = System.Drawing.Color.Maroon
        Me.percentButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.percentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentButton.ForeColor = System.Drawing.Color.White
        Me.percentButton.Location = New System.Drawing.Point(710, 351)
        Me.percentButton.Name = "percentButton"
        Me.percentButton.Size = New System.Drawing.Size(70, 70)
        Me.percentButton.TabIndex = 69
        Me.percentButton.Text = "%"
        Me.percentButton.UseVisualStyleBackColor = False
        '
        'regNumDecButton
        '
        Me.regNumDecButton.BackColor = System.Drawing.Color.Maroon
        Me.regNumDecButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regNumDecButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regNumDecButton.ForeColor = System.Drawing.Color.White
        Me.regNumDecButton.Location = New System.Drawing.Point(634, 579)
        Me.regNumDecButton.Name = "regNumDecButton"
        Me.regNumDecButton.Size = New System.Drawing.Size(70, 70)
        Me.regNumDecButton.TabIndex = 71
        Me.regNumDecButton.Text = "."
        Me.regNumDecButton.UseVisualStyleBackColor = False
        '
        'orderListBox
        '
        Me.orderListBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.orderListBox.FormattingEnabled = True
        Me.orderListBox.Location = New System.Drawing.Point(12, 105)
        Me.orderListBox.Name = "orderListBox"
        Me.orderListBox.ScrollAlwaysVisible = True
        Me.orderListBox.Size = New System.Drawing.Size(305, 498)
        Me.orderListBox.TabIndex = 1
        '
        'enterButton
        '
        Me.enterButton.BackColor = System.Drawing.Color.Maroon
        Me.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.enterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterButton.ForeColor = System.Drawing.Color.White
        Me.enterButton.Location = New System.Drawing.Point(710, 501)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(70, 146)
        Me.enterButton.TabIndex = 68
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.Yellow
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(12, 609)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(84, 38)
        Me.exitButton.TabIndex = 72
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'keypadTextBox
        '
        Me.keypadTextBox.AllowDrop = True
        Me.keypadTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.keypadTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keypadTextBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.keypadTextBox.Location = New System.Drawing.Point(330, 351)
        Me.keypadTextBox.MaxLength = 25
        Me.keypadTextBox.Name = "keypadTextBox"
        Me.keypadTextBox.Size = New System.Drawing.Size(146, 29)
        Me.keypadTextBox.TabIndex = 61
        Me.keypadTextBox.WordWrap = False
        '
        'clearOrderButton
        '
        Me.clearOrderButton.BackColor = System.Drawing.Color.Yellow
        Me.clearOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clearOrderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearOrderButton.Location = New System.Drawing.Point(406, 577)
        Me.clearOrderButton.Name = "clearOrderButton"
        Me.clearOrderButton.Size = New System.Drawing.Size(70, 70)
        Me.clearOrderButton.TabIndex = 73
        Me.clearOrderButton.Text = "Clear Order"
        Me.clearOrderButton.UseVisualStyleBackColor = False
        '
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 707)
        Me.ControlBox = False
        Me.Controls.Add(Me.clearOrderButton)
        Me.Controls.Add(Me.keypadTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.regNumDecButton)
        Me.Controls.Add(Me.percentButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.totalLargeTextBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.adjQtyButton)
        Me.Controls.Add(Me.adjTaxButton)
        Me.Controls.Add(Me.adjPriceButton)
        Me.Controls.Add(Me.itemTextBox)
        Me.Controls.Add(Me.customerDisplayTextBox)
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
        Me.Controls.Add(Me.voidButton)
        Me.Controls.Add(Me.discountButton)
        Me.Controls.Add(Me.orderListBox)
        Me.Controls.Add(Me.regTabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 715)
        Me.Name = "registerForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "BBIT POS for Ubercart 3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.regTabControl.ResumeLayout(False)
        Me.browseItems.ResumeLayout(False)
        Me.customers.ResumeLayout(False)
        Me.checkout.ResumeLayout(False)
        Me.checkout.PerformLayout()
        Me.amtTenderGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents customerDisplayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents discountButton As System.Windows.Forms.Button
    Friend WithEvents voidButton As System.Windows.Forms.Button
    Friend WithEvents adjPriceButton As System.Windows.Forms.Button
    Friend WithEvents adjTaxButton As System.Windows.Forms.Button
    Friend WithEvents adjQtyButton As System.Windows.Forms.Button
    Friend WithEvents itemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents regNum1Button As System.Windows.Forms.Button
    Friend WithEvents regNum2Button As System.Windows.Forms.Button
    Friend WithEvents regNum3Button As System.Windows.Forms.Button
    Friend WithEvents regNum4Button As System.Windows.Forms.Button
    Friend WithEvents regNum5Button As System.Windows.Forms.Button
    Friend WithEvents regNum6Button As System.Windows.Forms.Button
    Friend WithEvents regNum7Button As System.Windows.Forms.Button
    Friend WithEvents regNum8Button As System.Windows.Forms.Button
    Friend WithEvents regNum9Button As System.Windows.Forms.Button
    Friend WithEvents regNum0Button As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents regTimeToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents machineToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents regTabControl As System.Windows.Forms.TabControl
    Friend WithEvents browseItems As System.Windows.Forms.TabPage
    Friend WithEvents checkout As System.Windows.Forms.TabPage
    Friend WithEvents totalLargeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents customers As System.Windows.Forms.TabPage
    Friend WithEvents percentButton As System.Windows.Forms.Button
    Friend WithEvents regNumDecButton As System.Windows.Forms.Button
    Friend WithEvents discountsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents subtotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents taxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents totalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents orderListBox As System.Windows.Forms.ListBox
    Friend WithEvents enterButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents netStatusToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents discountsLabel As System.Windows.Forms.Label
    Friend WithEvents taxLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents subtotalLabel As System.Windows.Forms.Label
    Friend WithEvents coStoreCreditButton As System.Windows.Forms.Button
    Friend WithEvents coCreditButton As System.Windows.Forms.Button
    Friend WithEvents coCheckButton As System.Windows.Forms.Button
    Friend WithEvents coCashButton As System.Windows.Forms.Button
    Friend WithEvents amt5Button As System.Windows.Forms.Button
    Friend WithEvents amtTenderGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents amtCurButton As System.Windows.Forms.Button
    Friend WithEvents keypadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents clearOrderButton As System.Windows.Forms.Button
    Friend WithEvents productsViewAllButton As System.Windows.Forms.Button
    Friend WithEvents customersViewAllButton As System.Windows.Forms.Button
    Friend WithEvents amountsTenderedLabel As System.Windows.Forms.Label
    Friend WithEvents amt20Button As System.Windows.Forms.Button
    Friend WithEvents amt10Button As System.Windows.Forms.Button
End Class
