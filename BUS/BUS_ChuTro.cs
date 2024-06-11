using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_ChuTro
    {
        private static BUS_ChuTro _instance;
        public static BUS_ChuTro Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BUS_ChuTro();
                return _instance;
            }
            private set { _instance = value; }
        }
        public BUS_ChuTro() { }
        public DataTable GetChuTro()
        {
            return DAL_ChuTro.Instance.GetChuTro();
        }
        public DataTable GetChuTroByID(string id)
        {
            return DAL_ChuTro.Instance.GetChuTroByID(id);
        }
        public int GetIDChuTroByUserNameAndPassWord(string user, string pass)
        {
            return DAL_ChuTro.Instance.GetIDChuTroByUserNameAndPassWord(user, pass);
        }
        public void DangKyTro(string ten, string email, string sdt, string pass, string user)
        {
            DAL_ChuTro.Instance.DangKyTro(ten, email, sdt, pass, user); 
        }
        public DataTable GetUserNameAndPassWordByID(string id)
        {
            return DAL_ChuTro.Instance.GetUserNameAndPassWordByID(id);
        }
        public void ThayDoiMatKhau(string ID,string pass)
        {
            DAL_ChuTro.Instance.ThayDoiMatKhau(ID,pass);
        }
        public void ThayDoiThongTin(string Ten, string email, string sdt, string id)
        {
            DAL_ChuTro.Instance.ThayDoiThongTin(Ten, email, sdt, id);   
        }
    }
}
