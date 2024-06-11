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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QLPT
{
    public partial class BaoCao : Form
    {
        private int IDCHUTRO = ChuTroMain.IDCHUTRO;
        private string IDTro = string.Empty;
        public BaoCao()
        {
            InitializeComponent();
            InitComboboxTroTheoDiaChi();
            
        }
        private void SetUI()
        {
            // Giả sử idTro là biến toàn cục hoặc được truyền vào
            DataSet financialData = BUS_ThongKe.Instance.GetFinancialSummaryByTro(IDTro);

            if (financialData != null)
            {
                if (financialData.Tables["LatestMonth"].Rows.Count > 0)
                {
                    DataRow latest = financialData.Tables["LatestMonth"].Rows[0];
                    double doanhThuThang = (latest["DoanhThu"] != DBNull.Value) ? Convert.ToDouble(latest["DoanhThu"]) / 1000000 : 0; // Chia để loại bỏ ba số 0
                    double loiNhuanThang = (latest["LoiNhuận"] != DBNull.Value) ? Convert.ToDouble(latest["LoiNhuận"]) / 1000000 : 0; // Chia để loại bỏ ba số 0
                    lbDoanhThuThang.Text = doanhThuThang.ToString("N0"); // "N0" để định dạng không có số thập phân
                    lbLoiNhuanThang.Text = loiNhuanThang.ToString("N0");
                }

                if (financialData.Tables["TotalSummary"].Rows.Count > 0)
                {
                    DataRow total = financialData.Tables["TotalSummary"].Rows[0];
                    double tongDoanhThu = (total["TongDoanhThu"] != DBNull.Value) ? Convert.ToDouble(total["TongDoanhThu"]) / 1000000 : 0; // Chia để loại bỏ ba số 0
                    double tongLoiNhuan = (total["TongLoiNhuận"] != DBNull.Value) ? Convert.ToDouble(total["TongLoiNhuận"]) / 1000000 : 0; // Chia để loại bỏ ba số 0
                    lbTongDoanhThu.Text = tongDoanhThu.ToString("N0");
                    lbTongLoiNhuan.Text = tongLoiNhuan.ToString("N0");
                }
            }
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
            this.cbTro.DataSource = DiaChiTro.ToList();
            this.cbTro.ValueMember = "Key";
            this.cbTro.DisplayMember = "Value";
            this.cbTro.SelectedIndex = 0;
        }
        public void LoadChartData(string idTro)
        {
            DataTable dt = BUS_ThongKe.Instance.GetThongKebyIDTro(idTro);

            chart3.Series.Clear();
            chart3.ChartAreas.Clear();

            // Tạo một ChartArea mới và thêm vào chart
            ChartArea area = new ChartArea();
            chart3.ChartAreas.Add(area);

            Series series1 = chart3.Series.Add("Doanh Thu");
            series1.ChartType = SeriesChartType.Column;
            Series series2 = chart3.Series.Add("Lợi Nhuận");
            series2.ChartType = SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                series1.Points.AddXY(row["ThoiGian"], row["DoanhThu"]);
                series2.Points.AddXY(row["ThoiGian"], row["LoiNhuan"]);

                // Thiết lập nhãn cho các điểm dữ liệu
                series1.Points[series1.Points.Count - 1].AxisLabel = row["ThoiGian"].ToString();
                series2.Points[series2.Points.Count - 1].AxisLabel = row["ThoiGian"].ToString();
            }

            chart3.ChartAreas[0].AxisX.Interval = 1;
            chart3.ChartAreas[0].AxisX.Title = "Thời gian";
            chart3.ChartAreas[0].AxisY.Title = "Giá trị";
        }




        private void cbTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedKeyValuePair = (KeyValuePair<int, string>)this.cbTro.SelectedItem;
            IDTro = selectedKeyValuePair.Key.ToString();
            LoadChartData(IDTro);
            SetUI();
        }
    }
}
