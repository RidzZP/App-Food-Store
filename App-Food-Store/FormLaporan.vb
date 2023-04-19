Imports System.Data.SqlClient
Public Class FormLaporan
    Sub viewtable()
        connect()
        sql = "SELECT tb_transaksi.id_transaksi, tb_transaksi.tgl_transaksi, tb_transaksi.total_bayar, tb_user.username FROM tb_transaksi INNER JOIN tb_user ON tb_transaksi.id_user = tb_user.id_user"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "tb_transaksi")
        tbLaporan.DataSource = ds.Tables("tb_transaksi")
    End Sub
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        viewtable()
        connect()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        sql = "SELECT tgl_transaksi, total_bayar from tb_transaksi WHERE tgl_transaksi between '" & tglAwal.Value.Date.ToString("MM/dd/yyyy") & "' and '" & tglAkhir.Value.Date.ToString("MM/dd/yyyy") & "'"

        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "tb_transaksi")
        tbLaporan.DataSource = ds.Tables("tb_transaksi")
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        sql = "SELECT tgl_transaksi, total_bayar from tb_transaksi WHERE tgl_transaksi between '" & tglAwal.Value.Date.ToString("MM/dd/yyyy") & "' and '" & tglAkhir.Value.Date.ToString("MM/dd/yyyy") & "'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        Do While dr.Read
            chartLaporan.Series("Series 1").Points.AddXY(Microsoft.VisualBasic.Left(dr("tgl_transaksi").ToString, 10), dr("total_bayar").ToString)
        Loop
        dr.Close()
    End Sub
End Class