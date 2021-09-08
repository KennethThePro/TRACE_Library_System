Imports System.Data.SqlClient

Public Class Monthly_Report_of_Staff_Employment
    'For Each New Page
    Dim StartingRow As Integer = 0
    Dim newpage As Boolean = True


    Private Sub Monthly_Report_of_Staff_Employment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl = DirectCast(ctrl, Label)
                lbl.ForeColor = myTextColor
            End If
        Next
        'TODO: This line of code loads data into the 'TRACE_Library_SystemDataSet.Staff' table. You can move, or remove it, as needed.
        'Me.StaffTableAdapter.Fill(Me.TRACE_Library_SystemDataSet.Staff)
        btnPreviewReportandPrint.Enabled = False
        Me.CenterToScreen()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim Month As Integer = DateTimePickerForEmployed.Value.Month
        Dim Year As Integer = DateTimePickerForEmployed.Value.Year

        Dim myConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True"
        Dim myConnection As New SqlConnection(myConnectionString)
        Dim query As String = "SELECT [Staff ID],[Staff Name],[Staff Phone Number], [Staff Email], [User Type], [Date Of Employment] FROM Staff WHERE MONTH([Date Of Employment])='" & Month & "' AND YEAR([Date Of Employment]) = '" & Year & "'"
        Dim dataadapter As New SqlDataAdapter(query, myConnection)
        Dim ds As New DataSet()
        myConnection.Open()
        dataadapter.Fill(ds, "Staff")
        myConnection.Close()
        StaffDataGridView.DataSource = ds
        StaffDataGridView.DataMember = "Staff"

        If StaffDataGridView.Rows.Count = 0 Then
            btnPreviewReportandPrint.Enabled = False
            MessageBox.Show("No Records Found In This Month", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            btnPreviewReportandPrint.Enabled = True
        End If
        lblCount.Text = StaffDataGridView.Rows.Count.ToString() + " Employed Staff Members In Selected Month and Year"
    End Sub

    Private Sub DateTimePickerForEmployed_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerForEmployed.ValueChanged
        btnPreviewReportandPrint.Enabled = False
        StaffDataGridView.DataSource = Nothing
        StaffDataGridView.Rows.Clear()
        lblCount.Text = StaffDataGridView.Rows.Count.ToString() + " Employed Staff Members In Selected Month and Year"
    End Sub

    Private Sub btnPreviewReportandPrint_Click(sender As Object, e As EventArgs) Handles btnPreviewReportandPrint.Click
        dlgPreviewReport.Document = docPrintReport
        dlgPreviewReport.ShowDialog(Me)
    End Sub

    Private Sub Monthly_Report_of_Staff_Employment_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ReportGeneration.Show()
    End Sub

    Private Sub btnReturnToReportGeneration_Click(sender As Object, e As EventArgs) Handles btnReturnToReportGeneration.Click
        ReportGeneration.Show()
        Me.Close()
    End Sub

    Private Sub docPrintReport_BeginPrint(sender As Object, ByVal e As Printing.PrintEventArgs) Handles docPrintReport.BeginPrint
        'Reset If Print Button Is Clicked Again
        StartingRow = 0
        newpage = True
        dlgPreviewReport.PrintPreviewControl.StartPage = 0
        dlgPreviewReport.PrintPreviewControl.Zoom = 1.0
    End Sub

    Private Sub docPrintReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docPrintReport.PrintPage
        Dim Year As String = CType(DateTimePickerForEmployed.Value.Year, String)
        Dim longDate As String = DateTimePickerForEmployed.Value.ToLongDateString
        Dim monthString As String = longDate.Split(" "c)(1)

        Dim fontHeader As New Font("Calibri", 20, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Cosolas", 10)

        Dim header As String = "Staff Employed In " + monthString + " " + Year
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by Kenneth Koay:", DateTime.Now)
        With e.Graphics
            .DrawImage(My.Resources.vb_logo, 25, 15, 110, 110)
            .DrawString(header, fontHeader, Brushes.Purple, 150, 25)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 150, 60)
        End With

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
        'Initially Is Known As A New Page, newpage = True as declared earlier in the global scope, every new page will run this code
        If newpage Then
            row = StaffDataGridView.Rows(StartingRow)
            x = (e.MarginBounds.Left - 50)
            For Each cell As DataGridViewCell In row.Cells
                rc = New Rectangle(x, y, cell.Size.Width + 25, cell.Size.Height + 40)

                'Fill Up The First Header Row Rectangle With Light Grey Background
                e.Graphics.FillRectangle(Brushes.LightGray, rc)
                'Draw The Rectangle Using Black Colour
                e.Graphics.DrawRectangle(Pens.Black, rc)

                With e.Graphics
                    .DrawString(StaffDataGridView.Columns(cell.ColumnIndex).HeaderText,
                                            StaffDataGridView.Font, Brushes.Black, rc, fmt)
                End With
                x += rc.Width
                'Height Is the Max Height Of Rectangle
                h = Math.Max(h, rc.Height)
                'End If
            Next
            y += h

        End If
        newpage = False

        'This part will Print the data for each row
        'currentIndexOfRow is the index of the current row 
        Dim currentIndexOfRow As Int32
        'From startingRow = 0 Declare Global Until Number Of Rows In DataGridView
        For currentIndexOfRow = StartingRow To StaffDataGridView.RowCount - 1

            'Row is the index of currentIndexOfRow
            row = StaffDataGridView.Rows(currentIndexOfRow)
            x = (e.MarginBounds.Left - 50)
            h = 0

            ' reset the x coordinate to now print data in the rectangle
            x = (e.MarginBounds.Left - 50)

            'Print the data from the StaffDataGridView
            For Each cell As DataGridViewCell In row.Cells
                rc = New Rectangle(x, y, cell.Size.Width + 25, cell.Size.Height + 40)

                e.Graphics.DrawRectangle(Pens.Black, rc)
                e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      StaffDataGridView.Font, Brushes.Black, rc, fmt)

                x += rc.Width
                h = Math.Max(h, rc.Height)

            Next
            y += h
            ' next row to print
            StartingRow = currentIndexOfRow + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                newpage = True
                Return
            End If
        Next

    End Sub
End Class
