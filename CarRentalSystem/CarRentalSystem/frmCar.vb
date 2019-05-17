Public Class frmCar

    '///////////////////////////////////////////////
    'section 1. buttons and functions and construtor
    '///////////////////////////////////////////////

    Private Sub Car_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'code that is entered here will be compiled first
        btnIReceiptfrmCar.Enabled = False
    End Sub

    ' the calculations were put into btnIreceiption as a precaution incase the user didnt use the btnTotalPriceCar  
    'button to calculate. 
    Private Sub btnIReceiptfrmCar_Click(sender As Object, e As EventArgs) Handles btnIReceiptfrmCar.Click
        frmPaymentAndTandCs.Show()                                    'shows frmPaymentAnd Receipts
        Me.Hide()                                                      'Hides carform

        If chkTheftCar.Checked = False Then                            'if theft insurance isnt checked
            gdblTheftprice = 3000                                      'user will be charged 3000
        End If
        If chkCollisonCar.Checked = False Then                         'if collison insurance isnt cheked
            gdblColisonCharge = 2000                                   'user will be charged 2000
        End If

        If chkSatNavCar.Checked Then
            gdblSatnavprice = SatFunctionCar(nupAmountofDaysCar.Value)  'delaring the value of satnavprice to the paramter passed through satfunction
            gdblTotalprice1 += gdblSatnavprice                          'cost of satnav is added to the totalprice
        End If

        If chkSkiCar.Checked Then                                       'if chkSkiCar is checked
            gdblTotalprice1 += gintSkiExtras                            '78 will be addded to the total price
        End If
        If chkRoofRackCar.Checked Then
            gdblTotalprice1 += gdblRoofrack
        End If
        If chkContentsCar.Checked Then               'nupAmountofDaysCar = the amount of the days the user wants a vehicle
            gdblContentsprice = calcInsuranceContentsCar(nupAmountofDaysCar.Value)
        End If
        If chkCollisonCar.Checked Then
            gdblColisonCharge = collisonTheftCalcCar(nupAmountofDaysCar.Value)
        End If
        If chkTheftCar.Checked Then
            gdblTheftprice = collisonTheftCalcCar(nupAmountofDaysCar.Value)
        End If
        gdblVehicleprice = CostOfVehicle(nupAmountofDaysCar.Value)

        gdblVehiclesandExtrasCost = gdblVehicleprice + gdblSatnavprice + gdblContentsprice + gdblRoofrack + gintSkiExtras

        gdblVatCost = VatCalc1(gdblVehiclesandExtrasCost) 'declaring a variable with the 20% vat included to the gdblVehiclesandExtrasCost variable

        gdblInsuancePrice = +gdblColisonCharge + gdblTheftprice 'adding both insurance prices together 

        gdblTotalprice1 = gdblVatCost + gdblInsuancePrice + gdblVehiclesandExtrasCost 'variable with the value of the vat, insurance, vehicles and extras
    End Sub

    'price is calculated in btnTotalPriceCar below, it is the same code as above.

    Private Sub btnTotalPriceCar_Click(sender As Object, e As EventArgs) Handles btnTotalPriceCar.Click
        If chkTheftCar.Checked = False Then                                                      'all explained above 
            gdblTheftprice = 3000
        End If

        If chkCollisonCar.Checked = False Then
            gdblColisonCharge = 2000
        End If

        If chkSatNavCar.Checked Then
            gdblSatnavprice = SatFunctionCar(nupAmountofDaysCar.Value)
            gdblTotalprice1 += gdblSatnavprice
        End If

        If chkSkiCar.Checked Then
            gdblTotalprice1 += gintSkiExtras
        End If

        If chkRoofRackCar.Checked Then
            gdblTotalprice1 += gdblRoofrack
        End If
        If chkContentsCar.Checked Then
            gdblContentsprice = calcInsuranceContentsCar(nupAmountofDaysCar.Value)
        End If
        If chkCollisonCar.Checked Then
            gdblColisonCharge = collisonTheftCalcCar(nupAmountofDaysCar.Value)
        End If
        If chkTheftCar.Checked Then
            gdblTheftprice = collisonTheftCalcCar(nupAmountofDaysCar.Value)
        End If

        gdblVehicleprice = CostOfVehicle(nupAmountofDaysCar.Value)



        gdblVehiclesandExtrasCost = gdblVehicleprice + gdblSatnavprice + gdblContentsprice + gdblRoofrack + gintSkiExtras

        gdblVatCost = VatCalc1(gdblVehiclesandExtrasCost) 'declaring a variable with the 20% vat included to the gdblVehiclesandExtrasCost variable

        gdblInsuancePrice = +gdblColisonCharge + gdblTheftprice 'adding both insurance prices together 

        gdblTotalprice1 = gdblVatCost + gdblInsuancePrice + gdblVehiclesandExtrasCost 'variable with the value of the vat, insurance, vehicles and extras


        lstPriceBreakDown.Items.Add("Vehicle price:" & (gdblVehicleprice))       'adding variables to a listbox
        lstPriceBreakDown.Items.Add("sat nav price:" & (gdblSatnavprice))
        lstPriceBreakDown.Items.Add("content insurance:" & (gdblContentsprice))
        lstPriceBreakDown.Items.Add("Ski price:" & (gintSkiExtras))
        lstPriceBreakDown.Items.Add("roof rack price:" & (gdblRoofrack))
        lstPriceBreakDown.Items.Add("contents or surcharge:" & (gdblColisonCharge))
        lstPriceBreakDown.Items.Add("Theft or surcharge:" & (gdblTheftprice))
        lstPriceBreakDown.Items.Add("Vat Charge" & (gdblVatCost))
        lstPriceBreakDown.Items.Add("Total Price:" & (gdblTotalprice1))
    End Sub



    Private Sub btnInsuranceInfo_Click(sender As Object, e As EventArgs) Handles btnInsuranceInfo.Click
        MessageBox.Show("If the customer decides not to pay for collision damage insurance or theft insurance," & Environment.NewLine &
                        " the customer is required to pay a surcharge, that is refundable on return of the undamaged vehicle. Costs: " & Environment.NewLine & "
                                               Collision Damage Waiver = €2000
                                               Theft = €3000")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstPriceBreakDown.Items.Clear()
        btnTotalPriceCar.Enabled = True
    End Sub


    'start of functions

    'all functions are being * + - or / by the nupAmountofDaysCar

    Public Function CostOfVehicle(ByVal AmountOfDays As Double) As Double  'function to get the cost of a car 
        Dim price As Double = 0                     'declaring variable with a value of 0

        While AmountOfDays > 0                      ' implementing a while loop that will continue untill the parameter amountofdays = 0
            If AmountOfDays >= gintNuberOfFortnights Then

                AmountOfDays -= gintNuberOfFortnights  'if its more then 14 or 14, it takes 14 away from the amountofdays value
                price += gdblFortNightlyRate           'adds the fortnightly rate to the variable price

            ElseIf AmountOfDays >= gintNumberOfWeeks Then

                AmountOfDays -= gintNumberOfWeeks        ' if its 7-13, it takes away 7 from the amountofdays value
                price += gdblWeeklyRate                  'adds the weekly rate to the variable price
            Else
                AmountOfDays -= gintNumberOfDays         'any value under 7 will be taking away from the amount of days
                price += gdblNightlyRate                 ' and the nightly rate will be added to the variable price, 
            End If                                       ' this continues till amount of days = 0
        End While
        Return price                                     ' price is passed back through the function with the assigned value

    End Function

    Public Function SatFunctionCar(ByVal CostOfSat As Double) As Double 'function that mulitples amount of days by 5

        Return 5 * CostOfSat
    End Function

    Public Function collisonTheftCalcCar(ByVal AmountOfDays3 As Double) As Double 'function that mulitples amount of days by 2

        Return 2 * AmountOfDays3
    End Function

    Public Function calcInsuranceContentsCar(ByVal AmountOfDays2 As Double) As Double 'smaller version of costofvehicle funtion
        Dim priceOfContent As Double = 0                                              'same function///// explained above//////
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

    Public Function VatCalc1(ByVal Vat As Double) As Double 'function that mulitples amount of days by .2, to get 20%

        Return Vat * 0.2
    End Function


    'end of functions
    '////////////////////////////////////////////////////////////////////////////////
    'section 2 radio buttons & check bos
    '////////////////////////////////////////////////////////////////////////////////
    'start of radio buttons car selection


    Private Sub rdbPoloCar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPoloCar.CheckedChanged
        If rdbPoloCar.Checked Then                                   'if polo car is selected 
            gdblNightlyRate = 37.5                                   ' nightly, weekly and fortnightly rates are assigned values
            gdblWeeklyRate = 236.25
            gdblFortNightlyRate = 448.9
            picDisplayCar.Image = My.Resources.polocar               ' which ever vehichle is selected a different picture will be assigned
            lblDisplayColourCar.Text = ("red, blue, white, orange")  ' vehicle color, fuel type and doors are assigned depending on which vehicle is selected
            lblDisplayFuelCar.Text = ("petrol")
            lblDisplaydoorsCar.Text = ("5")

        End If
    End Sub

    Private Sub rdbOpelCar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOpelCar.CheckedChanged
        If rdbOpelCar.Checked Then                                            '///explained above///
            gdblNightlyRate = 43.25
            gdblWeeklyRate = 272.48
            gdblFortNightlyRate = 517.7
            picDisplayCar.Image = My.Resources.corsaCar
            lblDisplayColourCar.Text = ("silver, green, white")
            lblDisplayFuelCar.Text = ("petrol")
            lblDisplaydoorsCar.Text = ("5")
        End If
    End Sub

    Private Sub rdbSkodaCar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSkodaCar.CheckedChanged
        If rdbSkodaCar.Checked Then                                          '///explained above///
            gdblNightlyRate = 49.7
            gdblWeeklyRate = 313.11
            gdblFortNightlyRate = 594.91
            picDisplayCar.Image = My.Resources.skodaCar
            lblDisplayColourCar.Text = ("red, green, white")
            lblDisplayFuelCar.Text = ("petrol")
            lblDisplaydoorsCar.Text = ("5")
        End If
    End Sub

    Private Sub rdbAlfaCar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAlfaCar.CheckedChanged
        If rdbAlfaCar.Checked Then                                           '///explained above///
            gdblNightlyRate = 55.3
            gdblWeeklyRate = 348.39
            gdblFortNightlyRate = 661.95
            picDisplayCar.Image = My.Resources.alfaCar
            lblDisplayColourCar.Text = ("red, blue, white")
            lblDisplayFuelCar.Text = ("Diesel")
            lblDisplaydoorsCar.Text = ("5")
        End If
    End Sub

    Private Sub rdbZafiraCar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbZafiraCar.CheckedChanged
        If rdbZafiraCar.Checked Then                                           '///explained above///
            gdblNightlyRate = 63.15
            gdblWeeklyRate = 397.85
            gdblFortNightlyRate = 755.92
            picDisplayCar.Image = My.Resources.zafiraCar
            lblDisplayColourCar.Text = ("red, pink, white")
            lblDisplayFuelCar.Text = ("Diesel")
            lblDisplaydoorsCar.Text = ("4")
        End If
    End Sub

    'end of radio buttons car selection


    'start of checkbox 
    Private Sub chkContentsCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkContentsCar.CheckedChanged
        If chkContentsCar.Checked = False Then                     'if contents insurance isnt checked the value is 0
            gdblContentsprice = 0
        End If
    End Sub

    Private Sub chkCollisonCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkCollisonCar.CheckedChanged
        If chkCollisonCar.Checked = False Then                      ' explained above
            gdblColisonCharge = 0
        End If
    End Sub

    Private Sub chkSatNavCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkSatNavCar.CheckedChanged
        If chkSatNavCar.Checked = False Then                        ' eplained above
            gdblSatnavprice = 0
        End If
    End Sub

    Private Sub chkRoofRackCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkRoofRackCar.CheckedChanged
        If chkRoofRackCar.Checked = False Then                      ' explained above
            gdblRoofrack = 0
        End If
        If chkRoofRackCar.Checked = True Then                       ' if roof rack is check the value will be 45
            gdblRoofrack = 45
        End If
    End Sub

    Private Sub chkSkiCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkSkiCar.CheckedChanged
        If chkSkiCar.Checked = False Then                           'same as roof rack above
            gdblRoofrack = 0
        End If
        If chkSkiCar.Checked = True Then
            gdblRoofrack = 78
        End If
    End Sub

    Private Sub chkChildSeatCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkChildSeatCar.CheckedChanged
        If chkChildSeatCar.Checked = False Then                      'explained above
            gdblRoofrack = 0
        End If
    End Sub

    Private Sub chkTheftCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheftCar.CheckedChanged
        If chkTheftCar.Checked = False Then                           'explained above
            gdblTheftprice = 0
        End If
    End Sub

    Private Sub nupAmountofDaysCar_ValueChanged(sender As Object, e As EventArgs) Handles nupAmountofDaysCar.ValueChanged


        Dim dblcounterC As Double = 0                    'makes sure user selects an amount of days, before they can go to the next section
        If (nupAmountofDaysCar.Text > dblcounterC Or nupAmountofDaysCar.Text = dblcounterC) Then
            btnIReceiptfrmCar.Enabled = True
        End If


    End Sub

    Private Sub btnGoBackPageCar_Click(sender As Object, e As EventArgs) Handles btnGoBackPageCar.Click

        frmCustomerDetails.Show()
        Me.Hide()

    End Sub


    ' end of checkbox 

End Class