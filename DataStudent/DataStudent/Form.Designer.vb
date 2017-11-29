<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.StudentTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDataSet = New DataStudent.StudentDataSet()
        Me.StudentIDBox = New System.Windows.Forms.TextBox()
        Me.StudentNameBox = New System.Windows.Forms.TextBox()
        Me.MajorBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberBox = New System.Windows.Forms.TextBox()
        Me.AddressBox = New System.Windows.Forms.TextBox()
        Me.GenderBox = New System.Windows.Forms.TextBox()
        Me.MotherNameBox = New System.Windows.Forms.TextBox()
        Me.FatherNameBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.StudentTableTableAdapter = New DataStudent.StudentDataSetTableAdapters.StudentTableTableAdapter()
        Me.TableAdapterManager = New DataStudent.StudentDataSetTableAdapters.TableAdapterManager()
        Me.AddDataBtn = New System.Windows.Forms.Button()
        Me.EditDataBtn = New System.Windows.Forms.Button()
        Me.DeleteDataBtn = New System.Windows.Forms.Button()
        Me.DateOfBirthBox = New System.Windows.Forms.DateTimePicker()
        Me.EnrollDateBox = New System.Windows.Forms.DateTimePicker()
        CType(Me.StudentTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentTableDataGridView
        '
        Me.StudentTableDataGridView.AllowUserToAddRows = False
        Me.StudentTableDataGridView.AllowUserToDeleteRows = False
        Me.StudentTableDataGridView.AllowUserToResizeRows = False
        Me.StudentTableDataGridView.AutoGenerateColumns = False
        Me.StudentTableDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.StudentTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.StudentTableDataGridView.DataSource = Me.StudentTableBindingSource
        Me.StudentTableDataGridView.Location = New System.Drawing.Point(2, 199)
        Me.StudentTableDataGridView.Name = "StudentTableDataGridView"
        Me.StudentTableDataGridView.ReadOnly = True
        Me.StudentTableDataGridView.Size = New System.Drawing.Size(850, 220)
        Me.StudentTableDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StudentName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StudentName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DateOfBirth"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DateOfBirth"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Major"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Major"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "EnrollDate"
        Me.DataGridViewTextBoxColumn8.HeaderText = "EnrollDate"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FatherName"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FatherName"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MotherName"
        Me.DataGridViewTextBoxColumn10.HeaderText = "MotherName"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'StudentTableBindingSource
        '
        Me.StudentTableBindingSource.DataMember = "StudentTable"
        Me.StudentTableBindingSource.DataSource = Me.StudentDataSet
        '
        'StudentDataSet
        '
        Me.StudentDataSet.DataSetName = "StudentDataSet"
        Me.StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentIDBox
        '
        Me.StudentIDBox.Location = New System.Drawing.Point(98, 29)
        Me.StudentIDBox.Name = "StudentIDBox"
        Me.StudentIDBox.Size = New System.Drawing.Size(122, 20)
        Me.StudentIDBox.TabIndex = 2
        '
        'StudentNameBox
        '
        Me.StudentNameBox.Location = New System.Drawing.Point(98, 65)
        Me.StudentNameBox.Name = "StudentNameBox"
        Me.StudentNameBox.Size = New System.Drawing.Size(122, 20)
        Me.StudentNameBox.TabIndex = 3
        '
        'MajorBox
        '
        Me.MajorBox.Location = New System.Drawing.Point(98, 143)
        Me.MajorBox.Name = "MajorBox"
        Me.MajorBox.Size = New System.Drawing.Size(122, 20)
        Me.MajorBox.TabIndex = 5
        '
        'PhoneNumberBox
        '
        Me.PhoneNumberBox.Location = New System.Drawing.Point(342, 105)
        Me.PhoneNumberBox.Name = "PhoneNumberBox"
        Me.PhoneNumberBox.Size = New System.Drawing.Size(122, 20)
        Me.PhoneNumberBox.TabIndex = 8
        '
        'AddressBox
        '
        Me.AddressBox.Location = New System.Drawing.Point(342, 65)
        Me.AddressBox.Name = "AddressBox"
        Me.AddressBox.Size = New System.Drawing.Size(122, 20)
        Me.AddressBox.TabIndex = 7
        '
        'GenderBox
        '
        Me.GenderBox.Location = New System.Drawing.Point(342, 29)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(122, 20)
        Me.GenderBox.TabIndex = 6
        '
        'MotherNameBox
        '
        Me.MotherNameBox.Location = New System.Drawing.Point(563, 62)
        Me.MotherNameBox.Name = "MotherNameBox"
        Me.MotherNameBox.Size = New System.Drawing.Size(122, 20)
        Me.MotherNameBox.TabIndex = 11
        '
        'FatherNameBox
        '
        Me.FatherNameBox.Location = New System.Drawing.Point(563, 25)
        Me.FatherNameBox.Name = "FatherNameBox"
        Me.FatherNameBox.Size = New System.Drawing.Size(122, 20)
        Me.FatherNameBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Student ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Student Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Date of birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Major"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(259, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(259, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(259, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Phone Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(259, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Enroll Date "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(489, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Father Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(489, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Mother Name"
        '
        'StudentTableTableAdapter
        '
        Me.StudentTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentTableTableAdapter = Me.StudentTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = DataStudent.StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AddDataBtn
        '
        Me.AddDataBtn.Location = New System.Drawing.Point(730, 23)
        Me.AddDataBtn.Name = "AddDataBtn"
        Me.AddDataBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddDataBtn.TabIndex = 22
        Me.AddDataBtn.Text = "Add Data"
        Me.AddDataBtn.UseVisualStyleBackColor = True
        '
        'EditDataBtn
        '
        Me.EditDataBtn.Location = New System.Drawing.Point(730, 63)
        Me.EditDataBtn.Name = "EditDataBtn"
        Me.EditDataBtn.Size = New System.Drawing.Size(75, 23)
        Me.EditDataBtn.TabIndex = 23
        Me.EditDataBtn.Text = "Edit Data"
        Me.EditDataBtn.UseVisualStyleBackColor = True
        '
        'DeleteDataBtn
        '
        Me.DeleteDataBtn.ForeColor = System.Drawing.Color.Red
        Me.DeleteDataBtn.Location = New System.Drawing.Point(730, 103)
        Me.DeleteDataBtn.Name = "DeleteDataBtn"
        Me.DeleteDataBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteDataBtn.TabIndex = 24
        Me.DeleteDataBtn.Text = "Delete Data"
        Me.DeleteDataBtn.UseVisualStyleBackColor = True
        '
        'DateOfBirthBox
        '
        Me.DateOfBirthBox.Location = New System.Drawing.Point(98, 108)
        Me.DateOfBirthBox.Name = "DateOfBirthBox"
        Me.DateOfBirthBox.Size = New System.Drawing.Size(122, 20)
        Me.DateOfBirthBox.TabIndex = 25
        '
        'EnrollDateBox
        '
        Me.EnrollDateBox.Location = New System.Drawing.Point(342, 142)
        Me.EnrollDateBox.Name = "EnrollDateBox"
        Me.EnrollDateBox.Size = New System.Drawing.Size(122, 20)
        Me.EnrollDateBox.TabIndex = 26
        '
        'Form
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(852, 417)
        Me.Controls.Add(Me.EnrollDateBox)
        Me.Controls.Add(Me.DateOfBirthBox)
        Me.Controls.Add(Me.DeleteDataBtn)
        Me.Controls.Add(Me.EditDataBtn)
        Me.Controls.Add(Me.AddDataBtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MotherNameBox)
        Me.Controls.Add(Me.FatherNameBox)
        Me.Controls.Add(Me.PhoneNumberBox)
        Me.Controls.Add(Me.AddressBox)
        Me.Controls.Add(Me.GenderBox)
        Me.Controls.Add(Me.MajorBox)
        Me.Controls.Add(Me.StudentNameBox)
        Me.Controls.Add(Me.StudentIDBox)
        Me.Controls.Add(Me.StudentTableDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form"
        Me.Text = "Student Data "
        CType(Me.StudentTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentDataSet As StudentDataSet
    Friend WithEvents StudentTableBindingSource As BindingSource
    Friend WithEvents StudentTableTableAdapter As StudentDataSetTableAdapters.StudentTableTableAdapter
    Friend WithEvents TableAdapterManager As StudentDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDBox As TextBox
    Friend WithEvents StudentNameBox As TextBox
    Friend WithEvents MajorBox As TextBox
    Friend WithEvents PhoneNumberBox As TextBox
    Friend WithEvents AddressBox As TextBox
    Friend WithEvents GenderBox As TextBox
    Friend WithEvents MotherNameBox As TextBox
    Friend WithEvents FatherNameBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents AddDataBtn As Button
    Friend WithEvents EditDataBtn As Button
    Friend WithEvents DeleteDataBtn As Button
    Friend WithEvents DateOfBirthBox As DateTimePicker
    Friend WithEvents EnrollDateBox As DateTimePicker
End Class
