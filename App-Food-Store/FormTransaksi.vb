Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class FormTransaksi
    Dim PD As PrintDocument
    Dim PDD As New PrintPreviewDialog
    Private WithEvents PrintDoc As New Printing.PrintDocument

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim tinggi As Integer
        e.Graphics.DrawString("FOOD S", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("No Tlp: 0812", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Jl.Sukamulya", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 20
        e.Graphics.DrawString("--------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Barang" & vbTab & vbTab & "QTY" & vbTab & "total", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        For Each data As DataGridViewRow In tbKeranjang.Rows
            tinggi = tinggi + 10
            e.Graphics.DrawString(data.Cells(5).Value, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

            tinggi = tinggi + 10
            e.Graphics.DrawString(vbTab & vbTab & data.Cells(2).Value & vbTab & data.Cells(3).Value, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)
        Next


        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)


        tinggi = tinggi + 10
        e.Graphics.DrawString("Total" & vbTab & vbTab & ":" & Label4.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Tunai" & vbTab & vbTab & ":" & txtKembali.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Kembali" & vbTab & ":" & Label2.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("--------------------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Terimakasih...!!!", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)
    End Sub

    Sub printPD()
        PrintDoc.PrinterSettings.PrinterName = "Adobe PDF"
        PrintDoc.Print()
    End Sub

    Private Sub PrintDoc_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDoc.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("custom", 250, 300)
        PrintDoc.DefaultPageSettings = pagesetup
    End Sub


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
                  '" & txtTotalHarga.Text & "',
                  '" & lbIdKasir.Text & "',
                  '" & txtIdBarang.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Simpan")
            tbKeranjang.Rows.Clear()
            kosong()
        Next
    End Sub
End Class