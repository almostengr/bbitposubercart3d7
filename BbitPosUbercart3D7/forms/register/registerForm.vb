Imports System.ComponentModel
Imports System.Globalization
Imports System.Net
Imports System.Diagnostics.Process
Imports xmlsettings.Settings
Imports System.Security.Cryptography 'for using md5 hash
Imports System.Text
Imports System.IO.StreamReader
Imports BbitPosUbercart3D7.posLogger

Public Class registerForm
    'Private PrevResizeX As Integer
    'Private PrevResizeY As Integer
    Private utils As New utilities
    Private utilsAdmin As New utils_admin
    Private writeToPOSLog As New posLogger
    Private viewAllBtnClicked As Char
    Private decimalPlaces As Integer

    Private amtSubtotal As Double
    Private amtDiscount As Double
    Private amtSalesTax As Double
    Private amtOrderTotal As Double
    Private amtTendered As Double
    'Private orderProducts As list
    Private customerId As Integer
    Private orderProducts As Array

    Public posDatabase As posdbDataSet
    Dim posProductTA As posdbDataSetTableAdapters.ucProductTableAdapter
    Dim posCustomerTA As posdbDataSetTableAdapters.ucCustomerTableAdapter

    Private Sub updateCustomerName(ByVal enteredCustId As String)
        Dim rows() As System.Data.DataRow
        Dim row As DataRow



        'posDatabase.
        'rows = mainForm.ucCustomersDT.Select("[Field0] = " + CStr(CInt(enteredCustId)))

        If rows.Length > 0 Then
            customerId = enteredCustId
            For Each row In rows
                customerDisplayTextBox.Text = row("Field1") + " " + row("Field2") + ", " + row("Field3")
            Next
        Else
            MsgBox("Customer ID not found.", MsgBoxStyle.Information, My.Application.Info.ProductName)
        End If
        keypadTextBox.Clear()
    End Sub

    Private Sub updateAmtOrderTotals(ByVal addAmtSubtotal As Double, ByVal addSalesTax As Double)
        amtSubtotal = amtSubtotal + addAmtSubtotal
        amtSalesTax = amtSalesTax + (addAmtSubtotal * addSalesTax)
        amtOrderTotal = amtSubtotal + amtSalesTax

        subtotalTextBox.Text = regFormatCurrency(amtSubtotal)
        taxTextBox.Text = regFormatCurrency(amtSalesTax)
        discountsTextBox.Text = regFormatCurrency(amtDiscount)
        totalLargeTextBox.Text = regFormatCurrency(amtOrderTotal)
    End Sub

    Private Function regFormatCurrency(ByVal currencyAmt As Double) As String
        Dim formattedCurrency As String
        formattedCurrency = FormatCurrency(currencyAmt, decimalPlaces, TriState.UseDefault, TriState.True, TriState.True)
        Return formattedCurrency
    End Function 'regFormatCurrency

    Private Sub saveOrder()

    End Sub

    Private Sub changeItemQty(ByVal listItemNumber As Integer, ByVal newQty As Integer)
        'change selected item quantity
    End Sub



    Public Function getViewAllBtnClick() As String
        Return (viewAllBtnClicked)
    End Function

    'KEYPAD CONTROLS
    Private Sub regNumButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regNum1Button.Click,
        regNum2Button.Click, regNum3Button.Click, regNum4Button.Click, regNum5Button.Click, regNum6Button.Click,
        regNum7Button.Click, regNum8Button.Click, regNum9Button.Click, regNum0Button.Click, regNumDecButton.Click,
        percentButton.Click

        keypadTextBox.AppendText(Me.ActiveControl.Text) 'add number of button click to the field
    End Sub

    Private Sub regBkspButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        keypadTextBox.Clear()
    End Sub
    'KEYPAD CONTROLS

    Private orderBindingList As BindingList(Of DataRow)

    'ENTER SKU/ADD ITEM SUPPORTING FUNCTIONS
    Public Sub addItem(ByVal enteredSKU As String)
        Dim rows() As System.Data.DataRow
        Dim row As DataRow
        Dim customerName As String = ""
        Dim ringUpName As String = ""
        Dim ringUpTax As Double
        Dim ringUpPrice As Double

        itemTextBox.ForeColor = Color.Yellow
        itemTextBox.Text = "Searching..." 'search sku, if found add item, if not found, return error

        'rows = mainForm.ucProductsDT.Select("[Field1] = " + CStr(CInt(enteredSKU))) 'query product database for item 

        'If rows.Length > 0 Then
        '    'if item is found, add to data set, update item display
        '    For Each row In rows
        '        ringUpName = row("Field2")
        '        ringUpPrice = row("Field4")
        '        ringUpTax = row("Field3")
        '    Next

        '    itemTextBox.Text = ringUpName + vbCrLf + regFormatCurrency(ringUpPrice) 'display item

        '    'orderBindingList = mainForm.ucProductsDT.AsEnumerable.ToList

        '    orderListBox.DataSource = orderBindingList
        '    orderListBox.DisplayMember = ""

        '    updateAmtOrderTotals(ringUpPrice, ringUpTax) 'recalculate total

        'Else
        '    'if item is not found, display error message 
        '    itemTextBox.ForeColor = Color.Red
        '    itemTextBox.Text = "SKU NOT FOUND"
        '    My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        'End If
        keypadTextBox.Clear()
    End Sub
    'END ENTER SKU/ADD ITEM CONTROLS AND SUPPORTING FUNCTIONS


    'ITEM DISPLAY CONTROLS
    Private Sub regDiscountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles discountButton.Click
        Dim dialogResult As Windows.Forms.DialogResult
        dialogResult = adminLoginform.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.Yes Then
            If keypadTextBox.Text <> "" Then
                'get the selected item, and update with the price in the text box
            Else
                MsgBox("Enter a value first.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
                keypadTextBox.Focus()
            End If
        ElseIf dialogResult = Windows.Forms.DialogResult.No Then
            utilsAdmin.invalidPassword()
        End If
    End Sub

    Private Sub regVoidButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voidButton.Click
        'get the selected item and remove it from the list
    End Sub

    Private Sub regAdjPriceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjPriceButton.Click
        Dim dialogResult As Windows.Forms.DialogResult
        dialogResult = adminLoginform.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.Yes Then
            If keypadTextBox.Text <> "" Then
                'get the selected item, and update with the price in the text box
            Else
                MsgBox("Enter a value first.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
                keypadTextBox.Focus()
            End If
        ElseIf dialogResult = Windows.Forms.DialogResult.No Then
            utilsAdmin.invalidPassword()
        End If
    End Sub

    Private Sub adjTaxButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjTaxButton.Click
        Dim dialogResult As Windows.Forms.DialogResult
        dialogResult = adminLoginform.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.Yes Then
            If keypadTextBox.Text <> "" Then
                'get the selected item, and update with the price in the text box
            Else
                MsgBox("Enter a value first.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
                keypadTextBox.Focus()
            End If
        ElseIf dialogResult = Windows.Forms.DialogResult.No Then
            utilsAdmin.invalidPassword()
        End If
    End Sub

    'END OF ITEM DISPLAY CONTROLS

    'Private Sub Me_resize(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim increaseX As Integer = Me.Size.Width - PrevResizeX
    '    Dim increaseY As Integer = Me.Size.Height - PrevResizeY

    '    If Me.Size.Width > PrevResizeX Or Me.Size.Height > PrevResizeY Then
    '        'if form size is increased 
    '        For Each tempControl In Me.Controls
    '            tempControl.location.x = tempControl.location.x + increaseX
    '            tempControl.location.y = tempControl.location.y + increaseY

    '            tempControl.size.x = tempControl.size.x + increaseX
    '            tempControl.size.y = tempControl.size.y + increaseY
    '        Next

    '    ElseIf Me.Size.Width < PrevResizeX Or Me.Size.Height < PrevResizeY Then
    '        'if form size is decreased 
    '        For Each tempControl In Me.Controls
    '            tempControl.location.x = tempControl.location.x - increaseX
    '            tempControl.location.y = tempControl.location.y - increaseY

    '            tempControl.size.x = tempControl.size.x - increaseX
    '            tempControl.size.y = tempControl.size.y - increaseY
    '        Next
    '    End If

    '    'payment_GroupBox.Left = payment_GroupBox /
    '    'credit_Button.Width = MyBase.Size.Width * 0.10857
    '    'credit_Button.Left = credit_Button.Left /
    '    'credit_Button.Height = MyBase.Size.Height * 0.10571


    '    'http://www.vbforums.com/showthread.php?376702-Classic-VB-Resizing-Controls-on-Form
    '    'For Each tmpControl In Me.Controls

    '    '    tmpControl.Left = tmpControl.Left / PrevResizeX * Me.AutoScaleFactor
    '    '    tmpControl.Top = tmpControl.Top / PrevResizeY * Me.AutoScaleFactor
    '    '    tmpControl.Width = tmpControl.Width / PrevResizeX * Me.AutoScaleFactor
    '    '    tmpControl.Height = tmpControl.Height / PrevResizeY * Me.AutoScaleFactor

    '    'Next tmpControl
    'End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Dim diaResult As DialogResult
        Dim msgAlert As String = "The current order has not be completed. Your order will not be saved if you " + _
            "exit the reigster window. Are you sure you want to exit?"

        If amtOrderTotal > 0 Then
            diaResult = MsgBox(msgAlert, MsgBoxStyle.YesNo, My.Application.Info.ProductName)

            If diaResult = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If

        ElseIf amtOrderTotal = 0.0 Then
            Me.Close()
        End If
    End Sub

    Private Sub coCashButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles coCashButton.Click, coCheckButton.Click, coCreditButton.Click, coStoreCreditButton.Click

        If Me.ActiveControl.Text.ToLower() = "cash" Then
            coCashButton.BackColor = Color.Green
        ElseIf Me.ActiveControl.Text.ToLower() = "credit" Then
            coCreditButton.BackColor = Color.Green
        ElseIf Me.ActiveControl.Text.ToLower() = "check" Then
            coCheckButton.BackColor = Color.Green
        ElseIf Me.ActiveControl.Text.ToLower = "store credit" Then
            coStoreCreditButton.BackColor = Color.Green
        Else
            'in theory, shouldn't happen
            My.Application.Log.WriteEntry("Error detecting payment button.", TraceEventType.Error)
            writeToPOSLog.logError("Error detecting payment button. registerForm:266", "WARNING")
        End If
    End Sub

    Private Sub clearOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearOrderButton.Click
        Dim result As DialogResult
        result = MsgBox("Are you sure you want to delete the current order?", MsgBoxStyle.YesNo, My.Application.Info.ProductName)

        If result = Windows.Forms.DialogResult.Yes Then
            startNewOrder()
        End If
    End Sub

    Private Sub regTabControlCheckout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regTabControl.Click
        'orderListBox.SelectedValueChanged

        'update the next amt button based upon the current price
        Dim nextDollarAmt As Integer
        nextDollarAmt = Math.Ceiling(amtOrderTotal)
        amtCurButton.Text = "$" + CStr(nextDollarAmt)
    End Sub

    Private Sub startNewOrder()
        'set up the register for a new order

        'orderListBox. 'clear all items in listbox
        'orderListBox.Dispose()
        'newOrder()
        amtSubtotal = 0.0
        amtDiscount = 0.0
        amtSalesTax = 0.0
        amtOrderTotal = 0.0
        amtTendered = 0.0
        customerId = 1
        updateCustomerName(CStr(customerId))
        updateAmtOrderTotals(amtSubtotal, amtSalesTax)
        itemTextBox.Text = "Enter Item"
        amountsTenderedLabel.Text = ""
        amtCurButton.TabIndex = 0
    End Sub

    Private Sub customersViewAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customersViewAllButton.Click
        viewAllBtnClicked = "C"
        viewAllDatagrid.ShowDialog()
    End Sub

    Private Sub productsViewAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles productsViewAllButton.Click
        viewAllBtnClicked = "P"
        viewAllDatagrid.ShowDialog()
    End Sub

    Private Sub enterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterButton.Click
        If keypadTextBox.TextLength > 0 Then
            If CInt(regTabControl.SelectedIndex.ToString) = 0 Then
                'if currently on the products tab, then add item in textbox.
                addItem(keypadTextBox.Text)
            ElseIf CInt(regTabControl.SelectedIndex.ToString) = 1 Then
                'if currently on the customers tab, then update customer 
                updateCustomerName(keypadTextBox.Text)
            End If
        End If
    End Sub

    Private Sub keypadTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles keypadTextBox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            enterButton.PerformClick()
        End If
    End Sub

    Private Sub productsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'keypadTextBox.Text = 
    End Sub

    Private Sub registerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        utils.disableAllControls(Me)

        'productsDataGridView.DataSource = mainForm.ucProductsDT
        'customerDataGridView.DataSource = mainForm.ucCustomersDT

        'productsDataGridView.Columns("Field0").Visible = False 'product ID
        ''productsDataGridView.Columns("Field0").HeaderText = "Product ID" 'product ID
        'productsDataGridView.Columns("Field1").HeaderText = "SKU/Model"
        'productsDataGridView.Columns("Field2").HeaderText = "Name"
        'productsDataGridView.Columns("Field3").Visible = False '"Tax"
        'productsDataGridView.Columns("Field4").HeaderText = "Price"
        'productsDataGridView.Columns("Field5").Visible = False 'stock
        'productsDataGridView.Columns("Field6").Visible = False '"Category"
        'productsDataGridView.Columns("Field7").Visible = False '"Description"
        'productsDataGridView.Columns("Field8").Visible = False '"URL"

        ''customerDataGridView.Columns("Field0").Visible = False
        'customerDataGridView.Columns("Field0").HeaderText = "Customer ID"
        'customerDataGridView.Columns("FIeld1").HeaderText = "First Name"
        'customerDataGridView.Columns("FIeld2").HeaderText = "Last Name"
        'customerDataGridView.Columns("FIeld3").HeaderText = "Company"
        'customerDataGridView.Columns("FIeld4").Visible = False '"Email"
        'customerDataGridView.Columns("FIeld5").Visible = False '"Phone Number"
        'customerDataGridView.Columns("FIeld6").Visible = False '"Login"
        'customerDataGridView.Columns("FIeld7").Visible = False '"Acct Balance"

        'update checkout buttons with currency symbol
        amt5Button.Text = FormatCurrency(amt5Button.Text, 0, TriState.False, TriState.False, TriState.False)
        amt10Button.Text = FormatCurrency(amt10Button.Text, 0, TriState.False, TriState.False, TriState.False)
        amt20Button.Text = FormatCurrency(amt20Button.Text, 0, TriState.False, TriState.False, TriState.False)

        decimalPlaces = 2
        startNewOrder()

        utils.enableAllControls(Me)
    End Sub

    Private Sub amtCurButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amtCurButton.Click, _
        amt5Button.Click, amt10Button.Click, amt20Button.Click

        Dim tempValue As String
        tempValue = FormatCurrency(Me.ActiveControl.Text, decimalPlaces, TriState.False, TriState.False, TriState.UseDefault)
        keypadTextBox.Text = tempValue.Replace("$", "")
        'RegionInfo

        'Me.ActiveControl.Text.Replace("$", "")
    End Sub

    Public Sub displayItemText(ByVal itemName As String, ByVal itemPrice As Double,
                                    ByVal itemTaxRate As Double, ByVal itemQty As Integer,
                                    ByVal itemDisplayControl As Object, ByVal itemOrderList As Object)
        Dim itemTotal As Double
        Dim displayPrice As String = regFormatCurrency(CStr(itemPrice))
        Dim displayTax As String = regFormatCurrency(CStr(itemPrice * itemTaxRate))
        Dim displayQty As String = regFormatCurrency(CStr(itemQty))

        itemTotal = itemPrice * (1 + itemTaxRate) * itemQty

        itemDisplayControl = itemName + vbNewLine +
            "Price: " + displayPrice + " Tax: " + displayTax + " Item Total: "
    End Sub 'displayItemText


End Class