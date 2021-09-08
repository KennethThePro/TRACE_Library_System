<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Staff_and_Update_Staff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Profile_PictureLabel As System.Windows.Forms.Label
        Dim Staff_IDLabel As System.Windows.Forms.Label
        Dim Staff_NameLabel As System.Windows.Forms.Label
        Dim Staff_ICLabel As System.Windows.Forms.Label
        Dim Staff_GenderLabel As System.Windows.Forms.Label
        Dim Staff_Phone_NumberLabel As System.Windows.Forms.Label
        Dim Staff_EmailLabel As System.Windows.Forms.Label
        Dim User_TypeLabel As System.Windows.Forms.Label
        Dim Employment_StatusLabel As System.Windows.Forms.Label
        Dim Date_Of_EmploymentLabel As System.Windows.Forms.Label
        Dim Date_Of_UnemploymentLabel As System.Windows.Forms.Label
        Dim Reason_Of_UnemploymentLabel As System.Windows.Forms.Label
        Dim Staff_AddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_Staff_and_Update_Staff))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.btnReturnToStaffManagement = New System.Windows.Forms.Button()
        Me.grpStaffInformation = New System.Windows.Forms.GroupBox()
        Me.Staff_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRACE_Library_SystemDataSet = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
        Me.Date_Of_UnemploymentDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClearProfilePicture = New System.Windows.Forms.Button()
        Me.btnUpdateProfilePicture = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.grpEmploymentStatus = New System.Windows.Forms.GroupBox()
        Me.radUnemployed = New System.Windows.Forms.RadioButton()
        Me.radEmployed = New System.Windows.Forms.RadioButton()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.radLibrarianStaff = New System.Windows.Forms.RadioButton()
        Me.radAdministrator = New System.Windows.Forms.RadioButton()
        Me.Profile_PicturePictureBox = New System.Windows.Forms.PictureBox()
        Me.Staff_IDMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Staff_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_ICMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Staff_GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Staff_Phone_NumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Staff_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.User_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Employment_StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Of_EmploymentDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Reason_Of_UnemploymentTextBox = New System.Windows.Forms.TextBox()
        Me.StaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FileDialogProfilePicture = New System.Windows.Forms.OpenFileDialog()
        Me.StaffTableAdapter = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.TableAdapterManager()
        Me.ToolTipForSearchUpdateStaff = New System.Windows.Forms.ToolTip(Me.components)
        Profile_PictureLabel = New System.Windows.Forms.Label()
        Staff_IDLabel = New System.Windows.Forms.Label()
        Staff_NameLabel = New System.Windows.Forms.Label()
        Staff_ICLabel = New System.Windows.Forms.Label()
        Staff_GenderLabel = New System.Windows.Forms.Label()
        Staff_Phone_NumberLabel = New System.Windows.Forms.Label()
        Staff_EmailLabel = New System.Windows.Forms.Label()
        User_TypeLabel = New System.Windows.Forms.Label()
        Employment_StatusLabel = New System.Windows.Forms.Label()
        Date_Of_EmploymentLabel = New System.Windows.Forms.Label()
        Date_Of_UnemploymentLabel = New System.Windows.Forms.Label()
        Reason_Of_UnemploymentLabel = New System.Windows.Forms.Label()
        Staff_AddressLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStaffInformation.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGender.SuspendLayout()
        Me.grpEmploymentStatus.SuspendLayout()
        Me.grpType.SuspendLayout()
        CType(Me.Profile_PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Profile_PictureLabel
        '
        Profile_PictureLabel.AutoSize = True
        Profile_PictureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Profile_PictureLabel.ForeColor = System.Drawing.Color.Maroon
        Profile_PictureLabel.Location = New System.Drawing.Point(91, 37)
        Profile_PictureLabel.Name = "Profile_PictureLabel"
        Profile_PictureLabel.Size = New System.Drawing.Size(100, 17)
        Profile_PictureLabel.TabIndex = 0
        Profile_PictureLabel.Text = "Profile Picture:"
        '
        'Staff_IDLabel
        '
        Staff_IDLabel.AutoSize = True
        Staff_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_IDLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_IDLabel.Location = New System.Drawing.Point(380, 137)
        Staff_IDLabel.Name = "Staff_IDLabel"
        Staff_IDLabel.Size = New System.Drawing.Size(58, 17)
        Staff_IDLabel.TabIndex = 3
        Staff_IDLabel.Text = "Staff ID:"
        '
        'Staff_NameLabel
        '
        Staff_NameLabel.AutoSize = True
        Staff_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_NameLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_NameLabel.Location = New System.Drawing.Point(356, 166)
        Staff_NameLabel.Name = "Staff_NameLabel"
        Staff_NameLabel.Size = New System.Drawing.Size(82, 17)
        Staff_NameLabel.TabIndex = 5
        Staff_NameLabel.Text = "Staff Name:"
        '
        'Staff_ICLabel
        '
        Staff_ICLabel.AutoSize = True
        Staff_ICLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_ICLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_ICLabel.Location = New System.Drawing.Point(381, 193)
        Staff_ICLabel.Name = "Staff_ICLabel"
        Staff_ICLabel.Size = New System.Drawing.Size(57, 17)
        Staff_ICLabel.TabIndex = 7
        Staff_ICLabel.Text = "Staff IC:"
        '
        'Staff_GenderLabel
        '
        Staff_GenderLabel.AutoSize = True
        Staff_GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_GenderLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_GenderLabel.Location = New System.Drawing.Point(345, 251)
        Staff_GenderLabel.Name = "Staff_GenderLabel"
        Staff_GenderLabel.Size = New System.Drawing.Size(93, 17)
        Staff_GenderLabel.TabIndex = 11
        Staff_GenderLabel.Text = "Staff Gender:"
        '
        'Staff_Phone_NumberLabel
        '
        Staff_Phone_NumberLabel.AutoSize = True
        Staff_Phone_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_Phone_NumberLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_Phone_NumberLabel.Location = New System.Drawing.Point(298, 365)
        Staff_Phone_NumberLabel.Name = "Staff_Phone_NumberLabel"
        Staff_Phone_NumberLabel.Size = New System.Drawing.Size(140, 17)
        Staff_Phone_NumberLabel.TabIndex = 14
        Staff_Phone_NumberLabel.Text = "Staff Phone Number:"
        '
        'Staff_EmailLabel
        '
        Staff_EmailLabel.AutoSize = True
        Staff_EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_EmailLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_EmailLabel.Location = New System.Drawing.Point(359, 394)
        Staff_EmailLabel.Name = "Staff_EmailLabel"
        Staff_EmailLabel.Size = New System.Drawing.Size(79, 17)
        Staff_EmailLabel.TabIndex = 16
        Staff_EmailLabel.Text = "Staff Email:"
        '
        'User_TypeLabel
        '
        User_TypeLabel.AutoSize = True
        User_TypeLabel.ForeColor = System.Drawing.Color.Maroon
        User_TypeLabel.Location = New System.Drawing.Point(360, 24)
        User_TypeLabel.Name = "User_TypeLabel"
        User_TypeLabel.Size = New System.Drawing.Size(78, 17)
        User_TypeLabel.TabIndex = 0
        User_TypeLabel.Text = "User Type:"
        '
        'Employment_StatusLabel
        '
        Employment_StatusLabel.AutoSize = True
        Employment_StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employment_StatusLabel.ForeColor = System.Drawing.Color.Maroon
        Employment_StatusLabel.Location = New System.Drawing.Point(305, 424)
        Employment_StatusLabel.Name = "Employment_StatusLabel"
        Employment_StatusLabel.Size = New System.Drawing.Size(133, 17)
        Employment_StatusLabel.TabIndex = 18
        Employment_StatusLabel.Text = "Employment Status:"
        '
        'Date_Of_EmploymentLabel
        '
        Date_Of_EmploymentLabel.AutoSize = True
        Date_Of_EmploymentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Of_EmploymentLabel.ForeColor = System.Drawing.Color.Maroon
        Date_Of_EmploymentLabel.Location = New System.Drawing.Point(296, 532)
        Date_Of_EmploymentLabel.Name = "Date_Of_EmploymentLabel"
        Date_Of_EmploymentLabel.Size = New System.Drawing.Size(142, 17)
        Date_Of_EmploymentLabel.TabIndex = 21
        Date_Of_EmploymentLabel.Text = "Date Of Employment:"
        '
        'Date_Of_UnemploymentLabel
        '
        Date_Of_UnemploymentLabel.AutoSize = True
        Date_Of_UnemploymentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Of_UnemploymentLabel.ForeColor = System.Drawing.Color.Maroon
        Date_Of_UnemploymentLabel.Location = New System.Drawing.Point(279, 558)
        Date_Of_UnemploymentLabel.Name = "Date_Of_UnemploymentLabel"
        Date_Of_UnemploymentLabel.Size = New System.Drawing.Size(159, 17)
        Date_Of_UnemploymentLabel.TabIndex = 23
        Date_Of_UnemploymentLabel.Text = "Date Of Unemployment:"
        '
        'Reason_Of_UnemploymentLabel
        '
        Reason_Of_UnemploymentLabel.AutoSize = True
        Reason_Of_UnemploymentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Reason_Of_UnemploymentLabel.ForeColor = System.Drawing.Color.Maroon
        Reason_Of_UnemploymentLabel.Location = New System.Drawing.Point(260, 585)
        Reason_Of_UnemploymentLabel.Name = "Reason_Of_UnemploymentLabel"
        Reason_Of_UnemploymentLabel.Size = New System.Drawing.Size(178, 17)
        Reason_Of_UnemploymentLabel.TabIndex = 25
        Reason_Of_UnemploymentLabel.Text = "Reason Of Unemployment:"
        '
        'Staff_AddressLabel
        '
        Staff_AddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Staff_AddressLabel.AutoSize = True
        Staff_AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_AddressLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_AddressLabel.Location = New System.Drawing.Point(341, 219)
        Staff_AddressLabel.Name = "Staff_AddressLabel"
        Staff_AddressLabel.Size = New System.Drawing.Size(97, 17)
        Staff_AddressLabel.TabIndex = 9
        Staff_AddressLabel.Text = "Staff Address:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.search_icon
        Me.PictureBox1.Location = New System.Drawing.Point(508, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'btnClearSearch
        '
        Me.btnClearSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnClearSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClearSearch.Enabled = False
        Me.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSearch.ForeColor = System.Drawing.Color.Black
        Me.btnClearSearch.Location = New System.Drawing.Point(275, 44)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(108, 41)
        Me.btnClearSearch.TabIndex = 6
        Me.btnClearSearch.Text = "Clea&r Search"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.btnClearSearch, "Clears the entire Staff Information and Resets the Search")
        Me.btnClearSearch.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.Enabled = False
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(394, 44)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(108, 41)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Searc&h Staff"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.btnSearch, "Search for Staff Information based on Search Term")
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSearch.Location = New System.Drawing.Point(369, 16)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(176, 23)
        Me.txtSearch.TabIndex = 3
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.txtSearch, "Input search term")
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(271, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Enter Search : "
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(10, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Search By : "
        '
        'cboSearchBy
        '
        Me.cboSearchBy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Staff ID", "Staff Name"})
        Me.cboSearchBy.Location = New System.Drawing.Point(97, 16)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(163, 21)
        Me.cboSearchBy.TabIndex = 1
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.cboSearchBy, "Search by Staff ID or Staff Name")
        '
        'btnReturnToStaffManagement
        '
        Me.btnReturnToStaffManagement.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnReturnToStaffManagement.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnToStaffManagement.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReturnToStaffManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturnToStaffManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnToStaffManagement.ForeColor = System.Drawing.Color.Black
        Me.btnReturnToStaffManagement.Location = New System.Drawing.Point(601, 30)
        Me.btnReturnToStaffManagement.Name = "btnReturnToStaffManagement"
        Me.btnReturnToStaffManagement.Size = New System.Drawing.Size(154, 49)
        Me.btnReturnToStaffManagement.TabIndex = 7
        Me.btnReturnToStaffManagement.Text = "R&eturn to Staff Management"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.btnReturnToStaffManagement, "Return back to the Staff Management Menu")
        Me.btnReturnToStaffManagement.UseVisualStyleBackColor = False
        '
        'grpStaffInformation
        '
        Me.grpStaffInformation.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpStaffInformation.Controls.Add(Staff_AddressLabel)
        Me.grpStaffInformation.Controls.Add(Me.Staff_AddressTextBox)
        Me.grpStaffInformation.Controls.Add(Me.Date_Of_UnemploymentDateTimePicker)
        Me.grpStaffInformation.Controls.Add(Me.btnSave)
        Me.grpStaffInformation.Controls.Add(Me.btnCancel)
        Me.grpStaffInformation.Controls.Add(Me.btnClearProfilePicture)
        Me.grpStaffInformation.Controls.Add(Me.btnUpdateProfilePicture)
        Me.grpStaffInformation.Controls.Add(Me.btnEdit)
        Me.grpStaffInformation.Controls.Add(Me.grpGender)
        Me.grpStaffInformation.Controls.Add(Me.grpEmploymentStatus)
        Me.grpStaffInformation.Controls.Add(Me.grpType)
        Me.grpStaffInformation.Controls.Add(Profile_PictureLabel)
        Me.grpStaffInformation.Controls.Add(Me.Profile_PicturePictureBox)
        Me.grpStaffInformation.Controls.Add(Staff_IDLabel)
        Me.grpStaffInformation.Controls.Add(Me.Staff_IDMaskedTextBox)
        Me.grpStaffInformation.Controls.Add(Staff_NameLabel)
        Me.grpStaffInformation.Controls.Add(Me.Staff_NameTextBox)
        Me.grpStaffInformation.Controls.Add(Staff_ICLabel)
        Me.grpStaffInformation.Controls.Add(Me.Staff_ICMaskedTextBox)
        Me.grpStaffInformation.Controls.Add(Staff_GenderLabel)
        Me.grpStaffInformation.Controls.Add(Me.Staff_GenderTextBox)
        Me.grpStaffInformation.Controls.Add(Staff_Phone_NumberLabel)
        Me.grpStaffInformation.Controls.Add(Me.Staff_Phone_NumberMaskedTextBox)
        Me.grpStaffInformation.Controls.Add(Staff_EmailLabel)
        Me.grpStaffInformation.Controls.Add(Me.Staff_EmailTextBox)
        Me.grpStaffInformation.Controls.Add(User_TypeLabel)
        Me.grpStaffInformation.Controls.Add(Me.User_TypeTextBox)
        Me.grpStaffInformation.Controls.Add(Employment_StatusLabel)
        Me.grpStaffInformation.Controls.Add(Me.Employment_StatusTextBox)
        Me.grpStaffInformation.Controls.Add(Date_Of_EmploymentLabel)
        Me.grpStaffInformation.Controls.Add(Me.Date_Of_EmploymentDateTimePicker)
        Me.grpStaffInformation.Controls.Add(Date_Of_UnemploymentLabel)
        Me.grpStaffInformation.Controls.Add(Reason_Of_UnemploymentLabel)
        Me.grpStaffInformation.Controls.Add(Me.Reason_Of_UnemploymentTextBox)
        Me.grpStaffInformation.Enabled = False
        Me.grpStaffInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStaffInformation.ForeColor = System.Drawing.Color.Maroon
        Me.grpStaffInformation.Location = New System.Drawing.Point(21, 91)
        Me.grpStaffInformation.Name = "grpStaffInformation"
        Me.grpStaffInformation.Size = New System.Drawing.Size(772, 661)
        Me.grpStaffInformation.TabIndex = 5
        Me.grpStaffInformation.TabStop = False
        Me.grpStaffInformation.Text = "Staff Information"
        '
        'Staff_AddressTextBox
        '
        Me.Staff_AddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Staff_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Address", True))
        Me.Staff_AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_AddressTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Staff_AddressTextBox.Location = New System.Drawing.Point(440, 218)
        Me.Staff_AddressTextBox.Name = "Staff_AddressTextBox"
        Me.Staff_AddressTextBox.ReadOnly = True
        Me.Staff_AddressTextBox.Size = New System.Drawing.Size(327, 23)
        Me.Staff_AddressTextBox.TabIndex = 10
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.Staff_AddressTextBox, "Display the Staff Address")
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.TRACE_Library_SystemDataSet
        '
        'TRACE_Library_SystemDataSet
        '
        Me.TRACE_Library_SystemDataSet.DataSetName = "TRACE_Library_SystemDataSet"
        Me.TRACE_Library_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Date_Of_UnemploymentDateTimePicker
        '
        Me.Date_Of_UnemploymentDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "Date Of Unemployment", True))
        Me.Date_Of_UnemploymentDateTimePicker.Enabled = False
        Me.Date_Of_UnemploymentDateTimePicker.Location = New System.Drawing.Point(440, 554)
        Me.Date_Of_UnemploymentDateTimePicker.Name = "Date_Of_UnemploymentDateTimePicker"
        Me.Date_Of_UnemploymentDateTimePicker.Size = New System.Drawing.Size(327, 23)
        Me.Date_Of_UnemploymentDateTimePicker.TabIndex = 24
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.Date_Of_UnemploymentDateTimePicker, "Display Staff Date Of Unemployment")
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(524, 614)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 41)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "&Save"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.btnSave, "Save the updated Staff Information")
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Enabled = False
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(657, 614)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 41)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "&Cancel"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.btnCancel, "Cancel the current Update Process and Undo Changes")
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnClearProfilePicture
        '
        Me.btnClearProfilePicture.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearProfilePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearProfilePicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearProfilePicture.ForeColor = System.Drawing.Color.Black
        Me.btnClearProfilePicture.Location = New System.Drawing.Point(180, 213)
        Me.btnClearProfilePicture.Name = "btnClearProfilePicture"
        Me.btnClearProfilePicture.Size = New System.Drawing.Size(108, 41)
        Me.btnClearProfilePicture.TabIndex = 28
        Me.btnClearProfilePicture.Text = "C&lear Profile Picture"
        Me.btnClearProfilePicture.UseVisualStyleBackColor = False
        '
        'btnUpdateProfilePicture
        '
        Me.btnUpdateProfilePicture.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdateProfilePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateProfilePicture.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateProfilePicture.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateProfilePicture.Location = New System.Drawing.Point(45, 213)
        Me.btnUpdateProfilePicture.Name = "btnUpdateProfilePicture"
        Me.btnUpdateProfilePicture.Size = New System.Drawing.Size(108, 41)
        Me.btnUpdateProfilePicture.TabIndex = 27
        Me.btnUpdateProfilePicture.Text = "U&pdate Profile &Picture"
        Me.btnUpdateProfilePicture.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(399, 614)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(108, 41)
        Me.btnEdit.TabIndex = 29
        Me.btnEdit.Text = "E&dit"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.btnEdit, "Edit the Staff Information")
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.radFemale)
        Me.grpGender.Controls.Add(Me.radMale)
        Me.grpGender.Enabled = False
        Me.grpGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGender.ForeColor = System.Drawing.Color.Maroon
        Me.grpGender.Location = New System.Drawing.Point(440, 285)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(327, 69)
        Me.grpGender.TabIndex = 13
        Me.grpGender.TabStop = False
        Me.grpGender.Text = "Change Gender"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFemale.ForeColor = System.Drawing.Color.Maroon
        Me.radFemale.Location = New System.Drawing.Point(21, 42)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(72, 21)
        Me.radFemale.TabIndex = 1
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "&Female"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.radFemale, "Staff is a Female")
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.ForeColor = System.Drawing.Color.Maroon
        Me.radMale.Location = New System.Drawing.Point(21, 19)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(56, 21)
        Me.radMale.TabIndex = 0
        Me.radMale.TabStop = True
        Me.radMale.Text = "&Male"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.radMale, "Staff is a Male")
        Me.radMale.UseVisualStyleBackColor = True
        '
        'grpEmploymentStatus
        '
        Me.grpEmploymentStatus.Controls.Add(Me.radUnemployed)
        Me.grpEmploymentStatus.Controls.Add(Me.radEmployed)
        Me.grpEmploymentStatus.Enabled = False
        Me.grpEmploymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpEmploymentStatus.ForeColor = System.Drawing.Color.Maroon
        Me.grpEmploymentStatus.Location = New System.Drawing.Point(440, 448)
        Me.grpEmploymentStatus.Name = "grpEmploymentStatus"
        Me.grpEmploymentStatus.Size = New System.Drawing.Size(327, 63)
        Me.grpEmploymentStatus.TabIndex = 20
        Me.grpEmploymentStatus.TabStop = False
        Me.grpEmploymentStatus.Text = "Change Employment Status"
        '
        'radUnemployed
        '
        Me.radUnemployed.AutoSize = True
        Me.radUnemployed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUnemployed.ForeColor = System.Drawing.Color.Maroon
        Me.radUnemployed.Location = New System.Drawing.Point(10, 40)
        Me.radUnemployed.Name = "radUnemployed"
        Me.radUnemployed.Size = New System.Drawing.Size(105, 21)
        Me.radUnemployed.TabIndex = 1
        Me.radUnemployed.Text = "&Unemployed"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.radUnemployed, "Staff Is Unemployed")
        Me.radUnemployed.UseVisualStyleBackColor = True
        '
        'radEmployed
        '
        Me.radEmployed.AutoSize = True
        Me.radEmployed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEmployed.ForeColor = System.Drawing.Color.Maroon
        Me.radEmployed.Location = New System.Drawing.Point(10, 19)
        Me.radEmployed.Name = "radEmployed"
        Me.radEmployed.Size = New System.Drawing.Size(88, 21)
        Me.radEmployed.TabIndex = 0
        Me.radEmployed.Text = "Emplo&yed"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.radEmployed, "Staff is Employed")
        Me.radEmployed.UseVisualStyleBackColor = True
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.radLibrarianStaff)
        Me.grpType.Controls.Add(Me.radAdministrator)
        Me.grpType.Enabled = False
        Me.grpType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpType.ForeColor = System.Drawing.Color.Maroon
        Me.grpType.Location = New System.Drawing.Point(440, 54)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(327, 69)
        Me.grpType.TabIndex = 2
        Me.grpType.TabStop = False
        Me.grpType.Text = "User Type"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.grpType, "User Type cannot be changed")
        '
        'radLibrarianStaff
        '
        Me.radLibrarianStaff.AutoSize = True
        Me.radLibrarianStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLibrarianStaff.ForeColor = System.Drawing.Color.Maroon
        Me.radLibrarianStaff.Location = New System.Drawing.Point(21, 42)
        Me.radLibrarianStaff.Name = "radLibrarianStaff"
        Me.radLibrarianStaff.Size = New System.Drawing.Size(115, 21)
        Me.radLibrarianStaff.TabIndex = 1
        Me.radLibrarianStaff.TabStop = True
        Me.radLibrarianStaff.Text = "L&ibrarian Staff"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.radLibrarianStaff, "&Librarian Staff")
        Me.radLibrarianStaff.UseVisualStyleBackColor = True
        '
        'radAdministrator
        '
        Me.radAdministrator.AutoSize = True
        Me.radAdministrator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAdministrator.ForeColor = System.Drawing.Color.Maroon
        Me.radAdministrator.Location = New System.Drawing.Point(21, 19)
        Me.radAdministrator.Name = "radAdministrator"
        Me.radAdministrator.Size = New System.Drawing.Size(109, 21)
        Me.radAdministrator.TabIndex = 0
        Me.radAdministrator.TabStop = True
        Me.radAdministrator.Text = "&Administrator"
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.radAdministrator, "Administrator has access to Staff Management")
        Me.radAdministrator.UseVisualStyleBackColor = True
        '
        'Profile_PicturePictureBox
        '
        Me.Profile_PicturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Profile_PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StaffBindingSource, "Profile Picture", True))
        Me.Profile_PicturePictureBox.Location = New System.Drawing.Point(94, 57)
        Me.Profile_PicturePictureBox.Name = "Profile_PicturePictureBox"
        Me.Profile_PicturePictureBox.Size = New System.Drawing.Size(113, 134)
        Me.Profile_PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Profile_PicturePictureBox.TabIndex = 1
        Me.Profile_PicturePictureBox.TabStop = False
        '
        'Staff_IDMaskedTextBox
        '
        Me.Staff_IDMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff ID", True))
        Me.Staff_IDMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_IDMaskedTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Staff_IDMaskedTextBox.Location = New System.Drawing.Point(440, 134)
        Me.Staff_IDMaskedTextBox.Name = "Staff_IDMaskedTextBox"
        Me.Staff_IDMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Staff_IDMaskedTextBox.ReadOnly = True
        Me.Staff_IDMaskedTextBox.Size = New System.Drawing.Size(327, 23)
        Me.Staff_IDMaskedTextBox.TabIndex = 4
        Me.Staff_IDMaskedTextBox.TabStop = False
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.Staff_IDMaskedTextBox, "Displays Staff ID and cannot be changed")
        '
        'Staff_NameTextBox
        '
        Me.Staff_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Name", True))
        Me.Staff_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_NameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Staff_NameTextBox.Location = New System.Drawing.Point(440, 162)
        Me.Staff_NameTextBox.MaxLength = 40
        Me.Staff_NameTextBox.Name = "Staff_NameTextBox"
        Me.Staff_NameTextBox.ReadOnly = True
        Me.Staff_NameTextBox.Size = New System.Drawing.Size(327, 23)
        Me.Staff_NameTextBox.TabIndex = 6
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.Staff_NameTextBox, "Displays the Staff Name")
        '
        'Staff_ICMaskedTextBox
        '
        Me.Staff_ICMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Staff_ICMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff IC", True))
        Me.Staff_ICMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_ICMaskedTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Staff_ICMaskedTextBox.Location = New System.Drawing.Point(440, 190)
        Me.Staff_ICMaskedTextBox.Mask = "000000000000"
        Me.Staff_ICMaskedTextBox.Name = "Staff_ICMaskedTextBox"
        Me.Staff_ICMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Staff_ICMaskedTextBox.ReadOnly = True
        Me.Staff_ICMaskedTextBox.Size = New System.Drawing.Size(327, 23)
        Me.Staff_ICMaskedTextBox.TabIndex = 8
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.Staff_ICMaskedTextBox, "Displays the Staff IC Number")
        '
        'Staff_GenderTextBox
        '
        Me.Staff_GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Gender", True))
        Me.Staff_GenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_GenderTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Staff_GenderTextBox.Location = New System.Drawing.Point(440, 249)
        Me.Staff_GenderTextBox.Name = "Staff_GenderTextBox"
        Me.Staff_GenderTextBox.ReadOnly = True
        Me.Staff_GenderTextBox.Size = New System.Drawing.Size(327, 23)
        Me.Staff_GenderTextBox.TabIndex = 12
        Me.Staff_GenderTextBox.TabStop = False
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.Staff_GenderTextBox, "Displays the Staff Gender")
        '
        'Staff_Phone_NumberMaskedTextBox
        '
        Me.Staff_Phone_NumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Phone Number", True))
        Me.Staff_Phone_NumberMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_Phone_NumberMaskedTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Staff_Phone_NumberMaskedTextBox.Location = New System.Drawing.Point(440, 361)
        Me.Staff_Phone_NumberMaskedTextBox.Mask = "0000000000"
        Me.Staff_Phone_NumberMaskedTextBox.Name = "Staff_Phone_NumberMaskedTextBox"
        Me.Staff_Phone_NumberMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Staff_Phone_NumberMaskedTextBox.ReadOnly = True
        Me.Staff_Phone_NumberMaskedTextBox.Size = New System.Drawing.Size(327, 23)
        Me.Staff_Phone_NumberMaskedTextBox.TabIndex = 15
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.Staff_Phone_NumberMaskedTextBox, "Displays Staff Phone Number")
        '
        'Staff_EmailTextBox
        '
        Me.Staff_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Email", True))
        Me.Staff_EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_EmailTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Staff_EmailTextBox.Location = New System.Drawing.Point(440, 390)
        Me.Staff_EmailTextBox.Name = "Staff_EmailTextBox"
        Me.Staff_EmailTextBox.ReadOnly = True
        Me.Staff_EmailTextBox.Size = New System.Drawing.Size(327, 23)
        Me.Staff_EmailTextBox.TabIndex = 17
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.Staff_EmailTextBox, "Displays Staff Email")
        '
        'User_TypeTextBox
        '
        Me.User_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "User Type", True))
        Me.User_TypeTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.User_TypeTextBox.Location = New System.Drawing.Point(440, 19)
        Me.User_TypeTextBox.Name = "User_TypeTextBox"
        Me.User_TypeTextBox.ReadOnly = True
        Me.User_TypeTextBox.Size = New System.Drawing.Size(327, 23)
        Me.User_TypeTextBox.TabIndex = 1
        Me.User_TypeTextBox.TabStop = False
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.User_TypeTextBox, "Displays User Type")
        '
        'Employment_StatusTextBox
        '
        Me.Employment_StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Employment Status", True))
        Me.Employment_StatusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employment_StatusTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Employment_StatusTextBox.Location = New System.Drawing.Point(440, 421)
        Me.Employment_StatusTextBox.Name = "Employment_StatusTextBox"
        Me.Employment_StatusTextBox.ReadOnly = True
        Me.Employment_StatusTextBox.Size = New System.Drawing.Size(327, 23)
        Me.Employment_StatusTextBox.TabIndex = 19
        Me.Employment_StatusTextBox.TabStop = False
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.Employment_StatusTextBox, "Displays Employment Status of Staff")
        '
        'Date_Of_EmploymentDateTimePicker
        '
        Me.Date_Of_EmploymentDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "Date Of Employment", True))
        Me.Date_Of_EmploymentDateTimePicker.Enabled = False
        Me.Date_Of_EmploymentDateTimePicker.Location = New System.Drawing.Point(440, 528)
        Me.Date_Of_EmploymentDateTimePicker.Name = "Date_Of_EmploymentDateTimePicker"
        Me.Date_Of_EmploymentDateTimePicker.Size = New System.Drawing.Size(327, 23)
        Me.Date_Of_EmploymentDateTimePicker.TabIndex = 22
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.Date_Of_EmploymentDateTimePicker, "Displays Staff Date of Employment")
        '
        'Reason_Of_UnemploymentTextBox
        '
        Me.Reason_Of_UnemploymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Reason Of Unemployment", True))
        Me.Reason_Of_UnemploymentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reason_Of_UnemploymentTextBox.ForeColor = System.Drawing.Color.Maroon
        Me.Reason_Of_UnemploymentTextBox.Location = New System.Drawing.Point(440, 583)
        Me.Reason_Of_UnemploymentTextBox.Name = "Reason_Of_UnemploymentTextBox"
        Me.Reason_Of_UnemploymentTextBox.ReadOnly = True
        Me.Reason_Of_UnemploymentTextBox.Size = New System.Drawing.Size(327, 23)
        Me.Reason_Of_UnemploymentTextBox.TabIndex = 26
        Me.ToolTipForSearchUpdateStaff.SetToolTip(Me.Reason_Of_UnemploymentTextBox, "Displays Reason of Unemployment")
        '
        'StaffBindingNavigator
        '
        Me.StaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffBindingNavigator.BindingSource = Me.StaffBindingSource
        Me.StaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffBindingNavigatorSaveItem})
        Me.StaffBindingNavigator.Location = New System.Drawing.Point(0, 2)
        Me.StaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffBindingNavigator.Name = "StaffBindingNavigator"
        Me.StaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffBindingNavigator.Size = New System.Drawing.Size(828, 22)
        Me.StaffBindingNavigator.TabIndex = 69
        Me.StaffBindingNavigator.Text = "BindingNavigator1"
        Me.StaffBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 19)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 22)
        '
        'StaffBindingNavigatorSaveItem
        '
        Me.StaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffBindingNavigatorSaveItem.Name = "StaffBindingNavigatorSaveItem"
        Me.StaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 19)
        Me.StaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FileDialogProfilePicture
        '
        Me.FileDialogProfilePicture.FileName = "OpenFileDialog1"
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.CirculationTableAdapter = Nothing
        Me.TableAdapterManager.LoginRecordTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Search_Staff_and_Update_Staff
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 5)
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(828, 763)
        Me.Controls.Add(Me.StaffBindingNavigator)
        Me.Controls.Add(Me.grpStaffInformation)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClearSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboSearchBy)
        Me.Controls.Add(Me.btnReturnToStaffManagement)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Search_Staff_and_Update_Staff"
        Me.Text = "Search Staff and Update Staff"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStaffInformation.ResumeLayout(False)
        Me.grpStaffInformation.PerformLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.grpEmploymentStatus.ResumeLayout(False)
        Me.grpEmploymentStatus.PerformLayout()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        CType(Me.Profile_PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffBindingNavigator.ResumeLayout(False)
        Me.StaffBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboSearchBy As ComboBox
    Friend WithEvents btnReturnToStaffManagement As Button
    Friend WithEvents grpStaffInformation As GroupBox
    Friend WithEvents TRACE_Library_SystemDataSet As TRACE_Library_SystemDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As TRACE_Library_SystemDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As TRACE_Library_SystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StaffBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClearProfilePicture As Button
    Friend WithEvents btnUpdateProfilePicture As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents grpEmploymentStatus As GroupBox
    Friend WithEvents radUnemployed As RadioButton
    Friend WithEvents radEmployed As RadioButton
    Friend WithEvents grpType As GroupBox
    Friend WithEvents radLibrarianStaff As RadioButton
    Friend WithEvents radAdministrator As RadioButton
    Friend WithEvents Profile_PicturePictureBox As PictureBox
    Friend WithEvents Staff_IDMaskedTextBox As MaskedTextBox
    Friend WithEvents Staff_NameTextBox As TextBox
    Friend WithEvents Staff_ICMaskedTextBox As MaskedTextBox
    Friend WithEvents Staff_GenderTextBox As TextBox
    Friend WithEvents Staff_Phone_NumberMaskedTextBox As MaskedTextBox
    Friend WithEvents Staff_EmailTextBox As TextBox
    Friend WithEvents User_TypeTextBox As TextBox
    Friend WithEvents Employment_StatusTextBox As TextBox
    Friend WithEvents Date_Of_EmploymentDateTimePicker As DateTimePicker
    Friend WithEvents Reason_Of_UnemploymentTextBox As TextBox
    Friend WithEvents FileDialogProfilePicture As OpenFileDialog
    Friend WithEvents Date_Of_UnemploymentDateTimePicker As DateTimePicker
    Friend WithEvents Staff_AddressTextBox As TextBox
    Friend WithEvents ToolTipForSearchUpdateStaff As ToolTip
End Class
