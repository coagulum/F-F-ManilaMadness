Public Class Speed
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        car2.Top -= 3
        If (car.Bounds.IntersectsWith(car2.Bounds)) Then
            HiLo.Show()
            Me.Close()
        End If
        If (car.Bounds.IntersectsWith(PictureBox7.Bounds)) Then
            NeedForSpeed.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        car.Top -= 5
    End Sub

    Private Sub Speed_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub car_Click(sender As Object, e As EventArgs) Handles car.Click

    End Sub
End Class