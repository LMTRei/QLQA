using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class LoaiQABUS
    {
        private LoaiQABUS() { }
        private static LoaiQABUS _instance;
        public static LoaiQABUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoaiQABUS();
                }
                return _instance;
            }
        }

        public List<LoaiQADTO> Load_LQA()
        {
            List<LoaiQADTO> listLQA = new List<LoaiQADTO>();
            var LQA = LoaiQADAO.Instance.Load_LQA();

            foreach (DataRow row in LQA.Rows)
            {
                LoaiQADTO lqa = new LoaiQADTO(row);
                listLQA.Add(lqa);
            }

            return listLQA;
        }
    }
}

