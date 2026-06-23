namespace Quanlythuvien.GUI
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
            panel1 = new Panel();
            btnDangNhap = new Button();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTaiKhoan);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(195, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 450);
            panel1.TabIndex = 0;
            // 
            // btnDangNhap
            // 
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.ForeColor = Color.Blue;
            btnDangNhap.Location = new Point(111, 316);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(115, 37);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(62, 224);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(240, 34);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.Text = "Mật Khẩu";
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.AcceptsTab = true;
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Segoe UI", 12F);
            txtTaiKhoan.Location = new Point(62, 150);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(240, 34);
            txtTaiKhoan.TabIndex = 2;
            txtTaiKhoan.Text = "Tài Khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(79, 63);
            label1.Name = "label1";
            label1.Size = new Size(190, 46);
            label1.TabIndex = 1;
            label1.Text = "Đăng Nhập";
            label1.Click += label1_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "t";
            Paint += frmDangNhap_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Label label1;
        private Button btnDangNhap;
    }
}