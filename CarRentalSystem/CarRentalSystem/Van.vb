Public Class frmVan




    Private Sub frmVan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nupAmountOfDaysVan.Value = 0  'validation/// assigning nupMountOfDays a starting value of 0

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnTotalPriceVan.Click


        If chkSatnavVan.Checked Then
            gdblSatnavprice = SatFunctionVan(nupAmountOfDaysVan.Value)  'delaring the value of satnavprice to th paramter passed through satfunction
            gdblTotalprice1 += gdblSatnavprice
        End If

        If chkSkiVan.Checked Then
            gdblTotalprice1 += gintSkiExtras
        End If
        If chkRoofRackVan.Checked Then
            gdblTotalprice1 += gdblRoofrack
        End If
        If chkContentsVan.Checked Then
            gdblContentsprice = calcInsuranceContentsVan(nupAmountOfDaysVan.Value)
        End If
        If chkCollisonVan.Checked Then
            gdblColisonCharge = collisonTheftCalcVan(nupAmountOfDaysVan.Value)
        End If
        If chkTheftVan.Checked Then
            gdblTheftprice = collisonTheftCalcVan(nupAmountOfDaysVan.Value)
        End If

        gdblVanprice = calculate1(nupAmountOfDaysVan.Value)
        gdblTotalprice1 = gdblVanprice + gdblSatnavprice + gdblContentsprice + gdblColisonCharge + gdblTheftprice + gdblRoofrack + gintSkiExtras

        MessageBox.Show(gdblTotalprice1)
    End Sub

    Public Function calcInsuranceContentsVan(ByVal AmountOfDays2 As Double) As Double
        Dim priceOfContent As Double = 0
        While AmountOfDays2 > 0
            If AmountOfDays2 >= gintNumberOfWeeks Then

                AmountOfDays2 -= gintNumberOfWeeks
                priceOfContent += gdblContentWeeklyRate

            ElseIf AmountOfDays2 < 7 Then
                AmountOfDays2 -= gintNumberOfDays
                priceOfContent += gdblContentNightlyRate
            End If
        End While

        Return priceOfContent
    End Function

    Public Function SatFunctionVan(ByVal CostOfSat As Double) As Double 'function that mulitples amount of days by 5

        Return 5 * CostOfSat
    End Function
    'change names of functions
    Public Function calculate1(ByVal AmountOfDays As Double) As Double 'function to calculate the amount of days by the daily, weekly, nightly rates
        Dim price As Double = 0

        While AmountOfDays > 0
            If AmountOfDays >= gintNuberOfFortnights Then

                AmountOfDays -= gintNuberOfFortnights
                price += gdblFortNightlyRate

            ElseIf AmountOfDays >= gintNumberOfWeeks Then

                AmountOfDays -= gintNumberOfWeeks
                price += gdblWeeklyRate
            Else
                AmountOfDays -= gintNumberOfDays
                price += gdblNightlyRate
            End If
        End While
        Return price

    End Function

    Public Function collisonTheftCalcVan(ByVal AmountOfDays3 As Double) As Double

        Return 2 * AmountOfDays3
    End Function

    Private Sub rdbCorsa_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCorsa.CheckedChanged
        If rdbCorsa.Checked Then
            gdblNightlyRate = 35.1
            gdblWeeklyRate = 222.13
            gdblFortNightlyRate = 420.15
            picDisplayVan.Image = My.Resources.opelVan
            lblDisplayColourVan.Text = ("red, white, blue")
            lblDisplayFuelVan.Text = ("Petrol")
            lblDisplaydoorsVan.Text = ("3")
        End If
    End Sub

    Private Sub rdbToyota_CheckedChanged(sender As Object, e As EventArgs) Handles rdbToyota.CheckedChanged
        If rdbToyota.Checked Then
            gdblNightlyRate = 39.9
            gdblWeeklyRate = 251.37
            gdblFortNightlyRate = 477.6
            picDisplayVan.Image = My.Resources.hiaceVan
            lblDisplayColourVan.Text = ("red, white, black")
            lblDisplayFuelVan.Text = ("Diesel")
            lblDisplaydoorsVan.Text = ("4")
        End If
    End Sub

    Private Sub rdbTransit_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTransit.CheckedChanged
        If rdbTransit.Checked Then
            gdblNightlyRate = 65.4
            gdblWeeklyRate = 412.02
            gdblFortNightlyRate = 782.84
            picDisplayVan.Image = My.Resources.fordtransit
            lblDisplayColourVan.Text = ("red, white, black")
            lblDisplayFuelVan.Text = ("Diesel")
            lblDisplaydoorsVan.Text = ("4")
        End If
    End Sub

    Private Sub rdbMinibus_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMinibus.CheckedChanged
        If rdbMinibus.Checked Then
            gdblNightlyRate = 68.9
            gdblWeeklyRate = 434.07
            gdblFortNightlyRate = 824.73
            picDisplayVan.Image = My.Resources._26seater
            lblDisplayColourVan.Text = ("red, white, black")
            lblDisplayFuelVan.Text = ("Diesel")
            lblDisplaydoorsVan.Text = ("5")
        End If
    End Sub

    Private Sub rdbRunner_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRunner.CheckedChanged
        If rdbRunner.Checked Then
            gdblNightlyRate = 89.6
            gdblWeeklyRate = 564.46
            gdblFortNightlyRate = 1072.51
            picDisplayVan.Image = My.Resources.runner
            lblDisplayColourVan.Text = ("red, white, black")
            lblDisplayFuelVan.Text = ("Diesel")
            lblDisplaydoorsVan.Text = ("5")
        End If
    End Sub

    Private Sub rbtNissan_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNissan.CheckedChanged
        If rdbNissan.Checked Then
            lblSkiVan.Visible = True
            lblRoofRackVan.Visible = True
            chkSkiVan.Visible = True
            chkRoofRackVan.Visible = True
            gdblNightlyRate = 78.8
            gdblWeeklyRate = 496.44
            gdblFortNightlyRate = 943.24
            picDisplayVan.Image = My.Resources.patrol
            lblDisplayColourVan.Text = ("red, white, black")
            lblDisplayFuelVan.Text = ("Diesel")
            lblDisplaydoorsVan.Text = ("5")
        Else
            lblSkiVan.Visible = False
            lblRoofRackVan.Visible = False
            chkSkiVan.Visible = False
            chkRoofRackVan.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGobackVan.Click
        frmCustomerDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnIsurancefrm_Click(sender As Object, e As EventArgs) Handles btnIReceiptfrmVan.Click
        frmPaymentAndReceipt.Show()      'Doubled up on this code so if the user dosent press then btnCalulate the data will still save 
        Me.Hide()

        Dim vanPrice As Double
        vanPrice = calculate1(nupAmountOfDaysVan.Value)

        If chkSatnavVan.Checked Then
            gdblSatnavprice = SatFunctionVan(nupAmountOfDaysVan.Value)  'delaring the value of satnavprice to th paramter passed through satfunction
            gdblTotalprice1 += gdblSatnavprice
        End If

        If chkSkiVan.Checked Then
            gdblTotalprice1 += gintSkiExtras
        End If
        If chkRoofRackVan.Checked Then
            gdblTotalprice1 += gdblRoofrack
        End If
        If chkContentsVan.Checked Then
            gdblContentsprice = calcInsuranceContentsVan(nupAmountOfDaysVan.Value)
            If chkCollisonVan.Checked Then
                gdblColisonCharge = collisonTheftCalcVan(nupAmountOfDaysVan.Value)
            End If
            If chkTheftVan.Checked Then
                gdblTheftprice = collisonTheftCalcVan(nupAmountOfDaysVan.Value)
            End If



        End If
        gdblVanprice = calculate1(nupAmountOfDaysVan.Value)
        gdblTotalprice1 = gdblVanprice + gdblSatnavprice + gdblContentsprice + gdblColisonCharge + gdblTheftprice + gdblRoofrack + gintSkiExtras
    End Sub

    Private Sub chkSatnav_CheckedChanged(sender As Object, e As EventArgs) Handles chkSatnavVan.CheckedChanged
        If chkSatnavVan.Checked = False Then
            gdblSatnavprice = 0
        End If
    End Sub

    Private Sub chkSkiVan_CheckedChanged(sender As Object, e As EventArgs) Handles chkSkiVan.CheckedChanged
        If chkSkiVan.Checked = False Then
            gintSkiExtras = 0
        End If
        If chkSkiVan.Checked = True Then
            gintSkiExtras = 78
        End If

    End Sub

    Private Sub chkRoofRack_CheckedChanged(sender As Object, e As EventArgs) Handles chkRoofRackVan.CheckedChanged
        If chkRoofRackVan.Checked = False Then
            gdblRoofrack = 0
        End If
        If chkRoofRackVan.Checked = True Then
            gdblRoofrack = 45
        End If
    End Sub

    Private Sub chkCollison_CheckedChanged(sender As Object, e As EventArgs) Handles chkCollisonVan.CheckedChanged
        If chkCollisonVan.Checked = False Then
            gdblColisonCharge = 0
        End If
    End Sub

    Private Sub chkContents_CheckedChanged(sender As Object, e As EventArgs) Handles chkContentsVan.CheckedChanged
        If chkContentsVan.Checked = False Then
            gdblContentsprice = 0
        End If
    End Sub

    Private Sub chkTheft_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheftVan.CheckedChanged
        If chkTheftVan.Checked = False Then
            gdblTheftprice = 0
        End If
    End Sub


End Class
