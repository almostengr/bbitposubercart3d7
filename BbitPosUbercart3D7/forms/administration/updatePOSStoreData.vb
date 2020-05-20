Imports System.Windows.Forms

Public Class updatePOSStoreData
    Private Sub updatePOSStoreData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim utilsAdmin As New utils_admin
        Dim writeToPOSLog As posLogger

        Try
            Dim updateSucceeded As Boolean = False

            updateStorePictureBox.Visible = True
            updateSucceeded = utilsAdmin.getDataFromWebsite("storeinfo")
            If updateSucceeded = False Then
                Throw New Exception("An error occurred when trying to update the Store Information.")
            End If

            updateSucceeded = False 'reset variable

            updateStorePictureBox.Visible = False 'change the arrow to the next item
            updateProductPictureBox.Visible = True

            updateSucceeded = utilsAdmin.getDataFromWebsite("products")
            If updateSucceeded = False Then
                Throw New Exception("An error occurred hwen trying to update the Products database.")
            End If

            updateSucceeded = False 'reset variable

            updateProductPictureBox.Visible = False 'change the arrow to the next item
            updateCustomerPictureBox.Visible = True

            updateSucceeded = utilsAdmin.getDataFromWebsite("customers")
            If updateSucceeded = False Then
                Throw New Exception("Error occurred when trying to update the Customer database.")
            End If

            updateCustomerPictureBox.Visible = False 'change the arrow to the next item

            'MsgBox("Updates completed successfully.", MsgBoxStyle.Information, My.Application.Info.ProductName)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox("An error occurred when trying to update the POS information. Unable to continue." + ex.Message, _
                  MsgBoxStyle.Critical, My.Application.Info.ProductName)
            writeToPOSLog.logError(ex.Message, "ERROR")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Try
    End Sub
End Class
