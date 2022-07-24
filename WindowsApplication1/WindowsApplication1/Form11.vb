Public Class Form11
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label3.Parent = Me
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to use the name " + (TxtUsername.Text) + "?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            TxtUsername.Clear()
        ElseIf result = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub TxtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsername.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim result As Integer = MessageBox.Show("Are you sure you want to use the name " + (TxtUsername.Text) + "?", "", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                TxtUsername.Clear()
            ElseIf result = DialogResult.Yes Then
                Me.Hide()
                Form1.Show()
            End If
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class