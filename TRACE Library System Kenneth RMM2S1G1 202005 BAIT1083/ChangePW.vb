Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class ChangePW
    Private Sub ChangePW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        Me.Label1.ForeColor = myTextColor
        Me.Label2.ForeColor = myTextColor
        Me.Label3.ForeColor = myTextColor
        txtCurrentPW.Enabled = MainMenu.enableCurrentPW
        btnCancelCode.Enabled = MainMenu.enableCurrentPW
        Me.CenterToScreen()
    End Sub

    Private Sub btnCancelCode_Click(sender As Object, e As EventArgs) Handles btnCancelCode.Click
        Me.Close()
    End Sub

    Private Sub ChangePW_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainMenu.Show()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If Check_Password() Then
            StaffTableAdapter1.UpdatePWByID(txtNewPW.Text, MainMenu.myID)
            MessageBox.Show("Password Successfully Changed", "Success")
            Me.Close()
        End If
    End Sub

    Private Function Check_Password() As Boolean
        Dim staffTable As TRACE_Library_SystemDataSet.StaffDataTable
        staffTable = StaffTableAdapter1.GetDataByID(MainMenu.myID, MainMenu.myType)

        Dim errMsg = ""
        If txtCurrentPW.Text = "" And MainMenu.enableCurrentPW Then
            errMsg += "Please enter Current Password" + vbNewLine
        End If

        If txtNewPW.Text = "" Then
            errMsg += "Please enter New Password" + vbNewLine
        End If

        If txtConfirmNewPW.Text = "" Then
            errMsg += "Please Confirm New Password"
        End If

        If errMsg <> "" Then
            Display_ErrMsg(errMsg)
            Return False
        End If

        errMsg = ""

        If txtCurrentPW.Text <> staffTable(0).Password And MainMenu.enableCurrentPW Then
            errMsg = "Incorrect Current Password"
        End If

        If errMsg = "" And txtNewPW.Text = staffTable(0).Password And MainMenu.enableCurrentPW Then
            errMsg = "New Password can't be the same as Current Password "
        End If

        If errMsg = "" And txtNewPW.Text <> txtConfirmNewPW.Text Then
            errMsg = "New password does not equals to Confirm New Password"
        End If

        If errMsg <> "" Then
            Display_ErrMsg(errMsg)
            Return False
        End If

        If invalidPWFormat(txtNewPW.Text) Then
            errMsg = "New Password must satisfy the following Requirements: " + vbNewLine + "- 8 to 40 characters long" + vbNewLine +
                "- Contain at least one lower case letter" + vbNewLine + "- Contain at least one upper case letter" + vbNewLine + "- Contain at least one digit"
            Display_ErrMsg(errMsg)
            Return False
        End If
        Return True
    End Function

    Private Sub Display_ErrMsg(ByVal errMsg As String)
        MessageBox.Show(errMsg, "Password Changing Error")
        txtConfirmNewPW.Text = ""
        txtNewPW.Text = ""
        txtCurrentPW.Text = ""
    End Sub

    Public Function invalidPWFormat(PW As String) As Boolean
        Dim MatchNumberPattern As String = "^.*(?=.{8,40})(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$"
        If Not Regex.IsMatch(PW, MatchNumberPattern) Then
            Return True
        End If
        Return False
    End Function

End Class