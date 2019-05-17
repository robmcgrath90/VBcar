Public Class frmPaymentAndReceipt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        lstReciept.Items.Add(gstrCustomersName)
        lstReciept.Items.Add(gstrCustomersAddress)
        lstReciept.Items.Add(gstrTownCity)
        lstReciept.Items.Add(gstrCounty)
        lstReciept.Items.Add(gstrContactnumber)
        lstReciept.Items.Add(gstrlicenseNumber)

        lstReciept.Items.Add("Vehicle price:" & (gdblVanprice))
        lstReciept.Items.Add("sat nav price:" & (gdblSatnavprice))
        lstReciept.Items.Add("content insurance:" & (gdblContentsprice))
        lstReciept.Items.Add("Ski price:" & (gintSkiExtras))
        lstReciept.Items.Add("roof rack price:" & (gdblRoofrack))


        lstReciept.Items.Add("Total Price:" & (gdblTotalprice1))
    End Sub
End Class

'if statement anf if its car you use one lot, if van the other
'make two buttons and two list boxes and when the user selects car or vehicle on customer form one wil be visible n other wont be
'if statemnt about the 2000 k insurance 