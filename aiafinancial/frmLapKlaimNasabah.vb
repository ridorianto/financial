Imports System.Data.Odbc
Public Class frmLapKlaimNasabah
    Sub Tampiltanggal()
        Call koneksi()
        cmd = New OdbcCommand("select distinct tgl_klaim from klaimnasabah", conn)
        dr = cmd.ExecuteReader

        cmd = New OdbcCommand("select distinct month(tgl_klaim) as bulan from klaimnasabah", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item(0))
        Loop

        cmd = New OdbcCommand("select distinct year(tgl_klaim) as tahun from klaimnasabah", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            ComboBox2.Items.Add(dr.Item(0))
        Loop
    End Sub
    Private Sub frmLapKlaimNasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tampiltanggal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Pilih dulu bulan dan tahun")
            Exit Sub
        Else
            CRV.SelectionFormula = "Month({klaimnasabah.tgl_klaim})=" & Val(ComboBox1.Text) & " and Year({klaimnasabah.tgl_klaim})=" & Val(ComboBox2.Text)
            CRV.RefreshReport()
        End If
    End Sub
End Class