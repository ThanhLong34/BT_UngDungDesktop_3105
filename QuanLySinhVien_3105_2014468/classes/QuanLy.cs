using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_3105_2014468.classes
{
    public class QuanLy<T>
    {
        #region properties
        protected List<T> ds;
        #endregion

        #region constructors
        public QuanLy()
        {
            ds = new List<T>();
        }
        #endregion

        #region methods
        public void clear()
        {
            ds.Clear();
        }

        public void them(T item)
        {
            ds.Add(item);
        }

        public List<T> layDS()
        {
            return ds;
        }
        #endregion

    }
}
