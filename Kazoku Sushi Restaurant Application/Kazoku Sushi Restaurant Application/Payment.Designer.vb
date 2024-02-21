<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.lblSubTotalLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblCoupon = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.btnCoupon = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCoupon = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblCharges = New System.Windows.Forms.Label()
        Me.lblAdditionalCharges = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblRounding = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.pdReceipt = New System.Drawing.Printing.PrintDocument()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSubTotalLabel
        '
        Me.lblSubTotalLabel.Location = New System.Drawing.Point(599, 233)
        Me.lblSubTotalLabel.Name = "lblSubTotalLabel"
        Me.lblSubTotalLabel.Size = New System.Drawing.Size(85, 26)
        Me.lblSubTotalLabel.TabIndex = 0
        Me.lblSubTotalLabel.Text = "SubTotal :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(586, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Service Tax :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(601, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Discount :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(586, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 26)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total Sales :"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.White
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(690, 230)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(88, 26)
        Me.lblSubTotal.TabIndex = 7
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(690, 334)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(88, 26)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.White
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(690, 282)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(88, 26)
        Me.lblTax.TabIndex = 9
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCoupon
        '
        Me.lblCoupon.BackColor = System.Drawing.Color.White
        Me.lblCoupon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCoupon.Location = New System.Drawing.Point(690, 308)
        Me.lblCoupon.Name = "lblCoupon"
        Me.lblCoupon.Size = New System.Drawing.Size(88, 26)
        Me.lblCoupon.TabIndex = 10
        Me.lblCoupon.Text = "RM0.00"
        Me.lblCoupon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("UD Digi Kyokasho NP-B", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(276, 55)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "PAYMENT"
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(47, 429)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(126, 32)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Back"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lstReceipt
        '
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 20
        Me.lstReceipt.Location = New System.Drawing.Point(47, 99)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(316, 304)
        Me.lstReceipt.TabIndex = 32
        '
        'btnCoupon
        '
        Me.btnCoupon.AutoSize = True
        Me.btnCoupon.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCoupon.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnCoupon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnCoupon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnCoupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCoupon.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCoupon.Location = New System.Drawing.Point(649, 147)
        Me.btnCoupon.Name = "btnCoupon"
        Me.btnCoupon.Size = New System.Drawing.Size(139, 32)
        Me.btnCoupon.TabIndex = 33
        Me.btnCoupon.Text = "Enter Coupon"
        Me.btnCoupon.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Coupon Code : "
        '
        'txtCoupon
        '
        Me.txtCoupon.Location = New System.Drawing.Point(533, 115)
        Me.txtCoupon.Name = "txtCoupon"
        Me.txtCoupon.Size = New System.Drawing.Size(211, 26)
        Me.txtCoupon.TabIndex = 35
        '
        'btnPrint
        '
        Me.btnPrint.AutoSize = True
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(492, 429)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(140, 32)
        Me.btnPrint.TabIndex = 36
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lblCharges
        '
        Me.lblCharges.BackColor = System.Drawing.Color.White
        Me.lblCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCharges.Location = New System.Drawing.Point(690, 256)
        Me.lblCharges.Name = "lblCharges"
        Me.lblCharges.Size = New System.Drawing.Size(88, 26)
        Me.lblCharges.TabIndex = 38
        Me.lblCharges.Text = "RM0.00"
        Me.lblCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdditionalCharges
        '
        Me.lblAdditionalCharges.AutoSize = True
        Me.lblAdditionalCharges.Location = New System.Drawing.Point(529, 259)
        Me.lblAdditionalCharges.Name = "lblAdditionalCharges"
        Me.lblAdditionalCharges.Size = New System.Drawing.Size(155, 20)
        Me.lblAdditionalCharges.TabIndex = 37
        Me.lblAdditionalCharges.Text = "Additional Charges : "
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(545, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 26)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Rounding Adjust :"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(541, 386)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 26)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Total After Adjust :"
        '
        'lblRounding
        '
        Me.lblRounding.BackColor = System.Drawing.Color.White
        Me.lblRounding.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRounding.Location = New System.Drawing.Point(690, 360)
        Me.lblRounding.Name = "lblRounding"
        Me.lblRounding.Size = New System.Drawing.Size(88, 26)
        Me.lblRounding.TabIndex = 43
        Me.lblRounding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.BackColor = System.Drawing.Color.White
        Me.lblFinalTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalTotal.Location = New System.Drawing.Point(690, 386)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(88, 26)
        Me.lblFinalTotal.TabIndex = 44
        Me.lblFinalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pdReceipt
        '
        '
        'btnConfirm
        '
        Me.btnConfirm.AutoSize = True
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(638, 429)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(140, 32)
        Me.btnConfirm.TabIndex = 45
        Me.btnConfirm.Text = "Confirm Order"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblRounding)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblCharges)
        Me.Controls.Add(Me.lblAdditionalCharges)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtCoupon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCoupon)
        Me.Controls.Add(Me.lstReceipt)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblCoupon)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSubTotalLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(80, 0)
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubTotalLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblCoupon As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lstReceipt As ListBox
    Friend WithEvents btnCoupon As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCoupon As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblCharges As Label
    Friend WithEvents lblAdditionalCharges As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblRounding As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents pdReceipt As Printing.PrintDocument
    Friend WithEvents btnConfirm As Button
End Class
