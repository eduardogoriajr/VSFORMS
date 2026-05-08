<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtStudent_id = New TextBox()
        txtFirst_name = New TextBox()
        txtLast_name = New TextBox()
        cmbCourse = New ComboBox()
        cmbYear = New ComboBox()
        rbMale = New RadioButton()
        rbFemale = New RadioButton()
        cbActive = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        dgvRecords = New DataGridView()
        CType(dgvRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtStudent_id
        ' 
        txtStudent_id.Location = New Point(150, 23)
        txtStudent_id.Name = "txtStudent_id"
        txtStudent_id.Size = New Size(150, 31)
        txtStudent_id.TabIndex = 0
        ' 
        ' txtFirst_name
        ' 
        txtFirst_name.Location = New Point(150, 60)
        txtFirst_name.Name = "txtFirst_name"
        txtFirst_name.Size = New Size(150, 31)
        txtFirst_name.TabIndex = 1
        txtFirst_name.Text = "First Name"
        ' 
        ' txtLast_name
        ' 
        txtLast_name.Location = New Point(306, 60)
        txtLast_name.Name = "txtLast_name"
        txtLast_name.Size = New Size(150, 31)
        txtLast_name.TabIndex = 2
        txtLast_name.Text = "Last Name"
        ' 
        ' cmbCourse
        ' 
        cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCourse.FormattingEnabled = True
        cmbCourse.Items.AddRange(New Object() {"BS IT", "BS CS", "BS MED", "BS RAD", "BS TOURISM"})
        cmbCourse.Location = New Point(151, 98)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(182, 33)
        cmbCourse.TabIndex = 3
        ' 
        ' cmbYear
        ' 
        cmbYear.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYear.FormattingEnabled = True
        cmbYear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        cmbYear.Location = New Point(339, 98)
        cmbYear.Name = "cmbYear"
        cmbYear.Size = New Size(117, 33)
        cmbYear.TabIndex = 4
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Location = New Point(150, 139)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(75, 29)
        rbMale.TabIndex = 5
        rbMale.TabStop = True
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Location = New Point(231, 139)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(93, 29)
        rbFemale.TabIndex = 6
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' cbActive
        ' 
        cbActive.AutoSize = True
        cbActive.Location = New Point(150, 174)
        cbActive.Name = "cbActive"
        cbActive.Size = New Size(104, 29)
        cbActive.TabIndex = 7
        cbActive.Text = "Is Active"
        cbActive.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 8
        Label1.Text = "Student ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 9
        Label2.Text = "Full Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 101)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 25)
        Label4.TabIndex = 11
        Label4.Text = "Course, Year Lvl"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 139)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 25)
        Label5.TabIndex = 12
        Label5.Text = "Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 25)
        Label3.TabIndex = 13
        Label3.Text = "Status"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(12, 223)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 51)
        btnSave.TabIndex = 14
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(130, 223)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(112, 51)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(248, 223)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 51)
        btnDelete.TabIndex = 16
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(366, 223)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 51)
        btnClear.TabIndex = 17
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvRecords
        ' 
        dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecords.Location = New Point(12, 295)
        dgvRecords.Name = "dgvRecords"
        dgvRecords.RowHeadersWidth = 62
        dgvRecords.Size = New Size(776, 267)
        dgvRecords.TabIndex = 18
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 574)
        Controls.Add(dgvRecords)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cbActive)
        Controls.Add(rbFemale)
        Controls.Add(rbMale)
        Controls.Add(cmbYear)
        Controls.Add(cmbCourse)
        Controls.Add(txtLast_name)
        Controls.Add(txtFirst_name)
        Controls.Add(txtStudent_id)
        Name = "Form1"
        Text = "Form1"
        CType(dgvRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtStudent_id As TextBox
    Friend WithEvents txtFirst_name As TextBox
    Friend WithEvents txtLast_name As TextBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents cbActive As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvRecords As DataGridView

End Class
