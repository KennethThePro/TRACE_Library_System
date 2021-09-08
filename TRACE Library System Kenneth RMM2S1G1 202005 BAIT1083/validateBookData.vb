Imports System.Data.SqlClient
Imports System.Text

Module validateBookData
    Public err As New StringBuilder()

    Function validBookData(ByVal Title As String, ByVal Author As String, ByVal Pages As String,
                           ByVal Category As String, ByVal Language As String,
                           ByVal AddDate As String) As Boolean
        err.Clear()

        If Title = "" Then
            err.AppendLine("- Book Title Empty")
        End If

        If Author = "" Then
            err.AppendLine("- Author Name Empty")
        End If

        If Pages = "" Then
            err.AppendLine("- Pages Not Provided")
        End If

        If Category = "" Then
            err.AppendLine("- Category Not Chosen")
            'ctr = If(ctr, Staff_EmailTextBox)
        End If

        If Language = "" Then
            err.AppendLine("- Language Not Chosen")
        End If

        If AddDate = " " Then
            err.AppendLine("- Date Added Empty")
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Failed To Process Input (Input Error)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return False
        Else
            Return True
        End If
    End Function


    Function isDuplicateISBN(ByVal ISBN As String) As Integer
        OpenConnection()
        Dim cmd As SqlCommand = New SqlCommand("SELECT COUNT(*) AS numRows FROM Book WHERE [ISBN] = '" & ISBN & "'", conn)
        Return CInt(cmd.ExecuteScalar())
        CloseConnection()
    End Function

    Sub NumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

End Module
