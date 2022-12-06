Public Class MainPage
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) Handles student.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub guest_Click(ByVal sender As Object, e As EventArgs) Handles guest.Click
        Form2.Show()
        Me.Hide()

    End Sub
    Private Sub close_Click(ByVal sender As Object, e As EventArgs) Handles button1.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
