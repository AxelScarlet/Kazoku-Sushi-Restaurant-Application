Imports System.IO
Public Class Sushi
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Dim strSushiName() As String = {"Salmon Sushi", "Rolled Egg Sushi", "Shrimp Sushi", "Tuna Sushi roll", "Crab Sushi", "Egg Mayo Sushi", "Uramaki", "Salmon Roe Sushi"}
    Dim dblSushiPrice() As Double = {2, 2.4, 2.6, 2.9, 3.2}

    Sub DisplayError()
        MsgBox("Please make sure your input in numeric", vbOKOnly, "Error")
    End Sub
    Private Sub picSalmonSushi_Click(sender As Object, e As EventArgs) Handles picSalmonSushi.Click
        MsgBox(strSushiName(0) & " : " & dblSushiPrice(1).ToString("c"), vbOKOnly, "Price")
    End Sub

    Private Sub picEgg_Click(sender As Object, e As EventArgs) Handles picEgg.Click
        MsgBox(strSushiName(1) & " : " & dblSushiPrice(0).ToString("c"), vbOKOnly, "Price")
    End Sub

    Private Sub picShrimp_Click(sender As Object, e As EventArgs) Handles picShrimp.Click
        MsgBox(strSushiName(2) & " : " & dblSushiPrice(2).ToString("c"), vbOKOnly, "Price")
    End Sub

    Private Sub picTuna_Click(sender As Object, e As EventArgs) Handles picTuna.Click
        MsgBox(strSushiName(3) & " : " & dblSushiPrice(3).ToString("c"), vbOKOnly, "Price")
    End Sub

    Private Sub picCrab_Click(sender As Object, e As EventArgs) Handles picCrab.Click
        MsgBox(strSushiName(4) & " : " & dblSushiPrice(2).ToString("c"), vbOKOnly, "Price")
    End Sub

    Private Sub picMayo_Click(sender As Object, e As EventArgs) Handles picMayo.Click
        MsgBox(strSushiName(5) & " : " & dblSushiPrice(4).ToString("c"), vbOKOnly, "Price")
    End Sub

    Private Sub picUramaki_Click(sender As Object, e As EventArgs) Handles picUramaki.Click
        MsgBox(strSushiName(6) & " : " & dblSushiPrice(3).ToString("c"), vbOKOnly, "Price")
    End Sub

    Private Sub picSalmonRoe_Click(sender As Object, e As EventArgs) Handles picSalmonRoe.Click
        MsgBox(strSushiName(7) & " : " & dblSushiPrice(3).ToString("c"), vbOKOnly, "Price")
    End Sub

    'Quantity'
    Dim intSalmonQuantity As Integer
    Dim intEggQuantity As Integer
    Dim intShrimpQuantity As Integer
    Dim intTunaQuantity As Integer
    Dim intCrabQuantity As Integer
    Dim intMayoQuantity As Integer
    Dim intUramakiQuantity As Integer
    Dim intSalmonRoeQuantity As Integer
    'Total Price*Quantity'
    Dim dblTotalSalmon As Double
    Dim dblTotalEgg As Double
    Dim dblTotalShrimp As Double
    Dim dblTotalTuna As Double
    Dim dblTotalCrab As Double
    Dim dblTotalMayo As Double
    Dim dblTotalUramaki As Double
    Dim dblTotalSalmonRoe As Double
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click

        'Calculation for Salmon Sushi'
        If txtSalmon.Text <> String.Empty Then
            If Not Integer.TryParse(txtSalmon.Text, intSalmonQuantity) Then
                DisplayError()
                txtSalmon.Text = ""
                txtSalmon.Focus()
                dblTotalSalmon = 0
            Else
                'if no error'
                dblTotalSalmon = intSalmonQuantity * dblSushiPrice(1)
            End If
        Else
            dblTotalSalmon = 0
        End If

        'Calculation for Egg Sushi'
        If txtEgg.Text <> String.Empty Then
            If Not Integer.TryParse(txtEgg.Text, intEggQuantity) Then
                DisplayError()
                txtEgg.Text = ""
                txtEgg.Focus()
                dblTotalEgg = 0
            Else
                'if no error'
                dblTotalEgg = intEggQuantity * dblSushiPrice(0)
            End If
        Else
            dblTotalEgg = 0
        End If

        'Calculation for Shrimp Sushi'
        If txtShrimp.Text <> String.Empty Then
            If Not Integer.TryParse(txtShrimp.Text, intShrimpQuantity) Then
                DisplayError()
                txtShrimp.Text = ""
                txtShrimp.Focus()
                dblTotalShrimp = 0
            Else
                'if no error'
                dblTotalShrimp = intShrimpQuantity * dblSushiPrice(2)
            End If
        Else
            dblTotalShrimp = 0
        End If

        'Calculation for Tuna Sushi Roll'
        If txtTuna.Text <> String.Empty Then
            If Not Integer.TryParse(txtTuna.Text, intTunaQuantity) Then
                DisplayError()
                txtTuna.Text = ""
                txtTuna.Focus()
                dblTotalTuna = 0
            Else
                'if no error'
                dblTotalTuna = intTunaQuantity * dblSushiPrice(3)
            End If
        Else
            dblTotalTuna = 0
        End If

        'Calculation for Crab Sushi'
        If txtCrab.Text <> String.Empty Then
            If Not Integer.TryParse(txtCrab.Text, intCrabQuantity) Then
                DisplayError()
                txtCrab.Text = ""
                txtCrab.Focus()
                dblTotalCrab = 0
            Else
                'if no error'
                dblTotalCrab = intCrabQuantity * dblSushiPrice(2)
            End If
        Else
            dblTotalCrab = 0
        End If

        'Calculation for Egg Mayo Sushi'
        If txtMayo.Text <> String.Empty Then
            If Not Integer.TryParse(txtMayo.Text, intMayoQuantity) Then
                DisplayError()
                txtMayo.Text = ""
                txtMayo.Focus()
                dblTotalMayo = 0
            Else
                'if no error'
                dblTotalMayo = intMayoQuantity * dblSushiPrice(4)
            End If
        Else
            dblTotalMayo = 0
        End If

        'Calculation for Uramaki'
        If txtUramaki.Text <> String.Empty Then
            If Not Integer.TryParse(txtUramaki.Text, intUramakiQuantity) Then
                DisplayError()
                txtUramaki.Text = ""
                txtUramaki.Focus()
                dblTotalUramaki = 0
            Else
                'if no error'
                dblTotalUramaki = intUramakiQuantity * dblSushiPrice(3)
            End If
        Else
            dblTotalUramaki = 0
        End If

        'Calculation for Salmon roe Sushi'
        If txtSalmonRoe.Text <> String.Empty Then
            If Not Integer.TryParse(txtSalmonRoe.Text, intSalmonRoeQuantity) Then
                DisplayError()
                txtSalmonRoe.Text = ""
                txtSalmonRoe.Focus()
                dblTotalSalmonRoe = 0
            Else
                'if no error'
                dblTotalSalmonRoe = intSalmonRoeQuantity * dblSushiPrice(3)
            End If
        Else
            dblTotalSalmonRoe = 0
        End If
        'Total All'
        Dim dblTotalSushi As Double 'All sushi total'
        dblTotalSushi = dblTotalSalmon + dblTotalEgg + dblTotalShrimp + dblTotalTuna + dblTotalCrab + dblTotalMayo + dblTotalUramaki + dblTotalSalmonRoe
        MsgBox("Total order : " & dblTotalSushi.ToString("c"))
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Select Case MsgBox("Confirm order", vbYesNo, "Confirm Order")
            Case MsgBoxResult.Yes
                If Print() = True Then
                    Me.Hide()
                End If
        End Select
    End Sub

    Private Function Print() As Boolean
        Dim blnSushi As Boolean
        Dim SushiFile As StreamWriter
        Try
            SushiFile = File.CreateText("Sushi.txt")

            'Condition for Salmon sushi'
            If txtSalmon.Text <> String.Empty Then
                If Not Integer.TryParse(txtSalmon.Text, intSalmonQuantity) Then
                    DisplayError()
                    txtSalmon.Text = ""
                    txtSalmon.Focus()
                    dblTotalSalmon = 0
                    blnSushi = False
                Else
                    If txtSalmon.Text < "0" Then
                        'if no error'
                        dblTotalSalmon = intSalmonQuantity * dblSushiPrice(1)
                        blnSushi = True
                        SushiFile.WriteLine(strSushiName(0) & "  " & txtSalmon.Text & "Qty")
                        SushiFile.WriteLine(vbTab & vbTab & dblTotalSalmon.ToString("c"))
                    Else
                        dblTotalSalmon = intSalmonQuantity * dblSushiPrice(1)
                        blnSushi = True
                    End If
                End If
            Else
                dblTotalSalmon = 0
                blnSushi = True
            End If

            'Condition for Egg Sushi'
            If txtEgg.Text <> String.Empty Then
                If Not Integer.TryParse(txtEgg.Text, intEggQuantity) Then
                    DisplayError()
                    txtEgg.Text = ""
                    txtEgg.Focus()
                    dblTotalEgg = 0
                    blnSushi = False
                Else
                    If txtEgg.Text <> "0" Then
                        'if no error'
                        dblTotalEgg = intEggQuantity * dblSushiPrice(0)
                        blnSushi = True
                        SushiFile.WriteLine(strSushiName(1) & "  " & txtEgg.Text & "Qty")
                        SushiFile.WriteLine(vbTab & vbTab & dblTotalEgg.ToString("c"))
                    Else
                        dblTotalEgg = intEggQuantity * dblSushiPrice(0)
                        blnSushi = True
                    End If
                End If
            Else
                dblTotalEgg = 0
                blnSushi = True
            End If

            'Condition for Shrimp Sushi'
            If txtShrimp.Text <> String.Empty Then
                If Not Integer.TryParse(txtShrimp.Text, intShrimpQuantity) Then
                    DisplayError()
                    txtShrimp.Text = ""
                    txtShrimp.Focus()
                    dblTotalShrimp = 0
                    blnSushi = False
                Else
                    'if no error'
                    dblTotalShrimp = intShrimpQuantity * dblSushiPrice(2)
                    blnSushi = True
                    SushiFile.WriteLine(strSushiName(2) & "  " & txtShrimp.Text & "Qty")
                    SushiFile.WriteLine(vbTab & vbTab & dblTotalShrimp.ToString("c"))
                End If
            Else
                dblTotalShrimp = 0
                blnSushi = True
            End If

            'Conditon for Tuna Sushi Roll'
            If txtTuna.Text <> String.Empty Then
                If Not Integer.TryParse(txtTuna.Text, intTunaQuantity) Then
                    DisplayError()
                    txtTuna.Text = ""
                    txtTuna.Focus()
                    dblTotalTuna = 0
                    blnSushi = False
                Else
                    If txtTuna.Text <> "0" Then
                        'if no error'
                        dblTotalTuna = intTunaQuantity * dblSushiPrice(3)
                        blnSushi = True
                        SushiFile.WriteLine(strSushiName(3) & "  " & txtTuna.Text & "Qty")
                        SushiFile.WriteLine(vbTab & vbTab & dblTotalTuna.ToString("c"))
                    Else
                        dblTotalTuna = intTunaQuantity * dblSushiPrice(3)
                        blnSushi = True
                    End If
                End If
            Else
                dblTotalTuna = 0
                blnSushi = True
            End If

            'Condition for Crab Sushi'
            If txtCrab.Text <> String.Empty Then
                If Not Integer.TryParse(txtCrab.Text, intCrabQuantity) Then
                    DisplayError()
                    txtCrab.Text = ""
                    txtCrab.Focus()
                    dblTotalCrab = 0
                    blnSushi = False
                Else
                    If txtCrab.Text Then
                        dblTotalCrab = intCrabQuantity * dblSushiPrice(2)
                        SushiFile.WriteLine(strSushiName(4) & "  " & txtCrab.Text & "Qty")
                        SushiFile.WriteLine(vbTab & vbTab & dblTotalCrab.ToString("c"))
                        blnSushi = True
                    Else
                        dblTotalCrab = intCrabQuantity * dblSushiPrice(2)
                        blnSushi = True
                    End If
                    'if no error'
                    dblTotalCrab = intCrabQuantity * dblSushiPrice(2)
                    blnSushi = True
                End If
            Else
                dblTotalCrab = 0
                blnSushi = True
            End If

            'Condition for Egg Mayo Sushi'
            If txtMayo.Text <> String.Empty Then
                If Not Integer.TryParse(txtMayo.Text, intMayoQuantity) Then
                    DisplayError()
                    txtMayo.Text = ""
                    txtMayo.Focus()
                    dblTotalMayo = 0
                    blnSushi = False
                Else
                    If txtMayo.Text <> "0" Then
                        'if no error'
                        dblTotalMayo = intMayoQuantity * dblSushiPrice(4)
                        blnSushi = True
                        SushiFile.WriteLine(strSushiName(5) & "  " & txtMayo.Text & "Qty")
                        SushiFile.WriteLine(vbTab & vbTab & dblTotalMayo.ToString("c"))
                    Else
                        dblTotalMayo = intMayoQuantity * dblSushiPrice(4)
                        blnSushi = True
                    End If
                End If
            Else
                dblTotalMayo = 0
                blnSushi = True
            End If

            'Condition for Uramaki'
            If txtUramaki.Text <> String.Empty Then
                If Not Integer.TryParse(txtUramaki.Text, intUramakiQuantity) Then
                    DisplayError()
                    txtUramaki.Text = ""
                    txtUramaki.Focus()
                    dblTotalUramaki = 0
                    blnSushi = False
                Else
                    If txtUramaki.Text <> "0" Then
                        blnSushi = True
                        dblTotalUramaki = intUramakiQuantity * dblSushiPrice(3)
                        SushiFile.WriteLine(strSushiName(6) & "  " & txtUramaki.Text & "Qty")
                        SushiFile.WriteLine(vbTab & vbTab & dblTotalUramaki.ToString("c"))
                    Else
                        blnSushi = True
                        dblTotalUramaki = intUramakiQuantity * dblSushiPrice(3)
                    End If
                End If
            Else
                dblTotalUramaki = 0
                blnSushi = True
            End If

            'Condition for Salmon roe Sushi'
            If txtSalmonRoe.Text <> String.Empty Then
                If Not Integer.TryParse(txtSalmonRoe.Text, intSalmonRoeQuantity) Then
                    DisplayError()
                    txtSalmonRoe.Text = ""
                    txtSalmonRoe.Focus()
                    dblTotalSalmonRoe = 0
                    blnSushi = False
                Else
                    If txtSalmonRoe.Text <> "0" Then
                        'if no error'
                        dblTotalSalmonRoe = intSalmonRoeQuantity * dblSushiPrice(3)
                        blnSushi = True
                        SushiFile.WriteLine(strSushiName(7) & "  " & txtSalmonRoe.Text & "Qty")
                        SushiFile.WriteLine(vbTab & vbTab & dblTotalSalmonRoe.ToString("c"))
                    Else
                        dblTotalSalmonRoe = intSalmonRoeQuantity * dblSushiPrice(3)
                        blnSushi = True
                    End If
                End If
            Else
                dblTotalSalmonRoe = 0
                blnSushi = True
            End If


            'if no error'
            If blnSushi = True Then
                SushiFile.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("File cannot be created")
            Return False
        End Try

    End Function

End Class