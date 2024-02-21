Imports System.IO

Public Class BookingDate
    Dim blnBookingDate As Boolean
    Dim intTime As Integer '0-12'
    Dim strTime As String 'AM or PM'
    Dim intPax As Integer
    Dim dtmToday As Date = Today
    Private Sub btnConfirmDate_Click(sender As Object, e As EventArgs) Handles btnConfirmDate.Click
        If radAM.Checked Then
            strTime = "AM"
        ElseIf radPM.Checked Then
            strTime = "PM"
        End If
        Select Case lblDateMessage.Text
            Case String.Empty
                MsgBox("Please insert date")
                blnBookingDate = False
            Case Else
                If lblDateMessage.Text <> dtmToday Then
                    Select Case txtName.Text
                        Case String.Empty
                            MsgBox("Please insert Name")
                            txtName.Text = ""
                            txtName.Focus()
                        Case Else
                            If txtPax.Text <> String.Empty Then
                                blnBookingDate = True
                                If Integer.TryParse(txtPax.Text, intPax) Then
                                    blnBookingDate = True
                                    If validateTime() = True Then
                                        If blnBookingDate = True Then
                                            Select Case MsgBox("Book on " & lblDateMessage.Text & " at " & intTime & " " & strTime, vbYesNo, "Confirm Booking?")
                                                Case MsgBoxResult.Yes
                                                    ReceiptPrint(intTime, strTime)
                                                    Me.Hide()
                                                    Category.Show()
                                                    EatOptionMenu.Close()
                                                Case MsgBoxResult.No

                                            End Select
                                        End If
                                    End If
                                Else
                                    MsgBox("Please put numbers only on pax")
                                    blnBookingDate = False
                                    txtPax.Text = ""
                                    txtPax.Focus()
                                End If
                            Else
                                MsgBox("Please put the numbers of the people we will serve")
                                blnBookingDate = False
                                txtPax.Text = ""
                                txtPax.Focus()
                            End If
                    End Select
                Else
                    MsgBox("Please choose another date", vbOKOnly, "Error")
                    lblDateMessage.Text = ""
                End If
        End Select

    End Sub

    Private Sub btnTimePick_Click(sender As Object, e As EventArgs) Handles btnTimePick.Click
        lblDateMessage.Text = Format(DateTimePicker1.Value, "dd/MM/yyyy")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Select Case MsgBox("Cancel Booking?", vbOKCancel, "Cancel Booking")
            Case MsgBoxResult.Ok
                Me.Close()
                lblDateMessage.Text = ""
                txtTime.Text = ""
            Case MsgBoxResult.Cancel
                MsgBox("Continue Booking")
        End Select
    End Sub

    'All condition for any error found when confirming booking'
    Private Function validateTime() As Boolean
        If txtTime.Text = String.Empty Then
            MsgBox("Please insert your booking time")
            txtTime.Focus()
            Return False
        ElseIf Not Integer.TryParse(txtTime.Text, intTime) Then
            MsgBox("Please insert numeric number as time")
            txtTime.Text = ""
            txtTime.Focus()
            Return False
        ElseIf intTime > 12 Or intTime < 1 Then
            MsgBox("Please enter between 1 to 12")
            txtTime.Text = ""
            txtTime.Focus()
            Return False
        ElseIf radAM.Checked = True Then
            If intTime < 9 Or intTime > 11 Then
                MsgBox("Please enter time between 9am to 11am")
                txtTime.Text = ""
                txtTime.Focus()
                Return False
            Else
                Return True
            End If
        ElseIf radPM.Checked = True Then
            If intTime > 9 And intTime < 12 Then
                MsgBox("Please enter time between 12pm to 9pm")
                txtTime.Text = ""
                txtTime.Focus()
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If

    End Function

    Sub ReceiptPrint(ByRef intTime As Integer, strTime As String)
        Dim ReceiptFile As StreamWriter
        ReceiptFile = File.CreateText("Receipt.txt")
        ReceiptFile.WriteLine("Eat Option : Booking")
        ReceiptFile.WriteLine("Customer Name : " & txtName.Text)
        ReceiptFile.WriteLine("Pax : " & txtPax.Text)
        ReceiptFile.WriteLine("Date of Booking : " & lblDateMessage.Text)
        ReceiptFile.WriteLine("Time of Booking : " & intTime & " " & strTime)
        ReceiptFile.Close()
    End Sub

End Class