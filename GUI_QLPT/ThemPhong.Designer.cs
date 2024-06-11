namespace GUI_QLPT
{
    partial class ThemPhong
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
            this.btnThem = new System.Windows.Forms.Button();
            this.labelHienThi = new System.Windows.Forms.Label();
            this.btnXemHoaDon = new System.Windows.Forms.Button();
            this.btnXemKhach = new System.Windows.Forms.Button();
            this.dataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxIdPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.dateTimePickerKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBatDau = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTenPhong = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTienDien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienNuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnThem.Location = new System.Drawing.Point(468, 307);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(217, 46);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Cập nhật";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelHienThi
            // 
            this.labelHienThi.AutoSize = true;
            this.labelHienThi.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHienThi.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelHienThi.Location = new System.Drawing.Point(2, 359);
            this.labelHienThi.Name = "labelHienThi";
            this.labelHienThi.Size = new System.Drawing.Size(154, 27);
            this.labelHienThi.TabIndex = 16;
            this.labelHienThi.Text = "Đang hiển thị:";
            // 
            // btnXemHoaDon
            // 
            this.btnXemHoaDon.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXemHoaDon.Location = new System.Drawing.Point(942, 359);
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.Size = new System.Drawing.Size(217, 46);
            this.btnXemHoaDon.TabIndex = 15;
            this.btnXemHoaDon.Text = "Xem lịch sử hoá đơn";
            this.btnXemHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnXemKhach
            // 
            this.btnXemKhach.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXemKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKhach.ForeColor = System.Drawing.Color.White;
            this.btnXemKhach.Location = new System.Drawing.Point(659, 359);
            this.btnXemKhach.Name = "btnXemKhach";
            this.btnXemKhach.Size = new System.Drawing.Size(246, 46);
            this.btnXemKhach.TabIndex = 14;
            this.btnXemKhach.Text = "Xem danh sách khách trọ";
            this.btnXemKhach.UseVisualStyleBackColor = false;
            // 
            // dataGridViewKhachHang
            // 
            this.dataGridViewKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhachHang.Location = new System.Drawing.Point(7, 416);
            this.dataGridViewKhachHang.Name = "dataGridViewKhachHang";
            this.dataGridViewKhachHang.RowHeadersWidth = 62;
            this.dataGridViewKhachHang.RowTemplate.Height = 28;
            this.dataGridViewKhachHang.Size = new System.Drawing.Size(1152, 261);
            this.dataGridViewKhachHang.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTienNuoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTienDien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBoxIdPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxGia);
            this.groupBox1.Controls.Add(this.dateTimePickerKetThuc);
            this.groupBox1.Controls.Add(this.dateTimePickerBatDau);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 227);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // textBoxIdPhong
            // 
            this.textBoxIdPhong.Location = new System.Drawing.Point(251, 166);
            this.textBoxIdPhong.Name = "textBoxIdPhong";
            this.textBoxIdPhong.Size = new System.Drawing.Size(152, 26);
            this.textBoxIdPhong.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Loại phòng";
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(652, 111);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.Size = new System.Drawing.Size(179, 26);
            this.textBoxGia.TabIndex = 7;
            // 
            // dateTimePickerKetThuc
            // 
            this.dateTimePickerKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerKetThuc.Location = new System.Drawing.Point(251, 109);
            this.dateTimePickerKetThuc.Name = "dateTimePickerKetThuc";
            this.dateTimePickerKetThuc.Size = new System.Drawing.Size(152, 26);
            this.dateTimePickerKetThuc.TabIndex = 6;
            // 
            // dateTimePickerBatDau
            // 
            this.dateTimePickerBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBatDau.Location = new System.Drawing.Point(251, 49);
            this.dateTimePickerBatDau.Name = "dateTimePickerBatDau";
            this.dateTimePickerBatDau.Size = new System.Drawing.Size(152, 26);
            this.dateTimePickerBatDau.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(467, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời hạn kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian bắt đầu thuê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Phòng";
            // 
            // labelTenPhong
            // 
            this.labelTenPhong.AutoSize = true;
            this.labelTenPhong.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenPhong.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelTenPhong.Location = new System.Drawing.Point(482, 16);
            this.labelTenPhong.Name = "labelTenPhong";
            this.labelTenPhong.Size = new System.Drawing.Size(203, 40);
            this.labelTenPhong.TabIndex = 11;
            this.labelTenPhong.Text = "Tên Phòng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(652, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTienDien
            // 
            this.txtTienDien.Location = new System.Drawing.Point(652, 164);
            this.txtTienDien.Name = "txtTienDien";
            this.txtTienDien.ReadOnly = true;
            this.txtTienDien.Size = new System.Drawing.Size(136, 26);
            this.txtTienDien.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(467, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giá điện";
            // 
            // txtTienNuoc
            // 
            this.txtTienNuoc.Location = new System.Drawing.Point(999, 162);
            this.txtTienNuoc.Name = "txtTienNuoc";
            this.txtTienNuoc.ReadOnly = true;
            this.txtTienNuoc.Size = new System.Drawing.Size(136, 26);
            this.txtTienNuoc.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(843, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "Giá Nước";
            // 
            // ThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 690);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelHienThi);
            this.Controls.Add(this.btnXemHoaDon);
            this.Controls.Add(this.btnXemKhach);
            this.Controls.Add(this.dataGridViewKhachHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTenPhong);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThemPhong";
            this.Text = "ThemPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label labelHienThi;
        private System.Windows.Forms.Button btnXemHoaDon;
        private System.Windows.Forms.Button btnXemKhach;
        private System.Windows.Forms.DataGridView dataGridViewKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxIdPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.DateTimePicker dateTimePickerKetThuc;
        private System.Windows.Forms.DateTimePicker dateTimePickerBatDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTenPhong;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtTienNuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTienDien;
        private System.Windows.Forms.Label label6;
    }
}