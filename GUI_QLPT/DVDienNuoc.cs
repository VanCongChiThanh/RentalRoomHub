using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPT
{
    public partial class DVDienNuoc : Form
    {
        string IDTRO=ChuTroMain.IDTRO;
        int IDCHUTRO = ChuTroMain.IDCHUTRO;
        string DIACHI = ChuTroMain.DIACHI;
        public DVDienNuoc()
        {
            InitializeComponent();
            SetUI();
            this.dataGridViewLoaiTro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaiTro_CellClick);
            comboBox1.SelectedIndex = 1;
        }
        public void SetUI()
        {
            txtGiaNuoc.ReadOnly = true;
            txtGiaDien.ReadOnly = true;
            InitTabDienNuoc(BUS_DienNuoc.Instance.GetDienNuocAll(IDTRO));
            dataGridViewLoaiTro.DefaultCellStyle.ForeColor = Color.Black;
            InitComboboxTroTheoDiaChi();
            InitComboBoxInitTabQuanLyTienPhong();
            dataGridViewLoaiTro.DataSource = BUS_LoaiPhong.Instance.GetLoaiPhongByIDTRO(IDTRO.ToString());
            dataGridViewLoaiTro.DataBindingComplete += dataGridViewLoaiTro_DataBindingComplete;
        }
        private void dataGridViewLoaiTro_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Ví dụ chỉ hiển thị 'TenLoaiPhong' và 'Gia'
            foreach (DataGridViewColumn column in dataGridViewLoaiTro.Columns)
            {
                if (column.Name != "TenLoaiPhong" && column.Name != "Gia")
                {
                    column.Visible = false;
                }
            }
        }

        private void InitComboBoxInitTabQuanLyTienPhong()
        {
            var trangThaiPhong = new BindingList<KeyValuePair<string, string>>();
            trangThaiPhong.Add(new KeyValuePair<string, string>("", " --- Trạng thái phòng --- "));
            trangThaiPhong.Add(new KeyValuePair<string, string>("0", " --- Trống --- "));
            trangThaiPhong.Add(new KeyValuePair<string, string>("1", " ---  Đang thuê --- "));

            this.cbTrangThai.DataSource = trangThaiPhong;
            this.cbTrangThai.ValueMember = "Key";
            this.cbTrangThai.DisplayMember = "Value";
            this.cbTrangThai.SelectedIndex = 0;
        }
        private void InitTabDienNuoc(DataTable dt)
        {
            DataGridViewColumn columnA = dataGridViewSoDienNuoc.Columns["TienPhong"];
            columnA.DisplayIndex = dataGridViewSoDienNuoc.Columns.Count - 2;
            dataGridViewSoDienNuoc.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["TrangThai"].ToString().Equals("1"))
                {
                    dataGridViewSoDienNuoc.RowCount = dt.Rows.Count;
                    dataGridViewSoDienNuoc.Rows[i].Cells["ID_Phong1"].Value = dt.Rows[i]["ID_Phong"].ToString();

                    dataGridViewSoDienNuoc.Rows[i].Cells["SoDienCu"].Value = dt.Rows[i]["SoDienHienTai"].ToString();
                    dataGridViewSoDienNuoc.Rows[i].Cells["Name_Phong"].Value = dt.Rows[i]["TenPhong"].ToString();

                    dataGridViewSoDienNuoc.Rows[i].Cells["TrangThai"].Value = "Đang thuê";
                    dataGridViewSoDienNuoc.Rows[i].Cells["SoDienMoi"].Value = '0';

                    dataGridViewSoDienNuoc.Rows[i].Cells["SoNuocCu"].Value = dt.Rows[i]["SoNuocHienTai"].ToString();
                    dataGridViewSoDienNuoc.Rows[i].Cells["TienPhong"].Value = dt.Rows[i]["Gia"].ToString();
                    dataGridViewSoDienNuoc.Rows[i].Cells["SoNuocMoi"].Value = '0';

                    dataGridViewSoDienNuoc.Rows[i].Cells["SoDienSuDung"].Value = '0';
                    dataGridViewSoDienNuoc.Rows[i].Cells["SoNuocSuDung"].Value = '0';

                    dataGridViewSoDienNuoc.Rows[i].Cells["DonGiaDien"].Value = dt.Rows[i]["DonGiaDien"].ToString();
                    dataGridViewSoDienNuoc.Rows[i].Cells["DonGiaNuoc"].Value = dt.Rows[i]["DonGiaNuoc"].ToString();

                    dataGridViewSoDienNuoc.Rows[i].Cells["SoTienThanhToan1"].Value = '0';
                }
                else
                {
                    dataGridViewSoDienNuoc.RowCount = dt.Rows.Count;
                    dataGridViewSoDienNuoc.Rows[i].Cells["ID_Phong1"].Value = dt.Rows[i]["ID_Phong"].ToString();

                    dataGridViewSoDienNuoc.Rows[i].Cells["Name_Phong"].Value = dt.Rows[i]["TenPhong"].ToString();

                    dataGridViewSoDienNuoc.Rows[i].Cells["SoDienCu"].Value = dt.Rows[i]["SoDienHienTai"].ToString();
                    dataGridViewSoDienNuoc.Rows[i].Cells["TrangThai"].Value = "Hiện trống";
                    dataGridViewSoDienNuoc.Rows[i].Cells["SoDienMoi"].Value = '0';

                    dataGridViewSoDienNuoc.Rows[i].Cells["SoNuocCu"].Value = dt.Rows[i]["SoNuocHienTai"].ToString();
                    dataGridViewSoDienNuoc.Rows[i].Cells["TienPhong"].Value = dt.Rows[i]["Gia"].ToString();
                    dataGridViewSoDienNuoc.Rows[i].Cells["SoNuocMoi"].Value = '0';

                    dataGridViewSoDienNuoc.Rows[i].Cells["SoDienSuDung"].Value = '0';
                    dataGridViewSoDienNuoc.Rows[i].Cells["SoNuocSuDung"].Value = '0';
                    dataGridViewSoDienNuoc.Rows[i].Cells["DonGiaDien"].Value = dt.Rows[i]["DonGiaDien"].ToString();
                    dataGridViewSoDienNuoc.Rows[i].Cells["DonGiaNuoc"].Value = dt.Rows[i]["DonGiaNuoc"].ToString();

                    dataGridViewSoDienNuoc.Rows[i].Cells["SoTienThanhToan1"].Value = '0';
                }
            }
        }
        private void btnEditDien_Click(object sender, EventArgs e)
        {
            txtGiaDien.ReadOnly = false;
        }

        private void btnEditNuoc_Click(object sender, EventArgs e)
        {
            txtGiaNuoc.ReadOnly = false;
        }

        private void btnTimKiemSoDienNuoc_Click(object sender, EventArgs e)
        {
            string id = txtPhongTimKiem.Text;
            if (cbTrangThai.SelectedValue.ToString().Equals(""))
                InitTabDienNuoc(BUS_DienNuoc.Instance.GetDienNuocAllById(id,IDTRO));
            else
            {
                if (cbTrangThai.SelectedValue.ToString().Equals("0"))
                {
                    if (BUS_DienNuoc.Instance.GetDienNuocAllByIdAndTinhTrang(id, 0,IDTRO).Rows.Count < 0)
                    {
                        MessageBox.Show("Không có phòng hợp lệ");
                        txtPhongTimKiem.Text = "";
                    }
                    else
                        InitTabDienNuoc(BUS_DienNuoc.Instance.GetDienNuocAllByIdAndTinhTrang(id, 0,IDTRO));

                }
                if (cbTrangThai.SelectedValue.ToString().Equals("1"))
                    if (BUS_DienNuoc.Instance.GetDienNuocAllByIdAndTinhTrang(id, 1,IDTRO).Rows.Count < 0)
                    {
                        MessageBox.Show("Không có phòng hợp lệ");
                        txtPhongTimKiem.Text = "";
                    }
                    else
                        InitTabDienNuoc(BUS_DienNuoc.Instance.GetDienNuocAllByIdAndTinhTrang(id, 1,IDTRO));
            }
        }
        private void dataGridViewLoaiTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra để đảm bảo hàng được click không phải là header và là một hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                txtNewGiaPhong.Text = dataGridViewLoaiTro.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
                txtNewLoaiPhong.Text = dataGridViewLoaiTro.Rows[e.RowIndex].Cells["TenLoaiPhong"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần lấy dữ liệu");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dataGridViewSoDienNuoc.SelectedRows.Count > 0)
            {
                txtChiSoDienCu.Text = dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoDienCu"].Value.ToString();
                txtChiSoNuocCu.Text = dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoNuocCu"].Value.ToString();
                txtPhongUpd.Text = dataGridViewSoDienNuoc.SelectedRows[0].Cells["ID_Phong1"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Vui long chon phong can lay du lieu");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dataGridViewSoDienNuoc.SelectedRows.Count > 0)
            {
                if (dataGridViewSoDienNuoc.SelectedRows[0].Cells["TrangThai"].Value.ToString().Equals("Đang thuê"))
                {
                    int chiSoDienMoi, chiSoNuocMoi;
                    bool isDienValid = int.TryParse(txtChiSoDienMoi.Text, out chiSoDienMoi);
                    bool isNuocValid = int.TryParse(txtChiSoNuocMoi.Text, out chiSoNuocMoi);

                    int soDienCu = Convert.ToInt32(dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoDienCu"].Value);
                    int soNuocCu = Convert.ToInt32(dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoNuocCu"].Value);
                    int sodiensudung = chiSoDienMoi - soDienCu;
                    int sonuocsudung = chiSoNuocMoi - soNuocCu;

                    if (!isDienValid || !isNuocValid || sodiensudung < 0 || sonuocsudung < 0)
                    {
                        MessageBox.Show("Số điện hoặc số nước không hợp lệ. Vui lòng nhập lại.");
                        return;
                    }

                    dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoDienSuDung"].Value = sodiensudung.ToString();
                    dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoNuocSuDung"].Value = sonuocsudung.ToString();
                    dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoDienMoi"].Value = chiSoDienMoi.ToString();
                    dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoNuocMoi"].Value = chiSoNuocMoi.ToString();

                    int dien = Convert.ToInt32(dataGridViewSoDienNuoc.SelectedRows[0].Cells["DonGiaDien"].Value);
                    int nuoc = Convert.ToInt32(dataGridViewSoDienNuoc.SelectedRows[0].Cells["DonGiaNuoc"].Value);
                    int thanhtien = dien * sodiensudung + nuoc * sonuocsudung;
                    int giaphong = Convert.ToInt32(dataGridViewSoDienNuoc.SelectedRows[0].Cells["TienPhong"].Value);
                    dataGridViewSoDienNuoc.SelectedRows[0].Cells["ThanhTien"].Value = (giaphong + thanhtien).ToString();

                    // Cập nhật thông tin vào cơ sở dữ liệu
                    BUS_DienNuoc.Instance.UpdateDienNuoc(chiSoDienMoi, chiSoNuocMoi, dataGridViewSoDienNuoc.SelectedRows[0].Cells["ID_Phong1"].Value.ToString());

                    // Xử lý thống kê và tài chính
                    DataTable dt = BUS_Phong.Instance.GetPhongByID(txtPhongUpd.Text);
                    int gia = 0;
                    foreach (DataRow dr in dt.Rows)
                        gia = Convert.ToInt32(dr["Gia"].ToString());
                    int tt = gia + thanhtien;
                    DateTime selectedDate = dateTimePicker1.Value;
                    string formattedDate = "T" + selectedDate.ToString("M/yyyy");
                    BUS_ThongKe.Instance.InsertDienNuoc(formattedDate, sodiensudung, sonuocsudung, gia, tt, dataGridViewSoDienNuoc.SelectedRows[0].Cells["ID_Phong1"].Value.ToString());

                    // Cập nhật thông tin tài chính
                    dt = BUS_TongTien.Instance.getTongTienByID(txtPhongUpd.Text);
                    foreach (DataRow dr in dt.Rows)
                    {
                        int totalDue = Convert.ToInt32(dr["DuNo"].ToString()) + Convert.ToInt32(dr["TongTien"].ToString()) - Convert.ToInt32(dr["TienDaThanhToan"].ToString());
                        if (totalDue != 0)
                        {
                            BUS_TongTien.Instance.UpdateTienNo(totalDue, txtPhongUpd.Text);
                        }
                    }
                    BUS_TongTien.Instance.UpdateThangMoi(tt, 0, txtPhongUpd.Text);
                    MessageBox.Show("Thông tin đã được cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show("Phòng hiện đang không cho thuê");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng để xử lý!");
            }
        }


        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTrangThai.SelectedValue.ToString().Equals(""))
                InitTabDienNuoc(BUS_DienNuoc.Instance.GetDienNuocAll(IDTRO));
            if (cbTrangThai.SelectedValue.ToString().Equals("0"))
            {
                InitTabDienNuoc(BUS_DienNuoc.Instance.GetDienNuocAllByTrangThai(0, IDTRO));
            }
            if (cbTrangThai.SelectedValue.ToString().Equals("1"))
            {
                InitTabDienNuoc(BUS_DienNuoc.Instance.GetDienNuocAllByTrangThai(1, IDTRO));
            }
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            this.comboBox1.DataSource = DiaChiTro.ToList();
            this.comboBox1.ValueMember = "Key";
            this.comboBox1.DisplayMember = "Value";
            this.comboBox1.SelectedIndex = 0;
        }
        private void btnLuuGiaDienNuoc_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedKeyValuePair = (KeyValuePair<int, string>)this.comboBox1.SelectedItem;
            string idTro = selectedKeyValuePair.Key.ToString();
            string diaChi = selectedKeyValuePair.Value;
            BUS_Tro.Instance.ThayDoiThongTin(diaChi, txtGiaDien.Text, txtGiaNuoc.Text, idTro);

            if (IDTRO.Equals("0"))
            {
                MessageBox.Show("Vui lòng chọn trọ cần thêm thông tin");
                return;  // Ngừng xử lý nếu không chọn trọ
            }

            string loaiphong = txtNewLoaiPhong.Text;
            string gia = txtNewGiaPhong.Text;

            decimal giaValue;  // Biến để kiểm tra giá trị decimal
            if (!decimal.TryParse(gia, out giaValue))
            {
                MessageBox.Show("Giá phòng phải là một số. Vui lòng nhập lại.");
                return;  // Ngừng xử lý nếu giá không phải là số
            }

            if (dataGridViewLoaiTro.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật thông tin phòng đã chọn không? Chọn 'No' để thêm mới.", "Xác nhận hành động", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    // Cập nhật thông tin
                    BUS_LoaiPhong.Instance.Update(loaiphong, gia, dataGridViewLoaiTro.SelectedRows[0].Cells["ID_LoaiPhong"].Value.ToString());
                    MessageBox.Show("Cập nhật thông tin thành công");
                }
                else if (dialogResult == DialogResult.No)
                {
                    // Thêm mới thông tin
                    BUS_LoaiPhong.Instance.ThemLoaiPhong(loaiphong, gia, idTro);
                    MessageBox.Show("Thêm thành công");
                }
            }
            else
            {
                // Thêm mới thông tin
                BUS_LoaiPhong.Instance.ThemLoaiPhong(loaiphong, gia, idTro);
                MessageBox.Show("Thêm thành công");
            }

            // Cập nhật lại DataGridView
            dataGridViewLoaiTro.DataSource = BUS_LoaiPhong.Instance.GetLoaiPhongByIDTRO(idTro);
            dataGridViewLoaiTro.DataBindingComplete += dataGridViewLoaiTro_DataBindingComplete;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedKeyValuePair = (KeyValuePair<int, string>)this.comboBox1.SelectedItem;
            string idTro = selectedKeyValuePair.Key.ToString();
            string diaChi = selectedKeyValuePair.Value;

            DataTable dt = BUS_Tro.Instance.GetTienDienNuoc(idTro);

            if (dt.Rows.Count > 0)
            {
                var donGiaDien = dt.Rows[0]["DonGiaDien"];
                var donGiaNuoc = dt.Rows[0]["DonGiaNuoc"];

                txtGiaDien.Text = donGiaDien.ToString();
                txtGiaNuoc.Text = donGiaNuoc.ToString();
            }
            dataGridViewLoaiTro.DataSource = BUS_LoaiPhong.Instance.GetLoaiPhongByIDTRO(idTro);
            dataGridViewLoaiTro.DataBindingComplete += dataGridViewLoaiTro_DataBindingComplete;
        }

    }
}
