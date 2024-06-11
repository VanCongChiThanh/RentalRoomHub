using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TongTien
    {
        private static DAL_TongTien _instance;
        public static DAL_TongTien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DAL_TongTien();
                return _instance;
            }
            private set { _instance = value; }
        }
        public DAL_TongTien() { }
        public DataTable getTongTien(string idTro)
        {
            string query = string.Format("select TenPhong,Phong.ID_Phong,TrangThai,TongTien, TienDaThanhToan,DuNo from TongTien join Phong on Phong.ID_Phong=TongTien.ID_Phong where Phong.ID_Tro='{0}'",idTro);
            return DAL_DBHelper.Instance.GetRecords(query);
        }
        public DataTable getTongTienByID(string id)
        {
            string query = string.Format("select Phong.ID_Phong,TongTien,TienDaThanhToan,DuNo,TenPhong,TrangThai from TongTien join Phong on TongTien.ID_Phong = " +
                "Phong.ID_Phong where Phong.ID_Phong='{0}'",id);
            return DAL_DBHelper.Instance.GetRecords(query);
        }
        public void UpdateTienThanhToan(int tien,string id)
        {
            string query = string.Format("update TongTien set TienDaThanhToan='{0}' where ID_Phong = '{1}'",tien,id);
            DAL_DBHelper.Instance.ExecuteDB(query); 
        }
        public void UpdateThangMoi(int tongtien,int tiendathanhtoan, string id)
        {
            string query = string.Format("update TongTien set TongTien='{0}',TienDaThanhToan='{1}' where ID_Phong = '{2}'",tongtien, tiendathanhtoan, id);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
        public void UpdateTienNo(int tienno, string id)
        {
            string query = string.Format("update TongTien set DuNo='{0}' where ID_Phong = '{1}'", tienno, id);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
        public DataTable getTongTienByTinhTrang(int tt,string idtro)
        {
            string query = string.Format("select * from TongTien join Phong on Phong.ID_Phong = TongTien.ID_Phong where Phong.TrangThai= '{0}' and Phong.ID_Tro='{1}'", tt,idtro);
            return DAL_DBHelper.Instance.GetRecords(query);
        }
        public DataTable getTongTienByTinhTrangAndID(int tt,string id)
        {
            string query = string.Format("select * from TongTien join Phong on Phong.ID_Phong = TongTien.ID_Phong join LoaiPhong on LoaiPhong.ID_LoaiPhong=Phong.ID_LoaiPhong where Phong.TrangThai= '{0}' and Phong.ID_Phong='{1}'", tt,id);
            return DAL_DBHelper.Instance.GetRecords(query);

        }
        public string DeleteByID(string id)
        {
            string query = string.Format("delete from TongTien where ID_Phong = '{0}'",id);
            DAL_DBHelper.Instance.ExecuteDB(query);
            return query;
        }
        public void InsertTongTien(int tt,int dathanhtoan,int duno )
        {
            string query = string.Format("insert into TongTien values ('{0}','{1}','{2}')", tt,dathanhtoan,duno);
            DAL_DBHelper.Instance.ExecuteDB(query);
        }
    }
}

