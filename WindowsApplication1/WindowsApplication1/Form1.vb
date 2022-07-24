Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label2.Parent = Me
        Label1.Text = "Welcome " + Form11.TxtUsername.Text + "!"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As Integer = MessageBox.Show("Would you like to view the tutorial?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Me.Hide()
            Form18.FormReset()
            Form18.Show()
        End If
    End Sub
End Class
