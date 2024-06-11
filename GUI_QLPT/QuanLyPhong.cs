using BUS;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPT
{
    public partial class QuanLyPhong : Form
    {
        public  int IDCHUTRO = ChuTroMain.IDCHUTRO;
        public  string IDTRO = ChuTroMain.IDTRO;
        public  string DIACHI = ChuTroMain.DIACHI;
        #region Custom Group Box
        public class CustomGroupBox : GroupBox
        {
            public CustomGroupBox()
            {
                this.DoubleBuffered = true;
                this.TitleBackColor = Color.SteelBlue;
                this.TitleForeColor = Color.White;
                this.TitleFont = new Font(this.Font.FontFamily, Font.Size + 8, FontStyle.Bold);
                this.BackColor = Color.Transparent;
                this.Radious = 25;
                this.TitleHatchStyle = HatchStyle.Percent60;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                GroupBoxRenderer.DrawParentBackground(e.Graphics, this.ClientRectangle, this);
                var rect = ClientRectangle;
                using (var path = GetRoundRectagle(this.ClientRectangle, Radious))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    rect = new Rectangle(0, 0, rect.Width, TitleFont.Height + Padding.Bottom + Padding.Top);
                    if (this.BackColor != Color.Transparent)
                    {
                        using (var brush = new SolidBrush(BackColor))
                        {
                            e.Graphics.FillPath(brush, path);
                        }
                    }

                    var clip = e.Graphics.ClipBounds;
                    e.Graphics.SetClip(rect);

                    using (var brush = new HatchBrush(TitleHatchStyle, TitleBackColor, ControlPaint.Light(TitleBackColor)))
                    {
                        e.Graphics.FillPath(brush, path);
                    }

                    using (var pen = new Pen(TitleBackColor, 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }

                    TextRenderer.DrawText(e.Graphics, Text, TitleFont, rect, TitleForeColor);
                    e.Graphics.SetClip(clip);

                    using (var pen = new Pen(TitleBackColor, 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }

            public Color TitleBackColor { get; set; }
            public HatchStyle TitleHatchStyle { get; set; }
            public Font TitleFont { get; set; }
            public Color TitleForeColor { get; set; }
            public int Radious { get; set; }

            private GraphicsPath GetRoundRectagle(Rectangle b, int r)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(b.X, b.Y, r, r, 180, 90);
                path.AddArc(b.X + b.Width - r - 1, b.Y, r, r, 270, 90);
                path.AddArc(b.X + b.Width - r - 1, b.Y + b.Height - r - 1, r, r, 0, 90);
                path.AddArc(b.X, b.Y + b.Height - r - 1, r, r, 90, 90);
                path.CloseAllFigures();
                return path;
            }

        }
        #endregion
        public QuanLyPhong()
        {
            InitializeComponent();
            this.InitComboboxTroTheoDiaChi();
            cbbTro.SelectedIndex = 1;
/*            DataTable target = BUS_Phong.Instance.GetPhongMaPhong(IDTRO);
            InitGroupBoxTrangChu(target);
            target = BUS_Phong.Instance.GetPhongMaPhong(IDTRO);
            this.InitGroupBoxTrangChu(target);

            this.InitComboboxTrangThaiPhi();
            this.InitComboboxTrangThaiPhong();
            this.InitComboboxPhongTheoLoai();*/
        }
        private void InitComboboxTrangThaiPhong()
        {
            var trangThaiPhong = new BindingList<KeyValuePair<string, string>>();
            trangThaiPhong.Add(new KeyValuePair<string, string>("", " --- Trạng thái phòng --- "));
            trangThaiPhong.Add(new KeyValuePair<string, string>("0", " --- Chưa thuê --- "));
            trangThaiPhong.Add(new KeyValuePair<string, string>("1", " ---  Đã thuê  --- "));

            this.cbbTrangThaiPhong.DataSource = trangThaiPhong.ToList();
            this.cbbTrangThaiPhong.ValueMember = "Key";
            this.cbbTrangThaiPhong.DisplayMember = "Value";
            this.cbbTrangThaiPhong.SelectedIndex = 0;
        }
        private void InitComboboxTroTheoDiaChi()
        {
            DataTable dt = new DataTable();
            dt = BUS_Tro.Instance.GetDiaChiTroByIDChuTro(IDCHUTRO);
            var DiaChiTro = new BindingList<KeyValuePair<int, string>>();
            DiaChiTro.Add(new KeyValuePair<int, string>(0, "--- Tro ----"));

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["ID_Tro"]);
                DiaChiTro.Add(new KeyValuePair<int, string>(id, dr["DiaChi"].ToString()));
            }
            this.cbbTro.DataSource = DiaChiTro.ToList();
            this.cbbTro.ValueMember = "Key";
            this.cbbTro.DisplayMember = "Value";
            this.cbbTro.SelectedIndex = 0;


        }
        private void InitComboboxPhongTheoLoai()
        {
            DataTable dt = new DataTable();
            dt = BUS_LoaiPhong.Instance.GetLoaiPhongByID(IDTRO);
            var trangThaiPhi = new BindingList<KeyValuePair<string, string>>();
            trangThaiPhi.Add(new KeyValuePair<string, string>("", " --- Loại phòng --- "));

            foreach (DataRow dr in dt.Rows)
            {
                trangThaiPhi.Add(new KeyValuePair<string, string>(dr["ID_LoaiPhong"].ToString(), dr["TenLoaiPhong"].ToString()));
            }
            this.cbLoaiPhong.DataSource = trangThaiPhi;
            this.cbLoaiPhong.ValueMember = "Key";
            this.cbLoaiPhong.DisplayMember = "Value";
            this.cbLoaiPhong.SelectedIndex = 0;
        }
        private void InitComboboxTrangThaiPhi()
        {
            var trangThaiPhi = new BindingList<KeyValuePair<string, string>>();
            trangThaiPhi.Add(new KeyValuePair<string, string>("", " --- Trạng thái phí --- "));
            trangThaiPhi.Add(new KeyValuePair<string, string>("0", " --- Chưa thu phí  --- "));
            trangThaiPhi.Add(new KeyValuePair<string, string>("1", " --- Đã thu phí --- "));

            this.cbLoaiPhong.DataSource = trangThaiPhi;
            this.cbLoaiPhong.ValueMember = "Key";
            this.cbLoaiPhong.DisplayMember = "Value";
            this.cbLoaiPhong.SelectedIndex = 0;
        }
        private void InitGroupBoxTrangChu(DataTable target)
        {
            // khai báo biến
            int sophongthue = 0;
            int sophongtrong = 0;
            int y = 15;
            int x = 15;
            int rowCnt = 0;
            string searchStr = string.Empty;
            string trangThaiPhong = string.Empty;
            string trangThaiPhi = string.Empty;
            this.panelPhong.Controls.Clear();
            this.panelPhong.AutoScroll = true;

            if (this.cbbTrangThaiPhong.SelectedValue != null)
            {
                trangThaiPhong = this.cbbTrangThaiPhong.SelectedValue.ToString();
            }

            if (this.cbLoaiPhong.SelectedValue != null)
            {
                trangThaiPhi = this.cbLoaiPhong.SelectedValue.ToString();
            }

            if (!string.IsNullOrEmpty(this.txtSoPhong.Text.ToString()))
            {
                searchStr = this.txtSoPhong.Text;
            }
            if (target != null && target.Rows.Count > 0)
            {
                // lặp qua sanh sách phòng
                foreach (DataRow row in target.Rows)
                {
                    int ii = 0;
                    // Group box phòng
                    CustomGroupBox gb = new CustomGroupBox();
                    gb.Name = "groupBoxPhong" + row["TenPhong"].ToString();
                    gb.Text = "Phòng " + row["TenPhong"].ToString();
                    gb.Size = new Size(230, 140);

                    if (row["TrangThai"].ToString() == "1")
                    {
                        sophongthue += 1;
                        gb.TitleBackColor = Color.Tan;
                    }
                    if (row["TrangThai"].ToString() == "0")
                    {
                        sophongtrong += 1;
                    }
                    // chiều ngang
                    x = 15 + (15 * rowCnt) + (230 * rowCnt);

                    // chiều dọc
                    // xuống dòng khi đủ 3 phòng trên 1 row
                    if (x > 750)
                    {
                        x = 15;
                        y = y + 175;
                        rowCnt = 0;
                    }

                    // set vị trí cho group box
                    gb.Location = new Point(x, y);

                    // label tên khách hàng
                    // Value tên khách hàng
                    Label LabName = new Label();
                    Label valueName = new Label();
                    //if (string.IsNullOrEmpty(row["ID_KhachHang"].ToString()))
                    //{
                    //    LabName.Name = "LabelTenKhachHang" + ii;
                    //    valueName.Name = "TenKhachHang" + ii;
                    //    valueName.Text = "Chưa thuê";
                    //}
                    //else
                    //{
                    //    LabName.Name = "LabelTenKhachHang" + row["ID_KhachHang"].ToString();
                    //    valueName.Name = "TenKhachHang" + row["ID_KhachHang"].ToString();
                    //    valueName.Text = row["TenKhachHang"].ToString();
                    //}

                    //LabName.Text = "Khách hàng:";
                    //LabName.Location = new Point(15, 35);
                    //gb.Controls.Add(LabName);

                    Button btnChiTiet = new Button();
                    btnChiTiet.Name = row["ID_Phong"].ToString();
                    btnChiTiet.Text = "Xem";
                    btnChiTiet.Size = new Size(56, 25);
                    btnChiTiet.Location = new Point(35, 105);
                    btnChiTiet.Click += btnChiTiet_Click;
                    gb.Controls.Add(btnChiTiet);

                    // button xóa
                    Button btnXoa = new Button();
                    btnXoa.Name = row["ID_Phong"].ToString();
                    btnXoa.Text = "Xóa";
                    btnXoa.Size = new Size(56, 25);
                    btnXoa.Location = new Point(141, 105);
                    btnXoa.Click += ButtonXoa_Click;
                    gb.Controls.Add(btnXoa);

                    valueName.Location = new Point(113, 35);
                    gb.Controls.Add(valueName);

                    // label giá
                    Label LabGia = new Label();
                    LabGia.Name = "LabelGia" + row["ID_Phong"].ToString();
                    LabGia.Text = "Giá:";
                    LabGia.Location = new Point(15, 58);
                    gb.Controls.Add(LabGia);

                    // Value giá
                    Label valueGia = new Label();
                    valueGia.Name = "txtGia" + row["ID_Phong"].ToString();
                    valueGia.Text = row["Gia"].ToString();
                    valueGia.Location = new Point(113, 58);
                    valueGia.BorderStyle = BorderStyle.None;
                    gb.Controls.Add(valueGia);

                    // label loại phòng
                    Label labLoaiPhong = new Label();
                    labLoaiPhong.Name = "LabLoaiPhong" + row["ID_Phong"].ToString();
                    labLoaiPhong.Text = "Loại phòng:";
                    labLoaiPhong.Location = new Point(15, 81);
                    labLoaiPhong.Size = new Size(80, 20);
                    gb.Controls.Add(labLoaiPhong);

                    // Value giá
                    Label valueLoaiPhong = new Label();
                    valueLoaiPhong.Name = "cbLoaiPhong" + row["ID_Phong"].ToString();
                    valueLoaiPhong.Text = row["TenLoaiPhong"].ToString();
                    valueLoaiPhong.Location = new Point(113, 81);
                    valueLoaiPhong.Size = new Size(60, 20);
                    gb.Controls.Add(valueLoaiPhong);

                    // thêm group box vào danh sách phòng
                    panelPhong.Controls.Add(gb);
                    rowCnt++;
                    ii++;

                    labelSoPhongChoThue.Text = sophongtrong.ToString();
                    labelSoPhongTrong.Text = sophongthue.ToString();
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string id = button.Name.ToString();
            ThemPhong f = new ThemPhong(IDTRO, false, id);
            this.Hide();
            var result=f.ShowDialog();
            this.Show();
            if (result == DialogResult.OK)
            {
                DataTable target = BUS_Phong.Instance.GetPhongMaPhong(IDTRO);
                this.InitGroupBoxTrangChu(target);
            }
        }
        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string id = button.Name;
            DataTable dt = BUS_Phong.Instance.GetPhongMaPhongByTinhTrangAndID("1", id, IDTRO);
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Phòng đang được thuê, không thể xóa");
                return;
            }
            MessageBox.Show(id);
            BUS_ThongKe.Instance.Delete(id);
            BUS_TongTien.Instance.DeleteByID(id);
            BUS_DienNuoc.Instance.Delete(id);
            BUS_Phong.Instance.Delete(id);



            DataTable target = BUS_Phong.Instance.GetPhongMaPhong(IDTRO);
            this.InitGroupBoxTrangChu(target);

        }
        private void QuanLyPhong_Load(object sender, EventArgs e)
        {

        }

        private void cbbTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedKeyValuePair = (KeyValuePair<int, string>)this.cbbTro.SelectedItem;
            IDTRO = selectedKeyValuePair.Key.ToString();
            DIACHI = selectedKeyValuePair.Value;
            DataTable target = BUS_Phong.Instance.GetPhongMaPhong(IDTRO);
            this.InitGroupBoxTrangChu(target);

            this.InitComboboxTrangThaiPhi();
            this.InitComboboxTrangThaiPhong();
            this.InitComboboxPhongTheoLoai();
            ChuTroMain.IDTRO=IDTRO;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maPhong = txtSoPhong.Text.Trim();
            string trangThaiPhong = cbbTrangThaiPhong.SelectedValue?.ToString() ?? string.Empty;
            string loaiPhong = cbLoaiPhong.SelectedValue?.ToString() ?? string.Empty;
            DataTable target = new DataTable();
            if (!string.IsNullOrEmpty(maPhong))
            {
                // Nếu nhập mã phòng, tìm theo mã phòng
                if (!string.IsNullOrEmpty(trangThaiPhong) && (trangThaiPhong == "0" || trangThaiPhong == "1"))
                {
                    target = BUS_Phong.Instance.GetPhongMaPhongByTinhTrangAndID(trangThaiPhong, maPhong, IDTRO);
                }
                else
                {
                    target = BUS_Phong.Instance.GetPhongMaPhongByID(maPhong, IDTRO);
                }
            }
            else if (!string.IsNullOrEmpty(trangThaiPhong) && (trangThaiPhong == "0" || trangThaiPhong == "1"))
            {
                if (!string.IsNullOrEmpty(loaiPhong))
                {
                    // Nếu chọn cả tình trạng phòng và loại phòng
                    target = BUS_Phong.Instance.GetPhongByTinhTrangAndLoaiPhong(trangThaiPhong, loaiPhong, IDTRO);
                }
                else
                {
                    // Nếu chỉ chọn tình trạng phòng
                    target = BUS_Phong.Instance.GetPhongMaPhongByTinhTrang(trangThaiPhong, IDTRO);
                }
            }
            else if (!string.IsNullOrEmpty(loaiPhong))
            {
                // Nếu chỉ chọn loại phòng
                target = BUS_Phong.Instance.GetPhongByLoaiPhong(loaiPhong, IDTRO);
            }
            else
            {
                // Nếu không chọn gì hoặc không nhập mã phòng, trả về tất cả các phòng
                target = BUS_Phong.Instance.GetPhongMaPhong(IDTRO);
            }
            this.InitGroupBoxTrangChu(target);
        }

        private void btnThemPhongTro_Click(object sender, EventArgs e)
        {
            ThemPhong f = new ThemPhong(IDTRO, true);
            this.Hide();
            f.ShowDialog();
            this.Show();
            DataTable target = BUS_Phong.Instance.GetPhongMaPhong(IDTRO);
            this.InitGroupBoxTrangChu(target);
        }

        private void btnThemDayTro_Click(object sender, EventArgs e)
        {
            ThemDayTro f = new ThemDayTro(IDCHUTRO.ToString());
            this.Hide();
            f.ShowDialog();
            this.Show();
            InitComboboxTroTheoDiaChi();
        }
    }
}
