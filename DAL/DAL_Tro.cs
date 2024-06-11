using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Tro
    {
        private static DAL_Tro _instance;
        public static DAL_Tro Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_Tro();
                return _instance;
            }
            private set { _instance = value; }
        }
        public DAL_Tro() { }
        public DataTable GetTro() {
            string query = "(SELECT * FROM Tro)";
            DataTable Tro = new DataTable();
            Tro = DAL_DBHelper.Instance.GetRecords(query);
            return Tro;
        }
        public DataTable GetTroByID(string id)
        {
            string query = string.Format("(SELECT * FROM Tro where ID_Tro='{0}')",id);
            DataTable Tro = new DataTable();
            Tro = DAL_DBHelper.Instance.GetRecords(query);
            return Tro;
        }
         public DataTable GetDiaChiTroByIDChuTro(int idTro)
        {
            string query = string.Format("(SELECT * FROM Tro where ID_ChuTro='{0}')",idTro);
            DataTable Tro = new DataTable();
            Tro = DAL_DBHelper.Instance.GetRecords(query);
            return Tro;
        }
        public DataTable GetTienDienNuoc(string idTro)
        {
            // Truy vấn chỉ lấy ra 1 hàng dữ liệu đầu tiên phù hợp với ID_Tro cung cấp
            string query = string.Format("SELECT TOP 1 DonGiaDien, DonGiaNuoc FROM Tro WHERE ID_Tro = '{0}'", idTro);
            DataTable Tro = new DataTable();
            Tro = DAL_DBHelper.Instance.GetRecords(query);
            return Tro;
        }

        public void ThayDoiThongTin(string diachi, string Dongiadien, string DonGiaNuoc,string id)
        {
            string query = string.Format("UPDATE Tro SET DiaChi = N'{0}',DonGiaDien='{1}',DonGiaNuoc='{2}' WHERE ID_Tro ='{3}'", diachi,Dongiadien,DonGiaNuoc, id);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
        public void ThemDayTroMoi(string idChutro,string diachi,string dien,string nuoc)
        {
            string query = string.Format("INSERT INTO [dbo].[Tro] ([DiaChi],[DonGiaDien],[DonGiaNuoc],[ID_ChuTro]) VALUES (N'{0}','{1}','{2}','{3}')",diachi,dien,nuoc,idChutro);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }

    }
}
