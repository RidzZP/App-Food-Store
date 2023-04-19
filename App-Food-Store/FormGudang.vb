Imports System.Data.SqlClient
Public Class FormGudang
    Sub viewtable()
        sql = "SELECT * FROM tb_barang"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "tb_barang")
        tbBarang.DataSource = ds.Tables("tb_barang")
    End Sub
    Sub kosong()
        txtKodeBarang.Text = ""
        txtNamaBarang.Text = ""
        txtJumlahBarang.Text = ""
        txtSatuan.Text = ""
        txtHargaSatuan.Text = ""
    End Sub

    Private Sub FormGudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        viewtable()

        txtId.Visible = False
    End Sub

    Private Sub txtHargaSatuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaSatuan.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            MsgBox("Pastikan Hanya Angka yang Di Input")
            e.Handled = True
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtKodeBarang.Text = "" Or txtNamaBarang.Text = "" Or txtJumlahBarang.Text = "" Or txtSatuan.Text = "" Or txtHargaSatuan.Text = "" Then
            MsgBox("Pastikan Semua Terisi")
        Else
            sql = "INSERT INTO tb_barang(kode_barang, nama_barang, expired_date, jumlah_barang, satuan, harga_satuan) VALUES ('" & txtKodeBarang.Text & "',
                  '" & txtNamaBarang.Text & "',
                  '" & Format(ExpiredDate.Value, "yyyy-MM-dd") & "',
                  '" & txtJumlahBarang.Text & "',
                  '" & txtSatuan.Text & "',
                  '" & txtHargaSatuan.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Simpan")
            kosong()
            viewtable()
        End If
    End Sub

    Private Sub txtJumlahBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlahBarang.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            MsgBox("Pastikan Hanya Angka yang Di Input")
            e.Handled = True
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtKodeBarang.Text = "" Or txtNamaBarang.Text = "" Or txtJumlahBarang.Text = "" Or txtSatuan.Text = "" Or txtHargaSatuan.Text = "" Then
            MsgBox("Pastikan Semua Terisi")
        Else
            sql = "UPDATE tb_barang SET kode_barang ='" & txtKodeBarang.Text & "',
                  nama_barang ='" & txtNamaBarang.Text & "',
                  expired_date ='" & Format(ExpiredDate.Value, "yyyy-MM-dd") & "',
                  jumlah_barang ='" & txtJumlahBarang.Text & "',
                  satuan ='" & txtSatuan.Text & "',
                  harga_satuan ='" & txtHargaSatuan.Text & "' WHERE id_barang ='" & txtId.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Edit")
            kosong()
            viewtable()
        End If
    End Sub

    Private Sub tbBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tbBarang.CellContentClick
        txtId.Text = tbBarang.Rows(tbBarang.CurrentRow.Index).Cells(0).Value
        txtKodeBarang.Text = tbBarang.Rows(tbBarang.CurrentRow.Index).Cells(1).Value
        txtNamaBarang.Text = tbBarang.Rows(tbBarang.CurrentRow.Index).Cells(2).Value
        ExpiredDate.Value = tbBarang.Rows(tbBarang.CurrentRow.Index).Cells(3).Value
        txtJumlahBarang.Text = tbBarang.Rows(tbBarang.CurrentRow.Index).Cells(4).Value
        txtSatuan.Text = tbBarang.Rows(tbBarang.CurrentRow.Index).Cells(5).Value
        txtHargaSatuan.Text = tbBarang.Rows(tbBarang.CurrentRow.Index).Cells(6).Value

        Dim level As String = tbBarang.Rows(tbBarang.CurrentRow.Index).Cells(5).Value
        txtSatuan.SelectedItem = level
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeBarang.Text = "" Or txtNamaBarang.Text = "" Or txtJumlahBarang.Text = "" Or txtSatuan.Text = "" Or txtHargaSatuan.Text = "" Then
            MsgBox("Pastikan Semua Terisi")
        Else
            sql = "DELETE FROM tb_barang WHERE id_barang ='" & txtId.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Di hapus")
            kosong()
            viewtable()
        End If
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) 
        FormUser.Show()
        Me.Hide()
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
End Class