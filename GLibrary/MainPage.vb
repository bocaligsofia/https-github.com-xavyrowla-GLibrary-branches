Public Class MainPage
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, e As EventArgs) Handles student.Click
        Form12.Show()
        Me.Hide()
    End Sub
    Private Sub guest_Click(ByVal sender As Object, e As EventArgs) Handles guest.Click
        Form11.Show()
        Me.Hide()

    End Sub
    Private Sub close_Click(ByVal sender As Object, e As EventArgs) Handles button1.Click
        Me.Close()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        bookPanel.Show()
    End Sub
End Class
