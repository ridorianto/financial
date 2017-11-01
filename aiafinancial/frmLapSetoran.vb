Imports System.Data.Odbc
Public Class frmLapSetoran
    Sub Tampiltanggal()
        Call koneksi()
        cmd = New OdbcCommand("select distinct tgl_setor from setorannasabah", conn)
        dr = cmd.ExecuteReader

        cmd = New OdbcCommand("select distinct month(tgl_setor) as bulan from setorannasabah", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item(0))
        Loop

        cmd = New OdbcCommand("select distinct year(tgl_setor) as tahun from setorannasabah", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox2.Items.Add(dr.Item(0))
        Loop
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Pilih dulu bulan dan tahun")
            Exit Sub
        Else
            CRV.SelectionFormula = "Month({setorannasabah.tgl_setor})=" & Val(ComboBox1.Text) & " and Year({setorannasabah.tgl_setor})=" & Val(ComboBox2.Text)
            CRV.RefreshReport()
        End If
    End Sub

    Private Sub frmLapSetoran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tampiltanggal()
    End Sub
End Class