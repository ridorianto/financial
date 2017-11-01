Imports System.Data.Odbc
Public Class frmLapNasabah
    Sub Tampiltanggal()
        Call koneksi()
        cmd = New OdbcCommand("select distinct tgl_daftar from datanasabah", conn)
        dr = cmd.ExecuteReader

        cmd = New OdbcCommand("select distinct month(tgl_daftar) as bulan from datanasabah", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item(0))
        Loop

        cmd = New OdbcCommand("select distinct year(tgl_daftar) as tahun from datanasabah", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox2.Items.Add(dr.Item(0))
        Loop
    End Sub
    Private Sub frmLapNasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tampiltanggal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Pilih dulu bulan dan tahun")
            Exit Sub
        Else
            CRV.SelectionFormula = "Month({datanasabah.tgl_daftar})=" & Val(ComboBox1.Text) & " and Year({datanasabah.tgl_daftar})=" & Val(ComboBox2.Text)
            CRV.RefreshReport()
        End If
    End Sub
End Class