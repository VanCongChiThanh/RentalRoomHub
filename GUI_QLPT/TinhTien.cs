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
    public partial class TinhTien : Form
    {
        string IDTRO=ChuTroMain.IDTRO;
        public TinhTien()
        {
            InitializeComponent();

            this.InitComboBoxTabThanhToanTraPhong();
            this.InitTabThanhToanTraPhong(BUS_TongTien.Instance.getTongTien(IDTRO));
        }
        private void InitTabThanhToanTraPhong(DataTable dt)
        {
            dataGridViewTinhTien.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int tongtien = Convert.ToInt32(dt.Rows[i]["TongTien"].ToString());
                int dathanhtoan = Convert.ToInt32(dt.Rows[i]["TienDaThanhToan"].ToString());

                dataGridViewTinhTien.RowCount = dt.Rows.Count;

                dataGridViewTinhTien.Rows[i].Cells["ID_Phong2"].Value = dt.Rows[i]["TenPhong"].ToString();
                dataGridViewTinhTien.Rows[i].Cells["DuNo"].Value = dt.Rows[i]["DuNo"].ToString();
                if (dt.Rows[i]["TrangThai"].ToString().Equals("1"))
                {
                    dataGridViewTinhTien.Rows[i].Cells["TrangThai2"].Value = "Đang thuê";
                }
                else
                    dataGridViewTinhTien.Rows[i].Cells["TrangThai2"].Value = "Hiện trống";

                dataGridViewTinhTien.Rows[i].Cells["TongSoTien"].Value = dt.Rows[i]["TongTien"].ToString();
                dataGridViewTinhTien.Rows[i].Cells["TongSoTienDaThanhToan"].Value = dt.Rows[i]["TienDaThanhToan"].ToString();
                dataGridViewTinhTien.Rows[i].Cells["TongSoTienChuaThanhToan"].Value = (tongtien - dathanhtoan).ToString();
            }

        }
        private void InitComboBoxTabThanhToanTraPhong()
        {
            var trangThaiPhong = new BindingList<KeyValuePair<string, string>>();
            trangThaiPhong.Add(new KeyValuePair<string, string>("", " --- Trạng thái phòng --- "));
            trangThaiPhong.Add(new KeyValuePair<string, string>("0", " --- Trống --- "));
            trangThaiPhong.Add(new KeyValuePair<string, string>("1", " ---  Đang thuê --- "));

            this.cbbTinhTrangPhong.DataSource = trangThaiPhong;
            this.cbbTinhTrangPhong.ValueMember = "Key";
            this.cbbTinhTrangPhong.DisplayMember = "Value";
            this.cbbTinhTrangPhong.SelectedIndex = 0;
        }
        private void btnTImKiemTinhTien_Click(object sender, EventArgs e)
        {
            string id = txtTImKiemTinhTien.Text;
            if (cbbTinhTrangPhong.SelectedValue.ToString().Equals(""))
            {
                if (id.Equals(""))
                    InitTabThanhToanTraPhong(BUS_TongTien.Instance.getTongTien(IDTRO));
                else
                    InitTabThanhToanTraPhong(BUS_TongTien.Instance.getTongTienByID(id));
            }
            else
            {
                if (cbbTinhTrangPhong.SelectedValue.ToString().Equals("0"))
                {
                    if (BUS_TongTien.Instance.getTongTienByTinhTrangAndID(0, id).Rows.Count < 0)
                    {
                        MessageBox.Show("Không có phòng hợp lệ");
                        txtTImKiemTinhTien.Text = "";
                    }
                    else
                        InitTabThanhToanTraPhong(BUS_TongTien.Instance.getTongTienByTinhTrangAndID(0, id));

                }
                if (cbbTinhTrangPhong.SelectedValue.ToString().Equals("1"))
                    if (BUS_TongTien.Instance.getTongTienByTinhTrangAndID(1, id).Rows.Count < 0)
                    {
                        MessageBox.Show("Không có phòng hợp lệ");
                        txtTImKiemTinhTien.Text = "";
                    }
                    else
                        InitTabThanhToanTraPhong(BUS_TongTien.Instance.getTongTienByTinhTrangAndID(1, id));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dataGridViewTinhTien.SelectedRows.Count > 0)
            {
                if (dataGridViewTinhTien.SelectedRows[0].Cells["TrangThai2"].Value.ToString().Equals("Đang thuê"))
                {
                    if (txtThang.Text.Length > 0)
                    {
                        int tongtien = Convert.ToInt32(dataGridViewTinhTien.SelectedRows[0].Cells["TongSoTien"].Value);
                        int tienthanhtoan = Convert.ToInt32(dataGridViewTinhTien.SelectedRows[0].Cells["TongSoTienDaThanhToan"].Value);
                        dataGridViewTinhTien.SelectedRows[0].Cells["TongSoTienDaThanhToan"].Value = tienthanhtoan + Convert.ToInt32(txtThang.Text);
                        dataGridViewTinhTien.SelectedRows[0].Cells["TongSoTienChuaThanhToan"].Value = (tongtien - tienthanhtoan - Convert.ToInt32(txtThang.Text)).ToString();
                        BUS_TongTien.Instance.UpdateTienThanhToan(tienthanhtoan + Convert.ToInt32(txtThang.Text), dataGridViewTinhTien.SelectedRows[0].Cells["ID_Phong2"].Value.ToString());
                    }

                    if (txtNo.Text.Length > 0)
                    {
                        int tienno = Convert.ToInt32(dataGridViewTinhTien.SelectedRows[0].Cells["DuNo"].Value);
                        dataGridViewTinhTien.SelectedRows[0].Cells["DuNo"].Value = tienno - Convert.ToInt32(txtNo.Text);
                        BUS_TongTien.Instance.UpdateTienNo(tienno - Convert.ToInt32(txtNo.Text), dataGridViewTinhTien.SelectedRows[0].Cells["ID_Phong2"].Value.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Phòng hiện đang không cho thuê");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng cần xử lý!!!");
            }
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            this.InitTabThanhToanTraPhong(BUS_TongTien.Instance.getTongTien(IDTRO));
        }

        private void cbbTinhTrangPhongcbbTinhTrangPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTinhTrangPhong.SelectedValue.ToString().Equals(""))
                InitTabThanhToanTraPhong(BUS_TongTien.Instance.getTongTien(IDTRO));
            if (cbbTinhTrangPhong.SelectedValue.ToString().Equals("0"))
                InitTabThanhToanTraPhong(BUS_TongTien.Instance.getTongTienByTinhTrang(0, IDTRO));
            if (cbbTinhTrangPhong.SelectedValue.ToString().Equals("1"))
                InitTabThanhToanTraPhong(BUS_TongTien.Instance.getTongTienByTinhTrang(1, IDTRO));
        }
    }
}
