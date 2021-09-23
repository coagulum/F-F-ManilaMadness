Public Class NeedForSpeed2
    Dim comChoice As Integer
    Dim userChoice As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "You picked: Speed"
        userChoice = 1
        btnNextAlcohol.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = "You picked: Swerve"
        userChoice = 2
        btnNextAlcohol.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "You picked: Shoot"
        userChoice = 3
        btnNextAlcohol.Visible = True
    End Sub

    Private Sub btnNextAlcohol_Click(sender As Object, e As EventArgs) Handles btnNextAlcohol.Click
        Randomize()
        comChoice = Int(Rnd() * 4)
        If comChoice = 1 Then
            Label1.Text = "The Police picked: Speed"
        End If
        If comChoice = 2 Then
            Label1.Text = "The Police picked: Swerve"
        End If
        If comChoice = 3 Then
            Label1.Text = "The Police picked: Shoot"
        End If
        Button4.Visible = True
        btnNextAlcohol.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If comChoice = 1 And userChoice = 1 Then
            Label1.Text = "The Police picked: Speed"
            Speed.Show()
            Me.Hide()
        End If
        If comChoice = 2 And userChoice = 2 Then
            Label1.Text = "The Police picked: Swerve"
            Swerve.Show()
            Me.Hide()
        End If
        If comChoice = 3 And userChoice = 3 Then
            Label1.Text = "The Police picked: Shoot"
            Shoot.Show()
            Me.Hide()
        End If

        If comChoice = 1 And userChoice = 2 Then
            Label1.Text = "The Police picked: Speed"
            HiLo.Show()
            Me.Hide()
        End If
        If comChoice = 2 And userChoice = 3 Then
            Label1.Text = "The Police picked: Swerve"
            HiLo.Show()
            Me.Hide()
        End If
        If comChoice = 3 And userChoice = 1 Then
            Label1.Text = "The Police picked: Shoot"
            HiLo.Show()
            Me.Hide()
        End If

        If comChoice = 3 And userChoice = 2 Then
            Label1.Text = "The Police picked: Shoot"
            Winner.Show()
            Me.Hide()
        End If
        If comChoice = 2 And userChoice = 1 Then
            Label1.Text = "The Police picked: Swerve"
            Winner.Show()
            Me.Hide()
        End If
        If comChoice = 1 And userChoice = 3 Then
            Label1.Text = "The Police picked: Speed"
            Winner.Show()
            Me.Hide()
        End If
    End Sub
End Class