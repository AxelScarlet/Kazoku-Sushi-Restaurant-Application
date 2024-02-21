Imports System.IO

Public Class Payment
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Select Case MsgBox("Continue order?", vbYesNo, "Cancel Order")
            Case MsgBoxResult.Yes
                Category.Show()
                Me.Close()
        End Select
    End Sub

    Dim dblTotal As Double
    Dim dblSubTotal As Double
    Dim dblTax As Double
    Dim dblCharges As Double
    Dim dblCoupon As Double
    Dim dblSubTotalAfterRounding As Double
    Dim dblRounding As Double



    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Take boolean from Booking form'
        Dim blnBookingDate As New BookingDate

        Dim SetMealsFile As StreamReader
        Dim SushiFile As StreamReader
        Dim NoodlesFile As StreamReader
        Dim DonburiFile As StreamReader
        Dim BeverageFile As StreamReader
        Dim DessertFile As StreamReader

        SetMealsFile = File.OpenText("SetMeals.txt")
        SushiFile = File.OpenText("Sushi.txt")
        NoodlesFile = File.OpenText("Noodles.txt")
        DonburiFile = File.OpenText("Donburi.txt")
        BeverageFile = File.OpenText("Beverage.txt")
        DessertFile = File.OpenText("Dessert.txt")

        ReceiptOutput(SetMealsFile)
        ReceiptOutput(SushiFile)
        ReceiptOutput(NoodlesFile)
        ReceiptOutput(DonburiFile)
        ReceiptOutput(BeverageFile)
        ReceiptOutput(DessertFile)

        SetMealsFile.Close()
        SushiFile.Close()
        NoodlesFile.Close()
        DonburiFile.Close()
        BeverageFile.Close()
        DessertFile.Close()
        'Count total for lblTotal'
        For x As Integer = 0 To lstReceipt.Items.Count - 1
            x += 1
            dblSubTotal += CDbl(lstReceipt.Items(x))
        Next

        'Booking charges'
        If BookingDate.lblDateMessage.Text <> String.Empty And BookingDate.txtTime.Text <> String.Empty Then
            dblCharges = 15
        Else
            dblCharges = 0
        End If

        dblTax = dblSubTotal * 0.06
        dblCoupon = CDbl(lblCoupon.Text)
        dblTotal = dblSubTotal + dblCharges + dblTax - dblCoupon
        dblSubTotalAfterRounding = Math.Round(dblTotal, 1, MidpointRounding.ToEven)
        dblRounding = dblSubTotalAfterRounding - dblTotal

        lblSubTotal.Text = dblSubTotal.ToString("c")
        lblTax.Text = dblTax.ToString("c")
        lblCharges.Text = dblCharges.ToString("c")
        lblTotal.Text = dblTotal.ToString("c")
        lblFinalTotal.Text = dblSubTotalAfterRounding.ToString("c")
        lblRounding.Text = dblRounding.ToString("c")

    End Sub

    Sub ReceiptOutput(ByVal readFile As StreamReader)
        Dim strInput As String
        Do Until readFile.EndOfStream
            strInput = readFile.ReadLine()
            lstReceipt.Items.Add(strInput)
        Loop
    End Sub

    Private Function Coupon(ByVal dblSubTotal As Double) As Double
        Dim dblCoupon As Double
        Dim strCoupon() As String = {"KZKSUSHI", "KZKOPEN", "KZKPROMO"}
        Dim blnCoupon As Boolean
        If txtCoupon.Text <> String.Empty Then
            For x As Integer = 0 To strCoupon.Length - 1
                If txtCoupon.Text.ToUpper = strCoupon(x) Then
                    blnCoupon = True
                    dblCoupon = dblSubTotal * 0.2
                    Exit For
                Else
                    blnCoupon = False
                    dblCoupon = 0
                End If
            Next
        Else
            dblCoupon = 0
            blnCoupon = True
        End If
        If blnCoupon = False Then
            MsgBox("Coupon not valid or not exist", vbOKOnly, "Coupon Message")
        End If
        Return dblCoupon
    End Function

    Private Sub btnCoupon_Click(sender As Object, e As EventArgs) Handles btnCoupon.Click

        dblCoupon = Coupon(CDbl(lblSubTotal.Text))
        lblCoupon.Text = dblCoupon.ToString("c")
        'lblCoupon.Text = Coupon(CDbl(lblSubTotal.Text)).ToString("c")'

        dblSubTotal = 0
        'Count total for lblTotal'
        For x As Integer = 0 To lstReceipt.Items.Count - 1
            x += 1
            dblSubTotal += CDbl(lstReceipt.Items(x))
        Next

        'Booking charges'
        If BookingDate.lblDateMessage.Text <> String.Empty And BookingDate.txtTime.Text <> String.Empty Then
            dblCharges = 15
        Else
            dblCharges = 0
        End If

        dblTax = dblSubTotal * 0.06
        dblCoupon = CDbl(lblCoupon.Text)
        dblTotal = dblSubTotal + dblCharges + dblTax - dblCoupon
        dblSubTotalAfterRounding = Math.Round(dblTotal, 1, MidpointRounding.ToEven)
        dblRounding = dblSubTotalAfterRounding - dblTotal

        lblSubTotal.Text = dblSubTotal.ToString("c")
        lblTax.Text = dblTax.ToString("c")
        lblCharges.Text = dblCharges.ToString("c")
        lblTotal.Text = dblTotal.ToString("c")
        lblFinalTotal.Text = dblSubTotalAfterRounding.ToString("c")
        lblRounding.Text = dblRounding.ToString("c")

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Select Case MsgBox("Print?", vbYesNo, "Print")
            Case MsgBoxResult.Yes
                pdReceipt.Print()
            Case Else
                MsgBox("Cancel print")
        End Select

    End Sub

    Private Sub pdReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdReceipt.PrintPage

        Dim receiptFile As StreamReader

        Dim strInput As String
        Dim strFont As String
        strFont = "Microsoft Sans Serif"

        receiptFile = File.OpenText("Receipt.txt")
        'Position'
        Dim startX As Integer = 50 'right or left' 
        Dim startY As Integer = 80 'up or  down'
        'PRINT TITLE'
        e.Graphics.DrawString("KAZOKU SUSHI RESTAURANT", New Drawing.Font(strFont, 20, FontStyle.Bold), Brushes.Black, 50, 20)
        'PRINT RECEIPT DETAIL'
        Do Until receiptFile.EndOfStream
            strInput = receiptFile.ReadLine()
            e.Graphics.DrawString(strInput, New Drawing.Font(strFont, 8, FontStyle.Regular), Brushes.Black, startX, startY)
            startY += 15
        Loop
        startY -= 5
        e.Graphics.DrawString("________________________________________________", New Drawing.Font(strFont, 20, FontStyle.Regular), Brushes.Black, startX, startY)
        startY += 30
        For x As Integer = 0 To lstReceipt.Items.Count - 1
            strInput = lstReceipt.Items(x).ToString
            e.Graphics.DrawString(strInput, New Drawing.Font(strFont, 8, FontStyle.Regular), Brushes.Black, startX, startY)
            startY += 15
        Next
        startY -= 15
        e.Graphics.DrawString("________________________________________________", New Drawing.Font(strFont, 20, FontStyle.Regular), Brushes.Black, startX, startY)
        startY += 30
        startX = 400
        e.Graphics.DrawString(vbTab & "                 Sub total : " & lblSubTotal.Text, New Drawing.Font(strFont, 8, FontStyle.Regular), Brushes.Black, startX, startY)
        startY += 15
        e.Graphics.DrawString(vbTab & "Additional Charges : " & lblCharges.Text, New Drawing.Font(strFont, 8, FontStyle.Regular), Brushes.Black, startX, startY)
        startY += 15
        e.Graphics.DrawString(vbTab & "              Service tax : " & lblTax.Text, New Drawing.Font(strFont, 8, FontStyle.Regular), Brushes.Black, startX, startY)
        startY += 15
        e.Graphics.DrawString(vbTab & "                  Discount : " & lblCoupon.Text, New Drawing.Font(strFont, 8, FontStyle.Regular), Brushes.Black, startX, startY)
        startY += 15
        e.Graphics.DrawString(vbTab & "              Total Sales : " & lblTotal.Text, New Drawing.Font(strFont, 8, FontStyle.Regular), Brushes.Black, startX, startY)
        startY += 15
        e.Graphics.DrawString(vbTab & "      Rounding Adjust : " & lblRounding.Text, New Drawing.Font(strFont, 8, FontStyle.Regular), Brushes.Black, startX, startY)
        startY += 15
        e.Graphics.DrawString(vbTab & "   Total After Adjust : " & lblFinalTotal.Text, New Drawing.Font(strFont, 8, FontStyle.Regular), Brushes.Black, startX, startY)
        startY += 15
        receiptFile.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click


        Category.Close()
        BookingDate.Close()
        EatOptionMenu.Close()
        Category.Close()
        SetMeals.Close()
        AlaCarte.Close()
        Donburi.Close()
        Noodles.Close()
        Sushi.Close()
        Beverage.Close()
        Dessert.Close()
        StartPage.Show()
        Me.Close()

    End Sub
End Class