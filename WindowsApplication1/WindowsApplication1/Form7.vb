Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("The timer will start immediately, do you want to continue?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Me.Hide()
            Form4.FormReset()
            Form4.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Integer = MessageBox.Show("The timer will start immediately, do you want to continue?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Me.Hide()
            Form10.FormReset()
            Form10.Show()
        End If
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class