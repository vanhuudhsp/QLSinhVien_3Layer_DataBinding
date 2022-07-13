
namespace Presentation
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhatProfile = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnDMLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnDMSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapDiem = new DevExpress.XtraBars.BarButtonItem();
            this.pHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.gHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabMain = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(67);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnCapNhatProfile,
            this.btnChangePassword,
            this.btnDMLop,
            this.btnDMSinhVien,
            this.btnNhapDiem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 742;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pHeThong,
            this.pThongKe});
            this.ribbonControl1.Size = new System.Drawing.Size(1148, 219);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng Nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            // 
            // btnCapNhatProfile
            // 
            this.btnCapNhatProfile.Caption = "Cập Nhật Profile";
            this.btnCapNhatProfile.Id = 2;
            this.btnCapNhatProfile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatProfile.ImageOptions.Image")));
            this.btnCapNhatProfile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCapNhatProfile.ImageOptions.LargeImage")));
            this.btnCapNhatProfile.Name = "btnCapNhatProfile";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi Mật Khẩu";
            this.btnChangePassword.Id = 3;
            this.btnChangePassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.Image")));
            this.btnChangePassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.ImageOptions.LargeImage")));
            this.btnChangePassword.Name = "btnChangePassword";
            // 
            // btnDMLop
            // 
            this.btnDMLop.Caption = "Danh Mục Lớp";
            this.btnDMLop.Id = 4;
            this.btnDMLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDMLop.ImageOptions.Image")));
            this.btnDMLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDMLop.ImageOptions.LargeImage")));
            this.btnDMLop.Name = "btnDMLop";
            this.btnDMLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDMLop_ItemClick);
            // 
            // btnDMSinhVien
            // 
            this.btnDMSinhVien.Caption = "Thêm Mới Sinh Viên";
            this.btnDMSinhVien.Id = 5;
            this.btnDMSinhVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDMSinhVien.ImageOptions.SvgImage")));
            this.btnDMSinhVien.Name = "btnDMSinhVien";
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Caption = "Nhập Điểm";
            this.btnNhapDiem.Id = 6;
            this.btnNhapDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhapDiem.ImageOptions.SvgImage")));
            this.btnNhapDiem.Name = "btnNhapDiem";
            // 
            // pHeThong
            // 
            this.pHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.gHeThong,
            this.gSinhVien});
            this.pHeThong.Name = "pHeThong";
            this.pHeThong.Text = "Hệ Thống";
            // 
            // gHeThong
            // 
            this.gHeThong.ItemLinks.Add(this.btnDangNhap);
            this.gHeThong.ItemLinks.Add(this.btnCapNhatProfile);
            this.gHeThong.ItemLinks.Add(this.btnChangePassword);
            this.gHeThong.Name = "gHeThong";
            this.gHeThong.Text = "Hệ Thống";
            // 
            // gSinhVien
            // 
            this.gSinhVien.ItemLinks.Add(this.btnDMLop);
            this.gSinhVien.ItemLinks.Add(this.btnDMSinhVien);
            this.gSinhVien.ItemLinks.Add(this.btnNhapDiem);
            this.gSinhVien.Name = "gSinhVien";
            this.gSinhVien.Text = "Quản Lý Sinh Viên";
            // 
            // pThongKe
            // 
            this.pThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.pThongKe.Name = "pThongKe";
            this.pThongKe.Text = "Thống Kê";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 219);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1148, 372);
            this.tabMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 591);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage pHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup gHeThong;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnCapNhatProfile;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup gSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage pThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDMLop;
        private DevExpress.XtraBars.BarButtonItem btnDMSinhVien;
        private DevExpress.XtraBars.BarButtonItem btnNhapDiem;
        private System.Windows.Forms.TabControl tabMain;
    }
}