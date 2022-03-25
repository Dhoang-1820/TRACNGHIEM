namespace THITN
{
    partial class frmDangNhap
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
            this.cmbCoso = new System.Windows.Forms.ComboBox();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.rdoSinhVien = new System.Windows.Forms.RadioButton();
            this.rdoGiangVien = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbCoSo = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCoso
            // 
            this.cmbCoso.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoso.FormattingEnabled = true;
            this.cmbCoso.Location = new System.Drawing.Point(163, 80);
            this.cmbCoso.Name = "cmbCoso";
            this.cmbCoso.Size = new System.Drawing.Size(230, 28);
            this.cmbCoso.TabIndex = 0;
            this.cmbCoso.SelectedIndexChanged += new System.EventHandler(this.cmbCoso_SelectedIndexChanged);
            // 
            // grBox
            // 
            this.grBox.Controls.Add(this.rdoSinhVien);
            this.grBox.Controls.Add(this.rdoGiangVien);
            this.grBox.Controls.Add(this.txtPassword);
            this.grBox.Controls.Add(this.txtLogin);
            this.grBox.Controls.Add(this.lbPassword);
            this.grBox.Controls.Add(this.lbLogin);
            this.grBox.Controls.Add(this.lbCoSo);
            this.grBox.Controls.Add(this.cmbCoso);
            this.grBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox.Location = new System.Drawing.Point(128, 45);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(450, 234);
            this.grBox.TabIndex = 1;
            this.grBox.TabStop = false;
            this.grBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoSinhVien
            // 
            this.rdoSinhVien.AutoSize = true;
            this.rdoSinhVien.Location = new System.Drawing.Point(265, 37);
            this.rdoSinhVien.Name = "rdoSinhVien";
            this.rdoSinhVien.Size = new System.Drawing.Size(99, 25);
            this.rdoSinhVien.TabIndex = 9;
            this.rdoSinhVien.TabStop = true;
            this.rdoSinhVien.Text = "Sinh viên";
            this.rdoSinhVien.UseVisualStyleBackColor = true;
            // 
            // rdoGiangVien
            // 
            this.rdoGiangVien.AutoSize = true;
            this.rdoGiangVien.Location = new System.Drawing.Point(104, 37);
            this.rdoGiangVien.Name = "rdoGiangVien";
            this.rdoGiangVien.Size = new System.Drawing.Size(110, 25);
            this.rdoGiangVien.TabIndex = 8;
            this.rdoGiangVien.TabStop = true;
            this.rdoGiangVien.Text = "Giảng viên";
            this.rdoGiangVien.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(163, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(230, 28);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(163, 131);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(230, 28);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(59, 183);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(84, 21);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            this.lbPassword.Click += new System.EventHandler(this.lbMatKhau_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(59, 134);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(53, 21);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Login";
            this.lbLogin.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbCoSo
            // 
            this.lbCoSo.AutoSize = true;
            this.lbCoSo.Location = new System.Drawing.Point(59, 84);
            this.lbCoSo.Name = "lbCoSo";
            this.lbCoSo.Size = new System.Drawing.Size(56, 21);
            this.lbCoSo.TabIndex = 1;
            this.lbCoSo.Text = "Cơ sở";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(191, 306);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(111, 31);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(431, 306);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 31);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
           
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 414);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.grBox);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCoso;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbCoSo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
<<<<<<< HEAD
        private System.Windows.Forms.RadioButton rdoSinhVien;
        private System.Windows.Forms.RadioButton rdoGiangVien;
=======
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
>>>>>>> b4cf343f46e19a97e5be65b66042be05f488fdbd
    }
}