Public Class Form1
    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Try
            create("INSERT INTO recordings (Book_Name,Author,Category,Course,Total_of_Page) VALUES('" & textBox1.Text & "','" & textBox2.Text & "','" & textBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')")
            Try
                reload("SELECT * FROM recordings", dataGridView3)

                textBox1.Clear()
                textBox2.Clear()
                textBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            reload("SELECT * FROM recordings", dataGridView3)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView3.CellContentClick
        TextBox6.Text = dataGridView3.CurrentRow.Cells(0).Value
        textBox1.Text = dataGridView3.CurrentRow.Cells(1).Value
        TextBox2.Text = dataGridView3.CurrentRow.Cells(2).Value
        textBox3.Text = dataGridView3.CurrentRow.Cells(4).Value
        TextBox4.Text = dataGridView3.CurrentRow.Cells(5).Value
        TextBox5.Text = dataGridView3.CurrentRow.Cells(6).Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            delete("DELETE FROM recordings WHERE Book_ID = '" & TextBox6.Text & "'")
            TextBox6.Clear()
            Try
                reload("SELECT * FROM recordings", dataGridView3)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        reload("SELECT * FROM recordings", dataGridView3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            updates("UPDATE recordings SET Book_Name='" & textBox1.Text & "',Author='" & textBox2.Text & "',Category='" & textBox3.Text & "',Course='" & TextBox4.Text & "',Total_of_Page='" & TextBox5.Text & "' WHERE Book_ID = '" & TextBox6.Text & "'")
            Try
                reload("SELECT * FROM recordings", dataGridView3)

                textBox1.Clear()
                textBox2.Clear()
                textBox3.Clear()
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            reload("SELECT * FROM recordings WHERE (`Book_Name` LIKE '" & TextBox7.Text & "') OR (`Author` LIKE'" & TextBox7.Text & "') OR (`Category` LIKE'" & TextBox7.Text & "') ", dataGridView3)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub toolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles toolStripMenuItem5.Click
        Me.Close()
        Form2.Show()
    End Sub




    Private Sub menuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menuStrip2.ItemClicked

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        bookPanel.Show()
        Me.Hide()
    End Sub


End Class
