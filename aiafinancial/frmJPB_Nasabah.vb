﻿Imports System.Data.Odbc
Public Class frmJPB_Nasabah
    Sub isiGrid()
        ModConection.koneksi()
        da = New OdbcDataAdapter("SELECT * from jenispembayaran ORDER BY kd_jnspembayaran ASC", conn)
        ds = New DataSet
        da.Fill(ds, "jenispembayaran")
        DGV.DataSource = ds.Tables("jenispembayaran")
        DGV.ReadOnly = True
    End Sub
    Sub AturGrid()
        DGV.Columns(0).Width = 195
        DGV.Columns(1).Width = 195

        DGV.Columns(0).HeaderText = "Kode Jenis"
        DGV.Columns(1).HeaderText = "Jenis Pembayaran"
    End Sub
    Sub bersih()
        txtJenisPembayaran.Clear()
    End Sub
    Sub auto()
        Try
            koneksi()
            cmd = New OdbcCommand("select max(right(kd_jnspembayaran,3)) as jumlahku from jenispembayaran", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Try
                    If dr("Jumlahku") <> 0 Then
                        dr.Read()
                        txtKodeJenisPembayaran.Text = "KJPB-" & "00" & dr("Jumlahku") + 1
                    Else
                    End If
                Catch ex As Exception
                    txtKodeJenisPembayaran.Text = "KJPB-001"
                End Try
            End If
        Catch ex As Exception
            MsgBox("Proses Pembuatan Nomor Otomatis Gagal. Silakan Cek Server", vbInformation, "Cek Server")
        End Try
    End Sub
    Private Sub grid()
        DGV.RowsDefaultCellStyle.BackColor = Color.White
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    End Sub
    Private Sub frmJPB_Asuransi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        auto()
        isiGrid()
        AturGrid()
        grid()
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        Me.txtKodeJenisPembayaran.Text = DGV.Item(0, i).Value
        Me.txtJenisPembayaran.Text = DGV.Item(1, i).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtJenisPembayaran.Text = "" Then
            MsgBox("Data belum lengkap !!")
            txtJenisPembayaran.Focus()
        Else
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT * from jenispembayaran WHERE kd_jnspembayaran= '" & txtKodeJenisPembayaran.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Maaf, Data tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    koneksi()
                    simpan = "INSERT INTO jenispembayaran VALUES ('" & txtKodeJenisPembayaran.Text & "','" & txtJenisPembayaran.Text & "')"
                    cmd = New OdbcCommand(simpan, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Sukses Tersimpan", MsgBoxStyle.Information, "Pesan")
                    bersih()
                    isiGrid()
                    auto()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtJenisPembayaran.Text = "" Then
            MessageBox.Show("Data Belum Lengkap...", "informasi", MessageBoxButtons.OK)
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan dihapus ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    hapus = "DELETE FROM jenispembayaran WHERE kd_jnspembayaran='" & txtKodeJenisPembayaran.Text & "'"
                    cmd = New OdbcCommand(hapus, conn)
                    cmd.ExecuteNonQuery()
                    isiGrid()
                    bersih()
                    auto()
                Else
                    bersih()
                    auto()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        bersih()
        auto()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtJenisPembayaran.Text = "" Then
            MessageBox.Show("Data Belum Lengkap...", "informasi", MessageBoxButtons.OK)
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan diubah ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then

                    ubah = "UPDATE jenispembayaran SET jnspembayaran='" & txtJenisPembayaran.Text & "' WHERE kd_jnspembayaran= '" & txtKodeJenisPembayaran.Text & "'"
                    cmd = New OdbcCommand(ubah, conn)
                    cmd.ExecuteNonQuery()
                    isiGrid()
                    bersih()
                    auto()
                    MsgBox("Data Telah diubah", MsgBoxStyle.Information, "Pesan")
                Else
                    bersih()
                    auto()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub
End Class