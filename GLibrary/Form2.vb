Imports MySql.Data.MySqlClient

Public Class Form2
    Dim connection As New MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=recordingsection_library")

    Private Sub clsbtn_Click(sender As Object, e As EventArgs) Handles clsbtn.Click
        End
    End Sub

    Private Sub shwbtn_CheckedChanged(sender As Object, e As EventArgs) Handles shwbtn.CheckedChanged
        If shwbtn.Checked Then
            txtpass.UseSystemPasswordChar = True
        Else
            txtpass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub logbtn_Click(sender As Object, e As EventArgs) Handles logbtn.Click
        Dim command As New MySqlCommand("SELECT `Username`, `Password` FROM `login` WHERE `Username` = @username AND `Password` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtuser.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtpass.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username Or Password")

        Else



            Dim newForm As New Form1()
            newForm.Show()
            Me.Hide()

        End If

    End Sub
End Class