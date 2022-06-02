using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_3105_2014468.classes
{
    public class QuanLyLop
    {
        #region properties
        private List<Lop> dsLop;
        #endregion

        #region constructors
        public QuanLyLop()
        {
            dsLop = new List<Lop>();
        }
        #endregion

        #region methods
        public List<Lop> layDSLop()
        {
            return dsLop;
        }

        public void themLop(Lop l)
        {
            dsLop.Add(l);
        }

        public Lop timLopTheoMaLop(int maLop)
        {
            return dsLop.Find(l => l.id == maLop);
        }

        public void clear()
        {
            dsLop.Clear();
        }
        #endregion
    }
}
