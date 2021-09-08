Imports System.ComponentModel

Public Class MainMenu
    Friend myID As String
    Friend myName As String
    Friend myType As String
    Friend myEmail As String
    Friend enableStaffManagement As Boolean
    Friend enableCurrentPW As Boolean
    Friend myLoginTime As DateTime
    Private exitProgram As Boolean = False
    Private logout As Boolean = False

    Private Sub btnStaffManagement_Click(sender As Object, e As EventArgs) Handles btnStaffManagement.Click
        Staff_Management.Show()
        Me.Hide()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ReportGeneration.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        frmBookMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        frmAddBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click, LogOutToolStripMenuItem.Click
        logout = True
        Me.Close()
    End Sub

    Private Sub MainMenu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        picStaffManagement.Visible = enableStaffManagement
        btnStaffManagement.Visible = enableStaffManagement
        StaffEmploymentReportToolStripMenuItem.Visible = enableStaffManagement
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        ReturnSummary.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoanBoook_Click(sender As Object, e As EventArgs) Handles btnLoanBook.Click
        LoanSummary.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        exitProgram = True
        Me.Close()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        enableCurrentPW = True
        ChangePW.Show()
        Me.Hide()
    End Sub

    Private Sub StaffLoginReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffLoginReportToolStripMenuItem.Click
        LoginReport.Show()
        Me.Hide()
    End Sub

    Private Sub CirculationReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CirculationReportToolStripMenuItem.Click
        Circulation_Report.Show()
        Me.Hide()
    End Sub

    Private Sub BooksReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BooksReportToolStripMenuItem.Click
        frmReportBooksAddedRemoved.Show()
        Me.Hide()
    End Sub

    Private Sub StaffEmploymentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffEmploymentReportToolStripMenuItem.Click
        Monthly_Report_of_Staff_Employment.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItemRegNewStaff_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemRegNewStaff.Click
        Staff_Management.Register_Button_Clicked = True
        Me.Hide()
        Register_New_Staff.Show()
    End Sub

    Private Sub ToolStripMenuItemSearchAndUpdateStaff_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSearchAndUpdateStaff.Click
        Me.Hide()
        Search_Staff_and_Update_Staff.Show()
    End Sub

    Private Sub MainMenu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.BackColor = myBGColor
    End Sub

    Private Sub DarkModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkModeToolStripMenuItem.Click
        myMenuStrip.darkmode()
        Me.BackColor = System.Drawing.Color.Gray
    End Sub

    Private Sub LightModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightModeToolStripMenuItem.Click
        myMenuStrip.lightmode()
        Me.BackColor = System.Drawing.Color.AntiqueWhite
    End Sub

    Private Sub MainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If exitProgram Then
            DialogResult = MessageBox.Show("Are you sure you want to Exit?", "Closing Program", MessageBoxButtons.YesNo, MessageBoxIcon.None)
            If DialogResult = DialogResult.Yes Then
                LoginRecordTableAdapterMainMenu.UpdateLogoutRecord(DateTime.Now(), myID, myLoginTime)
                Login.Close()
            Else
                exitProgram = False
                e.Cancel = True
            End If
        ElseIf logout Then
            DialogResult = MessageBox.Show("Are you sure you want to Log Out?", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.None)
            If DialogResult = DialogResult.Yes Then
                LoginRecordTableAdapterMainMenu.UpdateLogoutRecord(DateTime.Now(), myID, myLoginTime)
                Login.Show()
            Else
                logout = False
                e.Cancel = True
            End If
        End If
    End Sub
End Class