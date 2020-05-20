Imports System.IO
Imports System.Net
Imports System.Text

Public Class posLogger
    Public Sub logError(ByVal logMsg As String, Optional ByVal msgType As String = "INFO")
        Dim errorLogFilePath As String = My.Application.Info.DirectoryPath + "\log\" + _
            CStr(DateTime.Now.Year) + CStr(DateTime.Now.Month) + CStr(DateTime.Now.Day) + ".log"
        Dim lineToWrite As String = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString + " [" + msgType + "] " + logMsg

        Try
            Dim errorWriter As IO.StreamWriter
            Try
                errorWriter = New StreamWriter(errorLogFilePath, True) 'open file
                errorWriter.WriteLine(lineToWrite) 'writes error message to files
            Catch ex As Exception
                'let the user know if the error could not be logged
                MsgBox("ERROR: Unable to log program error. " + ex.Message, MsgBoxStyle.Critical, My.Application.Info.ProductName)
            Finally
                errorWriter.Close() 'close file
            End Try
        Catch ex As NullReferenceException
            'do nothing
            MsgBox("ERROR: An error occurred that should not have happened. Please report this error to BBIT. " + ex.Message, _
                   MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End Try
    End Sub

    'Private Sub sendErrorLog()
    '    'Send POST Method to a PHP file through Visual Basic 
    '    'http://www.vbforums.com/showthread.php?658167-Send-POST-Method-to-a-PHP-file-through-Visual-Basic

    '    Dim errorLogFile As IO.StreamReader
    '    Dim errorMessage As String = ""

    '    Try
    '        errorLogFile = New StreamReader(errorLogFilePath)
    '        While errorLogFile.Peek <> -1
    '            errorMessage = errorLogFile.ReadLine
    '        End While
    '        errorLogFile.Close()

    '        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create("http://demopos.blackboxitech.com/poserrorreport.php")
    '        request.Method = "POST"
    '        Dim postData = "website=" + appSettings.GetSetting("storeWebsite") + "&error=" + errorMessage
    '        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
    '        request.ContentType = "application/x-www-form-urlencoded"
    '        request.ContentLength = byteArray.Length
    '        Dim dataStream As Stream = request.GetRequestStream()
    '        dataStream.Write(byteArray, 0, byteArray.Length)
    '        dataStream.Close()
    '        Dim response As WebResponse = request.GetResponse()
    '        dataStream = response.GetResponseStream()
    '        Dim reader As New StreamReader(dataStream)
    '        Dim responseFromServer As String = reader.ReadToEnd()
    '        reader.Close()
    '        dataStream.Close()
    '        response.Close()
    '        'Return (responseFromServer)
    '    Catch ex As Exception
    '        logError("Unable to send error log. " + ex.Message + " errorlog:53") 'write error to log
    '        'Dim error1 As String = ErrorToString()
    '        'If error1 = "Invalid URI: The format of the URI could not be determined." Then
    '        '    MsgBox("ERROR! Must have HTTP:// before the URL.")
    '        'Else
    '        '    MsgBox(error1)
    '        'End If
    '        'Return ("ERROR")
    '    End Try
    'End Sub
End Class
