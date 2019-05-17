<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.ckbShowPassword = New System.Windows.Forms.CheckBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.BackColor = System.Drawing.SystemColors.Control
        Me.lblIDNumber.Location = New System.Drawing.Point(62, 163)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(58, 13)
        Me.lblIDNumber.TabIndex = 0
        Me.lblIDNumber.Text = "ID Number"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.Control
        Me.lblPassword.Location = New System.Drawing.Point(62, 196)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password"
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Location = New System.Drawing.Point(169, 156)
        Me.txtIDNumber.MaxLength = 10
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtIDNumber.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(169, 196)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 3
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExit.Location = New System.Drawing.Point(70, 269)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnLogin.Location = New System.Drawing.Point(194, 269)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'ckbShowPassword
        '
        Me.ckbShowPassword.AutoSize = True
        Me.ckbShowPassword.BackColor = System.Drawing.SystemColors.Control
        Me.ckbShowPassword.Location = New System.Drawing.Point(169, 236)
        Me.ckbShowPassword.Name = "ckbShowPassword"
        Me.ckbShowPassword.Size = New System.Drawing.Size(102, 17)
        Me.ckbShowPassword.TabIndex = 4
        Me.ckbShowPassword.Text = "Show Password"
        Me.ckbShowPassword.UseVisualStyleBackColor = False
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblCompanyName.Font = New System.Drawing.Font("Monotype Corsiva", 15.0!, System.Drawing.FontStyle.Italic)
        Me.lblCompanyName.Location = New System.Drawing.Point(12, 9)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(237, 24)
        Me.lblCompanyName.TabIndex = 29
        Me.lblCompanyName.Text = "Speedy Edward’s Rental Service"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CarRentalSystem.My.Resources.Resources.loginBg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(309, 317)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.ckbShowPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtIDNumber)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblIDNumber)
        Me.Name = "frmLogin"
        Me.Text = "Login Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIDNumber As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents ckbShowPassword As CheckBox
    Friend WithEvents lblCompanyName As Label
End Class
