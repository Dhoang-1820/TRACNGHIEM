namespace THITN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.rib_HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MaGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_DangNhap,
            this.btn_TaoTaiKhoan,
            this.btn_DangXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rib_HeThong});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1268, 179);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Caption = "Đăng nhập";
            this.btn_DangNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.Glyph")));
            this.btn_DangNhap.Id = 2;
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btb_DangNhap_ItemClick);
            // 
            // btn_TaoTaiKhoan
            // 
            this.btn_TaoTaiKhoan.Caption = "Tạo tài khoản";
            this.btn_TaoTaiKhoan.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_TaoTaiKhoan.Glyph")));
            this.btn_TaoTaiKhoan.Id = 3;
            this.btn_TaoTaiKhoan.Name = "btn_TaoTaiKhoan";
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng xuất";
            this.btn_DangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.Glyph")));
            this.btn_DangXuat.Id = 4;
            this.btn_DangXuat.Name = "btn_DangXuat";
            // 
            // rib_HeThong
            // 
            this.rib_HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribPageGroup});
            this.rib_HeThong.Name = "rib_HeThong";
            this.rib_HeThong.Text = "Hệ Thống";
            // 
            // ribPageGroup
            // 
            this.ribPageGroup.ItemLinks.Add(this.btn_DangNhap);
            this.ribPageGroup.ItemLinks.Add(this.btn_TaoTaiKhoan);
            this.ribPageGroup.ItemLinks.Add(this.btn_DangXuat);
            this.ribPageGroup.Name = "ribPageGroup";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaGV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1268, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MaGV
            // 
            this.MaGV.Name = "MaGV";
            this.MaGV.Size = new System.Drawing.Size(51, 20);
            this.MaGV.Text = "MAGV";
            this.MaGV.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(57, 20);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(55, 20);
            this.NHOM.Text = "NHOM";
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 714);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribPageGroup;
        private DevExpress.XtraBars.BarButtonItem btn_DangNhap;
        private DevExpress.XtraBars.BarButtonItem btn_TaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MaGV;
        private System.Windows.Forms.ToolStripStatusLabel HOTEN;
        private System.Windows.Forms.ToolStripStatusLabel NHOM;
    }
}

