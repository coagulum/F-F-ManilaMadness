Public Class Shoot
    Dim score As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Top -= 20
        PictureBox2.Top -= 20
        PictureBox3.Top -= 20
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.Y < -60 Or PictureBox2.Location.Y < -60 Or PictureBox3.Location.Y < -60 Then
            HiLo.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If score = 10 Then
            NeedForSpeed.Show()
            Me.Close()
        End If
        PictureBox1.Location = New Point(382, 271)
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        score = score + 1
        If score = 10 Then
            NeedForSpeed.Show()
            Me.Close()
        End If
        PictureBox2.Location = New Point(169, 239)
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If score = 10 Then
            NeedForSpeed.Show()
            Me.Close()
        End If
        PictureBox3.Location = New Point(31, 271)
    End Sub
End Class