Public Class Form1
    Dim ZeroChar As String = String.Empty
    Dim ZeroLength As Integer
    Dim astring As String
    Dim bstring As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sourceAccountNumber As New FinnishBankAccountNumber(TextBox1.Text)
        Response.Write(sourceAccountNumber.getLongFormat())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label3.Text = ""
        TextBox1.Focus()
    End Sub
End Class
