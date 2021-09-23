Public Class Swerve
    Dim speed As Integer
    Dim road(3) As PictureBox
    Dim score As Integer = 0
    Private Sub Swerve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 100

        road(0) = PictureBox3
        road(1) = PictureBox4
        road(2) = PictureBox5
        road(3) = PictureBox6
        PictureBox13.Visible = False
        PictureBox14.Visible = False

    End Sub

    Private Sub crash()
        HiLo.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles RoadMove.Tick
        For x As Integer = 0 To 3
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If (car.Bounds.IntersectsWith(car1.Bounds)) Then
            crash()
        End If
        If (car.Bounds.IntersectsWith(car2.Bounds)) Then
            crash()
        End If
        If (car.Bounds.IntersectsWith(car3.Bounds)) Then
            crash()
        End If
        If (car.Bounds.IntersectsWith(PictureBox10.Bounds)) Then
            crash()
        End If

        If score = 4 Then
            NeedForSpeed.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Swerve_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            Right.Start()
            Left.Stop()
        End If
        If e.KeyCode = Keys.Left Then
            Left.Start()
            Right.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Right.Tick
        If (car.Location.X < 387) Then
            car.Left += 10
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Left.Tick
        If (car.Location.X > 30) Then
            car.Left -= 10
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        car1.Top += speed / 10
        If car1.Top > Me.Height Then
            score = score + 1
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        car2.Top += speed / 11
        If car2.Top > Me.Height Then
            score = score + 1
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        car3.Top += speed / 9
        If car3.Top > Me.Height Then
            score = score + 1
        End If
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox10.Top += speed / 9
        If PictureBox10.Top > Me.Height Then
            score = score + 1
        End If
    End Sub
End Class