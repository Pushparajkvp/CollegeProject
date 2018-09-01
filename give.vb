Public Class give
    Private sql As New Class1
    Private Sub give_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Custom_Icon_Design_Flatastic_5_Library_2
        sql.ExecSql("select name from student")
        If Sql.exep <> "" Then
            MsgBox(Sql.exep)
        End If
        For Each r As DataRow In Sql.sqld.Tables(0).Rows
            cboname.Items.Add(r("name"))
        Next
    End Sub
    Dim ss As Integer
    Private Sub cboname_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboname.SelectedIndexChanged
        cbobook.Items.Clear()
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
        sql.Addpram("@book", cbobook.Text)
        sql.Addpram("@id", ss)
        sql.ExecSql("select bookname from books B left join student S on S.id = B.stuid where B.stuid=@id")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        If sql.recordcount > 0 Then
            For Each r As DataRow In sql.sqld.Tables(0).Rows
                cbobook.Items.Add(r("bookname"))
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If cbobook.SelectedIndex < 0 Then
            MessageBox.Show("Please select a book first !", "select ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        sql.Addpram("@book", cbobook.Text)
        sql.ExecSql("delete from books where bookname=@book")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        MessageBox.Show("The Book Has Been Returned!", "return", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        cbobook.Items.Clear()
        txtage.Items.Clear()
        txtid.Items.Clear()
        txtsex.Items.Clear()
    End Sub
End Class