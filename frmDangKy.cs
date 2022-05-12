<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
           

            if (Program.mGroup == "TRUONG")
            {
                cmbLoaiTK.Items.Add("TRUONG");
                cmbLoaiTK.Enabled = false;
            }
            if (Program.mGroup == "COSO")
            {
                cmbLoaiTK.Items.Add("COSO");
                cmbLoaiTK.Items.Add("GIANGVIEN");
            }
            cmbLoaiTK.SelectedIndex = 0;
            
            this.tN_DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'tN_DS.DsGiAOVIEN' table. You can move, or remove it, as needed.
            this.dsGiAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dsGiAOVIENTableAdapter.Fill(this.tN_DS.DsGiAOVIEN);

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string checkLoginExists = "Exec [dbo].[SP_Kt_Loginname] '" + txtLogin.Text + "'";
            string checkUserExists = "Exec [dbo].[SP_Kt_Username] '" + cmbUser.SelectedValue.ToString() + "'";
            string crAccount = "Exec [dbo].[SP_Tao_Tai_Khoan] '" + txtLogin.Text + "', '" + cmbUser.SelectedValue.ToString() + "', '" + txtPassword.Text + "', '" + cmbLoaiTK.SelectedItem.ToString() + "'";
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            if (Program.ExecSqlNonQuery(checkLoginExists) == 1)
            {
                txtLogin.Focus();
                return;
            } else if (Program.ExecSqlNonQuery(checkUserExists) == 1)
            {
                cmbUser.Focus();
                return;
            } else
            {
                try
                {
                    Program.ExecSqlNonQuery(crAccount);
                    MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
                } catch (Exception ) { }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imageEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> 1612c1647b32028b8794a6d4ab03c680feecdf5f
