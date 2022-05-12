using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THITN
{
    public partial class frmDangNhap : Form
    {
        

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn_publisher.State == ConnectionState.Closed)
                Program.conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn_publisher);
            da.Fill(dt);
            Program.conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbCoso.DataSource = Program.bds_dspm;
            cmbCoso.DisplayMember = "TENCS";
            cmbCoso.ValueMember = "TENSERVER";
        }
        public frmDangNhap()
        {
            InitializeComponent();
        }

     
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM Get_Subscribes");
            cmbCoso.SelectedIndex = 1; cmbCoso.SelectedIndex = 0;
        }

        private void cmbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCoso.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Login name và password không được để trống", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = txtLogin.Text;
            Program.password = txtPassword.Text;
            
            if (Program.KetNoi() == 0) return;
            
            Program.mChinhanh = cmbCoso.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            string strLenh;
            if (rdoGiangVien.Checked)
            {
                strLenh = "EXEC SP_Lay_Thong_Tin_GV_Tu_Login '" + Program.mlogin + "'";
            }
            else
            {
                strLenh = "EXEC SP_Lay_Thong_Tin_SV_Tu_Login '" + Program.mlogin + "'";
            }

            Program.myreader = Program.ExecSqlDataReader(strLenh);
            
            if (Program.myreader == null) return;
            
            Program.myreader.Read();
            Program.username = Program.myreader.GetString(0);
            
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu.\nBạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }
            
            
            Program.mHoten = Program.myreader.GetString(1);
            Program.mGroup = Program.myreader.GetString(2);
            Program.myreader.Close();
            Program.conn.Close();
            Program.frmChinh.HienThiMenu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grBox_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
