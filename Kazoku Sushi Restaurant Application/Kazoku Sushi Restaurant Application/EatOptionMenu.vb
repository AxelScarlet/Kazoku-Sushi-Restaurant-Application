Imports System.IO
Public Class EatOptionMenu


    Dim strEatOption As String

    Private Sub lblEatIn_Click(sender As Object, e As EventArgs) Handles lblEatIn.Click
        strEatOption = "Eat In"
        ReceiptPrint(strEatOption)
        showCategory()
    End Sub

    Private Sub lblTakeAway_Click(sender As Object, e As EventArgs) Handles lblTakeAway.Click
        strEatOption = "Take Away"
        ReceiptPrint(strEatOption)
        showCategory()
    End Sub

    Private Sub lblBooking_Click(sender As Object, e As EventArgs) Handles lblBooking.Click

        BookingDate.ShowDialog()
    End Sub

    Sub showCategory()
        Category.Show()
        Me.Close()
    End Sub

    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        Select Case MsgBox("Cancel order?", vbYesNo, "Cancel Order")
            Case MsgBoxResult.Yes
                StartPage.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub btnEatIn_Click(sender As Object, e As EventArgs) Handles btnEatIn.Click
        strEatOption = "Eat In"
        ReceiptPrint(strEatOption)
        showCategory()
    End Sub

    Private Sub btnTakeAway_Click(sender As Object, e As EventArgs) Handles btnTakeAway.Click

        strEatOption = "Take Away"
        ReceiptPrint(strEatOption)
        showCategory()
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click

        BookingDate.ShowDialog()
    End Sub

    Private Sub EatOptionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SetMealsFile As StreamWriter
        Dim SushiFile As StreamWriter
        Dim NoodlesFile As StreamWriter
        Dim DonburiFile As StreamWriter
        Dim BeverageFile As StreamWriter
        Dim DessertFile As StreamWriter
        'Create empty file'
        SushiFile = File.CreateText("Sushi.txt")
        SetMealsFile = File.CreateText("SetMeals.txt")
        NoodlesFile = File.CreateText("Noodles.txt")
        BeverageFile = File.CreateText("Beverage.txt")
        DessertFile = File.CreateText("Dessert.txt")
        DonburiFile = File.CreateText("Donburi.txt")
        'Saved'
        SushiFile.Close()
        SetMealsFile.Close()
        NoodlesFile.Close()
        BeverageFile.Close()
        DessertFile.Close()
        DonburiFile.Close()


    End Sub

    Sub ReceiptPrint(ByRef strEatOption As String)
        Dim ReceiptFile As StreamWriter
        ReceiptFile = File.CreateText("Receipt.txt")
        ReceiptFile.WriteLine("Eat Option : " & strEatOption)
        ReceiptFile.WriteLine("Date and Time : " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
        ReceiptFile.Close()
    End Sub
End Class