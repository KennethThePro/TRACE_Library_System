Imports System.ComponentModel

Public Class Login
    Private Sub refreshForm() 'erase all data
        txtID.Text = ""
        txtPassword.Text = ""
        txtID.Focus()
    End Sub

    Private Sub lblForgotPW_Click(sender As Object, e As EventArgs) Handles lblForgotPW.Click
        Dim email As String = ""
        Dim type As String = ""
        If txtID.Text = "" Then
            MessageBox.Show("User ID is empty", "User not Found")
            txtPassword.Clear()
            txtID.Focus()
        Else
            Try
                If txtID.Text.Trim.EndsWith("A") Then
                    email = getEmail(txtID.Text, "Administrator")
                    type = "Administrator"
                ElseIf txtID.Text.Trim.EndsWith("S") Then
                    email = getEmail(txtID.Text, "Librarian Staff")
                    type = "Librarian Staff"
                End If
                If email <> "" Then
                    MainMenu.Show()
                    MainMenu.Hide()
                    MainMenu.myID = txtID.Text
                    MainMenu.myEmail = email
                    MainMenu.myType = type
                    If type = "Administrator" Then
                        MainMenu.enableStaffManagement = True
                    Else
                        MainMenu.enableStaffManagement = False
                    End If
                    forgotPW.ShowDialog()
                Else
                    MessageBox.Show("Invalid User ID", "User not Found")
                    refreshForm()
                End If
            Catch ex As Exception
                MessageBox.Show("Invalid User ID", "User not Found")
                refreshForm()
            End Try
        End If
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If txtID.Text.Trim.EndsWith("A") Then
            Search_Record(txtID.Text, "Administrator")
        ElseIf txtID.Text.Trim.EndsWith("S") Then
            Search_Record(txtID.Text, "Librarian Staff")
        Else
            Invalid_ID_or_PW()
        End If
    End Sub

    Private Sub Search_Record(ByVal strStaffID As String, ByVal type As String)
        Dim staffTable As TRACE_Library_SystemDataSet.StaffDataTable
        Try
            staffTable = StaffTableAdapterLoginPage.GetDataByID(strStaffID, type)
        Catch ex As Exception
            MessageBox.Show("Error Connecting to Server, Please Try Again", "Error")
        End Try


        If staffTable.Count <> 0 Then
            If txtPassword.Text <> staffTable(0).Password Then
                Invalid_ID_or_PW()
                Exit Sub
            End If
            With MainMenu
                .Show()
                .Hide()
                .myID = txtID.Text
                .myType = type
                .myName = staffTable(0).Staff_Name

                If type = "Administrator" Then
                    .enableStaffManagement = True
                Else
                    .enableStaffManagement = False
                End If

                .myLoginTime = DateTime.Now()
                LoginRecordTableAdapterLoginPage.InsertLoginRecord(txtID.Text, MainMenu.myName, MainMenu.myLoginTime)

                If ChangePW.invalidPWFormat(txtPassword.Text) Then
                    .enableCurrentPW = False
                    ChangePW.Show()
                Else
                    .Show()
                End If
            End With
            Me.Hide()
        Else
            Invalid_ID_or_PW()
        End If
    End Sub

    Private Function getEmail(ByVal strStaffID As String, ByVal type As String) As String
        Dim staffTable As TRACE_Library_SystemDataSet.StaffDataTable
        staffTable = StaffTableAdapterLoginPage.GetDataByID(strStaffID, type)
        MainMenu.myName = staffTable(0).Staff_Name

        If staffTable.Count <> 0 Then
            Return staffTable(0).Staff_Email
        End If
        Return ""
    End Function

    Private Sub Invalid_ID_or_PW()
        Dim errMsg = ""
        If txtID.Text.Trim = "" Then
            errMsg += "User ID is empty" + vbNewLine
        End If

        If txtPassword.Text.Trim = "" Then
            errMsg += "User Password is empty"
        End If

        If errMsg = "" Then
            errMsg = "Invalid user ID or password. "
        End If

        MessageBox.Show(errMsg, "User not Found")
        refreshForm()
    End Sub

    Private Sub Login_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        refreshForm()
        lightmode()
    End Sub
End Class