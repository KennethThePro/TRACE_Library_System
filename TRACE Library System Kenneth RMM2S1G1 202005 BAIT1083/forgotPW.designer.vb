<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotPW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgotPW))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmitCode = New System.Windows.Forms.Button()
        Me.txtPWConfirmationCode = New System.Windows.Forms.TextBox()
        Me.lblResendCode = New System.Windows.Forms.Label()
        Me.btnCancelCode = New System.Windows.Forms.Button()
        Me.LoginRecordTableAdapter1 = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter()
        Me.TracE_Library_SystemDataSet1 = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
        Me.tipForgotPW = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.TracE_Library_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A confirmation code has already been sent to your linked email. Please submit the" &
    " code below. "
        '
        'btnSubmitCode
        '
        Me.btnSubmitCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSubmitCode.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitCode.ForeColor = System.Drawing.Color.Black
        Me.btnSubmitCode.Location = New System.Drawing.Point(231, 62)
        Me.btnSubmitCode.Name = "btnSubmitCode"
        Me.btnSubmitCode.Size = New System.Drawing.Size(101, 25)
        Me.btnSubmitCode.TabIndex = 2
        Me.btnSubmitCode.Text = "&Submit Code"
        Me.btnSubmitCode.UseVisualStyleBackColor = False
        '
        'txtPWConfirmationCode
        '
        Me.txtPWConfirmationCode.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPWConfirmationCode.Location = New System.Drawing.Point(24, 63)
        Me.txtPWConfirmationCode.Name = "txtPWConfirmationCode"
        Me.txtPWConfirmationCode.Size = New System.Drawing.Size(201, 23)
        Me.txtPWConfirmationCode.TabIndex = 0
        Me.tipForgotPW.SetToolTip(Me.txtPWConfirmationCode, "Enter 5 digit code sent to your email")
        '
        'lblResendCode
        '
        Me.lblResendCode.AutoSize = True
        Me.lblResendCode.BackColor = System.Drawing.Color.Transparent
        Me.lblResendCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResendCode.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResendCode.ForeColor = System.Drawing.Color.Red
        Me.lblResendCode.Location = New System.Drawing.Point(25, 90)
        Me.lblResendCode.Name = "lblResendCode"
        Me.lblResendCode.Size = New System.Drawing.Size(167, 16)
        Me.lblResendCode.TabIndex = 1
        Me.lblResendCode.Text = "Click here to resend code"
        Me.lblResendCode.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnCancelCode
        '
        Me.btnCancelCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelCode.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelCode.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelCode.ForeColor = System.Drawing.Color.Black
        Me.btnCancelCode.Location = New System.Drawing.Point(231, 89)
        Me.btnCancelCode.Name = "btnCancelCode"
        Me.btnCancelCode.Size = New System.Drawing.Size(101, 23)
        Me.btnCancelCode.TabIndex = 3
        Me.btnCancelCode.Text = "&Cancel"
        Me.btnCancelCode.UseVisualStyleBackColor = False
        '
        'LoginRecordTableAdapter1
        '
        Me.LoginRecordTableAdapter1.ClearBeforeFill = True
        '
        'TracE_Library_SystemDataSet1
        '
        Me.TracE_Library_SystemDataSet1.DataSetName = "TRACE_Library_SystemDataSet"
        Me.TracE_Library_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'forgotPW
        '
        Me.AcceptButton = Me.btnSubmitCode
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnCancelCode
        Me.ClientSize = New System.Drawing.Size(369, 127)
        Me.Controls.Add(Me.btnCancelCode)
        Me.Controls.Add(Me.lblResendCode)
        Me.Controls.Add(Me.btnSubmitCode)
        Me.Controls.Add(Me.txtPWConfirmationCode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "forgotPW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Forgot Password"
        CType(Me.TracE_Library_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmitCode As Button
    Friend WithEvents txtPWConfirmationCode As TextBox
    Friend WithEvents lblResendCode As Label
    Friend WithEvents btnCancelCode As Button
    Friend WithEvents LoginRecordTableAdapter1 As TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter
    Friend WithEvents TracE_Library_SystemDataSet1 As TRACE_Library_SystemDataSet
    Friend WithEvents tipForgotPW As ToolTip
End Class
