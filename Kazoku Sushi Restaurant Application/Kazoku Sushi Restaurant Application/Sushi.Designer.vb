<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sushi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sushi))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.picSalmonSushi = New System.Windows.Forms.PictureBox()
        Me.picEgg = New System.Windows.Forms.PictureBox()
        Me.picSalmonRoe = New System.Windows.Forms.PictureBox()
        Me.picUramaki = New System.Windows.Forms.PictureBox()
        Me.picMayo = New System.Windows.Forms.PictureBox()
        Me.picCrab = New System.Windows.Forms.PictureBox()
        Me.picTuna = New System.Windows.Forms.PictureBox()
        Me.picShrimp = New System.Windows.Forms.PictureBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalmon = New System.Windows.Forms.TextBox()
        Me.txtEgg = New System.Windows.Forms.TextBox()
        Me.txtShrimp = New System.Windows.Forms.TextBox()
        Me.txtTuna = New System.Windows.Forms.TextBox()
        Me.txtSalmonRoe = New System.Windows.Forms.TextBox()
        Me.txtUramaki = New System.Windows.Forms.TextBox()
        Me.txtMayo = New System.Windows.Forms.TextBox()
        Me.txtCrab = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCount = New System.Windows.Forms.Button()
        CType(Me.picSalmonSushi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEgg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSalmonRoe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUramaki, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMayo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCrab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTuna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShrimp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.BackColor = System.Drawing.Color.LightBlue
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(12, 402)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 36)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'picSalmonSushi
        '
        Me.picSalmonSushi.Image = CType(resources.GetObject("picSalmonSushi.Image"), System.Drawing.Image)
        Me.picSalmonSushi.Location = New System.Drawing.Point(81, 77)
        Me.picSalmonSushi.Name = "picSalmonSushi"
        Me.picSalmonSushi.Size = New System.Drawing.Size(105, 81)
        Me.picSalmonSushi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSalmonSushi.TabIndex = 47
        Me.picSalmonSushi.TabStop = False
        '
        'picEgg
        '
        Me.picEgg.Image = CType(resources.GetObject("picEgg.Image"), System.Drawing.Image)
        Me.picEgg.Location = New System.Drawing.Point(224, 77)
        Me.picEgg.Name = "picEgg"
        Me.picEgg.Size = New System.Drawing.Size(105, 81)
        Me.picEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEgg.TabIndex = 48
        Me.picEgg.TabStop = False
        '
        'picSalmonRoe
        '
        Me.picSalmonRoe.Image = CType(resources.GetObject("picSalmonRoe.Image"), System.Drawing.Image)
        Me.picSalmonRoe.Location = New System.Drawing.Point(506, 227)
        Me.picSalmonRoe.Name = "picSalmonRoe"
        Me.picSalmonRoe.Size = New System.Drawing.Size(105, 81)
        Me.picSalmonRoe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSalmonRoe.TabIndex = 49
        Me.picSalmonRoe.TabStop = False
        '
        'picUramaki
        '
        Me.picUramaki.Image = CType(resources.GetObject("picUramaki.Image"), System.Drawing.Image)
        Me.picUramaki.Location = New System.Drawing.Point(362, 227)
        Me.picUramaki.Name = "picUramaki"
        Me.picUramaki.Size = New System.Drawing.Size(105, 81)
        Me.picUramaki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUramaki.TabIndex = 50
        Me.picUramaki.TabStop = False
        '
        'picMayo
        '
        Me.picMayo.Image = CType(resources.GetObject("picMayo.Image"), System.Drawing.Image)
        Me.picMayo.Location = New System.Drawing.Point(224, 227)
        Me.picMayo.Name = "picMayo"
        Me.picMayo.Size = New System.Drawing.Size(105, 81)
        Me.picMayo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMayo.TabIndex = 51
        Me.picMayo.TabStop = False
        '
        'picCrab
        '
        Me.picCrab.Image = CType(resources.GetObject("picCrab.Image"), System.Drawing.Image)
        Me.picCrab.Location = New System.Drawing.Point(81, 227)
        Me.picCrab.Name = "picCrab"
        Me.picCrab.Size = New System.Drawing.Size(105, 81)
        Me.picCrab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCrab.TabIndex = 52
        Me.picCrab.TabStop = False
        '
        'picTuna
        '
        Me.picTuna.Image = CType(resources.GetObject("picTuna.Image"), System.Drawing.Image)
        Me.picTuna.Location = New System.Drawing.Point(506, 77)
        Me.picTuna.Name = "picTuna"
        Me.picTuna.Size = New System.Drawing.Size(105, 81)
        Me.picTuna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTuna.TabIndex = 53
        Me.picTuna.TabStop = False
        '
        'picShrimp
        '
        Me.picShrimp.Image = CType(resources.GetObject("picShrimp.Image"), System.Drawing.Image)
        Me.picShrimp.Location = New System.Drawing.Point(362, 77)
        Me.picShrimp.Name = "picShrimp"
        Me.picShrimp.Size = New System.Drawing.Size(105, 81)
        Me.picShrimp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShrimp.TabIndex = 54
        Me.picShrimp.TabStop = False
        '
        'btnConfirm
        '
        Me.btnConfirm.AutoSize = True
        Me.btnConfirm.BackColor = System.Drawing.Color.LightBlue
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(679, 402)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(109, 36)
        Me.btnConfirm.TabIndex = 55
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("UD Digi Kyokasho N-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 54)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Sushi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalmon
        '
        Me.txtSalmon.Location = New System.Drawing.Point(81, 164)
        Me.txtSalmon.Name = "txtSalmon"
        Me.txtSalmon.Size = New System.Drawing.Size(100, 26)
        Me.txtSalmon.TabIndex = 57
        Me.txtSalmon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEgg
        '
        Me.txtEgg.Location = New System.Drawing.Point(224, 164)
        Me.txtEgg.Name = "txtEgg"
        Me.txtEgg.Size = New System.Drawing.Size(100, 26)
        Me.txtEgg.TabIndex = 58
        Me.txtEgg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtShrimp
        '
        Me.txtShrimp.Location = New System.Drawing.Point(367, 164)
        Me.txtShrimp.Name = "txtShrimp"
        Me.txtShrimp.Size = New System.Drawing.Size(100, 26)
        Me.txtShrimp.TabIndex = 59
        Me.txtShrimp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTuna
        '
        Me.txtTuna.Location = New System.Drawing.Point(511, 164)
        Me.txtTuna.Name = "txtTuna"
        Me.txtTuna.Size = New System.Drawing.Size(100, 26)
        Me.txtTuna.TabIndex = 60
        Me.txtTuna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSalmonRoe
        '
        Me.txtSalmonRoe.Location = New System.Drawing.Point(506, 314)
        Me.txtSalmonRoe.Name = "txtSalmonRoe"
        Me.txtSalmonRoe.Size = New System.Drawing.Size(100, 26)
        Me.txtSalmonRoe.TabIndex = 61
        Me.txtSalmonRoe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUramaki
        '
        Me.txtUramaki.Location = New System.Drawing.Point(367, 314)
        Me.txtUramaki.Name = "txtUramaki"
        Me.txtUramaki.Size = New System.Drawing.Size(100, 26)
        Me.txtUramaki.TabIndex = 62
        Me.txtUramaki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMayo
        '
        Me.txtMayo.Location = New System.Drawing.Point(224, 314)
        Me.txtMayo.Name = "txtMayo"
        Me.txtMayo.Size = New System.Drawing.Size(100, 26)
        Me.txtMayo.TabIndex = 63
        Me.txtMayo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCrab
        '
        Me.txtCrab.Location = New System.Drawing.Point(81, 314)
        Me.txtCrab.Name = "txtCrab"
        Me.txtCrab.Size = New System.Drawing.Size(100, 26)
        Me.txtCrab.TabIndex = 64
        Me.txtCrab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("UD Digi Kyokasho N-B", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(631, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 221)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Click the picture for details and Enter numeric number in the textbox for your ch" &
    "oice" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCount
        '
        Me.btnCount.AutoSize = True
        Me.btnCount.BackColor = System.Drawing.Color.LightBlue
        Me.btnCount.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise
        Me.btnCount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCount.Location = New System.Drawing.Point(679, 360)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(109, 36)
        Me.btnCount.TabIndex = 66
        Me.btnCount.Text = "Count Order"
        Me.btnCount.UseVisualStyleBackColor = False
        '
        'Sushi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCrab)
        Me.Controls.Add(Me.txtMayo)
        Me.Controls.Add(Me.txtUramaki)
        Me.Controls.Add(Me.txtSalmonRoe)
        Me.Controls.Add(Me.txtTuna)
        Me.Controls.Add(Me.txtShrimp)
        Me.Controls.Add(Me.txtEgg)
        Me.Controls.Add(Me.txtSalmon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.picShrimp)
        Me.Controls.Add(Me.picTuna)
        Me.Controls.Add(Me.picCrab)
        Me.Controls.Add(Me.picMayo)
        Me.Controls.Add(Me.picUramaki)
        Me.Controls.Add(Me.picSalmonRoe)
        Me.Controls.Add(Me.picEgg)
        Me.Controls.Add(Me.picSalmonSushi)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(80, 0)
        Me.Name = "Sushi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picSalmonSushi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEgg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSalmonRoe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUramaki, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMayo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCrab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTuna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShrimp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents picSalmonSushi As PictureBox
    Friend WithEvents picEgg As PictureBox
    Friend WithEvents picSalmonRoe As PictureBox
    Friend WithEvents picUramaki As PictureBox
    Friend WithEvents picMayo As PictureBox
    Friend WithEvents picCrab As PictureBox
    Friend WithEvents picTuna As PictureBox
    Friend WithEvents picShrimp As PictureBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSalmon As TextBox
    Friend WithEvents txtEgg As TextBox
    Friend WithEvents txtShrimp As TextBox
    Friend WithEvents txtTuna As TextBox
    Friend WithEvents txtSalmonRoe As TextBox
    Friend WithEvents txtUramaki As TextBox
    Friend WithEvents txtMayo As TextBox
    Friend WithEvents txtCrab As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCount As Button
End Class
