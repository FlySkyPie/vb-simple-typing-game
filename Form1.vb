Public Class Form1
    Dim letter(7) As Label
    Dim FileNum As Integer
    Dim strTemp As String
    Dim fontram As Integer
    Dim fontlong As Integer
    Dim Score As Integer
    Dim Health As Integer
    Dim combo As Integer
    Dim Level As Integer
    Dim Kills As Integer
    Dim St As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 0 To 7
            letter(i) = New Label
            letter(i).AutoSize = True
            letter(i).Width = 22
            letter(i).Height = 15
            letter(i).Font = New Font("新細明體", 12.25)
            letter(i).ForeColor = Color.Black
            letter(i).Text = "字"

            letter(i).Location = New Point(0 + i * 29, 0)

            Me.Controls.Add(letter(i))
            Me.Panel1.Controls.Add(Me.letter(i))
            letter(i).Visible = False
        Next
        '---------------------------------------
        Score = 0
        Health = 0
        ComboLabel.Text = ""
        combo = 0
        '---------------------------------------
        '讀取字庫
        Dim j As Integer
        j = Int(Rnd() * 9)
        FileNum = FreeFile()
        FileOpen(FileNum, ".\qg\font" & j & ".txt", OpenMode.Input)

        Do Until EOF(FileNum)
            strTemp &= LineInput(FileNum) & vbNewLine
        Loop

        FileClose(FileNum)
        '---------------------------------------

    End Sub

    Sub RamFont(ByVal rowfont As Integer)
        fontlong = Len(strTemp)

        Do
            fontram = Int(Rnd() * fontlong)
        Loop Until (fontram > 0) And (fontram < fontlong - 1)

        letter(rowfont).Text = Mid(strTemp, fontram, 1)

    End Sub

    Private Sub txtPIDSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyValue = Keys.Enter Then
            For i = 0 To 7
                If TextBox1.Text = letter(i).Text Then
                    combo += 1
                    Kills += 1
                    letter(i).Top = 0
                    RamFont(i)
                    Score += Level * Int(10 + combo / 10)
                    Health += combo
                    HealthBar.Maximum += 1
                End If
            Next
            TextBox1.Text = ""
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        For i = 0 To 7
            letter(i).Top += 10
        Next

    End Sub

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        '
        Dim j As Integer
        j = Int(Rnd() * 9)
        FileNum = FreeFile()
        FileOpen(FileNum, ".\qg\font" & j & ".txt", OpenMode.Input)

        Do Until EOF(FileNum)
            strTemp &= LineInput(FileNum) & vbNewLine
        Loop

        FileClose(FileNum)
        '
        '開始新遊戲.數值初始化
        Score = 0
        Level = 1
        Health = 100
        HealthBar.Maximum = 100
        combo = 0
        Kills = 0
        St = 0

        Timer2.Enabled = True
        Gameing.Enabled = True
        post.Visible = False

        For i = 0 To 7
            RamFont(i)
            letter(i).Top = 0
            letter(i).Visible = False
        Next
        StartButton.Visible = False


    End Sub

    Private Sub Gameing_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gameing.Tick
        If Health > HealthBar.Maximum Then
            Health = HealthBar.Maximum
        End If
        If Health <= 0 Then '血量歸零.遊戲結束
            HealthBar.Value = 0
            Timer1.Enabled = False
            Timer2.Enabled = False
            Gameing.Enabled = False
            For i = 0 To 7
                letter(i).Visible = False
            Next

            ScoreLabel.Text = "---"
            LevleLabel.Text = "---"
            post.Text = "遊戲結束!" & vbNewLine & "您本次的得分:" & Score
            post.Visible = True
            StartButton.Text = "再次挑戰"
            StartButton.Visible = True

            HealthBar.Value = 0
        Else
            LevleLabel.Text = Level
            ScoreLabel.Text = Score
            HealthBar.Value = Health
            '判斷文字是否落地
            For i = 0 To 7
                If letter(i).Top >= Panel1.Height Then
                    Health -= 10
                    letter(i).Top = 0
                    RamFont(i)
                    combo = 0
                End If
            Next
            '----------
            If combo >= 5 And combo < 100 Then
                ComboLabel.Font = New Font("新細明體", 15.75, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic))
                ComboLabel.ForeColor = Color.OrangeRed
                ComboLabel.Text = combo & "連擊!"
            ElseIf combo >= 100 Then
                ComboLabel.Font = New Font("新細明體", 17.75, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic))
                ComboLabel.ForeColor = Color.DeepPink
                ComboLabel.Text = combo & "連擊!"
            Else
                ComboLabel.Text = ""
            End If
            '----------
            If Kills / 50 > Level Then
                Level += 1
            End If
            '----------
            Timer1.Interval = 1000 - Level * 100


        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim j As Integer
        j = 3
        St += 1
        If St >= 0 * j Then
            letter(4).Visible = True
            letter(4).Top += 10
        End If
        If St >= 1 * j Then
            letter(3).Visible = True
            letter(3).Top += 10
        End If
        If St >= 2 * j Then
            letter(5).Visible = True
            letter(5).Top += 10
        End If
        If St >= 3 * j Then
            letter(2).Visible = True
            letter(2).Top += 10
        End If
        If St >= 4 * j Then
            letter(6).Visible = True
            letter(6).Top += 10
        End If
        If St >= 5 * j Then
            letter(1).Visible = True
            letter(1).Top += 10
        End If
        If St >= 6 * j Then
            letter(7).Visible = True
            letter(7).Top += 10
        End If
        If St >= 7 * j Then
            letter(0).Visible = True
            letter(0).Top += 10
            Timer1.Enabled = True
            Timer2.Enabled = False
        End If

    End Sub
End Class
