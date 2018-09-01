Public Class Add
    Private sql As New Class1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Title = "Select a Jpeg image"
            .FileName = ""
            .Multiselect = False
            .ShowDialog()
            If .FileName <> "" Then
                PictureBox1.Load(.FileName)
            End If
        End With
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PictureBox1.ImageLocation = ""
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If txtage.Text = "" Or txtid.Text = "" Or txtage.Text = 0 Or cbogender.Text = "" Then
            MessageBox.Show("You must leave any fields blank!", "Blank Fiels", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        sql.Addpram("@name", txtname.Text)
        sql.Addpram("@age", Convert.ToInt32(txtage.Text))
        sql.Addpram("@image", PictureBox1.ImageLocation)
        sql.Addpram("@sex", cbogender.SelectedIndex)
        sql.Addpram("@id", txtid.Text)
        sql.ExecSql("insert into student(name,idno,due,age,sex,photo) values(@name,@id,0,@age,@sex,@image)")
        If sql.exep <> "" Then
            MsgBox(sql.exep)
        End If
        MessageBox.Show("The Student Has Been Saved!", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Button4_Click(sender, e)
    End Sub

    Private Sub txtage_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtage.TextChanged
        If IsNumeric(txtage.Text) = False Then
            MessageBox.Show("Please give a number for age ", "Bad input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtage.Text = 0
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        txtage.Text = 0
        txtid.Text = ""
        txtname.Text = ""
        cbogender.Text = ""
        PictureBox1.ImageLocation = ""
    End Sub

    Private Sub Add_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.add_jpg
    End Sub
End Class