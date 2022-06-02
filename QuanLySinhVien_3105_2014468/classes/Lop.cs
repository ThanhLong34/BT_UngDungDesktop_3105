using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_3105_2014468.classes
{
    public class Lop
    {
        #region properties
        public int id { get; set; }
        public string tenLop { get; set; }
        #endregion

        #region constructors
        public Lop()
        {

        }

        public Lop(int id, string tenLop)
        {
            this.id = id;
            this.tenLop = tenLop;
        }
        #endregion

        #region methods

        #endregion
    }
}
