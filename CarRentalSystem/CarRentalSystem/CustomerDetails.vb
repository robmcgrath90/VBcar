Public Class frmCustomerDetails





    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() 'exits the application
    End Sub

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        'validtion to make sure the user enters all the required information ' string.empty will check if its empty, same as text = ""
        If txtName.Text = String.Empty Or txtAddress.Text = String.Empty Or txtTownCity.Text = String.Empty Or cboCounty.Text = String.Empty Or txtContactNumber.Text = String.Empty Or Len(txtLicenseNumber.Text) < 8 And txtCollectionDate.Text = String.Empty And cboDestination.Text = String.Empty And cboDropoff.Text = String.Empty Then
            MessageBox.Show("please fill in all required fields.  you are currently at attempt " & gintErrorAttempts & " of 5 attempts")
            ErrorCount()
            gintErrorAttempts = gintErrorAttempts + 1 'add one to error count
            txtName.Focus()

        End If

        If (rdoCar.Checked And txtName.Text IsNot "" And txtAddress.Text IsNot "" And cboCounty.Text IsNot "" And txtContactNumber.Text IsNot "" And Len(txtLicenseNumber.Text) > 7 And txtCollectionDate.Text IsNot "" And cboDestination.Text IsNot "" And cboDropoff.Text IsNot "") Then 'validation to make sure the user picks either a vehicle or car
            frmCar.Show()
            Me.Hide()
            gdblnCar = True
            gdblVan = False
        End If

        If (rdoVan.Checked And txtName.Text IsNot "" And txtAddress.Text IsNot "" And cboCounty.Text IsNot "" And txtContactNumber.Text IsNot "" And Len(txtLicenseNumber.Text) > 7 And txtCollectionDate.Text IsNot "" And cboDestination.Text IsNot "" And cboDropoff.Text IsNot "") Then
            gdblnCar = False
            gdblVan = True
            frmVan.Show()
            Me.Hide()
        ElseIf (rdoVan.Checked Or rdoCar.Checked) = False Then
            MsgBox("Please select a van or car")
        End If

        gstrCustomersName = txtName.Text  ' setting the vales to variables, which will be global and used on the reciept form
        gstrCustomersAddress = txtAddress.Text
        gstrTownCity = txtTownCity.Text
        gstrCounty = cboCounty.Text
        gstrContactnumber = txtContactNumber.Text
        gstrLicenseNumber = txtLicenseNumber.Text
        gstrCollectionDate = txtCollectionDate.Text
        gstrPickUp = cboDestination.Text
        gstrDropOff = cboDropoff.Text


    End Sub




    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Application.Restart()
    End Sub




    'validation to make sure user enters in the required information
    Private Sub txtLicenseNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtLicenseNumber.MaskInputRejected
        txtLicenseNumber.SelectionStart = 0
        If Len(txtLicenseNumber.Text) < 8 Then
            MessageBox.Show("Licence number must be formatted," & Environment.NewLine & "one lettter followed by seven numbers" & Environment.NewLine & "example [A1234567]")
        End If

    End Sub



    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        If txtAddress.Text = "" Then
            MessageBox.Show("please fill in street address again")
        End If
    End Sub

    Private Sub txtTownCity_TextChanged(sender As Object, e As EventArgs) Handles txtTownCity.TextChanged
        If txtTownCity.Text = "" Then
            MessageBox.Show("please fill in Town/city")
        End If
    End Sub

    Private Sub cboCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCounty.SelectedIndexChanged
        If cboCounty.Text = "" Then
            MessageBox.Show("please select a County")
        End If
    End Sub

    Private Sub txtContactNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtContactNumber.MaskInputRejected
        'change to lenght 
    End Sub

    Private Sub txtCollectionDate_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtCollectionDate.MaskInputRejected

    End Sub


    'following code is from youtube, but i added to it
    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 And Asc(e.KeyChar) < 32 Or Asc(e.KeyChar) > 32 And Asc(e.KeyChar) < 39 Or
            Asc(e.KeyChar) > 39 And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
            e.Handled = True
            MessageBox.Show("please select a letter or ' ")

        End If
    End Sub

    Private Sub frmCustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'end of referenced code
    'https://www.youtube.com/watch?v=xDop5pCelB8&index=11&list=PLDWXkSNB175IxpiRDpY4_lNPlja-LBF2w
End Class