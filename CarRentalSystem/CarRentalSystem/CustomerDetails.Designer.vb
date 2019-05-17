<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCustomerStreetAddress = New System.Windows.Forms.Label()
        Me.lblTownCity = New System.Windows.Forms.Label()
        Me.lblCustomerCounty = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblDrivingLicenseNumber = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtTownCity = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.grpCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.txtCollectionDate = New System.Windows.Forms.MaskedTextBox()
        Me.cboDropoff = New System.Windows.Forms.ComboBox()
        Me.lblDropoff = New System.Windows.Forms.Label()
        Me.cboDestination = New System.Windows.Forms.ComboBox()
        Me.cboCounty = New System.Windows.Forms.ComboBox()
        Me.lblPickUp = New System.Windows.Forms.Label()
        Me.lblCollectionDate = New System.Windows.Forms.Label()
        Me.txtLicenseNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtContactNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblVehicleSelection = New System.Windows.Forms.Label()
        Me.rdoVan = New System.Windows.Forms.RadioButton()
        Me.rdoCar = New System.Windows.Forms.RadioButton()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.grpButtonsCustomerfrm = New System.Windows.Forms.GroupBox()
        Me.picCustomerDetailsPage = New System.Windows.Forms.PictureBox()
        Me.grpCustomerDetails.SuspendLayout()
        Me.grpButtonsCustomerfrm.SuspendLayout()
        CType(Me.picCustomerDetailsPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(17, 19)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(35, 13)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Name"
        '
        'lblCustomerStreetAddress
        '
        Me.lblCustomerStreetAddress.AutoSize = True
        Me.lblCustomerStreetAddress.Location = New System.Drawing.Point(17, 42)
        Me.lblCustomerStreetAddress.Name = "lblCustomerStreetAddress"
        Me.lblCustomerStreetAddress.Size = New System.Drawing.Size(76, 13)
        Me.lblCustomerStreetAddress.TabIndex = 2
        Me.lblCustomerStreetAddress.Text = "Street Address"
        '
        'lblTownCity
        '
        Me.lblTownCity.AutoSize = True
        Me.lblTownCity.Location = New System.Drawing.Point(17, 68)
        Me.lblTownCity.Name = "lblTownCity"
        Me.lblTownCity.Size = New System.Drawing.Size(56, 13)
        Me.lblTownCity.TabIndex = 4
        Me.lblTownCity.Text = "Town/City"
        '
        'lblCustomerCounty
        '
        Me.lblCustomerCounty.AutoSize = True
        Me.lblCustomerCounty.Location = New System.Drawing.Point(17, 94)
        Me.lblCustomerCounty.Name = "lblCustomerCounty"
        Me.lblCustomerCounty.Size = New System.Drawing.Size(40, 13)
        Me.lblCustomerCounty.TabIndex = 6
        Me.lblCustomerCounty.Text = "County"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(17, 120)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(84, 13)
        Me.lblPhoneNumber.TabIndex = 8
        Me.lblPhoneNumber.Text = "Contact Number"
        '
        'lblDrivingLicenseNumber
        '
        Me.lblDrivingLicenseNumber.AutoSize = True
        Me.lblDrivingLicenseNumber.Location = New System.Drawing.Point(17, 150)
        Me.lblDrivingLicenseNumber.Name = "lblDrivingLicenseNumber"
        Me.lblDrivingLicenseNumber.Size = New System.Drawing.Size(84, 13)
        Me.lblDrivingLicenseNumber.TabIndex = 10
        Me.lblDrivingLicenseNumber.Text = "License Number"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(122, 16)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(122, 42)
        Me.txtAddress.MaxLength = 50
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 2
        '
        'txtTownCity
        '
        Me.txtTownCity.Location = New System.Drawing.Point(122, 68)
        Me.txtTownCity.MaxLength = 20
        Me.txtTownCity.Name = "txtTownCity"
        Me.txtTownCity.Size = New System.Drawing.Size(100, 20)
        Me.txtTownCity.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExit.Location = New System.Drawing.Point(14, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNextPage
        '
        Me.btnNextPage.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNextPage.Location = New System.Drawing.Point(387, 19)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(84, 23)
        Me.btnNextPage.TabIndex = 14
        Me.btnNextPage.Text = "Next Section"
        Me.btnNextPage.UseVisualStyleBackColor = False
        '
        'grpCustomerDetails
        '
        Me.grpCustomerDetails.BackColor = System.Drawing.SystemColors.Control
        Me.grpCustomerDetails.Controls.Add(Me.txtCollectionDate)
        Me.grpCustomerDetails.Controls.Add(Me.cboDropoff)
        Me.grpCustomerDetails.Controls.Add(Me.lblDropoff)
        Me.grpCustomerDetails.Controls.Add(Me.cboDestination)
        Me.grpCustomerDetails.Controls.Add(Me.cboCounty)
        Me.grpCustomerDetails.Controls.Add(Me.lblPickUp)
        Me.grpCustomerDetails.Controls.Add(Me.lblCollectionDate)
        Me.grpCustomerDetails.Controls.Add(Me.txtLicenseNumber)
        Me.grpCustomerDetails.Controls.Add(Me.txtContactNumber)
        Me.grpCustomerDetails.Controls.Add(Me.lblVehicleSelection)
        Me.grpCustomerDetails.Controls.Add(Me.rdoVan)
        Me.grpCustomerDetails.Controls.Add(Me.rdoCar)
        Me.grpCustomerDetails.Controls.Add(Me.txtName)
        Me.grpCustomerDetails.Controls.Add(Me.lblCustomerName)
        Me.grpCustomerDetails.Controls.Add(Me.lblCustomerStreetAddress)
        Me.grpCustomerDetails.Controls.Add(Me.txtAddress)
        Me.grpCustomerDetails.Controls.Add(Me.txtTownCity)
        Me.grpCustomerDetails.Controls.Add(Me.lblDrivingLicenseNumber)
        Me.grpCustomerDetails.Controls.Add(Me.lblTownCity)
        Me.grpCustomerDetails.Controls.Add(Me.lblCustomerCounty)
        Me.grpCustomerDetails.Controls.Add(Me.lblPhoneNumber)
        Me.grpCustomerDetails.Location = New System.Drawing.Point(12, 12)
        Me.grpCustomerDetails.Name = "grpCustomerDetails"
        Me.grpCustomerDetails.Size = New System.Drawing.Size(267, 302)
        Me.grpCustomerDetails.TabIndex = 19
        Me.grpCustomerDetails.TabStop = False
        Me.grpCustomerDetails.Text = "Insert Customer Details Below"
        '
        'txtCollectionDate
        '
        Me.txtCollectionDate.Location = New System.Drawing.Point(122, 183)
        Me.txtCollectionDate.Mask = "00/00/0000"
        Me.txtCollectionDate.Name = "txtCollectionDate"
        Me.txtCollectionDate.Size = New System.Drawing.Size(100, 20)
        Me.txtCollectionDate.TabIndex = 7
        Me.txtCollectionDate.ValidatingType = GetType(Date)
        '
        'cboDropoff
        '
        Me.cboDropoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDropoff.FormattingEnabled = True
        Me.cboDropoff.Items.AddRange(New Object() {"Dublin Heuston train station", "Dublin Connolly train station", "Dublin Airport", "Cork train station ", "Cork Airport", "Tralee Train station", "Limerick Train station", "Galway Train station", "Sligo Train station", "Wexford Train station"})
        Me.cboDropoff.Location = New System.Drawing.Point(122, 238)
        Me.cboDropoff.Name = "cboDropoff"
        Me.cboDropoff.Size = New System.Drawing.Size(121, 21)
        Me.cboDropoff.TabIndex = 9
        '
        'lblDropoff
        '
        Me.lblDropoff.AutoSize = True
        Me.lblDropoff.Location = New System.Drawing.Point(20, 237)
        Me.lblDropoff.Name = "lblDropoff"
        Me.lblDropoff.Size = New System.Drawing.Size(101, 13)
        Me.lblDropoff.TabIndex = 20
        Me.lblDropoff.Text = "Drop off Destination"
        '
        'cboDestination
        '
        Me.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDestination.FormattingEnabled = True
        Me.cboDestination.Items.AddRange(New Object() {"Dublin Heuston train station", "Dublin Connolly train station", "Dublin Airport", "Cork train station ", "Cork Airport", "Tralee Train station", "Limerick Train station", "Galway Train station", "Sligo Train station", "Wexford Train station"})
        Me.cboDestination.Location = New System.Drawing.Point(122, 211)
        Me.cboDestination.Name = "cboDestination"
        Me.cboDestination.Size = New System.Drawing.Size(121, 21)
        Me.cboDestination.TabIndex = 8
        '
        'cboCounty
        '
        Me.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCounty.FormattingEnabled = True
        Me.cboCounty.Items.AddRange(New Object() {"Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Derry", "Donegal", "Down", "Dublin", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow"})
        Me.cboCounty.Location = New System.Drawing.Point(122, 94)
        Me.cboCounty.Name = "cboCounty"
        Me.cboCounty.Size = New System.Drawing.Size(121, 21)
        Me.cboCounty.TabIndex = 4
        '
        'lblPickUp
        '
        Me.lblPickUp.AutoSize = True
        Me.lblPickUp.Location = New System.Drawing.Point(20, 211)
        Me.lblPickUp.Name = "lblPickUp"
        Me.lblPickUp.Size = New System.Drawing.Size(101, 13)
        Me.lblPickUp.TabIndex = 14
        Me.lblPickUp.Text = "Pick Up Destination"
        '
        'lblCollectionDate
        '
        Me.lblCollectionDate.AutoSize = True
        Me.lblCollectionDate.Location = New System.Drawing.Point(22, 183)
        Me.lblCollectionDate.Name = "lblCollectionDate"
        Me.lblCollectionDate.Size = New System.Drawing.Size(79, 13)
        Me.lblCollectionDate.TabIndex = 12
        Me.lblCollectionDate.Text = "Collection Date"
        '
        'txtLicenseNumber
        '
        Me.txtLicenseNumber.Location = New System.Drawing.Point(122, 150)
        Me.txtLicenseNumber.Mask = "L0000000"
        Me.txtLicenseNumber.Name = "txtLicenseNumber"
        Me.txtLicenseNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtLicenseNumber.TabIndex = 6
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(122, 120)
        Me.txtContactNumber.Mask = "(+353) 000-0000"
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtContactNumber.TabIndex = 5
        '
        'lblVehicleSelection
        '
        Me.lblVehicleSelection.AutoSize = True
        Me.lblVehicleSelection.Location = New System.Drawing.Point(20, 264)
        Me.lblVehicleSelection.Name = "lblVehicleSelection"
        Me.lblVehicleSelection.Size = New System.Drawing.Size(69, 13)
        Me.lblVehicleSelection.TabIndex = 16
        Me.lblVehicleSelection.Text = "Vehicle Type"
        '
        'rdoVan
        '
        Me.rdoVan.AutoSize = True
        Me.rdoVan.Location = New System.Drawing.Point(199, 264)
        Me.rdoVan.Name = "rdoVan"
        Me.rdoVan.Size = New System.Drawing.Size(44, 17)
        Me.rdoVan.TabIndex = 11
        Me.rdoVan.TabStop = True
        Me.rdoVan.Text = "Van"
        Me.rdoVan.UseVisualStyleBackColor = True
        '
        'rdoCar
        '
        Me.rdoCar.AutoSize = True
        Me.rdoCar.Location = New System.Drawing.Point(122, 264)
        Me.rdoCar.Name = "rdoCar"
        Me.rdoCar.Size = New System.Drawing.Size(41, 17)
        Me.rdoCar.TabIndex = 10
        Me.rdoCar.TabStop = True
        Me.rdoCar.Text = "Car"
        Me.rdoCar.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnRestart.Location = New System.Drawing.Point(192, 19)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 23)
        Me.btnRestart.TabIndex = 13
        Me.btnRestart.Text = "Restart Application"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'grpButtonsCustomerfrm
        '
        Me.grpButtonsCustomerfrm.BackColor = System.Drawing.SystemColors.Control
        Me.grpButtonsCustomerfrm.Controls.Add(Me.btnExit)
        Me.grpButtonsCustomerfrm.Controls.Add(Me.btnNextPage)
        Me.grpButtonsCustomerfrm.Controls.Add(Me.btnRestart)
        Me.grpButtonsCustomerfrm.Location = New System.Drawing.Point(12, 320)
        Me.grpButtonsCustomerfrm.Name = "grpButtonsCustomerfrm"
        Me.grpButtonsCustomerfrm.Size = New System.Drawing.Size(487, 55)
        Me.grpButtonsCustomerfrm.TabIndex = 27
        Me.grpButtonsCustomerfrm.TabStop = False
        '
        'picCustomerDetailsPage
        '
        Me.picCustomerDetailsPage.BackgroundImage = Global.CarRentalSystem.My.Resources.Resources.customerimage
        Me.picCustomerDetailsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCustomerDetailsPage.Location = New System.Drawing.Point(285, 12)
        Me.picCustomerDetailsPage.Name = "picCustomerDetailsPage"
        Me.picCustomerDetailsPage.Size = New System.Drawing.Size(214, 302)
        Me.picCustomerDetailsPage.TabIndex = 26
        Me.picCustomerDetailsPage.TabStop = False
        '
        'frmCustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(521, 388)
        Me.Controls.Add(Me.grpButtonsCustomerfrm)
        Me.Controls.Add(Me.picCustomerDetailsPage)
        Me.Controls.Add(Me.grpCustomerDetails)
        Me.Name = "frmCustomerDetails"
        Me.Text = "CustomerDetails"
        Me.grpCustomerDetails.ResumeLayout(False)
        Me.grpCustomerDetails.PerformLayout()
        Me.grpButtonsCustomerfrm.ResumeLayout(False)
        CType(Me.picCustomerDetailsPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblCustomerStreetAddress As Label
    Friend WithEvents lblTownCity As Label
    Friend WithEvents lblCustomerCounty As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblDrivingLicenseNumber As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtTownCity As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNextPage As Button
    Friend WithEvents grpCustomerDetails As GroupBox
    Friend WithEvents lblVehicleSelection As Label
    Friend WithEvents rdoVan As RadioButton
    Friend WithEvents rdoCar As RadioButton
    Friend WithEvents txtContactNumber As MaskedTextBox
    Friend WithEvents txtLicenseNumber As MaskedTextBox
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblPickUp As Label
    Friend WithEvents lblCollectionDate As Label
    Friend WithEvents cboCounty As ComboBox
    Friend WithEvents cboDropoff As ComboBox
    Friend WithEvents lblDropoff As Label
    Friend WithEvents cboDestination As ComboBox
    Friend WithEvents txtCollectionDate As MaskedTextBox
    Friend WithEvents picCustomerDetailsPage As PictureBox
    Friend WithEvents grpButtonsCustomerfrm As GroupBox
End Class
