Imports System.Data.Odbc
Public Class frmMain

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Tutup aplikasi..?", "Keluar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            frmLogin.Show()
            frmLogin.txtUser.Clear()
            frmLogin.txtPass.Clear()
            frmLogin.txtUser.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataUserToolStripMenuItem.Click
        frmUser.Show()
    End Sub

    Private Sub DataJenisProdukAsuransiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataJenisProdukAsuransiToolStripMenuItem.Click
        frmJP_Asuransi.Show()
    End Sub

    Private Sub DataJenisKlaimNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataJenisKlaimNasabahToolStripMenuItem.Click
        frmJK_Nasabah.Show()
    End Sub

    Private Sub DataJenisSetoranNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataJenisSetoranNasabahToolStripMenuItem.Click
        frmJS_Nasabah.Show()
    End Sub

    Private Sub DataJenisPenarikanNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataJenisPenarikanNasabahToolStripMenuItem.Click
        frmJPD_Nasabah.Show()
    End Sub

    Private Sub DataPimpinanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPimpinanToolStripMenuItem.Click
        frmPimpinan.Show()
    End Sub

    Private Sub DataAgenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataAgenToolStripMenuItem.Click
        frmAgen.Show()
    End Sub

    Private Sub DataNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataNasabahToolStripMenuItem.Click
        frmNasabah.Show()
    End Sub

    Private Sub DataKlaimNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKlaimNasabahToolStripMenuItem.Click
        frmK_Nasabah.Show()
    End Sub

    Private Sub DataSetoranNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSetoranNasabahToolStripMenuItem.Click
        frmS_Nasabah.Show()
    End Sub

    Private Sub DataPenarikanDanaNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPenarikanDanaNasabahToolStripMenuItem.Click
        frmPD_Nasabah.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Format(Now, "dd MMM yyyy")
        ToolStripStatusLabel4.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub LaporanNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanNasabahToolStripMenuItem.Click
        frmLapNasabah.Show()
    End Sub

    Private Sub LaporanKlaimNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanKlaimNasabahToolStripMenuItem.Click
        frmLapKlaimNasabah.Show()
    End Sub

    Private Sub LaporanSetoranNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanSetoranNasabahToolStripMenuItem.Click
        frmLapSetoran.Show()
    End Sub

    Private Sub LaporanPenarikanDanaNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenarikanDanaNasabahToolStripMenuItem.Click
        frmLapPenarikan.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmJK_Nasabah.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmJP_Asuransi.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmJS_Nasabah.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        frmJPD_Nasabah.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        frmPimpinan.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frmNasabah.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        frmAgen.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        frmK_Nasabah.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        frmS_Nasabah.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        frmPD_Nasabah.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        frmLapNasabah.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        frmLapKlaimNasabah.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        frmLapSetoran.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        frmLapPenarikan.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        frmUser.Show()
    End Sub

    Private Sub JenisPembayaranNasabahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JenisPembayaranNasabahToolStripMenuItem.Click
        frmJPB_Nasabah.Show()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        frmJPB_Nasabah.Show()
    End Sub

End Class
