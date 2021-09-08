Imports System.ComponentModel

Public Class ReportGeneration
    Private exitProgram As Boolean = False
    Private logout As Boolean = False
    Private Sub btnStaffLoginReport_Click(sender As Object, e As EventArgs) Handles btnStaffLoginReport.Click
        LoginReport.Show()
        Me.Hide()
    End Sub

    Private Sub btnStaffEmploymentReport_Click(sender As Object, e As EventArgs) Handles btnStaffEmploymentReport.Click
        Monthly_Report_of_Staff_Employment.Show()
        Me.Hide()
    End Sub

    Private Sub btnBooksReport_Click(sender As Object, e As EventArgs) Handles btnBooksReport.Click
        frmReportBooksAddedRemoved.Show()
        Me.Hide()
    End Sub

    Private Sub btnBackToMainMenu_Click(sender As Object, e As EventArgs) Handles btnBackToMainMenu.Click
        Me.Close()
    End Sub

    Private Sub ReportGeneration_FormClosing(sender As Object, e As CancelEventArgs) Handles Me.FormClosing
        If exitProgram Then
            DialogResult = MessageBox.Show("Are you sure you want to Exit?", "Closing Program", MessageBoxButtons.YesNo, MessageBoxIcon.None)
            If DialogResult = DialogResult.Yes Then
                LoginRecordTableAdapterReportGeneration.UpdateLogoutRecord(DateTime.Now(), MainMenu.myID, MainMenu.myLoginTime)
                Login.Close()
            Else
                exitProgram = False
                e.Cancel = True
            End If
        ElseIf logout Then
            DialogResult = MessageBox.Show("Are you sure you want to Log Out?", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.None)
            If DialogResult = DialogResult.Yes Then
                LoginRecordTableAdapterReportGeneration.UpdateLogoutRecord(DateTime.Now(), MainMenu.myID, MainMenu.myLoginTime)
                MainMenu.Close()
                Login.Show()
            Else
                logout = False
                e.Cancel = True
            End If
        Else
            MainMenu.Show()
        End If
    End Sub

    Private Sub ReportGeneration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = myBGColor
        picStaffEmploymentReport.Enabled = MainMenu.enableStaffManagement
        btnStaffEmploymentReport.Enabled = MainMenu.enableStaffManagement
        Me.CenterToScreen()
    End Sub

    Private Sub btnLoanReport_Click(sender As Object, e As EventArgs) Handles btnLoanReport.Click
        Circulation_Report.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        logout = True
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        exitProgram = True
        Me.Close()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        MainMenu.enableCurrentPW = True
        ChangePW.Show()
        Me.Hide()
    End Sub

    Private Sub DarkModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkModeToolStripMenuItem.Click
        myMenuStrip.darkmode()
        Me.BackColor = System.Drawing.Color.Gray
    End Sub

    Private Sub LightModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightModeToolStripMenuItem.Click
        myMenuStrip.lightmode()
        Me.BackColor = System.Drawing.Color.AntiqueWhite
    End Sub
End Class