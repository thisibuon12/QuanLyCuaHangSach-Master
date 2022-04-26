
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dateTimePicker_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dateTimePicker_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.fThoat = new System.Windows.Forms.Button();
            this.btnXuatBC = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvThongKe = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTuNgay.Location = new System.Drawing.Point(3, 10);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(66, 19);
            this.lblTuNgay.TabIndex = 14;
            this.lblTuNgay.Text = "TỪ NGÀY";
            // 
            // dateTimePicker_TuNgay
            // 
            this.dateTimePicker_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_TuNgay.Location = new System.Drawing.Point(95, 8);
            this.dateTimePicker_TuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_TuNgay.Name = "dateTimePicker_TuNgay";
            this.dateTimePicker_TuNgay.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker_TuNgay.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTuNgay);
            this.panel1.Controls.Add(this.dateTimePicker_TuNgay);
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 36);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDenNgay);
            this.panel2.Controls.Add(this.dateTimePicker_DenNgay);
            this.panel2.Location = new System.Drawing.Point(402, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 36);
            this.panel2.TabIndex = 17;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDenNgay.Location = new System.Drawing.Point(2, 10);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(76, 19);
            this.lblDenNgay.TabIndex = 14;
            this.lblDenNgay.Text = "ĐẾN NGÀY";
            // 
            // dateTimePicker_DenNgay
            // 
            this.dateTimePicker_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DenNgay.Location = new System.Drawing.Point(95, 8);
            this.dateTimePicker_DenNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_DenNgay.Name = "dateTimePicker_DenNgay";
            this.dateTimePicker_DenNgay.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker_DenNgay.TabIndex = 15;
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(800, 365);
            this.fThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(106, 22);
            this.fThoat.TabIndex = 18;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // btnXuatBC
            // 
            this.btnXuatBC.Location = new System.Drawing.Point(10, 358);
            this.btnXuatBC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatBC.Name = "btnXuatBC";
            this.btnXuatBC.Size = new System.Drawing.Size(200, 36);
            this.btnXuatBC.TabIndex = 19;
            this.btnXuatBC.Text = "XUẤT BÁO CÁO";
            this.btnXuatBC.UseVisualStyleBackColor = true;
            this.btnXuatBC.Click += new System.EventHandler(this.bXuatBC_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(769, 9);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 29);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.bTimKiem_Click);
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.HideSelection = false;
            this.dgvThongKe.Location = new System.Drawing.Point(10, 50);
            this.dgvThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(896, 302);
            this.dgvThongKe.TabIndex = 21;
            this.dgvThongKe.UseCompatibleStateImageBehavior = false;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(918, 401);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXuatBC);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TuNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DenNgay;
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.Button btnXuatBC;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ListView dgvThongKe;
    }
}