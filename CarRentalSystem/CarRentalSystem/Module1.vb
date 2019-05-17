Module Module1

    Public gstrLicenseNumber As String  ' decide on what 
    Public gstrContactnumber As String
    Public gstrCounty As String
    Public gstrTownCity As String
    Public gstrCustomersAddress As String
    Public gstrCustomersName As String
    Public gstrCollectionDate As String
    Public gstrPickUp As String
    Public gstrDropOff As String

    Public gdblnCar As Boolean = False
    Public gdblVan As Boolean = False

    Public gdblVat As Double

    Public gdblNightlyRate As Double     '
    Public gdblWeeklyRate As Double
    Public gdblFortNightlyRate As Double

    'Public gintAmountOfDays As Integer

    Public gintNumberOfDays As Integer = 1
    Public gintNumberOfWeeks As Integer = 7
    Public gintNuberOfFortnights As Integer = 14
    Public gdblTotalCost As Double  'where is this ?

    Public gintSkiExtras As Integer
    Public gdblVehicleprice As Double
    Public gdblRoofrack As Double
    Public gdblSatnav As Double
    Public gdblSatnavprice As Double
    Public gdblTotalprice1 As Double
    Public gdblColisonCharge As Double
    Public gdblTheftprice As Double
    Public gdblInsuancePrice As Double
    Public gdblVehiclesandExtrasCost As Double
    Public gdblVatCost As Double

    'insurance form part
    Public gdblContentsprice As Double
    Public gdblContentWeeklyRate As Double = 25
    Public gdblContentNightlyRate As Double = 5

    'Payment Form
    Public gstrPaymenttype As String
    Public gstrCardNumber As String

    'error count
    Friend gintErrorAttempts As Integer = 1

    Public Sub ErrorCount()
        If gintErrorAttempts = 5 Then
            MessageBox.Show("User has had 5 errors, you will now be logged out")
            Application.Restart()
            gintErrorAttempts = 0

        End If
    End Sub


End Module
