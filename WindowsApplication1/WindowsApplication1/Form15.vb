Public Class Form15
    Dim Player3 As String
    Dim Player2 As String
    Dim Player1 As String
    Dim Highscore3 As String
    Dim Highscore2 As String
    Dim Highscore1 As String
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub LoadNewHighscore()
        Dim FileNum As Integer
        If Form8.playerscorecountEM >= Val(PlayerHighscore1st.Text) Then
            Highscore1 = Form8.playerscorecountEM
            Player1 = Form11.TxtUsername.Text
            Highscore2 = PlayerHighscore1st.Text
            Player2 = Player1st.Text
            Highscore3 = PlayerHighscore2nd.Text
            Player3 = Player2nd.Text
            PlayerHighscore1st.Text = Highscore1
            Player1st.Text = Player1
            PlayerHighscore2nd.Text = Highscore2
            Player2nd.Text = Player2
            PlayerHighscore3rd.Text = Highscore3
            Player3rd.Text = Player3
            FileNum = FreeFile()
            FileOpen(FileNum, "scoreEM.txt", OpenMode.Output)
            PrintLine(FileNum, Player1)
            PrintLine(FileNum, Highscore1)
            PrintLine(FileNum, Player2)
            PrintLine(FileNum, Highscore2)
            PrintLine(FileNum, Player3)
            PrintLine(FileNum, Highscore3)
            FileClose(FileNum)
        ElseIf Form8.playerscorecountEM >= Val(PlayerHighscore2nd.Text) Then
            Highscore1 = PlayerHighscore1st.Text
            Player1 = Player1st.Text
            Highscore2 = Form8.playerscorecountEM
            Player2 = Form11.TxtUsername.Text
            Highscore3 = PlayerHighscore2nd.Text
            Player3 = Player2nd.Text
            PlayerHighscore1st.Text = Highscore1
            Player1st.Text = Player1
            PlayerHighscore2nd.Text = Highscore2
            Player2nd.Text = Player2
            PlayerHighscore3rd.Text = Highscore3
            Player3rd.Text = Player3
            FileNum = FreeFile()
            FileOpen(FileNum, "scoreEM.txt", OpenMode.Output)
            PrintLine(FileNum, Player1)
            PrintLine(FileNum, Highscore1)
            PrintLine(FileNum, Player2)
            PrintLine(FileNum, Highscore2)
            PrintLine(FileNum, Player3)
            PrintLine(FileNum, Highscore3)
            FileClose(FileNum)
        ElseIf Form8.playerscorecountEM >= Val(PlayerHighscore3rd.Text) Then
            Highscore1 = PlayerHighscore1st.Text
            Player1 = Player1st.Text
            Highscore2 = PlayerHighscore2nd.Text
            Player2 = Player2nd.Text
            Highscore3 = Form8.playerscorecountEM
            Player3 = Form11.TxtUsername.Text
            PlayerHighscore1st.Text = Highscore1
            Player1st.Text = Player1
            PlayerHighscore2nd.Text = Highscore2
            Player2nd.Text = Player2
            PlayerHighscore3rd.Text = Highscore3
            Player3rd.Text = Player3
            FileNum = FreeFile()
            FileOpen(FileNum, "scoreEM.txt", OpenMode.Output)
            PrintLine(FileNum, Player1)
            PrintLine(FileNum, Highscore1)
            PrintLine(FileNum, Player2)
            PrintLine(FileNum, Highscore2)
            PrintLine(FileNum, Player3)
            PrintLine(FileNum, Highscore3)
            FileClose(FileNum)
        End If
    End Sub
    Public Sub LoadCurrentHighScore()
        Dim FileNum As Integer
        FileNum = FreeFile()
        FileOpen(FileNum, "scoreEM.txt", OpenMode.Input)
        Player1 = LineInput(FileNum)
        Highscore1 = LineInput(FileNum)
        Player2 = LineInput(FileNum)
        Highscore2 = LineInput(FileNum)
        Player3 = LineInput(FileNum)
        Highscore3 = LineInput(FileNum)
        PlayerHighscore1st.Text = Highscore1
        Player1st.Text = Player1
        PlayerHighscore2nd.Text = Highscore2
        Player2nd.Text = Player2
        PlayerHighscore3rd.Text = Highscore3
        Player3rd.Text = Player3
        FileClose(FileNum)
        LoadNewHighscore()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class