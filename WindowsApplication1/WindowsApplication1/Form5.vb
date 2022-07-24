Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("The timer will start immediately, do you want to continue?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Me.Hide()
            Form2.FormReset()
            Form2.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("The timer will start immediately, do you want to continue?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Me.Hide()
            Form8.FormReset()
            Form8.Show()
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class