using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_3105_2014468.classes
{
    public class QuanLySinhVien : QuanLy<SinhVien>
    {
        #region properties
        #endregion

        #region constructors
        #endregion

        #region methods
        public List<SinhVien> timSVTheoHoTen(string hoTen)
        {
            return ds.FindAll(sv => {
                return sv.hoTen.ToLower().Contains(hoTen.ToLower());
            });
        }

        public SinhVien timSVTheoID(int id)
        {
            return ds.Find(sv => sv.id == id);
        }
        #endregion
    }
}
