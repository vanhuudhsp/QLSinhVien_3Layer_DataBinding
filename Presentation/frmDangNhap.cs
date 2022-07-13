using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmDangNhap : Form
    {
        private QLSINHVIEN4Entities db;
        private List<TAIKHOAN> tblTaiKhoan;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            db = new QLSINHVIEN4Entities();
            tblTaiKhoan = db.TAIKHOANs.ToList();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TAIKHOAN tk = tblTaiKhoan.Where(t => t.UserName == txtUserName.Text && t.PassWord == txtPassword.Text).FirstOrDefault();
            if (tk != null)
            {
                frmMain fMain = new frmMain();
                fMain.WindowState = FormWindowState.Maximized;
                fMain.Show();

            }
            else
            {
                MessageBox.Show("Dang Nhap That Bai");
            }
        }
    }
}
