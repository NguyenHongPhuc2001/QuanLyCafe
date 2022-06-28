
namespace PM_QLCF
{
    partial class fQuanLySanPham
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
            this.lblQuanLySanPham = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.tabctQuanLySanPham = new System.Windows.Forms.TabControl();
            this.tabpDanhMuc = new System.Windows.Forms.TabPage();
            this.btnXoaDM = new System.Windows.Forms.Button();
            this.btnThemDM = new System.Windows.Forms.Button();
            this.btnSuaDM = new System.Windows.Forms.Button();
            this.btnTimKiemDM = new System.Windows.Forms.Button();
            this.lblTenDanhMuc = new System.Windows.Forms.Label();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.IDDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabpThucDon = new System.Windows.Forms.TabPage();
            this.btnSortPrice = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.cbTenDanhMuc = new System.Windows.Forms.ComboBox();
            this.btnXoaTD = new System.Windows.Forms.Button();
            this.btnThemTD = new System.Windows.Forms.Button();
            this.btnSuaTD = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTenMonAn = new System.Windows.Forms.Label();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.btnTimKiemTD = new System.Windows.Forms.Button();
            this.lblDanhMucTD = new System.Windows.Forms.Label();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.IDMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDanhMucTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMucTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabctQuanLySanPham.SuspendLayout();
            this.tabpDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.tabpThucDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanLySanPham
            // 
            this.lblQuanLySanPham.AutoSize = true;
            this.lblQuanLySanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLySanPham.Location = new System.Drawing.Point(275, 15);
            this.lblQuanLySanPham.Name = "lblQuanLySanPham";
            this.lblQuanLySanPham.Size = new System.Drawing.Size(359, 38);
            this.lblQuanLySanPham.TabIndex = 1;
            this.lblQuanLySanPham.Text = "QUẢN LÝ SẢN PHẨM";
            this.lblQuanLySanPham.Click += new System.EventHandler(this.lblQuanLySanPham_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Location = new System.Drawing.Point(12, 12);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(112, 55);
            this.btnTroVe.TabIndex = 2;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // tabctQuanLySanPham
            // 
            this.tabctQuanLySanPham.Controls.Add(this.tabpDanhMuc);
            this.tabctQuanLySanPham.Controls.Add(this.tabpThucDon);
            this.tabctQuanLySanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctQuanLySanPham.Location = new System.Drawing.Point(12, 105);
            this.tabctQuanLySanPham.Name = "tabctQuanLySanPham";
            this.tabctQuanLySanPham.SelectedIndex = 0;
            this.tabctQuanLySanPham.Size = new System.Drawing.Size(968, 639);
            this.tabctQuanLySanPham.TabIndex = 3;
            // 
            // tabpDanhMuc
            // 
            this.tabpDanhMuc.Controls.Add(this.btnXoaDM);
            this.tabpDanhMuc.Controls.Add(this.btnThemDM);
            this.tabpDanhMuc.Controls.Add(this.btnSuaDM);
            this.tabpDanhMuc.Controls.Add(this.btnTimKiemDM);
            this.tabpDanhMuc.Controls.Add(this.lblTenDanhMuc);
            this.tabpDanhMuc.Controls.Add(this.txtTenDanhMuc);
            this.tabpDanhMuc.Controls.Add(this.dgvDanhMuc);
            this.tabpDanhMuc.Location = new System.Drawing.Point(4, 32);
            this.tabpDanhMuc.Name = "tabpDanhMuc";
            this.tabpDanhMuc.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDanhMuc.Size = new System.Drawing.Size(960, 603);
            this.tabpDanhMuc.TabIndex = 0;
            this.tabpDanhMuc.Text = "Danh Mục";
            this.tabpDanhMuc.UseVisualStyleBackColor = true;
            // 
            // btnXoaDM
            // 
            this.btnXoaDM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDM.Location = new System.Drawing.Point(608, 178);
            this.btnXoaDM.Name = "btnXoaDM";
            this.btnXoaDM.Size = new System.Drawing.Size(119, 60);
            this.btnXoaDM.TabIndex = 16;
            this.btnXoaDM.Text = "Xóa";
            this.btnXoaDM.UseVisualStyleBackColor = true;
            this.btnXoaDM.Click += new System.EventHandler(this.btnXoaDM_Click);
            // 
            // btnThemDM
            // 
            this.btnThemDM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDM.Location = new System.Drawing.Point(300, 178);
            this.btnThemDM.Name = "btnThemDM";
            this.btnThemDM.Size = new System.Drawing.Size(119, 60);
            this.btnThemDM.TabIndex = 15;
            this.btnThemDM.Text = "Thêm";
            this.btnThemDM.UseVisualStyleBackColor = true;
            this.btnThemDM.Click += new System.EventHandler(this.btnThemDM_Click);
            // 
            // btnSuaDM
            // 
            this.btnSuaDM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDM.Location = new System.Drawing.Point(455, 178);
            this.btnSuaDM.Name = "btnSuaDM";
            this.btnSuaDM.Size = new System.Drawing.Size(119, 60);
            this.btnSuaDM.TabIndex = 14;
            this.btnSuaDM.Text = "Sửa";
            this.btnSuaDM.UseVisualStyleBackColor = true;
            this.btnSuaDM.Click += new System.EventHandler(this.btnSuaDM_Click);
            // 
            // btnTimKiemDM
            // 
            this.btnTimKiemDM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemDM.Location = new System.Drawing.Point(150, 178);
            this.btnTimKiemDM.Name = "btnTimKiemDM";
            this.btnTimKiemDM.Size = new System.Drawing.Size(119, 60);
            this.btnTimKiemDM.TabIndex = 13;
            this.btnTimKiemDM.Text = "Tìm Kiếm";
            this.btnTimKiemDM.UseVisualStyleBackColor = true;
            this.btnTimKiemDM.Click += new System.EventHandler(this.btnTimKiemDM_Click);
            // 
            // lblTenDanhMuc
            // 
            this.lblTenDanhMuc.AutoSize = true;
            this.lblTenDanhMuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDanhMuc.Location = new System.Drawing.Point(274, 75);
            this.lblTenDanhMuc.Name = "lblTenDanhMuc";
            this.lblTenDanhMuc.Size = new System.Drawing.Size(133, 23);
            this.lblTenDanhMuc.TabIndex = 11;
            this.lblTenDanhMuc.Text = "Tên Danh Mục";
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(426, 72);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(176, 30);
            this.txtTenDanhMuc.TabIndex = 10;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDanhMuc,
            this.STT,
            this.TenDM});
            this.dgvDanhMuc.Location = new System.Drawing.Point(6, 293);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 24;
            this.dgvDanhMuc.Size = new System.Drawing.Size(948, 311);
            this.dgvDanhMuc.TabIndex = 0;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellClick);
            // 
            // IDDanhMuc
            // 
            this.IDDanhMuc.HeaderText = "IDDanhMuc";
            this.IDDanhMuc.MinimumWidth = 6;
            this.IDDanhMuc.Name = "IDDanhMuc";
            this.IDDanhMuc.Visible = false;
            this.IDDanhMuc.Width = 125;
            // 
            // STT
            // 
            this.STT.FillWeight = 193.5829F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 250;
            // 
            // TenDM
            // 
            this.TenDM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDM.FillWeight = 6.417114F;
            this.TenDM.HeaderText = "Tên Danh Mục";
            this.TenDM.MinimumWidth = 6;
            this.TenDM.Name = "TenDM";
            // 
            // tabpThucDon
            // 
            this.tabpThucDon.Controls.Add(this.btnSortPrice);
            this.tabpThucDon.Controls.Add(this.btnSortName);
            this.tabpThucDon.Controls.Add(this.cbTenDanhMuc);
            this.tabpThucDon.Controls.Add(this.btnXoaTD);
            this.tabpThucDon.Controls.Add(this.btnThemTD);
            this.tabpThucDon.Controls.Add(this.btnSuaTD);
            this.tabpThucDon.Controls.Add(this.txtDonGia);
            this.tabpThucDon.Controls.Add(this.lblDonGia);
            this.tabpThucDon.Controls.Add(this.lblTenMonAn);
            this.tabpThucDon.Controls.Add(this.txtTenMonAn);
            this.tabpThucDon.Controls.Add(this.btnTimKiemTD);
            this.tabpThucDon.Controls.Add(this.lblDanhMucTD);
            this.tabpThucDon.Controls.Add(this.dgvThucDon);
            this.tabpThucDon.Location = new System.Drawing.Point(4, 32);
            this.tabpThucDon.Name = "tabpThucDon";
            this.tabpThucDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabpThucDon.Size = new System.Drawing.Size(960, 603);
            this.tabpThucDon.TabIndex = 1;
            this.tabpThucDon.Text = "Thực Đơn";
            this.tabpThucDon.UseVisualStyleBackColor = true;
            // 
            // btnSortPrice
            // 
            this.btnSortPrice.Location = new System.Drawing.Point(309, 224);
            this.btnSortPrice.Name = "btnSortPrice";
            this.btnSortPrice.Size = new System.Drawing.Size(233, 42);
            this.btnSortPrice.TabIndex = 25;
            this.btnSortPrice.Text = "Sắp Xếp Theo Giá";
            this.btnSortPrice.UseVisualStyleBackColor = true;
            this.btnSortPrice.Click += new System.EventHandler(this.btnSortPrice_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(58, 224);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(238, 42);
            this.btnSortName.TabIndex = 24;
            this.btnSortName.Text = "Sắp Xếp Theo Tên";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // cbTenDanhMuc
            // 
            this.cbTenDanhMuc.FormattingEnabled = true;
            this.cbTenDanhMuc.Location = new System.Drawing.Point(309, 32);
            this.cbTenDanhMuc.Name = "cbTenDanhMuc";
            this.cbTenDanhMuc.Size = new System.Drawing.Size(176, 31);
            this.cbTenDanhMuc.TabIndex = 23;
            // 
            // btnXoaTD
            // 
            this.btnXoaTD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTD.Location = new System.Drawing.Point(703, 159);
            this.btnXoaTD.Name = "btnXoaTD";
            this.btnXoaTD.Size = new System.Drawing.Size(119, 60);
            this.btnXoaTD.TabIndex = 22;
            this.btnXoaTD.Text = "Xóa";
            this.btnXoaTD.UseVisualStyleBackColor = true;
            this.btnXoaTD.Click += new System.EventHandler(this.btnXoaTD_Click);
            // 
            // btnThemTD
            // 
            this.btnThemTD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTD.Location = new System.Drawing.Point(703, 78);
            this.btnThemTD.Name = "btnThemTD";
            this.btnThemTD.Size = new System.Drawing.Size(119, 60);
            this.btnThemTD.TabIndex = 21;
            this.btnThemTD.Text = "Thêm";
            this.btnThemTD.UseVisualStyleBackColor = true;
            this.btnThemTD.Click += new System.EventHandler(this.btnThemTD_Click);
            // 
            // btnSuaTD
            // 
            this.btnSuaTD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTD.Location = new System.Drawing.Point(554, 159);
            this.btnSuaTD.Name = "btnSuaTD";
            this.btnSuaTD.Size = new System.Drawing.Size(119, 60);
            this.btnSuaTD.TabIndex = 20;
            this.btnSuaTD.Text = "Sửa";
            this.btnSuaTD.UseVisualStyleBackColor = true;
            this.btnSuaTD.Click += new System.EventHandler(this.btnSuaTD_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(309, 162);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(176, 30);
            this.txtDonGia.TabIndex = 19;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(123, 160);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(81, 23);
            this.lblDonGia.TabIndex = 18;
            this.lblDonGia.Text = "Đơn Giá";
            // 
            // lblTenMonAn
            // 
            this.lblTenMonAn.AutoSize = true;
            this.lblTenMonAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMonAn.Location = new System.Drawing.Point(123, 100);
            this.lblTenMonAn.Name = "lblTenMonAn";
            this.lblTenMonAn.Size = new System.Drawing.Size(114, 23);
            this.lblTenMonAn.TabIndex = 17;
            this.lblTenMonAn.Text = "Tên Món Ăn";
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Location = new System.Drawing.Point(309, 102);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(176, 30);
            this.txtTenMonAn.TabIndex = 16;
            // 
            // btnTimKiemTD
            // 
            this.btnTimKiemTD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTD.Location = new System.Drawing.Point(554, 77);
            this.btnTimKiemTD.Name = "btnTimKiemTD";
            this.btnTimKiemTD.Size = new System.Drawing.Size(119, 60);
            this.btnTimKiemTD.TabIndex = 15;
            this.btnTimKiemTD.Text = "Tìm Kiếm";
            this.btnTimKiemTD.UseVisualStyleBackColor = true;
            this.btnTimKiemTD.Click += new System.EventHandler(this.btnTimKiemTD_Click);
            // 
            // lblDanhMucTD
            // 
            this.lblDanhMucTD.AutoSize = true;
            this.lblDanhMucTD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucTD.Location = new System.Drawing.Point(123, 40);
            this.lblDanhMucTD.Name = "lblDanhMucTD";
            this.lblDanhMucTD.Size = new System.Drawing.Size(133, 23);
            this.lblDanhMucTD.TabIndex = 14;
            this.lblDanhMucTD.Text = "Tên Danh Mục";
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMonAn,
            this.IDDanhMucTD,
            this.STTTD,
            this.DanhMucTD,
            this.TenMonAn,
            this.DonGia});
            this.dgvThucDon.Location = new System.Drawing.Point(6, 306);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.RowHeadersWidth = 51;
            this.dgvThucDon.RowTemplate.Height = 24;
            this.dgvThucDon.Size = new System.Drawing.Size(948, 298);
            this.dgvThucDon.TabIndex = 0;
            this.dgvThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucDon_CellClick);
            // 
            // IDMonAn
            // 
            this.IDMonAn.HeaderText = "IDMonAn";
            this.IDMonAn.MinimumWidth = 6;
            this.IDMonAn.Name = "IDMonAn";
            this.IDMonAn.Visible = false;
            this.IDMonAn.Width = 125;
            // 
            // IDDanhMucTD
            // 
            this.IDDanhMucTD.HeaderText = "IDDanhMuc";
            this.IDDanhMucTD.MinimumWidth = 6;
            this.IDDanhMucTD.Name = "IDDanhMucTD";
            this.IDDanhMucTD.Visible = false;
            this.IDDanhMucTD.Width = 125;
            // 
            // STTTD
            // 
            this.STTTD.HeaderText = "STT";
            this.STTTD.MinimumWidth = 6;
            this.STTTD.Name = "STTTD";
            this.STTTD.Width = 90;
            // 
            // DanhMucTD
            // 
            this.DanhMucTD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DanhMucTD.HeaderText = "Tên Danh Mục";
            this.DanhMucTD.MinimumWidth = 6;
            this.DanhMucTD.Name = "DanhMucTD";
            // 
            // TenMonAn
            // 
            this.TenMonAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMonAn.HeaderText = "Tên Món Ăn";
            this.TenMonAn.MinimumWidth = 6;
            this.TenMonAn.Name = "TenMonAn";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 200;
            // 
            // fQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 756);
            this.Controls.Add(this.tabctQuanLySanPham);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.lblQuanLySanPham);
            this.Name = "fQuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fQuanLySanPham";
            this.tabctQuanLySanPham.ResumeLayout(false);
            this.tabpDanhMuc.ResumeLayout(false);
            this.tabpDanhMuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.tabpThucDon.ResumeLayout(false);
            this.tabpThucDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLySanPham;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.TabControl tabctQuanLySanPham;
        private System.Windows.Forms.TabPage tabpDanhMuc;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.TabPage tabpThucDon;
        private System.Windows.Forms.Label lblTenDanhMuc;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Button btnXoaDM;
        private System.Windows.Forms.Button btnThemDM;
        private System.Windows.Forms.Button btnSuaDM;
        private System.Windows.Forms.Button btnTimKiemDM;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.Button btnXoaTD;
        private System.Windows.Forms.Button btnThemTD;
        private System.Windows.Forms.Button btnSuaTD;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTenMonAn;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.Button btnTimKiemTD;
        private System.Windows.Forms.Label lblDanhMucTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDanhMucTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMucTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.ComboBox cbTenDanhMuc;
        private System.Windows.Forms.Button btnSortPrice;
        private System.Windows.Forms.Button btnSortName;
    }
}