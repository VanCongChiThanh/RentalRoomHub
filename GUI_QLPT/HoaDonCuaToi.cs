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
    public partial class HoaDonCuaToi : Form
    {
        private string IDPhong=KhachTroMain.IDPhong;
        public HoaDonCuaToi()
        {
            InitializeComponent();
        }

        private void HoaDonCuaToi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BUS_ThongKe.Instance.GetThongKebyID(IDPhong);
            dataGridViewHoaDon.DataSource = dt;
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {

            DataTable dt= new DataTable();
            dt = BUS_ThongKe.Instance.GetThongKebyID(IDPhong);
            dataGridViewHoaDon.DataSource = dt;
        }
    }
}
