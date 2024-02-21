Imports System.IO

Public Class Donburi
    Dim dblDonburiPrice() As Double = {14, 15, 13.5, 13, 12}
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        MsgBox("Chicken Katsu Don : " & dblDonburiPrice(0).ToString("c"))
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MsgBox("Yakiniku & Chicken Katsu Don : " & dblDonburiPrice(1).ToString("c"))
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("Yakiniku Don : " & dblDonburiPrice(2).ToString("c"))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("Teriyaki Tofu Rice Bowls : " & dblDonburiPrice(3).ToString("c"))
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        MsgBox("Oyako Don : " & dblDonburiPrice(4).ToString("c"))
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Sub DisplayError()
        MsgBox("Please make sure your input in numeric", vbOKOnly, "Error")
    End Sub

    Dim intCknKatsuDon As Integer
    Dim dblCknKatsuDon As Double
    Dim intYakinikuCkn As Integer
    Dim dblYakinikuCkn As Double
    Dim intYakiniku As Integer
    Dim dblYakiniku As Double
    Dim intTeriyaki As Integer
    Dim dblTeriyaki As Double
    Dim intOyako As Integer
    Dim dblOyako As Double

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click

        If txtCknKatsuDon.Text <> String.Empty Then
            If Not Integer.TryParse(txtCknKatsuDon.Text, intCknKatsuDon) Then
                DisplayError()
                txtCknKatsuDon.Text = ""
                txtCknKatsuDon.Focus()
                dblCknKatsuDon = 0
            Else
                'if no error'
                dblCknKatsuDon = intCknKatsuDon * dblDonburiPrice(0)
            End If
        Else
            dblCknKatsuDon = 0
        End If

        If txtYakinikuCkn.Text <> String.Empty Then
            If Not Integer.TryParse(txtYakinikuCkn.Text, intYakinikuCkn) Then
                DisplayError()
                txtYakinikuCkn.Text = ""
                txtYakiniku.Focus()
                dblYakinikuCkn = 0
            Else
                'if no error'
                dblYakinikuCkn = intYakinikuCkn * dblDonburiPrice(1)
            End If
        Else
            dblYakinikuCkn = 0
        End If

        If txtYakiniku.Text <> String.Empty Then
            If Not Integer.TryParse(txtYakiniku.Text, intYakiniku) Then
                DisplayError()
                txtYakiniku.Text = ""
                txtYakiniku.Focus()
                dblYakiniku = 0
            Else
                'if no error'
                dblYakiniku = intYakiniku * dblDonburiPrice(2)
            End If
        Else
            dblYakiniku = 0
        End If

        If txtTeriyaki.Text <> String.Empty Then
            If Not Integer.TryParse(txtTeriyaki.Text, intTeriyaki) Then
                DisplayError()
                txtTeriyaki.Text = ""
                txtTeriyaki.Focus()
                dblTeriyaki = 0
            Else
                'if no error'
                dblTeriyaki = intTeriyaki * dblDonburiPrice(3)
            End If
        Else
            dblTeriyaki = 0
        End If

        If txtOyako.Text <> String.Empty Then
            If Not Integer.TryParse(txtOyako.Text, intOyako) Then
                DisplayError()
                txtOyako.Text = ""
                txtOyako.Focus()
                dblOyako = 0
            Else
                'if no error'
                dblOyako = intOyako * dblDonburiPrice(4)
            End If
        Else
            dblOyako = 0
        End If
        'Totak Donburi'
        Dim dblTotalDonburi As Double
        dblTotalDonburi = dblCknKatsuDon + dblYakinikuCkn + dblYakiniku + dblTeriyaki + dblOyako
        MsgBox("Total is : " & dblTotalDonburi.ToString("c"))


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
        Dim blnDonburi As Boolean
        Dim DonburiFile As StreamWriter

        Dim blnCknKatsuDon As Boolean
        Dim blnYakinikuCkn As Boolean
        Dim blnYakiniku As Boolean
        Dim blnTeriyaki As Boolean
        Dim blnOyako As Boolean
        Try
            DonburiFile = File.CreateText("Donburi.txt")


            If txtCknKatsuDon.Text <> String.Empty Then
                If Not Integer.TryParse(txtCknKatsuDon.Text, intCknKatsuDon) Then
                    blnCknKatsuDon = False
                    txtCknKatsuDon.Text = ""
                    txtCknKatsuDon.Focus()
                    dblCknKatsuDon = 0
                Else
                    'if no error'

                    If txtCknKatsuDon.Text <> "0" Then
                        blnCknKatsuDon = True
                        dblCknKatsuDon = intCknKatsuDon * dblDonburiPrice(0)
                        DonburiFile.WriteLine("Chicken Katsu Don : " & txtCknKatsuDon.Text & "Qty")
                        DonburiFile.WriteLine(vbTab & vbTab & dblCknKatsuDon.ToString("c"))
                    Else
                        blnCknKatsuDon = True
                        dblCknKatsuDon = intCknKatsuDon * dblDonburiPrice(0)
                    End If

                End If
            Else
                dblCknKatsuDon = 0
                blnCknKatsuDon = True
            End If


            If txtYakinikuCkn.Text <> String.Empty Then
                If Not Integer.TryParse(txtYakinikuCkn.Text, intYakinikuCkn) Then
                    blnYakinikuCkn = False
                    txtYakinikuCkn.Text = ""
                    txtYakinikuCkn.Focus()
                    dblYakinikuCkn = 0
                Else
                    If txtYakinikuCkn.Text <> "0" Then
                        'if no error'
                        blnYakinikuCkn = True
                        dblYakinikuCkn = intYakinikuCkn * dblDonburiPrice(1)
                        DonburiFile.WriteLine("Yakiniku & Chicken Katsu Don " & txtYakinikuCkn.Text & "Qty")
                        DonburiFile.WriteLine(vbTab & vbTab & dblYakinikuCkn.ToString("c"))
                    Else
                        blnYakinikuCkn = True
                        dblYakinikuCkn = intYakinikuCkn * dblDonburiPrice(1)
                    End If
                End If

            Else
                dblYakinikuCkn = 0
                blnYakinikuCkn = True
            End If


            If txtYakiniku.Text <> String.Empty Then
                If Not Integer.TryParse(txtYakiniku.Text, intYakiniku) Then
                    blnYakinikuCkn = False
                    txtYakiniku.Text = ""
                    txtYakiniku.Focus()
                    dblYakiniku = 0
                Else
                    If txtYakiniku.Text <> "0" Then
                        'if no error'
                        blnYakiniku = True
                        dblYakiniku = intYakiniku * dblDonburiPrice(2)
                        DonburiFile.WriteLine("Yakiniku Don " & txtYakiniku.Text & "Qty")
                        DonburiFile.WriteLine(vbTab & vbTab & dblYakiniku.ToString("c"))
                    Else
                        blnYakiniku = True
                        dblYakiniku = intYakiniku * dblDonburiPrice(2)
                    End If
                End If
            Else
                dblYakiniku = 0
                blnYakiniku = True
            End If


            If txtTeriyaki.Text <> String.Empty Then
                If Not Integer.TryParse(txtTeriyaki.Text, intTeriyaki) Then
                    blnTeriyaki = False
                    txtTeriyaki.Text = ""
                    txtTeriyaki.Focus()
                    dblTeriyaki = 0
                Else
                    If txtTeriyaki.Text <> "0" Then
                        'if no error'
                        blnTeriyaki = True
                        dblTeriyaki = intTeriyaki * dblDonburiPrice(3)
                        DonburiFile.WriteLine("Teriyaki Tofu Rice Bowls " & txtTeriyaki.Text & "Qty")
                        DonburiFile.WriteLine(vbTab & vbTab & dblTeriyaki.ToString("c"))
                    Else
                        blnTeriyaki = True
                        dblTeriyaki = intTeriyaki * dblDonburiPrice(3)
                    End If
                End If
            Else
                dblTeriyaki = 0
                blnTeriyaki = True
            End If


            If txtOyako.Text <> String.Empty Then
                If Not Integer.TryParse(txtOyako.Text, intOyako) Then
                    blnOyako = False
                    txtOyako.Text = ""
                    txtOyako.Focus()
                    dblOyako = 0
                Else
                    If txtOyako.Text <> "0" Then
                        'if no error'
                        blnOyako = True
                        dblOyako = intOyako * dblDonburiPrice(4)
                        DonburiFile.WriteLine("Oyako Don " & txtOyako.Text & "Qty")
                        DonburiFile.WriteLine(vbTab & vbTab & dblOyako.ToString("c"))
                    Else
                        dblOyako = intOyako * dblDonburiPrice(4)
                        blnOyako = True
                    End If
                End If
            Else

                dblOyako = 0
                blnOyako = True
            End If

            'if no error'
            If blnCknKatsuDon = True And blnYakinikuCkn = True And blnYakiniku = True And blnTeriyaki = True And blnOyako = True Then
                blnDonburi = True
            Else
                blnDonburi = False
            End If
            DonburiFile.Close()
            Return blnDonburi
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class