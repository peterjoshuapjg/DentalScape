Imports System.Data.Common
Imports MySql.Data.MySqlClient

Module DatabaseConnection
    Public cn As New MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public da As MySqlDataAdapter

    Public sql As String

    Public Sub connection()
        cn.Close()
        cn.ConnectionString = "server=localhost;user=root;password=;database=dentalclinicdb"
        cn.Open()
    End Sub
End Module
