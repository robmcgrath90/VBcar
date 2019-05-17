Public Class frmLogin




    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If (txtIDNumber.Text = "a" And txtPassword.Text = "1") Then
            frmCustomerDetails.Show()
            Me.Hide()
        Else
            MessageBox.Show("username or password is incorrect, please re-enter, you are currently at attempt " & gintErrorAttempts & " of 5 attempts")
            ErrorCount()
            gintErrorAttempts = gintErrorAttempts + 1
            txtIDNumber.Text = ""
            txtPassword.Text = ""
            txtIDNumber.Focus()
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'closses the form and since its the first form will exit the application
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ckbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ckbShowPassword.CheckedChanged
        If (ckbShowPassword.Checked) Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub


End Class
