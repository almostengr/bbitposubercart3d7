Public Class utilities
    Dim writeToPOSLog As New posLogger

    Public Sub enableAllControls(ByVal formControls As Object)
        For Each tempControl In formControls.Controls
            tempControl.enabled = True
        Next
    End Sub 'enableAllControls

    Public Sub disableAllControls(ByVal formControl As Object)
        For Each tempControl In formControl.Controls
            tempControl.enabled = False
        Next
    End Sub 'disableAllControls

    'Reading file to datatable
    'http://www.velocityreviews.com/forums/t122087-reading-text-file-to-dataset.html
    Public Function BuildDataTable(ByVal fileFullPath As String, ByVal seperator As Char) As DataTable
        Dim myTable As DataTable = New DataTable("MyTable")
        Dim i As Integer
        Dim myRow As DataRow
        Dim fieldValues As String()
        'Dim f As IO.File
        Dim myReader As IO.StreamReader
        'Dim myReader As IO.StreamReader = New IO.StreamReader(fileFullPath)


        fileFullPath = My.Application.Info.DirectoryPath + "\" + fileFullPath 'update the path to include the directory

        Try
            Try
                'Open file and read first line to determine how many fields there(are.
                myReader = IO.File.OpenText(fileFullPath)
                fieldValues = myReader.ReadLine().Split(seperator)
                'Create data columns accordingly
                For i = 0 To fieldValues.Length() - 1
                    myTable.Columns.Add(New DataColumn("Field" & i))
                Next

                'Adding the first line of data to data table
                myRow = myTable.NewRow
                For i = 0 To fieldValues.Length() - 1
                    myRow.Item(i) = fieldValues(i).ToString
                Next
                myTable.Rows.Add(myRow)

                'Now reading the rest of the data to data table
                While myReader.Peek() <> -1
                    fieldValues = myReader.ReadLine().Split(seperator)
                    myRow = myTable.NewRow
                    For i = 0 To fieldValues.Length() - 1
                        myRow.Item(i) = fieldValues(i).ToString
                    Next
                    myTable.Rows.Add(myRow)
                End While
            Catch ex As Exception
                MsgBox("Error building datatable: " & ex.Message, MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
                writeToPOSLog.logError(ex.Message, "ERROR")
                'Return (New DataTable("Empty"))
                myTable = New DataTable("Empty")
            Finally
                myReader.Close()
            End Try
        Catch ex As Exception
            writeToPOSLog.logError(ex.Message, "ERROR")
            'catch null myReader exception, do nothing
        End Try

        Return myTable
    End Function
End Class
