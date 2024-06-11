namespace GUI_QLPT
{
    partial class TinhTien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTinhTien = new System.Windows.Forms.DataGridView();
            this.ID_Phong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CongNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_SoDien2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_SoNuoc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_KhachHang2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoTienDaThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoTienChuaThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbbTinhTrangPhong = new System.Windows.Forms.ComboBox();
            this.btnTImKiemTinhTien = new System.Windows.Forms.Button();
            this.txtTImKiemTinhTien = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnRESET = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTinhTien)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewTinhTien);
            this.groupBox1.Location = new System.Drawing.Point(32, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 410);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng";
            // 
            // dataGridViewTinhTien
            // 
            this.dataGridViewTinhTien.AllowUserToAddRows = false;
            this.dataGridViewTinhTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTinhTien.ColumnHeadersHeight = 50;
            this.dataGridViewTinhTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Phong2,
            this.ID_CongNo2,
            this.TrangThai2,
            this.ID_SoDien2,
            this.ID_SoNuoc2,
            this.ID_KhachHang2,
            this.TenKhachHang2,
            this.DuNo,
            this.TongSoTien,
            this.TongSoTienDaThanhToan,
            this.TongSoTienChuaThanhToan});
            this.dataGridViewTinhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTinhTien.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewTinhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTinhTien.Name = "dataGridViewTinhTien";
            this.dataGridViewTinhTien.RowHeadersWidth = 82;
            this.dataGridViewTinhTien.RowTemplate.Height = 24;
            this.dataGridViewTinhTien.Size = new System.Drawing.Size(1093, 385);
            this.dataGridViewTinhTien.TabIndex = 1;
            // 
            // ID_Phong2
            // 
            this.ID_Phong2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID_Phong2.DataPropertyName = "ID_Phong";
            this.ID_Phong2.FillWeight = 40.98361F;
            this.ID_Phong2.Frozen = true;
            this.ID_Phong2.HeaderText = "Mã số phòng";
            this.ID_Phong2.MinimumWidth = 10;
            this.ID_Phong2.Name = "ID_Phong2";
            this.ID_Phong2.Width = 136;
            // 
            // ID_CongNo2
            // 
            this.ID_CongNo2.DataPropertyName = "ID_CongNo";
            this.ID_CongNo2.HeaderText = "ID_CongNo";
            this.ID_CongNo2.MinimumWidth = 10;
            this.ID_CongNo2.Name = "ID_CongNo2";
            this.ID_CongNo2.Visible = false;
            // 
            // TrangThai2
            // 
            this.TrangThai2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TrangThai2.DataPropertyName = "TrangThai";
            this.TrangThai2.HeaderText = "Trạng thái";
            this.TrangThai2.MinimumWidth = 10;
            this.TrangThai2.Name = "TrangThai2";
            this.TrangThai2.Width = 150;
            // 
            // ID_SoDien2
            // 
            this.ID_SoDien2.DataPropertyName = "ID_SoDien";
            this.ID_SoDien2.HeaderText = "ID_SoDien2";
            this.ID_SoDien2.MinimumWidth = 10;
            this.ID_SoDien2.Name = "ID_SoDien2";
            this.ID_SoDien2.Visible = false;
            // 
            // ID_SoNuoc2
            // 
            this.ID_SoNuoc2.DataPropertyName = "ID_SoNuoc";
            this.ID_SoNuoc2.HeaderText = "ID_SoNuoc2";
            this.ID_SoNuoc2.MinimumWidth = 10;
            this.ID_SoNuoc2.Name = "ID_SoNuoc2";
            this.ID_SoNuoc2.Visible = false;
            // 
            // ID_KhachHang2
            // 
            this.ID_KhachHang2.DataPropertyName = "ID_KhachHang";
            this.ID_KhachHang2.HeaderText = "ID_KhachHang";
            this.ID_KhachHang2.MinimumWidth = 10;
            this.ID_KhachHang2.Name = "ID_KhachHang2";
            this.ID_KhachHang2.Visible = false;
            // 
            // TenKhachHang2
            // 
            this.TenKhachHang2.DataPropertyName = "TenKhachHang";
            this.TenKhachHang2.HeaderText = "Tên khách hàng";
            this.TenKhachHang2.MinimumWidth = 10;
            this.TenKhachHang2.Name = "TenKhachHang2";
            this.TenKhachHang2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenKhachHang2.Visible = false;
            // 
            // DuNo
            // 
            this.DuNo.DataPropertyName = "DuNo";
            this.DuNo.FillWeight = 55.58263F;
            this.DuNo.HeaderText = "Dư nợ";
            this.DuNo.MinimumWidth = 10;
            this.DuNo.Name = "DuNo";
            // 
            // TongSoTien
            // 
            this.TongSoTien.DataPropertyName = "TongSoTien";
            this.TongSoTien.FillWeight = 46.68619F;
            this.TongSoTien.HeaderText = "Tông số tiền";
            this.TongSoTien.MinimumWidth = 10;
            this.TongSoTien.Name = "TongSoTien";
            // 
            // TongSoTienDaThanhToan
            // 
            this.TongSoTienDaThanhToan.DataPropertyName = "TongSoTienDaThanhToan";
            this.TongSoTienDaThanhToan.FillWeight = 58.0015F;
            this.TongSoTienDaThanhToan.HeaderText = "Tổng số tiền đã thanh toán";
            this.TongSoTienDaThanhToan.MinimumWidth = 10;
            this.TongSoTienDaThanhToan.Name = "TongSoTienDaThanhToan";
            // 
            // TongSoTienChuaThanhToan
            // 
            this.TongSoTienChuaThanhToan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TongSoTienChuaThanhToan.DataPropertyName = "TongSoTienChuaThanhToan";
            this.TongSoTienChuaThanhToan.FillWeight = 200F;
            this.TongSoTienChuaThanhToan.HeaderText = "Tổng số tiền chưa thanh toán";
            this.TongSoTienChuaThanhToan.MinimumWidth = 10;
            this.TongSoTienChuaThanhToan.Name = "TongSoTienChuaThanhToan";
            this.TongSoTienChuaThanhToan.Width = 177;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.cbbTinhTrangPhong);
            this.groupBox6.Controls.Add(this.btnTImKiemTinhTien);
            this.groupBox6.Controls.Add(this.txtTImKiemTinhTien);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(21, 18);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(430, 179);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tìm kiếm";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 128);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Trả phòng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(30, 111);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(198, 20);
            this.label21.TabIndex = 8;
            this.label21.Text = "Phòng/ Tên khách hàng";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 20);
            this.label20.TabIndex = 7;
            this.label20.Text = "Trạng thái";
            // 
            // cbbTinhTrangPhong
            // 
            this.cbbTinhTrangPhong.FormattingEnabled = true;
            this.cbbTinhTrangPhong.Location = new System.Drawing.Point(30, 53);
            this.cbbTinhTrangPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTinhTrangPhong.Name = "cbbTinhTrangPhong";
            this.cbbTinhTrangPhong.Size = new System.Drawing.Size(202, 28);
            this.cbbTinhTrangPhong.TabIndex = 6;
            this.cbbTinhTrangPhong.SelectedIndexChanged += new System.EventHandler(this.cbbTinhTrangPhongcbbTinhTrangPhong_SelectedIndexChanged);
            // 
            // btnTImKiemTinhTien
            // 
            this.btnTImKiemTinhTien.Location = new System.Drawing.Point(251, 47);
            this.btnTImKiemTinhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTImKiemTinhTien.Name = "btnTImKiemTinhTien";
            this.btnTImKiemTinhTien.Size = new System.Drawing.Size(123, 34);
            this.btnTImKiemTinhTien.TabIndex = 2;
            this.btnTImKiemTinhTien.Text = "Tìm kiếm";
            this.btnTImKiemTinhTien.UseVisualStyleBackColor = true;
            this.btnTImKiemTinhTien.Click += new System.EventHandler(this.btnTImKiemTinhTien_Click);
            // 
            // txtTImKiemTinhTien
            // 
            this.txtTImKiemTinhTien.Location = new System.Drawing.Point(30, 140);
            this.txtTImKiemTinhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTImKiemTinhTien.Name = "txtTImKiemTinhTien";
            this.txtTImKiemTinhTien.Size = new System.Drawing.Size(202, 26);
            this.txtTImKiemTinhTien.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 20);
            this.label19.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox10.Controls.Add(this.btnRESET);
            this.groupBox10.Controls.Add(this.txtNo);
            this.groupBox10.Controls.Add(this.txtThang);
            this.groupBox10.Controls.Add(this.label25);
            this.groupBox10.Controls.Add(this.label12);
            this.groupBox10.Controls.Add(this.btnThanhToan);
            this.groupBox10.Location = new System.Drawing.Point(536, 18);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(592, 179);
            this.groupBox10.TabIndex = 18;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tính tiền";
            // 
            // btnRESET
            // 
            this.btnRESET.Location = new System.Drawing.Point(431, 118);
            this.btnRESET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(149, 38);
            this.btnRESET.TabIndex = 9;
            this.btnRESET.Text = "Reset";
            this.btnRESET.UseVisualStyleBackColor = true;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(160, 126);
            this.txtNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(240, 26);
            this.txtNo.TabIndex = 4;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(160, 66);
            this.txtThang.Margin = new System.Windows.Forms.Padding(2);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(240, 26);
            this.txtThang.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 127);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 20);
            this.label25.TabIndex = 2;
            this.label25.Text = "Trả tiền nợ:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Trả tiền tháng:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(431, 54);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(149, 38);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // TinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 644);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.Name = "TinhTien";
            this.Text = "TinhTien";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTinhTien)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewTinhTien;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbbTinhTrangPhong;
        private System.Windows.Forms.Button btnTImKiemTinhTien;
        private System.Windows.Forms.TextBox txtTImKiemTinhTien;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Phong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CongNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SoDien2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SoNuoc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_KhachHang2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoTienDaThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoTienChuaThanhToan;
    }
}