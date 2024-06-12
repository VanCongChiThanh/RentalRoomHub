using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DBHelper
    {
        internal SqlConnection _conn;
        private static DAL_DBHelper _Instance;

        public static DAL_DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    String s = @"Data Source=DESKTOP-KKVDHC9\SQLEXPRESS;Initial Catalog=t5;Integrated Security=True;";
                    _Instance = new DAL_DBHelper(s);
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_DBHelper(string s)
        {
            _conn = new SqlConnection(s);
        }
        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            _conn.Open();
            adapter.Fill(dt);
            _conn.Close();
            return dt;
        }
        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _conn);
            _conn.Open();
            cmd.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
