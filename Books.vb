Public Class Books
    Private sql As New Class1
    Dim src As New BindingSource
    Private Sub Books_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Icon = My.Resources.Custom_Icon_Design_Pretty_Office_2_Library
        sql.ExecSql("select distinct(bookname) from books")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        For Each r As DataRow In sql.sqld.Tables(0).Rows
            cbobook.Items.Add(r("bookname"))
        Next
        sql.ExecSql("select name from student")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        For Each r As DataRow In sql.sqld.Tables(0).Rows
            cboname.Items.Add(r("name"))
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbobook.SelectedIndexChanged
        cboname.Items.Clear()
        sql.Addpram("@book", cbobook.Text)
        sql.ExecSql("select S.name,B.bookname from books B left join student S on S.id=B.stuid where bookname = @book")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        src.DataSource = sql.sqld.Tables(0)
        DataGridView1.DataSource = src
    End Sub
    Private Sub cboname_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboname.SelectedIndexChanged
        cbobook.Items.Clear()
        sql.Addpram("@name", cboname.Text)
        sql.ExecSql("select S.name,B.bookname from books B left join student S on S.id=B.stuid where S.name = @name")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        src.DataSource = sql.sqld.Tables(0)
        DataGridView1.DataSource = src
    End Sub
End Class