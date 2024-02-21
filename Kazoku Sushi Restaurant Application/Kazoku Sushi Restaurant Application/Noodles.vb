Imports System.IO
Public Class Noodles

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
    Sub DisplayError()
        MsgBox("Please make sure your input in numeric", vbOKOnly, "Error")
    End Sub

    'price each item'
    Dim dblNoodlePrice() As Double = {14.5, 15, 16.5, 17.5}
    Private Sub picSpicyBrothRamen_Click(sender As Object, e As EventArgs) Handles picSpicyBrothRamen.Click
        MsgBox("Spicy Broth Ramen : " & dblNoodlePrice(0).ToString("c"), vbOKOnly, "Detail")
    End Sub

    Private Sub picShoyuRamen_Click(sender As Object, e As EventArgs) Handles picShoyuRamen.Click
        MsgBox("Shoyu Ramen : " & dblNoodlePrice(0).ToString("c"), vbOKOnly, "Detail")
    End Sub

    Private Sub picUdon_Click(sender As Object, e As EventArgs) Handles picUdon.Click
        MsgBox("Beef Udon : " & dblNoodlePrice(1).ToString("c"), vbOKOnly, "Detail")
    End Sub

    Private Sub picSpicyRamen_Click(sender As Object, e As EventArgs) Handles picSpicyRamen.Click
        MsgBox("Korean Style Spicy Ramen : " & dblNoodlePrice(2).ToString("c"), vbOKOnly, "Detail")
    End Sub

    Private Sub picSpicyRamenChicken_Click(sender As Object, e As EventArgs) Handles picSpicyRamenChicken.Click
        MsgBox("Korean Style Spicy Ramen with Chicken: " & dblNoodlePrice(3).ToString("c"), vbOKOnly, "Detail")
    End Sub

    'Quantity'
    Dim intBrothRamen As Integer
    Dim intShoyuRamen As Integer
    Dim intSoba As Integer
    Dim intKoreanRamen As Integer
    Dim intKoreanRamenChicken As Integer

    'Total*Quantity'
    Dim dblBrothRamen As Double
    Dim dblShoyuRamen As Double
    Dim dblSoba As Double
    Dim dblKoreanRamen As Double
    Dim dblKoreanRamenChicken As Double
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click

        'Calculation for Spicy Broth Ramen '
        If txtBrothRamen.Text <> String.Empty Then
            If Not Integer.TryParse(txtBrothRamen.Text, intBrothRamen) Then
                DisplayError()
                txtBrothRamen.Text = ""
                txtBrothRamen.Focus()
                dblBrothRamen = 0
            Else
                'if no error'
                dblBrothRamen = intBrothRamen * dblNoodlePrice(0)
            End If
        Else
            dblBrothRamen = 0
        End If

        'Calculation for Shoyu Ramen '
        If txtShoyuRamen.Text <> String.Empty Then
            If Not Integer.TryParse(txtShoyuRamen.Text, intShoyuRamen) Then
                DisplayError()
                txtShoyuRamen.Text = ""
                txtShoyuRamen.Focus()
                dblShoyuRamen = 0
            Else
                'if no error'
                dblShoyuRamen = intShoyuRamen * dblNoodlePrice(0)
            End If
        Else
            dblShoyuRamen = 0
        End If

        'Calculation for Beef Soba '
        If txtSoba.Text <> String.Empty Then
            If Not Integer.TryParse(txtSoba.Text, intSoba) Then
                DisplayError()
                txtSoba.Text = ""
                txtSoba.Focus()
                dblSoba = 0
            Else
                'if no error'
                dblSoba = intSoba * dblNoodlePrice(1)
            End If
        Else
            dblSoba = 0
        End If

        'Calculation for Spicy Korean Ramen '
        If txtKoreanRamen.Text <> String.Empty Then
            If Not Integer.TryParse(txtKoreanRamen.Text, intKoreanRamen) Then
                DisplayError()
                txtKoreanRamen.Text = ""
                txtKoreanRamen.Focus()
                dblKoreanRamen = 0
            Else
                'if no error'
                dblKoreanRamen = intKoreanRamen * dblNoodlePrice(2)
            End If
        Else
            dblKoreanRamen = 0
        End If

        'Calculation for Spicy Korean Ramen with Chicken'
        If txtKoreanRamenChicken.Text <> String.Empty Then
            If Not Integer.TryParse(txtKoreanRamenChicken.Text, intKoreanRamenChicken) Then
                DisplayError()
                txtKoreanRamenChicken.Text = ""
                txtKoreanRamenChicken.Focus()
                dblKoreanRamenChicken = 0
            Else
                'if no error'
                dblKoreanRamenChicken = intKoreanRamenChicken * dblNoodlePrice(3)
            End If
        Else
            dblKoreanRamenChicken = 0
        End If


        Dim dblTotalNoodle As Double
        dblTotalNoodle = dblBrothRamen + dblShoyuRamen + dblSoba + dblKoreanRamen + dblKoreanRamenChicken
        MsgBox("Total order for noodles : " & dblTotalNoodle.ToString("c"))

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Select Case MsgBox("Confirm order", vbYesNo, "Confirm Order")
            Case MsgBoxResult.Yes
                If Print() = True Then
                    Me.Hide()
                Else
                    DisplayError()
                End If
        End Select
    End Sub

    Private Function Print() As Boolean
        Dim NoodlesFile As StreamWriter
        Dim blnBrothRamen As Boolean
        Dim blnShoyuRamen As Boolean
        Dim blnSoba As Boolean
        Dim blnKoreanRamen As Boolean
        Dim blnKoreanramenChicken As Boolean
        Dim blnNoodles As Boolean

        Try
            NoodlesFile = File.CreateText("Noodles.txt")

            'Calculation for Spicy Broth Ramen '
            If txtBrothRamen.Text <> String.Empty Then
                If Not Integer.TryParse(txtBrothRamen.Text, intBrothRamen) Then
                    blnBrothRamen = False
                    txtBrothRamen.Text = ""
                    txtBrothRamen.Focus()
                    dblBrothRamen = 0
                Else
                    If txtBrothRamen.Text <> "0" Then
                        'if no error'
                        blnBrothRamen = True
                        dblBrothRamen = intBrothRamen * dblNoodlePrice(0)
                        NoodlesFile.WriteLine("Spicy Broth Ramen " & txtBrothRamen.Text & " Qty")
                        NoodlesFile.WriteLine(vbTab & vbTab & dblBrothRamen.ToString("c"))
                    Else
                        blnBrothRamen = True
                        dblBrothRamen = intBrothRamen * dblNoodlePrice(0)
                    End If
                End If
            Else
                dblBrothRamen = 0
                blnBrothRamen = True
            End If

            'Condition for Shoyu Ramen '
            If txtShoyuRamen.Text <> String.Empty Then
                If Not Integer.TryParse(txtShoyuRamen.Text, intShoyuRamen) Then
                    blnShoyuRamen = False
                    txtShoyuRamen.Text = ""
                    txtShoyuRamen.Focus()
                    dblShoyuRamen = 0
                Else
                    If txtShoyuRamen.Text <> "0" Then
                        'if no error'
                        blnShoyuRamen = True
                        dblShoyuRamen = intShoyuRamen * dblNoodlePrice(0)
                        NoodlesFile.WriteLine("Shoyu Ramen " & txtShoyuRamen.Text & " Qty")
                        NoodlesFile.WriteLine(vbTab & vbTab & dblShoyuRamen.ToString("c"))
                    Else
                        blnShoyuRamen = True
                        dblShoyuRamen = intShoyuRamen * dblNoodlePrice(0)
                    End If
                End If
            Else
                blnShoyuRamen = True
                dblShoyuRamen = 0
            End If

            'Condition for Beef Soba '
            If txtSoba.Text <> String.Empty Then
                If Not Integer.TryParse(txtSoba.Text, intSoba) Then
                    blnSoba = False
                    txtSoba.Text = ""
                    txtSoba.Focus()
                    dblSoba = 0
                Else
                    If txtSoba.Text <> "0" Then
                        'if no error'
                        blnSoba = True
                        dblSoba = intSoba * dblNoodlePrice(1)
                        NoodlesFile.WriteLine("Beef Soba " & txtSoba.Text & " Qty")
                        NoodlesFile.WriteLine(vbTab & vbTab & dblSoba.ToString("c"))
                    Else
                        blnSoba = True
                        dblSoba = intSoba * dblNoodlePrice(1)
                    End If
                End If
            Else
                blnSoba = True
                dblSoba = 0
            End If

            'Condition for Spicy Korean Ramen '
            If txtKoreanRamen.Text <> String.Empty Then
                If Not Integer.TryParse(txtKoreanRamen.Text, intKoreanRamen) Then
                    blnKoreanRamen = False
                    txtKoreanRamen.Text = ""
                    txtKoreanRamen.Focus()
                    dblKoreanRamen = 0

                Else
                    If txtKoreanRamenChicken.Text <> "0" Then
                        'if no error'
                        blnKoreanRamen = True
                        dblKoreanRamen = intKoreanRamen * dblNoodlePrice(2)
                        NoodlesFile.WriteLine("Spicy Korean Ramen " & txtKoreanRamen.Text & " Qty")
                        NoodlesFile.WriteLine(vbTab & vbTab & dblKoreanRamen.ToString("c"))
                    Else
                        blnKoreanRamen = True
                        dblKoreanRamen = intKoreanRamen * dblNoodlePrice(2)
                    End If
                End If
            Else
                blnKoreanRamen = True
                dblKoreanRamen = 0
            End If


            'Condition for Spicy Korean Ramen with Chicken'
            If txtKoreanRamenChicken.Text <> String.Empty Then
                If Not Integer.TryParse(txtKoreanRamenChicken.Text, intKoreanRamenChicken) Then
                    blnKoreanramenChicken = False
                    txtKoreanRamenChicken.Text = ""
                    txtKoreanRamenChicken.Focus()
                    dblKoreanRamenChicken = 0
                    blnKoreanramenChicken = False
                Else
                    If txtKoreanRamenChicken.Text <> "0" Then
                        'if no error'
                        blnKoreanramenChicken = True
                        dblKoreanRamenChicken = intKoreanRamenChicken * dblNoodlePrice(3)
                        NoodlesFile.WriteLine("Spicy Korean Ramen with Chicken " & txtKoreanRamenChicken.Text & " Qty")
                        NoodlesFile.WriteLine(vbTab & vbTab & dblKoreanRamenChicken.ToString("c"))
                    Else
                        'if no error'
                        blnKoreanramenChicken = True
                        dblKoreanRamenChicken = intKoreanRamenChicken * dblNoodlePrice(3)
                    End If
                End If
            Else
                blnKoreanramenChicken = True
                dblKoreanRamenChicken = 0
            End If
            'If no error,saved file and return true to print'
            If blnBrothRamen = True And blnKoreanRamen = True And blnKoreanramenChicken = True And blnShoyuRamen = True And blnSoba = True Then
                blnNoodles = True
            Else
                blnNoodles = False
            End If
            NoodlesFile.Close()
            Return blnNoodles
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class