namespace QuanLyBanSach
{
    partial class frmMain
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.btnBanSach = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMenuTrangChu = new System.Windows.Forms.Button();
            this.btnMenuQuanLySach = new System.Windows.Forms.Button();
            this.btnMenuBanSach = new System.Windows.Forms.Button();
            this.btnMenuThongKe = new System.Windows.Forms.Button();
            this.btnMenuQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btnMenuDangXuat = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.BackColor = System.Drawing.Color.Navy;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTieuDe.Location = new System.Drawing.Point(206, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(606, 38);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "HỆ THỐNG QUẢN LÝ BÁN SÁCH GIÁO KHOA";
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.Color.Navy;
            this.lblXinChao.Location = new System.Drawing.Point(236, 98);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(124, 23);
            this.lblXinChao.TabIndex = 1;
            this.lblXinChao.Text = "Xin chào, bạn!";
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLySach.ForeColor = System.Drawing.Color.Navy;
            this.btnQuanLySach.Location = new System.Drawing.Point(311, 188);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Size = new System.Drawing.Size(159, 75);
            this.btnQuanLySach.TabIndex = 2;
            this.btnQuanLySach.Text = "QUẢN LÝ SÁCH";
            this.btnQuanLySach.UseVisualStyleBackColor = true;
            // 
            // btnBanSach
            // 
            this.btnBanSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanSach.ForeColor = System.Drawing.Color.Navy;
            this.btnBanSach.Location = new System.Drawing.Point(556, 188);
            this.btnBanSach.Name = "btnBanSach";
            this.btnBanSach.Size = new System.Drawing.Size(149, 75);
            this.btnBanSach.TabIndex = 3;
            this.btnBanSach.Text = "BÁN SÁCH";
            this.btnBanSach.UseVisualStyleBackColor = true;
            this.btnBanSach.Click += new System.EventHandler(this.btnBanSach_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Navy;
            this.btnThongKe.Location = new System.Drawing.Point(311, 345);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(159, 81);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Navy;
            this.btnDangXuat.Location = new System.Drawing.Point(556, 345);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(149, 81);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Navy;
            this.pnlMenu.Controls.Add(this.btnMenuDangXuat);
            this.pnlMenu.Controls.Add(this.btnMenuQuanLyTaiKhoan);
            this.pnlMenu.Controls.Add(this.btnMenuThongKe);
            this.pnlMenu.Controls.Add(this.btnMenuBanSach);
            this.pnlMenu.Controls.Add(this.btnMenuQuanLySach);
            this.pnlMenu.Controls.Add(this.btnMenuTrangChu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 521);
            this.pnlMenu.TabIndex = 6;
            // 
            // btnMenuTrangChu
            // 
            this.btnMenuTrangChu.BackColor = System.Drawing.Color.White;
            this.btnMenuTrangChu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuTrangChu.ForeColor = System.Drawing.Color.Navy;
            this.btnMenuTrangChu.Location = new System.Drawing.Point(24, 32);
            this.btnMenuTrangChu.Name = "btnMenuTrangChu";
            this.btnMenuTrangChu.Size = new System.Drawing.Size(159, 33);
            this.btnMenuTrangChu.TabIndex = 1;
            this.btnMenuTrangChu.Text = "TRANG CHỦ";
            this.btnMenuTrangChu.UseVisualStyleBackColor = false;
            // 
            // btnMenuQuanLySach
            // 
            this.btnMenuQuanLySach.BackColor = System.Drawing.Color.White;
            this.btnMenuQuanLySach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQuanLySach.ForeColor = System.Drawing.Color.Navy;
            this.btnMenuQuanLySach.Location = new System.Drawing.Point(24, 110);
            this.btnMenuQuanLySach.Name = "btnMenuQuanLySach";
            this.btnMenuQuanLySach.Size = new System.Drawing.Size(159, 35);
            this.btnMenuQuanLySach.TabIndex = 2;
            this.btnMenuQuanLySach.Text = "QUẢN LÝ SÁCH";
            this.btnMenuQuanLySach.UseVisualStyleBackColor = false;
            // 
            // btnMenuBanSach
            // 
            this.btnMenuBanSach.BackColor = System.Drawing.Color.White;
            this.btnMenuBanSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBanSach.ForeColor = System.Drawing.Color.Navy;
            this.btnMenuBanSach.Location = new System.Drawing.Point(24, 188);
            this.btnMenuBanSach.Name = "btnMenuBanSach";
            this.btnMenuBanSach.Size = new System.Drawing.Size(159, 34);
            this.btnMenuBanSach.TabIndex = 3;
            this.btnMenuBanSach.Text = "BÁN SÁCH";
            this.btnMenuBanSach.UseVisualStyleBackColor = false;
            // 
            // btnMenuThongKe
            // 
            this.btnMenuThongKe.BackColor = System.Drawing.Color.White;
            this.btnMenuThongKe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuThongKe.ForeColor = System.Drawing.Color.Navy;
            this.btnMenuThongKe.Location = new System.Drawing.Point(24, 268);
            this.btnMenuThongKe.Name = "btnMenuThongKe";
            this.btnMenuThongKe.Size = new System.Drawing.Size(159, 33);
            this.btnMenuThongKe.TabIndex = 4;
            this.btnMenuThongKe.Text = "THỐNG KÊ";
            this.btnMenuThongKe.UseVisualStyleBackColor = false;
            // 
            // btnMenuQuanLyTaiKhoan
            // 
            this.btnMenuQuanLyTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnMenuQuanLyTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuQuanLyTaiKhoan.ForeColor = System.Drawing.Color.Navy;
            this.btnMenuQuanLyTaiKhoan.Location = new System.Drawing.Point(24, 345);
            this.btnMenuQuanLyTaiKhoan.Name = "btnMenuQuanLyTaiKhoan";
            this.btnMenuQuanLyTaiKhoan.Size = new System.Drawing.Size(159, 41);
            this.btnMenuQuanLyTaiKhoan.TabIndex = 5;
            this.btnMenuQuanLyTaiKhoan.Text = "QUẢN LÝ TÀI KHOẢN";
            this.btnMenuQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btnMenuDangXuat
            // 
            this.btnMenuDangXuat.BackColor = System.Drawing.Color.White;
            this.btnMenuDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDangXuat.ForeColor = System.Drawing.Color.Navy;
            this.btnMenuDangXuat.Location = new System.Drawing.Point(24, 432);
            this.btnMenuDangXuat.Name = "btnMenuDangXuat";
            this.btnMenuDangXuat.Size = new System.Drawing.Size(159, 31);
            this.btnMenuDangXuat.TabIndex = 6;
            this.btnMenuDangXuat.Text = "ĐĂNG XUẤT";
            this.btnMenuDangXuat.UseVisualStyleBackColor = false;
            this.btnMenuDangXuat.Click += new System.EventHandler(this.btnMenuDangXuat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(819, 521);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnBanSach);
            this.Controls.Add(this.btnQuanLySach);
            this.Controls.Add(this.lblXinChao);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ BÁN SÁCH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblXinChao;
        private System.Windows.Forms.Button btnQuanLySach;
        private System.Windows.Forms.Button btnBanSach;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMenuQuanLySach;
        private System.Windows.Forms.Button btnMenuTrangChu;
        private System.Windows.Forms.Button btnMenuQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnMenuThongKe;
        private System.Windows.Forms.Button btnMenuBanSach;
        private System.Windows.Forms.Button btnMenuDangXuat;
    }
}