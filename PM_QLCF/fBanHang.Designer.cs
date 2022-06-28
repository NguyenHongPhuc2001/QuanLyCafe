
namespace PM_QLCF
{
    partial class fBanHang
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
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlThemMon = new System.Windows.Forms.Panel();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblThucDon = new System.Windows.Forms.Label();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cmbThucDon = new System.Windows.Forms.ComboBox();
            this.cmbDanhMuc = new System.Windows.Forms.ComboBox();
            this.pnlHoaDon = new System.Windows.Forms.Panel();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.IDMonAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlThanhToan = new System.Windows.Forms.Panel();
            this.btnDT = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.cmbChuyenBan = new System.Windows.Forms.ComboBox();
            this.lblTongTien_text = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.mcNgay = new System.Windows.Forms.MonthCalendar();
            this.pnlThemMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.pnlHoaDon.SuspendLayout();
            this.pnlThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.Location = new System.Drawing.Point(14, 231);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(694, 592);
            this.flpBan.TabIndex = 0;
            // 
            // pnlThemMon
            // 
            this.pnlThemMon.Controls.Add(this.btnThemMon);
            this.pnlThemMon.Controls.Add(this.nudSoLuong);
            this.pnlThemMon.Controls.Add(this.lblThucDon);
            this.pnlThemMon.Controls.Add(this.lblDanhMuc);
            this.pnlThemMon.Controls.Add(this.cmbThucDon);
            this.pnlThemMon.Controls.Add(this.cmbDanhMuc);
            this.pnlThemMon.Location = new System.Drawing.Point(715, 89);
            this.pnlThemMon.Name = "pnlThemMon";
            this.pnlThemMon.Size = new System.Drawing.Size(628, 136);
            this.pnlThemMon.TabIndex = 1;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Location = new System.Drawing.Point(461, 40);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(133, 57);
            this.btnThemMon.TabIndex = 22;
            this.btnThemMon.Text = "Thêm Món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(370, 59);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(51, 22);
            this.nudSoLuong.TabIndex = 20;
            // 
            // lblThucDon
            // 
            this.lblThucDon.AutoSize = true;
            this.lblThucDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThucDon.Location = new System.Drawing.Point(28, 84);
            this.lblThucDon.Name = "lblThucDon";
            this.lblThucDon.Size = new System.Drawing.Size(94, 23);
            this.lblThucDon.TabIndex = 19;
            this.lblThucDon.Text = "Thực Đơn";
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMuc.Location = new System.Drawing.Point(28, 32);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(96, 23);
            this.lblDanhMuc.TabIndex = 18;
            this.lblDanhMuc.Text = "Danh Mục";
            // 
            // cmbThucDon
            // 
            this.cmbThucDon.FormattingEnabled = true;
            this.cmbThucDon.Location = new System.Drawing.Point(151, 83);
            this.cmbThucDon.Name = "cmbThucDon";
            this.cmbThucDon.Size = new System.Drawing.Size(195, 24);
            this.cmbThucDon.TabIndex = 1;
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.FormattingEnabled = true;
            this.cmbDanhMuc.Location = new System.Drawing.Point(151, 31);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.Size = new System.Drawing.Size(195, 24);
            this.cmbDanhMuc.TabIndex = 0;
            this.cmbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cmbDanhMuc_SelectedIndexChanged);
            // 
            // pnlHoaDon
            // 
            this.pnlHoaDon.Controls.Add(this.lsvHoaDon);
            this.pnlHoaDon.Location = new System.Drawing.Point(715, 231);
            this.pnlHoaDon.Name = "pnlHoaDon";
            this.pnlHoaDon.Size = new System.Drawing.Size(628, 469);
            this.pnlHoaDon.TabIndex = 2;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDMonAn,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(3, 3);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(618, 463);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // IDMonAn
            // 
            this.IDMonAn.Text = "Tên Món Ăn";
            this.IDMonAn.Width = 138;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn Giá";
            this.DonGia.Width = 136;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số Lượng";
            this.SoLuong.Width = 122;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành Tiền";
            this.ThanhTien.Width = 118;
            // 
            // pnlThanhToan
            // 
            this.pnlThanhToan.Controls.Add(this.btnDT);
            this.pnlThanhToan.Controls.Add(this.btnFix);
            this.pnlThanhToan.Controls.Add(this.txtTongTien);
            this.pnlThanhToan.Controls.Add(this.btnChuyenBan);
            this.pnlThanhToan.Controls.Add(this.cmbChuyenBan);
            this.pnlThanhToan.Controls.Add(this.lblTongTien_text);
            this.pnlThanhToan.Controls.Add(this.btnThanhToan);
            this.pnlThanhToan.Location = new System.Drawing.Point(715, 706);
            this.pnlThanhToan.Name = "pnlThanhToan";
            this.pnlThanhToan.Size = new System.Drawing.Size(628, 117);
            this.pnlThanhToan.TabIndex = 3;
            // 
            // btnDT
            // 
            this.btnDT.Location = new System.Drawing.Point(171, 61);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(111, 40);
            this.btnDT.TabIndex = 28;
            this.btnDT.Text = "Đặt Trước";
            this.btnDT.UseVisualStyleBackColor = true;
            this.btnDT.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(171, 18);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(111, 40);
            this.btnFix.TabIndex = 27;
            this.btnFix.Text = "Sửa Chữa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(303, 61);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(118, 27);
            this.txtTongTien.TabIndex = 26;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenBan.Location = new System.Drawing.Point(13, 18);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(152, 57);
            this.btnChuyenBan.TabIndex = 23;
            this.btnChuyenBan.Text = "Chuyển Bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // cmbChuyenBan
            // 
            this.cmbChuyenBan.FormattingEnabled = true;
            this.cmbChuyenBan.Location = new System.Drawing.Point(13, 81);
            this.cmbChuyenBan.Name = "cmbChuyenBan";
            this.cmbChuyenBan.Size = new System.Drawing.Size(152, 24);
            this.cmbChuyenBan.TabIndex = 25;
            // 
            // lblTongTien_text
            // 
            this.lblTongTien_text.AutoSize = true;
            this.lblTongTien_text.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien_text.Location = new System.Drawing.Point(307, 35);
            this.lblTongTien_text.Name = "lblTongTien_text";
            this.lblTongTien_text.Size = new System.Drawing.Size(96, 23);
            this.lblTongTien_text.TabIndex = 23;
            this.lblTongTien_text.Text = "Tổng Tiền";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(461, 34);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(137, 55);
            this.btnThanhToan.TabIndex = 23;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(12, 13);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(112, 55);
            this.btnTroVe.TabIndex = 21;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // mcNgay
            // 
            this.mcNgay.Location = new System.Drawing.Point(225, 18);
            this.mcNgay.Name = "mcNgay";
            this.mcNgay.TabIndex = 22;
            // 
            // fBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 833);
            this.Controls.Add(this.mcNgay);
            this.Controls.Add(this.pnlThanhToan);
            this.Controls.Add(this.pnlHoaDon);
            this.Controls.Add(this.pnlThemMon);
            this.Controls.Add(this.flpBan);
            this.Controls.Add(this.btnTroVe);
            this.Name = "fBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBanHang";
            this.pnlThemMon.ResumeLayout(false);
            this.pnlThemMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.pnlHoaDon.ResumeLayout(false);
            this.pnlThanhToan.ResumeLayout(false);
            this.pnlThanhToan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.Panel pnlThemMon;
        private System.Windows.Forms.Panel pnlHoaDon;
        private System.Windows.Forms.Panel pnlThanhToan;
        private System.Windows.Forms.ComboBox cmbThucDon;
        private System.Windows.Forms.ComboBox cmbDanhMuc;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Label lblThucDon;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label lblTongTien_text;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.ComboBox cmbChuyenBan;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.ColumnHeader IDMonAn;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.MonthCalendar mcNgay;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.Button btnFix;
    }
}