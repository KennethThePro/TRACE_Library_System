Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Net.Mail

Public Class Search_Staff_and_Update_Staff
    Dim EditButtonClicked As Boolean = False
    Dim InitialRun As Boolean = True
    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TRACE_Library_SystemDataSet)
    End Sub

    Private Sub Search_Staff_and_Update_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        grpStaffInformation.ForeColor = myTextColor
        For Each ctrl In Me.grpStaffInformation.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
            If TypeOf ctrl Is RadioButton Then
                Dim lbl = DirectCast(ctrl, RadioButton)
                lbl.ForeColor = myTextColor
            End If
        Next
        grpType.ForeColor = myTextColor
        Me.CenterToScreen()
        If InitialRun = True Then
            cboSearchBy.SelectedIndex = 0
            Date_Of_EmploymentDateTimePicker.Format = DateTimePickerFormat.Custom
            Date_Of_UnemploymentDateTimePicker.Format = DateTimePickerFormat.Custom
            Date_Of_EmploymentDateTimePicker.CustomFormat = " "
            Date_Of_UnemploymentDateTimePicker.CustomFormat = " "
            Date_Of_EmploymentDateTimePicker.MaxDate = DateTime.Now()
            Date_Of_UnemploymentDateTimePicker.MaxDate = DateTime.Now()
            InitialRun = False
        End If

        'TODO: This line of code loads data into the 'TRACE_Library_SystemDataSet.Staff' table. You can move, or remove it, as needed.
        'Me.StaffTableAdapter.Fill(Me.TRACE_Library_SystemDataSet.Staff)
    End Sub

    Private Sub btnUpdateProfilePicture_Click(sender As Object, e As EventArgs) Handles btnUpdateProfilePicture.Click
        FileDialogProfilePicture.Filter = "Image Files(*.PNG;*.BMP;*.JPG;*.JPEG;*.GIF)|*.PNG;*.BMP;*.JPG;*.JPEG;*.GIF*."
        FileDialogProfilePicture.Title = "Please Select A File"
        FileDialogProfilePicture.InitialDirectory = "C:"
        Dim res As DialogResult = FileDialogProfilePicture.ShowDialog()
        If res = DialogResult.Cancel Then
            Return
        ElseIf res = DialogResult.OK Then
            Profile_PicturePictureBox.ImageLocation = FileDialogProfilePicture.FileName.ToString
            btnClearProfilePicture.Enabled = True
        End If

    End Sub

    Private Sub btnClearProfilePicture_Click(sender As Object, e As EventArgs) Handles btnClearProfilePicture.Click
        Profile_PicturePictureBox.Image = Nothing
        btnClearProfilePicture.Enabled = False
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

    Private Sub radEmployed_CheckedChanged(sender As Object, e As EventArgs) Handles radEmployed.CheckedChanged
        If radEmployed.Checked = True Then
            Employment_StatusTextBox.Text = "Employed"
            Date_Of_UnemploymentDateTimePicker.Format = DateTimePickerFormat.Custom
            Date_Of_UnemploymentDateTimePicker.CustomFormat = " "
            Date_Of_UnemploymentDateTimePicker.Enabled = False
            Reason_Of_UnemploymentTextBox.ReadOnly = True
            Reason_Of_UnemploymentTextBox.ReadOnly = True
            Reason_Of_UnemploymentTextBox.Text = ""
        End If
    End Sub

    Private Sub radUnemployed_CheckedChanged(sender As Object, e As EventArgs) Handles radUnemployed.CheckedChanged
        If radUnemployed.Checked = True Then
            Employment_StatusTextBox.Text = "Unemployed"
            If EditButtonClicked = True Then
                Date_Of_UnemploymentDateTimePicker.Enabled = True
                Date_Of_UnemploymentDateTimePicker.Format = DateTimePickerFormat.Custom
                Date_Of_UnemploymentDateTimePicker.CustomFormat = " "
                Reason_Of_UnemploymentTextBox.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub cboSearchBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchBy.SelectedIndexChanged
        If cboSearchBy.SelectedIndex = 0 Then
            With txtSearch
                .AutoCompleteMode = Nothing
                .AutoCompleteCustomSource.Clear()
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
            txtSearch.MaxLength = 6
            btnSearch.Enabled = True
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True")
                con.Open()
                Dim SearchQuery As String = "SELECT Distinct([Staff ID]) From Staff"
                Using cmd As SqlCommand = New SqlCommand(SearchQuery, con)
                    Using rd As SqlDataReader = cmd.ExecuteReader
                        While rd.Read
                            With txtSearch
                                .AutoCompleteMode = AutoCompleteMode.Suggest
                                .AutoCompleteCustomSource.Add(CStr(rd.Item(0)))
                                .AutoCompleteSource = AutoCompleteSource.CustomSource
                            End With
                        End While
                    End Using
                End Using
                con.Close()
            End Using
        ElseIf cboSearchBy.SelectedIndex = 1 Then
            With txtSearch
                .AutoCompleteMode = Nothing
                .AutoCompleteCustomSource.Clear()
                .AutoCompleteSource = AutoCompleteSource.CustomSource
            End With
            txtSearch.MaxLength = 50
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True")
                con.Open()
                Dim SearchQuery As String = "SELECT Distinct([Staff Name]) From Staff"
                Using cmd As SqlCommand = New SqlCommand(SearchQuery, con)
                    Using rd As SqlDataReader = cmd.ExecuteReader
                        While rd.Read
                            With txtSearch
                                .AutoCompleteMode = AutoCompleteMode.Suggest
                                .AutoCompleteCustomSource.Add(CStr(rd.Item(0)))
                                .AutoCompleteSource = AutoCompleteSource.CustomSource
                            End With
                        End While
                    End Using
                End Using
                con.Close()
            End Using
        End If
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If (txtSearch.Text.Trim().Length > 0) Then
            btnSearch.Enabled = True
        Else
            btnSearch.Enabled = False
        End If
    End Sub

    Private Sub Date_Of_EmploymentDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_Of_EmploymentDateTimePicker.ValueChanged
        Date_Of_EmploymentDateTimePicker.Format = DateTimePickerFormat.Custom
        Date_Of_EmploymentDateTimePicker.CustomFormat = "dd    /MMMM/    yyyy"
    End Sub

    Private Sub Date_Of_UnemploymentDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_Of_UnemploymentDateTimePicker.ValueChanged
        Date_Of_UnemploymentDateTimePicker.Format = DateTimePickerFormat.Custom
        Date_Of_UnemploymentDateTimePicker.CustomFormat = "dd    /MMMM/    yyyy"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SetSearchStatus()
        btnEdit.Focus()
        Dim SearchQuery As String
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True")

            If cboSearchBy.SelectedIndex = 0 Then
                SearchQuery = "SELECT * FROM Staff where [Staff ID] = '" & txtSearch.Text.Trim.ToUpper & "'"
            Else
                SearchQuery = "SELECT * FROM Staff where [Staff Name] LIKE '%" & txtSearch.Text.Trim.ToUpper & "%'"
            End If
            Using cmd As SqlCommand = New SqlCommand(SearchQuery, con)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            If btnClearProfilePicture.Enabled = False And EditButtonClicked = True Then
                                Profile_PicturePictureBox.Image = Nothing
                            Else
                                Dim data As Byte() = TryCast(dt.Rows(0)(0), Byte())
                                If data IsNot Nothing Then
                                    data = DirectCast(dt.Rows(0)(0), Byte())
                                    Using ms As New MemoryStream(data)
                                        Profile_PicturePictureBox.Image = Image.FromStream(ms)
                                    End Using
                                End If
                            End If

                            Staff_IDMaskedTextBox.Text = dt.Rows(0)(1).ToString()
                            Staff_NameTextBox.Text = dt.Rows(0)(2).ToString()
                            Staff_ICMaskedTextBox.Text = dt.Rows(0)(3).ToString()
                            Staff_AddressTextBox.Text = dt.Rows(0)(4).ToString()
                            Staff_GenderTextBox.Text = dt.Rows(0)(5).ToString()
                            Staff_Phone_NumberMaskedTextBox.Text = dt.Rows(0)(6).ToString()
                            Staff_EmailTextBox.Text = dt.Rows(0)(7).ToString()
                            User_TypeTextBox.Text = dt.Rows(0)(8).ToString()
                            Employment_StatusTextBox.Text = dt.Rows(0)(9).ToString()
                            Date_Of_EmploymentDateTimePicker.Format = DateTimePickerFormat.Custom
                            Date_Of_UnemploymentDateTimePicker.Format = DateTimePickerFormat.Custom
                            Date_Of_EmploymentDateTimePicker.CustomFormat = "dd    /MMMM/    yyyy"

                            Date_Of_EmploymentDateTimePicker.Value = Convert.ToDateTime(dt.Rows(0)(10))
                            If Employment_StatusTextBox.Text = "Unemployed" Then
                                Date_Of_UnemploymentDateTimePicker.CustomFormat = "dd    /MMMM/    yyyy"
                                Date_Of_UnemploymentDateTimePicker.Value = Convert.ToDateTime(dt.Rows(0)(11))
                                Reason_Of_UnemploymentTextBox.Text = dt.Rows(0)(12).ToString
                            Else
                                Date_Of_UnemploymentDateTimePicker.CustomFormat = " "
                                Reason_Of_UnemploymentTextBox.Text = ""
                            End If
                            Radio_Button_Update_When_Searching()
                        Else
                            MessageBox.Show("No Record", "Staff Record Does Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            grpStaffInformation.Enabled = False
                        End If
                    End Using
                End Using
            End Using
            con.Close()
        End Using
    End Sub

    Private Sub Radio_Button_Update_When_Searching()
        If Staff_GenderTextBox.Text = "Male" Then
            radMale.Checked = True
        ElseIf Staff_GenderTextBox.Text = "Female" Then
            radFemale.Checked = True
        End If

        If User_TypeTextBox.Text = "Administrator" Then
            radAdministrator.Checked = True
        ElseIf User_TypeTextBox.Text = "Librarian Staff" Then
            radLibrarianStaff.Checked = True
        End If

        If Employment_StatusTextBox.Text = "Employed" Then
            radEmployed.Checked = True
        ElseIf Employment_StatusTextBox.Text = "Unemployed" Then
            radUnemployed.Checked = True
            grpEmploymentStatus.Enabled = False
        End If
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        btnSearch.Enabled = True
        btnClearSearch.Enabled = False
        cboSearchBy.Enabled = True
        txtSearch.Enabled = True
        Profile_PicturePictureBox.Image = Nothing

        For Each groupboxControl In Me.Controls.OfType(Of GroupBox)()
            For Each txt In groupboxControl.Controls.OfType(Of TextBox)()
                txt.Text = ""
            Next
            For Each msktxt In groupboxControl.Controls.OfType(Of MaskedTextBox)
                msktxt.Text = ""
            Next
        Next

        Date_Of_EmploymentDateTimePicker.Format = DateTimePickerFormat.Custom
        Date_Of_UnemploymentDateTimePicker.Format = DateTimePickerFormat.Custom
        Date_Of_EmploymentDateTimePicker.CustomFormat = " "
        Date_Of_UnemploymentDateTimePicker.CustomFormat = " "
        radAdministrator.Checked = False
        radLibrarianStaff.Checked = False
        radMale.Checked = False
        radFemale.Checked = False
        radEmployed.Checked = False
        radUnemployed.Checked = False

        cboSearchBy.SelectedIndex = 0
        cboSearchBy.Focus()
        txtSearch.Text = ""
        grpStaffInformation.Enabled = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnClearSearch.Enabled = False
        btnCancel.Enabled = True
        btnReturnToStaffManagement.Enabled = False
        EditButtonClicked = True
        EditMode()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DialogResult = MessageBox.Show("Are you sure you want to update this staff information?", "Update Staff Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = DialogResult.Yes Then
            Dim myConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True"
            Dim myConnection As New SqlConnection(myConnectionString)
            Dim rows As Integer
            Dim myCommand As SqlCommand = myConnection.CreateCommand()

            myConnection.Open()

            Dim err As New StringBuilder()
            Dim ctr As Control = Nothing

            Dim name As String = Staff_NameTextBox.Text
            Dim gender As String = Staff_GenderTextBox.Text
            Dim email As String = Staff_EmailTextBox.Text
            Dim dateEmployment As String = Date_Of_EmploymentDateTimePicker.Text
            Dim reasonOfUnemployment As String = Reason_Of_UnemploymentTextBox.Text

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

            If radUnemployed.Checked = True Then
                If Date_Of_UnemploymentDateTimePicker.Text = " " Then
                    err.AppendLine("- Date of Unemployment Not Selected")
                    ctr = If(ctr, Date_Of_UnemploymentDateTimePicker)
                End If

                If Date_Of_UnemploymentDateTimePicker.Value < Date_Of_EmploymentDateTimePicker.Value Then
                    err.AppendLine("- Invalid Date of Unemployment. Date Must Be More or Equal Than The Employed Date")
                    ctr = If(ctr, Date_Of_UnemploymentDateTimePicker)
                End If

                If reasonOfUnemployment = "" Then
                    err.AppendLine("- Please Provide Reason of Unemployment")
                    ctr = If(ctr, Reason_Of_UnemploymentTextBox)
                End If
            End If

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Failed To Update Staff Information (Input Error)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                ctr.Focus()
                Return
            Else
                If Employment_StatusTextBox.Text = "Unemployed" Then
                    Staff_NameTextBox.Text.Trim()
                    Staff_AddressTextBox.Text.Trim()
                    Staff_EmailTextBox.Text.Trim()
                    Reason_Of_UnemploymentTextBox.Text.Trim()
                    myCommand.CommandText = "Update Staff Set [Staff Name] = '" + Staff_NameTextBox.Text + "', [Staff IC] = '" + Staff_ICMaskedTextBox.Text + "', [Staff Address] = '" + Staff_AddressTextBox.Text + "', [Staff Gender] = '" + Staff_GenderTextBox.Text + "',[Staff Phone Number] = '" + Staff_Phone_NumberMaskedTextBox.Text + "', [Staff Email] = '" + Staff_EmailTextBox.Text + "', [User Type] = '" + User_TypeTextBox.Text + "', [Employment Status] = '" + Employment_StatusTextBox.Text + "',[Date Of Unemployment] = '" + CType(Date_Of_UnemploymentDateTimePicker.Value, String) + "', [Reason Of Unemployment] = '" + Reason_Of_UnemploymentTextBox.Text + "' where [Staff ID] = '" & Staff_IDMaskedTextBox.Text & "'"
                    rows = myCommand.ExecuteNonQuery()
                    myConnection.Close()

                    If Not Profile_PicturePictureBox.Image Is Nothing Then
                        Dim ms As New MemoryStream
                        Dim bm As Bitmap = New Bitmap(Profile_PicturePictureBox.Image)
                        bm.Save(ms, Profile_PicturePictureBox.Image.RawFormat)
                        Dim arrPic() As Byte = ms.GetBuffer()
                        Dim conn As SqlConnection
                        conn = New SqlConnection()
                        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True"
                        conn.Open()
                        Dim sqlquery = "Update Staff Set [Profile Picture] = @Image WHERE [Staff ID] = '" + Staff_IDMaskedTextBox.Text + "'"
                        myCommand = New SqlCommand(sqlquery, conn)
                        myCommand.Parameters.AddWithValue("@Image", arrPic)
                        rows = myCommand.ExecuteNonQuery()
                        conn.Close()
                    Else
                        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True"
                        conn.Open()
                        Dim sqlquery = "Update Staff Set [Profile Picture] = @Image WHERE [Staff ID] = '" + Staff_IDMaskedTextBox.Text + "'"
                        myCommand = New SqlCommand(sqlquery, conn)
                        myCommand.Parameters.Add("@Image", SqlDbType.VarBinary).Value = DBNull.Value
                        rows = myCommand.ExecuteNonQuery()
                        conn.Close()
                    End If

                Else
                    Staff_NameTextBox.Text.Trim()
                    Staff_EmailTextBox.Text.Trim()
                    myCommand.CommandText = "Update Staff Set [Staff Name] = '" + Staff_NameTextBox.Text + "', [Staff IC] = '" + Staff_ICMaskedTextBox.Text + "', [Staff Address] = '" + Staff_AddressTextBox.Text + "',[Staff Gender] = '" + Staff_GenderTextBox.Text + "',[Staff Phone Number] = '" + Staff_Phone_NumberMaskedTextBox.Text + "', [Staff Email] = '" + Staff_EmailTextBox.Text + "', [User Type] = '" + User_TypeTextBox.Text + "', [Employment Status] = '" + Employment_StatusTextBox.Text + "'  where [Staff ID] = '" & Staff_IDMaskedTextBox.Text & "'"
                    rows = myCommand.ExecuteNonQuery()
                    myConnection.Close()

                    If Not Profile_PicturePictureBox.Image Is Nothing Then
                        Dim ms As New MemoryStream
                        Dim bm As Bitmap = New Bitmap(Profile_PicturePictureBox.Image)
                        bm.Save(ms, Profile_PicturePictureBox.Image.RawFormat)
                        Dim arrPic() As Byte = ms.GetBuffer()
                        Dim conn As SqlConnection
                        conn = New SqlConnection()
                        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True"
                        conn.Open()
                        Dim sqlquery = "Update Staff Set [Profile Picture] = @Image WHERE [Staff ID] = '" + Staff_IDMaskedTextBox.Text + "'"
                        myCommand = New SqlCommand(sqlquery, conn)
                        myCommand.Parameters.AddWithValue("@Image", arrPic)
                        rows = myCommand.ExecuteNonQuery()
                        conn.Close()
                    Else
                        conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True"
                        conn.Open()
                        Dim sqlquery = "Update Staff Set [Profile Picture] = @Image WHERE [Staff ID] = '" + Staff_IDMaskedTextBox.Text + "'"
                        myCommand = New SqlCommand(sqlquery, conn)
                        myCommand.Parameters.Add("@Image", SqlDbType.VarBinary).Value = DBNull.Value
                        rows = myCommand.ExecuteNonQuery()
                        conn.Close()
                    End If
                End If

                DoneEdit()
                btnEdit.Enabled = True
                btnSave.Enabled = False
                btnCancel.Enabled = False
                EditButtonClicked = False
                btnClearSearch.Enabled = True
                btnReturnToStaffManagement.Enabled = True
                MessageBox.Show("Staff Information Has Been Updated", "Staff Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Return
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = MessageBox.Show("Warning! You have decided to cancel the edit process" & vbNewLine & "Are you sure you want undo any changes?", "Editing Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DialogResult = DialogResult.Yes Then
            btnEdit.Enabled = True
            btnSave.Enabled = False
            btnCancel.Enabled = False
            btnReturnToStaffManagement.Enabled = True
            EditButtonClicked = False
            btnSearch_Click(Nothing, Nothing)
            DoneEdit()
        End If
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

    Private Sub EditMode()
        btnSearch.Enabled = False
        btnClearSearch.Enabled = False
        If Profile_PicturePictureBox.Image Is Nothing Then
            btnClearProfilePicture.Enabled = False
        Else
            btnClearProfilePicture.Enabled = True
        End If
        btnUpdateProfilePicture.Enabled = True
        Staff_NameTextBox.ReadOnly = False
        Staff_ICMaskedTextBox.ReadOnly = False
        Staff_AddressTextBox.ReadOnly = False
        Staff_Phone_NumberMaskedTextBox.ReadOnly = False
        Staff_EmailTextBox.ReadOnly = False
        grpGender.Enabled = True
        If Employment_StatusTextBox.Text = "Unemployed" Then
            grpEmploymentStatus.Enabled = False
            Reason_Of_UnemploymentTextBox.ReadOnly = False
        Else
            grpEmploymentStatus.Enabled = True
            Date_Of_EmploymentDateTimePicker.Enabled = True
        End If
    End Sub

    Private Sub DoneEdit()
        Profile_PicturePictureBox.Enabled = False
        Staff_NameTextBox.ReadOnly = True
        Staff_ICMaskedTextBox.ReadOnly = True
        Staff_AddressTextBox.ReadOnly = True
        Staff_Phone_NumberMaskedTextBox.ReadOnly = True
        Staff_EmailTextBox.ReadOnly = True
        grpGender.Enabled = False
        grpEmploymentStatus.Enabled = False
        Date_Of_EmploymentDateTimePicker.Enabled = False
        Date_Of_UnemploymentDateTimePicker.Enabled = False
        Reason_Of_UnemploymentTextBox.ReadOnly = True
        btnUpdateProfilePicture.Enabled = False
        btnClearProfilePicture.Enabled = False
    End Sub

    Private Sub SetSearchStatus()
        If EditButtonClicked = False Then
            btnUpdateProfilePicture.Enabled = False
            btnClearProfilePicture.Enabled = False
            grpStaffInformation.Enabled = True
            btnSearch.Enabled = False
            btnClearSearch.Enabled = True
            txtSearch.Enabled = False
            cboSearchBy.Enabled = False
            btnSave.Enabled = False
            btnUpdateProfilePicture.Enabled = False
            btnClearProfilePicture.Enabled = False
        End If
    End Sub

    Private Sub Search_Staff_and_Update_Staff_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EditButtonClicked = True Then
            DialogResult = MessageBox.Show("Warning! You are currently in edit mode and data may be lost. Are you sure you want to close this windows?", "Editing Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If DialogResult = DialogResult.Yes Then
                Staff_Management.Show()
            Else
                e.Cancel = True
            End If
        Else
            Staff_Management.Show()
        End If
    End Sub

    Private Sub btnReturnToStaffManagement_Click(sender As Object, e As EventArgs) Handles btnReturnToStaffManagement.Click
        Staff_Management.Show()
        Me.Close()
    End Sub
End Class