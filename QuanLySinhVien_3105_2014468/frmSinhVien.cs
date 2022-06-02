using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien_3105_2014468.classes;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLySinhVien_3105_2014468
{
    public partial class frmSinhVien : Form
    {
        #region properties
        private string connectionStrings;
        private SqlConnection conn;
        private SqlCommand cmd;

        private QuanLySinhVien qlSV;
        private QuanLyLop qlLop;
        #endregion

        #region constructors
        public frmSinhVien()
        {
            InitializeComponent();
            // khởi tạo vùng nhớ cho properties
            init();
            // kết nối Database
            connectDB();
            // lấy danh sách lớp
            layDSLop();
            // hiển thị danh sách sinh viên trên ListView
            hienThiDSSinhVien(qlSV.layDSSinhVien());
        }
        #endregion

        #region methods
        private void init()
        {
            qlSV = new QuanLySinhVien();
            qlLop = new QuanLyLop();
        }

        private void connectDB()
        {
            connectionStrings = ConfigurationManager.ConnectionStrings["QLSinhVien"].ConnectionString;
            conn = new SqlConnection(connectionStrings);
            cmd = conn.CreateCommand();

            conn.Open();
        }
        
        private void closeDB()
        {
            conn.Close();
            conn.Dispose();
        }

        private void execCommand(Action callback)
        {
            connectDB();
            callback();
            closeDB();
        }

        private void layDSSinhVien()
        {
            qlSV.clear();

            execCommand(() =>
            {
                string tblName = "SinhVien";
                cmd.CommandText = $"SELECT * FROM {tblName}";
                SqlDataReader records = cmd.ExecuteReader();
                while (records.Read())
                {
                    SinhVien sv = new SinhVien()
                    {
                        id = (int)records["ID"],
                        hoTen = records["HoTen"].ToString(),
                        maLop = (int)records["MaLop"]
                    };
                    qlSV.themSV(sv);
                }
            });
        }

        private void hienThiDSSinhVien(List<SinhVien> ds)
        {
            layDSSinhVien();

            lvSinhVien.Items.Clear();

            foreach (var sv in ds)
            {
                string[] data = { 
                    sv.id.ToString(),
                    sv.hoTen,
                    layTenLopSV(sv.maLop) // lấy tên lớp
                };
                ListViewItem item = new ListViewItem(data);
                lvSinhVien.Items.Add(item);
            }
        }

        private void timKiemSVTheoHoTen(string hoTen)
        {
            if (!string.IsNullOrEmpty(hoTen))
            {
                List<SinhVien> founds = qlSV.timSVTheoHoTen(hoTen);
                hienThiDSSinhVien(founds);
            }
            else
            {
                hienThiDSSinhVien(qlSV.layDSSinhVien());
            }
        }

        private string layTenLopSV(int maLop)
        {
            Lop found = qlLop.timLopTheoMaLop(maLop);
            if (found != null)
            {
                return found.tenLop;
            }
            return "";
        }

        private void layDSLop()
        {
            qlLop.clear();

            execCommand(() =>
            {
                string tblName = "Lop";
                cmd.CommandText = $"SELECT * FROM {tblName}";
                SqlDataReader records = cmd.ExecuteReader();
                while (records.Read())
                {
                    Lop l = new Lop()
                    {
                        id = (int)records["ID"],
                        tenLop = records["TenLop"].ToString(),
                    };
                    qlLop.themLop(l);
                }
            });

            // hiển thị danh sách lớp ra ComboBox
            cbLop.DataSource = qlLop.layDSLop();
            cbLop.ValueMember = "ID";
            cbLop.DisplayMember = "TenLop";
        }

        private void themSV()
        {
            string hoTen = txtHoTen.Text;
            int maLop = int.Parse(cbLop.SelectedValue.ToString());

            // thêm sinh viên vào Database
            execCommand(() =>
            {
                cmd.CommandText = 
                    $"INSERT INTO SinhVien (HoTen, MaLop) " +
                    $"VALUES (N'{hoTen}', {maLop})";
                
                // nếu thực thi query thành công
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Thêm sinh viên thành công!");
                    resetMacDinh();
                    // sau khi thêm thì tải lại danh sách sinh viên
                    hienThiDSSinhVien(qlSV.layDSSinhVien());
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm sinh viên!");
                }
            });

        }

        private void suaSV(int id)
        {
            string hoTen = txtHoTen.Text;
            int maLop = int.Parse(cbLop.SelectedValue.ToString());

            // thêm sinh viên vào Database
            execCommand(() =>
            {
                cmd.CommandText = 
                    $"UPDATE SinhVien " +
                    $"SET HoTen=N'{hoTen}', MaLop={maLop} " +
                    $"WHERE ID={id}";

                // nếu thực thi query thành công
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sửa thông tin sinh viên thành công!");
                    resetMacDinh();
                    // sau khi thêm thì tải lại danh sách sinh viên
                    hienThiDSSinhVien(qlSV.layDSSinhVien());
                }
                else
                {
                    MessageBox.Show("Lỗi khi sửa thông tin sinh viên!");
                }
            });
        }

        private void resetMacDinh()
        {
            txtMSSV.Text = null;
            txtHoTen.Text = null;
            cbLop.Text = null;
            txtTimKiem.Text = null;
        }

        private void bindingThongTinSV(SinhVien sv)
        {
            txtMSSV.Text = sv.id.ToString();
            txtHoTen.Text = sv.hoTen;
            cbLop.Text = layTenLopSV(sv.maLop);
        }
        #endregion

        #region events
        private void frmSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeDB();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            hienThiDSSinhVien(qlSV.layDSSinhVien());
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            resetMacDinh();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TextBox owner = sender as TextBox;
            string hoTen = owner.Text;
            timKiemSVTheoHoTen(hoTen);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            if (string.IsNullOrEmpty(mssv))
            {
                themSV();
            }
            else
            {
                int id = int.Parse(mssv);
                suaSV(id);
            }
        }

        private void lvSinhVien_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // ngăn xử lý sự kiện 2 lần
            if (e.IsSelected)
            {
                ListView owner = sender as ListView;
                int id = int.Parse(owner.SelectedItems[0].Text);

                // tìm sinh viên với id tương ứng
                SinhVien found = qlSV.timSVTheoID(id);
                if (found != null)
                {
                    // lấy thông tin sinh viên đưa vào các Controls
                    bindingThongTinSV(found);
                }
            }
        }
        #endregion
    }
}
