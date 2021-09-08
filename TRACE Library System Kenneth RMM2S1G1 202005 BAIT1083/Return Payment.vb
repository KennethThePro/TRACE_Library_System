Imports System.Data.SqlClient

Public Class ReturnPayment
    Private Sub ReturnPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        lblISBN.Text = ReturnSummary.lblISBN.Text
        lblOverdue.Text = ReturnSummary.lblOverdue.Text
        lblTotal.Text = (Integer.Parse(lblOverdue.Text) * 0.5).ToString("0.00")
        Me.CenterToScreen()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim available As String = "Available"
        Dim payment As Double = Double.Parse(lblTotal.Text)
        Dim current As DateTime = DateTime.Now()

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
        DialogResult = MessageBox.Show("Fined has been Paid." & vbNewLine & "Book has been returned.", "Book Successfully Returned", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If DialogResult = DialogResult.OK Then
            Me.Close()
            ReturnSummary.lblISBN.Text = ""
            ReturnSummary.lblOverdue.Text = ""
            ReturnSummary.lblPayment.Text = ""
            ReturnSummary.lblTitle.Text = ""
            ReturnSummary.btnCheckout.Enabled = False
            ReturnSummary.grpLoanDetails.Enabled = False
            ReturnSummary.btnSearchStudentID_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class