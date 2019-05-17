<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentAndTandCs
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
        Me.grpPaymentType = New System.Windows.Forms.GroupBox()
        Me.btnGoback = New System.Windows.Forms.Button()
        Me.btnReceiptPage = New System.Windows.Forms.Button()
        Me.TxtCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.cmbPaymentType = New System.Windows.Forms.ComboBox()
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.grpTandCs = New System.Windows.Forms.GroupBox()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbYes = New System.Windows.Forms.RadioButton()
        Me.lblAgree = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpPaymentType.SuspendLayout()
        Me.grpTandCs.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPaymentType
        '
        Me.grpPaymentType.Controls.Add(Me.btnGoback)
        Me.grpPaymentType.Controls.Add(Me.btnReceiptPage)
        Me.grpPaymentType.Controls.Add(Me.TxtCardNumber)
        Me.grpPaymentType.Controls.Add(Me.PictureBox1)
        Me.grpPaymentType.Controls.Add(Me.cmbPaymentType)
        Me.grpPaymentType.Controls.Add(Me.lblCardNumber)
        Me.grpPaymentType.Controls.Add(Me.lblPaymentType)
        Me.grpPaymentType.Location = New System.Drawing.Point(12, 251)
        Me.grpPaymentType.Name = "grpPaymentType"
        Me.grpPaymentType.Size = New System.Drawing.Size(494, 191)
        Me.grpPaymentType.TabIndex = 0
        Me.grpPaymentType.TabStop = False
        Me.grpPaymentType.Text = "Payment Type"
        '
        'btnGoback
        '
        Me.btnGoback.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnGoback.Location = New System.Drawing.Point(15, 153)
        Me.btnGoback.Name = "btnGoback"
        Me.btnGoback.Size = New System.Drawing.Size(75, 23)
        Me.btnGoback.TabIndex = 5
        Me.btnGoback.Text = "back"
        Me.btnGoback.UseVisualStyleBackColor = False
        '
        'btnReceiptPage
        '
        Me.btnReceiptPage.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnReceiptPage.Location = New System.Drawing.Point(401, 153)
        Me.btnReceiptPage.Name = "btnReceiptPage"
        Me.btnReceiptPage.Size = New System.Drawing.Size(75, 23)
        Me.btnReceiptPage.TabIndex = 6
        Me.btnReceiptPage.Text = "Summary"
        Me.btnReceiptPage.UseVisualStyleBackColor = False
        '
        'TxtCardNumber
        '
        Me.TxtCardNumber.Location = New System.Drawing.Point(102, 81)
        Me.TxtCardNumber.Mask = "0000-0000-0000-0000"
        Me.TxtCardNumber.Name = "TxtCardNumber"
        Me.TxtCardNumber.Size = New System.Drawing.Size(121, 20)
        Me.TxtCardNumber.TabIndex = 4
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentType.FormattingEnabled = True
        Me.cmbPaymentType.Items.AddRange(New Object() {"MasterCard", "Visa", "Laser"})
        Me.cmbPaymentType.Location = New System.Drawing.Point(102, 27)
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.Size = New System.Drawing.Size(121, 21)
        Me.cmbPaymentType.TabIndex = 3
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.Location = New System.Drawing.Point(12, 81)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(69, 13)
        Me.lblCardNumber.TabIndex = 8
        Me.lblCardNumber.Text = "Card Number"
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Location = New System.Drawing.Point(12, 30)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(75, 13)
        Me.lblPaymentType.TabIndex = 7
        Me.lblPaymentType.Text = "Payment Type"
        '
        'grpTandCs
        '
        Me.grpTandCs.Controls.Add(Me.rdbNo)
        Me.grpTandCs.Controls.Add(Me.rdbYes)
        Me.grpTandCs.Controls.Add(Me.lblAgree)
        Me.grpTandCs.Controls.Add(Me.ListBox1)
        Me.grpTandCs.Location = New System.Drawing.Point(12, 12)
        Me.grpTandCs.Name = "grpTandCs"
        Me.grpTandCs.Size = New System.Drawing.Size(494, 234)
        Me.grpTandCs.TabIndex = 1
        Me.grpTandCs.TabStop = False
        Me.grpTandCs.Text = "Terms and Conditions"
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.Location = New System.Drawing.Point(248, 206)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(39, 17)
        Me.rdbNo.TabIndex = 2
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "No"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbYes
        '
        Me.rdbYes.AutoSize = True
        Me.rdbYes.Location = New System.Drawing.Point(180, 206)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(43, 17)
        Me.rdbYes.TabIndex = 1
        Me.rdbYes.TabStop = True
        Me.rdbYes.Text = "Yes"
        Me.rdbYes.UseVisualStyleBackColor = True
        '
        'lblAgree
        '
        Me.lblAgree.AutoSize = True
        Me.lblAgree.Location = New System.Drawing.Point(12, 206)
        Me.lblAgree.Name = "lblAgree"
        Me.lblAgree.Size = New System.Drawing.Size(147, 13)
        Me.lblAgree.TabIndex = 3
        Me.lblAgree.Text = "Do you agree to the T and Cs"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"The Collision Damage Waiver (CDW) option limits your financial liability", " for damage to the Speedy Edward’s Rental Service vehicle, its parts and", " accessories, except theft, attempted theft or vandalism, provided the ", "vehicle is used in accordance with the terms and conditions of the rental", "agreement. If CDW is declined, you will be responsible for damage up to the full " &
                "", "value of the vehicle, ranging from EUR 15,000.00 (including tax) to EUR 55,000.00" &
                "", " (including tax) depending on the vehicle rented. If you decide not to purchase C" &
                "DW,", " you will be required to provide a security of EUR 2,000.00 at the commencement o" &
                "f ", "the rental using your credit card.This amount will be used towards any damage to " &
                "the", " rented vehicle. The Theft Protection (TP) option limits your financial liability" &
                ",", " subject to the terms of the rental agreement, for loss or theft", "of the Speedy TM vehicle, its parts and accessories, provided the vehicle ", "is used in accordance with the terms and conditions of the rental agreement.", " If TP is declined, you will be responsible for the cost of repairing or replacin" &
                "g ", "the Speedy Edward’s Rental Service vehicle lost or damaged, following theft,", " attempted theft or vandalism up to the full value of the vehicle, ranging from", "EUR 15,000.00 (including tax) to EUR 55,000.00 (including tax) depending on the v" &
                "ehicle", "rented. If you decide not to purchase TP, you will be required to provide a secur" &
                "ity of EUR", "2,000.00 at the commencement of the rental using your credit card.  ", "This amount will be used towards the loss of the rented vehicle."})
        Me.ListBox1.Location = New System.Drawing.Point(15, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(461, 173)
        Me.ListBox1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CarRentalSystem.My.Resources.Resources.cardlogic_payments
        Me.PictureBox1.Location = New System.Drawing.Point(269, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmPaymentAndTandCs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 462)
        Me.Controls.Add(Me.grpTandCs)
        Me.Controls.Add(Me.grpPaymentType)
        Me.Name = "frmPaymentAndTandCs"
        Me.Text = "T and Cs and Payment Type"
        Me.grpPaymentType.ResumeLayout(False)
        Me.grpPaymentType.PerformLayout()
        Me.grpTandCs.ResumeLayout(False)
        Me.grpTandCs.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpPaymentType As GroupBox
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents lblCardNumber As Label
    Friend WithEvents cmbPaymentType As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReceiptPage As Button
    Friend WithEvents TxtCardNumber As MaskedTextBox
    Friend WithEvents grpTandCs As GroupBox
    Friend WithEvents btnGoback As Button
    Friend WithEvents lblAgree As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents rdbYes As RadioButton
    Friend WithEvents rdbNo As RadioButton
End Class
