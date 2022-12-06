Imports MySql.Data.MySqlClient

Public Class bookRecords

    Dim sqlConn As New MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=recordingsection_library")
    Dim sqlCmd As New MySqlCommand

    Private Sub bookRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            reload("SELECT * FROM book_records", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            create("INSERT INTO book_records (Serial,Category,Category_ID,Researcher_ID,Date_Borrowed,Date_Returned,Book_Name,Author) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "', '" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')")
            Try
                reload("SELECT * FROM book_records", DataGridView1)
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox7.Clear()
                TextBox8.Clear()
                TextBox9.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox7.Text = DataGridView1.CurrentRow.Cells(5).Value
        TextBox8.Text = DataGridView1.CurrentRow.Cells(6).Value
        TextBox9.Text = DataGridView1.CurrentRow.Cells(7).Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            delete("DELETE FROM book_records WHERE Serial = '" & TextBox1.Text & "'")
            TextBox1.Clear()
            Try
                reload("SELECT * FROM book_records", DataGridView1)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        bookPanel.Show()
        Me.Hide()
    End Sub



    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            updates("UPDATE book_records SET Category='" & TextBox2.Text & "',Category_ID='" & TextBox3.Text & "',Researcher_ID='" & TextBox4.Text & "',Date_Borrowed='" & TextBox5.Text & "',Date_Returned='" & TextBox7.Text & "',Book_Name='" & TextBox8.Text & "',Author='" & TextBox9.Text & "' WHERE Serial = '" & TextBox1.Text & "'")
            Try
                reload("SELECT * FROM book_records", DataGridView1)

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class