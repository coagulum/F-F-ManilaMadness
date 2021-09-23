Public Class menu
    Dim price As Double
    Public Property tableNumberMenu As String

    Private Sub btnOrder_Click(sender As Object, e As EventArgs)
        If CheckBox16.Checked Then
            price = price + 6
        End If
        If cbAddIce.Checked Then
            price = price + 1
            cbRemIce.Checked = False
        End If
        If cbRemIce.Checked Then
            price = price - 1
            cbAddIce.Checked = False
        End If
        If cbAddSugar.Checked Then
            price = price + 2
            cbRemSugar.Checked = False
        End If

        If cbRemSugar.Checked Then
            price = price - 2
            cbAddSugar.Checked = False
        End If

        If CheckBox17.Checked Then
            price = price + 5
        End If
        If cbUbe.Checked Then
            price = price + 1
            cbChocolate.Checked = False
            cbStrawberry.Checked = False
        End If
        If cbChocolate.Checked Then
            price = price + 1
            cbUbe.Checked = False
            cbStrawberry.Checked = False
        End If

        If cbStrawberry.Checked Then
            price = price + 1
            cbChocolate.Checked = False
            cbUbe.Checked = False
        End If
    End Sub
    Private Sub cbAddIce_CheckedChanged(sender As Object, e As EventArgs) 
        cbRemIce.Checked = False
    End Sub

    Private Sub cbRemIce_CheckedChanged(sender As Object, e As EventArgs) 
        cbAddIce.Checked = False
    End Sub

    Private Sub cbAddSugar_CheckedChanged(sender As Object, e As EventArgs) 
        cbRemSugar.Checked = False
    End Sub

    Private Sub cbRemSugar_CheckedChanged(sender As Object, e As EventArgs) 
        cbAddSugar.Checked = False
    End Sub

    Private Sub cbUbe_CheckedChanged(sender As Object, e As EventArgs) 
        cbChocolate.Checked = False
        cbStrawberry.Checked = False
    End Sub

    Private Sub cbStrawberry_CheckedChanged(sender As Object, e As EventArgs) 
        cbChocolate.Checked = False
        cbUbe.Checked = False
    End Sub

    Private Sub cbChocolate_CheckedChanged(sender As Object, e As EventArgs) 
        cbStrawberry.Checked = False
        cbUbe.Checked = False
    End Sub
    Private Sub meny_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTablenumber.Text = tableNumberMenu
    End Sub

    Private Sub CheckBox16_CheckedChanged_2(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            ListBox1.Items.Add("Halo-Halo")
            ListBox2.Items.Add("6.00")
            cbAddIce.Visible = True
            cbRemIce.Visible = True
            cbAddSugar.Visible = True
            cbRemSugar.Visible = True
        End If
        If CheckBox16.Checked = False Then
            ListBox1.Items.Remove("Halo-Halo")
            ListBox2.Items.Remove("6.00")
            cbAddIce.Visible = False
            cbRemIce.Visible = False
            cbAddSugar.Visible = False
            cbRemSugar.Visible = False

            cbAddIce.Checked = False
            cbRemIce.Checked = False
            cbAddSugar.Checked = False
            cbRemSugar.Checked = False
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            ListBox1.Items.Add("Taho")
            ListBox2.Items.Add("5.00")
            cbUbe.Visible = True
            cbChocolate.Visible = True
            cbStrawberry.Visible = True
        End If
        If CheckBox17.Checked = False Then
            ListBox1.Items.Remove("Taho")
            ListBox2.Items.Remove("5.00")
            cbUbe.Visible = False
            cbChocolate.Visible = False
            cbStrawberry.Visible = False

            cbUbe.Checked = False
            cbChocolate.Checked = False
            cbStrawberry.Checked = False
        End If
    End Sub

    Private Sub cbAddIce_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbAddIce.CheckedChanged
        If cbAddIce.Checked = True Then
            cbRemIce.Checked = False
            ListBox1.Items.Add("added ice")
            ListBox2.Items.Add("0.50")
        End If
        If cbAddIce.Checked = False Then
            ListBox1.Items.Remove("added ice")
            ListBox2.Items.Remove("0.50")
        End If
    End Sub

    Private Sub cbRemIce_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbRemIce.CheckedChanged
        If cbRemIce.Checked = True Then
            cbAddIce.Checked = False
            ListBox1.Items.Add("removed ice")
            ListBox2.Items.Add("-0.50")
        End If
        If cbRemIce.Checked = False Then
            ListBox1.Items.Remove("removed ice")
            ListBox2.Items.Remove("-0.50")
        End If
    End Sub

    Private Sub cbAddSugar_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbAddSugar.CheckedChanged
        If cbAddSugar.Checked = True Then
            cbRemSugar.Checked = False
            ListBox1.Items.Add("added sugar")
            ListBox2.Items.Add("0.80")
        End If
        If cbAddSugar.Checked = False Then
            ListBox1.Items.Remove("added sugar")
            ListBox2.Items.Remove("0.80")
        End If
    End Sub

    Private Sub cbRemSugar_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbRemSugar.CheckedChanged
        If cbRemSugar.Checked = True Then
            cbAddSugar.Checked = False
            ListBox1.Items.Add("removed sugar")
            ListBox2.Items.Add("-0.80")
        End If
        If cbRemSugar.Checked = False Then
            ListBox1.Items.Remove("removed sugar")
            ListBox2.Items.Remove("-0.80")
        End If
    End Sub

    Private Sub cbStrawberry_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbStrawberry.CheckedChanged
        If cbStrawberry.Checked = True Then
            cbChocolate.Checked = False
            cbUbe.Checked = False
            ListBox1.Items.Add("strawberry")
            ListBox2.Items.Add("1.00")
        End If
        If cbStrawberry.Checked = False Then
            ListBox1.Items.Remove("strawberry")
            ListBox2.Items.Remove("1.00")
        End If
    End Sub

    Private Sub cbUbe_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbUbe.CheckedChanged
        If cbUbe.Checked = True Then
            cbChocolate.Checked = False
            cbStrawberry.Checked = False
            ListBox1.Items.Add("ube")
            ListBox2.Items.Add("1.00")
        End If
        If cbUbe.Checked = False Then
            ListBox1.Items.Remove("ube")
            ListBox2.Items.Remove("1.00")
        End If
    End Sub

    Private Sub cbChocolate_CheckedChanged_1(sender As Object, e As EventArgs) Handles cbChocolate.CheckedChanged
        If cbChocolate.Checked = True Then
            cbUbe.Checked = False
            cbStrawberry.Checked = False
            ListBox1.Items.Add("chocolate")
            ListBox2.Items.Add("1.00")
        End If
        If cbChocolate.Checked = False Then
            ListBox1.Items.Remove("chocolate")
            ListBox2.Items.Remove("1.00")
        End If
    End Sub

    Private Sub btnOrder_Click_1(sender As Object, e As EventArgs) Handles btnOrder.Click
        If ListBox1.Items.Count = 0 Then
            btnOrder.Text = "Buy Something"
            btnOrder.Font = New Font("Times New Roman", 15)
        Else
            Dim Total As Double
            For Each Str As String In ListBox2.Items
                Total = Total + CDbl(Str)
            Next
            Paybook.lblPrice.Text = Math.Round((Total * 1.1), 2, MidpointRounding.AwayFromZero)
            Paybook.Label7.Text = Math.Round((Total * 1.1) - (Total), 2, MidpointRounding.AwayFromZero)
            Paybook.lblNeeded.Text = Total
            Paybook.Label14.Text = Total
            Paybook.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add("Lumpia")
        ListBox2.Items.Add("6.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove("Lumpia")
        ListBox2.Items.Remove("6.00")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Add("Empanada")
        ListBox2.Items.Add("6.50")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        ListBox1.Items.Remove("Empanada")
        ListBox2.Items.Remove("6.50")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Add("Sinigang")
        ListBox2.Items.Add("7.00")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ListBox1.Items.Remove("Sinigang")
        ListBox2.Items.Remove("7.00")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Items.Add("Kare-Kare")
        ListBox2.Items.Add("7.11")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        ListBox1.Items.Remove("Kare-Kare")
        ListBox2.Items.Remove("7.11")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Add("Chicken Adobo")
        ListBox2.Items.Add("6.89")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListBox1.Items.Add("Pancit")
        ListBox2.Items.Add("7.14")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox1.Items.Add("Sisig")
        ListBox2.Items.Add("8.00")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ListBox1.Items.Add("Lechon")
        ListBox2.Items.Add("8.50")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        ListBox1.Items.Remove("Chicken Adobo")
        ListBox2.Items.Remove("6.98")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        ListBox1.Items.Remove("Pancit")
        ListBox2.Items.Remove("7.14")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        ListBox1.Items.Remove("Sisig")
        ListBox2.Items.Remove("8.00")
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        ListBox1.Items.Remove("Lechon")
        ListBox2.Items.Remove("8.50")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        ListBox1.Items.Remove("Fruit Salad")
        ListBox2.Items.Remove("7.77")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        ListBox1.Items.Remove("Brazo de Mercedes")
        ListBox2.Items.Remove("9.00")
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        ListBox1.Items.Remove("Ube Cake")
        ListBox2.Items.Remove("8.88")
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        ListBox1.Items.Remove("Leche Flan")
        ListBox2.Items.Remove("7.99")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListBox1.Items.Add("Fruit Salad")
        ListBox2.Items.Add("7.77")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ListBox1.Items.Add("Brazo de Mercedes")
        ListBox2.Items.Add("9.00")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ListBox1.Items.Add("Ube Cake")
        ListBox2.Items.Add("8.88")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ListBox1.Items.Add("Lecho Flan")
        ListBox2.Items.Add("7.99")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ListBox1.Items.Add("Calamansi Juice")
        ListBox2.Items.Add("3.14")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ListBox1.Items.Add("Mogu Mogu")
        ListBox2.Items.Add("4.00")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        ListBox1.Items.Add("Coconut Water")
        ListBox2.Items.Add("4.50")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        ListBox1.Items.Add("Freshest Water")
        ListBox2.Items.Add("9.99")
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        ListBox1.Items.Remove("Calamansi Juice")
        ListBox2.Items.Remove("3.14")
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        ListBox1.Items.Remove("Mogu Mogu")
        ListBox2.Items.Remove("4.00")
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        ListBox1.Items.Remove("Coconut Water")
        ListBox2.Items.Remove("4.50")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        ListBox1.Items.Remove("Freshest Water")
        ListBox2.Items.Remove("9.99")
    End Sub

    Private Sub FlowLayoutPanel16_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel16.Paint

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    Private Sub TableLayoutPanel40_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel40.Paint

    End Sub

    Private Sub TableLayoutPanel41_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel41.Paint

    End Sub

    Private Sub TableLayoutPanel42_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel42.Paint

    End Sub

    Private Sub TableLayoutPanel43_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel43.Paint

    End Sub

    Private Sub FlowLayoutPanel33_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel33.Paint

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub TableLayoutPanel44_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel44.Paint

    End Sub

    Private Sub TableLayoutPanel45_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel45.Paint

    End Sub

    Private Sub FlowLayoutPanel34_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel34.Paint

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub TableLayoutPanel46_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel46.Paint

    End Sub

    Private Sub TableLayoutPanel47_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel47.Paint

    End Sub

    Private Sub FlowLayoutPanel28_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel28.Paint

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub TableLayoutPanel48_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel48.Paint

    End Sub

    Private Sub TableLayoutPanel49_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel49.Paint

    End Sub

    Private Sub FlowLayoutPanel27_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel27.Paint

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub FlowLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel3.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TableLayoutPanel30_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel30.Paint

    End Sub

    Private Sub TableLayoutPanel31_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel31.Paint

    End Sub

    Private Sub TableLayoutPanel32_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel32.Paint

    End Sub

    Private Sub TableLayoutPanel33_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel33.Paint

    End Sub

    Private Sub FlowLayoutPanel32_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel32.Paint

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub TableLayoutPanel34_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel34.Paint

    End Sub

    Private Sub TableLayoutPanel35_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel35.Paint

    End Sub

    Private Sub FlowLayoutPanel31_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel31.Paint

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub TableLayoutPanel36_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel36.Paint

    End Sub

    Private Sub TableLayoutPanel37_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel37.Paint

    End Sub

    Private Sub FlowLayoutPanel30_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel30.Paint

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub TableLayoutPanel38_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel38.Paint

    End Sub

    Private Sub TableLayoutPanel39_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel39.Paint

    End Sub

    Private Sub FlowLayoutPanel29_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel29.Paint

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub FlowLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel4.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TableLayoutPanel20_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel20.Paint

    End Sub

    Private Sub TableLayoutPanel21_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel21.Paint

    End Sub

    Private Sub TableLayoutPanel22_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel22.Paint

    End Sub

    Private Sub TableLayoutPanel23_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel23.Paint

    End Sub

    Private Sub FlowLayoutPanel26_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel26.Paint

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub TableLayoutPanel24_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel24.Paint

    End Sub

    Private Sub TableLayoutPanel25_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel25.Paint

    End Sub

    Private Sub FlowLayoutPanel25_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel25.Paint

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub TableLayoutPanel26_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel26.Paint

    End Sub

    Private Sub TableLayoutPanel27_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel27.Paint

    End Sub

    Private Sub FlowLayoutPanel24_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel24.Paint

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub TableLayoutPanel28_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel28.Paint

    End Sub

    Private Sub TableLayoutPanel29_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel29.Paint

    End Sub

    Private Sub FlowLayoutPanel23_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel23.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel2.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TableLayoutPanel10_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel10.Paint

    End Sub

    Private Sub TableLayoutPanel11_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel11.Paint

    End Sub

    Private Sub TableLayoutPanel18_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel18.Paint

    End Sub

    Private Sub TableLayoutPanel19_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel19.Paint

    End Sub

    Private Sub FlowLayoutPanel12_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel12.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TableLayoutPanel16_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel16.Paint

    End Sub

    Private Sub TableLayoutPanel17_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel17.Paint

    End Sub

    Private Sub FlowLayoutPanel11_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel11.Paint

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TableLayoutPanel14_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel14.Paint

    End Sub

    Private Sub TableLayoutPanel15_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel15.Paint

    End Sub

    Private Sub FlowLayoutPanel10_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel10.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TableLayoutPanel12_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel12.Paint

    End Sub

    Private Sub TableLayoutPanel13_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel13.Paint

    End Sub

    Private Sub FlowLayoutPanel9_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel9.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub TableLayoutPanel7_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel7.Paint

    End Sub

    Private Sub FlowLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel6.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

    End Sub

    Private Sub TableLayoutPanel51_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel51.Paint

    End Sub

    Private Sub FlowLayoutPanel7_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel7.Paint

    End Sub

    Private Sub TableLayoutPanel52_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel52.Paint

    End Sub

    Private Sub FlowLayoutPanel17_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel17.Paint

    End Sub

    Private Sub FlowLayoutPanel15_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel15.Paint

    End Sub

    Private Sub FlowLayoutPanel14_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel14.Paint

    End Sub

    Private Sub TableLayoutPanel53_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel53.Paint

    End Sub

    Private Sub FlowLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel5.Paint

    End Sub

    Private Sub TableLayoutPanel54_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel54.Paint

    End Sub

    Private Sub FlowLayoutPanel21_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel21.Paint

    End Sub

    Private Sub FlowLayoutPanel20_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel20.Paint

    End Sub

    Private Sub FlowLayoutPanel19_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel19.Paint

    End Sub

    Private Sub FlowLayoutPanel18_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel18.Paint

    End Sub

    Private Sub TableLayoutPanel8_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel8.Paint

    End Sub

    Private Sub TableLayoutPanel9_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel9.Paint

    End Sub

    Private Sub TableLayoutPanel55_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel55.Paint

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub TableLayoutPanel56_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel56.Paint

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub TableLayoutPanel50_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel50.Paint

    End Sub

    Private Sub FlowLayoutPanel13_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel13.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub FlowLayoutPanel8_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel8.Paint

    End Sub

    Private Sub lblTablenumber_Click(sender As Object, e As EventArgs) Handles lblTablenumber.Click

    End Sub

    Private Sub TableLayoutPanel57_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel57.Paint

    End Sub

    Private Sub FlowLayoutPanel22_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel22.Paint

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub
End Class