
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmViewTong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTong));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TaikhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CapnhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangxuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemsachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XoasachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuasachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LinhvucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoaisachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TacgiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemTGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaTGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuaTGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HoadonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhaxuatbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.txbTenNguoiDung = new System.Windows.Forms.TextBox();
            this.dgvSach = new System.Windows.Forms.ListView();
            this.lblDoanhthu = new System.Windows.Forms.Label();
            this.txbDoanhThu = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSoLuongKhach = new System.Windows.Forms.Label();
            this.txbSLKhach = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaikhoanToolStripMenuItem,
            this.SachToolStripMenuItem,
            this.LinhvucToolStripMenuItem,
            this.LoaisachToolStripMenuItem,
            this.TacgiaToolStripMenuItem,
            this.HoadonToolStripMenuItem,
            this.KhoToolStripMenuItem,
            this.NhaxuatbanToolStripMenuItem,
            this.ThongkeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TaikhoanToolStripMenuItem
            // 
            this.TaikhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CapnhapToolStripMenuItem,
            this.DangxuatToolStripMenuItem});
            this.TaikhoanToolStripMenuItem.Name = "TaikhoanToolStripMenuItem";
            this.TaikhoanToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.TaikhoanToolStripMenuItem.Text = "TÀI KHOẢN";
            // 
            // CapnhapToolStripMenuItem
            // 
            this.CapnhapToolStripMenuItem.Name = "CapnhapToolStripMenuItem";
            this.CapnhapToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.CapnhapToolStripMenuItem.Text = "CẬP NHẬT";
            this.CapnhapToolStripMenuItem.Click += new System.EventHandler(this.CapnhapToolStripMenuItem_Click);
            // 
            // DangxuatToolStripMenuItem
            // 
            this.DangxuatToolStripMenuItem.Name = "DangxuatToolStripMenuItem";
            this.DangxuatToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.DangxuatToolStripMenuItem.Text = "ĐĂNG XUẤT";
            this.DangxuatToolStripMenuItem.Click += new System.EventHandler(this.DangxuatToolStripMenuItem_Click);
            // 
            // SachToolStripMenuItem
            // 
            this.SachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemsachToolStripMenuItem,
            this.XoasachToolStripMenuItem,
            this.SuasachToolStripMenuItem});
            this.SachToolStripMenuItem.Name = "SachToolStripMenuItem";
            this.SachToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.SachToolStripMenuItem.Text = "SÁCH";
            // 
            // ThemsachToolStripMenuItem
            // 
            this.ThemsachToolStripMenuItem.Name = "ThemsachToolStripMenuItem";
            this.ThemsachToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ThemsachToolStripMenuItem.Text = "THÊM SÁCH";
            this.ThemsachToolStripMenuItem.Click += new System.EventHandler(this.ThemsachToolStripMenuItem_Click);
            // 
            // XoasachToolStripMenuItem
            // 
            this.XoasachToolStripMenuItem.Name = "XoasachToolStripMenuItem";
            this.XoasachToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.XoasachToolStripMenuItem.Text = "XÓA SÁCH";
            this.XoasachToolStripMenuItem.Click += new System.EventHandler(this.XoasachToolStripMenuItem_Click);
            // 
            // SuasachToolStripMenuItem
            // 
            this.SuasachToolStripMenuItem.Name = "SuasachToolStripMenuItem";
            this.SuasachToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.SuasachToolStripMenuItem.Text = "SỬA SÁCH";
            this.SuasachToolStripMenuItem.Click += new System.EventHandler(this.SuasachToolStripMenuItem_Click);
            // 
            // LinhvucToolStripMenuItem
            // 
            this.LinhvucToolStripMenuItem.Name = "LinhvucToolStripMenuItem";
            this.LinhvucToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.LinhvucToolStripMenuItem.Text = "LĨNH VỰC";
            this.LinhvucToolStripMenuItem.Click += new System.EventHandler(this.LinhvucToolStripMenuItem_Click);
            // 
            // LoaisachToolStripMenuItem
            // 
            this.LoaisachToolStripMenuItem.Name = "LoaisachToolStripMenuItem";
            this.LoaisachToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.LoaisachToolStripMenuItem.Text = "LOẠI SÁCH";
            this.LoaisachToolStripMenuItem.Click += new System.EventHandler(this.LoaisachToolStripMenuItem_Click);
            // 
            // TacgiaToolStripMenuItem
            // 
            this.TacgiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemTGToolStripMenuItem,
            this.XoaTGToolStripMenuItem,
            this.SuaTGToolStripMenuItem});
            this.TacgiaToolStripMenuItem.Name = "TacgiaToolStripMenuItem";
            this.TacgiaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.TacgiaToolStripMenuItem.Text = "TÁC GIẢ";
            // 
            // ThemTGToolStripMenuItem
            // 
            this.ThemTGToolStripMenuItem.Name = "ThemTGToolStripMenuItem";
            this.ThemTGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ThemTGToolStripMenuItem.Text = "THÊM TÁC GIẢ";
            this.ThemTGToolStripMenuItem.Click += new System.EventHandler(this.ThemTGToolStripMenuItem_Click);
            // 
            // XoaTGToolStripMenuItem
            // 
            this.XoaTGToolStripMenuItem.Name = "XoaTGToolStripMenuItem";
            this.XoaTGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.XoaTGToolStripMenuItem.Text = "XÓA TÁC GIẢ";
            this.XoaTGToolStripMenuItem.Click += new System.EventHandler(this.XoaTGToolStripMenuItem_Click);
            // 
            // SuaTGToolStripMenuItem
            // 
            this.SuaTGToolStripMenuItem.Name = "SuaTGToolStripMenuItem";
            this.SuaTGToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SuaTGToolStripMenuItem.Text = "SỬA TÁC GIẢ";
            this.SuaTGToolStripMenuItem.Click += new System.EventHandler(this.SuaTGToolStripMenuItem_Click);
            // 
            // HoadonToolStripMenuItem
            // 
            this.HoadonToolStripMenuItem.Name = "HoadonToolStripMenuItem";
            this.HoadonToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.HoadonToolStripMenuItem.Text = "HÓA ĐƠN";
            this.HoadonToolStripMenuItem.Click += new System.EventHandler(this.HoadonToolStripMenuItem_Click);
            // 
            // KhoToolStripMenuItem
            // 
            this.KhoToolStripMenuItem.Name = "KhoToolStripMenuItem";
            this.KhoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.KhoToolStripMenuItem.Text = "KHO";
            this.KhoToolStripMenuItem.Click += new System.EventHandler(this.KhoToolStripMenuItem_Click);
            // 
            // NhaxuatbanToolStripMenuItem
            // 
            this.NhaxuatbanToolStripMenuItem.Name = "NhaxuatbanToolStripMenuItem";
            this.NhaxuatbanToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.NhaxuatbanToolStripMenuItem.Text = "NHÀ XUẤT BẢN";
            this.NhaxuatbanToolStripMenuItem.Click += new System.EventHandler(this.NhaxuatbanToolStripMenuItem_Click);
            // 
            // ThongkeToolStripMenuItem
            // 
            this.ThongkeToolStripMenuItem.Name = "ThongkeToolStripMenuItem";
            this.ThongkeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.ThongkeToolStripMenuItem.Text = "THỐNG KÊ";
            this.ThongkeToolStripMenuItem.Click += new System.EventHandler(this.ThongkeToolStripMenuItem_Click);
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenNguoiDung.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(818, 26);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(86, 15);
            this.lblTenNguoiDung.TabIndex = 2;
            this.lblTenNguoiDung.Text = "NGƯỜI DÙNG:";
            // 
            // txbTenNguoiDung
            // 
            this.txbTenNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTenNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTenNguoiDung.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txbTenNguoiDung.Location = new System.Drawing.Point(920, 26);
            this.txbTenNguoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTenNguoiDung.Name = "txbTenNguoiDung";
            this.txbTenNguoiDung.ReadOnly = true;
            this.txbTenNguoiDung.Size = new System.Drawing.Size(96, 16);
            this.txbTenNguoiDung.TabIndex = 3;
            // 
            // dgvSach
            // 
            this.dgvSach.BackColor = System.Drawing.Color.White;
            this.dgvSach.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dgvSach.ForeColor = System.Drawing.Color.OrangeRed;
            this.dgvSach.HideSelection = false;
            this.dgvSach.Location = new System.Drawing.Point(10, 44);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(1053, 295);
            this.dgvSach.TabIndex = 1;
            this.dgvSach.UseCompatibleStateImageBehavior = false;
            // 
            // lblDoanhthu
            // 
            this.lblDoanhthu.AutoSize = true;
            this.lblDoanhthu.BackColor = System.Drawing.Color.Transparent;
            this.lblDoanhthu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDoanhthu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDoanhthu.Location = new System.Drawing.Point(10, 350);
            this.lblDoanhthu.Name = "lblDoanhthu";
            this.lblDoanhthu.Size = new System.Drawing.Size(158, 15);
            this.lblDoanhthu.TabIndex = 6;
            this.lblDoanhthu.Text = "DOANH THU TRONG NGÀY:";
            // 
            // txbDoanhThu
            // 
            this.txbDoanhThu.BackColor = System.Drawing.SystemColors.Control;
            this.txbDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbDoanhThu.Location = new System.Drawing.Point(206, 347);
            this.txbDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDoanhThu.Name = "txbDoanhThu";
            this.txbDoanhThu.Size = new System.Drawing.Size(230, 19);
            this.txbDoanhThu.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(836, 368);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(202, 15);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Thứ xxxx, ngày yy, tháng zz, năm tttt";
            // 
            // lblSoLuongKhach
            // 
            this.lblSoLuongKhach.AutoSize = true;
            this.lblSoLuongKhach.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuongKhach.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoLuongKhach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSoLuongKhach.Location = new System.Drawing.Point(12, 377);
            this.lblSoLuongKhach.Name = "lblSoLuongKhach";
            this.lblSoLuongKhach.Size = new System.Drawing.Size(113, 15);
            this.lblSoLuongKhach.TabIndex = 8;
            this.lblSoLuongKhach.Text = "SỐ LƯỢNG KHÁCH:";
            // 
            // txbSLKhach
            // 
            this.txbSLKhach.BackColor = System.Drawing.SystemColors.Control;
            this.txbSLKhach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSLKhach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSLKhach.Location = new System.Drawing.Point(206, 377);
            this.txbSLKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSLKhach.Name = "txbSLKhach";
            this.txbSLKhach.Size = new System.Drawing.Size(230, 19);
            this.txbSLKhach.TabIndex = 9;
            this.txbSLKhach.TextChanged += new System.EventHandler(this.txbSLKhach_TextChanged);
            // 
            // frmViewTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1074, 401);
            this.Controls.Add(this.txbSLKhach);
            this.Controls.Add(this.lblSoLuongKhach);
            this.Controls.Add(this.txbDoanhThu);
            this.Controls.Add(this.lblDoanhthu);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txbTenNguoiDung);
            this.Controls.Add(this.lblTenNguoiDung);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmViewTong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ CỬA HÀNG SÁCH";
            this.Load += new System.EventHandler(this.fViewTong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TaikhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LinhvucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoaisachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TacgiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HoadonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CapnhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangxuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemsachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XoasachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuasachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhaxuatbanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThongkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemTGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XoaTGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SuaTGToolStripMenuItem;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.TextBox txbTenNguoiDung;
        private System.Windows.Forms.ListView dgvSach;
        private System.Windows.Forms.Label lblDoanhthu;
        private System.Windows.Forms.TextBox txbDoanhThu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSoLuongKhach;
        private System.Windows.Forms.TextBox txbSLKhach;
    }
}