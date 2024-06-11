namespace GUI_QLPT
{
    partial class BaoCao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbSoPhongThue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTongSoPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDoanhThuThang = new System.Windows.Forms.Label();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbLoiNhuanThang = new System.Windows.Forms.Label();
            this.lbTongLoiNhuan = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbTro = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(800, 489);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1257, 179);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lbSoPhongThue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbTongSoPhong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 176);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI_QLPT.Properties.Resources.construction;
            this.pictureBox3.Location = new System.Drawing.Point(23, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // lbSoPhongThue
            // 
            this.lbSoPhongThue.AutoSize = true;
            this.lbSoPhongThue.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoPhongThue.ForeColor = System.Drawing.Color.White;
            this.lbSoPhongThue.Location = new System.Drawing.Point(269, 124);
            this.lbSoPhongThue.Name = "lbSoPhongThue";
            this.lbSoPhongThue.Size = new System.Drawing.Size(36, 27);
            this.lbSoPhongThue.TabIndex = 3;
            this.lbSoPhongThue.Text = "15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số phòng được thuê";
            // 
            // lbTongSoPhong
            // 
            this.lbTongSoPhong.AutoSize = true;
            this.lbTongSoPhong.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSoPhong.ForeColor = System.Drawing.Color.White;
            this.lbTongSoPhong.Location = new System.Drawing.Point(254, 63);
            this.lbTongSoPhong.Name = "lbTongSoPhong";
            this.lbTongSoPhong.Size = new System.Drawing.Size(68, 45);
            this.lbTongSoPhong.TabIndex = 1;
            this.lbTongSoPhong.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số phòng";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbDoanhThuThang);
            this.panel2.Controls.Add(this.lbTongDoanhThu);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(387, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 176);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI_QLPT.Properties.Resources.money;
            this.pictureBox2.Location = new System.Drawing.Point(22, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tháng này";
            // 
            // lbDoanhThuThang
            // 
            this.lbDoanhThuThang.AutoSize = true;
            this.lbDoanhThuThang.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhThuThang.ForeColor = System.Drawing.Color.White;
            this.lbDoanhThuThang.Location = new System.Drawing.Point(263, 124);
            this.lbDoanhThuThang.Name = "lbDoanhThuThang";
            this.lbDoanhThuThang.Size = new System.Drawing.Size(53, 27);
            this.lbDoanhThuThang.TabIndex = 4;
            this.lbDoanhThuThang.Text = "96,3";
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongDoanhThu.AutoSize = true;
            this.lbTongDoanhThu.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongDoanhThu.ForeColor = System.Drawing.Color.White;
            this.lbTongDoanhThu.Location = new System.Drawing.Point(181, 62);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(154, 45);
            this.lbTongDoanhThu.TabIndex = 5;
            this.lbTongDoanhThu.Text = "1232,3";
            this.lbTongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng doanh thu";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lbLoiNhuanThang);
            this.panel3.Controls.Add(this.lbTongLoiNhuan);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(777, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 176);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_QLPT.Properties.Resources.give_money;
            this.pictureBox1.Location = new System.Drawing.Point(22, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tháng này";
            // 
            // lbLoiNhuanThang
            // 
            this.lbLoiNhuanThang.AutoSize = true;
            this.lbLoiNhuanThang.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoiNhuanThang.ForeColor = System.Drawing.Color.White;
            this.lbLoiNhuanThang.Location = new System.Drawing.Point(273, 124);
            this.lbLoiNhuanThang.Name = "lbLoiNhuanThang";
            this.lbLoiNhuanThang.Size = new System.Drawing.Size(53, 27);
            this.lbLoiNhuanThang.TabIndex = 4;
            this.lbLoiNhuanThang.Text = "22,5";
            // 
            // lbTongLoiNhuan
            // 
            this.lbTongLoiNhuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongLoiNhuan.AutoSize = true;
            this.lbTongLoiNhuan.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongLoiNhuan.ForeColor = System.Drawing.Color.White;
            this.lbTongLoiNhuan.Location = new System.Drawing.Point(206, 63);
            this.lbTongLoiNhuan.Name = "lbTongLoiNhuan";
            this.lbTongLoiNhuan.Size = new System.Drawing.Size(130, 45);
            this.lbTongLoiNhuan.TabIndex = 5;
            this.lbTongLoiNhuan.Text = "512,3";
            this.lbTongLoiNhuan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(17, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 27);
            this.label12.TabIndex = 4;
            this.label12.Text = "Lợi nhuận";
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(43, 369);
            this.chart3.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(1124, 504);
            this.chart3.TabIndex = 7;
            this.chart3.Text = "chart3";
            // 
            // cbTro
            // 
            this.cbTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.cbTro.FormattingEnabled = true;
            this.cbTro.Location = new System.Drawing.Point(127, 76);
            this.cbTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTro.Name = "cbTro";
            this.cbTro.Size = new System.Drawing.Size(412, 37);
            this.cbTro.TabIndex = 14;
            this.cbTro.SelectedIndexChanged += new System.EventHandler(this.cbTro_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.label28.Location = new System.Drawing.Point(42, 76);
            this.label28.MaximumSize = new System.Drawing.Size(102, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 32);
            this.label28.TabIndex = 13;
            this.label28.Text = "Trọ:";
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 885);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.cbTro);
            this.Controls.Add(this.label28);
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbSoPhongThue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTongSoPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbDoanhThuThang;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbLoiNhuanThang;
        private System.Windows.Forms.Label lbTongLoiNhuan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.ComboBox cbTro;
        private System.Windows.Forms.Label label28;
    }
}