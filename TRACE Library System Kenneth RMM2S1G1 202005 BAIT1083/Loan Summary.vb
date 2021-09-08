Imports System.Data.SqlClient
Public Class LoanSummary
    Dim countBooks As Integer

    Function IsDuplicatedISBN(ISBN As String) As Boolean
        For Each book In lstSelectedBooks.Items
            If CStr(book).StartsWith(ISBN) Then Return True
        Next
        Return False
    End Function

    Private Sub mskStudentID_Click(sender As Object, e As EventArgs) Handles mskStudentID.Click
        If mskStudentID.Text.Length = 0 Then
            mskStudentID.Select(0, 0)
        End If
    End Sub

    Private Sub mskISBN_Click(sender As Object, e As EventArgs) Handles mskISBN.Click
        If mskISBN.Text.Length = 0 Then
            mskISBN.Select(0, 0)
        End If
    End Sub

    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click
        Dim BookTitle As String = lblTitle.Text
        Dim isbn As String = mskISBN.Text.Trim()
        If IsDuplicatedISBN(isbn) Then
            MessageBox.Show("Book has been already added in the list", "Duplicate Book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf countBooks < 5 Then

            lstSelectedBooks.Items.Add(isbn + "                " + BookTitle)

            lblCallNumber.Text = ""
            lblTitle.Text = ""
            lblAuthor.Text = ""
            mskISBN.Text = ""
            mskISBN.Focus()
            countBooks = countBooks + 1
            btnLoan.Enabled = True
            btnAddToList.Enabled = False
        Else
            DialogResult = MessageBox.Show("You cannot borrow more than 5 books", "Reached Maximum Loan Capacity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If DialogResult = DialogResult.OK Then
                lblCallNumber.Text = ""
                lblTitle.Text = ""
                lblAuthor.Text = ""
                mskISBN.Text = ""
                mskISBN.Focus()
                btnAddToList.Enabled = False
            End If

        End If
        UpdateCount()
    End Sub


    Private Sub UpdateCount() Handles btnAddToList.Click, btnDelete.Click, btnSearchStudentID.Click
        lblCount.Text = lstSelectedBooks.Items.Count.ToString("0 books to borrow")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            lstSelectedBooks.Items.RemoveAt(lstSelectedBooks.SelectedIndex)
            If lstSelectedBooks.Items.Count = 0 Then
                btnLoan.Enabled = False
            Else
                btnLoan.Enabled = True
            End If
            countBooks = countBooks - 1
        Catch ex As Exception

        End Try
        UpdateCount()
        mskISBN.Focus()
    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click

        Dim rows As Integer
        Dim myCommand As SqlCommand
        Dim loan As String = "Loaned"
        For Each book As String In lstSelectedBooks.Items
            Using con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True")
                con.Open()
                Using com As New SqlCommand("INSERT INTO [Circulation] ([Student ID],[ISBN],[Title],[Loan Date],[Return Due Date]) VALUES (@StudentID, @ISBN, @Title, @LoanDate, @ReturnDueDate)", con)
                    com.Parameters.AddWithValue("@StudentID", mskStudentID.Text)
                    com.Parameters.AddWithValue("@ISBN", book.ToString.Substring(0, 13))
                    com.Parameters.AddWithValue("@Title", book.ToString.Substring(29, (book.ToString.Length() - 29)))
                    com.Parameters.AddWithValue("@LoanDate", LoanStartDate.Value)
                    com.Parameters.AddWithValue("@ReturnDueDate", ReturnDueDate.Value)
                    com.ExecuteNonQuery()
                    myCommand = con.CreateCommand()
                    myCommand.CommandText = "Update Book Set [Status] = '" & loan & "' WHERE [ISBN] = '" & book.ToString.Substring(0, 13) & "'"

                    rows = myCommand.ExecuteNonQuery()
                End Using
                con.Close()
            End Using
        Next

        MessageBox.Show("Book has been Loaned.", "Book Successfully Loaned.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lblCallNumber.Text = ""
        lblTitle.Text = ""
        lblAuthor.Text = ""
        mskISBN.Text = ""
        lstSelectedBooks.Items.Clear()
        mskStudentID.Text = ""
        lblStudentName.Text = ""
        CirculationDataGridView.DataSource = Nothing
        CirculationDataGridView.Rows.Clear()
        grpSelectedBooks.Enabled = False
        grpBookDetails.Enabled = False
        btnLoan.Enabled = False
        mskStudentID.ReadOnly = False
        btnSearchStudentID.Enabled = True
        btnClear.Enabled = False
        mskStudentID.Focus()
    End Sub

    Private Sub btnSearchISBN_Click(sender As Object, e As EventArgs) Handles btnSearchISBN.Click
        Dim Available As String = "Available"
        Dim SearchQuery As String
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True")
            SearchQuery = "Select * From Book Where ([ISBN] = '" & mskISBN.Text & "') AND ([Status] = '" & Available & "')"

            Using cmd As SqlCommand = New SqlCommand(SearchQuery, con)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            lblCallNumber.Text = dt.Rows(0)(1).ToString()
                            lblTitle.Text = dt.Rows(0)(2).ToString()
                            lblAuthor.Text = dt.Rows(0)(3).ToString()
                            btnAddToList.Enabled = True
                        Else
                            MessageBox.Show("Searched Book may be loaned, removed or not in library", "Book Not Available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            mskISBN.Text = ""
                            mskISBN.Focus()
                        End If
                    End Using
                End Using
            End Using
            con.Close()
        End Using
    End Sub

    Private Sub btnSearchStudentID_Click(sender As Object, e As EventArgs) Handles btnSearchStudentID.Click
        Dim SearchQuery As String
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True")

            SearchQuery = "SELECT * FROM Student where [Student ID] = '" & mskStudentID.Text & "'"

            Using cmd As SqlCommand = New SqlCommand(SearchQuery, con)
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            lblStudentName.Text = dt.Rows(0)(1).ToString()
                            'Dim myConnection As New SqlConnection(myConnectionString)
                            Dim query As String = "SELECT [Student ID],[ISBN],[Title],[Loan Date],[Return Due Date] FROM Circulation WHERE [Student ID] = '" & mskStudentID.Text & "' AND [Actual Return Date] IS NULL"
                            Dim dataadapter As New SqlDataAdapter(query, con)
                            Dim ds As New DataSet()
                            'con.Open()
                            dataadapter.Fill(ds, "Circulation")
                            'con.Close()
                            CirculationDataGridView.DataSource = ds
                            CirculationDataGridView.DataMember = "Circulation"
                            btnSearchStudentID.Enabled = False
                            btnClear.Enabled = True
                            grpSelectedBooks.Enabled = True
                            grpBookDetails.Enabled = True
                            mskStudentID.ReadOnly = True
                        Else
                            MessageBox.Show("Student does not exist", "Student's ID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            mskStudentID.Text = ""
                        End If
                    End Using
                End Using
            End Using
            con.Close()
        End Using


        countBooks = CirculationDataGridView.Rows.Count
        countBooks = countBooks + lstSelectedBooks.Items.Count
        mskISBN.Focus()
    End Sub

    Private Sub LoanStartDate_ValueChanged(sender As Object, e As EventArgs) Handles LoanStartDate.ValueChanged
        LoanStartDate.CustomFormat = "dd / MM / yyyy"
        ReturnDueDate.CustomFormat = "dd / MM / yyyy"
        ReturnDueDate.Value = LoanStartDate.Value.AddDays(Integer.Parse(lblDuration.Text))
    End Sub

    Private Sub LoanSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        grpBookDetails.ForeColor = myTextColor
        grpLoanHistory.ForeColor = myTextColor
        grpLoanSummary.ForeColor = myTextColor
        grpSelectedBooks.ForeColor = myTextColor
        For Each ctrl In Me.grpBookDetails.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        For Each ctrl In Me.grpLoanHistory.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        For Each ctrl In Me.grpLoanSummary.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        For Each ctrl In Me.grpSelectedBooks.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next

        'TODO: This line of code loads data into the 'TRACE_Library_SystemDataSet.Circulation' table. You can move, or remove it, as needed.
        'Me.CirculationTableAdapter.Fill(Me.TRACE_Library_SystemDataSet.Circulation)
        LoanStartDate.MinDate = DateTime.Now()
        LoanStartDate.MaxDate = DateTime.Now()
        mskStudentID.Focus()
        Me.CenterToScreen()

    End Sub

    Private Sub mskISBN_TextChanged(sender As Object, e As EventArgs) Handles mskISBN.TextChanged
        lblCallNumber.Text = ""
        lblTitle.Text = ""
        lblAuthor.Text = ""
    End Sub

    Private Sub CirculationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CirculationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CirculationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TRACE_Library_SystemDataSet)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DialogResult = MessageBox.Show("Are you sure you want to clear current Student's ID?" & vbNewLine & "All input data will be lost.", "Clearing Student's ID", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If DialogResult = DialogResult.Yes Then
            mskStudentID.Text = ""
            lblStudentName.Text = ""
            lstSelectedBooks.Items.Clear()
            CirculationDataGridView.DataSource = Nothing
            CirculationDataGridView.Rows.Clear()
            mskISBN.Text = ""
            lblCallNumber.Text = ""
            lblTitle.Text = ""
            lblAuthor.Text = ""
            mskStudentID.ReadOnly = False
            btnLoan.Enabled = False
            grpBookDetails.Enabled = False
            grpSelectedBooks.Enabled = False
            btnSearchStudentID.Enabled = True
            btnClear.Enabled = False
            mskStudentID.Focus()
        End If
    End Sub

    Private Sub LoanSummary_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mskStudentID.Text.Length <> 0 Then
            DialogResult = MessageBox.Show("Warning! You are about to close this window." & vbNewLine & " Any input data will not be saved" & vbNewLine & "Are you sure you want to close this window?", "Closing Window", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If DialogResult = DialogResult.Yes Then
                Staff_Management.Register_Button_Clicked = False
                MainMenu.Show()
            Else
                e.Cancel = True
            End If
        Else
            MainMenu.Show()
        End If
    End Sub

End Class