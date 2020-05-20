Imports System.Windows.Forms

Public Class pwdChgDialog
    Private pwdFieldSelected As Integer = 1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim utilsAdmin As New utils_admin
        Dim enterPasswordIsInt As Integer
        Dim reEnterPasswordIsInt As Integer

        Try
            If enterPwdTextBox.Text.Length > 0 And reEnterPwdTextBox.Text.Length > 0 Then
                Integer.TryParse(enterPwdTextBox.Text, enterPasswordIsInt)
                Integer.TryParse(reEnterPwdTextBox.Text, reEnterPasswordIsInt)

                If enterPasswordIsInt = reEnterPasswordIsInt Then
                    'if password matches, the update the password

                    utilsAdmin.updateAdminPwd(CStr(enterPasswordIsInt))
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    Throw New Exception
                End If
            Else
                Throw New Exception
            End If

        Catch ex As Exception
            'if the passwords don't match, then alert and return to form
            MsgBox("The passwords entered do not match. Please try again.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            enterPwdTextBox.Clear()
            reEnterPwdTextBox.Clear()
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Num1_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num1_Button.Click,
        Num2_Button.Click, Num3_Button.Click, Num4_Button.Click, Num5_Button.Click, Num6_Button.Click,
        Num7_Button.Click, NUm8_Button.Click, Num9_Button.Click, Num0_Button.Click

        If pwdFieldSelected = 1 Then
            enterPwdTextBox.AppendText(Me.ActiveControl.Text())
            enterPwdTextBox.Focus()
        ElseIf pwdFieldSelected = 2 Then
            reEnterPwdTextBox.AppendText(Me.ActiveControl.Text())
            reEnterPwdTextBox.Focus()
        End If
    End Sub

    Private Sub enterPwdTextBox_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles enterPwdTextBox.KeyDown
        If e.KeyData = Keys.Enter Then
            reEnterPwdTextBox.Focus()
        End If
    End Sub

    Private Sub reEnterPwdTextBox_Enter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles reEnterPwdTextBox.KeyDown
        If e.KeyData = Keys.Enter Then
            OK.PerformClick()
        End If
    End Sub

    Private Sub admin_pwdChg_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        enterPwdTextBox.Clear()
        reEnterPwdTextBox.Clear()
        enterPwdTextBox.Focus()
    End Sub

    Private Sub enterPwdTextSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterPwdTextBox.Click
        pwdFieldSelected = 1
    End Sub

    Private Sub reEnterPwdTextSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reEnterPwdTextBox.Click
        pwdFieldSelected = 2
    End Sub
End Class
