using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_3105_2014468.classes
{
    public class QuanLyLop : QuanLy<Lop>
    {
        #region properties
        #endregion

        #region constructors
        #endregion

        #region methods
        public Lop timLopTheoID(int id)
        {
            return ds.Find(lop => lop.id == id);
        }
        #endregion
    }
}
