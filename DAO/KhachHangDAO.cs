using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        private KhachHangDAO() { }

        public static KhachHangDAO _instance;
        public static KhachHangDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhachHangDAO();
                }
                return _instance;
            }
        }
        public KhachHangDTO LayThongTinKhachHang(String HoTen, String sDT, String diachi)
        {
            string tenKH = HoTen;
            string diaChi = diachi;
            string soDT = sDT;

            KhachHangDTO khachHang = new KhachHangDTO(tenKH, soDT, diaChi);

            return khachHang;
        }

        public DataTable TimKiemTheoSDT(string SDT)
        {
            string query = "EXEC sp_select_TimKiemKhachHang @SDT";
            object[] param = new object[] { SDT };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, param);

            return data;

        }

    }
}
