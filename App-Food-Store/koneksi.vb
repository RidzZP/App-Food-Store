'Import sql
Imports System.Data.SqlClient

'Membuat koneksi
Module koneksi
    Public con As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public ds As DataSet
    Public sql As String
    Public Sub connect()
        sql = "Data Source=WIN-1PKC0KA10NS\SQLEXPRESS;Initial Catalog=FoodS;Integrated Security=True"
        con = New SqlConnection(sql)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
