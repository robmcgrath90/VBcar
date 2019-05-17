Public Class frmReceipt
    Private Sub btnExitPandR_Click(sender As Object, e As EventArgs) Handles btnExitPandR.Click
        Application.Restart()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnPrint.Enabled = False ' limiting the user to one print at a time, making the list box more structured 

        ' adding variables to a listbox to display previous details, both entered and selected
        'customer details
        Me.lstReceipt.Items.Add("customers name:" & (gstrCustomersName))
        Me.lstReceipt.Items.Add("customers address:" & (gstrCustomersAddress))
        Me.lstReceipt.Items.Add("customers City:" & (gstrTownCity))
        Me.lstReceipt.Items.Add("customers county" & (gstrCounty))
        Me.lstReceipt.Items.Add("customers Number:" & (gstrContactnumber))
        Me.lstReceipt.Items.Add("License Number:" & (gstrLicenseNumber))
        Me.lstReceipt.Items.Add("Collection Date:" & (gstrCollectionDate))
        Me.lstReceipt.Items.Add("Pick Up Destination:" & (gstrPickUp))
        Me.lstReceipt.Items.Add("Drop Off Destination:" & (gstrDropOff))

        Me.lstReceipt.Items.Add("Card type:" & (gstrPaymenttype))
        Me.lstReceipt.Items.Add("Card type:" & (gstrCardNumber))

        'vehicle costs and type of vehicle
        Me.lstReceipt.Items.Add("Vehicle price:" & "£" & (gdblVehicleprice))
        Me.lstReceipt.Items.Add("sat nav price:" & "£" & (gdblSatnavprice))
        Me.lstReceipt.Items.Add("content insurance:" & "£" & (gdblContentsprice))
        Me.lstReceipt.Items.Add("Ski price:" & "£" & (gintSkiExtras))
        Me.lstReceipt.Items.Add("roof rack price:" & "£" & (gdblRoofrack))
        Me.lstReceipt.Items.Add("content or surcharge:" & "£" & (gdblColisonCharge))
        Me.lstReceipt.Items.Add("Theft or Surcharge:" & "£" & (gdblTheftprice))
        Me.lstReceipt.Items.Add("Vat Charge" & "£" & (gdblVatCost))
        'Total Price                                
        Me.lstReceipt.Items.Add("Total Price:" & (gdblTotalprice1))
        btnExitPandR.Enabled = True                                     'enable exit button so user can exit application
    End Sub

    Private Sub btnGoBackReceipt_Click(sender As Object, e As EventArgs) Handles btnGoBackReceipt.Click

        btnPrint.Enabled = True        'sets print button to enabled
        lstReceipt.Items.Clear()        'clears the receipt
        frmPaymentAndTandCs.Show()       ' loads previous section
        Me.Hide()
    End Sub

    Private Sub btnClearReceipt_Click(sender As Object, e As EventArgs) Handles btnClearReceipt.Click
        lstReceipt.Items.Clear()       'user can empthy the reciept
        btnPrint.Enabled = True         'print button will be enabled again, limiting the user to one print at a time
    End Sub

    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class