Imports System.IO

Public Class Beverage
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Category.Show()
    End Sub
    'Price for beverages'
    Dim dblBeveragePrice() As Double = {3, 3.2, 2.5, 3.5, 0.5, 0.7}

    Dim intGreenTea As Integer
    Dim dblGreenTea As Double
    Dim intLemonTea As Integer
    Dim dblLemonTea As Double
    Dim intTropicana As Integer
    Dim dblTropicana As Double
    Dim intApple As Integer
    Dim dblApple As Double
    Dim intHotCoffee As Integer
    Dim dblHotCoffee As Double
    Dim intIcedCoffee As Integer
    Dim dblIcedCoffee As Double
    Dim intIcedWater As Integer
    Dim dblIcedWater As Double
    Dim intWarmWater As Integer
    Dim dblWarmWater As Double

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click

        If txtGreenTea.Text <> String.Empty Then
            If Not Integer.TryParse(txtGreenTea.Text, intGreenTea) Then
                DisplayError()
                txtGreenTea.Text = ""
                txtGreenTea.Focus()
                dblGreenTea = 0
            Else
                'if no error'
                dblGreenTea = intGreenTea * dblBeveragePrice(2)
            End If
        Else
            dblGreenTea = 0
        End If

        If txtLemonTea.Text <> String.Empty Then
            If Not Integer.TryParse(txtLemonTea.Text, intLemonTea) Then
                DisplayError()
                txtLemonTea.Text = ""
                txtLemonTea.Focus()
                dblLemonTea = 0
            Else
                'if no error'
                dblLemonTea = intLemonTea * dblBeveragePrice(0)
            End If
        Else
            dblLemonTea = 0
        End If

        If txtTropicana.Text <> String.Empty Then
            If Not Integer.TryParse(txtTropicana.Text, intTropicana) Then
                DisplayError()
                txtTropicana.Text = ""
                txtTropicana.Focus()
                dblTropicana = 0
            Else
                'if no error'
                dblTropicana = intTropicana * dblBeveragePrice(3)
            End If
        Else
            dblTropicana = 0
        End If

        If txtApple.Text <> String.Empty Then
            If Not Integer.TryParse(txtApple.Text, intApple) Then
                DisplayError()
                txtApple.Text = ""
                txtApple.Focus()
                dblApple = 0
            Else
                'if no error'
                dblApple = intApple * dblBeveragePrice(3)
            End If
        Else
            dblApple = 0
        End If

        If txtHotCoffee.Text <> String.Empty Then
            If Not Integer.TryParse(txtHotCoffee.Text, intHotCoffee) Then
                DisplayError()
                txtHotCoffee.Text = ""
                txtHotCoffee.Focus()
                dblHotCoffee = 0
            Else
                'if no error'
                dblHotCoffee = intHotCoffee * dblBeveragePrice(0)
            End If
        Else
            dblHotCoffee = 0
        End If

        If txtIcedCoffee.Text <> String.Empty Then
            If Not Integer.TryParse(txtIcedCoffee.Text, intIcedCoffee) Then
                DisplayError()
                txtIcedCoffee.Text = ""
                txtIcedCoffee.Focus()
                dblIcedCoffee = 0
            Else
                'if no error'
                dblIcedCoffee = intIcedCoffee * dblBeveragePrice(1)
            End If
        Else
            dblIcedCoffee = 0
        End If

        If txtIcedWater.Text <> String.Empty Then
            If Not Integer.TryParse(txtIcedWater.Text, intIcedWater) Then
                DisplayError()
                txtIcedWater.Text = ""
                txtIcedWater.Focus()
                dblIcedWater = 0
            Else
                'if no error'
                dblIcedWater = intIcedWater * dblBeveragePrice(5)
            End If
        Else
            dblIcedWater = 0
        End If

        If txtWarmWater.Text <> String.Empty Then
            If Not Integer.TryParse(txtWarmWater.Text, intWarmWater) Then
                DisplayError()
                txtWarmWater.Text = ""
                txtWarmWater.Focus()
                dblWarmWater = 0
            Else
                'if no error'
                dblWarmWater = intWarmWater * dblBeveragePrice(4)
            End If
        Else
            dblWarmWater = 0
        End If

        'Total Beverages'
        Dim dblTotalBeverage As Double
        dblTotalBeverage = dblGreenTea + dblLemonTea + dblTropicana + dblApple + dblHotCoffee + dblIcedCoffee + dblIcedWater + dblWarmWater
        MsgBox("Total is : " & dblTotalBeverage.ToString("c"))

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Select Case MsgBox("Confirm order", vbYesNo, "Confirm Order")
            Case MsgBoxResult.Yes
                If Print() = True Then
                    Me.Hide()
                    Category.Show()
                Else
                    DisplayError()
                End If
        End Select
    End Sub

    Sub DisplayError()
        MsgBox("Please make sure your input in numeric", vbOKOnly, "Error")
    End Sub

    Private Sub mnuSetMeals_Click(sender As Object, e As EventArgs) Handles mnuSetMeals.Click
        SetMeals.Show()
        Me.Hide()
    End Sub

    Private Sub mnuAlaCarte_Click(sender As Object, e As EventArgs) Handles mnuAlaCarte.Click
        AlaCarte.Show()
        Me.Hide()
    End Sub

    Private Function Print() As Boolean
        Dim blnBeverage As Boolean
        Dim BeverageFile As StreamWriter

        Dim blnGreenTea As Boolean
        Dim blnLemonTea As Boolean
        Dim blnTropicana As Boolean
        Dim blnApple As Boolean
        Dim blnHotCoffee As Boolean
        Dim blnIcedCoffee As Boolean
        Dim blnIcedWater As Boolean
        Dim blnWarmWater As Boolean
        Try
            BeverageFile = File.CreateText("Beverage.txt")


            If txtGreenTea.Text <> String.Empty Then
                If Not Integer.TryParse(txtGreenTea.Text, intGreenTea) Then
                    blnGreenTea = False
                    txtGreenTea.Text = ""
                    txtGreenTea.Focus()
                    dblGreenTea = 0
                Else
                    If txtGreenTea.Text <> "0" Then
                        'if no error'
                        blnGreenTea = True
                        dblGreenTea = intGreenTea * dblBeveragePrice(2)
                        BeverageFile.WriteLine("Iced Green Tea " & txtGreenTea.Text & "Qty")
                        BeverageFile.WriteLine(vbTab & vbTab & dblGreenTea.ToString("c"))
                    Else
                        blnGreenTea = True
                        dblGreenTea = intGreenTea * dblBeveragePrice(2)
                    End If
                End If
            Else
                dblGreenTea = 0
                blnGreenTea = True
            End If


            If txtLemonTea.Text <> String.Empty Then
                If Not Integer.TryParse(txtLemonTea.Text, intLemonTea) Then
                    blnLemonTea = False
                    txtLemonTea.Text = ""
                    txtLemonTea.Focus()
                    dblLemonTea = 0
                Else
                    If txtLemonTea.Text <> "0" Then
                        'if no error'
                        blnLemonTea = True
                        dblLemonTea = intLemonTea * dblBeveragePrice(0)
                        BeverageFile.WriteLine("Iced Lemon Tea " & txtLemonTea.Text & "Qty")
                        BeverageFile.WriteLine(vbTab & vbTab & dblLemonTea.ToString("c"))
                    Else
                        blnLemonTea = True
                        dblLemonTea = intLemonTea * dblBeveragePrice(0)
                    End If
                End If
            Else
                dblLemonTea = 0
                blnLemonTea = True
            End If


            If txtTropicana.Text <> String.Empty Then
                If Not Integer.TryParse(txtTropicana.Text, intTropicana) Then
                    blnTropicana = False
                    txtTropicana.Text = ""
                    txtTropicana.Focus()
                    dblTropicana = 0
                Else
                    If txtTropicana.Text <> "0" Then
                        'if no error'
                        blnTropicana = True
                        dblTropicana = intTropicana * dblBeveragePrice(0)
                        BeverageFile.WriteLine("Tropicana Twister " & txtTropicana.Text & "Qty")
                        BeverageFile.WriteLine(vbTab & vbTab & dblTropicana.ToString("c"))
                    Else
                        blnTropicana = True
                        dblTropicana = intTropicana * dblBeveragePrice(0)
                    End If
                End If
            Else
                dblTropicana = 0
                blnTropicana = True
            End If

            If txtApple.Text <> String.Empty Then
                If Not Integer.TryParse(txtApple.Text, intApple) Then
                    blnApple = False
                    txtApple.Text = ""
                    txtApple.Focus()
                    dblApple = 0
                Else
                    If txtApple.Text <> "0" Then
                        'if no error'
                        blnApple = True
                        dblApple = intApple * dblBeveragePrice(3)
                        BeverageFile.WriteLine("Apple Juice " & txtApple.Text & "Qty")
                        BeverageFile.WriteLine(vbTab & vbTab & dblApple.ToString("c"))
                    Else
                        'if no error'
                        blnApple = True
                        dblApple = intApple * dblBeveragePrice(3)
                    End If
                End If
            Else
                dblApple = 0
                blnApple = True
            End If


            If txtHotCoffee.Text <> String.Empty Then
                If Not Integer.TryParse(txtHotCoffee.Text, intHotCoffee) Then
                    blnHotCoffee = False
                    txtHotCoffee.Text = ""
                    txtHotCoffee.Focus()
                    dblHotCoffee = 0
                Else
                    If txtHotCoffee.Text <> "0" Then
                        'if no error' 
                        blnHotCoffee = True
                        dblHotCoffee = intHotCoffee * dblBeveragePrice(0)
                        BeverageFile.WriteLine("Hot Coffee " & txtHotCoffee.Text & "Qty")
                        BeverageFile.WriteLine(vbTab & vbTab & dblHotCoffee.ToString("c"))
                    Else
                        'if no error' 
                        blnHotCoffee = True
                        dblHotCoffee = intHotCoffee * dblBeveragePrice(0)
                    End If
                End If
            Else
                dblHotCoffee = 0
                blnHotCoffee = True
            End If


            If txtIcedCoffee.Text <> String.Empty Then
                If Not Integer.TryParse(txtIcedCoffee.Text, intIcedCoffee) Then
                    blnIcedCoffee = False
                    txtIcedCoffee.Text = ""
                    txtIcedCoffee.Focus()
                    dblIcedCoffee = 0
                Else
                    If txtIcedCoffee.Text <> "0" Then
                        'if no error'
                        blnIcedCoffee = True
                        dblIcedCoffee = intIcedCoffee * dblBeveragePrice(1)
                        BeverageFile.WriteLine("Iced Coffee " & txtIcedCoffee.Text & "Qty")
                        BeverageFile.WriteLine(vbTab & vbTab & dblIcedCoffee.ToString("c"))
                    Else
                        'if no error'
                        blnIcedCoffee = True
                        dblIcedCoffee = intIcedCoffee * dblBeveragePrice(1)
                    End If
                End If
            Else
                dblIcedCoffee = 0
                blnIcedCoffee = True
            End If


            If txtIcedWater.Text <> String.Empty Then
                If Not Integer.TryParse(txtIcedWater.Text, intIcedWater) Then
                    blnIcedWater = False
                    txtIcedWater.Text = ""
                    txtIcedWater.Focus()
                    dblIcedWater = 0
                Else
                    If txtIcedCoffee.Text <> "0" Then
                        blnIcedWater = True
                        dblIcedWater = intIcedWater * dblBeveragePrice(5)
                        BeverageFile.WriteLine("Iced Water " & txtIcedWater.Text & "Qty")
                        BeverageFile.WriteLine(vbTab & vbTab & dblIcedWater.ToString("c"))
                    Else
                        'if no error'
                        blnIcedWater = True
                        dblIcedWater = intIcedWater * dblBeveragePrice(5)
                    End If
                End If
            Else
                dblIcedWater = 0
                blnIcedWater = True
            End If

            If txtWarmWater.Text <> String.Empty Then
                If Not Integer.TryParse(txtWarmWater.Text, intWarmWater) Then
                    blnWarmWater = False
                    txtWarmWater.Text = ""
                    txtWarmWater.Focus()
                    dblWarmWater = 0
                Else
                    If txtWarmWater.Text <> "0" Then
                        'if no error'
                        blnWarmWater = True
                        dblWarmWater = intWarmWater * dblBeveragePrice(4)
                        BeverageFile.WriteLine("Warm Water " & txtWarmWater.Text & "Qty")
                        BeverageFile.WriteLine(vbTab & vbTab & dblWarmWater.ToString("c"))
                    Else
                        blnWarmWater = True
                        dblWarmWater = intWarmWater * dblBeveragePrice(4)
                    End If

                End If
            Else
                dblWarmWater = 0
                blnWarmWater = True
            End If
            'if no error'
            If blnGreenTea = True And blnLemonTea = True And blnTropicana = True And blnApple = True And blnHotCoffee = True And blnIcedCoffee = True And blnIcedWater = True And blnWarmWater = True Then
                blnBeverage = True
            Else
                blnBeverage = False
            End If
            BeverageFile.Close()
            Return blnBeverage
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub mnuDessert_Click(sender As Object, e As EventArgs) Handles mnuDessert.Click
        Dessert.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MsgBox("Iced Green Tea : " & dblBeveragePrice(2).ToString("c"))
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("Iced Lemon Tea : " & dblBeveragePrice(0).ToString("c"))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("Tropicana Twister : " & dblBeveragePrice(3).ToString("c"))
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        MsgBox("Apple Juice : " & dblBeveragePrice(3).ToString("c"))
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        MsgBox("Hot Coffee : " & dblBeveragePrice(0).ToString("c"))
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        MsgBox("Iced Coffee : " & dblBeveragePrice(1).ToString("c"))
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MsgBox("Iced Water : " & dblBeveragePrice(5).ToString("c"))
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        MsgBox("Warm Water : " & dblBeveragePrice(4).ToString("c"))
    End Sub
End Class