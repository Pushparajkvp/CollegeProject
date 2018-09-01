Public Class LoginForm1
    Private sql As New Class1

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click
        sql.Addpram("@user", UsernameTextBox.Text)
        sql.Addpram("@pass", PasswordTextBox.Text)
        sql.ExecSql("SELECT * FROM users WHERE name = @user and password = @pass")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Please Dont Leave Any Fields Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If sql.recordcount > 0 Then
            MainDialog.Show()
            Me.Hide()
        Else
            MessageBox.Show("The Username Or Password Is Incorrect !", "login error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676300_Login_Manager
    End Sub
End Class
