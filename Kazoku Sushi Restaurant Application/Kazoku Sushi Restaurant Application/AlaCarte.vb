Public Class AlaCarte

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Category.Show()
    End Sub

    Private Sub btnNoodles_Click(sender As Object, e As EventArgs) Handles btnNoodles.Click
        Noodles.ShowDialog()
    End Sub

    Private Sub btnDonburi_Click(sender As Object, e As EventArgs) Handles btnDonburi.Click
        Donburi.ShowDialog()
    End Sub

    Private Sub btnSushi_Click(sender As Object, e As EventArgs) Handles btnSushi.Click
        Sushi.ShowDialog()
    End Sub

    Private Sub mnuSetMeals_Click(sender As Object, e As EventArgs) Handles mnuSetMeals.Click
        SetMeals.Show()
        Me.Close()
    End Sub

    Private Sub mnuBeverage_Click(sender As Object, e As EventArgs) Handles mnuBeverage.Click
        Beverage.Show()
        Me.Close()
    End Sub

    Private Sub mnuDessert_Click(sender As Object, e As EventArgs) Handles mnuDessert.Click
        Dessert.Show()
        Me.Close()
    End Sub
End Class