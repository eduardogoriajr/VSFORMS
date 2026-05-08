Imports MySql.Data.MySqlClient

Public Class Form1
    Dim students As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadTable()
        dgvRecords.Columns(0).Width = 50
        dgvRecords.Columns(1).Width = 100
        dgvRecords.Columns(2).Width = 100
        dgvRecords.Columns(3).Width = 100
        dgvRecords.Columns(4).Width = 100
        dgvRecords.Columns(5).Width = 100
        dgvRecords.Columns(6).Width = 100
        dgvRecords.Columns(7).Width = 100
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Opencon()
        Try
            cmd.CommandText = "INSERT INTO students(student_id, first_name, last_name, course, year_level, gender, status) " &
                              "VALUES ('" & txtStudent_id.Text & "', '" & txtFirst_name.Text & "', '" & txtLast_name.Text & "', '" &
                              cmbCourse.Text & "', '" & cmbYear.Text & "', '" &
                              If(rbMale.Checked, "Male", "Female") & "', '" & If(cbActive.Checked, 1, 0) & "')"
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("STUDENT SAVED")
            Call clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
        Call loadTable()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        con.Open()
        Try
            cmd.CommandText = "UPDATE students SET first_name='" & txtFirst_name.Text & "', last_name='" & txtLast_name.Text &
                              "', course='" & cmbCourse.Text & "', year_level='" & cmbYear.Text &
                              "', gender='" & If(rbMale.Checked, "Male", "Female") &
                              "', status='" & If(cbActive.Checked, 1, 0) &
                              "' WHERE student_id='" & txtStudent_id.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Successfully updated record")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
        Call loadTable()
        Call clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        con.Open()
        Try
            Dim answer As DialogResult
            answer = MessageBox.Show("Are you sure you want to delete this student?", "DELETE",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = DialogResult.Yes Then
                cmd.CommandText = "DELETE FROM students WHERE student_id='" & txtStudent_id.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("RECORD DELETED")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
        Call loadTable()
        Call clear()
    End Sub

    Sub clear()
        txtStudent_id.Clear()
        txtFirst_name.Clear()
        txtLast_name.Clear()
        cmbCourse.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        rbMale.Checked = False
        rbFemale.Checked = False
        cbActive.Checked = False
        btnSave.Enabled = True
    End Sub

    Sub loadTable()
        con.Open()
        cmd.Connection = con
        Try
            cmd.CommandText = "SELECT id, student_id, first_name, last_name, course, year_level, gender, " &
                              "CASE WHEN status = 1 THEN 'Active' ELSE 'Inactive' END AS status_text " &
                              "FROM students"
            adapter.SelectCommand = cmd
            students.Clear()
            adapter.Fill(students)
            dgvRecords.DataSource = students
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub dgvRecords_DoubleClick(sender As Object, e As EventArgs) Handles dgvRecords.DoubleClick
        txtStudent_id.Text = dgvRecords.Item("student_id", dgvRecords.CurrentRow.Index).Value
        txtFirst_name.Text = dgvRecords.Item("first_name", dgvRecords.CurrentRow.Index).Value
        txtLast_name.Text = dgvRecords.Item("last_name", dgvRecords.CurrentRow.Index).Value
        cmbCourse.Text = dgvRecords.Item("course", dgvRecords.CurrentRow.Index).Value
        cmbYear.Text = dgvRecords.Item("year_level", dgvRecords.CurrentRow.Index).Value
        Dim g As String = dgvRecords.Item("gender", dgvRecords.CurrentRow.Index).Value
        rbMale.Checked = (g = "Male")
        rbFemale.Checked = (g = "Female")
        Dim s As String = dgvRecords.Item("status_text", dgvRecords.CurrentRow.Index).Value
        cbActive.Checked = (s = "Active")
        btnSave.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call clear()
    End Sub
End Class