<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register_New_Staff
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
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Staff_AddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_New_Staff))
        Me.TRACE_Library_SystemDataSet = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.TableAdapterManager()
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
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.grpUserType = New System.Windows.Forms.GroupBox()
        Me.radLibrarianStaff = New System.Windows.Forms.RadioButton()
        Me.radAdministrator = New System.Windows.Forms.RadioButton()
        Me.btnReturnToStaffManagement = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClearProfilePicture = New System.Windows.Forms.Button()
        Me.btnAddProfilePicture = New System.Windows.Forms.Button()
        Me.FileDialogProfilePicture = New System.Windows.Forms.OpenFileDialog()
        Me.Staff_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTipForAddStaffInformation = New System.Windows.Forms.ToolTip(Me.components)
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
        PasswordLabel = New System.Windows.Forms.Label()
        Staff_AddressLabel = New System.Windows.Forms.Label()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffBindingNavigator.SuspendLayout()
        CType(Me.Profile_PicturePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGender.SuspendLayout()
        Me.grpUserType.SuspendLayout()
        Me.SuspendLayout()
        '
        'Profile_PictureLabel
        '
        Profile_PictureLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Profile_PictureLabel.AutoSize = True
        Profile_PictureLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Profile_PictureLabel.ForeColor = System.Drawing.Color.Maroon
        Profile_PictureLabel.Location = New System.Drawing.Point(118, 31)
        Profile_PictureLabel.Name = "Profile_PictureLabel"
        Profile_PictureLabel.Size = New System.Drawing.Size(94, 15)
        Profile_PictureLabel.TabIndex = 1
        Profile_PictureLabel.Text = "Profile Picture:"
        '
        'Staff_IDLabel
        '
        Staff_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Staff_IDLabel.AutoSize = True
        Staff_IDLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_IDLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_IDLabel.Location = New System.Drawing.Point(330, 128)
        Staff_IDLabel.Name = "Staff_IDLabel"
        Staff_IDLabel.Size = New System.Drawing.Size(58, 15)
        Staff_IDLabel.TabIndex = 3
        Staff_IDLabel.Text = "Staff ID:"
        '
        'Staff_NameLabel
        '
        Staff_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Staff_NameLabel.AutoSize = True
        Staff_NameLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_NameLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_NameLabel.Location = New System.Drawing.Point(312, 154)
        Staff_NameLabel.Name = "Staff_NameLabel"
        Staff_NameLabel.Size = New System.Drawing.Size(76, 15)
        Staff_NameLabel.TabIndex = 5
        Staff_NameLabel.Text = "Staff Name:"
        '
        'Staff_ICLabel
        '
        Staff_ICLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Staff_ICLabel.AutoSize = True
        Staff_ICLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_ICLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_ICLabel.Location = New System.Drawing.Point(331, 180)
        Staff_ICLabel.Name = "Staff_ICLabel"
        Staff_ICLabel.Size = New System.Drawing.Size(57, 15)
        Staff_ICLabel.TabIndex = 7
        Staff_ICLabel.Text = "Staff IC:"
        '
        'Staff_GenderLabel
        '
        Staff_GenderLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Staff_GenderLabel.AutoSize = True
        Staff_GenderLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_GenderLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_GenderLabel.Location = New System.Drawing.Point(304, 235)
        Staff_GenderLabel.Name = "Staff_GenderLabel"
        Staff_GenderLabel.Size = New System.Drawing.Size(84, 15)
        Staff_GenderLabel.TabIndex = 11
        Staff_GenderLabel.Text = "Staff Gender:"
        '
        'Staff_Phone_NumberLabel
        '
        Staff_Phone_NumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Staff_Phone_NumberLabel.AutoSize = True
        Staff_Phone_NumberLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_Phone_NumberLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_Phone_NumberLabel.Location = New System.Drawing.Point(260, 344)
        Staff_Phone_NumberLabel.Name = "Staff_Phone_NumberLabel"
        Staff_Phone_NumberLabel.Size = New System.Drawing.Size(128, 15)
        Staff_Phone_NumberLabel.TabIndex = 14
        Staff_Phone_NumberLabel.Text = "Staff Phone Number:"
        '
        'Staff_EmailLabel
        '
        Staff_EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Staff_EmailLabel.AutoSize = True
        Staff_EmailLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_EmailLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_EmailLabel.Location = New System.Drawing.Point(311, 370)
        Staff_EmailLabel.Name = "Staff_EmailLabel"
        Staff_EmailLabel.Size = New System.Drawing.Size(77, 15)
        Staff_EmailLabel.TabIndex = 16
        Staff_EmailLabel.Text = "Staff Email:"
        '
        'User_TypeLabel
        '
        User_TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        User_TypeLabel.AutoSize = True
        User_TypeLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        User_TypeLabel.ForeColor = System.Drawing.Color.Maroon
        User_TypeLabel.Location = New System.Drawing.Point(318, 18)
        User_TypeLabel.Name = "User_TypeLabel"
        User_TypeLabel.Size = New System.Drawing.Size(70, 15)
        User_TypeLabel.TabIndex = 0
        User_TypeLabel.Text = "User Type:"
        '
        'Employment_StatusLabel
        '
        Employment_StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Employment_StatusLabel.AutoSize = True
        Employment_StatusLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employment_StatusLabel.ForeColor = System.Drawing.Color.Maroon
        Employment_StatusLabel.Location = New System.Drawing.Point(266, 404)
        Employment_StatusLabel.Name = "Employment_StatusLabel"
        Employment_StatusLabel.Size = New System.Drawing.Size(122, 15)
        Employment_StatusLabel.TabIndex = 18
        Employment_StatusLabel.Text = "Employment Status:"
        '
        'Date_Of_EmploymentLabel
        '
        Date_Of_EmploymentLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Date_Of_EmploymentLabel.AutoSize = True
        Date_Of_EmploymentLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Of_EmploymentLabel.ForeColor = System.Drawing.Color.Maroon
        Date_Of_EmploymentLabel.Location = New System.Drawing.Point(255, 434)
        Date_Of_EmploymentLabel.Name = "Date_Of_EmploymentLabel"
        Date_Of_EmploymentLabel.Size = New System.Drawing.Size(133, 15)
        Date_Of_EmploymentLabel.TabIndex = 20
        Date_Of_EmploymentLabel.Text = "Date Of Employment:"
        '
        'PasswordLabel
        '
        PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.Color.Maroon
        PasswordLabel.Location = New System.Drawing.Point(196, 468)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(192, 15)
        PasswordLabel.TabIndex = 22
        PasswordLabel.Text = "Default Password Is IC Number:"
        '
        'Staff_AddressLabel
        '
        Staff_AddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Staff_AddressLabel.AutoSize = True
        Staff_AddressLabel.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staff_AddressLabel.ForeColor = System.Drawing.Color.Maroon
        Staff_AddressLabel.Location = New System.Drawing.Point(300, 206)
        Staff_AddressLabel.Name = "Staff_AddressLabel"
        Staff_AddressLabel.Size = New System.Drawing.Size(88, 15)
        Staff_AddressLabel.TabIndex = 9
        Staff_AddressLabel.Text = "Staff Address:"
        '
        'TRACE_Library_SystemDataSet
        '
        Me.TRACE_Library_SystemDataSet.DataSetName = "TRACE_Library_SystemDataSet"
        Me.TRACE_Library_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.TRACE_Library_SystemDataSet
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
        'StaffBindingNavigator
        '
        Me.StaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffBindingNavigator.BindingSource = Me.StaffBindingSource
        Me.StaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffBindingNavigatorSaveItem})
        Me.StaffBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffBindingNavigator.Name = "StaffBindingNavigator"
        Me.StaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffBindingNavigator.Size = New System.Drawing.Size(703, 25)
        Me.StaffBindingNavigator.TabIndex = 0
        Me.StaffBindingNavigator.Text = "BindingNavigator1"
        Me.StaffBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StaffBindingNavigatorSaveItem
        '
        Me.StaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffBindingNavigatorSaveItem.Name = "StaffBindingNavigatorSaveItem"
        Me.StaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 22)
        Me.StaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Profile_PicturePictureBox
        '
        Me.Profile_PicturePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Profile_PicturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Profile_PicturePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.StaffBindingSource, "Profile Picture", True))
        Me.Profile_PicturePictureBox.Location = New System.Drawing.Point(100, 57)
        Me.Profile_PicturePictureBox.Name = "Profile_PicturePictureBox"
        Me.Profile_PicturePictureBox.Size = New System.Drawing.Size(109, 132)
        Me.Profile_PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Profile_PicturePictureBox.TabIndex = 2
        Me.Profile_PicturePictureBox.TabStop = False
        '
        'Staff_IDMaskedTextBox
        '
        Me.Staff_IDMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Staff_IDMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff ID", True))
        Me.Staff_IDMaskedTextBox.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_IDMaskedTextBox.ForeColor = System.Drawing.Color.White
        Me.Staff_IDMaskedTextBox.Location = New System.Drawing.Point(393, 124)
        Me.Staff_IDMaskedTextBox.Mask = "00000>L"
        Me.Staff_IDMaskedTextBox.Name = "Staff_IDMaskedTextBox"
        Me.Staff_IDMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Staff_IDMaskedTextBox.ReadOnly = True
        Me.Staff_IDMaskedTextBox.Size = New System.Drawing.Size(323, 23)
        Me.Staff_IDMaskedTextBox.TabIndex = 4
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.Staff_IDMaskedTextBox, "Staff ID is auto generated")
        '
        'Staff_NameTextBox
        '
        Me.Staff_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Staff_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Name", True))
        Me.Staff_NameTextBox.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_NameTextBox.Location = New System.Drawing.Point(393, 150)
        Me.Staff_NameTextBox.MaxLength = 40
        Me.Staff_NameTextBox.Name = "Staff_NameTextBox"
        Me.Staff_NameTextBox.Size = New System.Drawing.Size(323, 23)
        Me.Staff_NameTextBox.TabIndex = 6
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.Staff_NameTextBox, "Inout Staff Name")
        '
        'Staff_ICMaskedTextBox
        '
        Me.Staff_ICMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Staff_ICMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff IC", True))
        Me.Staff_ICMaskedTextBox.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_ICMaskedTextBox.Location = New System.Drawing.Point(393, 176)
        Me.Staff_ICMaskedTextBox.Mask = "000000000000"
        Me.Staff_ICMaskedTextBox.Name = "Staff_ICMaskedTextBox"
        Me.Staff_ICMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Staff_ICMaskedTextBox.Size = New System.Drawing.Size(323, 23)
        Me.Staff_ICMaskedTextBox.TabIndex = 8
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.Staff_ICMaskedTextBox, "Input Staff IC (12 Digits Required with no Dashes)")
        '
        'Staff_GenderTextBox
        '
        Me.Staff_GenderTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Staff_GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Gender", True))
        Me.Staff_GenderTextBox.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_GenderTextBox.ForeColor = System.Drawing.Color.White
        Me.Staff_GenderTextBox.Location = New System.Drawing.Point(394, 229)
        Me.Staff_GenderTextBox.Name = "Staff_GenderTextBox"
        Me.Staff_GenderTextBox.ReadOnly = True
        Me.Staff_GenderTextBox.Size = New System.Drawing.Size(322, 23)
        Me.Staff_GenderTextBox.TabIndex = 12
        Me.Staff_GenderTextBox.TabStop = False
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.Staff_GenderTextBox, "Automatically filled up when selecting Staff Gender")
        '
        'Staff_Phone_NumberMaskedTextBox
        '
        Me.Staff_Phone_NumberMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Staff_Phone_NumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Phone Number", True))
        Me.Staff_Phone_NumberMaskedTextBox.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_Phone_NumberMaskedTextBox.Location = New System.Drawing.Point(394, 341)
        Me.Staff_Phone_NumberMaskedTextBox.Mask = "0000000000"
        Me.Staff_Phone_NumberMaskedTextBox.Name = "Staff_Phone_NumberMaskedTextBox"
        Me.Staff_Phone_NumberMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Staff_Phone_NumberMaskedTextBox.Size = New System.Drawing.Size(323, 23)
        Me.Staff_Phone_NumberMaskedTextBox.TabIndex = 15
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.Staff_Phone_NumberMaskedTextBox, "Input Staff Phone Number (10 Digits Required with no Dashes)")
        '
        'Staff_EmailTextBox
        '
        Me.Staff_EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Staff_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Email", True))
        Me.Staff_EmailTextBox.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_EmailTextBox.Location = New System.Drawing.Point(394, 367)
        Me.Staff_EmailTextBox.Name = "Staff_EmailTextBox"
        Me.Staff_EmailTextBox.Size = New System.Drawing.Size(323, 23)
        Me.Staff_EmailTextBox.TabIndex = 17
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.Staff_EmailTextBox, "Input Staff Email")
        '
        'User_TypeTextBox
        '
        Me.User_TypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.User_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "User Type", True))
        Me.User_TypeTextBox.Enabled = False
        Me.User_TypeTextBox.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_TypeTextBox.ForeColor = System.Drawing.Color.White
        Me.User_TypeTextBox.Location = New System.Drawing.Point(393, 12)
        Me.User_TypeTextBox.Name = "User_TypeTextBox"
        Me.User_TypeTextBox.ReadOnly = True
        Me.User_TypeTextBox.Size = New System.Drawing.Size(323, 23)
        Me.User_TypeTextBox.TabIndex = 1
        Me.User_TypeTextBox.TabStop = False
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.User_TypeTextBox, "Automatically filled up when selecting User Type")
        '
        'Employment_StatusTextBox
        '
        Me.Employment_StatusTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Employment_StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Employment Status", True))
        Me.Employment_StatusTextBox.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employment_StatusTextBox.ForeColor = System.Drawing.Color.White
        Me.Employment_StatusTextBox.Location = New System.Drawing.Point(395, 401)
        Me.Employment_StatusTextBox.Name = "Employment_StatusTextBox"
        Me.Employment_StatusTextBox.ReadOnly = True
        Me.Employment_StatusTextBox.Size = New System.Drawing.Size(322, 23)
        Me.Employment_StatusTextBox.TabIndex = 19
        Me.Employment_StatusTextBox.TabStop = False
        Me.Employment_StatusTextBox.Text = "Employed"
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.Employment_StatusTextBox, "Adding nnew staff automatically sets the status to Employed")
        '
        'Date_Of_EmploymentDateTimePicker
        '
        Me.Date_Of_EmploymentDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Date_Of_EmploymentDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "Date Of Employment", True))
        Me.Date_Of_EmploymentDateTimePicker.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Of_EmploymentDateTimePicker.Location = New System.Drawing.Point(394, 431)
        Me.Date_Of_EmploymentDateTimePicker.Name = "Date_Of_EmploymentDateTimePicker"
        Me.Date_Of_EmploymentDateTimePicker.Size = New System.Drawing.Size(323, 23)
        Me.Date_Of_EmploymentDateTimePicker.TabIndex = 21
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.Date_Of_EmploymentDateTimePicker, "Choose the date when staff is Employed")
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.White
        Me.PasswordTextBox.Location = New System.Drawing.Point(394, 465)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordTextBox.ReadOnly = True
        Me.PasswordTextBox.Size = New System.Drawing.Size(323, 23)
        Me.PasswordTextBox.TabIndex = 23
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.PasswordTextBox, "Automatically filled up when typing in IC Number")
        '
        'grpGender
        '
        Me.grpGender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpGender.Controls.Add(Me.radFemale)
        Me.grpGender.Controls.Add(Me.radMale)
        Me.grpGender.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGender.ForeColor = System.Drawing.Color.Maroon
        Me.grpGender.Location = New System.Drawing.Point(394, 255)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(322, 69)
        Me.grpGender.TabIndex = 13
        Me.grpGender.TabStop = False
        Me.grpGender.Text = "Select Staff Gender"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(57, 42)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(66, 19)
        Me.radFemale.TabIndex = 1
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "&Female"
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.radFemale, "Staff is a Female")
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(57, 19)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(53, 19)
        Me.radMale.TabIndex = 0
        Me.radMale.TabStop = True
        Me.radMale.Text = "&Male"
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.radMale, "Staff is a Male")
        Me.radMale.UseVisualStyleBackColor = True
        '
        'grpUserType
        '
        Me.grpUserType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grpUserType.Controls.Add(Me.radLibrarianStaff)
        Me.grpUserType.Controls.Add(Me.radAdministrator)
        Me.grpUserType.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUserType.ForeColor = System.Drawing.Color.Maroon
        Me.grpUserType.Location = New System.Drawing.Point(393, 38)
        Me.grpUserType.Name = "grpUserType"
        Me.grpUserType.Size = New System.Drawing.Size(325, 69)
        Me.grpUserType.TabIndex = 2
        Me.grpUserType.TabStop = False
        Me.grpUserType.Text = "Select User Type"
        '
        'radLibrarianStaff
        '
        Me.radLibrarianStaff.AutoSize = True
        Me.radLibrarianStaff.Location = New System.Drawing.Point(58, 42)
        Me.radLibrarianStaff.Name = "radLibrarianStaff"
        Me.radLibrarianStaff.Size = New System.Drawing.Size(110, 19)
        Me.radLibrarianStaff.TabIndex = 1
        Me.radLibrarianStaff.TabStop = True
        Me.radLibrarianStaff.Text = "Librarian &Staff"
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.radLibrarianStaff, "Librarian has no access to Staff Management")
        Me.radLibrarianStaff.UseVisualStyleBackColor = True
        '
        'radAdministrator
        '
        Me.radAdministrator.AutoSize = True
        Me.radAdministrator.Location = New System.Drawing.Point(58, 19)
        Me.radAdministrator.Name = "radAdministrator"
        Me.radAdministrator.Size = New System.Drawing.Size(104, 19)
        Me.radAdministrator.TabIndex = 0
        Me.radAdministrator.TabStop = True
        Me.radAdministrator.Text = "A&dministrator"
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.radAdministrator, "Administrator has access to Staff Management")
        Me.radAdministrator.UseVisualStyleBackColor = True
        '
        'btnReturnToStaffManagement
        '
        Me.btnReturnToStaffManagement.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReturnToStaffManagement.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnToStaffManagement.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReturnToStaffManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturnToStaffManagement.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnToStaffManagement.ForeColor = System.Drawing.Color.Black
        Me.btnReturnToStaffManagement.Location = New System.Drawing.Point(64, 500)
        Me.btnReturnToStaffManagement.Name = "btnReturnToStaffManagement"
        Me.btnReturnToStaffManagement.Size = New System.Drawing.Size(145, 43)
        Me.btnReturnToStaffManagement.TabIndex = 29
        Me.btnReturnToStaffManagement.Text = "R&eturn to Staff Management"
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.btnReturnToStaffManagement, "Return back to the Staff Management Menu")
        Me.btnReturnToStaffManagement.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(424, 500)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(92, 43)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "&Add"
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.btnAdd, "Add Staff Record")
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClearProfilePicture
        '
        Me.btnClearProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClearProfilePicture.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearProfilePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClearProfilePicture.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearProfilePicture.ForeColor = System.Drawing.Color.Black
        Me.btnClearProfilePicture.Location = New System.Drawing.Point(164, 206)
        Me.btnClearProfilePicture.Name = "btnClearProfilePicture"
        Me.btnClearProfilePicture.Size = New System.Drawing.Size(92, 43)
        Me.btnClearProfilePicture.TabIndex = 27
        Me.btnClearProfilePicture.Text = "&Clear Profile Picture"
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.btnClearProfilePicture, "Clears the current Profile Picture")
        Me.btnClearProfilePicture.UseVisualStyleBackColor = False
        '
        'btnAddProfilePicture
        '
        Me.btnAddProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddProfilePicture.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddProfilePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddProfilePicture.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProfilePicture.ForeColor = System.Drawing.Color.Black
        Me.btnAddProfilePicture.Location = New System.Drawing.Point(65, 206)
        Me.btnAddProfilePicture.Name = "btnAddProfilePicture"
        Me.btnAddProfilePicture.Size = New System.Drawing.Size(92, 43)
        Me.btnAddProfilePicture.TabIndex = 26
        Me.btnAddProfilePicture.Text = "Add Profile &Picture"
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.btnAddProfilePicture, "Add a Profile Picture for the Staff")
        Me.btnAddProfilePicture.UseVisualStyleBackColor = False
        '
        'FileDialogProfilePicture
        '
        Me.FileDialogProfilePicture.FileName = "OpenFileDialog1"
        '
        'Staff_AddressTextBox
        '
        Me.Staff_AddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Staff_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Staff Address", True))
        Me.Staff_AddressTextBox.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staff_AddressTextBox.Location = New System.Drawing.Point(393, 202)
        Me.Staff_AddressTextBox.Name = "Staff_AddressTextBox"
        Me.Staff_AddressTextBox.Size = New System.Drawing.Size(323, 23)
        Me.Staff_AddressTextBox.TabIndex = 10
        Me.ToolTipForAddStaffInformation.SetToolTip(Me.Staff_AddressTextBox, "Input Staff Address")
        '
        'Register_New_Staff
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnReturnToStaffManagement
        Me.ClientSize = New System.Drawing.Size(761, 556)
        Me.Controls.Add(Staff_AddressLabel)
        Me.Controls.Add(Me.Staff_AddressTextBox)
        Me.Controls.Add(Me.btnClearProfilePicture)
        Me.Controls.Add(Me.btnAddProfilePicture)
        Me.Controls.Add(Me.btnReturnToStaffManagement)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpUserType)
        Me.Controls.Add(Me.grpGender)
        Me.Controls.Add(Profile_PictureLabel)
        Me.Controls.Add(Me.Profile_PicturePictureBox)
        Me.Controls.Add(Staff_IDLabel)
        Me.Controls.Add(Me.Staff_IDMaskedTextBox)
        Me.Controls.Add(Staff_NameLabel)
        Me.Controls.Add(Me.Staff_NameTextBox)
        Me.Controls.Add(Staff_ICLabel)
        Me.Controls.Add(Me.Staff_ICMaskedTextBox)
        Me.Controls.Add(Staff_GenderLabel)
        Me.Controls.Add(Me.Staff_GenderTextBox)
        Me.Controls.Add(Staff_Phone_NumberLabel)
        Me.Controls.Add(Me.Staff_Phone_NumberMaskedTextBox)
        Me.Controls.Add(Staff_EmailLabel)
        Me.Controls.Add(Me.Staff_EmailTextBox)
        Me.Controls.Add(User_TypeLabel)
        Me.Controls.Add(Me.User_TypeTextBox)
        Me.Controls.Add(Employment_StatusLabel)
        Me.Controls.Add(Me.Employment_StatusTextBox)
        Me.Controls.Add(Date_Of_EmploymentLabel)
        Me.Controls.Add(Me.Date_Of_EmploymentDateTimePicker)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.StaffBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Register_New_Staff"
        Me.Text = "Register New Staff"
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffBindingNavigator.ResumeLayout(False)
        Me.StaffBindingNavigator.PerformLayout()
        CType(Me.Profile_PicturePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.grpUserType.ResumeLayout(False)
        Me.grpUserType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents grpUserType As GroupBox
    Friend WithEvents radLibrarianStaff As RadioButton
    Friend WithEvents radAdministrator As RadioButton
    Friend WithEvents btnReturnToStaffManagement As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClearProfilePicture As Button
    Friend WithEvents btnAddProfilePicture As Button
    Friend WithEvents FileDialogProfilePicture As OpenFileDialog
    Friend WithEvents Staff_AddressTextBox As TextBox
    Friend WithEvents ToolTipForAddStaffInformation As ToolTip
End Class
