Imports System.ComponentModel
Imports System.Data.SqlClient


Public Class frmAddBook
    'Dim con As New SqlConnection
    Dim cmd As SqlCommand
    Dim validData As Boolean

    Private Sub BookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BookBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TRACE_Library_SystemDataSet)

    End Sub

    Private Sub frmAddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        'TODO: This line of code loads data into the 'TRACE_Library_SystemDataSet.Book' table. 
        'You can move, Or remove it, as needed.
        'Me.BookTableAdapter.Fill(Me.TRACE_Library_SystemDataSet.Book)

        Me.CenterToScreen()

        BookBindingSource.EndEdit()
        BookBindingSource.AddNew()
        dtpDateAdded.MaxDate = DateTime.Now()
        btnClear_Click(Nothing, Nothing)
        lblStatus.Text = "Available"
        mskISBN.Focus()

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

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        'Dim com As SqlCommand = Nothing

        validData = validBookData(txtTitle.Text, txtAuthor.Text, txtPages.Text,
                                                   cboCategory.Text, cboLanguage.Text, dtpDateAdded.Text)

        If validData = True Then

            If OpenConnection() = True Then
                BookBindingSource.EndEdit()
                BookTableAdapter.Update(TRACE_Library_SystemDataSet.Book)
                CloseConnection()
                MessageBox.Show("Book successfully added.", "Book Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnClear_Click(Nothing, Nothing)
            Else
                MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
            End If
        End If

    End Sub

    Private Sub dtpDateAdded_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateAdded.ValueChanged
        dtpDateAdded.Format = DateTimePickerFormat.Custom
        dtpDateAdded.CustomFormat = "dd/MMMM/yyyy"
        'dtpDateAdded.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        mskISBN.Clear()
        mskCallNum.Clear()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtPages.Clear()
        txtPublisher.Clear()
        cboCategory.SelectedIndex = -1
        cboLanguage.SelectedIndex = -1
        dtpDateAdded.Format = DateTimePickerFormat.Custom
        dtpDateAdded.CustomFormat = " "
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub frmAddBook_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        DialogResult = MessageBox.Show("Are you sure you want to close this window?" + vbCrLf +
                                       "Any changes made will be lost", "Confirm Form Closing",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DialogResult = DialogResult.Yes Then
            e.Cancel = False
            MainMenu.Show()
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub mskISBN_Validating(sender As Object, e As CancelEventArgs) Handles mskISBN.Validating
        Dim ISBN As String = If(mskISBN.MaskFull, mskISBN.Text, "")

        If ISBN = "" Then
            errISBN.SetError(mskISBN, "Please enter a 13 digit ISBN code")
            e.Cancel = True
            btnAddBook.Enabled = False
        ElseIf isDuplicateISBN(ISBN) <> 0 Then
            errISBN.SetError(mskISBN, "ISBN is duplicated")
            e.Cancel = True
            btnAddBook.Enabled = False
        Else
            errISBN.SetError(mskISBN, Nothing)
            btnAddBook.Enabled = True
        End If
    End Sub

    Private Sub txtPages_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPages.KeyPress
        NumberOnly(e)
    End Sub

    Private Sub mskCallNum_Validating(sender As Object, e As CancelEventArgs) Handles mskCallNum.Validating
        Dim CallNum As String = If(mskCallNum.MaskCompleted, mskCallNum.Text.Replace(" ", "0"), "")
        If CallNum = "" Then
            errCallNum.SetError(mskCallNum, "Please enter at least 3 digits followed by 3 letters" + vbCrLf + "eg. 111.000FOR")
            e.Cancel = True
            btnAddBook.Enabled = False
        Else
            errCallNum.SetError(mskCallNum, Nothing)
            btnAddBook.Enabled = True
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
End Class