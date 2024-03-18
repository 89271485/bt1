
namespace baitap8
{
    partial class Form1
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnDangky = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GrbThongTin = new System.Windows.Forms.GroupBox();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.lstHocvien = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Location = new System.Drawing.Point(196, 259);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 27);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTiep
            // 
            this.btnTiep.ForeColor = System.Drawing.Color.Blue;
            this.btnTiep.Location = new System.Drawing.Point(106, 259);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(84, 27);
            this.btnTiep.TabIndex = 11;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            // 
            // btnDangky
            // 
            this.btnDangky.ForeColor = System.Drawing.Color.Blue;
            this.btnDangky.Location = new System.Drawing.Point(16, 259);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(84, 27);
            this.btnDangky.TabIndex = 10;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "1200000$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(21, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thành tiền";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(125, 86);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(186, 27);
            this.txtHoten.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(18, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên HV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(18, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lớp đăng ký";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(125, 44);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(186, 27);
            this.txtMaHV.TabIndex = 1;
            this.txtMaHV.TextChanged += new System.EventHandler(this.txtMaHV_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(18, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã HV";
            // 
            // GrbThongTin
            // 
            this.GrbThongTin.Controls.Add(this.btnThoat);
            this.GrbThongTin.Controls.Add(this.btnTiep);
            this.GrbThongTin.Controls.Add(this.cboLopHoc);
            this.GrbThongTin.Controls.Add(this.btnDangky);
            this.GrbThongTin.Controls.Add(this.label7);
            this.GrbThongTin.Controls.Add(this.label6);
            this.GrbThongTin.Controls.Add(this.txtHoten);
            this.GrbThongTin.Controls.Add(this.label5);
            this.GrbThongTin.Controls.Add(this.label4);
            this.GrbThongTin.Controls.Add(this.txtMaHV);
            this.GrbThongTin.Controls.Add(this.label3);
            this.GrbThongTin.Location = new System.Drawing.Point(350, 140);
            this.GrbThongTin.Name = "GrbThongTin";
            this.GrbThongTin.Size = new System.Drawing.Size(317, 345);
            this.GrbThongTin.TabIndex = 9;
            this.GrbThongTin.TabStop = false;
            this.GrbThongTin.Text = "Thông tin học viên";
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(125, 131);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(186, 27);
            this.cboLopHoc.TabIndex = 7;
            // 
            // lstHocvien
            // 
            this.lstHocvien.ForeColor = System.Drawing.Color.Blue;
            this.lstHocvien.FormattingEnabled = true;
            this.lstHocvien.ItemHeight = 19;
            this.lstHocvien.Location = new System.Drawing.Point(12, 140);
            this.lstHocvien.Name = "lstHocvien";
            this.lstHocvien.Size = new System.Drawing.Size(308, 346);
            this.lstHocvien.TabIndex = 8;
            this.lstHocvien.SelectedIndexChanged += new System.EventHandler(this.lstBang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(93, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 77);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH HỌC VIÊN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 492);
            this.Controls.Add(this.GrbThongTin);
            this.Controls.Add(this.lstHocvien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Danh sách học viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrbThongTin.ResumeLayout(false);
            this.GrbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GrbThongTin;
        private System.Windows.Forms.ListBox lstHocvien;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.Label label1;
    }
}

