Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class FormTransaksi
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Sub kosong()
        cbMenu.Text = ""
        txtHargaSatuan.Text = ""
        txtQty.Text = ""
        txtTotalHarga.Text = ""
        txtKodeBarang.Text = ""
        munculKodeBarang()
    End Sub

    Sub munculKodeBarang()
        connect()
        cbMenu.Items.Clear()
        cmd = New SqlCommand("SELECT * FROM tb_barang", con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            Dim pilihan As String = cbMenu.Items.Add(dr.Item(2))
        Loop
        dr.Close()
    End Sub
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        kosong()

        'ambil data username dari tabel tb_user berdasarkan ID user yang tersimpan pada variabel logUserId
        Dim username As String = ""
        Dim query As String = "SELECT username FROM tb_user WHERE id_user = @logUserId"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@logUserId", GlobalVariable.logUserId)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                username = dr("username").ToString()
            End If
            dr.Close()
        End Using

        'tampilkan username pada label
        lbKasir.Text = "Kasir: " & username

        lbIdKasir.Text = GlobalVariable.logUserId

        'hidden 
        txtKodeBarang.Visible = False
        txtIdBarang.Visible = False
        lbIdKasir.Visible = False

        'readonly
        txtHargaSatuan.ReadOnly = True
        txtTotalHarga.ReadOnly = True
    End Sub

    Private Sub cbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMenu.SelectedIndexChanged
        connect()
        sql = "SELECT * FROM tb_barang WHERE nama_barang='" & cbMenu.Text & "'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtHargaSatuan.Text = dr!harga_satuan
            txtKodeBarang.Text = dr!kode_barang
            txtIdBarang.Text = dr!id_barang
        End If
        dr.Close()
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        txtTotalHarga.Text = (Val(txtQty.Text) * Val(txtHargaSatuan.Text)).ToString()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cbMenu.SelectedIndex = -1
        txtHargaSatuan.Text = ""
        txtQty.Text = ""
        txtTotalHarga.Text = ""
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim jml As Integer
        tbKeranjang.Rows.Add(txtKodeBarang.Text, cbMenu.Text, txtHargaSatuan.Text, txtQty.Text, txtTotalHarga.Text)
        For baris As Integer = 0 To tbKeranjang.Rows.Count - 1
            jml = jml + ((tbKeranjang.Rows(baris).Cells(2).Value) * (tbKeranjang.Rows(baris).Cells(3).Value))
        Next
        lbTotal.Text = jml
        kosong()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtKembali.TextChanged
        lbKembali.Text = Val(txtKembali.Text) - Val(lbTotal.Text)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        For baris1 As Integer = 0 To tbKeranjang.Rows.Count - 2
            sql = "SELECT * FROM tb_transaksi WHERE no_transaksi in (SELECT MAX(no_transaksi) FROM tb_transaksi)"
            cmd = New SqlCommand(sql, con)
            Dim noTransaksi As String
            Dim hit As Long
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                noTransaksi = Format(Now, "yyMMdd") + "0001"
            Else
                hit = Microsoft.VisualBasic.Right(dr.GetInt32(0), 11) + 1
                noTransaksi = Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hit, 4)
            End If
            dr.Close()

            sql = "INSERT INTO tb_transaksi(no_transaksi, tgl_transaksi, total_bayar, id_user, id_barang) VALUES ('" & noTransaksi & "',
                  '" & DateTime.Now.ToString("yyyy-MM-dd") & "',
                  '" & lbTotal.Text & "',
                  '" & lbIdKasir.Text & "',
                  '" & txtIdBarang.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Simpan")
            tbKeranjang.Rows.Clear()
            kosong()
        Next
        dr.Close()
    End Sub

    Private Sub txtQty_Validating(sender As Object, e As CancelEventArgs) Handles txtQty.Validating
        sql = "SELECT jumlah_barang FROM tb_barang WHERE id_barang = @id_barang"
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@id_barang", txtIdBarang.Text)

        Dim quantity As Integer = cmd.ExecuteScalar()

        If Integer.TryParse(txtQty.Text, Nothing) AndAlso CInt(txtQty.Text) > quantity Then
            MsgBox("Quantity melebihi stok barang yang tersedia.")
            e.Cancel = True
        End If
        dr.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Simpan aktivitas logout ke database
        Dim waktu As DateTime = DateTime.Now
        Dim aktivitas As String = "Logout"
        Dim id_user As Integer = GlobalVariable.logUserId
        Dim queryLog As String = "INSERT INTO tb_log (waktu, aktivitas, id_user) VALUES (@waktu, @aktivitas, @id_user)"
        Using cmdLog As New SqlCommand(queryLog, con)
            cmdLog.Parameters.AddWithValue("@waktu", waktu)
            cmdLog.Parameters.AddWithValue("@aktivitas", aktivitas)
            cmdLog.Parameters.AddWithValue("@id_user", id_user)
            cmdLog.ExecuteNonQuery()
        End Using

        GlobalVariable.logUserId = 0

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim marginLeft As Integer = PD.DefaultPageSettings.Margins.Left
        Dim marginCenter As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim marginRight As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "-----------------------------------------------------"

        e.Graphics.DrawString("Food Store", f14, Brushes.Black, marginCenter, 5, tengah)
        e.Graphics.DrawString("Jl. Meikarta No.123", f10, Brushes.Black, marginCenter, 25, tengah)

        e.Graphics.DrawString("No Transaksi ", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 60)
        e.Graphics.DrawString("231231", f10, Brushes.Black, 75, 60)

        e.Graphics.DrawString("Nama Kasir", f10, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f10, Brushes.Black, 65, 75)
        e.Graphics.DrawString(lbKasir.Text, f10, Brushes.Black, 75, 75)

        e.Graphics.DrawString(Format("yyyy-MM-dd"), f10, Brushes.Black, 0, 90)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)

        tbKeranjang.AllowUserToAddRows = False
        Dim tinggi As Integer
        Dim i As Long
        For baris As Integer = 0 To tbKeranjang.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(tbKeranjang.Rows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 0, 100 + tinggi)
            e.Graphics.DrawString(tbKeranjang.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 25, 100 + tinggi)

            i = tbKeranjang.Rows(baris).Cells(2).Value
            tbKeranjang.Rows(baris).Cells(2).Value = Format(i, "##, ##0")
            e.Graphics.DrawString(tbKeranjang.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, marginRight, 100 + tinggi, kanan)
        Next
        tinggi = 110 + tinggi

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, tinggi)
        e.Graphics.DrawString("Total" & vbTab & vbTab & ":" & lbTotal.Text, f10b, Brushes.Black, marginRight, 10 + tinggi, kanan)

        e.Graphics.DrawString("Terimakasi Telah Belanja", f10, Brushes.Black, marginCenter, 35 + tinggi, tengah)
        e.Graphics.DrawString("Di Toko Kami", f10, Brushes.Black, marginCenter, 50 + tinggi, tengah)
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("custom", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub txtKembali_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKembali.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan hanya angka yg di input")
            e.Handled = True
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Pastikan hanya angka yg di input")
            e.Handled = True
        End If
    End Sub
End Class