using System;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btb_DangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void HienThiMenu()
        {
            MaSo.Text = "Mã GV: " + Program.username;
            HoTen.Text = "Họ và tên: " + Program.mHoten;
            Nhom.Text = "Nhóm: " + Program.mGroup;
            if (Program.mGroup == "SINHVIEN")
                rib_SinhVien.Visible = true;
            if (Program.mGroup == "GIANGVIEN")
                rib_QuanLy.Visible = true;
            if (Program.mGroup == "COSO" || Program.mGroup == "TRUONG")
            {
                btn_TaoTaiKhoan.Enabled = true;
                rib_QuanLy.Visible = true;
                rib_SinhVien.Visible = true;
            }    
            btn_DangXuat.Enabled = true;
        }

        private void btn_TaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangKy));
            if (frm != null) frm.Activate();
            else
            {
                frmDangKy f = new frmDangKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_TaoTaiKhoan.Enabled = false;
            rib_QuanLy.Visible = false;
            rib_SinhVien.Visible = false;
        }

        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKhoa));
            if (frm != null) frm.Activate();
            else
            {
                frmKhoa f = new frmKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.checkThiGV = false;
            Form frm = this.CheckExists(typeof(frmChonMonThi));
            if (frm != null) frm.Activate();
            else
            {
                frmChonMonThi f = new frmChonMonThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.checkThiGV = true;
            Form frm = this.CheckExists(typeof(frmChonMonThi));
            if (frm != null) frm.Activate();
            else
            {
                frmChonMonThi f = new frmChonMonThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnXemKetQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmXemKetQua));
            if (frm != null) frm.Activate();
            else
            {
                frmXemKetQua f = new frmXemKetQua();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
