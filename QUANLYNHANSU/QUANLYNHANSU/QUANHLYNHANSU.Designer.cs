namespace QUANLYNHANSU
{
    partial class QUANLY2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVNHANSU = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQUEQUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSĐT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.txtMASO = new System.Windows.Forms.TextBox();
            this.dTPNGAYSINH2 = new System.Windows.Forms.DateTimePicker();
            this.comSEX2 = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.comNATIVE2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNHANSU)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVNHANSU
            // 
            this.dGVNHANSU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNHANSU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.clmMaso,
            this.clmHoten,
            this.clmQUEQUAN,
            this.clmNGAYSINH,
            this.clmGIOITINH,
            this.clmSĐT});
            this.dGVNHANSU.Location = new System.Drawing.Point(24, 189);
            this.dGVNHANSU.Margin = new System.Windows.Forms.Padding(4);
            this.dGVNHANSU.MultiSelect = false;
            this.dGVNHANSU.Name = "dGVNHANSU";
            this.dGVNHANSU.ReadOnly = true;
            this.dGVNHANSU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVNHANSU.Size = new System.Drawing.Size(753, 258);
            this.dGVNHANSU.TabIndex = 0;
            this.dGVNHANSU.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dGVNHANSU_RowPrePaint_1);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // clmMaso
            // 
            this.clmMaso.DataPropertyName = "maso";
            this.clmMaso.HeaderText = "Mã số";
            this.clmMaso.Name = "clmMaso";
            this.clmMaso.ReadOnly = true;
            this.clmMaso.Width = 70;
            // 
            // clmHoten
            // 
            this.clmHoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmHoten.DataPropertyName = "ten";
            this.clmHoten.HeaderText = "Họ tên";
            this.clmHoten.Name = "clmHoten";
            this.clmHoten.ReadOnly = true;
            // 
            // clmQUEQUAN
            // 
            this.clmQUEQUAN.DataPropertyName = "quequan";
            this.clmQUEQUAN.HeaderText = "Quê quán";
            this.clmQUEQUAN.Name = "clmQUEQUAN";
            this.clmQUEQUAN.ReadOnly = true;
            this.clmQUEQUAN.Width = 150;
            // 
            // clmNGAYSINH
            // 
            this.clmNGAYSINH.DataPropertyName = "ngaysinh";
            this.clmNGAYSINH.HeaderText = "Ngày sinh";
            this.clmNGAYSINH.Name = "clmNGAYSINH";
            this.clmNGAYSINH.ReadOnly = true;
            this.clmNGAYSINH.Width = 150;
            // 
            // clmGIOITINH
            // 
            this.clmGIOITINH.DataPropertyName = "gioitinh";
            this.clmGIOITINH.HeaderText = "Giới tính";
            this.clmGIOITINH.Name = "clmGIOITINH";
            this.clmGIOITINH.ReadOnly = true;
            this.clmGIOITINH.Width = 70;
            // 
            // clmSĐT
            // 
            this.clmSĐT.DataPropertyName = "sdt";
            this.clmSĐT.HeaderText = "Số điện thoại";
            this.clmSĐT.Name = "clmSĐT";
            this.clmSĐT.ReadOnly = true;
            this.clmSĐT.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quê quán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số điện thoại:";
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(104, 13);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(280, 22);
            this.txtNAME.TabIndex = 7;
            // 
            // txtMASO
            // 
            this.txtMASO.Location = new System.Drawing.Point(104, 44);
            this.txtMASO.Name = "txtMASO";
            this.txtMASO.Size = new System.Drawing.Size(280, 22);
            this.txtMASO.TabIndex = 8;
            // 
            // dTPNGAYSINH2
            // 
            this.dTPNGAYSINH2.CustomFormat = "dd/MM/yyyy";
            this.dTPNGAYSINH2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNGAYSINH2.Location = new System.Drawing.Point(536, 11);
            this.dTPNGAYSINH2.Name = "dTPNGAYSINH2";
            this.dTPNGAYSINH2.Size = new System.Drawing.Size(131, 22);
            this.dTPNGAYSINH2.TabIndex = 10;
            // 
            // comSEX2
            // 
            this.comSEX2.FormattingEnabled = true;
            this.comSEX2.Location = new System.Drawing.Point(536, 44);
            this.comSEX2.Name = "comSEX2";
            this.comSEX2.Size = new System.Drawing.Size(131, 24);
            this.comSEX2.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(536, 76);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(241, 22);
            this.txtSDT.TabIndex = 12;
            // 
            // btnTHEM
            // 
            this.btnTHEM.Location = new System.Drawing.Point(24, 119);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(184, 42);
            this.btnTHEM.TabIndex = 13;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(307, 119);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(184, 42);
            this.btnSUA.TabIndex = 14;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(593, 119);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(184, 42);
            this.btnXOA.TabIndex = 15;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // comNATIVE2
            // 
            this.comNATIVE2.FormattingEnabled = true;
            this.comNATIVE2.Location = new System.Drawing.Point(104, 76);
            this.comNATIVE2.Name = "comNATIVE2";
            this.comNATIVE2.Size = new System.Drawing.Size(280, 24);
            this.comNATIVE2.TabIndex = 17;
            // 
            // QUANLY2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.comNATIVE2);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.comSEX2);
            this.Controls.Add(this.dTPNGAYSINH2);
            this.Controls.Add(this.txtMASO);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVNHANSU);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QUANLY2";
            this.Size = new System.Drawing.Size(805, 478);
            this.Load += new System.EventHandler(this.QUANLY2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVNHANSU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVNHANSU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.TextBox txtMASO;
        private System.Windows.Forms.DateTimePicker dTPNGAYSINH2;
        private System.Windows.Forms.ComboBox comSEX2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.ComboBox comNATIVE2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQUEQUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSĐT;
    }
}
