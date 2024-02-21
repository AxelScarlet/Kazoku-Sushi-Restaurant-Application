<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Category
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.mnuCategory = New System.Windows.Forms.MenuStrip()
        Me.mnuSetMeals = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAlaCarte = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBeverage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDessert = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAlaCarte = New System.Windows.Forms.Button()
        Me.btnBeverage = New System.Windows.Forms.Button()
        Me.btnDessert = New System.Windows.Forms.Button()
        Me.picAlaCarte = New System.Windows.Forms.PictureBox()
        Me.picBeverages = New System.Windows.Forms.PictureBox()
        Me.picDesserts = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picSetMeals = New System.Windows.Forms.PictureBox()
        Me.btnSetMeals = New System.Windows.Forms.Button()
        Me.btnFinishOrder = New System.Windows.Forms.Button()
        Me.btnInstruction = New System.Windows.Forms.Button()
        Me.mnuCategory.SuspendLayout()
        CType(Me.picAlaCarte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBeverages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDesserts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSetMeals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.Cornsilk
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(22, 381)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(148, 32)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CANCEL ORDER"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'mnuCategory
        '
        Me.mnuCategory.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.mnuCategory.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuCategory.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuCategory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSetMeals, Me.mnuAlaCarte, Me.mnuBeverage, Me.mnuDessert})
        Me.mnuCategory.Location = New System.Drawing.Point(0, 0)
        Me.mnuCategory.Name = "mnuCategory"
        Me.mnuCategory.Size = New System.Drawing.Size(892, 33)
        Me.mnuCategory.TabIndex = 4
        Me.mnuCategory.Text = "MenuStrip1"
        '
        'mnuSetMeals
        '
        Me.mnuSetMeals.Name = "mnuSetMeals"
        Me.mnuSetMeals.Size = New System.Drawing.Size(104, 29)
        Me.mnuSetMeals.Text = "Set Meals"
        '
        'mnuAlaCarte
        '
        Me.mnuAlaCarte.Name = "mnuAlaCarte"
        Me.mnuAlaCarte.Size = New System.Drawing.Size(99, 29)
        Me.mnuAlaCarte.Text = "Ala Carte"
        '
        'mnuBeverage
        '
        Me.mnuBeverage.Name = "mnuBeverage"
        Me.mnuBeverage.Size = New System.Drawing.Size(100, 29)
        Me.mnuBeverage.Text = "Beverage"
        '
        'mnuDessert
        '
        Me.mnuDessert.Name = "mnuDessert"
        Me.mnuDessert.Size = New System.Drawing.Size(87, 29)
        Me.mnuDessert.Text = "Dessert"
        '
        'btnAlaCarte
        '
        Me.btnAlaCarte.AutoSize = True
        Me.btnAlaCarte.BackColor = System.Drawing.Color.Cornsilk
        Me.btnAlaCarte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlaCarte.FlatAppearance.BorderSize = 0
        Me.btnAlaCarte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnAlaCarte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnAlaCarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlaCarte.Font = New System.Drawing.Font("UD Digi Kyokasho N-B", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAlaCarte.Location = New System.Drawing.Point(240, 278)
        Me.btnAlaCarte.Name = "btnAlaCarte"
        Me.btnAlaCarte.Size = New System.Drawing.Size(173, 66)
        Me.btnAlaCarte.TabIndex = 10
        Me.btnAlaCarte.Text = "ALA CARTE"
        Me.btnAlaCarte.UseVisualStyleBackColor = False
        '
        'btnBeverage
        '
        Me.btnBeverage.AutoSize = True
        Me.btnBeverage.BackColor = System.Drawing.Color.Cornsilk
        Me.btnBeverage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBeverage.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnBeverage.FlatAppearance.BorderSize = 0
        Me.btnBeverage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnBeverage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnBeverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeverage.Font = New System.Drawing.Font("UD Digi Kyokasho N-B", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnBeverage.Location = New System.Drawing.Point(433, 278)
        Me.btnBeverage.Name = "btnBeverage"
        Me.btnBeverage.Size = New System.Drawing.Size(173, 66)
        Me.btnBeverage.TabIndex = 11
        Me.btnBeverage.Text = "BEVERAGE"
        Me.btnBeverage.UseVisualStyleBackColor = False
        '
        'btnDessert
        '
        Me.btnDessert.AutoSize = True
        Me.btnDessert.BackColor = System.Drawing.Color.Cornsilk
        Me.btnDessert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDessert.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnDessert.FlatAppearance.BorderSize = 0
        Me.btnDessert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnDessert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnDessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDessert.Font = New System.Drawing.Font("UD Digi Kyokasho N-B", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDessert.Location = New System.Drawing.Point(624, 279)
        Me.btnDessert.Name = "btnDessert"
        Me.btnDessert.Size = New System.Drawing.Size(171, 66)
        Me.btnDessert.TabIndex = 12
        Me.btnDessert.Text = "DESSERT"
        Me.btnDessert.UseVisualStyleBackColor = False
        '
        'picAlaCarte
        '
        Me.picAlaCarte.Image = CType(resources.GetObject("picAlaCarte.Image"), System.Drawing.Image)
        Me.picAlaCarte.Location = New System.Drawing.Point(241, 116)
        Me.picAlaCarte.Name = "picAlaCarte"
        Me.picAlaCarte.Size = New System.Drawing.Size(170, 150)
        Me.picAlaCarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAlaCarte.TabIndex = 14
        Me.picAlaCarte.TabStop = False
        '
        'picBeverages
        '
        Me.picBeverages.Image = CType(resources.GetObject("picBeverages.Image"), System.Drawing.Image)
        Me.picBeverages.Location = New System.Drawing.Point(434, 115)
        Me.picBeverages.Name = "picBeverages"
        Me.picBeverages.Size = New System.Drawing.Size(170, 149)
        Me.picBeverages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBeverages.TabIndex = 15
        Me.picBeverages.TabStop = False
        '
        'picDesserts
        '
        Me.picDesserts.Image = CType(resources.GetObject("picDesserts.Image"), System.Drawing.Image)
        Me.picDesserts.Location = New System.Drawing.Point(625, 115)
        Me.picDesserts.Name = "picDesserts"
        Me.picDesserts.Size = New System.Drawing.Size(170, 149)
        Me.picDesserts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDesserts.TabIndex = 16
        Me.picDesserts.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("UD Digi Kyokasho N-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 54)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "MENU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picSetMeals
        '
        Me.picSetMeals.Image = CType(resources.GetObject("picSetMeals.Image"), System.Drawing.Image)
        Me.picSetMeals.Location = New System.Drawing.Point(48, 116)
        Me.picSetMeals.Name = "picSetMeals"
        Me.picSetMeals.Size = New System.Drawing.Size(170, 150)
        Me.picSetMeals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSetMeals.TabIndex = 19
        Me.picSetMeals.TabStop = False
        '
        'btnSetMeals
        '
        Me.btnSetMeals.AutoSize = True
        Me.btnSetMeals.BackColor = System.Drawing.Color.Cornsilk
        Me.btnSetMeals.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetMeals.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnSetMeals.FlatAppearance.BorderSize = 0
        Me.btnSetMeals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnSetMeals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnSetMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetMeals.Font = New System.Drawing.Font("UD Digi Kyokasho N-B", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSetMeals.Location = New System.Drawing.Point(47, 278)
        Me.btnSetMeals.Name = "btnSetMeals"
        Me.btnSetMeals.Size = New System.Drawing.Size(173, 66)
        Me.btnSetMeals.TabIndex = 18
        Me.btnSetMeals.Text = "SET MEALS"
        Me.btnSetMeals.UseVisualStyleBackColor = False
        '
        'btnFinishOrder
        '
        Me.btnFinishOrder.AutoSize = True
        Me.btnFinishOrder.BackColor = System.Drawing.Color.Cornsilk
        Me.btnFinishOrder.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnFinishOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnFinishOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnFinishOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinishOrder.Location = New System.Drawing.Point(732, 384)
        Me.btnFinishOrder.Name = "btnFinishOrder"
        Me.btnFinishOrder.Size = New System.Drawing.Size(138, 32)
        Me.btnFinishOrder.TabIndex = 34
        Me.btnFinishOrder.Text = "FINISH ORDER"
        Me.btnFinishOrder.UseVisualStyleBackColor = False
        '
        'btnInstruction
        '
        Me.btnInstruction.AutoSize = True
        Me.btnInstruction.BackColor = System.Drawing.Color.Cornsilk
        Me.btnInstruction.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnInstruction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnInstruction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnInstruction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstruction.Location = New System.Drawing.Point(346, 381)
        Me.btnInstruction.Name = "btnInstruction"
        Me.btnInstruction.Size = New System.Drawing.Size(148, 32)
        Me.btnInstruction.TabIndex = 35
        Me.btnInstruction.Text = "INSTRUCTION"
        Me.btnInstruction.UseVisualStyleBackColor = False
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(892, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnInstruction)
        Me.Controls.Add(Me.btnFinishOrder)
        Me.Controls.Add(Me.picSetMeals)
        Me.Controls.Add(Me.btnSetMeals)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picDesserts)
        Me.Controls.Add(Me.picBeverages)
        Me.Controls.Add(Me.picAlaCarte)
        Me.Controls.Add(Me.btnDessert)
        Me.Controls.Add(Me.btnBeverage)
        Me.Controls.Add(Me.btnAlaCarte)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.mnuCategory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(80, 0)
        Me.MainMenuStrip = Me.mnuCategory
        Me.Name = "Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mnuCategory.ResumeLayout(False)
        Me.mnuCategory.PerformLayout()
        CType(Me.picAlaCarte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBeverages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDesserts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSetMeals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents mnuCategory As MenuStrip
    Friend WithEvents mnuBeverage As ToolStripMenuItem
    Friend WithEvents mnuDessert As ToolStripMenuItem
    Friend WithEvents btnAlaCarte As Button
    Friend WithEvents btnBeverage As Button
    Friend WithEvents btnDessert As Button
    Friend WithEvents picAlaCarte As PictureBox
    Friend WithEvents picBeverages As PictureBox
    Friend WithEvents picDesserts As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mnuSetMeals As ToolStripMenuItem
    Friend WithEvents picSetMeals As PictureBox
    Friend WithEvents btnSetMeals As Button
    Friend WithEvents btnFinishOrder As Button
    Friend WithEvents mnuAlaCarte As ToolStripMenuItem
    Friend WithEvents btnInstruction As Button
End Class
