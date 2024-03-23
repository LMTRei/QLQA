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
    public class HinhQABUS
    {
        private HinhQABUS() { }
        private static HinhQABUS _instance;
        public static HinhQABUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HinhQABUS();
                }
                return _instance;
            }
        }

        public HinhQADTO Load_HinhSanPham(int id_QA)
        {

            var table = HinhQADAO.Instance.Load_HinhSanPham(id_QA);
            if (table.Rows.Count == 0) return null;

            return new HinhQADTO(table.Rows[0]);
        }
       
    }
}
