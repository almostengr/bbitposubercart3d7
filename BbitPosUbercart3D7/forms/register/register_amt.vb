Public Class register_amt

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim amountDecimal As String = "0"

    Private Sub reg_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_OK.Click
        Me.Close()
    End Sub

    Private Sub reg_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_Cancel.Click
        Me.Close()
    End Sub

    Private Sub register_amt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AmountTextBox.Focus()
    End Sub

    Private Sub reg_Num1_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_Num1_Button.Click
        'amountDecimal = amountDecimal + "1"

        AmountTextBox.AppendText("1")
        convertCurrency()
    End Sub

    Private Sub Num2_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_Num2_Button.Click
        AmountTextBox.AppendText("2")
    End Sub

    Private Sub Num3_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_Num3_Button.Click
        AmountTextBox.AppendText("3")
    End Sub

    Private Sub Num4_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_Num4_Button.Click
        AmountTextBox.AppendText("4")
    End Sub

    Private Sub Num5_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_Num5_Button.Click
        AmountTextBox.AppendText("5")
    End Sub

    Private Sub Num6_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_Num6_Button.Click
        AmountTextBox.AppendText("6")
    End Sub

    Private Sub Num7_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_Num7_Button.Click
        AmountTextBox.AppendText("7")
    End Sub

    Private Sub Num8_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_NUm8_Button.Click
        AmountTextBox.AppendText("8")
    End Sub

    Private Sub Num9_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_Num9_Button.Click
        AmountTextBox.AppendText("9")
    End Sub

    Private Sub Num0_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reg_Num0_Button.Click
        AmountTextBox.AppendText("0")
    End Sub

    Private Sub Decimal_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AmountTextBox.AppendText(".")
    End Sub

    Private Sub convertCurrency()

        FormatCurrency(AmountTextBox.Text, 2, TriState.True, TriState.False, TriState.True)
    End Sub

End Class
