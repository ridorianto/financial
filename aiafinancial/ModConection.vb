Imports System.Data.Odbc
Module ModConection
    Public conn As Odbc.OdbcConnection
    Public da As OdbcDataAdapter
    Public dr As OdbcDataReader
    Public cmd As OdbcCommand
    Public ds As DataSet
    Public simpan, ubah, hapus As String
    Public strTemp As String = ""
    Public strValue As String = ""
    Public Sub koneksi()
        conn = New OdbcConnection("Dsn=aiafinancial")
        conn.Open()
    End Sub
End Module
