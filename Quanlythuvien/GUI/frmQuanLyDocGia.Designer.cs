namespace Quanlythuvien.GUI
{
    partial class frmQuanLyDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDocGia));
            pnlHeader = new Panel();
            label1 = new Label();
            pnlInput = new Panel();
            groupBox1 = new GroupBox();
            pnlGrid = new Panel();
            panel3 = new Panel();
            btnTim = new Button();
            txtTuKhoa = new TextBox();
            cboTimKiem = new ComboBox();
            panel2 = new Panel();
            dtpNgayDangKy = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            txtMaDocGia = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            btnThem = new Button();
            btnXoa = new Button();
            pictureBox4 = new PictureBox();
            btnSua = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            dgvDocGia = new DataGridView();
            MaDocGia = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            NgayDangKy = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlInput.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlGrid.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.ControlLightLight;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(911, 85);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(273, 9);
            label1.Name = "label1";
            label1.Size = new Size(394, 67);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Đọc Giả";
            // 
            // pnlInput
            // 
            pnlInput.Controls.Add(groupBox1);
            pnlInput.Dock = DockStyle.Top;
            pnlInput.Location = new Point(0, 85);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(911, 209);
            pnlInput.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(pnlGrid);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(911, 209);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đọc giả";
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(panel3);
            pnlGrid.Controls.Add(panel2);
            pnlGrid.Controls.Add(panel1);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(3, 23);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(905, 183);
            pnlGrid.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(btnTim);
            panel3.Controls.Add(txtTuKhoa);
            panel3.Controls.Add(cboTimKiem);
            panel3.Location = new Point(584, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 186);
            panel3.TabIndex = 17;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(128, 255, 128);
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.ForeColor = Color.Black;
            btnTim.Location = new Point(204, 97);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(94, 29);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm kiếm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTimKiem_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(173, 19);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(125, 27);
            txtTuKhoa.TabIndex = 1;
            // 
            // cboTimKiem
            // 
            cboTimKiem.ForeColor = SystemColors.HotTrack;
            cboTimKiem.FormattingEnabled = true;
            cboTimKiem.Location = new Point(16, 18);
            cboTimKiem.Name = "cboTimKiem";
            cboTimKiem.Size = new Size(151, 28);
            cboTimKiem.TabIndex = 0;
            cboTimKiem.Text = "Họ tên";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpNgayDangKy);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtSoDienThoai);
            panel2.Controls.Add(txtHoTen);
            panel2.Controls.Add(txtMaDocGia);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(9, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 183);
            panel2.TabIndex = 16;
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Location = new Point(116, 138);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(250, 27);
            dtpNgayDangKy.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(9, 57);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(9, 16);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 7;
            label2.Text = "Mã đọc giả:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(125, 97);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(125, 27);
            txtSoDienThoai.TabIndex = 12;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(125, 57);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 13;
            // 
            // txtMaDocGia
            // 
            txtMaDocGia.Location = new Point(125, 16);
            txtMaDocGia.Name = "txtMaDocGia";
            txtMaDocGia.Size = new Size(125, 27);
            txtMaDocGia.TabIndex = 14;
            txtMaDocGia.TextChanged += txtMaDocGia_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(9, 97);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 9;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(9, 138);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 10;
            label5.Text = "Ngày đăng ký:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(410, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 183);
            panel1.TabIndex = 15;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Highlight;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(62, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 32);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(62, 134);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.HotTrack;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(15, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(62, 75);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Red;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 134);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // dgvDocGia
            // 
            dgvDocGia.BackgroundColor = SystemColors.ControlLightLight;
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocGia.Columns.AddRange(new DataGridViewColumn[] { MaDocGia, HoTen, SoDienThoai, NgayDangKy });
            dgvDocGia.Dock = DockStyle.Fill;
            dgvDocGia.Location = new Point(0, 294);
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.ReadOnly = true;
            dgvDocGia.RowHeadersWidth = 51;
            dgvDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocGia.Size = new Size(911, 293);
            dgvDocGia.TabIndex = 2;
            dgvDocGia.CellClick += dgvDocGia_CellClick;
            // 
            // MaDocGia
            // 
            MaDocGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaDocGia.DataPropertyName = "MaDocGia";
            MaDocGia.HeaderText = "Mã đọc giã";
            MaDocGia.MinimumWidth = 6;
            MaDocGia.Name = "MaDocGia";
            MaDocGia.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // NgayDangKy
            // 
            NgayDangKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgayDangKy.DataPropertyName = "NgayDangKy";
            NgayDangKy.HeaderText = "Ngày đăng ký";
            NgayDangKy.MinimumWidth = 6;
            NgayDangKy.Name = "NgayDangKy";
            NgayDangKy.ReadOnly = true;
            // 
            // frmQuanLyDocGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 587);
            Controls.Add(dgvDocGia);
            Controls.Add(pnlInput);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLyDocGia";
            Text = "frmQuanLyDocGia";
            Load += frmQuanLyDocGia_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlInput.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            pnlGrid.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Panel pnlInput;
        private GroupBox groupBox1;
        private Panel pnlGrid;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private DataGridView dgvDocGia;
        private TextBox txtMaDocGia;
        private TextBox txtHoTen;
        private TextBox txtSoDienThoai;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private TextBox btnTimKiem;
        private TextBox txtTuKhoa;
        private ComboBox cboTimKiem;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpNgayDangKy;
        private Button btnTim;
        private DataGridViewTextBoxColumn MaDocGia;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn NgayDangKy;
    }
}