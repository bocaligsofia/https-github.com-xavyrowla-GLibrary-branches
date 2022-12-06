Imports MySql.Data.MySqlClient
Imports System.DateTime
Public Class Form12
    Dim sqlConn As New MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=recordingsection_library")
    Dim sqlCmd As New MySqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        MainPage.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles add.Click
        MsgBox("Student" + last_name.Text + "is officially registered")

        Try
            create("INSERT INTO student (StudentID,firstName,lastName,suffix,dateOfregistration,department,course,year) VALUES('" & studID.Text & "','" & first_name.Text & "','" & last_name.Text & "','" & suffix.Text & "','" & dor.Text & "','" & dprt.Text & "','" & course.Text & "','" & year.Text & "')")
            Try
                reload("SELECT * FROM student", DataGridView7)

                studID.Clear()
                first_name.Clear()
                last_name.Clear()
                suffix.Clear()
                dor.Clear()
                dprt.Clear()
                course.Clear()
                year.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub studID_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles studID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            first_name.Focus()
        End If
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        MsgBox("Successfully Deleted")

        Try
            delete("DELETE FROM student WHERE StudentID = '" & studID.Text & "'")
            studID.Clear()
            Try
                reload("SELECT * FROM student", DataGridView7)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub first_name_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles first_name.KeyPress
        If Asc(e.KeyChar) = 13 Then
            last_name.Focus()
        End If
    End Sub
    Private Sub suffix_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles suffix.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dor.Focus()
        End If
    End Sub
    Private Sub last_name_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles last_name.KeyPress
        If Asc(e.KeyChar) = 13 Then
            suffix.Focus()
        End If
    End Sub
    Private Sub dor_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dprt.Focus()
        End If
    End Sub
    Private Sub dprt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dprt.KeyPress
        If Asc(e.KeyChar) = 13 Then
            course.Focus()
        End If
    End Sub
    Private Sub course_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles course.KeyPress
        If Asc(e.KeyChar) = 13 Then
            year.Focus()
        End If
    End Sub

    Private Sub DataGridView7_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick
        studID.Text = DataGridView7.CurrentRow.Cells(0).Value
        first_name.Text = DataGridView7.CurrentRow.Cells(1).Value
        last_name.Text = DataGridView7.CurrentRow.Cells(2).Value
        suffix.Text = DataGridView7.CurrentRow.Cells(3).Value
        dor.Text = DataGridView7.CurrentRow.Cells(4).Value

        dprt.Text = DataGridView7.CurrentRow.Cells(5).Value
        course.Text = DataGridView7.CurrentRow.Cells(6).Value
        year.Text = DataGridView7.CurrentRow.Cells(7).Value

    End Sub

    Private Sub ref_Click(sender As Object, e As EventArgs) Handles ref.Click
        reload("SELECT * FROM student", DataGridView7)
    End Sub


    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        Try
            updates("UPDATE student SET firstName='" & first_name.Text & "',lastName='" & last_name.Text & "',suffix='" & suffix.Text & "',dateOfregistration='" & dor.Text & "',department='" & dprt.Text & "',course='" & course.Text & "',year= '" & year.Text & "',WHERE StudentID= '" & studID.Text & "'")
            Try
                reload("SELECT * FROM student", DataGridView7)


                first_name.Clear()
                last_name.Clear()
                suffix.Clear()
                dor.Clear()
                dprt.Clear()
                course.Clear()
                year.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class