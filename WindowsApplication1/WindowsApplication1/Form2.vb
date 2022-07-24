Public Class Form2
    Dim X As Integer
    Dim Y As Integer
    Dim correctcount As Integer = 0
    Dim incorrectcount As Integer = 0
    Dim timercount As Integer = 120
    Dim problemtimercount As Integer = 15
    Dim problemcount As Integer = 0
    Public playerscorecountEA As Integer = 0

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label1.Parent = Me
        Me.Label2.Parent = Me
        Me.Label5.Parent = Me
        Me.Label4.Parent = Me
        Me.Label3.Parent = Me
        FormReset()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Check" Then
            If Val(TextBox1.Text) > 0 Then
                If Val(TextBox1.Text) = Int(X + Y) Then
                    Correct()
                Else
                    Incorrect()
                End If
            Else

            End If
        ElseIf Button2.Text = "Next" Then
            ProblemReset()
        ElseIf Button2.Text = "Finish" Then
            Me.Hide()
            Form12.Show()
            Label3.Text = ""
            Form12.LoadCurrentHighScore()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Button2.Text = "Check" Then
                If Val(TextBox1.Text) > 0 Then
                    If Val(TextBox1.Text) = Int(X + Y) Then
                        Correct()
                    Else
                        Incorrect()
                    End If
                Else

                End If
            ElseIf Button2.Text = "Next" Then
                ProblemReset()
            ElseIf Button2.Text = "Finish" Then
                Me.Hide()
                Form12.Show()
                Label3.Text = ""
                Form12.LoadCurrentHighScore()
            End If

        Else
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = timercount.ToString
        If timercount = 0 Then
            Label3.Text = ""
            Label3.ForeColor = Color.Black
            Label1.Text = ""
            Timer1.Enabled = False
            Timer2.Enabled = False
            Label4.Text = "Time Up"
            timercount = 120
            Button2.Text = "Finish"
            TextBox1.Enabled = False
            playerscorecountEA = correctcount - incorrectcount
            If (correctcount / problemcount) >= 0.85 Then
                Dim result As Integer = MessageBox.Show("Congratulations " + Form11.TxtUsername.Text + "! You just achieved a score higher than 85%! Would you like to print a certificate? (Please do not press finish until you have printed or saved your certificate, otherwise you will lose access to it).", "", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then

                ElseIf result = DialogResult.Yes Then
                    My.Computer.FileSystem.CopyFile("Certificatetemp.docx", "Certificate.docx", Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                    IO.File.SetAttributes("Certificate.docx", IO.FileAttributes.Normal)
                    System.Diagnostics.Process.Start("Certificate.docx")
                End If
            Else
                Dim result As Integer = MessageBox.Show("Unfortunately you didn't get 85%, don't worry! Keep on practicing and eventually you will reach your goals!", "", MessageBoxButtons.OK)
                If result = DialogResult.OK Then

                End If
            End If
        Else
            timercount -= 1
        End If
        If timercount <= 10 Then
            Label3.ForeColor = Color.Red
        ElseIf timercount <= 30 Then
            Label3.ForeColor = Color.Orange
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If problemtimercount = 0 Then
            Incorrect()
        Else
            problemtimercount -= 1
        End If
    End Sub
    Sub problemtimerreset()
        problemtimercount = 15
        Timer2.Enabled = True
    End Sub
    Sub infinitetimer()
        problemtimercount = 1000000
        Timer2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        timercount = 0
    End Sub
    Sub Correct()
        problemcount = problemcount + 1
        correctcount = correctcount + 1
        Label2.Text = correctcount
        Label1.Text = X & " + " & Y & " = " & Int(X + Y)
        TextBox1.Enabled = False
        infinitetimer()
        Button2.Text = "Next"
    End Sub
    Sub Incorrect()
        problemcount = problemcount + 1
        incorrectcount = incorrectcount + 1
        Label5.Text = incorrectcount
        Label1.Text = X & " + " & Y & " = " & Int(X + Y)
        TextBox1.Enabled = False
        infinitetimer()
        Button2.Text = "Next"
    End Sub
    Sub ProblemReset()
        TextBox1.Clear()
        TextBox1.Enabled = True
        TextBox1.Select()
        Randomize()
        X = Int(Rnd() * 5 + 1)
        Y = Int(Rnd() * 5 + 1)
        Label1.Text = X & " + " & Y & " ="
        problemtimerreset()
        Button2.Text = "Check"
    End Sub
    Public Sub FormReset()
        Label4.Show()
        problemcount = 0
        correctcount = 0
        incorrectcount = 0
        Button2.Enabled = True
        TextBox1.Clear()
        TextBox1.Enabled = True
        TextBox1.Select()
        Label2.Text = "0"
        Label5.Text = "0"
        Randomize()
        X = Int(Rnd() * 5 + 1)
        Y = Int(Rnd() * 5 + 1)
        Label1.Text = X & " + " & Y & " ="
        problemtimerreset()
        timercount = 120
        Timer1.Enabled = True
        Label4.Text = "Time Left"
        Button2.Text = "Check"
        Label3.ForeColor = Color.Black
        Label3.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        timercount = 30
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If timercount <= 10 Then
            Timer3.Interval = 250
            If timercount >= 0 Then
                Label3.Visible = True
                Timer3.Enabled = False
                Timer4.Enabled = True
            End If
        ElseIf timercount <= 30 Then
            Timer3.Interval = 500
            If timercount > 10 Then
                Label3.Visible = True
                Timer3.Enabled = False
                Timer4.Enabled = True
            End If
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If timercount <= 10 Then
            Timer4.Interval = 250
            If timercount > 0 Then
                Label3.Visible = False
                Timer3.Enabled = True
                Timer4.Enabled = False
            End If
        ElseIf timercount <= 30 Then
            Timer4.Interval = 500
            If timercount > 10 Then
                Label3.Visible = False
                Timer3.Enabled = True
                Timer4.Enabled = False
            End If
        End If
    End Sub
End Class