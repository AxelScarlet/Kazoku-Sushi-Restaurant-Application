Public Class Category
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Dim Booking As New BookingDate
        Select Case MsgBox("Cancel order?", vbYesNo, "Cancel Order")
            Case MsgBoxResult.Yes
                StartPage.Show()
                AlaCarte.Close()
                Sushi.Close()
                Noodles.Close()
                SetMeals.Close()
                Beverage.Close()
                Dessert.Close()
                Payment.Close()
                Donburi.Close()
                'Booking.lblDateMessage.Text = ""
                'Booking.txtTime.Text = ""
                BookingDate.Close()
                Payment.Close()
                Me.Close()
        End Select
    End Sub

    Private Sub btnFinishOrder_Click(sender As Object, e As EventArgs) Handles btnFinishOrder.Click
        Payment.Show()
        Me.Close()
    End Sub

    Private Sub btnSetMeals_Click(sender As Object, e As EventArgs) Handles btnSetMeals.Click
        SetMeals.Show()
        Me.Close()
    End Sub

    Private Sub mnuSetMeals_Click(sender As Object, e As EventArgs) Handles mnuSetMeals.Click
        SetMeals.Show()
        Me.Close()
    End Sub

    Private Sub btnBeverage_Click(sender As Object, e As EventArgs) Handles btnBeverage.Click
        Beverage.Show()
        Me.Close()
    End Sub

    Private Sub picBeverages_Click(sender As Object, e As EventArgs) Handles picBeverages.Click
        Beverage.Show()
        Me.Close()
    End Sub

    Private Sub mnuBeverages_Click(sender As Object, e As EventArgs) Handles mnuBeverage.Click
        Beverage.Show()
        Me.Close()
    End Sub

    Private Sub btnAlaCarte_Click(sender As Object, e As EventArgs) Handles btnAlaCarte.Click
        AlaCarte.Show()
        Me.Close()
    End Sub

    Private Sub picAlaCarte_Click(sender As Object, e As EventArgs) Handles picAlaCarte.Click
        AlaCarte.Show()
        Me.Close()
    End Sub

    Private Sub mnuAlaCarte_Click(sender As Object, e As EventArgs) Handles mnuAlaCarte.Click
        AlaCarte.Show()
        Me.Close()
    End Sub

    Private Sub picSetMeals_Click(sender As Object, e As EventArgs) Handles picSetMeals.Click
        SetMeals.Show()
        Me.Close()
    End Sub

    Private Sub btnInstruction_Click(sender As Object, e As EventArgs) Handles btnInstruction.Click
        MsgBox("Please click Confirm Order to save your order in payment later")
    End Sub

    Private Sub btnDesserts_Click(sender As Object, e As EventArgs) Handles btnDessert.Click
        Dessert.Show()
        Me.Close()

    End Sub

    Private Sub picDesserts_Click(sender As Object, e As EventArgs) Handles picDesserts.Click
        Dessert.Show()
        Me.Close()

    End Sub

    Private Sub mnuDessert_Click(sender As Object, e As EventArgs) Handles mnuDessert.Click
        Dessert.Show()
        Me.Close()
    End Sub

End Class