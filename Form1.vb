Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NIP As Single
        If TextBox1.Text = 1234 Then
            Form2.Show()
            Me.Hide()

        ElseIf TextBox1.Text = NIP Then
        ElseIf TextBox2.Text = 270791 Then
        Else
            MsgBox("Intente de nuevo")


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
