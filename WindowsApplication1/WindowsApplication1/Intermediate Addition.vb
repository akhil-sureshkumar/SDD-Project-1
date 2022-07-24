Public Class Form3
    Dim X As Integer
    Dim Y As Integer
    Dim Count As Integer


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Label2.Text = ""
        Randomize()
        X = Int(Rnd() * 20 + 1)
        Y = Int(Rnd() * 20 + 1)
        Label1.Text = X & " + " & Y & " ="
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = True
        Count = 1 + Count
        If Count <= 9 Then
            TextBox1.Clear()
            TextBox1.Enabled = True
            Label2.Text = ""
            Randomize()
            X = Int(Rnd() * 20 + 1)
            Y = Int(Rnd() * 20 + 1)
            Label1.Text = X & " + " & Y & " ="
        Else
            Me.Hide()
            Form1.Show()
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(TextBox1.Text) = Int(X + Y) Then
            Label2.Text = "Correct"
            TextBox1.Enabled = False
            Button1.Enabled = True
            Button2.Enabled = False
        End If
    End Sub
End Class