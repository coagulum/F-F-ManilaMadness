Public Class Paybook

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim Price As Double
        Dim buttonClicks As Integer
        Price = lblPrice.Text

        If buttonClicks = 0 Then
            If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False Then
                lblNotEnough.Visible = True
                lblNotEnough.Text = "Please pick a payment option"
            Else
                buttonClicks = buttonClicks + 1
            End If

            If buttonClicks = 1 Then
                Try
                    If tbPriceGiven.Text > Price Then
                        lblNotEnough.Text = "Payment Complete"
                        lblNotEnough.Visible = True

                        If RadioButton1.Checked Then
                            Label12.Text = "Cash"
                        End If
                        If RadioButton2.Checked Then
                            Label12.Text = "Credit"
                        End If
                        If RadioButton3.Checked Then
                            Label12.Text = "Debit"
                        End If
                        If RadioButton4.Checked Then
                            Label12.Text = "Bitcoin"
                        End If

                        Label8.Visible = True
                        Label5.Visible = True
                        Label11.Visible = True
                        Label13.Visible = True

                        Label10.Text = tbPriceGiven.Text
                        Button1.Visible = True
                        btnPay.Visible = False
                        lblNotEnough.Visible = False
                        tbPriceGiven.Visible = False
                        Label1.Visible = False

                        Label10.Visible = True
                        Label12.Visible = True
                        Label6.Visible = True
                        Label14.Visible = True
                    Else
                        lblNotEnough.Text = "insufficient funds"
                        lblNotEnough.Visible = True
                    End If
                Catch ex As Exception
                    lblNotEnough.Text = "Put money in mate"
                    lblNotEnough.Visible = True
                End Try
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        HiLo.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        NeedForSpeed.Show()
        Me.Hide()
    End Sub

    Private Sub btnPay_KeyDown(sender As Object, e As KeyEventArgs) Handles btnPay.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Price As Double
            Dim buttonClicks As Integer
            Price = lblPrice.Text

            If buttonClicks = 0 Then
                If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False Then
                    lblNotEnough.Visible = True
                    lblNotEnough.Text = "Please pick a payment option"
                Else
                    buttonClicks = buttonClicks + 1
                End If

                If buttonClicks = 1 Then
                    Try
                        If tbPriceGiven.Text > Price Then
                            lblNotEnough.Text = "Payment Complete"
                            lblNotEnough.Visible = True

                            If RadioButton1.Checked Then
                                Label12.Text = "Cash"
                            End If
                            If RadioButton2.Checked Then
                                Label12.Text = "Credit"
                            End If
                            If RadioButton3.Checked Then
                                Label12.Text = "Debit"
                            End If
                            If RadioButton4.Checked Then
                                Label12.Text = "Bitcoin"
                            End If

                            Label8.Visible = True
                            Label5.Visible = True
                            Label11.Visible = True
                            Label13.Visible = True

                            Label10.Text = tbPriceGiven.Text
                            Button1.Visible = True
                            btnPay.Visible = False
                            lblNotEnough.Visible = False
                            tbPriceGiven.Visible = False
                            Label1.Visible = False

                            Label10.Visible = True
                            Label12.Visible = True
                            Label6.Visible = True
                            Label14.Visible = True
                        Else
                            lblNotEnough.Text = "insufficient funds"
                            lblNotEnough.Visible = True
                        End If
                    Catch ex As Exception
                        lblNotEnough.Text = "Put money in mate"
                        lblNotEnough.Visible = True
                    End Try
                End If
            End If
        End If

    End Sub
End Class