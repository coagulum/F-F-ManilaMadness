Public Class StoryMode
    Dim username As String
    Private Sub btnNext_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click
        If tbName.Text.Trim.Length = 0 Then
            lblWelcome.Text = "Please put your name in the the text box"
        Else
            If tbName.Text.Length > 15 Then
                lblWelcome.Text = "Your name is too long"
            Else
                username = tbName.Text
                Paybook.Label6.Text = username
                lblName.Hide()
                tbName.Hide()
                lblWelcome.Text = "Hello " + username + " Where do you want to sit?"
                btnNext.Hide()
                Button2.Show()
                Button3.Show()
                Button4.Show()
                Button5.Show()
                FlowLayoutPanel1.Show()
                FlowLayoutPanel10.Show()
                FlowLayoutPanel4.Show()
                FlowLayoutPanel9.Show()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tableNumber As New menu
        tableNumber.tableNumberMenu = "Table 1"
        tableNumber.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tableNumber As New menu
        tableNumber.tableNumberMenu = "Table 2"
        tableNumber.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tableNumber As New menu
        tableNumber.tableNumberMenu = "Table 3"
        tableNumber.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim tableNumber As New menu
        tableNumber.tableNumberMenu = "Table 4"
        tableNumber.Show()
        Me.Hide()
    End Sub

    Private Sub btnNext_KeyDown(sender As Object, e As KeyEventArgs) Handles btnNext.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tbName.Text.Trim.Length = 0 Then
                lblWelcome.Text = "Please put your name in the the text box"
            Else
                If tbName.Text.Length > 15 Then
                    lblWelcome.Text = "Your name is too long"
                Else
                    username = tbName.Text
                    Paybook.Label6.Text = username
                    lblName.Hide()
                    tbName.Hide()
                    lblWelcome.Text = "Hello " + username + " Where do you want to sit?"
                    btnNext.Hide()
                    Button2.Show()
                    Button3.Show()
                    Button4.Show()
                    Button5.Show()
                    FlowLayoutPanel1.Show()
                    FlowLayoutPanel10.Show()
                    FlowLayoutPanel4.Show()
                    FlowLayoutPanel9.Show()
                End If
            End If
        End If
    End Sub



End Class