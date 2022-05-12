namespace THITN
{
    partial class frmXemKetQua
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label7;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tN_DS = new THITN.TN_DS();
            this.sP_Xem_Ket_QuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Xem_Ket_QuaTableAdapter = new THITN.TN_DSTableAdapters.SP_Xem_Ket_QuaTableAdapter();
            this.tableAdapterManager = new THITN.TN_DSTableAdapters.TableAdapterManager();
            this.sP_Xem_Ket_QuaGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAUSO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAP_AN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDACHON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            mALOPLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Xem_Ket_QuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Xem_Ket_QuaGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(585, 46);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(78, 22);
            mALOPLabel.TabIndex = 6;
            mALOPLabel.Text = "Lần thi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(306, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 22);
            label2.TabIndex = 6;
            label2.Text = "Họ tên :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(792, 118);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(78, 22);
            label7.TabIndex = 12;
            label7.Text = "Lần thi :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1469, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(688, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Môn học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã sinh viên:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 28);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(130, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 28);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Orange;
            this.groupBox2.Controls.Add(this.textEdit5);
            this.groupBox2.Controls.Add(this.textEdit4);
            this.groupBox2.Controls.Add(label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textEdit3);
            this.groupBox2.Controls.Add(this.textEdit2);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.textEdit1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(2, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1469, 172);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textEdit5
            // 
            this.textEdit5.EditValue = "";
            this.textEdit5.Enabled = false;
            this.textEdit5.Location = new System.Drawing.Point(544, 116);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.textEdit5.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit5.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit5.Properties.Appearance.Options.UseFont = true;
            this.textEdit5.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit5.Properties.ReadOnly = true;
            this.textEdit5.Size = new System.Drawing.Size(155, 26);
            this.textEdit5.TabIndex = 14;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "";
            this.textEdit4.Enabled = false;
            this.textEdit4.Location = new System.Drawing.Point(877, 114);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit4.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit4.Properties.Appearance.Options.UseFont = true;
            this.textEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.Size = new System.Drawing.Size(92, 26);
            this.textEdit4.TabIndex = 13;
            this.textEdit4.EditValueChanged += new System.EventHandler(this.textEdit4_EditValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày thi :";
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "";
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(409, 44);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit3.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(319, 26);
            this.textEdit3.TabIndex = 9;
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "";
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(95, 116);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(285, 26);
            this.textEdit2.TabIndex = 8;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "";
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(95, 44);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(137, 26);
            this.textEdit1.TabIndex = 7;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Môn thi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lớp :";
            // 
            // tN_DS
            // 
            this.tN_DS.DataSetName = "TN_DS";
            this.tN_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_Xem_Ket_QuaBindingSource
            // 
            this.sP_Xem_Ket_QuaBindingSource.DataMember = "SP_Xem_Ket_Qua";
            this.sP_Xem_Ket_QuaBindingSource.DataSource = this.tN_DS;
            // 
            // sP_Xem_Ket_QuaTableAdapter
            // 
            this.sP_Xem_Ket_QuaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITN.TN_DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_Xem_Ket_QuaGridControl
            // 
            this.sP_Xem_Ket_QuaGridControl.DataSource = this.sP_Xem_Ket_QuaBindingSource;
            this.sP_Xem_Ket_QuaGridControl.Location = new System.Drawing.Point(2, 293);
            this.sP_Xem_Ket_QuaGridControl.MainView = this.gridView1;
            this.sP_Xem_Ket_QuaGridControl.Name = "sP_Xem_Ket_QuaGridControl";
            this.sP_Xem_Ket_QuaGridControl.Size = new System.Drawing.Size(1469, 339);
            this.sP_Xem_Ket_QuaGridControl.TabIndex = 3;
            this.sP_Xem_Ket_QuaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAUSO,
            this.colNOIDUNG,
            this.colA,
            this.colB,
            this.colC,
            this.colD,
            this.colDAP_AN,
            this.colDACHON,
            this.colSTT});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1232, 569, 328, 290);
            this.gridView1.GridControl = this.sP_Xem_Ket_QuaGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCAUSO
            // 
            this.colCAUSO.AppearanceCell.Options.UseTextOptions = true;
            this.colCAUSO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCAUSO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCAUSO.AppearanceHeader.Options.UseTextOptions = true;
            this.colCAUSO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCAUSO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCAUSO.FieldName = "CAUSO";
            this.colCAUSO.MinWidth = 25;
            this.colCAUSO.Name = "colCAUSO";
            this.colCAUSO.Visible = true;
            this.colCAUSO.VisibleIndex = 1;
            this.colCAUSO.Width = 93;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOIDUNG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOIDUNG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.MinWidth = 25;
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 2;
            this.colNOIDUNG.Width = 93;
            // 
            // colA
            // 
            this.colA.AppearanceHeader.Options.UseTextOptions = true;
            this.colA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colA.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colA.FieldName = "A";
            this.colA.MinWidth = 25;
            this.colA.Name = "colA";
            this.colA.Visible = true;
            this.colA.VisibleIndex = 3;
            this.colA.Width = 93;
            // 
            // colB
            // 
            this.colB.AppearanceHeader.Options.UseTextOptions = true;
            this.colB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colB.FieldName = "B";
            this.colB.MinWidth = 25;
            this.colB.Name = "colB";
            this.colB.Visible = true;
            this.colB.VisibleIndex = 4;
            this.colB.Width = 93;
            // 
            // colC
            // 
            this.colC.AppearanceHeader.Options.UseTextOptions = true;
            this.colC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colC.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colC.FieldName = "C";
            this.colC.MinWidth = 25;
            this.colC.Name = "colC";
            this.colC.Visible = true;
            this.colC.VisibleIndex = 5;
            this.colC.Width = 93;
            // 
            // colD
            // 
            this.colD.AppearanceHeader.Options.UseTextOptions = true;
            this.colD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colD.FieldName = "D";
            this.colD.MinWidth = 25;
            this.colD.Name = "colD";
            this.colD.Visible = true;
            this.colD.VisibleIndex = 6;
            this.colD.Width = 93;
            // 
            // colDAP_AN
            // 
            this.colDAP_AN.AppearanceCell.Options.UseTextOptions = true;
            this.colDAP_AN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDAP_AN.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDAP_AN.AppearanceHeader.Options.UseTextOptions = true;
            this.colDAP_AN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDAP_AN.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDAP_AN.FieldName = "DAP_AN";
            this.colDAP_AN.MinWidth = 25;
            this.colDAP_AN.Name = "colDAP_AN";
            this.colDAP_AN.Visible = true;
            this.colDAP_AN.VisibleIndex = 7;
            this.colDAP_AN.Width = 93;
            // 
            // colDACHON
            // 
            this.colDACHON.AppearanceCell.Options.UseTextOptions = true;
            this.colDACHON.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDACHON.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDACHON.AppearanceHeader.Options.UseTextOptions = true;
            this.colDACHON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDACHON.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colDACHON.FieldName = "DACHON";
            this.colDACHON.MinWidth = 25;
            this.colDACHON.Name = "colDACHON";
            this.colDACHON.Visible = true;
            this.colDACHON.VisibleIndex = 8;
            this.colDACHON.Width = 106;
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Options.UseTextOptions = true;
            this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 25;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 52;
            // 
            // frmXemKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 652);
            this.Controls.Add(this.sP_Xem_Ket_QuaGridControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXemKetQua";
            this.Text = "frmXemKetQua";
            this.Load += new System.EventHandler(this.frmXemKetQua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tN_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Xem_Ket_QuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Xem_Ket_QuaGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private TN_DS tN_DS;
        private System.Windows.Forms.BindingSource sP_Xem_Ket_QuaBindingSource;
        private TN_DSTableAdapters.SP_Xem_Ket_QuaTableAdapter sP_Xem_Ket_QuaTableAdapter;
        private TN_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_Xem_Ket_QuaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCAUSO;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colA;
        private DevExpress.XtraGrid.Columns.GridColumn colB;
        private DevExpress.XtraGrid.Columns.GridColumn colC;
        private DevExpress.XtraGrid.Columns.GridColumn colD;
        private DevExpress.XtraGrid.Columns.GridColumn colDAP_AN;
        private DevExpress.XtraGrid.Columns.GridColumn colDACHON;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
    }
}