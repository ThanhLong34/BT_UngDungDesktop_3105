namespace QuanLySinhVien_3105_2014468
{
    partial class frmSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên SV:";
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(200, 133);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(305, 25);
            this.cbLop.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(200, 94);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(305, 24);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(200, 54);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.ReadOnly = true;
            this.txtMSSV.Size = new System.Drawing.Size(305, 24);
            this.txtMSSV.TabIndex = 999;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvSinhVien);
            this.groupBox1.Location = new System.Drawing.Point(11, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 352);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chHoTen,
            this.chLop});
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 20);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(535, 329);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvSinhVien_ItemSelectionChanged);
            // 
            // chId
            // 
            this.chId.Text = "ID";
            // 
            // chHoTen
            // 
            this.chHoTen.Text = "Họ tên ";
            this.chHoTen.Width = 335;
            // 
            // chLop
            // 
            this.chLop.Text = "Lớp";
            this.chLop.Width = 136;
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.AutoSize = true;
            this.btnMacDinh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMacDinh.FlatAppearance.BorderSize = 0;
            this.btnMacDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMacDinh.ForeColor = System.Drawing.Color.Black;
            this.btnMacDinh.Location = new System.Drawing.Point(308, 185);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(89, 32);
            this.btnMacDinh.TabIndex = 4;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = false;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.AutoSize = true;
            this.btnTaiLai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaiLai.FlatAppearance.BorderSize = 0;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.ForeColor = System.Drawing.Color.Black;
            this.btnTaiLai.Location = new System.Drawing.Point(416, 185);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(89, 32);
            this.btnTaiLai.TabIndex = 5;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTimKiem.Location = new System.Drawing.Point(280, 248);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(269, 24);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(195, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "QUẢN LÝ SINH VIÊN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tìm kiếm";
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.Location = new System.Drawing.Point(200, 185);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 32);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(564, 641);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnMacDinh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cerebri Sans Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSinhVien_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TxtTimKiem_GotFocus(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chHoTen;
        private System.Windows.Forms.ColumnHeader chLop;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
    }
}

