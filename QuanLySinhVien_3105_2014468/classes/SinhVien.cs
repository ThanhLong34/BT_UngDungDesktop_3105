using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_3105_2014468.classes
{
    public class SinhVien
    {
        #region properties
        public int id { get; set; }
        public string hoTen { get; set; }
        public int maLop { get; set; }
        #endregion

        #region constructors
        public SinhVien()
        {

        }

        public SinhVien(int id, string hoTen, int maLop)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.maLop = maLop;
        }
        #endregion

        #region methods

        #endregion
    }
}
