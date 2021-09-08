Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class ReturnSummary
    Const CHARGE_PER_DAY As Double = 0.5

    Private Sub mskStudentID_Click(sender As Object, e As EventArgs) Handles mskStudentID.Click
        If mskStudentID.Text.Length = 0 Then
            mskStudentID.Select(0, 0)
        End If
    End Sub

    Friend Sub btnSearchStudentID_Click(sender As Object, e As EventArgs) Handles btnSearchStudentID.Click
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
                            mskStudentID.ReadOnly = True
                            btnSearchStudentID.Enabled = False
                            btnClear.Enabled = True
                            grpSelectedBox.Enabled = True
                            grpLoanDetails.Enabled = True
                        Else
                            MessageBox.Show("Student does not exist", "Student's ID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            mskStudentID.Text = ""
                        End If
                    End Using
                End Using
            End Using
            con.Close()
        End Using
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        mskStudentID.Text = ""
        lblStudentName.Text = ""
        lblISBN.Text = ""
        lblTitle.Text = ""
        lblOverdue.Text = ""
        lblPayment.Text = ""
        CirculationDataGridView.DataSource = Nothing
        CirculationDataGridView.Rows.Clear()
        grpLoanDetails.Enabled = False
        btnSearchStudentID.Enabled = True
        mskStudentID.ReadOnly = False
        mskStudentID.Focus()
        btnClear.Enabled = False
    End Sub

    Private Sub ReturnSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        For Each ctrl In grpLoanDetails.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        For Each ctrl In grpSelectedBox.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        grpSelectedBox.ForeColor = myTextColor
        grpLoanDetails.ForeColor = myTextColor
        'TODO: This line of code loads data into the 'TRACE_Library_SystemDataSet.Circulation' table. You can move, or remove it, as needed.
        'Me.CirculationTableAdapter.Fill(Me.TRACE_Library_SystemDataSet.Circulation)
        mskStudentID.Focus()
        Me.CenterToScreen()
    End Sub

    Private Sub CirculationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CirculationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CirculationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TRACE_Library_SystemDataSet)

    End Sub

    Private Sub mskStudentID_TextChanged(sender As Object, e As EventArgs)
        lblStudentName.Text = ""
        lblISBN.Text = ""
        lblTitle.Text = ""
        lblOverdue.Text = ""
        lblPayment.Text = ""
        CirculationDataGridView.DataSource = Nothing
        CirculationDataGridView.Rows.Clear()
    End Sub

    Private Sub CirculationDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CirculationDataGridView.CellMouseClick

        If (e.RowIndex >= 0) Then
            grpLoanDetails.Enabled = True
            Dim row As DataGridViewRow = CirculationDataGridView.Rows(e.RowIndex)
            lblISBN.Text = row.Cells(1).Value.ToString()
            lblTitle.Text = row.Cells(2).Value.ToString()
            Dim returnDate As DateTime = Convert.ToDateTime(CirculationDataGridView.CurrentRow.Cells(4).Value)
            Dim currentDate As DateTime = DateTime.Now()
            Dim overdue As Integer = (currentDate - returnDate).Days
            If overdue > 0 Then
                lblOverdue.Text = overdue.ToString()
                lblPayment.Text = (overdue * CHARGE_PER_DAY).ToString("0.00")
            Else
                lblOverdue.Text = "N/A"
                lblPayment.Text = "0.00"
            End If
            btnCheckout.Enabled = True
        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim available As String = "Available"
        Dim payment As Double = Double.Parse(lblPayment.Text)
        Dim current As DateTime = DateTime.Now()
        If payment = 0.00 Then
            Dim myConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True"
            Dim myConnection As New SqlConnection(myConnectionString)
            Dim rows As Integer
            Dim myCommand As SqlCommand = myConnection.CreateCommand()

            myConnection.Open()
            myCommand.CommandText = "Update Book Set [Status] = '" & available & "' WHERE [ISBN] = '" & lblISBN.Text & "'"
            rows = myCommand.ExecuteNonQuery()

            myCommand.CommandText = "Update Circulation Set [Actual Return Date] = '" + CType(current, String) + "' WHERE [ISBN] = '" & lblISBN.Text & "'"
            rows = myCommand.ExecuteNonQuery()

            myCommand.CommandText = "Update Circulation Set [Fined Amount] = '" & payment & "' WHERE [ISBN] = '" & lblISBN.Text & "'"
            rows = myCommand.ExecuteNonQuery()
            myConnection.Close()
            MessageBox.Show("Book has been returned.", "Book Successfully Returned", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSearchStudentID_Click(Nothing, Nothing)
            lblISBN.Text = ""
            lblTitle.Text = ""
            lblOverdue.Text = ""
            lblPayment.Text = ""
            grpLoanDetails.Enabled = False
        Else
            ReturnPayment.Show()
        End If
    End Sub

    Private Sub ReturnSummary_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub ReturnSummary_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Or e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

End Class