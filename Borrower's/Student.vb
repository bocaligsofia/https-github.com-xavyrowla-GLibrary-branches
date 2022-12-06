Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ref.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles record.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        MainPage.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Add.Click
        MsgBox("Student" + last_name.Text + "is officially registered")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Edit.Click

    End Sub

    Private Sub studID_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles studID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            first_name.Focus()
        End If
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        MsgBox("Successfully Deleted")
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
End Class