Public Class frmCar
    Private Sub Car_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTotalPriceCar.Click
        If chkTheftCar.Checked = False Then
            gdblTheftprice = 3000
        End If
        If chkCollisonCar.Checked = False Then
            gdblColisonCharge = 2000
        End If
        If chkSatNavCar.Checked Then
            gdblSatnavprice = SatFunctionCar(nupAmountofDaysCar.Value)  'delaring the value of satnavprice to th paramter passed through satfunction
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

        gdblVanprice = calculate2(nupAmountofDaysCar.Value)
        gdblTotalprice1 = gdblVanprice + gdblSatnavprice + gdblContentsprice + gdblColisonCharge + gdblTheftprice + gdblRoofrack + gintSkiExtras

        MessageBox.Show(gdblTotalprice1)
    End Sub

    Public Function calculate2(ByVal AmountOfDays As Double) As Double
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

    Public Function SatFunctionCar(ByVal CostOfSat As Double) As Double 'function that mulitples amount of days by 5

        Return 5 * CostOfSat
    End Function

    Public Function collisonTheftCalcCar(ByVal AmountOfDays3 As Double) As Double

        Return 2 * AmountOfDays3
    End Function

    Public Function calcInsuranceContentsCar(ByVal AmountOfDays2 As Double) As Double
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

    'start of radio buttons car selection

    Private Sub rdbPoloCar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPoloCar.CheckedChanged
        If rdbPoloCar.Checked Then
            gdblNightlyRate = 37.5
            gdblWeeklyRate = 236.25
            gdblFortNightlyRate = 448.9
            picDisplayCar.Image = My.Resources.polocar
            lblDisplayColourCar.Text = ("red, blue, white, orange")
            lblDisplayFuelCar.Text = ("petrol")
            lblDisplaydoorsCar.Text = ("5")
        End If
    End Sub

    Private Sub rdbOpelCar_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOpelCar.CheckedChanged
        If rdbOpelCar.Checked Then
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
        If rdbSkodaCar.Checked Then
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
        If rdbAlfaCar.Checked Then
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
        If rdbZafiraCar.Checked Then
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


    Private Sub txtAmountOfDaysCar_TextChanged(sender As Object, e As EventArgs)

    End Sub



    'start of checkbox multiplications 
    Private Sub chkContentsCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkContentsCar.CheckedChanged
        If chkContentsCar.Checked = False Then
            gdblContentsprice = 0
        End If
    End Sub

    Private Sub chkCollisonCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkCollisonCar.CheckedChanged
        If chkCollisonCar.Checked = False Then
            gdblColisonCharge = 0
        End If
    End Sub

    Private Sub chkSatNavCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkSatNavCar.CheckedChanged
        If chkSatNavCar.Checked = False Then
            gdblSatnavprice = 0
        End If
    End Sub

    Private Sub chkRoofRackCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkRoofRackCar.CheckedChanged
        If chkRoofRackCar.Checked = False Then
            gdblRoofrack = 0
        End If
        If chkRoofRackCar.Checked = True Then
            gdblRoofrack = 45
        End If
    End Sub

    Private Sub chkSkiCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkSkiCar.CheckedChanged
        If chkSkiCar.Checked = False Then
            gdblRoofrack = 0
        End If
        If chkSkiCar.Checked = True Then
            gdblRoofrack = 78
        End If
    End Sub

    Private Sub chkChildSeatCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkChildSeatCar.CheckedChanged
        If chkChildSeatCar.Checked = False Then
            gdblRoofrack = 0
        End If
    End Sub

    Private Sub chkTheftCar_CheckedChanged(sender As Object, e As EventArgs) Handles chkTheftCar.CheckedChanged
        If chkTheftCar.Checked = False Then
            gdblTheftprice = 0
        End If
    End Sub

    Private Sub btnIReceiptfrmCar_Click(sender As Object, e As EventArgs) Handles btnIReceiptfrmCar.Click
        'calulation code in the next section putting, as validation in case the user dosen't use the calulation button
        If chkTheftCar.Checked = False Then
            gdblTheftprice = 3000
        End If
        If chkCollisonCar.Checked = False Then
            gdblColisonCharge = 2000
        End If
        If chkSatNavCar.Checked Then
            gdblSatnavprice = SatFunctionCar(nupAmountofDaysCar.Value)  'delaring the value of satnavprice to th paramter passed through satfunction
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

        gdblVanprice = calculate2(nupAmountofDaysCar.Value)
        gdblTotalprice1 = gdblVanprice + gdblSatnavprice + gdblContentsprice + gdblColisonCharge + gdblTheftprice + gdblRoofrack + gintSkiExtras

    End Sub
    ' end of checkbox multiplications 


End Class