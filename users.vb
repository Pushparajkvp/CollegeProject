Public Class users
    Private sql As New Class1
    Private Sub txtpass_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpass.TextChanged
        check()
    End Sub
    Private Sub check()
        If txtpass.Text <> txtrepass.Text Then
            lblcheck.Text = "No match"
        Else
            lblcheck.Text = "Match!"
        End If
    End Sub

    Private Sub txtrepass_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtrepass.TextChanged
        check()
    End Sub

    Private Sub users_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources._1459676422_Teacher_male_24
        sql.ExecSql("select name from users")
        For Each r As DataRow In sql.sqld.Tables(0).Rows
            cboname.Items.Add(r("name"))
        Next
    End Sub

    Private Sub butsubmit_Click(sender As System.Object, e As System.EventArgs) Handles butsubmit.Click
        If txtname.Text = "" Or txtpass.Text = "" Or txtrepass.Text = "" Then
            MessageBox.Show("you should not leave any field blank ", "empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If cboname.Items.Contains(txtname.Text) Then
            MessageBox.Show("There is already a user with that name ", "username error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        sql.Addpram("@name", txtname.Text)
        sql.Addpram("@pass", txtpass.Text)
        sql.ExecSql("insert into users(name,password) values(@name,@pass)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        MessageBox.Show("The username has been added now u can login with that !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        sql.Addpram("@name", cboname.Text)
        sql.ExecSql("delete from users where name = @name")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        MessageBox.Show("The username has been deleted :( ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()
    End Sub
End Class