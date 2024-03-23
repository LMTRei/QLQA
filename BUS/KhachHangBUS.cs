using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Windows.Forms;
using DTO;
using System.Data;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangBUS() { }

        public static KhachHangBUS _instance;

        public static KhachHangBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhachHangBUS();
                }
                return _instance;
            }
        }

        public KhachHangDTO LayThongTinKhachHang(String HoTen, String diachi, String sDT)
        {

            var tablekhachHang = KhachHangDAO.Instance.LayThongTinKhachHang(HoTen, diachi, sDT);

            check checking = new check();
            checking.SetTieuDe("Tên khách hàng")
                .SetInputString(tablekhachHang.HoTen)
                .SanLocInPut()
                .Require()
                .MustBeValidString();
            tablekhachHang.HoTen = tablekhachHang.HoTen.Sanitize();

            checking.SetTieuDe("SĐT khách hàng")
                .SetInputString(tablekhachHang.SDT)
                .SanLocInPut()
                .Require()
                .MustBeValidString()
                .IsNumber();

            tablekhachHang.SDT = tablekhachHang.SDT.Sanitize();

            if (checking.HasError)
            {
                MessageBox.Show(checking.GetErrorMessage());
                return null;
            }

            return tablekhachHang;
        }

        public List<KhachHangDTO> TimKiemTheoSDT(string sdt)
        {
            List<KhachHangDTO> dsKhachHang = new List<KhachHangDTO>();
            var data = KhachHangDAO.Instance.TimKiemTheoSDT(sdt);

            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO khachhang = new KhachHangDTO(row);
                dsKhachHang.Add(khachhang);
            }

            return dsKhachHang;
        }


    }
}
