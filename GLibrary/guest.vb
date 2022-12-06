Imports MySql.Data.MySqlClient

Public Class Form11
    Dim sqlConn As New MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=recordingsection_library")
    Dim sqlCmd As New MySqlCommand

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        MainPage.Show()
    End Sub


    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        MsgBox("Successfully Deleted")

        Try
            delete("DELETE FROM guest WHERE GuestID = '" & guestID.Text & "'")
            guestID.Clear()
            Try
                reload("SELECT * FROM guest", DataGridView5)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Try
            create("INSERT INTO guest (GuestID,firstName,lastName,suffix,dateOfregistration,school,ContactNo,Address) VALUES('" & guestID.Text & "','" & first_name.Text & "','" & last_name.Text & "','" & suffix.Text & "','" & dor.Text & "','" & school.Text & "','" & cono.Text & "','" & address.Text & "')")
            Try
                reload("SELECT * FROM guest", DataGridView5)

                guestID.Clear()
                first_name.Clear()
                last_name.Clear()
                suffix.Clear()
                dor.Clear()
                school.Clear()
                cono.Clear()
                address.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        guestID.Text = DataGridView5.CurrentRow.Cells(0).Value
        first_name.Text = DataGridView5.CurrentRow.Cells(1).Value
        last_name.Text = DataGridView5.CurrentRow.Cells(2).Value
        suffix.Text = DataGridView5.CurrentRow.Cells(3).Value
        dor.Text = DataGridView5.CurrentRow.Cells(4).Value
        school.Text = DataGridView5.CurrentRow.Cells(5).Value
        cono.Text = DataGridView5.CurrentRow.Cells(6).Value
        address.Text = DataGridView5.CurrentRow.Cells(7).Value

    End Sub

    Private Sub ref_Click(sender As Object, e As EventArgs) Handles ref.Click
        reload("SELECT * FROM guest", DataGridView5)
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        Try
            updates("UPDATE guest SET firstName='" & first_name.Text & "',lastName='" & last_name.Text & "',suffix='" & suffix.Text & "',dateOfregistration='" & dor.Text & "',school='" & school.Text & "',ContactNo '" & cono.Text & "',Address = '" & address.Text & "' WHERE GuestID = '" & guestID.Text & "'")
            Try
                reload("SELECT * FROM guest", DataGridView5)

                first_name.Clear()
                last_name.Clear()
                suffix.Clear()
                dor.Clear()
                school.Clear()
                cono.Clear()
                address.Clear()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class