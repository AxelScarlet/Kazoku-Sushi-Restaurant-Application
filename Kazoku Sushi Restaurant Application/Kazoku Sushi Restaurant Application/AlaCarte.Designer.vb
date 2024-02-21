<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlaCarte
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSetDetails = New System.Windows.Forms.Label()
        Me.btnSushi = New System.Windows.Forms.Button()
        Me.mnuCategory = New System.Windows.Forms.MenuStrip()
        Me.mnuSetMeals = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAlaCarte = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBeverage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDessert = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDonburi = New System.Windows.Forms.Button()
        Me.btnNoodles = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.mnuCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("UD Digi Kyokasho N-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 54)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Ala Carte"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSetDetails
        '
        Me.lblSetDetails.BackColor = System.Drawing.Color.Aquamarine
        Me.lblSetDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSetDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetDetails.Location = New System.Drawing.Point(139, 223)
        Me.lblSetDetails.Name = "lblSetDetails"
        Me.lblSetDetails.Size = New System.Drawing.Size(156, 43)
        Me.lblSetDetails.TabIndex = 33
        Me.lblSetDetails.Text = "Choose your dish"
        Me.lblSetDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSushi
        '
        Me.btnSushi.AutoSize = True
        Me.btnSushi.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSushi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSushi.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnSushi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnSushi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnSushi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSushi.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSushi.Location = New System.Drawing.Point(21, 118)
        Me.btnSushi.Name = "btnSushi"
        Me.btnSushi.Size = New System.Drawing.Size(174, 78)
        Me.btnSushi.TabIndex = 36
        Me.btnSushi.Text = "Sushi"
        Me.btnSushi.UseVisualStyleBackColor = False
        '
        'mnuCategory
        '
        Me.mnuCategory.BackColor = System.Drawing.Color.LightSeaGreen
        Me.mnuCategory.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuCategory.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuCategory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSetMeals, Me.mnuAlaCarte, Me.mnuBeverage, Me.mnuDessert})
        Me.mnuCategory.Location = New System.Drawing.Point(0, 0)
        Me.mnuCategory.Name = "mnuCategory"
        Me.mnuCategory.Size = New System.Drawing.Size(454, 36)
        Me.mnuCategory.TabIndex = 40
        Me.mnuCategory.Text = "MenuStrip1"
        '
        'mnuSetMeals
        '
        Me.mnuSetMeals.Name = "mnuSetMeals"
        Me.mnuSetMeals.Size = New System.Drawing.Size(104, 32)
        Me.mnuSetMeals.Text = "Set Meals"
        '
        'mnuAlaCarte
        '
        Me.mnuAlaCarte.Name = "mnuAlaCarte"
        Me.mnuAlaCarte.Size = New System.Drawing.Size(99, 32)
        Me.mnuAlaCarte.Text = "Ala Carte"
        '
        'mnuBeverage
        '
        Me.mnuBeverage.Name = "mnuBeverage"
        Me.mnuBeverage.Size = New System.Drawing.Size(100, 32)
        Me.mnuBeverage.Text = "Beverage"
        '
        'mnuDessert
        '
        Me.mnuDessert.Name = "mnuDessert"
        Me.mnuDessert.Size = New System.Drawing.Size(87, 32)
        Me.mnuDessert.Text = "Dessert"
        '
        'btnDonburi
        '
        Me.btnDonburi.AutoSize = True
        Me.btnDonburi.BackColor = System.Drawing.Color.PaleGreen
        Me.btnDonburi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDonburi.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnDonburi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnDonburi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnDonburi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDonburi.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDonburi.Location = New System.Drawing.Point(126, 288)
        Me.btnDonburi.Name = "btnDonburi"
        Me.btnDonburi.Size = New System.Drawing.Size(187, 78)
        Me.btnDonburi.TabIndex = 41
        Me.btnDonburi.Text = "Donburi"
        Me.btnDonburi.UseVisualStyleBackColor = False
        '
        'btnNoodles
        '
        Me.btnNoodles.AutoSize = True
        Me.btnNoodles.BackColor = System.Drawing.Color.PaleGreen
        Me.btnNoodles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNoodles.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnNoodles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnNoodles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnNoodles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNoodles.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnNoodles.Location = New System.Drawing.Point(241, 118)
        Me.btnNoodles.Name = "btnNoodles"
        Me.btnNoodles.Size = New System.Drawing.Size(174, 78)
        Me.btnNoodles.TabIndex = 42
        Me.btnNoodles.Text = "Noodles"
        Me.btnNoodles.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.PaleGreen
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(139, 402)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(160, 36)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "BACK"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'AlaCarte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(454, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNoodles)
        Me.Controls.Add(Me.btnDonburi)
        Me.Controls.Add(Me.mnuCategory)
        Me.Controls.Add(Me.btnSushi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSetDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AlaCarte"
        Me.mnuCategory.ResumeLayout(False)
        Me.mnuCategory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSetDetails As Label
    Friend WithEvents btnSushi As Button
    Friend WithEvents mnuCategory As MenuStrip
    Friend WithEvents mnuSetMeals As ToolStripMenuItem
    Friend WithEvents mnuAlaCarte As ToolStripMenuItem
    Friend WithEvents mnuBeverage As ToolStripMenuItem
    Friend WithEvents mnuDessert As ToolStripMenuItem
    Friend WithEvents btnDonburi As Button
    Friend WithEvents btnNoodles As Button
    Friend WithEvents btnCancel As Button
End Class
