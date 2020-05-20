Imports System.Windows.Forms

Public Class endOfBusDay
    Private utilsSftp As New BBIT_POS_Ubercart3_SFTP.utils_sftp

    Private Sub endOfBusDay_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        endOfBusDayLabel.Text = "Generating report..."
        endOfBusDayLabel.Text = "Sending report to printer..."
        endOfBusDayLabel.Text = "Saving transactions to file..."
        endOfBusDayLabel.Text = "Sending transactions file to website..."
        endOfBusDayLabel.Text = "Contacting website to add transactions to website database..."
        endOfBusDayLabel.Text = "Updating transactions in database as sent..."
        endOfBusDayLabel.Text = "End of Business Day reporting completed."
        Me.Close()
    End Sub
End Class
