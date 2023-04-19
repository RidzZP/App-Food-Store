<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.tbKeranjang = New System.Windows.Forms.DataGridView()
        Me.kdBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hargaSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.cbMenu = New System.Windows.Forms.ComboBox()
        Me.txtHargaSatuan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.txtKembali = New System.Windows.Forms.TextBox()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbKembali = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.lbKasir = New System.Windows.Forms.Label()
        Me.txtIdBarang = New System.Windows.Forms.TextBox()
        Me.lbIdKasir = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.tbKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kasir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(291, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Pilih Menu"
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.SkyBlue
        Me.btnTambah.Location = New System.Drawing.Point(566, 198)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(93, 25)
        Me.btnTambah.TabIndex = 56
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 451)
        Me.Panel1.TabIndex = 52
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.SkyBlue
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(32, 328)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(182, 29)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'tbKeranjang
        '
        Me.tbKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbKeranjang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kdBarang, Me.namaBarang, Me.hargaSatuan, Me.Qty, Me.totalHarga})
        Me.tbKeranjang.Location = New System.Drawing.Point(258, 255)
        Me.tbKeranjang.Name = "tbKeranjang"
        Me.tbKeranjang.Size = New System.Drawing.Size(541, 76)
        Me.tbKeranjang.TabIndex = 58
        '
        'kdBarang
        '
        Me.kdBarang.HeaderText = "Kode Barang"
        Me.kdBarang.Name = "kdBarang"
        '
        'namaBarang
        '
        Me.namaBarang.HeaderText = "Nama Barang"
        Me.namaBarang.Name = "namaBarang"
        '
        'hargaSatuan
        '
        Me.hargaSatuan.HeaderText = "Harga Satuan"
        Me.hargaSatuan.Name = "hargaSatuan"
        '
        'Qty
        '
        Me.Qty.HeaderText = "Quantitas"
        Me.Qty.Name = "Qty"
        '
        'totalHarga
        '
        Me.totalHarga.HeaderText = "Subtotal"
        Me.totalHarga.Name = "totalHarga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(289, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 29)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Form Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(586, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Quantitas"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(589, 65)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(170, 20)
        Me.txtQty.TabIndex = 74
        '
        'cbMenu
        '
        Me.cbMenu.FormattingEnabled = True
        Me.cbMenu.Location = New System.Drawing.Point(294, 65)
        Me.cbMenu.Name = "cbMenu"
        Me.cbMenu.Size = New System.Drawing.Size(170, 21)
        Me.cbMenu.TabIndex = 75
        '
        'txtHargaSatuan
        '
        Me.txtHargaSatuan.Location = New System.Drawing.Point(294, 130)
        Me.txtHargaSatuan.Name = "txtHargaSatuan"
        Me.txtHargaSatuan.ReadOnly = True
        Me.txtHargaSatuan.Size = New System.Drawing.Size(170, 20)
        Me.txtHargaSatuan.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Harga Satuan"
        '
        'txtTotalHarga
        '
        Me.txtTotalHarga.Location = New System.Drawing.Point(589, 130)
        Me.txtTotalHarga.Name = "txtTotalHarga"
        Me.txtTotalHarga.ReadOnly = True
        Me.txtTotalHarga.Size = New System.Drawing.Size(170, 20)
        Me.txtTotalHarga.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(586, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Total harga"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.SkyBlue
        Me.btnReset.Location = New System.Drawing.Point(684, 198)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(93, 25)
        Me.btnReset.TabIndex = 80
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(291, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Total harga"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(414, 344)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(27, 13)
        Me.lbTotal.TabIndex = 82
        Me.lbTotal.Text = "Rp. "
        '
        'txtKembali
        '
        Me.txtKembali.Location = New System.Drawing.Point(294, 372)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.Size = New System.Drawing.Size(140, 20)
        Me.txtKembali.TabIndex = 83
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnBayar.Location = New System.Drawing.Point(294, 398)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(140, 25)
        Me.btnBayar.TabIndex = 84
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(291, 426)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Kembalian"
        '
        'lbKembali
        '
        Me.lbKembali.AutoSize = True
        Me.lbKembali.Location = New System.Drawing.Point(414, 428)
        Me.lbKembali.Name = "lbKembali"
        Me.lbKembali.Size = New System.Drawing.Size(27, 13)
        Me.lbKembali.TabIndex = 86
        Me.lbKembali.Text = "Rp. "
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSimpan.Location = New System.Drawing.Point(684, 398)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(93, 25)
        Me.btnSimpan.TabIndex = 88
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.SkyBlue
        Me.btnPrint.Location = New System.Drawing.Point(566, 398)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(93, 25)
        Me.btnPrint.TabIndex = 87
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(258, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Keranjang"
        '
        'txtKodeBarang
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(294, 156)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Size = New System.Drawing.Size(10, 20)
        Me.txtKodeBarang.TabIndex = 91
        '
        'lbKasir
        '
        Me.lbKasir.AutoSize = True
        Me.lbKasir.Location = New System.Drawing.Point(703, 21)
        Me.lbKasir.Name = "lbKasir"
        Me.lbKasir.Size = New System.Drawing.Size(61, 13)
        Me.lbKasir.TabIndex = 92
        Me.lbKasir.Text = "Nama Kasir"
        '
        'txtIdBarang
        '
        Me.txtIdBarang.Location = New System.Drawing.Point(310, 156)
        Me.txtIdBarang.Name = "txtIdBarang"
        Me.txtIdBarang.Size = New System.Drawing.Size(10, 20)
        Me.txtIdBarang.TabIndex = 93
        '
        'lbIdKasir
        '
        Me.lbIdKasir.AutoSize = True
        Me.lbIdKasir.Location = New System.Drawing.Point(703, 34)
        Me.lbIdKasir.Name = "lbIdKasir"
        Me.lbIdKasir.Size = New System.Drawing.Size(42, 13)
        Me.lbIdKasir.TabIndex = 94
        Me.lbIdKasir.Text = "Kasir Id"
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbIdKasir)
        Me.Controls.Add(Me.txtIdBarang)
        Me.Controls.Add(Me.lbKasir)
        Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lbKembali)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.txtKembali)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtTotalHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHargaSatuan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbMenu)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbKeranjang)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormTransaksi"
        Me.Text = "FormLaporan"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tbKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbKeranjang As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lbKembali As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBayar As Button
    Friend WithEvents txtKembali As TextBox
    Friend WithEvents lbTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents txtTotalHarga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHargaSatuan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbMenu As ComboBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtKodeBarang As TextBox
    Friend WithEvents kdBarang As DataGridViewTextBoxColumn
    Friend WithEvents namaBarang As DataGridViewTextBoxColumn
    Friend WithEvents hargaSatuan As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents totalHarga As DataGridViewTextBoxColumn
    Friend WithEvents lbKasir As Label
    Friend WithEvents txtIdBarang As TextBox
    Friend WithEvents lbIdKasir As Label
End Class
