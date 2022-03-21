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
        SqlConnection conn_publisher = new SqlConnection();

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
                conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbCoso.DataSource = Program.bds_dspm;
            cmbCoso.DisplayMember = "TENCS";
            cmbCoso.ValueMember = "TENSERVER";
        }
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            } catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc.\nBạn xem lại tên server của Publisher, và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;  
            }
        }
     
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM Get_Subscribes");
            cmbCoso.SelectedIndex = 1;
            cmbCoso.SelectedIndex = 0;

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
