Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class LoginReport
    Dim startingRow As Integer = 0
    Dim newpage As Boolean = True

    Private Sub Monthly_Report_of_Staff_Employment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        btnPreviewReportandPrint.Enabled = False
        Me.CenterToScreen()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim Month As Integer = DateTimePicker.Value.Month
        Dim Year As Integer = DateTimePicker.Value.Year

        Dim myConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True"
        Dim myConnection As New SqlConnection(myConnectionString)
        Dim query As String = "SELECT [Staff ID], [Staff Name], [Log in Date and Time], [Log out Date and Time] FROM LoginRecord WHERE Month([Log in Date and Time])= '" & Month & "'"
        Dim dataadapter As New SqlDataAdapter(query, myConnection)
        Dim ds As New DataSet()
        myConnection.Open()
        dataadapter.Fill(ds, "LoginRecord")
        myConnection.Close()
        LoginDataGridView.DataSource = ds
        LoginDataGridView.DataMember = "LoginRecord"

        lblCount.Text = LoginDataGridView.Rows.Count.ToString() + " Logins Detected In " + DateTimePicker.Value.ToString("MMMM yyyy")

        If LoginDataGridView.Rows.Count = 0 Then
            btnPreviewReportandPrint.Enabled = False
            MessageBox.Show("No Records Found In This Month", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            btnPreviewReportandPrint.Enabled = True
        End If
    End Sub

    Private Sub btnPreviewReportandPrint_Click(sender As Object, e As EventArgs) Handles btnPreviewReportandPrint.Click
        dlgPreviewLoginReport.Document = docPrintLoginReport
        dlgPreviewLoginReport.ShowDialog(Me)
    End Sub

    Private Sub Monthly_Report_of_Staff_Employment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ReportGeneration.Show()
    End Sub

    Private Sub btnReturnToReportMenu_Click(sender As Object, e As EventArgs) Handles btnReturnToReportMenu.Click
        Me.Close()
    End Sub

    Private Sub docPrintReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docPrintLoginReport.PrintPage
        'Dim Year As String = CType(DateTimePicker.Value.Year, String)
        Dim monthAndYear As String = DateTimePicker.Value.ToString("MMMM yyyy")
        Dim header As String = "Staff Logged in during " + monthAndYear
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by Choy Mei Xin:", DateTime.Now)
        Dim fontHeader As New Font("Calibri", 20, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Cosolas", 10)
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)

        'Align Text To The Center Height Of Rectangle
        fmt.LineAlignment = StringAlignment.Center

        'Set the top and bottom margins to h inches.
        'y is the y axis
        'x is x axis
        'h is height
        Dim y As Int32 = e.MarginBounds.Top + 10
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        ' print the header text for a new page
        'Initially Is Known As A New Page, newpage = True as declared earlier in the global scope
        If newpage Then
            row = LoginDataGridView.Rows(startingRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                rc = New Rectangle(x, y, cell.Size.Width + 20, cell.Size.Height + 5)

                'Fill Up The Rectangle With Light Grey Background
                e.Graphics.FillRectangle(Brushes.LightGray, rc)
                'Draw The Rectangle Using Black Colour
                e.Graphics.DrawRectangle(Pens.Black, rc)

                With e.Graphics
                    .DrawImage(My.Resources.vb_logo, 25, 15, 110, 110)
                    .DrawString(header, fontHeader, Brushes.Purple, 150, 25)
                    .DrawString(subHeader, fontSubHeader, Brushes.Black, 150, 60)
                    .DrawString(LoginDataGridView.Columns(cell.ColumnIndex).HeaderText,
                                            LoginDataGridView.Font, Brushes.Black, rc, fmt)
                End With
                x += rc.Width
                'Height Is the Max Height Of Rectangle
                h = Math.Max(h, rc.Height)
            Next
            y += h

        End If
        newpage = False

        'This part will Print the data for each row
        'currentIndexOfRow is the index of the current row 
        Dim currentIndexOfRow As Int32
        'From startingRow = 0 Declare Global Until Number Of Rows In DataGridView
        For currentIndexOfRow = startingRow To LoginDataGridView.RowCount - 1

            'Row is the index of currentIndexOfRow
            row = LoginDataGridView.Rows(currentIndexOfRow)
            x = e.MarginBounds.Left
            h = 0

            ' reset the x coordinate to now print data in the rectangle
            x = e.MarginBounds.Left

            'Print the data from the StaffDataGridView
            For Each cell As DataGridViewCell In row.Cells
                rc = New Rectangle(x, y, cell.Size.Width + 20, cell.Size.Height + 5)

                e.Graphics.DrawRectangle(Pens.Black, rc)
                e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      LoginDataGridView.Font, Brushes.Black, rc, fmt)

                x += rc.Width
                h = Math.Max(h, rc.Height)

            Next
            y += h
            ' next row to print
            startingRow = currentIndexOfRow + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                newpage = True
                Return
            End If
        Next

    End Sub

    Private Sub docPrintLoginReport_BeginPrint(sender As Object, e As PrintEventArgs) Handles docPrintLoginReport.BeginPrint
        'Reset If Print Button Is Clicked Again
        startingRow = 0
        newpage = True
        dlgPreviewLoginReport.PrintPreviewControl.StartPage = 0
        dlgPreviewLoginReport.PrintPreviewControl.Zoom = 1.0
    End Sub

    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker.ValueChanged
        btnPreviewReportandPrint.Enabled = False
        LoginDataGridView.DataSource = Nothing
        LoginDataGridView.Rows.Clear()
        lblCount.Text = LoginDataGridView.Rows.Count.ToString() + " Logins Detected In " + DateTimePicker.Value.ToString("MMMM yyyy")
    End Sub

End Class
