Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text

Public Class frmBookMenu
    Dim blnIsUpdating As Boolean = False
    Dim blnIsRemoving As Boolean = False
    Dim blnSelectingCategory As Boolean = False
    Dim blnSelectingLanguage As Boolean = False
    Dim blnBorrowing As Boolean = False



    Private Sub frmBookMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        For Each ctrl In GroupBox1.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        For Each ctrl In grpSearch.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        grpSearch.ForeColor = myTextColor
        GroupBox1.ForeColor = myTextColor
        'TODO: This line of code loads data into the 'TRACE_Library_SystemDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.TRACE_Library_SystemDataSet.Book)
        Me.CenterToScreen()
        cboSearchFilter.SelectedIndex = 0   'set default selected index
        dgvBooks_SelectionChanged(Nothing, Nothing)

        'set limits for the date 
        dtpDateAdded.MaxDate = DateTime.Now()
        dtpDateRemoved.MinDate = DateTime.Now()
        dtpDateRemoved.Format = DateTimePickerFormat.Custom
        If lblStatus.Text <> "Removed" Then
            dtpDateRemoved.CustomFormat = "  "
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        chklstCategory.Visible = False
        chklstLanguage.Visible = False
        If OpenConnection() = True Then

            BookBindingSource.Filter = GetFilter()
            If BookBindingSource.Count <> 0 Then
                With dgvBooks
                    .DataSource = BookBindingSource
                End With

            Else
                MessageBox.Show("The search item  was not found.", "No result",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                BookBindingSource.Filter = Nothing 'reset filter
                btnClear_Click(Nothing, Nothing)
            End If
            CloseConnection()

        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub txtSearchBar_Click(sender As Object, e As EventArgs) Handles txtSearchBar.Click
        txtSearchBar.SelectAll()
    End Sub

    Private Function GetFilter() As String

        Dim searchBy As Integer = cboSearchFilter.SelectedIndex
        Dim keyword As String = txtSearchBar.Text
        Dim strFilter As String = ""

        If cboStatus.SelectedIndex <> -1 Then
            strFilter = "[Status] = '" & cboStatus.Text & "'"
        End If

        If chklstCategory.CheckedItems.Count <> 0 Then
            If strFilter.Length <> 0 Then
                strFilter += " And "
            End If
            strFilter += "[Category] In ("
            For Each item As String In chklstCategory.CheckedItems
                strFilter += "'" + item + "', "
            Next
            strFilter = strFilter.Substring(0, strFilter.Length - 2) + ")" 'get rid of last comma
        End If

        If chklstLanguage.CheckedItems.Count <> 0 Then
            If strFilter.Length <> 0 Then
                strFilter += " And "
            End If
            strFilter += "[Language] In ("
            For Each item As String In chklstLanguage.CheckedItems
                strFilter += "'" + item + "', "
            Next
            strFilter = strFilter.Substring(0, strFilter.Length - 2) + ")" 'get rid of last comma
        End If

        'No search keyword
        If keyword.Length = 0 Then
            Return strFilter
        End If

        If strFilter.Length <> 0 Then
            strFilter += " And "
        End If

        Select Case searchBy
            Case 0
                strFilter += "([Title] Like '%" + keyword + "%' Or [Author] Like '%" + keyword +
                   "%' Or [Publisher] Like '%" + keyword + "%')"
            Case 1
                strFilter += "[Title] Like '%" + keyword + "%'"
            Case 2
                strFilter += "[Author] Like '%" + keyword + "%'"
            Case 3
                strFilter += "[Publisher] Like '%" + keyword + "%'"
            Case Else
                strFilter += Nothing
        End Select


        Return strFilter
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        chklstCategory.Visible = False
        chklstLanguage.Visible = False

        cboSearchFilter.SelectedIndex = 0
        txtSearchBar.Clear()
        blnSelectingCategory = False
        blnSelectingLanguage = False

        For i = 0 To chklstCategory.Items.Count - 1
            chklstCategory.SetItemChecked(i, False)
        Next

        For i = 0 To chklstLanguage.Items.Count - 1
            chklstLanguage.SetItemChecked(i, False)
        Next
        cboStatus.SelectedIndex = -1
        'err.Clear()??
        Try
            OpenConnection()
            BookBindingSource.Filter = Nothing
            With dgvBooks
                .DataSource = BookBindingSource
            End With
            CloseConnection()
        Catch ex As Exception

        End Try
        frmBookMenu_Load(Nothing, Nothing)
    End Sub

    Private Sub dgvBooks_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBooks.SelectionChanged
        'String.IsNullOrEmpty(dgvBooks.CurrentRow.Cells(11).Value.ToString())
        dtpDateRemoved.MinDate = dtpDateAdded.Value
        Try
            If lblStatus.Text <> "Removed" Then
                dtpDateRemoved.Format = DateTimePickerFormat.Custom
                dtpDateRemoved.CustomFormat = "  "

            Else
                dtpDateRemoved.Format = DateTimePickerFormat.Short

            End If

            If lblStatus.Text = "Available" Then
                btnRemove.Enabled = True
                btnUpdate.Enabled = True
                btnLoan.Enabled = True
            Else
                btnRemove.Enabled = False
                btnUpdate.Enabled = False
                btnLoan.Enabled = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    'Code below referred from Chapter 9B Demo codes
    '---------------------------------------------------------------------------------------------
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim dlgResult As DialogResult
        dgvBooks.Enabled = False
        grpSearch.Enabled = False
        btnLoan.Enabled = False
        'NOTE:btnUpdate share "Update", "Save", and "Remove" operations in one button
        If btnUpdate.Text = "&Update" Then
            'For updating method
            blnIsUpdating = True
            SetButtonForUpdate()
        ElseIf btnUpdate.Text = "&Save" Then
            'For Save method
            Dim validData As Boolean = validBookData(txtTitle.Text, txtAuthor.Text, txtPages.Text,
                                                   cboCategory.Text, cboLanguage.Text, dtpDateAdded.Text)
            If validData = True Then

                If OpenConnection() = True Then
                    Try

                        BookBindingSource.EndEdit() 'Updates newly changed data fields to the Book table
                        BookTableAdapter.Update(TRACE_Library_SystemDataSet.Book)
                        CloseConnection()
                        MessageBox.Show("Book successfully updated.", "Book updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        dgvBooks.Enabled = True
                        grpSearch.Enabled = True
                        btnLoan.Enabled = True
                    Catch ex As Exception
                        MessageBox.Show("Update failed", "Update Error", MessageBoxButtons.OK)
                    End Try

                Else
                    MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
                End If
            End If

            blnIsUpdating = False
            SetButtonAfterEdit() 'reset controls to default
        Else
            'For Remove method
            Dim validationString As String = ""
            dlgResult = MessageBox.Show("Are you sure you want to remove this book?", "Remove Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlgResult = DialogResult.Yes Then
                If dtpDateRemoved.Text = " " Then
                    validationString = "- Date Of Removal Is Empty"
                End If

                If txtRemovalReason.Text = "" Then
                    validationString = validationString + vbNewLine + "- Reason Of Removal Is Empty"
                End If

                If validationString.Length > 0 Then
                    MessageBox.Show(validationString, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf validationString.Length = 0 Then
                    lblStatus.Text = "Removed"
                    If OpenConnection() = True Then
                        Try
                            BookBindingSource.EndEdit()
                            BookTableAdapter.Update(TRACE_Library_SystemDataSet.Book)
                            CloseConnection()
                            MessageBox.Show("Book has been removed.", "Book Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            dgvBooks.Enabled = True
                            grpSearch.Enabled = True
                            dtpDateRemoved.Enabled = False
                            txtRemovalReason.Enabled = False
                            btnRemove.Enabled = False
                            btnUpdate.Enabled = False
                            SetButtonAfterEdit()
                        Catch ex As Exception
                            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
                        End Try
                    End If
                Else
                    'btnRemove_Click(Nothing, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        dgvBooks.Enabled = False
        grpSearch.Enabled = False
        btnLoan.Enabled = False
        If btnRemove.Text = "&Remove" Then
            'For removing
            btnUpdate.Text = "&Remove"
            btnRemove.Text = "&Cancel"

            'Enable removal and Reason
            dtpDateRemoved.Enabled = True
            dtpDateRemoved.Format = DateTimePickerFormat.Custom
            dtpDateRemoved.CustomFormat = " "
            'dtpDateRemoved.Format = DateTimePickerFormat.Short
            txtRemovalReason.ReadOnly = False

        Else
            'For cancelling update
            BookBindingSource.CancelEdit()
            blnIsUpdating = False
            'blnIsRemoving = False
            dtpDateRemoved.Enabled = False
            dgvBooks.Enabled = True
            grpSearch.Enabled = True
            btnLoan.Enabled = True
            SetButtonAfterEdit() 'reset controls to default
        End If
    End Sub

    Private Sub SetButtonForUpdate()
        SetTextboxReadOnly(False)
        mskISBN.ReadOnly = True
        txtTitle.ReadOnly = True
        txtRemovalReason.ReadOnly = True
        SetCBOEnabled(True)
        btnUpdate.Text = "&Save"
        btnRemove.Text = "&Cancel"
    End Sub

    Private Sub SetButtonAfterEdit()
        SetTextboxReadOnly(True)
        SetCBOEnabled(False)
        btnUpdate.Text = "&Update"
        btnRemove.Text = "&Remove"
        If lblStatus.Text = "Available" Then
            dtpDateRemoved.Format = DateTimePickerFormat.Custom
            dtpDateRemoved.CustomFormat = " "
        End If
    End Sub

    Private Sub SetTextboxReadOnly(ByVal blnRead As Boolean)
        For Each textbox As TextBox In GroupBox1.Controls.OfType(Of TextBox)
            textbox.ReadOnly = blnRead
        Next

        For Each masked As MaskedTextBox In GroupBox1.Controls.OfType(Of MaskedTextBox)
            masked.ReadOnly = blnRead
        Next
    End Sub

    Private Sub SetCBOEnabled(ByVal blnEnable As Boolean)
        For Each combo As ComboBox In GroupBox1.Controls.OfType(Of ComboBox)
            combo.Enabled = blnEnable
        Next
        dtpDateAdded.Enabled = blnEnable
    End Sub

    Private Sub txtPages_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPages.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub mskCallNum_Validating(sender As Object, e As CancelEventArgs) Handles mskCallNum.Validating
        Dim CallNum As String = If(mskCallNum.MaskCompleted, mskCallNum.Text.Replace(" ", "0"), "")
        If CallNum = "" Then
            errCallNum.SetError(mskCallNum, "Please enter at least 3 digits followed by 3 letters" + vbCrLf + "eg. 111.000FOR")
            e.Cancel = True
            btnUpdate.Enabled = False
        Else
            errCallNum.SetError(mskCallNum, Nothing)
            btnUpdate.Enabled = True
        End If

    End Sub

    Private Sub frmBookMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If btnRemove.Text = "&Cancel" Then
            DialogResult = MessageBox.Show("Warning! You are currently in edit mode and data may be lost. " +
                "Are you sure you want to exit this window?", "Editing Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If DialogResult = DialogResult.Yes Then
                e.Cancel = False
                If blnBorrowing Then
                    LoanSummary.Show()
                Else
                    MainMenu.Show()
                End If
            Else
                e.Cancel = True
            End If
        Else
            If blnBorrowing Then
                LoanSummary.Show()
            Else
                MainMenu.Show()
            End If
        End If
    End Sub

    Private Sub mskISBN_Click(sender As Object, e As EventArgs) Handles mskISBN.Click
        If mskISBN.Text.Length = 0 Then
            mskISBN.Select(0, 0)
        End If
    End Sub

    Private Sub mskCallNum_Click(sender As Object, e As EventArgs) Handles mskCallNum.Click
        If mskCallNum.Text.Length = 0 Then
            mskCallNum.Select(0, 0)
        End If
    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        LoanSummary.mskISBN.Text = mskISBN.Text.Trim()
        LoanSummary.lblCallNumber.Text = mskCallNum.Text.Trim()
        LoanSummary.lblTitle.Text = txtTitle.Text.Trim()
        LoanSummary.lblAuthor.Text = txtAuthor.Text.Trim()
        blnBorrowing = True
        LoanSummary.Show()
        Me.Close()
    End Sub

    Private Sub btnLanguage_Click(sender As Object, e As EventArgs) Handles btnLanguage.Click
        chklstLanguage.Visible = Not blnSelectingLanguage
        blnSelectingLanguage = chklstLanguage.Visible
    End Sub


    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        chklstCategory.Visible = Not blnSelectingCategory
        blnSelectingCategory = chklstCategory.Visible
    End Sub

    Private Sub txtAuthor_LostFocus(sender As Object, e As EventArgs) Handles txtAuthor.LostFocus
        txtAuthor.Text = StrConv(txtAuthor.Text, VbStrConv.ProperCase) 'makes capitalisation proper
    End Sub

    Private Sub txtTitle_LostFocus(sender As Object, e As EventArgs) Handles txtTitle.LostFocus
        txtTitle.Text = StrConv(txtTitle.Text, VbStrConv.ProperCase) 'makes capitalisation proper
    End Sub

    Private Sub txtPublisher_LostFocus(sender As Object, e As EventArgs) Handles txtPublisher.LostFocus
        txtPublisher.Text = StrConv(txtPublisher.Text, VbStrConv.ProperCase) 'makes capitalisation proper
    End Sub

    Private Sub dtpDateRemoved_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateRemoved.ValueChanged
        dtpDateRemoved.Format = DateTimePickerFormat.Custom
        dtpDateRemoved.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dgvBooks_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvBooks.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub
End Class
