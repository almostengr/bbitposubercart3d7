Imports xmlsettings.Settings
Imports System.Net
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports BBIT_POS_Ubercart3_SFTP

Public Class utils_admin
    Private appSettings As New xmlsettings.Settings()
    Private utilsSftp As New utils_sftp
    Private writeToPOSLog As New posLogger

    Public Sub updateCustomerDb()

    End Sub

    Public Sub updateProductDb()

    End Sub

    Public Function loginCorrect(ByVal enteredPassword As String) As Boolean
        'confirms whether admin login is correct
        Dim pwdSuccess As Boolean = False

        Dim [source] As String = enteredPassword
        Using md5Hash As MD5 = MD5.Create()

            If enteredPassword = appSettings.GetSetting("adminPassword") Then
                pwdSuccess = True
            Else
                pwdSuccess = False
            End If
        End Using

        Return pwdSuccess
    End Function

    Public Sub updateAdminPwd(ByVal newPassword As String)
        'updates the administrator password
        appSettings.SetSetting("adminPassword", newPassword) 'sets new password, saves it to settings file
        MsgBox("Password successfully changed!", MsgBoxStyle.Information, My.Application.Info.ProductName)
    End Sub

    Public Sub updateShutDownEndOfBusDay(ByVal updateFlag As Boolean)
        'sets whether the computer should be shutdown after closing
        appSettings.SetSetting("shutDownAfterEndOfBusinessDay", updateFlag)
    End Sub

    Public Function getShutDownEndOfBusDay()
        'gets the value of if the computer should shut down after running end of day processing
        Return appSettings.GetSetting("shutDownAfterEndOfBusinessDay")
    End Function

    Public Sub invalidPassword()
        'prompts user that the password that was entered is incorrect.
        MsgBox("Incorrect password!", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        writeToPOSLog.logError("ERROR: Incorrect administrator password was entered.")
    End Sub

    Public Function getDataFromWebsite(ByVal whatToGet As String)
        'get requested data from website. 

        Dim didSucceed As Boolean = False

        Try
            ' make a Web request
            Dim request As WebRequest = WebRequest.Create(appSettings.GetSetting("storeWebsite") + _
                                                              "/bbitpos.php?update=" + whatToGet)

            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Dim responseStream As System.IO.Stream = response.GetResponseStream()
            Dim responseStreamReader As System.IO.StreamReader = New StreamReader(responseStream) '= New System.IO.StreamReader(Str)

            Try
                Dim dataArray As Array
                Dim currentLine As String

                While (responseStreamReader.Peek <> -1) 'read all the lines of the stream
                    currentLine = responseStreamReader.ReadLine 'read each line
                    dataArray = Split(currentLine, "|") 'find the pipe and split into an array called temp

                    If whatToGet = "products" Then
                        'connect to website
                        System.Threading.Thread.Sleep(5000) 'wait five seconds 
                        'get file via sftp

                        'parse and read file into database
                    ElseIf whatToGet = "storeinfo" Then
                        appSettings.SetSetting("storeName", dataArray(0))
                        appSettings.SetSetting("storeAddr1", dataArray(1))
                        appSettings.SetSetting("storeAddr2", dataArray(2))
                        appSettings.SetSetting("storeCity", dataArray(3))
                        appSettings.SetSetting("storeState", dataArray(4))
                        appSettings.SetSetting("storeZip", dataArray(5))
                        appSettings.SetSetting("storePhone", dataArray(6))
                        appSettings.SetSetting("decimalPlaces", dataArray(7))

                    ElseIf whatToGet = "ping" Then
                        'do nothing
                    ElseIf whatToGet = "customers" Then
                        'contact website to update files
                        System.Threading.Thread.Sleep(5000) 'wait five seconds 
                        'get file via sftp
                        'parse and read file into database
                    Else
                        'therotically shouldn't happen, throw exception
                        Throw New Exception("Unable to determine what to get from the website. utilsadmin:92")
                    End If
                End While

                didSucceed = True
            Catch ex As Exception
                didSucceed = False
                writeToPOSLog.logError("ERROR: " & ex.Message)
            Finally
                responseStreamReader.Close()  'Close Stream and StreamReader when done
                responseStream.Close()
            End Try
        Catch webEx As WebException
            didSucceed = False
            writeToPOSLog.logError("ERROR: " & webEx.Message)
        Finally
            'do nothing
        End Try

        Return didSucceed
    End Function

    'Private Sub updateCustomersDb()
    '    'update the customers database with data from the website.
    '    Dim dataArray As Array
    '    Dim currentLine As String
    '    'Dim ucc As New ucCustomer

    '    Try
    '        'contact website to update file
    '        utilsSftp.downloadFileFromWeb("customers.txt")

    '        'read file 
    '        Dim fileStreamReader As New StreamReader(My.Application.Info.DirectoryPath + "\customers.txt")
    '        While (fileStreamReader.Peek <> -1) 'read all the lines of the stream

    '            currentLine = fileStreamReader.ReadLine 'read each line
    '            dataArray = Split(currentLine, "|") 'find the pipe and split into an array

    '            'customers file into db columns
    '            'ucc.ucCustomerId = CInt(dataArray(0))

    '            'save/update database row

    '        End While

    '        'delete the file after done processing, place in recycle bin
    '        My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\customers.txt", _
    '                                             FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
    '    Catch ex As Exception
    '        writeToPOSLog.logError(ex.Message)
    '    End Try
    'End Sub


    Shared Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String

        ' Convert the input string to a byte array and compute the hash. 
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder() ' Create a new Stringbuilder to collect the bytes and create a string. 

        ' Loop through each byte of the hashed data and format each one as a hexadecimal string. 
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString() ' Return the hexadecimal string. 
    End Function 'GetMd5Hash

    Shared Function VerifyMd5Hash(ByVal md5Hash As MD5, ByVal input As String, ByVal hash As String) As Boolean
        ' Verify a hash against a string. 

        Dim hashOfInput As String = GetMd5Hash(md5Hash, input) ' Hash the input. 
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase ' Create a StringComparer an compare the hashes. 
        If 0 = comparer.Compare(hashOfInput, hash) Then
            Return True
        Else
            Return False
        End If
    End Function 'VerifyMd5Hash

End Class
