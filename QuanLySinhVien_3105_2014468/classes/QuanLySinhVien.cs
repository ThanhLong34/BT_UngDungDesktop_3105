using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_3105_2014468.classes
{
    public class QuanLySinhVien
    {
        #region properties
        private List<SinhVien> dsSV;
        #endregion

        #region constructors
        public QuanLySinhVien()
        {
            dsSV = new List<SinhVien>();
        }
        #endregion

        #region methods
        public void themSV(SinhVien sv)
        { 
            dsSV.Add(sv);
        }

        public List<SinhVien> layDSSinhVien()
        {
            return dsSV;
        }

        public void clear()
        {
            dsSV.Clear();
        }

        public List<SinhVien> timSVTheoHoTen(string hoTen)
        {
            return dsSV.FindAll(sv => {
                return sv.hoTen.ToLower().Contains(hoTen.ToLower());
            });
        }

        public SinhVien timSVTheoID(int id)
        {
            return dsSV.Find(sv => sv.id == id);
        }
        #endregion

    }
}
