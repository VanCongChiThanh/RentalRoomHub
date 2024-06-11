using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TongTien
    {
        private static BUS_TongTien _instance;
        public static BUS_TongTien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_TongTien();
                return _instance;
            }
            private set { _instance = value; }
        }
        public BUS_TongTien() { }
        public DataTable getTongTien(string idTro)
        {
            return DAL_TongTien.Instance.getTongTien(idTro);
        }
        public DataTable getTongTienByID(string id)
        {
            return DAL_TongTien.Instance.getTongTienByID(id);
        }
        public void UpdateTienThanhToan(int tien, string id)
        {
            DAL_TongTien.Instance.UpdateTienThanhToan(tien, id);
        }
        public void UpdateTienNo(int tienno, string id)
        {
            DAL_TongTien.Instance.UpdateTienNo(tienno, id);
        }
        public void UpdateThangMoi(int tongtien, int tiendathanhtoan, string id)
        {
            DAL_TongTien.Instance.UpdateThangMoi(tongtien, tiendathanhtoan, id);

        }
        public DataTable getTongTienByTinhTrangAndID(int a, string id)
        {
           return DAL_TongTien.Instance.getTongTienByTinhTrangAndID(a,id);
        }
        public DataTable getTongTienByTinhTrang(int tt, string idtro)
        {
            return DAL_TongTien.Instance.getTongTienByTinhTrang(tt, idtro);
        }
        public string DeleteByID(string id)
        {
            return DAL_TongTien.Instance.DeleteByID(id);
        }
        public void InsertTongTien(int tt, int dathanhtoan, int duno)
        {
            DAL_TongTien.Instance.InsertTongTien(tt, dathanhtoan, duno);
        }
    }
}
