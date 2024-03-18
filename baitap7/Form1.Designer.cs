
namespace baitap7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.lstBang = new System.Windows.Forms.ListBox();
            this.GrbThongTin = new System.Windows.Forms.GroupBox();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgaysinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GrbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HỌC VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn lớp";
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(147, 88);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(210, 27);
            this.cboLopHoc.TabIndex = 2;
            this.cboLopHoc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lstBang
            // 
            this.lstBang.FormattingEnabled = true;
            this.lstBang.ItemHeight = 19;
            this.lstBang.Location = new System.Drawing.Point(49, 138);
            this.lstBang.Name = "lstBang";
            this.lstBang.Size = new System.Drawing.Size(308, 346);
            this.lstBang.TabIndex = 3;
            this.lstBang.SelectedIndexChanged += new System.EventHandler(this.lstBang_SelectedIndexChanged);
            // 
            // GrbThongTin
            // 
            this.GrbThongTin.Controls.Add(this.btnTiep);
            this.GrbThongTin.Controls.Add(this.btnXoa);
            this.GrbThongTin.Controls.Add(this.btnCapnhat);
            this.GrbThongTin.Controls.Add(this.txtDiachi);
            this.GrbThongTin.Controls.Add(this.label7);
            this.GrbThongTin.Controls.Add(this.txtNgaysinh);
            this.GrbThongTin.Controls.Add(this.label6);
            this.GrbThongTin.Controls.Add(this.txtHoten);
            this.GrbThongTin.Controls.Add(this.label5);
            this.GrbThongTin.Controls.Add(this.txtPhai);
            this.GrbThongTin.Controls.Add(this.label4);
            this.GrbThongTin.Controls.Add(this.txtMaHV);
            this.GrbThongTin.Controls.Add(this.label3);
            this.GrbThongTin.Location = new System.Drawing.Point(387, 104);
            this.GrbThongTin.Name = "GrbThongTin";
            this.GrbThongTin.Size = new System.Drawing.Size(299, 379);
            this.GrbThongTin.TabIndex = 4;
            this.GrbThongTin.TabStop = false;
            this.GrbThongTin.Text = "Thông tin học viên";
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(209, 305);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(84, 27);
            this.btnTiep.TabIndex = 12;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(111, 305);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 27);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(13, 305);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(84, 27);
            this.btnCapnhat.TabIndex = 10;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(107, 216);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(186, 27);
            this.txtDiachi.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Địa chỉ";
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Location = new System.Drawing.Point(107, 173);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(186, 27);
            this.txtNgaysinh.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày sinh";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(107, 86);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(186, 27);
            this.txtHoten.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên HV";
            // 
            // txtPhai
            // 
            this.txtPhai.Location = new System.Drawing.Point(107, 128);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(186, 27);
            this.txtPhai.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(107, 44);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(186, 27);
            this.txtMaHV.TabIndex = 1;
            this.txtMaHV.TextChanged += new System.EventHandler(this.txtMaHV_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã HV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.GrbThongTin);
            this.Controls.Add(this.lstBang);
            this.Controls.Add(this.cboLopHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Danh sách học viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrbThongTin.ResumeLayout(false);
            this.GrbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.ListBox lstBang;
        private System.Windows.Forms.GroupBox GrbThongTin;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNgaysinh;
        private System.Windows.Forms.Label label6;
    }
}

