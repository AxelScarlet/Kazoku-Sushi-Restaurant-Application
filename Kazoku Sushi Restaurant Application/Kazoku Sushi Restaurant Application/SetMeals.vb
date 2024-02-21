Imports System.IO

Public Class SetMeals
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Category.Show()

    End Sub

    Private Sub lstSetMeals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSetMeals.SelectedIndexChanged
        If lstSetMeals.SelectedIndex.ToString = 0 Then
            lblSetDetails.Text = "Rice with chicken katsu,curry and salad with iced water."
            picBentoSet.Visible = True
            picSushiSet.Visible = False
            picKidsSet1.Visible = False
            picKidsSet2.Visible = False
            picFamilySet1.Visible = False
            picFamilySet2.Visible = False
        ElseIf lstSetMeals.SelectedIndex.ToString = 1 Then
            lblSetDetails.Text = "A set of variety delicious sushi (including soy sauce and wasabi)"
            picSushiSet.Visible = True
            picBentoSet.Visible = False
            picKidsSet1.Visible = False
            picKidsSet2.Visible = False
            picFamilySet1.Visible = False
            picFamilySet2.Visible = False
        ElseIf lstSetMeals.SelectedIndex.ToString = 2 Then
            lblSetDetails.Text = "Smaller portion of egg fried rice with iced lemon tea(free refill)"
            picKidsSet1.Visible = True
            picSushiSet.Visible = False
            picBentoSet.Visible = False
            picKidsSet2.Visible = False
            picFamilySet1.Visible = False
            picFamilySet2.Visible = False
        ElseIf lstSetMeals.SelectedIndex.ToString = 3 Then
            lblSetDetails.Text = "White rice and Hamburg steak with iced milo(free refill)"
            picKidsSet2.Visible = True
            picSushiSet.Visible = False
            picBentoSet.Visible = False
            picKidsSet1.Visible = False
            picFamilySet1.Visible = False
            picFamilySet2.Visible = False
        ElseIf lstSetMeals.SelectedIndex.ToString = 4 Then
            lblSetDetails.Text = "1 noodles,1 donburi,a set of sushi with green tea(free refill)"
            picFamilySet1.Visible = True
            picKidsSet2.Visible = False
            picSushiSet.Visible = False
            picBentoSet.Visible = False
            picKidsSet1.Visible = False
            picFamilySet2.Visible = False
        ElseIf lstSetMeals.SelectedIndex.ToString = 5 Then
            lblSetDetails.Text = "2 donburi,1 noodles,a set of sushi with green tea(free refill)"
            picFamilySet2.Visible = True
            picKidsSet2.Visible = False
            picSushiSet.Visible = False
            picBentoSet.Visible = False
            picKidsSet1.Visible = False
            picFamilySet1.Visible = False

        End If
    End Sub

    Dim dblTotalSetFee As Double 'Count the total fee'
    Dim blnTotalSetFee As Boolean 'Confrim there is no error when confirm the display'

    'Quantity of each set'
    Dim intBentoSetQuantity As Integer
    Dim intSushiSetQuantity As Integer
    Dim intKidsSet1Quantity As Integer
    Dim intKidsSet2Quantity As Integer
    Dim intFamilySet1Quantity As Integer
    Dim intFamilySet2Quantity As Integer

    'Total price of each set'
    Dim dblTotalBentoSet As Double
    Dim dblTotalSushiSet As Double
    Dim dblTotalKidsSet1 As Double
    Dim dblTotalKidsSet2 As Double
    Dim dblTotalFamilySet1 As Double
    Dim dblTotalFamilySet2 As Double

    'Price of each set'
    Const dblBentoSetPrice As Double = 8.9
    Const dblSushiSetPrice As Double = 13.9
    Const dblKidsSet1Price As Double = 8.9
    Const dblKidsSet2Price As Double = 12.9
    Const dblFamilySet1Price As Double = 25.9
    Const dblFamilySet2Price As Double = 29.9
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        'Check the condition for bento set'
        If chkBentoSet.Checked = True Then
            If Not Integer.TryParse(txtBentoSet.Text, intBentoSetQuantity) Then
                MsgBox("Please insert numeric number on bento set", vbOKOnly, "Warning!")
                blnTotalSetFee = False
            Else
                blnTotalSetFee = True
                dblTotalBentoSet = dblBentoSetPrice * intBentoSetQuantity
            End If
        Else
            dblTotalBentoSet = 0
        End If
        If txtBentoSet.Text <> String.Empty And chkBentoSet.Checked = False Then
            MsgBox("Please tick check box for bento set!", vbOKOnly, "Warning")
        End If

        'check the condition for sushi set'
        If chkSushiSet.Checked = True Then
            If Not Integer.TryParse(txtSushiSet.Text, intSushiSetQuantity) Then
                MsgBox("Please insert numeric number on sushi set", vbOKOnly, "Warning!")
                blnTotalSetFee = False
            Else
                blnTotalSetFee = True
                dblTotalSushiSet = dblSushiSetPrice * intSushiSetQuantity
            End If
        Else
            dblTotalSushiSet = 0
        End If
        If txtSushiSet.Text <> "" And chkSushiSet.Checked = False Then
            MsgBox("Please tick check box for sushi set!", vbOKOnly, "Warning")
        End If

        'check the condition for kids set 1'
        If chkKidsSet1.Checked = True Then
            If Not Integer.TryParse(txtKidsSet1.Text, intKidsSet1Quantity) Then
                MsgBox("Please insert numeric number on kids set 1", vbOKOnly, "Warning!")
                blnTotalSetFee = False
            Else
                blnTotalSetFee = True
                dblTotalKidsSet1 = dblKidsSet1Price * intKidsSet1Quantity
            End If
        Else
            dblTotalKidsSet1 = 0
        End If
        If txtKidsSet1.Text <> "" And chkKidsSet1.Checked = False Then
            MsgBox("Please tick check box for kids set 1!", vbOKOnly, "Warning")
        End If

        'check the condition for kids set 2
        If chkKidsSet2.Checked = True Then
            If Not Integer.TryParse(txtKidsSet2.Text, intKidsSet2Quantity) Then
                MsgBox("Please insert numeric number on kids set 2", vbOKOnly, "Warning!")
                blnTotalSetFee = False
            Else
                blnTotalSetFee = True
                dblTotalKidsSet2 = dblKidsSet2Price * intKidsSet2Quantity
            End If
        Else
            dblTotalKidsSet2 = 0
        End If
        If txtKidsSet2.Text <> "" And chkKidsSet2.Checked = False Then
            MsgBox("Please tick check box for kids set 2!", vbOKOnly, "Warning")
        End If

        'check the condition for family set 1'
        If chkFamilySet1.Checked = True Then
            If Not Integer.TryParse(txtFamilySet1.Text, intFamilySet1Quantity) Then
                MsgBox("Please insert numeric number on family set 1", vbOKOnly, "Warning!")
                blnTotalSetFee = False
            Else
                blnTotalSetFee = True
                dblTotalFamilySet1 = dblFamilySet1Price * intFamilySet1Quantity
            End If
        Else
            dblTotalFamilySet1 = 0
        End If
        If txtFamilySet1.Text <> "" And chkFamilySet1.Checked = False Then
            MsgBox("Please tick check box for family set 1!", vbOKOnly, "Warning")
        End If

        'check the condition for family set 2'

        If chkFamilySet2.Checked = True Then
            If Not Integer.TryParse(txtFamilySet2.Text, intFamilySet2Quantity) Then
                MsgBox("Please insert numeric number on family set 2 set", vbOKOnly, "Warning!")
                blnTotalSetFee = False
            Else
                blnTotalSetFee = True
                dblTotalFamilySet2 = dblFamilySet2Price * intFamilySet2Quantity
            End If
        Else
            dblTotalFamilySet2 = 0
        End If
        If txtFamilySet2.Text <> String.Empty And chkFamilySet2.Checked = False Then
            MsgBox("Please tick check box for family set 2!", vbOKOnly, "Warning")
        End If

        'Display'
        dblTotalSetFee = dblTotalBentoSet + dblTotalFamilySet1 + dblTotalFamilySet2 + dblTotalKidsSet1 + dblTotalKidsSet2 + dblTotalSushiSet
        If blnTotalSetFee = True Then
            MsgBox("Total order : " & dblTotalSetFee.ToString("c"))
        End If
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Select Case MsgBox("Confirm order?", vbOKCancel, "Confirm order.")
            Case MsgBoxResult.Ok

                If Print(blnTotalSetFee) = True Then
                    Me.Hide()
                    Category.Show()
                Else
                    MsgBox("Please put your input correctly", vbOKOnly, "Error")
                End If
        End Select
    End Sub

    Private Function Print(ByRef blnSetTotalFee As Boolean) As Boolean
        Dim SetMealsFile As StreamWriter

        Try
            'Create/Recreate the file for Set Meals'
            SetMealsFile = File.CreateText("SetMeals.txt")

            'Condition for Bento Set'
            If chkBentoSet.Checked = True Then
                If txtBentoSet.Text = String.Empty Then
                    MsgBox("Please insert number or uncheck for bento set")
                    blnTotalSetFee = False

                Else
                    If Not Integer.TryParse(txtBentoSet.Text, intBentoSetQuantity) Then
                        MsgBox("Please insert numeric number on bento set", vbOKOnly, "Warning!")
                        blnTotalSetFee = False

                    Else
                        dblTotalBentoSet = dblBentoSetPrice * intBentoSetQuantity
                        SetMealsFile.WriteLine("Bento Set  " & txtBentoSet.Text & "Qty")
                        SetMealsFile.WriteLine(vbTab & vbTab & dblTotalBentoSet.ToString("c"))
                        blnTotalSetFee = True
                    End If
                End If
            End If

            'Condition for sushi set'
            If chkSushiSet.Checked = True Then
                If txtSushiSet.Text = String.Empty Then
                    MsgBox("Please insert number or uncheck for sushi set")
                    blnTotalSetFee = False

                Else
                    If Not Integer.TryParse(txtSushiSet.Text, intSushiSetQuantity) Then
                        MsgBox("Please insert numeric number on sushi set", vbOKOnly, "Warning!")
                        blnTotalSetFee = False

                    Else
                        dblTotalSushiSet = dblSushiSetPrice * intSushiSetQuantity
                        SetMealsFile.WriteLine("Sushi Set  " & txtSushiSet.Text & "Qty")
                        SetMealsFile.WriteLine(vbTab & vbTab & dblTotalSushiSet.ToString("c"))
                        blnTotalSetFee = True
                    End If
                End If
            End If

            'Condition for kids set 1'
            If chkKidsSet1.Checked = True Then
                If txtKidsSet1.Text = String.Empty Then
                    MsgBox("Please insert number or uncheck for Kids set 1")
                    blnTotalSetFee = False

                Else
                    If Not Integer.TryParse(txtKidsSet1.Text, intKidsSet1Quantity) Then
                        MsgBox("Please insert numeric number on Kids set 1", vbOKOnly, "Warning!")
                        blnTotalSetFee = False

                    Else
                        dblTotalKidsSet1 = dblKidsSet1Price * intKidsSet1Quantity
                        SetMealsFile.WriteLine("Kids Set 1 " & txtKidsSet1.Text & "Qty")
                        SetMealsFile.WriteLine(vbTab & vbTab & dblTotalKidsSet1.ToString("c"))
                        blnTotalSetFee = True
                    End If
                End If
            End If

            'Condition for kids set 2'
            If chkKidsSet2.Checked = True Then
                If txtKidsSet2.Text = String.Empty Then
                    MsgBox("Please insert number or uncheck for Kids set 2")
                    blnTotalSetFee = False

                Else
                    If Not Integer.TryParse(txtKidsSet2.Text, intKidsSet2Quantity) Then
                        MsgBox("Please insert numeric number on Kids set 2", vbOKOnly, "Warning!")
                        blnTotalSetFee = False

                    Else
                        dblTotalKidsSet2 = dblKidsSet2Price * intKidsSet2Quantity
                        SetMealsFile.WriteLine("Kids Set 2 " & txtKidsSet2.Text & "Qty")
                        SetMealsFile.WriteLine(vbTab & vbTab & dblTotalKidsSet2.ToString("c"))
                        blnTotalSetFee = True
                    End If
                End If
            End If

            'Condition for family set 1'
            If chkFamilySet1.Checked = True Then
                If txtFamilySet1.Text = String.Empty Then
                    MsgBox("Please insert number or uncheck for Family set 1")
                    blnTotalSetFee = False

                Else
                    If Not Integer.TryParse(txtFamilySet1.Text, intFamilySet1Quantity) Then
                        MsgBox("Please insert numeric number on Family set 1", vbOKOnly, "Warning!")
                        blnTotalSetFee = False

                    Else
                        dblTotalFamilySet1 = dblFamilySet1Price * intFamilySet1Quantity
                        SetMealsFile.WriteLine("Family Set 1 " & txtFamilySet1.Text & "Qty")
                        SetMealsFile.WriteLine(vbTab & vbTab & dblTotalFamilySet1.ToString("c"))
                        blnTotalSetFee = True
                    End If
                End If
            End If

            'Condition for family set 2'
            If chkFamilySet2.Checked = True Then
                If txtFamilySet2.Text = String.Empty Then
                    MsgBox("Please insert number or uncheck for Family set 2")
                    blnTotalSetFee = False

                Else
                    If Not Integer.TryParse(txtFamilySet2.Text, intFamilySet2Quantity) Then
                        MsgBox("Please insert numeric number on Family set 2", vbOKOnly, "Warning!")
                        blnTotalSetFee = False

                    Else
                        dblTotalFamilySet2 = dblFamilySet2Price * intFamilySet2Quantity
                        SetMealsFile.WriteLine("Family Set 2 " & txtFamilySet2.Text & "Qty")
                        SetMealsFile.WriteLine(vbTab & vbTab & dblTotalFamilySet2.ToString("c"))
                        blnTotalSetFee = True
                    End If
                End If
            End If

            'Saved File for Set Meals'
            If blnTotalSetFee = True Then
                SetMealsFile.Close()
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
            MsgBox("File cannot be created")
        End Try

    End Function

    Private Sub mnuAlaCarte_Click(sender As Object, e As EventArgs) Handles mnuAlaCarte.Click
        AlaCarte.Show()
        Me.Hide()
    End Sub


    Private Sub mnuBeverage_Click(sender As Object, e As EventArgs) Handles mnuBeverage.Click
        Me.Hide()
        Beverage.Show()
    End Sub

    Private Sub mnuDessert_Click(sender As Object, e As EventArgs) Handles mnuDessert.Click
        Me.Hide()
        Dessert.Show()

    End Sub

    Private Sub picFamilySet2_Click(sender As Object, e As EventArgs)

    End Sub
End Class