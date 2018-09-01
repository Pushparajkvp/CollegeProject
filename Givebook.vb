Public Class Givebook
    Private sql As New Class1
    Dim ss As Integer
    Private Sub Givebook_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Itzikgur_My_Seven_Books_1
        sql.ExecSql("select name from student")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        For Each r As DataRow In sql.sqld.Tables(0).Rows
            cboname.Items.Add(r("name"))
        Next
    End Sub

    Private Sub cboname_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboname.SelectedIndexChanged
        txtage.Items.Clear()
        txtid.Items.Clear()
        txtsex.Items.Clear()
        sql.Addpram("@name", cboname.Text)
        sql.ExecSql("select S.id as ids,G.gender as men,idno,due,age,photo from student S left join gender G on S.sex = G.id where S.name = @name")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        If sql.recordcount > 0 Then
            PictureBox1.ImageLocation = sql.sqld.Tables(0).Rows(0).Item("photo")
            txtage.Items.Add(sql.sqld.Tables(0).Rows(0).Item("age"))
            txtage.SelectedIndex = 0
            txtid.Items.Add(sql.sqld.Tables(0).Rows(0).Item("idno"))
            txtid.SelectedIndex = 0
            txtsex.Items.Add(sql.sqld.Tables(0).Rows(0).Item("men"))
            txtsex.SelectedIndex = 0
            ss = sql.sqld.Tables(0).Rows(0).Item("ids")
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txtbook.Text = "" Then
            MessageBox.Show("Please dont leave the boxes blank", "to entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        sql.Addpram("@name", txtbook.Text)
        sql.Addpram("@id", ss)
        sql.ExecSql("insert into books(stuid,bookname) values(@id,@name)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
            Exit Sub
        End If
        PictureBox1.ImageLocation = ""
        txtage.Text = 0
        txtid.Text = ""
        txtsex.Text = ""
        txtbook.Text = ""
        MessageBox.Show("The Book details has been updated !", "done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class