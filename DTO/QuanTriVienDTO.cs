using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanTriVienDTO
    {
        private int _ID_QTV;
        private string _TenDangNhap;
        private string _MatKhau;
        private string _Ten_KTK;
        private DataTable row;

        public QuanTriVienDTO(int iD_QTV, string tenDangNhap, string matKhau, string ten_KTK)
        {
            ID_QTV = iD_QTV;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            Ten_KTK = ten_KTK;
        }

        public int ID_QTV { get => _ID_QTV; set => _ID_QTV = value; }
        public string TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
        public string MatKhau { get => _MatKhau; set => _MatKhau = value; }
        public string Ten_KTK { get => _Ten_KTK; set => _Ten_KTK = value; }

        public QuanTriVienDTO(DataRow row)
        {
            ID_QTV = (int)row["ID_QTV"];
            TenDangNhap = row["TenDangNhap"].ToString();
            MatKhau = row["MatKhau"].ToString();
            Ten_KTK = row["Ten_KTK"].ToString();
        }

        public QuanTriVienDTO(DataTable row)
        {
            this.row = row;
        }

    }
}
