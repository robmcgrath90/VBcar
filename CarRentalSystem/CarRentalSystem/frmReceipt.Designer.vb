<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReceipt
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
        Me.grpReceipt = New System.Windows.Forms.GroupBox()
        Me.btnClearReceipt = New System.Windows.Forms.Button()
        Me.btnGoBackReceipt = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.btnExitPandR = New System.Windows.Forms.Button()
        Me.grpReceipt.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpReceipt
        '
        Me.grpReceipt.BackColor = System.Drawing.SystemColors.Control
        Me.grpReceipt.Controls.Add(Me.btnClearReceipt)
        Me.grpReceipt.Controls.Add(Me.btnGoBackReceipt)
        Me.grpReceipt.Controls.Add(Me.btnPrint)
        Me.grpReceipt.Controls.Add(Me.lstReceipt)
        Me.grpReceipt.Controls.Add(Me.btnExitPandR)
        Me.grpReceipt.Location = New System.Drawing.Point(12, 12)
        Me.grpReceipt.Name = "grpReceipt"
        Me.grpReceipt.Size = New System.Drawing.Size(460, 345)
        Me.grpReceipt.TabIndex = 2
        Me.grpReceipt.TabStop = False
        Me.grpReceipt.Text = "Receipt"
        '
        'btnClearReceipt
        '
        Me.btnClearReceipt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnClearReceipt.Location = New System.Drawing.Point(105, 316)
        Me.btnClearReceipt.Name = "btnClearReceipt"
        Me.btnClearReceipt.Size = New System.Drawing.Size(99, 22)
        Me.btnClearReceipt.TabIndex = 2
        Me.btnClearReceipt.Text = "Clear Reciept"
        Me.btnClearReceipt.UseVisualStyleBackColor = False
        '
        'btnGoBackReceipt
        '
        Me.btnGoBackReceipt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnGoBackReceipt.Location = New System.Drawing.Point(7, 316)
        Me.btnGoBackReceipt.Name = "btnGoBackReceipt"
        Me.btnGoBackReceipt.Size = New System.Drawing.Size(75, 23)
        Me.btnGoBackReceipt.TabIndex = 1
        Me.btnGoBackReceipt.Text = "Go Back"
        Me.btnGoBackReceipt.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPrint.Location = New System.Drawing.Point(226, 316)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(106, 23)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print Receipt"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lstReceipt
        '
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.Location = New System.Drawing.Point(6, 19)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(443, 290)
        Me.lstReceipt.TabIndex = 0
        '
        'btnExitPandR
        '
        Me.btnExitPandR.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExitPandR.Location = New System.Drawing.Point(374, 316)
        Me.btnExitPandR.Name = "btnExitPandR"
        Me.btnExitPandR.Size = New System.Drawing.Size(75, 23)
        Me.btnExitPandR.TabIndex = 4
        Me.btnExitPandR.Text = "Exit"
        Me.btnExitPandR.UseVisualStyleBackColor = False
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(488, 369)
        Me.Controls.Add(Me.grpReceipt)
        Me.Name = "frmReceipt"
        Me.Text = "frmReceipt"
        Me.grpReceipt.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpReceipt As GroupBox
    Friend WithEvents btnExitPandR As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lstReceipt As ListBox
    Friend WithEvents btnGoBackReceipt As Button
    Friend WithEvents btnClearReceipt As Button
End Class
