using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Tro
    {
        private static BUS_Tro _instance;
        public static BUS_Tro Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_Tro();
                return _instance;
            }
            private set { _instance = value; }
        }
        public BUS_Tro() { }
        public DataTable GetTro()
        {
            return DAL_Tro.Instance.GetTro();
        }
        public DataTable GetTroByID(string id)
        {
           return DAL_Tro.Instance.GetTroByID(id);
        }
        public DataTable GetDiaChiTroByIDChuTro(int idTro)

        {
            return DAL_Tro.Instance.GetDiaChiTroByIDChuTro(idTro);
        }
        public DataTable GetTienDienNuoc(string idTro)
        {
            return DAL_Tro.Instance.GetTienDienNuoc(idTro);
        }
        public void ThayDoiThongTin(string diachi, string Dongiadien, string DonGiaNuoc, string id)
        {
            DAL_Tro.Instance.ThayDoiThongTin(diachi, Dongiadien, DonGiaNuoc, id);
        }
        public void ThemDayTroMoi(string idChutro, string diachi, string dien, string nuoc)
        {
            DAL_Tro.Instance.ThemDayTroMoi(idChutro, diachi, dien, nuoc);
        }

    }
}
