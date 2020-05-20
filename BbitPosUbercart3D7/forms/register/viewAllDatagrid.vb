Public Class viewAllDatagrid

    Public bsViewAll As New BindingSource
    Private regButtonClicked As Char
    Private viewType As String

    Private Sub viewAllCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewAllCancelButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub viewAllSelectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewAllSelectButton.Click
        'get the selected item

        If viewAllDataGridView.CurrentRow.Index >= 0 Then
            If regButtonClicked = "C" Then 'if Customers, update the customer
                'order.setCustomerId()
            ElseIf regButtonClicked = "P" Then 'if products, add to the list of items
                registerForm.addItem(viewAllDataGridView.CurrentRow.Cells(1).Value()) 'add item to listbox

            End If

            'if products, add to the list of items
            'Me.Close()
        Else
            MsgBox("You did not select a " + viewType + ".", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub viewAllDatagrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'viewAllDataGridView.AutoResizeColumns()
        'viewAllDataGridView.RowTemplate.Height = 70
        'viewAllDataGridView.DataSource = viewAllBindingNavigator.BindingSource
        'viewAllDatagrid.datasource = bsViewAll

        viewAllBindingNavigator.BindingSource = bsViewAll
        viewAllDataGridView.DataSource = bsViewAll
        regButtonClicked = registerForm.getViewAllBtnClick()

        If regButtonClicked = "C" Then
            viewType = "customer"
            Me.Text = "View All Customers"
            Me.bsViewAll.DataSource = registerForm.posDatabase.ucCustomer

            'rename headers
            Me.viewAllDataGridView.Columns("Field0").HeaderText = "Customer ID"
            Me.viewAllDataGridView.Columns("FIeld1").HeaderText = "First Name"
            Me.viewAllDataGridView.Columns("FIeld2").HeaderText = "Last Name"
            Me.viewAllDataGridView.Columns("FIeld3").HeaderText = "Company"
            Me.viewAllDataGridView.Columns("FIeld4").HeaderText = "First Name"
            Me.viewAllDataGridView.Columns("FIeld5").HeaderText = "Email"
            Me.viewAllDataGridView.Columns("FIeld6").HeaderText = "Phone"
            Me.viewAllDataGridView.Columns("FIeld7").HeaderText = "Acct Bal"

        ElseIf regButtonClicked = "P" Then
            viewType = "product"
            Me.Text = "View All Products"
            Me.bsViewAll.DataSource = registerForm.posDatabase.ucProduct

            'rename headers
            Me.viewAllDataGridView.Columns("Field0").HeaderText = "Product ID" 'product ID
            Me.viewAllDataGridView.Columns("Field1").HeaderText = "SKU/Model"
            Me.viewAllDataGridView.Columns("Field2").HeaderText = "Name"
            Me.viewAllDataGridView.Columns("Field3").HeaderText = "Tax"
            Me.viewAllDataGridView.Columns("Field4").HeaderText = "Price"
            Me.viewAllDataGridView.Columns("Field5").HeaderText = "Stock" 'stock
            Me.viewAllDataGridView.Columns("Field6").HeaderText = "Category"
            Me.viewAllDataGridView.Columns("Field7").HeaderText = "Description"
            Me.viewAllDataGridView.Columns("Field8").HeaderText = "URL"
        Else
            'theoretically shouldn't happen, but using fail safe just in case
            MsgBox("An unexpected error occurred.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
            'log error to system log
            Me.DialogResult = Windows.Forms.DialogResult.Abort
            Me.Close()
        End If

    End Sub
End Class