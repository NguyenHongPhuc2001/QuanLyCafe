
namespace PM_QLCF
{
    partial class fLichSuBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvLSHoaDon = new System.Windows.Forms.DataGridView();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lblLichSuBanHang = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dgvLSCTHoaDon = new System.Windows.Forms.DataGridView();
            this.mcChonNgay = new System.Windows.Forms.MonthCalendar();
            this.IDHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSCTHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLSHoaDon
            // 
            this.dgvLSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHoaDon,
            this.STTHD,
            this.IDBan,
            this.NgayLapHD,
            this.TongTien});
            this.dgvLSHoaDon.Location = new System.Drawing.Point(12, 359);
            this.dgvLSHoaDon.Name = "dgvLSHoaDon";
            this.dgvLSHoaDon.RowHeadersWidth = 51;
            this.dgvLSHoaDon.RowTemplate.Height = 24;
            this.dgvLSHoaDon.Size = new System.Drawing.Size(568, 383);
            this.dgvLSHoaDon.TabIndex = 0;
            this.dgvLSHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLSHoaDon_CellClick);
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(664, 91);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(119, 60);
            this.btnLoc.TabIndex = 16;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // lblLichSuBanHang
            // 
            this.lblLichSuBanHang.AutoSize = true;
            this.lblLichSuBanHang.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichSuBanHang.Location = new System.Drawing.Point(397, 15);
            this.lblLichSuBanHang.Name = "lblLichSuBanHang";
            this.lblLichSuBanHang.Size = new System.Drawing.Size(350, 37);
            this.lblLichSuBanHang.TabIndex = 19;
            this.lblLichSuBanHang.Text = "LỊCH SỬ BÁN HÀNG";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(12, 12);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(112, 55);
            this.btnTroVe.TabIndex = 20;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dgvLSCTHoaDon
            // 
            this.dgvLSCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSCTHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCTHD,
            this.STTCTHD,
            this.TenMonAn,
            this.SoLuong,
            this.DonGia});
            this.dgvLSCTHoaDon.Location = new System.Drawing.Point(586, 359);
            this.dgvLSCTHoaDon.Name = "dgvLSCTHoaDon";
            this.dgvLSCTHoaDon.RowHeadersWidth = 51;
            this.dgvLSCTHoaDon.RowTemplate.Height = 24;
            this.dgvLSCTHoaDon.Size = new System.Drawing.Size(592, 383);
            this.dgvLSCTHoaDon.TabIndex = 21;
            // 
            // mcChonNgay
            // 
            this.mcChonNgay.Location = new System.Drawing.Point(318, 91);
            this.mcChonNgay.Name = "mcChonNgay";
            this.mcChonNgay.TabIndex = 22;
            // 
            // IDHoaDon
            // 
            this.IDHoaDon.HeaderText = "ID Hóa Đơn";
            this.IDHoaDon.MinimumWidth = 6;
            this.IDHoaDon.Name = "IDHoaDon";
            this.IDHoaDon.Visible = false;
            this.IDHoaDon.Width = 125;
            // 
            // STTHD
            // 
            this.STTHD.HeaderText = "STT";
            this.STTHD.MinimumWidth = 6;
            this.STTHD.Name = "STTHD";
            this.STTHD.Width = 50;
            // 
            // IDBan
            // 
            this.IDBan.FillWeight = 252.3364F;
            this.IDBan.HeaderText = "Bàn ";
            this.IDBan.MinimumWidth = 6;
            this.IDBan.Name = "IDBan";
            this.IDBan.Width = 60;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLapHD.FillWeight = 23.83178F;
            this.NgayLapHD.HeaderText = "Ngày Lập Hóa Đơn";
            this.NgayLapHD.MinimumWidth = 6;
            this.NgayLapHD.Name = "NgayLapHD";
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.FillWeight = 23.83178F;
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // IDCTHD
            // 
            this.IDCTHD.HeaderText = "ID ChiTietHoaDon";
            this.IDCTHD.MinimumWidth = 6;
            this.IDCTHD.Name = "IDCTHD";
            this.IDCTHD.Visible = false;
            this.IDCTHD.Width = 125;
            // 
            // STTCTHD
            // 
            this.STTCTHD.HeaderText = "STT";
            this.STTCTHD.MinimumWidth = 6;
            this.STTCTHD.Name = "STTCTHD";
            this.STTCTHD.Width = 60;
            // 
            // TenMonAn
            // 
            this.TenMonAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMonAn.HeaderText = "Tên Món Ăn";
            this.TenMonAn.MinimumWidth = 6;
            this.TenMonAn.Name = "TenMonAn";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 90;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // fLichSuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 754);
            this.Controls.Add(this.mcChonNgay);
            this.Controls.Add(this.dgvLSCTHoaDon);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.lblLichSuBanHang);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.dgvLSHoaDon);
            this.Name = "fLichSuBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLichSuBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSCTHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLSHoaDon;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lblLichSuBanHang;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvLSCTHoaDon;
        private System.Windows.Forms.MonthCalendar mcChonNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}