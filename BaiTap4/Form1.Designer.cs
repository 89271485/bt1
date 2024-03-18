
namespace BaiTap4
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnNhapso = new System.Windows.Forms.Button();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaPTchon = new System.Windows.Forms.Button();
            this.btnSochan = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnTanglenhai = new System.Windows.Forms.Button();
            this.btnbinhphuong = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(165, 71);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(325, 27);
            this.txtSo.TabIndex = 1;
            // 
            // btnNhapso
            // 
            this.btnNhapso.Location = new System.Drawing.Point(527, 63);
            this.btnNhapso.Name = "btnNhapso";
            this.btnNhapso.Size = new System.Drawing.Size(108, 40);
            this.btnNhapso.TabIndex = 2;
            this.btnNhapso.Text = "Nhập Số";
            this.btnNhapso.UseVisualStyleBackColor = true;
            this.btnNhapso.Click += new System.EventHandler(this.btnNhapso_Click);
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 19;
            this.lstSo.Location = new System.Drawing.Point(92, 130);
            this.lstSo.Name = "lstSo";
            this.lstSo.Size = new System.Drawing.Size(312, 327);
            this.lstSo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaPTchon);
            this.groupBox1.Controls.Add(this.btnSochan);
            this.groupBox1.Controls.Add(this.btnXoaDauCuoi);
            this.groupBox1.Controls.Add(this.btnTanglenhai);
            this.groupBox1.Controls.Add(this.btnbinhphuong);
            this.groupBox1.Controls.Add(this.btnTong);
            this.groupBox1.Location = new System.Drawing.Point(445, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 323);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng";
            // 
            // btnXoaPTchon
            // 
            this.btnXoaPTchon.Location = new System.Drawing.Point(26, 128);
            this.btnXoaPTchon.Name = "btnXoaPTchon";
            this.btnXoaPTchon.Size = new System.Drawing.Size(201, 40);
            this.btnXoaPTchon.TabIndex = 10;
            this.btnXoaPTchon.Text = "Xoá PT chọn";
            this.btnXoaPTchon.UseVisualStyleBackColor = true;
            this.btnXoaPTchon.Click += new System.EventHandler(this.btnXoaPTchon_Click);
            // 
            // btnSochan
            // 
            this.btnSochan.Location = new System.Drawing.Point(26, 281);
            this.btnSochan.Name = "btnSochan";
            this.btnSochan.Size = new System.Drawing.Size(201, 40);
            this.btnSochan.TabIndex = 7;
            this.btnSochan.Text = "Chọn các số chẳn";
            this.btnSochan.UseVisualStyleBackColor = true;
            this.btnSochan.Click += new System.EventHandler(this.btnSochan_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(26, 77);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(201, 40);
            this.btnXoaDauCuoi.TabIndex = 6;
            this.btnXoaDauCuoi.Text = "Xoá PT đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnTanglenhai
            // 
            this.btnTanglenhai.Location = new System.Drawing.Point(26, 230);
            this.btnTanglenhai.Name = "btnTanglenhai";
            this.btnTanglenhai.Size = new System.Drawing.Size(201, 40);
            this.btnTanglenhai.TabIndex = 9;
            this.btnTanglenhai.Text = "Tăng phần tử lên 2";
            this.btnTanglenhai.UseVisualStyleBackColor = true;
            this.btnTanglenhai.Click += new System.EventHandler(this.btnTanglenhai_Click);
            // 
            // btnbinhphuong
            // 
            this.btnbinhphuong.Location = new System.Drawing.Point(26, 179);
            this.btnbinhphuong.Name = "btnbinhphuong";
            this.btnbinhphuong.Size = new System.Drawing.Size(201, 40);
            this.btnbinhphuong.TabIndex = 8;
            this.btnbinhphuong.Text = "Thay bảng bình phương";
            this.btnbinhphuong.UseVisualStyleBackColor = true;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(26, 26);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(201, 40);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "Tổng các số";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(641, 63);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(60, 40);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(753, 483);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSo);
            this.Controls.Add(this.btnNhapso);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Xử Lý danh sách số";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnNhapso;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaPTchon;
        private System.Windows.Forms.Button btnSochan;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTanglenhai;
        private System.Windows.Forms.Button btnbinhphuong;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnLuu;
    }
}

