Public Class CS

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Saldo As Double
        Saldo = 10000
        Label2.Text = Saldo
        MsgBox(Saldo)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Hide()
    End Sub
End Class