<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetMeals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetMeals))
        Me.picBentoSet = New System.Windows.Forms.PictureBox()
        Me.lblSetDetails = New System.Windows.Forms.Label()
        Me.mnuCategory = New System.Windows.Forms.MenuStrip()
        Me.SetMealsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAlaCarte = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBeverage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDessert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSetMeals = New System.Windows.Forms.ListBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFamilySet2 = New System.Windows.Forms.TextBox()
        Me.txtSushiSet = New System.Windows.Forms.TextBox()
        Me.txtKidsSet1 = New System.Windows.Forms.TextBox()
        Me.txtKidsSet2 = New System.Windows.Forms.TextBox()
        Me.txtFamilySet1 = New System.Windows.Forms.TextBox()
        Me.txtBentoSet = New System.Windows.Forms.TextBox()
        Me.chkFamilySet2 = New System.Windows.Forms.CheckBox()
        Me.chkFamilySet1 = New System.Windows.Forms.CheckBox()
        Me.chkKidsSet2 = New System.Windows.Forms.CheckBox()
        Me.chkKidsSet1 = New System.Windows.Forms.CheckBox()
        Me.chkSushiSet = New System.Windows.Forms.CheckBox()
        Me.chkBentoSet = New System.Windows.Forms.CheckBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.picSushiSet = New System.Windows.Forms.PictureBox()
        Me.picKidsSet1 = New System.Windows.Forms.PictureBox()
        Me.picKidsSet2 = New System.Windows.Forms.PictureBox()
        Me.picFamilySet1 = New System.Windows.Forms.PictureBox()
        Me.picFamilySet2 = New System.Windows.Forms.PictureBox()
        CType(Me.picBentoSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuCategory.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picSushiSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKidsSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKidsSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFamilySet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFamilySet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBentoSet
        '
        Me.picBentoSet.Image = CType(resources.GetObject("picBentoSet.Image"), System.Drawing.Image)
        Me.picBentoSet.Location = New System.Drawing.Point(12, 119)
        Me.picBentoSet.Name = "picBentoSet"
        Me.picBentoSet.Size = New System.Drawing.Size(229, 151)
        Me.picBentoSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBentoSet.TabIndex = 22
        Me.picBentoSet.TabStop = False
        '
        'lblSetDetails
        '
        Me.lblSetDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSetDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSetDetails.Location = New System.Drawing.Point(247, 122)
        Me.lblSetDetails.Name = "lblSetDetails"
        Me.lblSetDetails.Size = New System.Drawing.Size(135, 151)
        Me.lblSetDetails.TabIndex = 26
        Me.lblSetDetails.Text = "Rice with chicken katsu,curry and salad with iced water." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mnuCategory
        '
        Me.mnuCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mnuCategory.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuCategory.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuCategory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetMealsToolStripMenuItem, Me.mnuAlaCarte, Me.mnuBeverage, Me.mnuDessert})
        Me.mnuCategory.Location = New System.Drawing.Point(0, 0)
        Me.mnuCategory.Name = "mnuCategory"
        Me.mnuCategory.Size = New System.Drawing.Size(800, 33)
        Me.mnuCategory.TabIndex = 27
        Me.mnuCategory.Text = "MenuStrip1"
        '
        'SetMealsToolStripMenuItem
        '
        Me.SetMealsToolStripMenuItem.Name = "SetMealsToolStripMenuItem"
        Me.SetMealsToolStripMenuItem.Size = New System.Drawing.Size(104, 29)
        Me.SetMealsToolStripMenuItem.Text = "Set Meals"
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("UD Digi Kyokasho N-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 54)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Set Meals"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstSetMeals
        '
        Me.lstSetMeals.AllowDrop = True
        Me.lstSetMeals.FormattingEnabled = True
        Me.lstSetMeals.ItemHeight = 20
        Me.lstSetMeals.Items.AddRange(New Object() {"Bento Set" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "[RM   8.90]", "Sushi Set" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "[RM 13.90]", "Kids Set 1" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "[RM   8.90]", "Kids Set 2" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "[RM 12.90]", "Family Set 1 (2-3 pax)" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "[RM 25.90]", "Family Set 2 (3-4 pax)" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "[RM 29.90]"})
        Me.lstSetMeals.Location = New System.Drawing.Point(9, 276)
        Me.lstSetMeals.Name = "lstSetMeals"
        Me.lstSetMeals.Size = New System.Drawing.Size(373, 124)
        Me.lstSetMeals.TabIndex = 29
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.Lime
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(12, 442)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(114, 32)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Back"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFamilySet2)
        Me.GroupBox1.Controls.Add(Me.txtSushiSet)
        Me.GroupBox1.Controls.Add(Me.txtKidsSet1)
        Me.GroupBox1.Controls.Add(Me.txtKidsSet2)
        Me.GroupBox1.Controls.Add(Me.txtFamilySet1)
        Me.GroupBox1.Controls.Add(Me.txtBentoSet)
        Me.GroupBox1.Controls.Add(Me.chkFamilySet2)
        Me.GroupBox1.Controls.Add(Me.chkFamilySet1)
        Me.GroupBox1.Controls.Add(Me.chkKidsSet2)
        Me.GroupBox1.Controls.Add(Me.chkKidsSet1)
        Me.GroupBox1.Controls.Add(Me.chkSushiSet)
        Me.GroupBox1.Controls.Add(Me.chkBentoSet)
        Me.GroupBox1.Location = New System.Drawing.Point(400, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 333)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose based on your preferences"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(298, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "quantity"
        '
        'txtFamilySet2
        '
        Me.txtFamilySet2.Location = New System.Drawing.Point(282, 280)
        Me.txtFamilySet2.Name = "txtFamilySet2"
        Me.txtFamilySet2.Size = New System.Drawing.Size(100, 26)
        Me.txtFamilySet2.TabIndex = 11
        '
        'txtSushiSet
        '
        Me.txtSushiSet.Location = New System.Drawing.Point(282, 76)
        Me.txtSushiSet.Name = "txtSushiSet"
        Me.txtSushiSet.Size = New System.Drawing.Size(100, 26)
        Me.txtSushiSet.TabIndex = 10
        '
        'txtKidsSet1
        '
        Me.txtKidsSet1.Location = New System.Drawing.Point(282, 120)
        Me.txtKidsSet1.Name = "txtKidsSet1"
        Me.txtKidsSet1.Size = New System.Drawing.Size(100, 26)
        Me.txtKidsSet1.TabIndex = 9
        '
        'txtKidsSet2
        '
        Me.txtKidsSet2.Location = New System.Drawing.Point(282, 174)
        Me.txtKidsSet2.Name = "txtKidsSet2"
        Me.txtKidsSet2.Size = New System.Drawing.Size(100, 26)
        Me.txtKidsSet2.TabIndex = 8
        '
        'txtFamilySet1
        '
        Me.txtFamilySet1.Location = New System.Drawing.Point(282, 227)
        Me.txtFamilySet1.Name = "txtFamilySet1"
        Me.txtFamilySet1.Size = New System.Drawing.Size(100, 26)
        Me.txtFamilySet1.TabIndex = 7
        '
        'txtBentoSet
        '
        Me.txtBentoSet.Location = New System.Drawing.Point(282, 30)
        Me.txtBentoSet.Name = "txtBentoSet"
        Me.txtBentoSet.Size = New System.Drawing.Size(100, 26)
        Me.txtBentoSet.TabIndex = 6
        '
        'chkFamilySet2
        '
        Me.chkFamilySet2.AutoSize = True
        Me.chkFamilySet2.Location = New System.Drawing.Point(24, 280)
        Me.chkFamilySet2.Name = "chkFamilySet2"
        Me.chkFamilySet2.Size = New System.Drawing.Size(122, 24)
        Me.chkFamilySet2.TabIndex = 5
        Me.chkFamilySet2.Text = "Family Set 2"
        Me.chkFamilySet2.UseVisualStyleBackColor = True
        '
        'chkFamilySet1
        '
        Me.chkFamilySet1.AutoSize = True
        Me.chkFamilySet1.Location = New System.Drawing.Point(24, 229)
        Me.chkFamilySet1.Name = "chkFamilySet1"
        Me.chkFamilySet1.Size = New System.Drawing.Size(122, 24)
        Me.chkFamilySet1.TabIndex = 4
        Me.chkFamilySet1.Text = "Family Set 1"
        Me.chkFamilySet1.UseVisualStyleBackColor = True
        '
        'chkKidsSet2
        '
        Me.chkKidsSet2.AutoSize = True
        Me.chkKidsSet2.Location = New System.Drawing.Point(24, 176)
        Me.chkKidsSet2.Name = "chkKidsSet2"
        Me.chkKidsSet2.Size = New System.Drawing.Size(107, 24)
        Me.chkKidsSet2.TabIndex = 3
        Me.chkKidsSet2.Text = "Kids Set 2"
        Me.chkKidsSet2.UseVisualStyleBackColor = True
        '
        'chkKidsSet1
        '
        Me.chkKidsSet1.AutoSize = True
        Me.chkKidsSet1.Location = New System.Drawing.Point(21, 122)
        Me.chkKidsSet1.Name = "chkKidsSet1"
        Me.chkKidsSet1.Size = New System.Drawing.Size(107, 24)
        Me.chkKidsSet1.TabIndex = 2
        Me.chkKidsSet1.Text = "Kids Set 1"
        Me.chkKidsSet1.UseVisualStyleBackColor = True
        '
        'chkSushiSet
        '
        Me.chkSushiSet.AutoSize = True
        Me.chkSushiSet.Location = New System.Drawing.Point(24, 78)
        Me.chkSushiSet.Name = "chkSushiSet"
        Me.chkSushiSet.Size = New System.Drawing.Size(104, 24)
        Me.chkSushiSet.TabIndex = 1
        Me.chkSushiSet.Text = "Sushi Set"
        Me.chkSushiSet.UseVisualStyleBackColor = True
        '
        'chkBentoSet
        '
        Me.chkBentoSet.AutoSize = True
        Me.chkBentoSet.Location = New System.Drawing.Point(24, 30)
        Me.chkBentoSet.Name = "chkBentoSet"
        Me.chkBentoSet.Size = New System.Drawing.Size(107, 24)
        Me.chkBentoSet.TabIndex = 0
        Me.chkBentoSet.Text = "Bento Set"
        Me.chkBentoSet.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.AutoSize = True
        Me.btnContinue.BackColor = System.Drawing.Color.Lime
        Me.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Location = New System.Drawing.Point(661, 444)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(129, 32)
        Me.btnContinue.TabIndex = 32
        Me.btnContinue.Text = "Confirm Order"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'btnTotal
        '
        Me.btnTotal.AutoSize = True
        Me.btnTotal.BackColor = System.Drawing.Color.Lime
        Me.btnTotal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTotal.Location = New System.Drawing.Point(661, 406)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(127, 32)
        Me.btnTotal.TabIndex = 34
        Me.btnTotal.Text = "Count Order"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'picSushiSet
        '
        Me.picSushiSet.Image = CType(resources.GetObject("picSushiSet.Image"), System.Drawing.Image)
        Me.picSushiSet.Location = New System.Drawing.Point(12, 122)
        Me.picSushiSet.Name = "picSushiSet"
        Me.picSushiSet.Size = New System.Drawing.Size(229, 151)
        Me.picSushiSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSushiSet.TabIndex = 35
        Me.picSushiSet.TabStop = False
        Me.picSushiSet.Visible = False
        '
        'picKidsSet1
        '
        Me.picKidsSet1.Image = CType(resources.GetObject("picKidsSet1.Image"), System.Drawing.Image)
        Me.picKidsSet1.Location = New System.Drawing.Point(12, 122)
        Me.picKidsSet1.Name = "picKidsSet1"
        Me.picKidsSet1.Size = New System.Drawing.Size(229, 151)
        Me.picKidsSet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKidsSet1.TabIndex = 36
        Me.picKidsSet1.TabStop = False
        Me.picKidsSet1.Visible = False
        '
        'picKidsSet2
        '
        Me.picKidsSet2.Image = CType(resources.GetObject("picKidsSet2.Image"), System.Drawing.Image)
        Me.picKidsSet2.Location = New System.Drawing.Point(12, 122)
        Me.picKidsSet2.Name = "picKidsSet2"
        Me.picKidsSet2.Size = New System.Drawing.Size(229, 151)
        Me.picKidsSet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKidsSet2.TabIndex = 37
        Me.picKidsSet2.TabStop = False
        Me.picKidsSet2.Visible = False
        '
        'picFamilySet1
        '
        Me.picFamilySet1.Image = CType(resources.GetObject("picFamilySet1.Image"), System.Drawing.Image)
        Me.picFamilySet1.Location = New System.Drawing.Point(12, 119)
        Me.picFamilySet1.Name = "picFamilySet1"
        Me.picFamilySet1.Size = New System.Drawing.Size(229, 151)
        Me.picFamilySet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFamilySet1.TabIndex = 38
        Me.picFamilySet1.TabStop = False
        Me.picFamilySet1.Visible = False
        '
        'picFamilySet2
        '
        Me.picFamilySet2.Image = CType(resources.GetObject("picFamilySet2.Image"), System.Drawing.Image)
        Me.picFamilySet2.Location = New System.Drawing.Point(12, 119)
        Me.picFamilySet2.Name = "picFamilySet2"
        Me.picFamilySet2.Size = New System.Drawing.Size(229, 154)
        Me.picFamilySet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFamilySet2.TabIndex = 39
        Me.picFamilySet2.TabStop = False
        Me.picFamilySet2.Visible = False
        '
        'SetMeals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 487)
        Me.ControlBox = False
        Me.Controls.Add(Me.picFamilySet2)
        Me.Controls.Add(Me.picFamilySet1)
        Me.Controls.Add(Me.picKidsSet2)
        Me.Controls.Add(Me.picKidsSet1)
        Me.Controls.Add(Me.picSushiSet)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lstSetMeals)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mnuCategory)
        Me.Controls.Add(Me.lblSetDetails)
        Me.Controls.Add(Me.picBentoSet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(80, 0)
        Me.Name = "SetMeals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picBentoSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuCategory.ResumeLayout(False)
        Me.mnuCategory.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picSushiSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKidsSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKidsSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFamilySet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFamilySet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBentoSet As PictureBox
    Friend WithEvents lblSetDetails As Label
    Friend WithEvents mnuCategory As MenuStrip
    Friend WithEvents SetMealsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAlaCarte As ToolStripMenuItem
    Friend WithEvents mnuBeverage As ToolStripMenuItem
    Friend WithEvents mnuDessert As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents lstSetMeals As ListBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkFamilySet2 As CheckBox
    Friend WithEvents chkFamilySet1 As CheckBox
    Friend WithEvents chkKidsSet2 As CheckBox
    Friend WithEvents chkKidsSet1 As CheckBox
    Friend WithEvents chkSushiSet As CheckBox
    Friend WithEvents chkBentoSet As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFamilySet2 As TextBox
    Friend WithEvents txtSushiSet As TextBox
    Friend WithEvents txtKidsSet1 As TextBox
    Friend WithEvents txtKidsSet2 As TextBox
    Friend WithEvents txtFamilySet1 As TextBox
    Friend WithEvents txtBentoSet As TextBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents picSushiSet As PictureBox
    Friend WithEvents picKidsSet1 As PictureBox
    Friend WithEvents picKidsSet2 As PictureBox
    Friend WithEvents picFamilySet1 As PictureBox
    Friend WithEvents picFamilySet2 As PictureBox
End Class
