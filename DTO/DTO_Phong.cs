using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Phong
    {
        private string _NgayBatDauThue;
        private string _NgayKetThucThue;
        private string _IDTro;
        private string _Ten;
        private int _Gia;
        private string _LoaiPhong;
        private int _TrangThai;
        private int _DelFlag;

        public string NgayBatDauThue { get => _NgayBatDauThue; set => _NgayBatDauThue = value; }
        public string NgayKetThucThue { get => _NgayKetThucThue; set => _NgayKetThucThue = value; }
        public int Gia { get => _Gia; set => _Gia = value; }
        public string LoaiPhong { get => _LoaiPhong; set => _LoaiPhong = value; }
        public int TrangThai { get => _TrangThai; set => _TrangThai = value; }
        public int DelFlag { get => _DelFlag; set => _DelFlag = value; }
        public string IDTro { get => _IDTro; set => _IDTro = value; }
        public string Ten { get => _Ten; set => _Ten= value; }

        public DTO_Phong(string ten, string ID_Tro,string ngayBatDauThue, string ngayKetThucThue, int gia, string loaiPhong, int trangThai, int Flag)
        {
            this.NgayBatDauThue = ngayBatDauThue;
            this.NgayKetThucThue = ngayKetThucThue;
            this.Gia = gia;
            this.LoaiPhong = loaiPhong;
            this.TrangThai = trangThai;
            this.Ten = ten;
            this.IDTro = ID_Tro;
            this.DelFlag = Flag;
        }
    }
}
