Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class Circulation_Report
    Dim startingRow As Integer = 0
    Dim newpage As Boolean = True


    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim Month As Integer = DateTimePickerCirculation.Value.Month
        Dim Year As Integer = DateTimePickerCirculation.Value.Year

        Dim myConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System Kenneth RMM2S1G1 202005 BAIT1083\TRACE Library System.mdf;Integrated Security=True"
        Dim myConnection As New SqlConnection(myConnectionString)
        Dim query As String = "SELECT [Student ID], [ISBN], [Title], [Loan Date], [Return Due Date] FROM Circulation WHERE Month([Return Due Date])= '" & Month & "' AND [Actual Return Date] IS NULL"
        Dim dataadapter As New SqlDataAdapter(query, myConnection)
        Dim ds As New DataSet()
        myConnection.Open()
        dataadapter.Fill(ds, "Circulation")
        myConnection.Close()
        CirculationDataGridView.DataSource = ds
        CirculationDataGridView.DataMember = "Circulation"

        If CirculationDataGridView.Rows.Count = 0 Then
            btnPreviewReportandPrint.Enabled = False
            MessageBox.Show("No Records Found In This Month", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            btnPreviewReportandPrint.Enabled = True
        End If
        lblCount.Text = CirculationDataGridView.Rows.Count.ToString() + " Number of Books Unreturned"
    End Sub

    Private Sub btnPreviewReportandPrint_Click(sender As Object, e As EventArgs) Handles btnPreviewReportandPrint.Click
        dlgPreviewCirculation.Document = docPrintCirculation
        dlgPreviewCirculation.ShowDialog(Me)
    End Sub

    Private Sub Loan_Return_Report_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ReportGeneration.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ReportGeneration.Show()
        Me.Close()
    End Sub

    Private Sub docPrintReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docPrintCirculation.PrintPage
        'Dim Year As String = CType(DateTimePicker.Value.Year, String)
        Dim monthAndYear As String = DateTimePickerCirculation.Value.ToString("MMMM yyyy")
        Dim header As String = "Books Not Return in " + monthAndYear
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by Tan Yin Yuen:", DateTime.Now)
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
            row = CirculationDataGridView.Rows(startingRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invisible columns
                'If cell.Visible Then
                rc = New Rectangle(x, y, cell.Size.Width + 20, cell.Size.Height + 5)

                'Fill Up The Rectangle With Light Grey Background
                e.Graphics.FillRectangle(Brushes.LightGray, rc)
                'Draw The Rectangle Using Black Colour
                e.Graphics.DrawRectangle(Pens.Black, rc)

                'DefaultCellAslignment()

                With e.Graphics
                    .DrawImage(My.Resources.vb_logo, 25, 15, 110, 110)
                    .DrawString(header, fontHeader, Brushes.Purple, 150, 25)
                    .DrawString(subHeader, fontSubHeader, Brushes.Black, 150, 60)
                    .DrawString(CirculationDataGridView.Columns(cell.ColumnIndex).HeaderText,
                                            CirculationDataGridView.Font, Brushes.Black, rc, fmt)
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
        'FRom startingRow = 0 Declare Global Until Number Of Rows In DataGridView
        For currentIndexOfRow = startingRow To CirculationDataGridView.RowCount - 1

            'row is the index of currentIndexofRow
            row = CirculationDataGridView.Rows(currentIndexOfRow)
            row = CirculationDataGridView.Rows(currentIndexOfRow)
            x = e.MarginBounds.Left
            h = 0

            ' reset the x coordinate to now print data in the rectangle
            x = e.MarginBounds.Left

            'Print the data from the StaffDataGridView
            For Each cell As DataGridViewCell In row.Cells
                rc = New Rectangle(x, y, cell.Size.Width + 20, cell.Size.Height + 5)

                e.Graphics.DrawRectangle(Pens.Black, rc)
                e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      CirculationDataGridView.Font, Brushes.Black, rc, fmt)

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

    Private Sub docPrintLoginReport_BeginPrint(sender As Object, ByVal e As Printing.PrintEventArgs) Handles docPrintCirculation.BeginPrint
        'Reset If Print Button Is Clicked Again
        startingRow = 0
        newpage = True
        dlgPreviewCirculation.PrintPreviewControl.StartPage = 0
        dlgPreviewCirculation.PrintPreviewControl.Zoom = 1.0
    End Sub

    Private Sub Loan_Return_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.ForeColor = myTextColor
        Me.lblCount.ForeColor = myTextColor
        Me.BackColor = myBGColor
        btnPreviewReportandPrint.Enabled = False
        Me.CenterToScreen()
    End Sub

    Private Sub DateTimePickerCirculation_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerCirculation.ValueChanged
        btnPreviewReportandPrint.Enabled = False
        CirculationDataGridView.DataSource = Nothing
        CirculationDataGridView.Rows.Clear()
        lblCount.Text = CirculationDataGridView.Rows.Count.ToString() + " Number of Books Unreturned"
    End Sub

End Class