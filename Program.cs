using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.SqlClient;

namespace THITN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr_publisher = "Data Source=DESKTOP-8BQ2NC6;Initial Catalog=THI_TN;Integrated Security=True";
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";


        public static BindingSource bds_dspm = new BindingSource();  // luôn kết nối đến server, thay đổi khi dữ liệu thay đổi.
        public static frmMain frmChinh;



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
