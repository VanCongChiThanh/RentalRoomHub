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

                    dataGridViewSoDienNuoc.Rows[i].Cells["DonGiaDien"].Value = "5000";
                    dataGridViewSoDienNuoc.Rows[i].Cells["DonGiaNuoc"].Value = "6000";

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

                    dataGridViewSoDienNuoc.Rows[i].Cells["DonGiaDien"].Value = "5000";
                    dataGridViewSoDienNuoc.Rows[i].Cells["DonGiaNuoc"].Value = "6000";

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
                    int sodiensudung = Convert.ToInt32(txtChiSoDienMoi.Text)
                         - Convert.ToInt32(dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoDienCu"].Value.ToString());

                    dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoDienSuDung"].Value = sodiensudung.ToString();

                    int sonuocsudung = Convert.ToInt32(txtChiSoNuocMoi.Text)
               - Convert.ToInt32(dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoNuocCu"].Value.ToString());

                    dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoNuocSuDung"].Value = sonuocsudung.ToString();
                    MessageBox.Show("0");
                    if (sonuocsudung < 0 || sodiensudung < 0)
                    {
                        MessageBox.Show("Số điện hoặc nước không hợp lệ");
                    }
                    else
                    {
                        MessageBox.Show("1");


                        dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoDienMoi"].Value = txtChiSoDienMoi.Text;
                        dataGridViewSoDienNuoc.SelectedRows[0].Cells["SoNuocMoi"].Value = txtChiSoNuocMoi.Text;
                        int dien = Convert.ToInt32(dataGridViewSoDienNuoc.SelectedRows[0].Cells["DonGiaDien"].Value.ToString());
                        int nuoc = Convert.ToInt32(dataGridViewSoDienNuoc.SelectedRows[0].Cells["DonGiaNuoc"].Value.ToString());
                        int thanhtien = dien * sodiensudung + nuoc * sonuocsudung;
                        int giaphong = Convert.ToInt32(dataGridViewSoDienNuoc.SelectedRows[0].Cells["TienPhong"].Value.ToString());
                        dataGridViewSoDienNuoc.SelectedRows[0].Cells["ThanhTien"].Value = (giaphong + thanhtien).ToString();
                        MessageBox.Show("2");

                        BUS_DienNuoc.Instance.UpdateDienNuoc(Convert.ToInt32(txtChiSoDienMoi.Text), Convert.ToInt32(txtChiSoNuocMoi.Text), dataGridViewSoDienNuoc.SelectedRows[0].Cells["ID_Phong1"].Value.ToString());

                        DataTable dt = BUS_Phong.Instance.GetPhongByID(txtPhongUpd.Text);
                        int gia = 0;

                        foreach (DataRow dr in dt.Rows)
                            gia = Convert.ToInt32(dr["Gia"].ToString());
                        int tt = 0;
                        tt = gia + thanhtien;
                        //cbbTime.SelectedItem.ToString()
                        DateTime selectedDate = dateTimePicker1.Value;
                        // Chuyển đổi sang định dạng mong muốn, thêm 'T' trước tháng
                        string formattedDate = "T" + selectedDate.ToString("M/yyyy");
                        BUS_ThongKe.Instance.InsertDienNuoc(formattedDate, sodiensudung, sonuocsudung, gia, tt, dataGridViewSoDienNuoc.SelectedRows[0].Cells["ID_Phong1"].Value.ToString());
                        dt = BUS_TongTien.Instance.getTongTienByID(txtPhongUpd.Text);

                        foreach (DataRow dr in dt.Rows)
                        {
                            //2110000
                            if (Convert.ToInt32(dr["TongTien"].ToString()) - Convert.ToInt32(dr["TienDaThanhToan"].ToString()) != 0)
                            {
                                BUS_TongTien.Instance.UpdateTienNo(Convert.ToInt32(dr["DuNo"].ToString()) + Convert.ToInt32(dr["TongTien"].ToString()) - Convert.ToInt32(dr["TienDaThanhToan"].ToString()), txtPhongUpd.Text);
                            }
                            MessageBox.Show("5");

                        }
                        BUS_TongTien.Instance.UpdateThangMoi(tt, 0, txtPhongUpd.Text);
                    }

                }
                else
                {
                    MessageBox.Show("Phòng hiện đang không cho thuê");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng xủ lý!!!");
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
            }
            else
            {
                string loaiphong = txtNewLoaiPhong.Text;
                string gia = txtNewGiaPhong.Text;
                if (dataGridViewLoaiTro.SelectedRows.Count > 0)
                {
                    BUS_LoaiPhong.Instance.Update(loaiphong, gia, dataGridViewLoaiTro.SelectedRows[0].Cells["ID_LoaiPhong"].Value.ToString());
                    MessageBox.Show("Cập nhật thông tin thành công");
                }
                else
                {
                    BUS_LoaiPhong.Instance.ThemLoaiPhong(loaiphong, gia, IDTRO);
                    MessageBox.Show("Thêm thành công");
                }

            }
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
            dataGridViewLoaiTro.DataSource = BUS_LoaiPhong.Instance.GetLoaiPhongByIDTRO(IDTRO.ToString());
            dataGridViewLoaiTro.DataBindingComplete += dataGridViewLoaiTro_DataBindingComplete;
        }

    }
}
