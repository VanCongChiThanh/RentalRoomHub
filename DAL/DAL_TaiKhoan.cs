using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan _instance;
        public static DAL_TaiKhoan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_TaiKhoan();
                return _instance;
            }
            private set { _instance = value; }
        }
        public DAL_TaiKhoan() { }
        #region Get danh sách tài khoản

        /// <summary>
        /// Get danh sách tài khoản
        /// </summary>
        /// <returns></returns>
        public DataTable GetTaiKhoan()
        {
            string query = string.Format("SELECT * FROM TaiKhoan where DelFlg = 0");
            DataTable dataTable = new DataTable();
            dataTable = DAL_DBHelper.Instance.GetRecords(query);
            return dataTable;
        }

        #endregion

        #region Get danh sách tài khoản by Name

        /// <summary>
        /// Get danh sách tài khoản by Name
        /// </summary>
        /// <returns></returns>
        public DataTable GetTaiKhoanbyName(string key)
        {
            string query = string.Format("SELECT * FROM TaiKhoan where TenTaiKhoan like '{0}'", key);
            DataTable dataTable = new DataTable();
            dataTable = DAL_DBHelper.Instance.GetRecords(query);
            return dataTable;
        }

        #endregion

        #region Get tài khoản theo ID

        /// <summary>
        /// Get tài khoản theo ID
        /// </summary>
        /// <returns></returns>
        public DataTable GetTaiKhoanByID(string Id)
        {
            string query = string.Format("SELECT * FROM TaiKhoan WHERE ID_TaiKhoan ={0} AND DelFlg = 0", Id);
            DataTable dataTable = new DataTable();
            dataTable = DAL_DBHelper.Instance.GetRecords(query);
            return dataTable;
        }

        #endregion

        #region Get tài khoản login

        /// <summary>
        /// Get tài khoản login
        /// </summary>
        /// <returns></returns>
        public DataTable GetLogin(string Ten, string Pass)
        {
            string query = string.Format("SELECT * FROM TaiKhoan WHERE TenTaiKhoan = '{0}' AND Password = '{1}' AND DelFlg = 0", Ten, Pass);
            DataTable dataTable = new DataTable();
            dataTable = DAL_DBHelper.Instance.GetRecords(query);
            return dataTable;
        }

        #endregion

        #region 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //public string GetMaxId()
        //{
        //    string id = string.Empty;

        //    _conn.Open();
        //    SqlCommand command = new SqlCommand("SELECT TOP 1 ID_TaiKhoan FROM TaiKhoan order by ID_TaiKhoan DESC", _conn);
        //    using (SqlDataReader reader = command.ExecuteReader())
        //    {
        //        if (reader.Read())
        //        {
        //            id = reader["ID_TaiKhoan"].ToString();
        //        }
        //    }
        //    _conn.Close();

        //    return id;
        //}

        #endregion

        public bool CheckConflict(string username)
        {
            // Thay đổi connection string theo cấu hình của bạn
            string connectionString = "Data Source=DESKTOP-KKVDHC9\\SQLEXPRESS;Initial Catalog=t5;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Tạo lệnh SQL để kiểm tra tên đăng nhập
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                // Thực thi lệnh và đọc kết quả
                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    // Nếu tồn tại ít nhất một tài khoản với tên này, trả về true
                    return true;
                }
                // Nếu không, trả về false
                return false;
            }
        }

        public void Update(DTO_TaiKhoan tk,string id)
        {
            string query = string.Empty;
            if (tk.FlagInsert == true)
            {
                query = string.Format("INSERT INTO TaiKhoan (Password, TenTaiKhoan , Quyen , DelFlg) VALUES('{0}','{1}','{2}','{3}')", tk.Password, tk.TenTaiKhoan, tk.Quyen, tk.DelFlg);
            }
            else
            {
                query = string.Format("UPDATE TaiKhoan SET Password = '{0}',TenTaiKhoan ='{1}',Quyen ='{2}' WHERE ID_TaiKhoan ='{3}'", tk.Password, tk.TenTaiKhoan, tk.Quyen, id);
            }
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
        public bool DeleteByID(string id)
        {
            try
            {
                string query = string.Format("Delete from TaiKhoan WHERE ID_TaiKhoan = '{0}'", id);
                DAL_DBHelper.Instance.GetRecords(query);
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }
        public void DeleteByUserNameAndPassword(string userName, string password)
        {
            string query = string.Format("Delete from TaiKhoan WHERE TenTaiKhoan = '{0}' AND Password='{1}'", userName,password);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
    }
}
