namespace Quanlythuvien.GUI
{
    partial class frmQuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySach));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            gobThongTinSach = new GroupBox();
            panel3 = new Panel();
            cboMaTheLoai = new ComboBox();
            nudSoLuong = new NumericUpDown();
            nudNamXB = new NumericUpDown();
            txtTenSach = new TextBox();
            txtTacGia = new TextBox();
            txtMaSach = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            groupBox4 = new GroupBox();
            lblTongSo = new Label();
            dgvDanhSachSach = new DataGridView();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            TacGia = new DataGridViewTextBoxColumn();
            NamXuatBan = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            MaTheLoai = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gobThongTinSach.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNamXB).BeginInit();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSach).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 288);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(gobThongTinSach);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1086, 288);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản lý sách";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel4);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(599, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(484, 246);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thao tác";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(btnXoa);
            panel4.Controls.Add(btnSua);
            panel4.Controls.Add(btnThem);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(3, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(402, 220);
            panel4.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Red;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(92, 162);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(92, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.HotTrack;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(200, 162);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(200, 94);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.HotTrack;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = SystemColors.Window;
            btnThem.Location = new Point(200, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // gobThongTinSach
            // 
            gobThongTinSach.Controls.Add(panel3);
            gobThongTinSach.Dock = DockStyle.Left;
            gobThongTinSach.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gobThongTinSach.Location = new Point(3, 39);
            gobThongTinSach.Name = "gobThongTinSach";
            gobThongTinSach.Size = new Size(596, 246);
            gobThongTinSach.TabIndex = 0;
            gobThongTinSach.TabStop = false;
            gobThongTinSach.Text = "Thông tin sách";
            // 
            // panel3
            // 
            panel3.Controls.Add(cboMaTheLoai);
            panel3.Controls.Add(nudSoLuong);
            panel3.Controls.Add(nudNamXB);
            panel3.Controls.Add(txtTenSach);
            panel3.Controls.Add(txtTacGia);
            panel3.Controls.Add(txtMaSach);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(3, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(487, 220);
            panel3.TabIndex = 6;
            // 
            // cboMaTheLoai
            // 
            cboMaTheLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaTheLoai.FormattingEnabled = true;
            cboMaTheLoai.Location = new Point(118, 184);
            cboMaTheLoai.Name = "cboMaTheLoai";
            cboMaTheLoai.Size = new Size(333, 28);
            cboMaTheLoai.TabIndex = 14;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(118, 150);
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(333, 27);
            nudSoLuong.TabIndex = 13;
            // 
            // nudNamXB
            // 
            nudNamXB.Location = new Point(118, 110);
            nudNamXB.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nudNamXB.Name = "nudNamXB";
            nudNamXB.Size = new Size(333, 27);
            nudNamXB.TabIndex = 12;
            nudNamXB.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(118, 41);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(333, 27);
            txtTenSach.TabIndex = 11;
            // 
            // txtTacGia
            // 
            txtTacGia.Location = new Point(118, 77);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(333, 27);
            txtTacGia.TabIndex = 7;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(118, 3);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(333, 27);
            txtMaSach.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(6, 187);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 5;
            label6.Text = "Mã thể loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(6, 10);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(6, 44);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(6, 80);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Tác giả:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(6, 115);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "Năm xuất bản:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(6, 152);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Số lượng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 288);
            panel2.Name = "panel2";
            panel2.Size = new Size(1086, 257);
            panel2.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblTongSo);
            groupBox4.Controls.Add(dgvDanhSachSach);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1086, 257);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách sách";
            // 
            // lblTongSo
            // 
            lblTongSo.AutoSize = true;
            lblTongSo.Location = new Point(6, 228);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(98, 20);
            lblTongSo.TabIndex = 12;
            lblTongSo.Text = "Tổng số sách:";
            // 
            // dgvDanhSachSach
            // 
            dgvDanhSachSach.BackgroundColor = SystemColors.ButtonFace;
            dgvDanhSachSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSach.Columns.AddRange(new DataGridViewColumn[] { MaSach, TenSach, TacGia, NamXuatBan, SoLuong, MaTheLoai });
            dgvDanhSachSach.Dock = DockStyle.Fill;
            dgvDanhSachSach.Location = new Point(3, 23);
            dgvDanhSachSach.Name = "dgvDanhSachSach";
            dgvDanhSachSach.RowHeadersWidth = 51;
            dgvDanhSachSach.Size = new Size(1080, 231);
            dgvDanhSachSach.TabIndex = 0;
            dgvDanhSachSach.CellClick += dgvDanhSachSach_CellClick;
            // 
            // MaSach
            // 
            MaSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSach.DataPropertyName = "MaSach";
            MaSach.HeaderText = "Mã sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            TenSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenSach.DataPropertyName = "TenSach";
            TenSach.HeaderText = "Tên sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            // 
            // TacGia
            // 
            TacGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TacGia.DataPropertyName = "TacGia";
            TacGia.HeaderText = "Tác giả";
            TacGia.MinimumWidth = 6;
            TacGia.Name = "TacGia";
            // 
            // NamXuatBan
            // 
            NamXuatBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NamXuatBan.DataPropertyName = "NamXuatBan";
            NamXuatBan.HeaderText = "Năm xuất bản";
            NamXuatBan.MinimumWidth = 6;
            NamXuatBan.Name = "NamXuatBan";
            // 
            // SoLuong
            // 
            SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // MaTheLoai
            // 
            MaTheLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaTheLoai.DataPropertyName = "MaTheLoai";
            MaTheLoai.HeaderText = "Mã Thể Loại";
            MaTheLoai.MinimumWidth = 6;
            MaTheLoai.Name = "MaTheLoai";
            // 
            // frmQuanLySach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 545);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLySach";
            Text = "frmQuanLySach";
            Load += frmQuanLySach_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gobThongTinSach.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNamXB).EndInit();
            panel2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox gobThongTinSach;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTenSach;
        private TextBox txtTacGia;
        private TextBox txtMaSach;
        private GroupBox groupBox3;
        private Panel panel4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox4;
        private DataGridView dgvDanhSachSach;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn NamXuatBan;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn MaTheLoai;
        private Label lblTongSo;
        private ComboBox cboMaTheLoai;
        private NumericUpDown nudSoLuong;
        private NumericUpDown nudNamXB;
    }
}