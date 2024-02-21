Public Class StartPage

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case MsgBox("Exit App?", vbYesNo, "Exit")
            Case MsgBoxResult.Yes
                Beep()
                Me.Close()
                Login.Close()
        End Select

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        EatOptionMenu.Show()
        Me.Hide()
    End Sub

End Class
