Imports System.Data
Imports System.Data.SqlServerCe
Public Class Class1
    ' SQL coneectio and commands
    Private sqlcon As New SqlCeConnection("Data Source=PUSHPARAJ\PUSHPARAJ;Initial Catalog=Library;Integrated Security=True")
    Private sqlcmd As New SqlCeCommand

    'SQL data
    Public sqlda As New SqlCeDataAdapter
    Public sqld As New DataSet

    'SQL parameters
    Public prams As New List(Of SqlCeParameter)

    'SQL stats
    Public recordcount As Integer
    Public exep As String

    Public Sub ExecSql(Query As String)
        Try
            sqlcon.Open()
            sqlcmd = New SqlCeCommand(Query, sqlcon)
            prams.ForEach(Sub(x) sqlcmd.Parameters.Add(x))
            prams.Clear()
            sqld = New DataSet
            sqlda = New SqlCeDataAdapter(sqlcmd)
            recordcount = sqlda.Fill(sqld, Query)
            sqlcon.Close()
        Catch ex As Exception
            exep = ex.Message
        End Try
        If sqlcon.State = ConnectionState.Open Then sqlcon.Close()
    End Sub
    Public Sub Addpram(name As String, value As Object)
        Dim newpram As New SqlCeParameter(name, value)
        prams.Add(newpram)
    End Sub
End Class
