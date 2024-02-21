<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingDate
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
        Me.btnTimePick = New System.Windows.Forms.Button()
        Me.lblDateMessage = New System.Windows.Forms.Label()
        Me.btnConfirmDate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.radPM = New System.Windows.Forms.RadioButton()
        Me.radAM = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTimePick
        '
        Me.btnTimePick.BackColor = System.Drawing.Color.Linen
        Me.btnTimePick.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff
        Me.btnTimePick.FlatAppearance.BorderSize = 0
        Me.btnTimePick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff
        Me.btnTimePick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.btnTimePick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimePick.Location = New System.Drawing.Point(319, 141)
        Me.btnTimePick.Name = "btnTimePick"
        Me.btnTimePick.Size = New System.Drawing.Size(104, 32)
        Me.btnTimePick.TabIndex = 1
        Me.btnTimePick.Text = "Enter Date"
        Me.btnTimePick.UseVisualStyleBackColor = False
        '
        'lblDateMessage
        '
        Me.lblDateMessage.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblDateMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateMessage.Location = New System.Drawing.Point(72, 86)
        Me.lblDateMessage.Name = "lblDateMessage"
        Me.lblDateMessage.Size = New System.Drawing.Size(298, 34)
        Me.lblDateMessage.TabIndex = 2
        '
        'btnConfirmDate
        '
        Me.btnConfirmDate.BackColor = System.Drawing.Color.Linen
        Me.btnConfirmDate.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff
        Me.btnConfirmDate.FlatAppearance.BorderSize = 0
        Me.btnConfirmDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff
        Me.btnConfirmDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.btnConfirmDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmDate.Location = New System.Drawing.Point(525, 354)
        Me.btnConfirmDate.Name = "btnConfirmDate"
        Me.btnConfirmDate.Size = New System.Drawing.Size(189, 32)
        Me.btnConfirmDate.TabIndex = 3
        Me.btnConfirmDate.Text = "Confirm Date and Time"
        Me.btnConfirmDate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.Linen
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(554, 392)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(132, 32)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel Booking"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.radPM)
        Me.GroupBox1.Controls.Add(Me.radAM)
        Me.GroupBox1.Location = New System.Drawing.Point(525, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 170)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Time"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(12, 34)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 26)
        Me.txtTime.TabIndex = 2
        '
        'radPM
        '
        Me.radPM.AutoSize = True
        Me.radPM.Location = New System.Drawing.Point(12, 96)
        Me.radPM.Name = "radPM"
        Me.radPM.Size = New System.Drawing.Size(57, 24)
        Me.radPM.TabIndex = 1
        Me.radPM.Text = "PM"
        Me.radPM.UseVisualStyleBackColor = True
        '
        'radAM
        '
        Me.radAM.AutoSize = True
        Me.radAM.Checked = True
        Me.radAM.Location = New System.Drawing.Point(12, 66)
        Me.radAM.Name = "radAM"
        Me.radAM.Size = New System.Drawing.Size(58, 24)
        Me.radAM.TabIndex = 0
        Me.radAM.TabStop = True
        Me.radAM.Text = "AM"
        Me.radAM.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.lblDateMessage)
        Me.GroupBox2.Controls.Add(Me.btnTimePick)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 183)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(32, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(393, 26)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "BOOKING"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(80, 25)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 26)
        Me.txtName.TabIndex = 10
        '
        'txtPax
        '
        Me.txtPax.Location = New System.Drawing.Point(80, 57)
        Me.txtPax.Name = "txtPax"
        Me.txtPax.Size = New System.Drawing.Size(100, 26)
        Me.txtPax.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Pax :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.txtPax)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(700, 100)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Information"
        '
        'BookingDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirmDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(80, 0)
        Me.Name = "BookingDate"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTimePick As Button
    Friend WithEvents lblDateMessage As Label
    Friend WithEvents btnConfirmDate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radPM As RadioButton
    Friend WithEvents radAM As RadioButton
    Friend WithEvents txtTime As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPax As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
