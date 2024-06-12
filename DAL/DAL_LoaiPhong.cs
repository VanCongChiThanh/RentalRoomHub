using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAL_LoaiPhong
    {
        private SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-KKVDHC9\\SQLEXPRESS;Initial Catalog=t5;Integrated Security=True;");
        private static DAL_LoaiPhong _instance;
        public static DAL_LoaiPhong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_LoaiPhong();
                return _instance;
            }
            private set { _instance = value; }
        }
        public DAL_LoaiPhong() { }
        #region Get danh sách loại phòng

        /// <summary>
        /// Get danh sách loại phòng
        /// </summary>
        /// <returns></returns>
        public DataTable GetLoaiPhong(int IDTro)
		{
            string query = string.Format("SELECT * FROM LoaiPhong WHERE ID_Tro='{0}'",IDTro);
            DataTable dtLoaiPhong = new DataTable();
            dtLoaiPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtLoaiPhong;
        }
        public DataTable GetLoaiPhongByIDTRO(string Id)
        {
            string query = string.Format("SELECT * FROM LoaiPhong WHERE ID_TRO = {0} AND DelFlg = 0", Id);
            DataTable dtLoaiPhong = new DataTable();
            dtLoaiPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtLoaiPhong;
        }
        #endregion

        #region Get danh sách phong theo ma phong

        /// <summary>
        /// Get danh sách phong theo ma phong
        /// </summary>
        /// <returns></returns>
        /// 
        public DataTable GetLoaiPhongByID(string Id)
		{
            string query = string.Format("SELECT * FROM LoaiPhong WHERE ID_Tro = {0} AND DelFlg = 0", Id);
            DataTable dtLoaiPhong = new DataTable();
            dtLoaiPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtLoaiPhong;
        }
        public DataTable GetThongTinPhong(string Id)
        {
            string query = string.Format("select * from Phong join LoaiPhong on Phong.ID_LoaiPhong = LoaiPhong.ID_LoaiPhong where ID_Phong ='{0}'", Id);
            DataTable dtLoaiPhong = new DataTable();
            dtLoaiPhong = DAL_DBHelper.Instance.GetRecords(query);
            return dtLoaiPhong;
        }
        public int GetGia(string Id)
        {
            string query = string.Format("select Gia from LoaiPhong where ID_LoaiPhong='{0}'",Id);
            int gia = 1;
            DataTable dtLoaiPhong = DAL_DBHelper.Instance.GetRecords(query);
            foreach (DataRow row in dtLoaiPhong.Rows)
            {
                gia = Convert.ToInt32(row["Gia"].ToString());
            }
            return gia;
        }
        public string GetMaxID(string idtro)
        {
            string query = string.Format("SELECT COUNT(*) AS SoHang\r\nFROM LoaiPhong\r\nWHERE ID_Tro = '{0}';\r\n", idtro);
            string id = "";
            _conn.Open();
            SqlCommand cmd = new SqlCommand(query, _conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    id = reader["SoHang"].ToString();
                }
            }
            _conn.Close();
            return id;
        }
        public void ThemLoaiPhong(string loaiphong,string gia,string id)
        {
            string query = string.Format("INSERT [dbo].[LoaiPhong] ( [TenLoaiPhong], [DelFlg],[Gia],[ID_Tro])VALUES (N'{0}','{1}','{2}','{3}')",loaiphong,0,gia,id);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
        public void Update(string loaiphong,string gia,string id)
        {
            string query = string.Format("update LoaiPhong set Gia='{0}',TenLoaiPhong='{1}' where ID_LoaiPhong='{2}'",gia,loaiphong, id);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
        public void Delete(string id)
        {
            string query = string.Format("delete from LoaiPhong where ID_LoaiPhong='{0}'", id);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
        #endregion
    }
}
