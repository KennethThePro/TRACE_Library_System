<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStripMainMenuGenerateReport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StaffLoginReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CirculationReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffEmploymentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.btnLoanBook = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.picStaffManagement = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStripMainMenuStaffManagement = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemRegNewStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemSearchAndUpdateStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStaffManagement = New System.Windows.Forms.Button()
        Me.btnSearchBook = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.LoginRecordTableAdapterMainMenu = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.MenuStripMainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripMainMenuGenerateReport.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStaffManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripMainMenuStaffManagement.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.return_icon
        Me.PictureBox2.Location = New System.Drawing.Point(283, 42)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.ContextMenuStrip = Me.ContextMenuStripMainMenuGenerateReport
        Me.PictureBox4.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.Report_Icon
        Me.PictureBox4.Location = New System.Drawing.Point(283, 182)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'ContextMenuStripMainMenuGenerateReport
        '
        Me.ContextMenuStripMainMenuGenerateReport.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.ContextMenuStripMainMenuGenerateReport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffLoginReportToolStripMenuItem, Me.CirculationReportToolStripMenuItem, Me.BooksReportToolStripMenuItem, Me.StaffEmploymentReportToolStripMenuItem})
        Me.ContextMenuStripMainMenuGenerateReport.Name = "ContextMenuStripMainMenu"
        Me.ContextMenuStripMainMenuGenerateReport.Size = New System.Drawing.Size(208, 92)
        '
        'StaffLoginReportToolStripMenuItem
        '
        Me.StaffLoginReportToolStripMenuItem.Name = "StaffLoginReportToolStripMenuItem"
        Me.StaffLoginReportToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.StaffLoginReportToolStripMenuItem.Text = "Staff Login Report"
        '
        'CirculationReportToolStripMenuItem
        '
        Me.CirculationReportToolStripMenuItem.Name = "CirculationReportToolStripMenuItem"
        Me.CirculationReportToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CirculationReportToolStripMenuItem.Text = "Circulation Report"
        '
        'BooksReportToolStripMenuItem
        '
        Me.BooksReportToolStripMenuItem.Name = "BooksReportToolStripMenuItem"
        Me.BooksReportToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.BooksReportToolStripMenuItem.Text = "Books Report"
        '
        'StaffEmploymentReportToolStripMenuItem
        '
        Me.StaffEmploymentReportToolStripMenuItem.Name = "StaffEmploymentReportToolStripMenuItem"
        Me.StaffEmploymentReportToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.StaffEmploymentReportToolStripMenuItem.Text = "Staff Employment Report"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.loan_icon
        Me.PictureBox1.Location = New System.Drawing.Point(99, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReport.ContextMenuStrip = Me.ContextMenuStripMainMenuGenerateReport
        Me.btnReport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReport.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(262, 254)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(112, 42)
        Me.btnReport.TabIndex = 4
        Me.btnReport.Text = "&Generate Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnReturnBook
        '
        Me.btnReturnBook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturnBook.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.Location = New System.Drawing.Point(262, 114)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(112, 38)
        Me.btnReturnBook.TabIndex = 1
        Me.btnReturnBook.Text = "&Return Book"
        Me.btnReturnBook.UseVisualStyleBackColor = False
        '
        'btnLoanBook
        '
        Me.btnLoanBook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLoanBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoanBook.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanBook.Location = New System.Drawing.Point(74, 114)
        Me.btnLoanBook.Name = "btnLoanBook"
        Me.btnLoanBook.Size = New System.Drawing.Size(112, 40)
        Me.btnLoanBook.TabIndex = 0
        Me.btnLoanBook.Text = "&Loan Book"
        Me.btnLoanBook.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.search_icon
        Me.PictureBox5.Location = New System.Drawing.Point(465, 44)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 27
        Me.PictureBox5.TabStop = False
        '
        'picStaffManagement
        '
        Me.picStaffManagement.ContextMenuStrip = Me.ContextMenuStripMainMenuStaffManagement
        Me.picStaffManagement.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.staff_icon
        Me.picStaffManagement.Location = New System.Drawing.Point(465, 184)
        Me.picStaffManagement.Name = "picStaffManagement"
        Me.picStaffManagement.Size = New System.Drawing.Size(70, 66)
        Me.picStaffManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaffManagement.TabIndex = 26
        Me.picStaffManagement.TabStop = False
        '
        'ContextMenuStripMainMenuStaffManagement
        '
        Me.ContextMenuStripMainMenuStaffManagement.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.ContextMenuStripMainMenuStaffManagement.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemRegNewStaff, Me.ToolStripMenuItemSearchAndUpdateStaff})
        Me.ContextMenuStripMainMenuStaffManagement.Name = "ContextMenuStripMainMenu"
        Me.ContextMenuStripMainMenuStaffManagement.Size = New System.Drawing.Size(239, 48)
        '
        'ToolStripMenuItemRegNewStaff
        '
        Me.ToolStripMenuItemRegNewStaff.Name = "ToolStripMenuItemRegNewStaff"
        Me.ToolStripMenuItemRegNewStaff.Size = New System.Drawing.Size(238, 22)
        Me.ToolStripMenuItemRegNewStaff.Text = "Register New Staff"
        '
        'ToolStripMenuItemSearchAndUpdateStaff
        '
        Me.ToolStripMenuItemSearchAndUpdateStaff.Name = "ToolStripMenuItemSearchAndUpdateStaff"
        Me.ToolStripMenuItemSearchAndUpdateStaff.Size = New System.Drawing.Size(238, 22)
        Me.ToolStripMenuItemSearchAndUpdateStaff.Text = "Search and Update Staff Details"
        '
        'btnStaffManagement
        '
        Me.btnStaffManagement.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStaffManagement.ContextMenuStrip = Me.ContextMenuStripMainMenuStaffManagement
        Me.btnStaffManagement.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStaffManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffManagement.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffManagement.Location = New System.Drawing.Point(444, 256)
        Me.btnStaffManagement.Name = "btnStaffManagement"
        Me.btnStaffManagement.Size = New System.Drawing.Size(112, 42)
        Me.btnStaffManagement.TabIndex = 5
        Me.btnStaffManagement.Text = "Staff &Management"
        Me.btnStaffManagement.UseVisualStyleBackColor = False
        '
        'btnSearchBook
        '
        Me.btnSearchBook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchBook.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBook.Location = New System.Drawing.Point(444, 116)
        Me.btnSearchBook.Name = "btnSearchBook"
        Me.btnSearchBook.Size = New System.Drawing.Size(112, 38)
        Me.btnSearchBook.TabIndex = 2
        Me.btnSearchBook.Text = "&Search Book"
        Me.btnSearchBook.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(557, -1)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(72, 25)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log &out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'LoginRecordTableAdapterMainMenu
        '
        Me.LoginRecordTableAdapterMainMenu.ClearBeforeFill = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.addbook
        Me.PictureBox3.Location = New System.Drawing.Point(95, 182)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'btnAddBook
        '
        Me.btnAddBook.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddBook.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddBook.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBook.Location = New System.Drawing.Point(74, 254)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(112, 42)
        Me.btnAddBook.TabIndex = 3
        Me.btnAddBook.Text = "&Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'MenuStripMainMenu
        '
        Me.MenuStripMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.MenuStripMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMainMenu.Name = "MenuStripMainMenu"
        Me.MenuStripMainMenu.Size = New System.Drawing.Size(628, 24)
        Me.MenuStripMainMenu.TabIndex = 31
        Me.MenuStripMainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkModeToolStripMenuItem, Me.LightModeToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DarkModeToolStripMenuItem
        '
        Me.DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem"
        Me.DarkModeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DarkModeToolStripMenuItem.Text = "Dark mode "
        '
        'LightModeToolStripMenuItem
        '
        Me.LightModeToolStripMenuItem.Name = "LightModeToolStripMenuItem"
        Me.LightModeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LightModeToolStripMenuItem.Text = "Light mode"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(628, 323)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnAddBook)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.picStaffManagement)
        Me.Controls.Add(Me.btnStaffManagement)
        Me.Controls.Add(Me.btnSearchBook)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.btnLoanBook)
        Me.Controls.Add(Me.MenuStripMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripMainMenu
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripMainMenuGenerateReport.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStaffManagement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripMainMenuStaffManagement.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripMainMenu.ResumeLayout(False)
        Me.MenuStripMainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReport As Button
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents btnLoanBook As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents picStaffManagement As PictureBox
    Friend WithEvents btnStaffManagement As Button
    Friend WithEvents btnSearchBook As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents LoginRecordTableAdapterMainMenu As TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnAddBook As Button
    Friend WithEvents MenuStripMainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripMainMenuGenerateReport As ContextMenuStrip
    Friend WithEvents CirculationReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffLoginReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BooksReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffEmploymentReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemRegNewStaff As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSearchAndUpdateStaff As ToolStripMenuItem
    Public WithEvents ContextMenuStripMainMenuStaffManagement As ContextMenuStrip
End Class
