
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txbMKMoi = new System.Windows.Forms.TextBox();
            this.txbMKMoiNhapLai = new System.Windows.Forms.TextBox();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new System.Windows.Forms.ListView();
            this.btnChon = new System.Windows.Forms.Button();
            this.txbMKHienTai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.txbTenDangNhap);
            this.panel2.Controls.Add(this.lblTenDangNhap);
            this.panel2.Location = new System.Drawing.Point(10, 122);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 56);
            this.panel2.TabIndex = 1;
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(209, 18);
            this.txbTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.ReadOnly = true;
            this.txbTenDangNhap.Size = new System.Drawing.Size(237, 23);
            this.txbTenDangNhap.TabIndex = 7;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenDangNhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTenDangNhap.Location = new System.Drawing.Point(3, 17);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(146, 21);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "TÊN ĐĂNG NHẬP:";
            this.lblTenDangNhap.Click += new System.EventHandler(this.lblTenDangNhap1_Click);
            // 
            // txbMKMoi
            // 
            this.txbMKMoi.Location = new System.Drawing.Point(220, 214);
            this.txbMKMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMKMoi.Name = "txbMKMoi";
            this.txbMKMoi.Size = new System.Drawing.Size(237, 23);
            this.txbMKMoi.TabIndex = 3;
            this.txbMKMoi.UseSystemPasswordChar = true;
            // 
            // txbMKMoiNhapLai
            // 
            this.txbMKMoiNhapLai.Location = new System.Drawing.Point(220, 250);
            this.txbMKMoiNhapLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMKMoiNhapLai.Name = "txbMKMoiNhapLai";
            this.txbMKMoiNhapLai.Size = new System.Drawing.Size(237, 23);
            this.txbMKMoiNhapLai.TabIndex = 4;
            this.txbMKMoiNhapLai.UseSystemPasswordChar = true;
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(110, 288);
            this.btnCapNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(242, 22);
            this.btnCapNhap.TabIndex = 5;
            this.btnCapNhap.Text = "CẬP NHẬT";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.bCapNhap_Click);
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.HideSelection = false;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(10, 9);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(447, 79);
            this.dgvTaiKhoan.TabIndex = 16;
            this.dgvTaiKhoan.UseCompatibleStateImageBehavior = false;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(10, 94);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(108, 22);
            this.btnChon.TabIndex = 17;
            this.btnChon.Text = "CHỌN";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.bChon_Click);
            // 
            // txbMKHienTai
            // 
            this.txbMKHienTai.Location = new System.Drawing.Point(220, 178);
            this.txbMKHienTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMKHienTai.Name = "txbMKHienTai";
            this.txbMKHienTai.Size = new System.Drawing.Size(237, 23);
            this.txbMKHienTai.TabIndex = 3;
            this.txbMKHienTai.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "MẬT KHẨU HIỆN TẠI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "MẬT KHẨU MỚI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(10, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "NHẬP LẠI:";
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(466, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMKHienTai);
            this.Controls.Add(this.txbMKMoiNhapLai);
            this.Controls.Add(this.txbMKMoi);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.btnCapNhap);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN TÀI KHOẢN";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txbMKMoi;
        private System.Windows.Forms.TextBox txbMKMoiNhapLai;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.ListView dgvTaiKhoan;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txbMKHienTai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}