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
    public class QuanAoBUS
    {
        private QuanAoBUS() { }

        private static QuanAoBUS _instance;
        public static QuanAoBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new QuanAoBUS();
                }
                return _instance;
            }
        }
        public List<QuanAoDTO> Load_QA()
        {
            List<QuanAoDTO> listQuanAo = new List<QuanAoDTO>();

            var table = QuanAoDAO.Instance.Load_QA();

            foreach (DataRow row in table.Rows)
            {
                QuanAoDTO quanAo = new QuanAoDTO(row);
                listQuanAo.Add(quanAo);
            }

            return listQuanAo;
        }
        public List<QuanAoDTO> tiemkiemqa(string tiemkiem)
        {
            List<QuanAoDTO> listQuanAo = new List<QuanAoDTO>();
            var table = QuanAoDAO.Instance.tiemkiem(tiemkiem);

            foreach (DataRow row in table.Rows)
            {
                QuanAoDTO quanAo = new QuanAoDTO(row);
                listQuanAo.Add(quanAo);
            }

            return listQuanAo;
        }
    }
}
