
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmSuaTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaTacGia));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaTacGia = new System.Windows.Forms.TextBox();
            this.lblMaTacGia = new System.Windows.Forms.Label();
            this.txbTenTacGia = new System.Windows.Forms.TextBox();
            this.chkQueQuan = new System.Windows.Forms.CheckBox();
            this.txbQueQuan = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.chkNgaySinh = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.chkNgayMat = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_NgayMat = new System.Windows.Forms.DateTimePicker();
            this.dgvTacGia = new System.Windows.Forms.ListView();
            this.btnChon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.txbMaTacGia);
            this.panel2.Controls.Add(this.lblMaTacGia);
            this.panel2.Location = new System.Drawing.Point(514, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 56);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(514, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÊN TÁC GIẢ:";
            // 
            // txbMaTacGia
            // 
            this.txbMaTacGia.Location = new System.Drawing.Point(127, 18);
            this.txbMaTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaTacGia.Name = "txbMaTacGia";
            this.txbMaTacGia.ReadOnly = true;
            this.txbMaTacGia.Size = new System.Drawing.Size(320, 23);
            this.txbMaTacGia.TabIndex = 2;
            // 
            // lblMaTacGia
            // 
            this.lblMaTacGia.AutoSize = true;
            this.lblMaTacGia.BackColor = System.Drawing.Color.Transparent;
            this.lblMaTacGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaTacGia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMaTacGia.Location = new System.Drawing.Point(3, 17);
            this.lblMaTacGia.Name = "lblMaTacGia";
            this.lblMaTacGia.Size = new System.Drawing.Size(104, 21);
            this.lblMaTacGia.TabIndex = 0;
            this.lblMaTacGia.Text = "MÃ TÁC GIẢ:";
            // 
            // txbTenTacGia
            // 
            this.txbTenTacGia.Location = new System.Drawing.Point(641, 64);
            this.txbTenTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTenTacGia.Name = "txbTenTacGia";
            this.txbTenTacGia.Size = new System.Drawing.Size(320, 23);
            this.txbTenTacGia.TabIndex = 1;
            // 
            // chkQueQuan
            // 
            this.chkQueQuan.AutoSize = true;
            this.chkQueQuan.BackColor = System.Drawing.Color.Transparent;
            this.chkQueQuan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkQueQuan.Location = new System.Drawing.Point(877, 106);
            this.chkQueQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkQueQuan.Name = "chkQueQuan";
            this.chkQueQuan.Size = new System.Drawing.Size(78, 19);
            this.chkQueQuan.TabIndex = 12;
            this.chkQueQuan.Text = "CHƯA RÕ";
            this.chkQueQuan.UseVisualStyleBackColor = false;
            this.chkQueQuan.CheckedChanged += new System.EventHandler(this.checkBox_QueQuan_CheckedChanged);
            // 
            // txbQueQuan
            // 
            this.txbQueQuan.Location = new System.Drawing.Point(641, 104);
            this.txbQueQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbQueQuan.Name = "txbQueQuan";
            this.txbQueQuan.Size = new System.Drawing.Size(210, 23);
            this.txbQueQuan.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(718, 220);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(243, 22);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.bbLuu_Click);
            // 
            // chkNgaySinh
            // 
            this.chkNgaySinh.AutoSize = true;
            this.chkNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.chkNgaySinh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkNgaySinh.Location = new System.Drawing.Point(877, 149);
            this.chkNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkNgaySinh.Name = "chkNgaySinh";
            this.chkNgaySinh.Size = new System.Drawing.Size(78, 19);
            this.chkNgaySinh.TabIndex = 10;
            this.chkNgaySinh.Text = "CHƯA RÕ";
            this.chkNgaySinh.UseVisualStyleBackColor = false;
            this.chkNgaySinh.CheckedChanged += new System.EventHandler(this.checkBox_NgaySinh_CheckedChanged);
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(641, 146);
            this.dateTimePicker_NgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(210, 23);
            this.dateTimePicker_NgaySinh.TabIndex = 9;
            // 
            // chkNgayMat
            // 
            this.chkNgayMat.AutoSize = true;
            this.chkNgayMat.BackColor = System.Drawing.Color.Transparent;
            this.chkNgayMat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkNgayMat.Location = new System.Drawing.Point(877, 189);
            this.chkNgayMat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkNgayMat.Name = "chkNgayMat";
            this.chkNgayMat.Size = new System.Drawing.Size(78, 19);
            this.chkNgayMat.TabIndex = 11;
            this.chkNgayMat.Text = "CHƯA RÕ";
            this.chkNgayMat.UseVisualStyleBackColor = false;
            this.chkNgayMat.CheckedChanged += new System.EventHandler(this.checkBox_NgayMat_CheckedChanged);
            // 
            // dateTimePicker_NgayMat
            // 
            this.dateTimePicker_NgayMat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayMat.Location = new System.Drawing.Point(641, 187);
            this.dateTimePicker_NgayMat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_NgayMat.Name = "dateTimePicker_NgayMat";
            this.dateTimePicker_NgayMat.Size = new System.Drawing.Size(210, 23);
            this.dateTimePicker_NgayMat.TabIndex = 9;
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.HideSelection = false;
            this.dgvTacGia.Location = new System.Drawing.Point(10, 9);
            this.dgvTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.Size = new System.Drawing.Size(494, 198);
            this.dgvTacGia.TabIndex = 17;
            this.dgvTacGia.UseCompatibleStateImageBehavior = false;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(10, 220);
            this.btnChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(114, 22);
            this.btnChon.TabIndex = 18;
            this.btnChon.Text = "CHỌN";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.bChon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(517, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "QUÊ QUÁN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(517, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "NGÀY SINH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(519, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "NGÀY MẤT:";
            // 
            // frmSuaTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(974, 248);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkNgayMat);
            this.Controls.Add(this.chkNgaySinh);
            this.Controls.Add(this.dateTimePicker_NgayMat);
            this.Controls.Add(this.chkQueQuan);
            this.Controls.Add(this.dateTimePicker_NgaySinh);
            this.Controls.Add(this.txbTenTacGia);
            this.Controls.Add(this.txbQueQuan);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.dgvTacGia);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSuaTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMaTacGia;
        private System.Windows.Forms.TextBox txbTenTacGia;
        private System.Windows.Forms.TextBox txbQueQuan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.CheckBox chkNgaySinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
        private System.Windows.Forms.CheckBox chkNgayMat;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayMat;
        private System.Windows.Forms.ListView dgvTacGia;
        private System.Windows.Forms.TextBox txbMaTacGia;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.CheckBox chkQueQuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}