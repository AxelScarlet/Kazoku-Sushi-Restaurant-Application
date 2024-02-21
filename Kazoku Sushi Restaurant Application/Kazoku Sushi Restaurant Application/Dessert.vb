Imports System.IO

Public Class Dessert
    Dim dblDessertPrice() As Double = {3, 5, 6, 8.9}
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("Chocolate Ice Cream : " & dblDessertPrice(0).ToString("c"))
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("Vanilla Ice Cream : " & dblDessertPrice(0).ToString("c"))
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MsgBox("Okonomiyaki : " & dblDessertPrice(2).ToString("c"))
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MsgBox("Pavlova : " & dblDessertPrice(2).ToString("c"))
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        MsgBox("Japanese Cake : " & dblDessertPrice(3).ToString("c"))
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        MsgBox("Takoyaki : " & dblDessertPrice(1).ToString("c"))
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Category.Show()
    End Sub

    Sub DisplayError()
        MsgBox("Please make sure your input in numeric", vbOKOnly, "Error")
    End Sub

    Dim intCIceCream As Integer
    Dim dblCIceCream As Double
    Dim intVIceCream As Integer
    Dim dblVIceCream As Double
    Dim intOkonomiyaki As Integer
    Dim dblOkonomiyaki As Double
    Dim intPavlova As Integer
    Dim dblPavlova As Double
    Dim intCake As Integer
    Dim dblCake As Double
    Dim intTakoyaki As Integer
    Dim dblTakoyaki As Double

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click

        If txtCIceCream.Text <> String.Empty Then
            If Not Integer.TryParse(txtCIceCream.Text, intCIceCream) Then
                DisplayError()
                txtCIceCream.Text = ""
                txtCIceCream.Focus()
                dblCIceCream = 0
            Else
                'if no error'
                dblCIceCream = intCIceCream * dblDessertPrice(0)
            End If
        Else
            dblCIceCream = 0
        End If

        If txtVIceCream.Text <> String.Empty Then
            If Not Integer.TryParse(txtVIceCream.Text, intVIceCream) Then
                DisplayError()
                txtVIceCream.Text = ""
                txtVIceCream.Focus()
                dblVIceCream = 0
            Else
                'if no error'
                dblVIceCream = intVIceCream * dblDessertPrice(0)
            End If
        Else
            dblVIceCream = 0
        End If

        If txtOkonomiyaki.Text <> String.Empty Then
            If Not Integer.TryParse(txtOkonomiyaki.Text, intOkonomiyaki) Then
                DisplayError()
                txtOkonomiyaki.Text = ""
                txtOkonomiyaki.Focus()
                dblOkonomiyaki = 0
            Else
                'if no error'
                dblOkonomiyaki = intOkonomiyaki * dblDessertPrice(2)
            End If
        Else
            dblOkonomiyaki = 0
        End If

        If txtPavlova.Text <> String.Empty Then
            If Not Integer.TryParse(txtPavlova.Text, intPavlova) Then
                DisplayError()
                txtPavlova.Text = ""
                txtPavlova.Focus()
                dblPavlova = 0
            Else
                'if no error'
                dblPavlova = intPavlova * dblDessertPrice(2)
            End If
        Else
            dblPavlova = 0
        End If

        If txtCake.Text <> String.Empty Then
            If Not Integer.TryParse(txtCake.Text, intCake) Then
                DisplayError()
                txtCake.Text = ""
                txtCake.Focus()
                dblCake = 0
            Else
                'if no error'
                dblCake = intCake * dblDessertPrice(3)
            End If
        Else
            dblCake = 0
        End If

        If txtTakoyaki.Text <> String.Empty Then
            If Not Integer.TryParse(txtTakoyaki.Text, intTakoyaki) Then
                DisplayError()
                txtTakoyaki.Text = ""
                txtTakoyaki.Focus()
                dblTakoyaki = 0
            Else
                'if no error'
                dblTakoyaki = intTakoyaki * dblDessertPrice(1)
            End If
        Else
            dblTakoyaki = 0
        End If

        'Total Desserts'
        Dim dblTotalDessert As Double
        dblTotalDessert = dblCIceCream + dblVIceCream + dblOkonomiyaki + dblPavlova + dblCake + dblTakoyaki
        MsgBox("Total is : " & dblTotalDessert.ToString("c"))

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

    Private Function Print() As Boolean
        Dim blnDessert As Boolean
        Dim DessertFile As StreamWriter
        Dim intCIceCream As Integer
        Dim dblCIceCream As Double
        Dim intVIceCream As Integer
        Dim dblVIceCream As Double
        Dim intOkonomiyaki As Integer
        Dim dblOkonomiyaki As Double
        Dim intPavlova As Integer
        Dim dblPavlova As Double
        Dim intCake As Integer
        Dim dblCake As Double
        Dim intTakoyaki As Integer
        Dim dblTakoyaki As Double
        Dim blnCIceCream As Boolean
        Dim blnVIceCream As Boolean
        Dim blnOkonomiyaki As Boolean
        Dim blnPavlova As Boolean
        Dim blnCake As Boolean
        Dim blnTakoyaki As Boolean
        Try
            DessertFile = File.CreateText("Dessert.txt")


            If txtCIceCream.Text <> String.Empty Then
                If Not Integer.TryParse(txtCIceCream.Text, intCIceCream) Then
                    blnCIceCream = False
                    txtCIceCream.Text = ""
                    txtCIceCream.Focus()
                    dblCIceCream = 0
                Else
                    If txtCIceCream.Text <> "0" Then
                        'if no error'
                        blnCIceCream = True
                        dblCIceCream = intCIceCream * dblDessertPrice(0)
                        DessertFile.WriteLine("Chocolate Ice Cream " & txtCIceCream.Text & "Qty")
                        DessertFile.WriteLine(vbTab & vbTab & dblCIceCream.ToString("c"))
                    Else
                        blnCIceCream = True
                        dblCIceCream = intCIceCream * dblDessertPrice(0)
                    End If
                End If
            Else
                dblCIceCream = 0
                blnCIceCream = True
            End If


            If txtVIceCream.Text <> String.Empty Then
                If Not Integer.TryParse(txtVIceCream.Text, intVIceCream) Then
                    blnVIceCream = False
                    txtVIceCream.Text = ""
                    txtVIceCream.Focus()
                    dblVIceCream = 0
                Else
                    If txtVIceCream.Text <> "0" Then
                        'if no error'
                        blnVIceCream = True
                        dblVIceCream = intVIceCream * dblDessertPrice(0)
                        DessertFile.WriteLine("Vanilla Ice Cream " & txtVIceCream.Text & "Qty")
                        DessertFile.WriteLine(vbTab & vbTab & dblVIceCream.ToString("c"))
                    Else
                        blnVIceCream = True
                        dblVIceCream = intVIceCream * dblDessertPrice(0)
                    End If
                End If
            Else
                dblVIceCream = 0
                blnVIceCream = True
            End If


            If txtOkonomiyaki.Text <> String.Empty Then
                If Not Integer.TryParse(txtOkonomiyaki.Text, intOkonomiyaki) Then
                    blnOkonomiyaki = False
                    txtOkonomiyaki.Text = ""
                    txtOkonomiyaki.Focus()
                    dblOkonomiyaki = 0
                Else
                    If txtOkonomiyaki.Text <> "0" Then

                        'if no error'
                        blnOkonomiyaki = True
                        dblOkonomiyaki = intOkonomiyaki * dblDessertPrice(2)
                        DessertFile.WriteLine("Okonomiyaki " & txtOkonomiyaki.Text & "Qty")
                        DessertFile.WriteLine(vbTab & vbTab & dblOkonomiyaki.ToString("c"))
                    Else
                        'if no error'
                        blnOkonomiyaki = True
                        dblOkonomiyaki = intOkonomiyaki * dblDessertPrice(2)
                    End If
                End If
            Else
                dblOkonomiyaki = 0
                blnOkonomiyaki = True
            End If
            If txtPavlova.Text <> String.Empty Then
                If Not Integer.TryParse(txtPavlova.Text, intPavlova) Then
                    blnPavlova = False
                    txtPavlova.Text = ""
                    txtPavlova.Focus()
                    dblPavlova = 0
                Else
                    If txtPavlova.Text <> "0" Then
                        'if no error'
                        blnPavlova = True
                        dblPavlova = intPavlova * dblDessertPrice(2)
                        DessertFile.WriteLine("Pavlova " & txtPavlova.Text & "Qty")
                        DessertFile.WriteLine(vbTab & vbTab & dblPavlova.ToString("c"))
                    Else
                        blnPavlova = True
                        dblPavlova = intPavlova * dblDessertPrice(2)
                    End If

                End If
            Else
                dblPavlova = 0
                blnPavlova = True
            End If

            If txtCake.Text <> String.Empty Then
                If Not Integer.TryParse(txtCake.Text, intCake) Then
                    blnCake = False
                    txtCake.Text = ""
                    txtCake.Focus()
                    dblCake = 0
                Else
                    If txtCake.Text <> "0" Then
                        blnCake = True
                        dblCake = intCake * dblDessertPrice(3)
                        DessertFile.WriteLine("Japanese Cake " & txtCake.Text & "Qty")
                        DessertFile.WriteLine(vbTab & vbTab & dblCake.ToString("c"))
                    Else
                        blnCake = True
                        dblCake = intCake * dblDessertPrice(3)
                    End If
                End If
            Else
                dblCake = 0
                blnCake = True
            End If


            If txtTakoyaki.Text <> String.Empty Then
                If Not Integer.TryParse(txtTakoyaki.Text, intTakoyaki) Then
                    blnTakoyaki = False
                    txtTakoyaki.Text = ""
                    txtTakoyaki.Focus()
                    dblTakoyaki = 0
                Else
                    If txtTakoyaki.Text <> "0" Then
                        'if no error'
                        blnTakoyaki = True
                        dblTakoyaki = intTakoyaki * dblDessertPrice(1)
                        DessertFile.WriteLine("Takoyaki " & txtTakoyaki.Text & "Qty")
                        DessertFile.WriteLine(vbTab & vbTab & dblTakoyaki.ToString("c"))
                    Else

                        blnTakoyaki = True
                        dblTakoyaki = intTakoyaki * dblDessertPrice(1)
                    End If
                    'if no error'
                End If
            Else
                dblTakoyaki = 0
                blnTakoyaki = True
            End If

            'if no error'
            If blnCIceCream = True And blnVIceCream = True And blnOkonomiyaki = True And blnPavlova = True And blnCake = True And blnTakoyaki = True Then
                blnDessert = True
            Else
                blnDessert = False
            End If
            DessertFile.Close()
            Return blnDessert
        Catch ex As Exception
            Return False
        End Try

    End Function



    Private Sub mnuSetMeals_Click(sender As Object, e As EventArgs) Handles mnuSetMeals.Click
        SetMeals.Show()
        Me.Hide()
    End Sub

    Private Sub mnuAlaCarte_Click(sender As Object, e As EventArgs) Handles mnuAlaCarte.Click
        AlaCarte.Show()
        Me.Hide()
    End Sub

    Private Sub mnuBeverage_Click(sender As Object, e As EventArgs) Handles mnuBeverage.Click
        Beverage.Show()
        Me.Hide()
    End Sub
End Class