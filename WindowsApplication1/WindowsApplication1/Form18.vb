Public Class Form18
    Dim nextcount As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If nextcount < 4 Then
            nextcount = nextcount + 1
            If nextcount = 1 Then
                Button1.Hide()
                Button2.Hide()
                Button3.Hide()
                PictureBox1.Hide()
                PictureBox2.Hide()
                Label8.Show()
                Label3.Text = ""
                Label8.Text = "Would you like to do addition or multiplication?"
                Label1.Text = "One you have chosen your desired mode, you will be asked whether you want to do addition or multiplication. However, once you choose between Addition or Multiplication, the timer will start immediately."
                Button6.Show()
                Button7.Show()
                Button5.Enabled = True
            ElseIf nextcount = 2 Then
                Label8.Hide()
                Button6.Hide()
                Button7.Hide()
                Label1.Font = New Font(Label1.Font.FontFamily, 8, FontStyle.Regular)
                Label1.Text = "You will then be given a time based on the mode to solve as many problems as you can. The time you have left will appear next to the TextBox.  There is a tally being kept of how many questions you get correct and incorrect. When you press the check button, it will check whether your answer is correct or incorrect and display the correct answer, whilst adding your score to the tally. The next button will be enabled, allowing you to progress to the next question whenever you are ready. There is no limit to how many questions you can answer however, there is a time limit per question based on the mode. If you don't answer a question within this limit, it is counted as incorrect."
                Button8.Show()
                TextBox1.Show()
                Label6.Show()
                Label4.Show()
                Label5.Show()
                Label2.Show()
                PictureBox1.Show()
                PictureBox2.Show()
                Label3.Text = "4 + 3"
            ElseIf nextcount = 3 Then
                Button8.Hide()
                TextBox1.Hide()
                Label6.Hide()
                Label4.Hide()
                Label5.Hide()
                Label2.Hide()
                PictureBox1.Hide()
                PictureBox2.Hide()
                Label3.Text = ""
                Label1.Font = New Font(Label1.Font.FontFamily, 12, FontStyle.Regular)
                Label1.Text = "If you get above 85% correct, you will be asked if you want to print a certificate. If you select yes, a word document will open with a certificate in which you type your own name in. If you don't have a printer, you can feel free to save the document whereever you like (Save using Save As in a folder of your choice otherwise your certificate will dissappear). If you do have a printer, you should be able to print from the word document itself."
                Label7.Text = "Congratulations " + Form11.TxtUsername.Text + "! You just achieved a score higher than 85%! Would you like to print a certificate?"
                Label7.Show()
                Button10.Show()
                Button11.Show()
            ElseIf nextcount = 4 Then
                Label7.Hide()
                Button10.Hide()
                Button11.Hide()
                Label3.Text = "Leaderboards"
                Label1.Font = New Font(Label1.Font.FontFamily, 12, FontStyle.Regular)
                Label1.Text = "Once you press the finish button, you will be taken to the leaderboards which will display the top 3 scores. These scores are calculated by the amount of questions answered correctly subtracted by the amount of questions answered incorrectly. If you beat any of these scores, it will update to fit your own. If you want to play again or play another mode, there is a button which can be pressed to do so."
                Button12.Show()
                Label11.Show()
                Label10.Show()
                Label9.Show()
                Player1st.Show()
                Player2nd.Show()
                Player3rd.Show()
                PlayerHighscore1st.Show()
                PlayerHighscore2nd.Show()
                PlayerHighscore3rd.Show()
                Button4.Text = "Finish tutorial"
            End If
        ElseIf nextcount = 4 Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button6.Hide()
        Button7.Hide()
        Button8.Hide()
        TextBox1.Hide()
        Label6.Hide()
        Label4.Hide()
        Label5.Hide()
        Label2.Hide()
        Label3.Text = "Select a Mode!"
        Label7.Hide()
        Label8.Hide()
        Button10.Hide()
        Button11.Hide()
        Button12.Hide()
        Label11.Hide()
        Label10.Hide()
        Label9.Hide()
        Player1st.Hide()
        Player2nd.Hide()
        Player3rd.Hide()
        PlayerHighscore1st.Hide()
        PlayerHighscore2nd.Hide()
        PlayerHighscore3rd.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        Button5.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
    Public Sub FormReset()
        Button6.Hide()
        Button7.Hide()
        Button8.Hide()
        TextBox1.Hide()
        Label6.Hide()
        Label4.Hide()
        Label5.Hide()
        Label2.Hide()
        Label3.Text = "Select a Mode!"
        Label7.Hide()
        Label8.Hide()
        Button10.Hide()
        Button11.Hide()
        Button12.Hide()
        Label11.Hide()
        Label10.Hide()
        Label9.Hide()
        Player1st.Hide()
        Player2nd.Hide()
        Player3rd.Hide()
        PlayerHighscore1st.Hide()
        PlayerHighscore2nd.Hide()
        PlayerHighscore3rd.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Label1.Font = New Font(Label1.Font.FontFamily, 16, FontStyle.Regular)
        Label1.Text = "In the main menu, you will be asked to select a mode. Beginner Mode deals with the numbers 1 to 5. Intermediate Mode deals with the numbers 1 to 20. Expert Mode deals with the numbers 1 to 30."
        Button4.Text = "Next"
        nextcount = 0
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If nextcount > 0 Then
            nextcount = nextcount - 1
            If nextcount = 0 Then
                Button6.Hide()
                Button7.Hide()
                Button8.Hide()
                TextBox1.Hide()
                Label6.Hide()
                Label4.Hide()
                Label5.Hide()
                Label2.Hide()
                Label3.Text = "Select a Mode!"
                Label7.Hide()
                Label8.Hide()
                Button10.Hide()
                Button11.Hide()
                Button12.Hide()
                Label11.Hide()
                Label10.Hide()
                Label9.Hide()
                Player1st.Hide()
                Player2nd.Hide()
                Player3rd.Hide()
                PlayerHighscore1st.Hide()
                PlayerHighscore2nd.Hide()
                PlayerHighscore3rd.Hide()
                Button1.Show()
                Button2.Show()
                Button3.Show()
                Label1.Font = New Font(Label1.Font.FontFamily, 16, FontStyle.Regular)
                Label1.Text = "In the main menu, you will be asked to select a mode. Beginner Mode involves the numbers 1 to 5. Intermediate Mode involves the numbers 1 to 20. Expert Mode involves the numbers 1 to 30."
                Button4.Text = "Next"
                Button5.Enabled = False
            ElseIf nextcount = 1 Then
                Label1.Font = New Font(Label1.Font.FontFamily, 16, FontStyle.Regular)
                Button1.Hide()
                Button2.Hide()
                Button3.Hide()
                PictureBox1.Hide()
                PictureBox2.Hide()
                Label8.Show()
                Label3.Text = ""
                Label8.Text = "Would you like to do addition or multiplication?"
                Label1.Text = "Once you have chosen your desired mode, you will be asked whether you want to do addition or multiplication. However, once you choose between Addition or Multiplication, the timer will start immediately."
                Button6.Show()
                Button7.Show()
                Button8.Hide()
                TextBox1.Hide()
                Label6.Hide()
                Label4.Hide()
                Label5.Hide()
                Label2.Hide()
                Label3.Text = ""
                Button5.Enabled = True
            ElseIf nextcount = 2 Then
                Label8.Hide()
                Button6.Hide()
                Button7.Hide()
                Label1.Font = New Font(Label1.Font.FontFamily, 8, FontStyle.Regular)
                Label1.Text = "You will then be given a time of 60 seconds to solve as many problems as you can. The time you have left will appear next to the TextBox.  There is a tally being kept of how many questions you get correct and incorrect. When you press the check button, it will check whether your answer is correct or incorrect and display the correct answer, whilst adding your score to the tally. The next button will be enabled, allowing you to progress to the next question whenever you are ready. There is no limit to how many questions you can answer however, there is a limit of 10 seconds per question. If you don't answer a question within the 10 seconds, it is counted as incorrect."
                Button8.Show()
                TextBox1.Show()
                Label6.Show()
                Label4.Show()
                Label5.Show()
                Label2.Show()
                PictureBox1.Show()
                PictureBox2.Show()
                Label3.Text = "4 + 3 ="
                Label7.Hide()
                Button10.Hide()
                Button11.Hide()
            ElseIf nextcount = 3 Then
                Button8.Hide()
                TextBox1.Hide()
                Label6.Hide()
                Label4.Hide()
                Label5.Hide()
                Label2.Hide()
                PictureBox1.Hide()
                PictureBox2.Hide()
                Label3.Text = ""
                Label1.Font = New Font(Label1.Font.FontFamily, 12, FontStyle.Regular)
                Label1.Text = "If you get above 85% correct, you will be asked if you want to print a certificate. If you select yes, a word document will open with a certificate in which you type your own name in. If you don't have a printer, you can feel free to save the document whereever you like (Save using Save As in a folder of your choice otherwise your certificate will dissappear). If you do have a printer, you should be able to print from the word document itself."
                Label7.Text = "Congratulations " + Form11.TxtUsername.Text + "! You just achieved a score higher than 85%! Would you like to print a certificate?"
                Label7.Show()
                Button10.Show()
                Button11.Show()
                Button4.Text = "Next"
                Button12.Hide()
                Label11.Hide()
                Label10.Hide()
                Label9.Hide()
                Player1st.Hide()
                Player2nd.Hide()
                Player3rd.Hide()
                PlayerHighscore1st.Hide()
                PlayerHighscore2nd.Hide()
                PlayerHighscore3rd.Hide()
            ElseIf nextcount = 4 Then
                Label7.Hide()
                Button10.Hide()
                Button11.Hide()
                Label1.Font = New Font(Label1.Font.FontFamily, 12, FontStyle.Regular)
                Label1.Text = "Once you press the finish button, you will be taken to the leaderboards which will display the top 3 scores. These scores are calculated by the amount of questions answered correctly subtracted by the amount of questions answered incorrectly. If you beat any of these scores, it will update to fit your own. If you want to play again or play another mode, there is a button which can be pressed to do so."
                Button12.Show()
                Label11.Show()
                Label10.Show()
                Label9.Show()
                Player1st.Show()
                Player2nd.Show()
                Player3rd.Show()
                PlayerHighscore1st.Show()
                PlayerHighscore2nd.Show()
                PlayerHighscore3rd.Show()
                Button4.Text = "Finish tutorial"
            End If
        ElseIf nextcount = 4 Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class