
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txbTongDoanhThu = new System.Windows.Forms.TextBox();
            this.lblLoiNhuan = new System.Windows.Forms.Label();
            this.txbLoiNhuan = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 9);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(696, 306);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(10, 325);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(114, 15);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "TỔNG DOANH THU:";
            // 
            // txbTongDoanhThu
            // 
            this.txbTongDoanhThu.BackColor = System.Drawing.SystemColors.Control;
            this.txbTongDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTongDoanhThu.Location = new System.Drawing.Point(141, 322);
            this.txbTongDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTongDoanhThu.Name = "txbTongDoanhThu";
            this.txbTongDoanhThu.Size = new System.Drawing.Size(189, 19);
            this.txbTongDoanhThu.TabIndex = 2;
            // 
            // lblLoiNhuan
            // 
            this.lblLoiNhuan.AutoSize = true;
            this.lblLoiNhuan.Location = new System.Drawing.Point(10, 353);
            this.lblLoiNhuan.Name = "lblLoiNhuan";
            this.lblLoiNhuan.Size = new System.Drawing.Size(74, 15);
            this.lblLoiNhuan.TabIndex = 3;
            this.lblLoiNhuan.Text = "LỢI NHUẬN:";
            // 
            // txbLoiNhuan
            // 
            this.txbLoiNhuan.BackColor = System.Drawing.SystemColors.Control;
            this.txbLoiNhuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLoiNhuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbLoiNhuan.Location = new System.Drawing.Point(141, 351);
            this.txbLoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLoiNhuan.Name = "txbLoiNhuan";
            this.txbLoiNhuan.Size = new System.Drawing.Size(189, 19);
            this.txbLoiNhuan.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(592, 346);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 22);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.bThoat_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(718, 386);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txbLoiNhuan);
            this.Controls.Add(this.lblLoiNhuan);
            this.Controls.Add(this.txbTongDoanhThu);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txbTongDoanhThu;
        private System.Windows.Forms.Label lblLoiNhuan;
        private System.Windows.Forms.TextBox txbLoiNhuan;
        private System.Windows.Forms.Button btnThoat;
    }
}