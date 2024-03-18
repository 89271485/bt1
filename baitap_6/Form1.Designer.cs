
namespace baitap_6
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
            this.lbt = new System.Windows.Forms.Label();
            this.txtMonAn = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstThucDon = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstMonAn = new System.Windows.Forms.ListBox();
            this.btnLapLai = new System.Windows.Forms.Button();
            this.btnQua1 = new System.Windows.Forms.Button();
            this.btnQuaAll = new System.Windows.Forms.Button();
            this.btnTroLai1 = new System.Windows.Forms.Button();
            this.btnTrolai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbt
            // 
            this.lbt.AutoSize = true;
            this.lbt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbt.ForeColor = System.Drawing.Color.White;
            this.lbt.Location = new System.Drawing.Point(12, 51);
            this.lbt.Name = "lbt";
            this.lbt.Size = new System.Drawing.Size(105, 19);
            this.lbt.TabIndex = 0;
            this.lbt.Text = "Nhập món ăn";
            // 
            // txtMonAn
            // 
            this.txtMonAn.Location = new System.Drawing.Point(123, 53);
            this.txtMonAn.Name = "txtMonAn";
            this.txtMonAn.Size = new System.Drawing.Size(318, 20);
            this.txtMonAn.TabIndex = 1;
            this.txtMonAn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.Red;
            this.btnNhap.Location = new System.Drawing.Point(472, 50);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(80, 34);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstThucDon);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 332);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thực đơn";
            // 
            // lstThucDon
            // 
            this.lstThucDon.FormattingEnabled = true;
            this.lstThucDon.ItemHeight = 19;
            this.lstThucDon.Location = new System.Drawing.Point(6, 26);
            this.lstThucDon.Name = "lstThucDon";
            this.lstThucDon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstThucDon.Size = new System.Drawing.Size(266, 289);
            this.lstThucDon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMonAn);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(343, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 332);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chọn món ăn";
            // 
            // lstMonAn
            // 
            this.lstMonAn.FormattingEnabled = true;
            this.lstMonAn.ItemHeight = 19;
            this.lstMonAn.Location = new System.Drawing.Point(6, 26);
            this.lstMonAn.Name = "lstMonAn";
            this.lstMonAn.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstMonAn.Size = new System.Drawing.Size(258, 289);
            this.lstMonAn.TabIndex = 0;
            // 
            // btnLapLai
            // 
            this.btnLapLai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapLai.Location = new System.Drawing.Point(579, 52);
            this.btnLapLai.Name = "btnLapLai";
            this.btnLapLai.Size = new System.Drawing.Size(60, 31);
            this.btnLapLai.TabIndex = 4;
            this.btnLapLai.Text = "Auto";
            this.btnLapLai.UseVisualStyleBackColor = true;
            this.btnLapLai.Click += new System.EventHandler(this.btnLapLai_Click);
            // 
            // btnQua1
            // 
            this.btnQua1.Location = new System.Drawing.Point(301, 172);
            this.btnQua1.Name = "btnQua1";
            this.btnQua1.Size = new System.Drawing.Size(36, 28);
            this.btnQua1.TabIndex = 5;
            this.btnQua1.Text = ">";
            this.btnQua1.UseVisualStyleBackColor = true;
            this.btnQua1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuaAll
            // 
            this.btnQuaAll.Location = new System.Drawing.Point(301, 230);
            this.btnQuaAll.Name = "btnQuaAll";
            this.btnQuaAll.Size = new System.Drawing.Size(36, 28);
            this.btnQuaAll.TabIndex = 6;
            this.btnQuaAll.Text = ">>";
            this.btnQuaAll.UseVisualStyleBackColor = true;
            this.btnQuaAll.Click += new System.EventHandler(this.btnQuaAll_Click);
            // 
            // btnTroLai1
            // 
            this.btnTroLai1.Location = new System.Drawing.Point(301, 281);
            this.btnTroLai1.Name = "btnTroLai1";
            this.btnTroLai1.Size = new System.Drawing.Size(36, 28);
            this.btnTroLai1.TabIndex = 7;
            this.btnTroLai1.Text = "<";
            this.btnTroLai1.UseVisualStyleBackColor = true;
            this.btnTroLai1.Click += new System.EventHandler(this.btnTroLai1_Click);
            // 
            // btnTrolai
            // 
            this.btnTrolai.Location = new System.Drawing.Point(301, 335);
            this.btnTrolai.Name = "btnTrolai";
            this.btnTrolai.Size = new System.Drawing.Size(36, 28);
            this.btnTrolai.TabIndex = 8;
            this.btnTrolai.Text = "<<";
            this.btnTrolai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrolai);
            this.Controls.Add(this.btnTroLai1);
            this.Controls.Add(this.btnQuaAll);
            this.Controls.Add(this.btnQua1);
            this.Controls.Add(this.btnLapLai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtMonAn);
            this.Controls.Add(this.lbt);
            this.Name = "Form1";
            this.Text = "Thưc đơn món ăn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbt;
        private System.Windows.Forms.TextBox txtMonAn;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLapLai;
        private System.Windows.Forms.ListBox lstThucDon;
        private System.Windows.Forms.ListBox lstMonAn;
        private System.Windows.Forms.Button btnQua1;
        private System.Windows.Forms.Button btnQuaAll;
        private System.Windows.Forms.Button btnTroLai1;
        private System.Windows.Forms.Button btnTrolai;
    }
}

