Public Class Staff_Management
    Friend Register_Button_Clicked As Boolean = False
    Private exitProgram As Boolean = False
    Private logout As Boolean = False

    Private Sub Staff_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnRegisterNewStaff_Click(sender As Object, e As EventArgs) Handles btnRegisterNewStaff.Click
        Register_Button_Clicked = True
        Me.Hide()
        Register_New_Staff.Show()
    End Sub

    Private Sub btnSearchStaff_Click(sender As Object, e As EventArgs) Handles btnSearchStaff.Click
        Me.Hide()
        Search_Staff_and_Update_Staff.Show()
    End Sub

    Private Sub Staff_Management_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If exitProgram Then
            DialogResult = MessageBox.Show("Are you sure you want to Exit?", "Closing Program", MessageBoxButtons.YesNo, MessageBoxIcon.None)
            If DialogResult = DialogResult.Yes Then
                LoginRecordTableAdapterStaffManagement.UpdateLogoutRecord(DateTime.Now(), MainMenu.myID, MainMenu.myLoginTime)
                Login.Close()
            Else
                exitProgram = False
                e.Cancel = True
            End If
        ElseIf logout Then
            DialogResult = MessageBox.Show("Are you sure you want to Log Out?", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.None)
            If DialogResult = DialogResult.Yes Then
                LoginRecordTableAdapterStaffManagement.UpdateLogoutRecord(DateTime.Now(), MainMenu.myID, MainMenu.myLoginTime)
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

    Private Sub btnReturnToMainMenu_Click(sender As Object, e As EventArgs) Handles btnReturnToMainMenu.Click
        Me.Close()
    End Sub

    Private Sub btnMonthlyReportStaffEmployment_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        Monthly_Report_of_Staff_Employment.Show()
    End Sub

    Private Sub Staff_Management_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Me.BackColor = myBGColor
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

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        logout = True
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        exitProgram = True
        Me.Close()
    End Sub
End Class