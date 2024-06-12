namespace GUI_QLPT
{
    partial class QuanLyPhong
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
            this.components = new System.ComponentModel.Container();
            this.toolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.btnThemDayTro = new System.Windows.Forms.PictureBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemPhongTro = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPhong = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTro = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbbTrangThaiPhong = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTrong = new System.Windows.Forms.Label();
            this.labelSoPhongChoThue = new System.Windows.Forms.Label();
            this.labelSoPhongTrong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemDayTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemPhongTro)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTipSearch
            // 
            this.toolTipSearch.Tag = "";
            // 
            // btnThemDayTro
            // 
            this.btnThemDayTro.Image = global::GUI_QLPT.Properties.Resources.house;
            this.btnThemDayTro.Location = new System.Drawing.Point(8, 7);
            this.btnThemDayTro.Name = "btnThemDayTro";
            this.btnThemDayTro.Size = new System.Drawing.Size(79, 68);
            this.btnThemDayTro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThemDayTro.TabIndex = 28;
            this.btnThemDayTro.TabStop = false;
            this.toolTipSearch.SetToolTip(this.btnThemDayTro, "Thêm dãy trọ");
            this.btnThemDayTro.Click += new System.EventHandler(this.btnThemDayTro_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTimKiem.BackgroundImage = global::GUI_QLPT.Properties.Resources.icons8_search_64;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Location = new System.Drawing.Point(453, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(61, 50);
            this.btnTimKiem.TabIndex = 26;
            this.toolTipSearch.SetToolTip(this.btnTimKiem, "Tìm kiếm phòng");
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemPhongTro
            // 
            this.btnThemPhongTro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemPhongTro.Image = global::GUI_QLPT.Properties.Resources.plus;
            this.btnThemPhongTro.Location = new System.Drawing.Point(1183, 249);
            this.btnThemPhongTro.Name = "btnThemPhongTro";
            this.btnThemPhongTro.Size = new System.Drawing.Size(80, 61);
            this.btnThemPhongTro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThemPhongTro.TabIndex = 29;
            this.btnThemPhongTro.TabStop = false;
            this.toolTipSearch.SetToolTip(this.btnThemPhongTro, "Thêm phòng trọ");
            this.btnThemPhongTro.Click += new System.EventHandler(this.btnThemPhongTro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Danh sách phòng trọ";
            // 
            // panelPhong
            // 
            this.panelPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPhong.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPhong.Location = new System.Drawing.Point(12, 329);
            this.panelPhong.Name = "panelPhong";
            this.panelPhong.Size = new System.Drawing.Size(1251, 502);
            this.panelPhong.TabIndex = 30;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.68083F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.31917F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1242, 190);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemDayTro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbTro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 89);
            this.panel2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Trọ";
            // 
            // cbbTro
            // 
            this.cbbTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTro.FormattingEnabled = true;
            this.cbbTro.Location = new System.Drawing.Point(153, 25);
            this.cbbTro.Name = "cbbTro";
            this.cbbTro.Size = new System.Drawing.Size(434, 33);
            this.cbbTro.TabIndex = 26;
            this.cbbTro.SelectedIndexChanged += new System.EventHandler(this.cbbTro_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoaiPhong);
            this.groupBox1.Controls.Add(this.cbbTrangThaiPhong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 89);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc kết quả";
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(324, 32);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(263, 33);
            this.cbLoaiPhong.TabIndex = 1;
            // 
            // cbbTrangThaiPhong
            // 
            this.cbbTrangThaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTrangThaiPhong.FormattingEnabled = true;
            this.cbbTrangThaiPhong.Location = new System.Drawing.Point(18, 32);
            this.cbbTrangThaiPhong.Name = "cbbTrangThaiPhong";
            this.cbbTrangThaiPhong.Size = new System.Drawing.Size(277, 33);
            this.cbbTrangThaiPhong.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtSoPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(694, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 89);
            this.panel1.TabIndex = 26;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoPhong.Location = new System.Drawing.Point(93, 26);
            this.txtSoPhong.Multiline = true;
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(354, 39);
            this.txtSoPhong.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Đã cho thuê:";
            // 
            // labelTrong
            // 
            this.labelTrong.AutoSize = true;
            this.labelTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrong.Location = new System.Drawing.Point(570, 265);
            this.labelTrong.Name = "labelTrong";
            this.labelTrong.Size = new System.Drawing.Size(94, 22);
            this.labelTrong.TabIndex = 33;
            this.labelTrong.Text = "Còn trống:";
            // 
            // labelSoPhongChoThue
            // 
            this.labelSoPhongChoThue.AutoSize = true;
            this.labelSoPhongChoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoPhongChoThue.Location = new System.Drawing.Point(670, 265);
            this.labelSoPhongChoThue.Name = "labelSoPhongChoThue";
            this.labelSoPhongChoThue.Size = new System.Drawing.Size(19, 20);
            this.labelSoPhongChoThue.TabIndex = 34;
            this.labelSoPhongChoThue.Text = "0";
            // 
            // labelSoPhongTrong
            // 
            this.labelSoPhongTrong.AutoSize = true;
            this.labelSoPhongTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoPhongTrong.Location = new System.Drawing.Point(489, 265);
            this.labelSoPhongTrong.Name = "labelSoPhongTrong";
            this.labelSoPhongTrong.Size = new System.Drawing.Size(19, 20);
            this.labelSoPhongTrong.TabIndex = 35;
            this.labelSoPhongTrong.Text = "0";
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 843);
            this.Controls.Add(this.btnThemPhongTro);
            this.Controls.Add(this.labelSoPhongTrong);
            this.Controls.Add(this.labelSoPhongChoThue);
            this.Controls.Add(this.labelTrong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelPhong);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.Name = "QuanLyPhong";
            this.Text = "QuanLyPhong";
            this.Load += new System.EventHandler(this.QuanLyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnThemDayTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemPhongTro)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPhong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ComboBox cbbTrangThaiPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTrong;
        private System.Windows.Forms.Label labelSoPhongChoThue;
        private System.Windows.Forms.Label labelSoPhongTrong;
        private System.Windows.Forms.PictureBox btnThemDayTro;
        private System.Windows.Forms.PictureBox btnThemPhongTro;
    }
}