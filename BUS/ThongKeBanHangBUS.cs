using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeBanHangBUS
    {
        private ThongKeBanHangBUS() { }

        private static ThongKeBanHangBUS _instance;
        public static ThongKeBanHangBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThongKeBanHangBUS();
                }
                return _instance;
            }
        }

        public List<ThongKeBanHangDTO> GetListThongKeBanHang()
        {
            List<ThongKeBanHangDTO> listThongKe = new List<ThongKeBanHangDTO>();

            var table = ThongKeBanHangDAO.Instance.GetListThongKeBanHang();

            foreach (DataRow row in table.Rows)
            {
                ThongKeBanHangDTO thongKe = new ThongKeBanHangDTO(row);
                listThongKe.Add(thongKe);
            }

            return listThongKe;
        }

        public List<ThongKeBanHangDTO> GetListThongKeBanHangInTime(DateTime fromDate, DateTime toDate)
        {
            List<ThongKeBanHangDTO> listThongKe = new List<ThongKeBanHangDTO>();
            
            var table = ThongKeBanHangDAO.Instance.GetListThongKeBanHangInTime(fromDate,toDate);

            foreach (DataRow row in table.Rows)
            {
                ThongKeBanHangDTO thongKe = new ThongKeBanHangDTO(row);
                listThongKe.Add(thongKe);
            }

            return listThongKe;
        }
    }
}
