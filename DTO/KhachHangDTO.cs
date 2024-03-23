using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private int _ID_KH;
        private string _HoTen;
        private string _SDT;
        private string _Diachi;

        public KhachHangDTO(int iD_KH, string hoTen, string sDT, string diachi)
        {
            _ID_KH = iD_KH;
            _HoTen = hoTen;
            _SDT = sDT;
            _Diachi = diachi;
        }

        public int ID_KH { get => _ID_KH; set => _ID_KH = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string DiaChi { get => _Diachi; set => _Diachi = value; }

        public KhachHangDTO(DataRow row)
        {
            ID_KH = (int)row["ID_KH"];
            HoTen = row["HoTen"].ToString();
            SDT = row["SDT"].ToString();
            DiaChi = row["DiaChi"].ToString();
        }

        public KhachHangDTO(string hoTen, string sDT, string diaChi)
        {
            HoTen = hoTen;
            SDT = sDT;
            DiaChi = diaChi;
        }



    }
}
