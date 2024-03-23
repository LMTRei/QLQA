using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DTO
{
    public class HinhQADTO
    {
        private int _ID_HQA;
        private byte[] _HinhQA;
        private string _HinhQAP;
        private int ID_QA;

        public HinhQADTO(int iD_HQA, byte[] hinhQA, string hinhQAP, int iD_QA1)
        {
            ID_HQA = iD_HQA;
            HinhQA = hinhQA;
            HinhQAP = hinhQAP;
            ID_QA1 = iD_QA1;
        }

        public HinhQADTO(DataRow row)
        {
            ID_HQA = (int)row["ID_HQA"];
            HinhQA = (byte[])row["HinhQA"];
            HinhQAP = row["HinhQAP"].ToString();
            ID_QA = (int)row["ID_QA"];
        }

        public int ID_HQA { get => _ID_HQA; set => _ID_HQA = value; }
        public byte[] HinhQA { get => _HinhQA; set => _HinhQA = value; }
        public string HinhQAP { get => _HinhQAP; set => _HinhQAP = value; }
        public int ID_QA1 { get => ID_QA; set => ID_QA = value; }

        public Image ToImage()
        {
            using (var ms = new MemoryStream(HinhQA))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
    }
}
