Imports System.ComponentModel
Imports System.Net.Mail

Public Class forgotPW
    Private verificationCode As String

    Private Sub btnCancelCode_Click(sender As Object, e As EventArgs) Handles btnCancelCode.Click
        Me.Close()
    End Sub

    Private Sub lblResendCode_Click(sender As Object, e As EventArgs) Handles lblResendCode.Click
        If SendEmail() Then
            MessageBox.Show("Email successfully sent", "Success")
            txtPWConfirmationCode.Text = ""
            txtPWConfirmationCode.Focus()
        End If
    End Sub

    Private Sub forgotPW_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        txtPWConfirmationCode.Clear()
    End Sub

    Private Sub btnSubmitCode_Click(sender As Object, e As EventArgs) Handles btnSubmitCode.Click
        If txtPWConfirmationCode.Text.Trim = verificationCode Then
            ' save login time to variable
            MainMenu.myLoginTime = DateTime.Now()
            ' insert new login record
            LoginRecordTableAdapter1.InsertLoginRecord(MainMenu.myID, MainMenu.myName, MainMenu.myLoginTime)
            MainMenu.enableCurrentPW = False
            ChangePW.BackColor = System.Drawing.Color.AntiqueWhite
            ChangePW.Show()     'let user change their password
            Login.Hide()
            Me.Close()
        Else
            MessageBox.Show("Incorrect Verification Code", "Incorrect code")
            txtPWConfirmationCode.Clear()
            txtPWConfirmationCode.Focus()
        End If
    End Sub

    Private Sub forgotPW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SendEmail()
        txtPWConfirmationCode.Focus()
        Me.CenterToScreen()
    End Sub

    Protected Function SendEmail() As Boolean
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 100000 and 999999.
        verificationCode = (Int((89999 * Rnd()) + 10000)).ToString

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("yingzichan826@gmail.com", "yingzichan826") 'email account to send email
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("yingzichan826@gmail.com")
            e_mail.To.Add(MainMenu.myEmail)
            e_mail.Subject = "TRACE library system - Verification Code" 'email title
            e_mail.IsBodyHtml = False
            e_mail.Body = "Hi, " & MainMenu.myName & vbNewLine & vbNewLine &
                " A request to access your account has been made. Please use the following code to log into your account." &
                vbNewLine & vbNewLine & "Your Verification Code is: " & verificationCode & vbNewLine & vbNewLine &
                "If you did not make this request, please ignore this email." 'email body

            Smtp_Server.Send(e_mail)
            Return True
        Catch error_t As Exception
            MsgBox("Error sending email" + vbNewLine + "Please Try Again Later")
            Me.Close()
        End Try
        Return False
    End Function
End Class