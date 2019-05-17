Public Class frmPaymentAndTandCs



    Private Sub frmPaymentAndReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpPaymentType.Visible = False
        btnReceiptPage.Enabled = False
    End Sub



    Private Sub cmbPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaymentType.SelectedIndexChanged
        gstrPaymenttype = cmbPaymentType.Text
        If Len(TxtCardNumber.Text) > 17 And cmbPaymentType.Text IsNot "" Then
            btnReceiptPage.Enabled = True
        End If
    End Sub

    Private Sub btnReceiptPage_Click(sender As Object, e As EventArgs) Handles btnReceiptPage.Click

        frmReceipt.Show()
        Me.Hide()
    End Sub

    Private Sub btnGoback_Click(sender As Object, e As EventArgs) Handles btnGoback.Click
        If gdblVan = True Then
            frmVan.Show()
        End If
        If gdblnCar = True Then
            frmCar.Show()
        End If
    End Sub

    Private Sub rdbYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdbYes.CheckedChanged
        grpPaymentType.Visible = True

    End Sub

    Private Sub rdbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNo.CheckedChanged
        If rdbNo.Checked Then
            grpPaymentType.Visible = False
            MessageBox.Show("Customer must agree to terms and conditcions, in order to get vehichle")
        End If
    End Sub

    Private Sub TxtCardNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TxtCardNumber.MaskInputRejected
        gstrCardNumber = TxtCardNumber.Text
        If Len(TxtCardNumber.Text) > 17 And cmbPaymentType.Text IsNot "" Then
            btnReceiptPage.Enabled = True
        End If
    End Sub
End Class


'validate card type n card number