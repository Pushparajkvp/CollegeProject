<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class give
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsex = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboname = New System.Windows.Forms.ComboBox()
        Me.cbobook = New System.Windows.Forms.ComboBox()
        Me.txtage = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 514)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 85)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Return"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "sex"
        '
        'txtsex
        '
        Me.txtsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtsex.FormattingEnabled = True
        Me.txtsex.Location = New System.Drawing.Point(177, 317)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.Size = New System.Drawing.Size(197, 24)
        Me.txtsex.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Id number"
        '
        'txtid
        '
        Me.txtid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtid.FormattingEnabled = True
        Me.txtid.Location = New System.Drawing.Point(177, 214)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(197, 24)
        Me.txtid.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Book Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(467, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 394)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Select Name"
        '
        'cboname
        '
        Me.cboname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboname.FormattingEnabled = True
        Me.cboname.Location = New System.Drawing.Point(177, 45)
        Me.cboname.Name = "cboname"
        Me.cboname.Size = New System.Drawing.Size(197, 24)
        Me.cboname.TabIndex = 14
        '
        'cbobook
        '
        Me.cbobook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbobook.FormattingEnabled = True
        Me.cbobook.Location = New System.Drawing.Point(177, 407)
        Me.cbobook.Name = "cbobook"
        Me.cbobook.Size = New System.Drawing.Size(197, 24)
        Me.cbobook.TabIndex = 26
        '
        'txtage
        '
        Me.txtage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtage.FormattingEnabled = True
        Me.txtage.Location = New System.Drawing.Point(177, 136)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(197, 24)
        Me.txtage.TabIndex = 27
        '
        'give
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 676)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.cbobook)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "give"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Return"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsex As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboname As System.Windows.Forms.ComboBox
    Friend WithEvents cbobook As System.Windows.Forms.ComboBox
    Friend WithEvents txtage As System.Windows.Forms.ComboBox
End Class
