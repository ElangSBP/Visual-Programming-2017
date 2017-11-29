Public Class Form
    Private Sub StudentTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.StudentTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDataSet)

    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet.StudentTable' table. You can move, or remove it, as needed.
        Me.StudentTableTableAdapter.Fill(Me.StudentDataSet.StudentTable)

    End Sub

    Private Sub AddDataBtn_Click(sender As Object, e As EventArgs) Handles AddDataBtn.Click
        Dim con As New OleDb.OleDbConnection
        Dim SqlString As String = "Insert Into [StudentTable] (StudentID,StudentName,DateOfBirth,Major,Gender,Address,PhoneNumber,EnrollDate,FatherName,MotherName) Values (StudentIDBox,StudentNameBox,DateOfBirthBox,MajorBox,GenderBox,AddressBox,PhoneNumberBox,EnrollDateBox,FatherNameBox,MotherNameBox)"
        con.ConnectionString = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source = C:\Users\elang\Documents\Student.accdb"

        Using conn As New OleDb.OleDbConnection(con.ConnectionString)

            Using cmd As New OleDb.OleDbCommand(SqlString, con)

                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("column", StudentIDBox.Text)
                cmd.Parameters.AddWithValue("column", StudentNameBox.Text)
                cmd.Parameters.AddWithValue("column", DateOfBirthBox.Text)
                cmd.Parameters.AddWithValue("column", MajorBox.Text)
                cmd.Parameters.AddWithValue("column", GenderBox.Text)
                cmd.Parameters.AddWithValue("column", AddressBox.Text)
                cmd.Parameters.AddWithValue("column", PhoneNumberBox.Text)
                cmd.Parameters.AddWithValue("column", EnrollDateBox.Text)
                cmd.Parameters.AddWithValue("column", FatherNameBox.Text)
                cmd.Parameters.AddWithValue("column", MotherNameBox.Text)

                con.Open()
                cmd.ExecuteNonQuery()
                StudentTableDataGridView.DataSource = StudentDataSet.Tables(0)
                con.Close()

            End Using
        End Using
    End Sub

    Private Sub EditDataBtn_Click(sender As Object, e As EventArgs) Handles EditDataBtn.Click
        Dim con As New OleDb.OleDbConnection
        Dim SqlString As String = "UPDATE [StudentTable] (StudentID,StudentName,DateOfBirth,Major,Gender,Address,PhoneNumber,EnrollDate,FatherName,MotherName) SET StudentID ='" & StudentIDBox.Text & "',StudentName='" & StudentNameBox.Text & "',"
        con.ConnectionString = "PROVIDER = Microsoft.Ace.OLEDB.12.0; Data Source = C:\Users\elang\Documents\Student.accdb"

        Using conn As New OleDb.OleDbConnection(con.ConnectionString)

            Using cmd As New OleDb.OleDbCommand(SqlString, con)

                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("column", StudentIDBox.Text)
                cmd.Parameters.AddWithValue("column", StudentNameBox.Text)
                cmd.Parameters.AddWithValue("column", DateOfBirthBox.Text)
                cmd.Parameters.AddWithValue("column", MajorBox.Text)
                cmd.Parameters.AddWithValue("column", GenderBox.Text)
                cmd.Parameters.AddWithValue("column", AddressBox.Text)
                cmd.Parameters.AddWithValue("column", PhoneNumberBox.Text)
                cmd.Parameters.AddWithValue("column", EnrollDateBox.Text)
                cmd.Parameters.AddWithValue("column", FatherNameBox.Text)
                cmd.Parameters.AddWithValue("column", MotherNameBox.Text)

                con.Open()
                cmd.ExecuteNonQuery()
                StudentTableDataGridView.DataSource = StudentDataSet.Tables(0)
                con.Close()

            End Using
        End Using
    End Sub

    Private Sub DeleteDataBtn_Click(sender As Object, e As EventArgs) Handles DeleteDataBtn.Click

    End Sub
End Class
