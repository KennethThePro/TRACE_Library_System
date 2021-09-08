Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class frmReportBooksAddedRemoved
    Dim startRow As Integer = 0
    Dim newpage As Boolean = True

    Private Sub frmReportBooksAddedRemoved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        Label1.ForeColor = myTextColor

        'TODO: This line of code loads data into the 'TRACE_Library_SystemDataSet.Book' table. You can move, or remove it, as needed.
        'Me.BookTableAdapter.Fill(Me.TRACE_Library_SystemDataSet.Book)
        dtpMonthYear.MaxDate = DateTime.Today
        btnPrint.Enabled = False
        Me.CenterToScreen()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPrintPreview.Document = docReport
        dlgPrintPreview.ShowDialog(Me)

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim strMonth As String = dtpMonthYear.Value.Month.ToString()
        Dim strYear As String = dtpMonthYear.Value.Year.ToString()
        Dim Month As Integer = dtpMonthYear.Value.Month
        Dim Year As Integer = dtpMonthYear.Value.Year

        Try
            Me.BookTableAdapter.Fill(Me.TRACE_Library_SystemDataSet.Book)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        If OpenConnection() = True Then

            Dim query As String = "Select [ISBN], [Call Number], [Title], [Author], [Publisher], [Date Added], [Date Removed], [Reason Of Removal]" +
                "From Book Where Month([Date Added])='" + strMonth + "' And Year([Date Added])='" + strYear + "'" +
                "Or Month([Date Removed])='" + strMonth + "' And Year([Date Removed])='" + strYear + "'"
            Dim da As New SqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            da.Fill(ds, "Books Added Removed")
            CloseConnection()
            dgvBooksAddRemove.DataSource = ds
            dgvBooksAddRemove.DataMember = "Books Added Removed"
            If dgvBooksAddRemove.Rows.Count = 0 Then
                btnPrint.Enabled = False
                MessageBox.Show("No Records Found In This Month", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                btnPrint.Enabled = True
            End If

        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub FillByDateAddedRemovedToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByDateAddedRemovedToolStripButton.Click
        Try
            Me.BookTableAdapter.Fill(Me.TRACE_Library_SystemDataSet.Book)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub docReport_BeginPrint(sender As Object, ByVal e As Printing.PrintEventArgs) Handles docReport.BeginPrint
        'Reset If Print Button Is Clicked Again
        startRow = 0
        newpage = True
        dlgPrintPreview.PrintPreviewControl.StartPage = 0
        dlgPrintPreview.PrintPreviewControl.Zoom = 1.0
    End Sub

    Private Sub docReport_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docReport.PrintPage
        Dim Year As String = CType(dtpMonthYear.Value.Year, String)
        Dim longDate As String = dtpMonthYear.Value.ToLongDateString
        Dim monthString As String = longDate.Split(" "c)(1)

        '(1) Fonts
        Dim fontHeader As New Font("Calibri", 20, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Concolas", 10)

        'Prep header/sub-header
        Dim header As String = "Books added and removed in " + monthString + " " + Year
        Dim subHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by Marcus Kiong:", DateTime.Now)

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

        If newpage Then
            row = dgvBooksAddRemove.Rows(startRow)
            x = e.MarginBounds.Left - 50             ' LEFT MARGIN SIZE needs experimenting
            For Each cell As DataGridViewCell In row.Cells
                rc = New Rectangle(x, y, cell.Size.Width - 10, cell.Size.Height + 5)  'adjust based on data

                'Fill Up The Rectangle With Light Grey Background
                e.Graphics.FillRectangle(Brushes.LightGray, rc)
                'Draw The Rectangle Using Black Colour
                e.Graphics.DrawRectangle(Pens.Black, rc)

                'DefaultCellAslignment()

                With e.Graphics
                    .DrawString(dgvBooksAddRemove.Columns(cell.ColumnIndex).HeaderText,
                                            dgvBooksAddRemove.Font, Brushes.Black, rc, fmt)
                End With
                x += rc.Width
                'Height Is the Max Height Of Rectangle
                h = Math.Max(h, rc.Height)
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row

        Dim CurrentRowIndex As Int32
        'From startRow = 0 Declare Global Until Number Of Rows In DataGridView
        For CurrentRowIndex = startRow To dgvBooksAddRemove.RowCount - 1

            'row is the index of current row
            row = dgvBooksAddRemove.Rows(CurrentRowIndex)
            x = e.MarginBounds.Left - 50
            h = 0

            'Print the data from the StaffDataGridView
            x = e.MarginBounds.Left - 50

            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                rc = New Rectangle(x, y, cell.Size.Width - 10, cell.Size.Height + 5)  'size of cell containing data

                e.Graphics.DrawRectangle(Pens.Black, rc)
                e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      dgvBooksAddRemove.Font, Brushes.Black, rc, fmt)

                x += rc.Width
                h = Math.Max(h, rc.Height)

            Next
            y += h
            ' next row to print
            startRow = CurrentRowIndex + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                newpage = True
                Return
            End If
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dgvBooksAddRemove.DataSource = Nothing
        dtpMonthYear.Value = DateTime.Today
        btnPrint.Enabled = False
    End Sub


    Private Sub btnReturnToReportGeneration_Click(sender As Object, e As EventArgs) Handles btnReturnToReportGeneration.Click
        ReportGeneration.Show()
        Me.Close()
    End Sub

    Private Sub frmReportBooksAddedRemoved_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ReportGeneration.Show()
    End Sub

    Private Sub frmReportBooksAddedRemoved_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ReportGeneration.Show()
    End Sub

    Private Sub dtpMonthYear_ValueChanged(sender As Object, e As EventArgs) Handles dtpMonthYear.ValueChanged
        btnPrint.Enabled = False
        dgvBooksAddRemove.DataSource = Nothing
        dgvBooksAddRemove.Rows.Clear()
    End Sub
End Class