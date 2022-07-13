using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Entity;
using System.IO;
namespace Presentation
{
    public partial class frmSinhVien : Form
    {

        string path = "../../Hinh";
        List<SINHVIEN> Bang_SINHVIEN;
        List<LOP> Bang_LOP;
        QLSINHVIEN4Entities db;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new QLSINHVIEN4Entities();
            Bang_SINHVIEN = db.SINHVIENs.ToList() ;
            Bang_LOP = db.LOPs.ToList();
            loadCBOLop();
            LoadDGVHocSinh();
            //txtMaSV.DataBindings.Add("text", Bang_SINHVIEN, "MaSV", true);
            //txtHoTen.DataBindings.Add("text", Bang_SINHVIEN, "HoTen", true);
            //dateNgaySinh.DataBindings.Add("text", Bang_SINHVIEN, "NgaySinh", true);
            //radNam.DataBindings.Add("checked", Bang_SINHVIEN, "GioiTinh", true);
            //cboLop.DataBindings.Add("SelectedValue", Bang_SINHVIEN, "MaLop", true);
            //txtQueQuan.DataBindings.Add("text", Bang_SINHVIEN, "DiaChi", true);
            //pHinh.DataBindings.Add("ImageLocation", Bang_SINHVIEN, "Hinh", true);
            enabledNutLenh(false);
        }


        private void enabledNutLenh(bool pCapNhat)
        {
            btnThem.Enabled = !pCapNhat;
            btnXoa.Enabled = !pCapNhat;
            btnSua.Enabled = !pCapNhat;
            btnThoat.Enabled = !pCapNhat;
            btnLuu.Enabled = pCapNhat;
            btnHuy.Enabled = pCapNhat;
        }
        private void loadCBOLop()
        {
            cboLop.DataSource = Bang_LOP;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

        private void LoadDGVHocSinh()
        {
            dgvDSSV.AutoGenerateColumns = false;
            dgvDSSV.DataSource = Bang_SINHVIEN;
        }


        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //DSSV.AddNew();
            SINHVIEN sv = new SINHVIEN();
            sv.MaSV = txtMaSV.Text;
            sv.HoTen = txtHoTen.Text;
            sv.NgaySinh = dateNgaySinh.Value;
            sv.MaLop = cboLop.SelectedValue.ToString();
            sv.DiaChi = txtQueQuan.Text;
            Bang_SINHVIEN.Add(sv);
            db.SaveChanges();
            enabledNutLenh(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                db.SaveChanges();
                enabledNutLenh(false);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            enabledNutLenh(false);
          
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {

           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvDSSV_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
