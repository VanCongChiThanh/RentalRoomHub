using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class DAL_ChuTro
    {
        private SqlConnection _conn = new SqlConnection("Data Source=LAPTOP-8EBE9VMB\\SQLEXPRESS;Initial Catalog=t2;Integrated Security=True");
        private static DAL_ChuTro _instance;
        public static DAL_ChuTro Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_ChuTro();
                return _instance;
            }
            private set { _instance = value; }
        }
        public DAL_ChuTro() { }
        public DataTable GetChuTro()
        {
            string query = "(SELECT * FROM ChuTro)";
            DataTable dtChuTro = new DataTable();
            dtChuTro = DAL_DBHelper.Instance.GetRecords(query);
            return dtChuTro;
        }
        public DataTable GetChuTroByID(string id)
        {
            string query = string.Format("SELECT * FROM ChuTro where ID_ChuTro='{0}'",id);
            DataTable dtChuTro = new DataTable();
            dtChuTro = DAL_DBHelper.Instance.GetRecords(query);
            return dtChuTro;
        }

        public void DangKyTro(string ten,string email,string sdt,string pass, string user)
        {
            string query = string.Format("INSERT INTO [dbo].[ChuTro] (TenChuTro,Email,SoDienThoai, [Password], TenTaiKhoan)\r\nVALUES \r\n('{0}', '{1}','{2}','{3}', '{4}')",ten,email,sdt,pass,user);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
        public string GetMaxID()
        {
            string query = string.Format("select top 1 ID_Phong from Phong order by ID_Phong DESC");
            string id = "";
            _conn.Open();
            SqlCommand cmd = new SqlCommand(query, _conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    id = reader["ID_Phong"].ToString();
                }
            }
            _conn.Close();
            return id;
        }
        public int GetIDChuTroByUserNameAndPassWord(string user,string pass)
        {
            string query = string.Format("(SELECT * FROM ChuTro where TenTaiKhoan='{0}' and Password='{1}')",user,pass);
            int id=0;
            DataTable tro = new DataTable();
            tro = DAL_DBHelper.Instance.GetRecords(query);
            foreach(DataRow dr in tro.Rows)
            {
                id= Convert.ToInt32(dr["ID_ChuTro"].ToString());
            }
            return id;
        }
        public DataTable GetUserNameAndPassWordByID(string id)
        {
            string query = string.Format("(SELECT TenTaiKhoan,Password FROM ChuTro where ID_ChuTro='{0}')",id);
            return DAL_DBHelper.Instance.GetRecords(query);
        }
        public void ThayDoiMatKhau(string ID, string pass)
        {
            string query = string.Format("UPDATE ChuTro SET Password = '{0}'WHERE ID_ChuTro ='{1}'", pass, ID);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
        public void ThayDoiThongTin(string Ten, string email,string sdt,string id)
        {
            string query = string.Format("UPDATE ChuTro SET TenChuTro = '{0}',Email='{1}',SoDienThoai='{2}' WHERE ID_ChuTro ='{3}'", Ten,email,sdt,id);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
    }
}
