Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text

Public Class Register_New_Staff
    Dim AddButtonClicked As Boolean = True
    Dim CloseByButton As Boolean = False
    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TRACE_Library_SystemDataSet)

    End Sub

    Private Sub Register_New_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        For Each ctrl In grpGender.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        For Each ctrl In grpUserType.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        grpUserType.ForeColor = myTextColor
        grpGender.ForeColor = myTextColor

        Me.CenterToScreen()
        Date_Of_EmploymentDateTimePicker.Format = DateTimePickerFormat.Custom
        Date_Of_EmploymentDateTimePicker.CustomFormat = " "
        Date_Of_EmploymentDateTimePicker.MaxDate = DateTime.Now()

        'TODO: This line of code loads data into the 'TRACE_Library_SystemDataSet.Staff' table. You can move, or remove it, as needed.
        'Me.StaffTableAdapter.Fill(Me.TRACE_Library_SystemDataSet.Staff)
        If Staff_Management.Register_Button_Clicked = True Then
            StaffBindingSource.EndEdit()
            StaffBindingSource.AddNew()
            grpUserType.Focus()
            btnClearProfilePicture.Enabled = False
            User_TypeTextBox.Text = "Administrator"
            Employment_StatusTextBox.Text = "Employed"
            Staff_IDMaskedTextBox.Enabled = False
            radAdministrator.Checked = True
        End If

        If AddButtonClicked = True Then
            Dim id As String
            Dim cmd As New SqlCommand
            Dim myConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True"
            Dim myConnection As New SqlConnection(myConnectionString)
            myConnection.Open()

            cmd.Connection = myConnection
            cmd.CommandText = "SELECT MAX([Staff ID]) FROM Staff"
            If cmd.ExecuteScalar Is Nothing Then
                Staff_IDMaskedTextBox.Text = "10001A"
            Else
                id = CType(CInt(cmd.ExecuteScalar.ToString.Substring(0, 5)) + 1, String)
                Staff_IDMaskedTextBox.Text = id + "A"
            End If
            myConnection.Close()
            AddButtonClicked = False
        End If
    End Sub

    Private Sub btnAddProfilePicture_Click(sender As Object, e As EventArgs) Handles btnAddProfilePicture.Click
        FileDialogProfilePicture.Filter = "Image Files(*.PNG;*.BMP;*.JPG;*.JPEG;*.GIF)|*.PNG;*.BMP;*.JPG;*.JPEG;*.GIF*."
        FileDialogProfilePicture.Title = "Please Select A File"
        FileDialogProfilePicture.InitialDirectory = "C:"

        Dim res As DialogResult = FileDialogProfilePicture.ShowDialog()
        If res = DialogResult.Cancel Then
            btnClearProfilePicture.Enabled = False
        ElseIf res = DialogResult.OK Then
            Profile_PicturePictureBox.ImageLocation = FileDialogProfilePicture.FileName.ToString
            btnClearProfilePicture.Enabled = True
            btnAddProfilePicture.Text = "C&hange Profile Picture"
        End If
    End Sub

    Private Sub btnClearProfilePicture_Click(sender As Object, e As EventArgs) Handles btnClearProfilePicture.Click
        Profile_PicturePictureBox.Image = Nothing
        btnAddProfilePicture.Text = "Add Profile &Picture"
        btnClearProfilePicture.Enabled = False
    End Sub

    Private Sub Staff_NameTextBox_LostFocus(sender As Object, e As EventArgs) Handles Staff_NameTextBox.LostFocus
        Staff_NameTextBox.Text = StrConv(Staff_NameTextBox.Text, VbStrConv.ProperCase)
    End Sub

    Private Sub Staff_ICMaskedTextBox_TextChanged(sender As Object, e As EventArgs) Handles Staff_ICMaskedTextBox.TextChanged
        PasswordTextBox.Text = Staff_ICMaskedTextBox.Text
    End Sub

    Private Sub radMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        If radMale.Checked = True Then
            Staff_GenderTextBox.Text = "Male"
        End If
    End Sub

    Private Sub radFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radFemale.CheckedChanged
        If radFemale.Checked = True Then
            Staff_GenderTextBox.Text = "Female"
        End If
    End Sub

    Private Sub radAdministrator_CheckedChanged(sender As Object, e As EventArgs) Handles radAdministrator.CheckedChanged
        Dim firstNumbers As String
        If Staff_IDMaskedTextBox.Text <> "" Then
            firstNumbers = Staff_IDMaskedTextBox.Text.Substring(0, 5)
            If radAdministrator.Checked = True Then
                User_TypeTextBox.Text = "Administrator"
                Staff_IDMaskedTextBox.Text = ""
                Staff_IDMaskedTextBox.Text &= firstNumbers
                Staff_IDMaskedTextBox.Text &= "A"
            End If
        End If
    End Sub

    Private Sub radLibrarianStaff_CheckedChanged(sender As Object, e As EventArgs) Handles radLibrarianStaff.CheckedChanged
        Dim firstNumbers As String
        If Staff_IDMaskedTextBox.Text <> "" Then
            firstNumbers = Staff_IDMaskedTextBox.Text.Substring(0, 5)
            If radLibrarianStaff.Checked = True Then
                User_TypeTextBox.Text = "Librarian Staff"
                Staff_IDMaskedTextBox.Text = ""
                Staff_IDMaskedTextBox.Text &= firstNumbers
                Staff_IDMaskedTextBox.Text &= "S"
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        DialogResult = MessageBox.Show("Are you sure you want to add this new staff?", "Add New Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = DialogResult.Yes Then
            Dim err As New StringBuilder()
            Dim ctr As Control = Nothing

            Dim userType As String = User_TypeTextBox.Text
            Dim name As String = Staff_NameTextBox.Text
            Dim gender As String = Staff_GenderTextBox.Text
            Dim email As String = Staff_EmailTextBox.Text
            Dim dateEmployment As String = Date_Of_EmploymentDateTimePicker.Text

            If name = "" Then
                err.AppendLine("- Staff Name Empty")
                ctr = If(ctr, Staff_NameTextBox)
            End If

            If Staff_ICMaskedTextBox.MaskFull = False Then
                err.AppendLine("- Staff IC Incomplete Format (12 Digits Required)")
                ctr = If(ctr, Staff_ICMaskedTextBox)
            End If

            If Staff_AddressTextBox.Text = "" Then
                err.AppendLine("- Staff Address Empty")
                ctr = If(ctr, Staff_AddressTextBox)
            End If

            If gender = "" Then
                err.AppendLine("- Staff Gender Empty")
                ctr = If(ctr, Staff_GenderTextBox)
            End If

            If Staff_Phone_NumberMaskedTextBox.MaskFull = False Then
                err.AppendLine("- Staff Phone Number Incomplete Format (10 Digits Required)")
                ctr = If(ctr, Staff_Phone_NumberMaskedTextBox)
            End If

            If email = "" Then
                err.AppendLine("- Staff Email Empty")
                ctr = If(ctr, Staff_EmailTextBox)
            Else
                Try
                    Dim testaddress As New MailAddress(email)
                Catch ex As Exception
                    err.AppendLine(" - Staff Email Invalid Format")
                    ctr = If(ctr, Staff_EmailTextBox)
                End Try
            End If

            If dateEmployment = " " Then
                err.AppendLine("- Staff Employment Date Empty")
                ctr = If(ctr, Date_Of_EmploymentDateTimePicker)
            End If

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Failed To Add Staff (Input Error)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                ctr.Focus()
                Return
            Else
                Staff_NameTextBox.Text.Trim()
                Staff_EmailTextBox.Text.Trim()
                StaffBindingSource.EndEdit()
                StaffTableAdapter.Update(TRACE_Library_SystemDataSet.Staff)
                MessageBox.Show("New Staff Added", "New Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            radAdministrator.Checked = False
            radLibrarianStaff.Checked = False
            radMale.Checked = False
            radFemale.Checked = False
            Staff_IDMaskedTextBox.Text = ""
            AddButtonClicked = True
            Register_New_Staff_Load(Nothing, Nothing)
        Else
            Return
        End If
    End Sub

    Private Sub Date_Of_EmploymentDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_Of_EmploymentDateTimePicker.ValueChanged
        Date_Of_EmploymentDateTimePicker.Format = DateTimePickerFormat.Custom
        Date_Of_EmploymentDateTimePicker.CustomFormat = "dd    /MMMM/    yyyy"
    End Sub

    Private Sub Staff_ICMaskedTextBox_Click(sender As Object, e As EventArgs) Handles Staff_ICMaskedTextBox.Click
        If Staff_ICMaskedTextBox.Text.Length = 0 Then
            Staff_ICMaskedTextBox.Select(0, 0)
        End If
    End Sub

    Private Sub Staff_Phone_NumberMaskedTextBox_CLick(sender As Object, e As EventArgs) Handles Staff_Phone_NumberMaskedTextBox.Click
        If Staff_Phone_NumberMaskedTextBox.Text.Length = 0 Then
            Staff_Phone_NumberMaskedTextBox.Select(0, 0)
        End If
    End Sub

    Private Sub Register_New_Staff_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CloseByButton = False Then
            If Staff_NameTextBox.Text.Length <> 0 Or Staff_ICMaskedTextBox.Text.Length <> 0 Or Staff_AddressTextBox.Text.Length <> 0 Or
        Staff_GenderTextBox.Text.Length <> 0 Or Staff_Phone_NumberMaskedTextBox.Text.Length <> 0 Or Staff_EmailTextBox.Text.Length <> 0 Or
        Date_Of_EmploymentDateTimePicker.Text <> " " Then
                DialogResult = MessageBox.Show("Warning! You are about to close this window." & vbNewLine & "Any input data will not be saved" & vbNewLine & "Are you sure you want to close this window?", "Closing Window", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If DialogResult = DialogResult.Yes Then
                    Staff_Management.Register_Button_Clicked = False
                    Staff_Management.Show()
                Else
                    e.Cancel = True
                End If
            Else
                Staff_Management.Register_Button_Clicked = False
                Staff_Management.Show()
            End If
        End If
    End Sub

    Private Sub btnReturnToStaffManagement_Click(sender As Object, e As EventArgs) Handles btnReturnToStaffManagement.Click
        If Staff_NameTextBox.Text.Length <> 0 Or Staff_ICMaskedTextBox.Text.Length <> 0 Or Staff_AddressTextBox.Text.Length <> 0 Or
        Staff_GenderTextBox.Text.Length <> 0 Or Staff_Phone_NumberMaskedTextBox.Text.Length <> 0 Or Staff_EmailTextBox.Text.Length <> 0 Or
        Date_Of_EmploymentDateTimePicker.Text <> " " Then
            DialogResult = MessageBox.Show("Warning! You are about to close this window." & vbNewLine & " Any input data will not be saved" & vbNewLine & "Are you sure you want to close this window?", "Closing Window", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If DialogResult = DialogResult.Yes Then
                Staff_Management.Register_Button_Clicked = False
                CloseByButton = True
                Staff_Management.Show()
                Me.Close()
            End If
        Else
            Staff_Management.Show()
            Me.Close()
        End If
    End Sub

End Class