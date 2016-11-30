Public Class Form3

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NIP, Comp, nue As Single
        Comp = 1234
        TextBox1.Text = Comp
        TextBox2.Text = nue
        If Comp = NIP Then
            nue = NIP
            nue = Comp
        Else
            MsgBox("NIP incorrecto")



        End If

    End Sub

End Class