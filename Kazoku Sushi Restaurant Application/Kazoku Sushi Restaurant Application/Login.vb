Imports System.Data.SqlClient

Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\Kazoku Sushi Restaurant Application\Kazoku Sushi Restaurant Application\Login.mdf;Integrated Security=True"
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing
        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\Kazoku Sushi Restaurant Application\Kazoku Sushi Restaurant Application\Login.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "Select * From Login Where Username = '" & UsernameTextBox.Text & "' AND Password = '" & PasswordTextBox.Text & "'"
            objcmd = New SqlCommand(stmt, objcon)

            Dim reader As SqlDataReader = objcmd.ExecuteReader

            If reader.Read Then
                MessageBox.Show("Login Successfully")
                Me.Hide()
                StartPage.Show()
            Else
                MessageBox.Show("Invalid Login. Please try Again.")
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
            End If
        Catch ex As Exception
            MsgBox("CONNECTION ERROR")
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub chkPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        If (Me.chkPassword.Checked = True) Then
            Me.PasswordTextBox.PasswordChar = ""
        Else
            Me.PasswordTextBox.PasswordChar = "*"c
        End If
    End Sub

End Class
