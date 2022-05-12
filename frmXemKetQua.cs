using System;
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
    public partial class frmXemKetQua : Form
    {
        public frmXemKetQua()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            textEdit3.Text = "";
            textEdit1.Text = "";
            textEdit5.Text = "";
            String lenh = "";
            lenh = "SELECT HO,TEN,MALOP FROM SINHVIEN WHERE MASV = '" + textBox1.Text + "'";
            try
            {
                
                Program.myreader = Program.ExecSqlDataReader(lenh);
                if (Program.myreader == null) return;
                Program.myreader.Read();
                textEdit3.Text = Program.myreader.GetString(0);
                textEdit3.Text += Program.myreader.GetString(1);
                textEdit1.Text = Program.myreader.GetString(2);
                Program.myreader.Close();
            }
            catch(Exception ex)
            {   
                Program.myreader.Close();
                MessageBox.Show("Không thể tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                lenh = "SELECT NGAYTHI,DIEM FROM BANGDIEM WHERE MASV='" + textBox1.Text + "' AND MAMH='" + textBox2.Text + "' AND LAN=" + comboBox1.Text;
                Program.myreader = Program.ExecSqlDataReader(lenh);
                if (Program.myreader == null) return;
                Program.myreader.Read();
                textEdit5.Text = Program.myreader.GetDateTime(0).ToString();
                // diem =Program.myreader.GetString(1);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không thể tìm thấy môn thi!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                
                this.sP_Xem_Ket_QuaTableAdapter.Fill(this.tN_DS.SP_Xem_Ket_Qua, textBox1.Text, textBox2.Text, new System.Nullable<short>(((short)(System.Convert.ChangeType(comboBox1.Text, typeof(short))))));
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void frmXemKetQua_Load(object sender, EventArgs e)
        {
            if(Program.mGroup=="SINHVIEN")
            {
                textBox1.Text = Program.username;
                textBox1.Enabled = false;
                
            }
            else
            {
                textBox1.Enabled = true;

            }
            

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
