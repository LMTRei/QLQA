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
    public class ChiTietBanHangBUS
    {
        private ChiTietBanHangBUS() { }

        private static ChiTietBanHangBUS _instance;
        public static ChiTietBanHangBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChiTietBanHangBUS();
                }
                return _instance;
            }
        }
        public List<ChiTietBanHangDTO> Load_CTBH(int id_BH)
        {
            List<ChiTietBanHangDTO> listCTBH = new List<ChiTietBanHangDTO>();

            var table = ChiTietBanHangDAO.Instance.Load_CTBH(id_BH);

            foreach (DataRow row in table.Rows)
            {
                ChiTietBanHangDTO chiTietBanHang = new ChiTietBanHangDTO(row);
                listCTBH.Add(chiTietBanHang);
            }

            return listCTBH;
        }
        public bool InsertChiTietBanHang(int id_QA, int id_BH, int soluongsanpham)
        {
            int result = ChiTietBanHangDAO.Instance.InsertChiTietBanHang(id_QA, id_BH, soluongsanpham);
            return result > 0;
        }
    }
}
