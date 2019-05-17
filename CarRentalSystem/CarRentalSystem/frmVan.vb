Public Class frmVan

    '/////////////////////////////////////////
    'section 1 construtor, buttons and methods
    '/////////////////////////////////////////

    Private Sub frmVan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnIReceiptfrmVan.Enabled = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnTotalPriceVan.Click
        btnTotalPriceVan.Enabled = False
        If chkCollisonVan.Checked = False Then  'setting the surcharge in btnCalc, so that it will be added on if not checked
            gdblColisonCharge = 2000
        End If
        If chkTheftVan.Checked = False Then
            gdblTheftprice = 3000
        End If
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
        gdblVehicleprice = VehiclePriceVan(nupAmountOfDaysVan.Value)

        gdblVehiclesandExtrasCost = gdblVehicleprice + gdblSatnavprice + gdblContentsprice + gdblRoofrack + gintSkiExtras

        gdblVatCost = VatCalc2(gdblVehiclesandExtrasCost) 'declaring a variable with the 20% vat included to the gdblVehiclesandExtrasCost variable

        gdblInsuancePrice = +gdblColisonCharge + gdblTheftprice 'adding both insurance prices together 

        gdblTotalprice1 = gdblVatCost + gdblInsuancePrice + gdblVehiclesandExtrasCost 'variable with the value of the vat, insurance, vehicles and extras

        lstPriceBreakdownVan.Items.Add("Vehicle price:" & (gdblVehicleprice))
        lstPriceBreakdownVan.Items.Add("sat nav price:" & (gdblSatnavprice))
        lstPriceBreakdownVan.Items.Add("content insurance:" & (gdblContentsprice))
        lstPriceBreakdownVan.Items.Add("Ski price:" & (gintSkiExtras))
        lstPriceBreakdownVan.Items.Add("roof rack price:" & (gdblRoofrack))
        lstPriceBreakdownVan.Items.Add("contents or surcharge:" & (gdblColisonCharge))
        lstPriceBreakdownVan.Items.Add("Theft or surcharge:" & (gdblTheftprice))
        lstPriceBreakdownVan.Items.Add("Vat Charge" & (gdblVatCost))
        lstPriceBreakdownVan.Items.Add("Total Price:" & (gdblTotalprice1))
    End Sub

    Private Sub btnIsurancefrm_Click(sender As Object, e As EventArgs) Handles btnIReceiptfrmVan.Click
        frmPaymentAndTandCs.Show()      'Doubled up on this code so if the user dosent press then btnCalulate the data will still save 
        Me.Hide()

        If chkCollisonVan.Checked = False Then  'setting the surcharge in btnCalc, so that it will be added on if not checked
            gdblColisonCharge = 2000
        End If

        If chkTheftVan.Checked = False Then
            gdblTheftprice = 3000
        End If

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

        gdblVehicleprice = VehiclePriceVan(nupAmountOfDaysVan.Value)

        gdblVehiclesandExtrasCost = gdblVehicleprice + gdblSatnavprice + gdblContentsprice + gdblRoofrack + gintSkiExtras

        gdblVatCost = VatCalc2(gdblVehiclesandExtrasCost) 'declaring a variable with the 20% vat included to the gdblVehiclesandExtrasCost variable

        gdblInsuancePrice = +gdblColisonCharge + gdblTheftprice 'adding both insurance prices together 

        gdblTotalprice1 = gdblVatCost + gdblInsuancePrice + gdblVehiclesandExtrasCost 'variable with the value of the vat, insurance, vehicles and extras

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
    Public Function VehiclePriceVan(ByVal AmountOfDays As Double) As Double 'function to calculate the amount of days by the daily, weekly, nightly rates
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

    Public Function VatCalc2(ByVal Vat As Double) As Double 'function that mulitples amount of days by .2, to get 20%

        Return Vat * 0.2
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
            chkSkiVan.Checked = False
            chkRoofRackVan.Checked = False
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
            chkRoofRackVan.Checked = False
            chkSkiVan.Checked = False
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
            chkSkiVan.Checked = False
            chkRoofRackVan.Checked = False
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
            chkSkiVan.Checked = False
            chkRoofRackVan.Checked = False
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
            chkSkiVan.Checked = False
            chkRoofRackVan.Checked = False

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

    Private Sub btnSurchargeInfoVan_Click(sender As Object, e As EventArgs) Handles btnSurchargeInfoVan.Click
        MessageBox.Show("If the customer decides not to pay for collision damage insurance or theft insurance," & Environment.NewLine &
                        " the customer is required to pay a surcharge, that is refundable on return of the undamaged vehicle. Costs: " & Environment.NewLine & "
                                               Collision Damage Waiver = €2000
                                               Theft = €3000")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lstPriceBreakdownVan.Items.Clear()
        btnTotalPriceVan.Enabled = True
    End Sub

    Private Sub nupAmountOfDaysVan_ValueChanged(sender As Object, e As EventArgs) Handles nupAmountOfDaysVan.ValueChanged

        Dim dblCounterV As Double = 0    'declaring a variable  so that the user has to select an amount of days before going to next section

        If (nupAmountOfDaysVan.Text > dblCounterV Or nupAmountOfDaysVan.Text = dblCounterV) Then
            btnIReceiptfrmVan.Enabled = True
        End If
    End Sub
End Class
