Public Class HiLo
    Dim randspeed As Integer
    Dim randomAlcohol As Integer
    Dim buttonCounter As Integer
    Dim speedCounter As Integer
    Dim speedChances As Integer
    Dim alcoholCounter As Integer
    Dim alcoholChances As Integer
    Dim alcoholStart As Integer

    Private Sub btnNextAlcohol_Click_1(sender As Object, e As EventArgs) Handles btnNextAlcohol.Click
        If buttonCounter = 0 Then
            buttonCounter = buttonCounter + 1
        End If
        If buttonCounter = 1 Then
            buttonCounter = buttonCounter + 1
            lblDescription1.Text = "You have 5 chances to redeem yourself, you must guess your speed between 40-60"

            Randomize()
            randspeed = Int((Rnd() * 21) + 40)
            randomAlcohol = Int(Rnd() * 101)
        End If
        If buttonCounter = 2 Then
            Label1.Visible = True
            tbSpeed.Visible = True

            Try
                speedCounter = speedCounter + 1
                speedChances = speedChances + 1
                If speedChances < 7 Then
                    If tbSpeed.Text = randspeed Then
                        lblAnswerSpeed.Text = "Correct!"
                        btnNextAlcohol.Visible = True
                        buttonCounter = buttonCounter + 1
                        tbSpeed.Visible = False
                        tbAlcohol.Visible = True
                        lblAnswerSpeed.Text = ""
                        PictureBox1.Visible = True
                    ElseIf tbSpeed.Text > randspeed Then
                        lblAnswerSpeed.Text = "Too high, your next guess will be " + speedChances.ToString + " out of 5 guesses"
                        tbSpeed.Clear()
                    ElseIf tbSpeed.Text < randspeed Then
                        lblAnswerSpeed.Text = "Too low, your next guess will be " + speedChances.ToString + " out of 5 guesses"
                        tbSpeed.Clear()
                    End If
                    lblAnswerSpeed.Visible = True
                End If
                If speedChances = 6 Then
                    lblAnswerSpeed.Text = "you have used all your guesses"
                    tbSpeed.Visible = False
                    Label1.Visible = False
                End If
                If speedChances = 7 Then
                    lblDescription1.Text = "You're arrested mate"
                    GameOver.Show()
                    Me.Hide()
                End If
            Catch ex As Exception
                If speedCounter = 1 Then
                Else
                    lblAnswerSpeed.Text = "Are you drunk? It's a number, If you don't comply, you're arrested"
                    lblAnswerSpeed.Visible = True
                End If
            End Try
        End If

        If buttonCounter = 3 Then
            lblDescription1.Text = "You're not done yet! 7 chances to guess your blood alcohol level between 1-100 and you're FREE!"

            Try
                alcoholCounter = alcoholCounter + 1
                alcoholChances = alcoholChances + 1
                If alcoholChances < 9 Then
                    If tbAlcohol.Text = randomAlcohol Then
                        lblAnswerSpeed.Text = "Corrrrect!"
                        Winner.Show()
                        Me.Hide()
                    ElseIf tbAlcohol.Text > randomAlcohol Then
                        lblAnswerSpeed.Text = "Too high, your next guess will be " + alcoholChances.ToString + " out of 7 guesses"
                        tbAlcohol.Clear()
                    ElseIf tbAlcohol.Text < randomAlcohol Then
                        lblAnswerSpeed.Text = "Too low, your next guess will be " + alcoholChances.ToString + " out of 7 guesses"
                        tbAlcohol.Clear()
                    End If
                    lblAnswerSpeed.Visible = True
                End If
                If alcoholChances = 8 Then
                    lblAnswerSpeed.Text = "you have used all your guesses"
                    tbAlcohol.Visible = False
                    Label1.Visible = False
                End If
                If alcoholChances = 9 Then
                    lblDescription1.Text = "You're arrested mate"
                    Label1.Visible = False
                    tbSpeed.Visible = False
                    lblAnswerSpeed.Visible = False
                    GameOver.Show()
                    Me.Hide()
                End If
            Catch ex As Exception
                If alcoholCounter = 1 Then
                Else
                    lblAnswerSpeed.Text = "Are you drunk? It's a number, If you don't comply, you're arrested"
                    lblAnswerSpeed.Visible = True
                End If
            End Try
        End If
    End Sub
    Private Sub tbSpeed_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSpeed.KeyDown
        If e.KeyCode = Keys.Enter Then
            If buttonCounter = 0 Then
                buttonCounter = buttonCounter + 1
            End If
            If buttonCounter = 1 Then
                buttonCounter = buttonCounter + 1
                lblDescription1.Text = "You have 5 chances to redeem yourself, you must guess your speed between 40-60"

                Randomize()
                randspeed = Int((Rnd() * 21) + 40)
                randomAlcohol = Int(Rnd() * 101)
            End If
            If buttonCounter = 2 Then
                Label1.Visible = True
                tbSpeed.Visible = True

                Try
                    speedCounter = speedCounter + 1
                    speedChances = speedChances + 1
                    If speedChances < 7 Then
                        If tbSpeed.Text = randspeed Then
                            lblAnswerSpeed.Text = "Correct!"
                            btnNextAlcohol.Visible = True
                            buttonCounter = buttonCounter + 1
                            tbSpeed.Visible = False
                            tbAlcohol.Visible = True
                            lblAnswerSpeed.Text = ""
                            PictureBox1.Visible = True
                        ElseIf tbSpeed.Text > randspeed Then
                            lblAnswerSpeed.Text = "Too high, your next guess will be " + speedChances.ToString + " out of 5 guesses"
                        ElseIf tbSpeed.Text < randspeed Then
                            lblAnswerSpeed.Text = "Too low, your next guess will be " + speedChances.ToString + " out of 5 guesses"
                        End If
                        lblAnswerSpeed.Visible = True
                    End If
                    If speedChances = 6 Then
                        lblAnswerSpeed.Text = "you have used all your guesses"
                        tbSpeed.Visible = False
                        Label1.Visible = False
                    End If
                    If speedChances = 7 Then
                        lblDescription1.Text = "You're arrested mate"
                        GameOver.Show()
                        Me.Hide()
                    End If
                Catch ex As Exception
                    If speedCounter = 1 Then
                    Else
                        lblAnswerSpeed.Text = "Are you drunk? It's a number, If you don't comply, you're arrested"
                        lblAnswerSpeed.Visible = True
                    End If
                End Try
            End If

            If buttonCounter = 3 Then
                lblDescription1.Text = "You're not done yet! 7 chances to guess your blood alcohol level between 1-100 and you're FREE!"

                Try
                    alcoholCounter = alcoholCounter + 1
                    alcoholChances = alcoholChances + 1
                    If alcoholChances < 9 Then
                        If tbAlcohol.Text = randomAlcohol Then
                            lblAnswerSpeed.Text = "Corrrrect!"
                            Winner.Show()
                            Me.Hide()
                        ElseIf tbAlcohol.Text > randomAlcohol Then
                            lblAnswerSpeed.Text = "Too high, your next guess will be " + alcoholChances.ToString + " out of 7 guesses"
                        ElseIf tbAlcohol.Text < randomAlcohol Then
                            lblAnswerSpeed.Text = "Too low, your next guess will be " + alcoholChances.ToString + " out of 7 guesses"
                        End If
                        lblAnswerSpeed.Visible = True
                    End If
                    If alcoholChances = 8 Then
                        lblAnswerSpeed.Text = "you have used all your guesses"
                        tbAlcohol.Visible = False
                        Label1.Visible = False
                    End If
                    If alcoholChances = 9 Then
                        lblDescription1.Text = "You're arrested mate"
                        Label1.Visible = False
                        tbSpeed.Visible = False
                        lblAnswerSpeed.Visible = False
                        GameOver.Show()
                        Me.Hide()
                    End If
                Catch ex As Exception
                    If alcoholCounter = 1 Then
                    Else
                        lblAnswerSpeed.Text = "Are you drunk? It's a number, If you don't comply, you're arrested"
                        lblAnswerSpeed.Visible = True
                    End If
                End Try
            End If
        End If
    End Sub
End Class