namespace Quanlythuvien.GUI
{
    partial class frmQuanLyTheLoai
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
            panel1 = new Panel();
            gboThongTinLoaiSach = new GroupBox();
            panel3 = new Panel();
            btnThem = new Button();
            txtTenTheLoai = new TextBox();
            txtMaTheLoai = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblTongSo = new Label();
            dgvTheLoai = new DataGridView();
            MaTheLoai = new DataGridViewTextBoxColumn();
            TenTheLoai = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            gboThongTinLoaiSach.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(gboThongTinLoaiSach);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(470, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 522);
            panel1.TabIndex = 0;
            // 
            // gboThongTinLoaiSach
            // 
            gboThongTinLoaiSach.Controls.Add(panel3);
            gboThongTinLoaiSach.Dock = DockStyle.Fill;
            gboThongTinLoaiSach.Location = new Point(0, 0);
            gboThongTinLoaiSach.Name = "gboThongTinLoaiSach";
            gboThongTinLoaiSach.Size = new Size(452, 522);
            gboThongTinLoaiSach.TabIndex = 0;
            gboThongTinLoaiSach.TabStop = false;
            gboThongTinLoaiSach.Text = "Thông tin loại sách";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(txtTenTheLoai);
            panel3.Controls.Add(txtMaTheLoai);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(24, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(401, 178);
            panel3.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.HotTrack;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(35, 126);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenTheLoai
            // 
            txtTenTheLoai.Location = new Point(148, 78);
            txtTenTheLoai.Name = "txtTenTheLoai";
            txtTenTheLoai.Size = new Size(218, 27);
            txtTenTheLoai.TabIndex = 2;
            // 
            // txtMaTheLoai
            // 
            txtMaTheLoai.Location = new Point(148, 30);
            txtMaTheLoai.Name = "txtMaTheLoai";
            txtMaTheLoai.Size = new Size(218, 27);
            txtMaTheLoai.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(272, 126);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Location = new Point(148, 126);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 85);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên thể loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 30);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã thể loại:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 522);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 522);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quản Lý Thể Loại";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTongSo);
            groupBox2.Controls.Add(dgvTheLoai);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(464, 480);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách thể loại";
            // 
            // lblTongSo
            // 
            lblTongSo.AutoSize = true;
            lblTongSo.ForeColor = Color.Black;
            lblTongSo.Location = new Point(9, 454);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(98, 20);
            lblTongSo.TabIndex = 0;
            lblTongSo.Text = "Tổng số loại :";
            // 
            // dgvTheLoai
            // 
            dgvTheLoai.BackgroundColor = SystemColors.Control;
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoai.Columns.AddRange(new DataGridViewColumn[] { MaTheLoai, TenTheLoai });
            dgvTheLoai.Dock = DockStyle.Fill;
            dgvTheLoai.Location = new Point(3, 23);
            dgvTheLoai.Name = "dgvTheLoai";
            dgvTheLoai.RowHeadersWidth = 51;
            dgvTheLoai.Size = new Size(458, 454);
            dgvTheLoai.TabIndex = 0;
            dgvTheLoai.CellClick += dgvTheLoai_CellClick;
            // 
            // MaTheLoai
            // 
            MaTheLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaTheLoai.DataPropertyName = "MaTheLoai";
            MaTheLoai.HeaderText = "Mã thể loại";
            MaTheLoai.MinimumWidth = 6;
            MaTheLoai.Name = "MaTheLoai";
            // 
            // TenTheLoai
            // 
            TenTheLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenTheLoai.DataPropertyName = "TenTheLoai";
            TenTheLoai.HeaderText = "Tên thể loại";
            TenTheLoai.MinimumWidth = 6;
            TenTheLoai.Name = "TenTheLoai";
            // 
            // frmQuanLyTheLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 522);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLyTheLoai";
            Text = "frmQuanLyTheLoai";
            Load += frmQuanLyTheLoai_Load;
            panel1.ResumeLayout(false);
            gboThongTinLoaiSach.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox gboThongTinLoaiSach;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvTheLoai;
        private DataGridViewTextBoxColumn ColMaTheLoai;
        private DataGridViewTextBoxColumn ColTenTheLoai;
        private Label lblTongSo;
        private Panel panel3;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtMaTheLoai;
        private TextBox txtTenTheLoai;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn MaTheLoai;
        private DataGridViewTextBoxColumn TenTheLoai;
    }
}