
namespace baitap2
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
            this.tblhesoa = new System.Windows.Forms.Label();
            this.txthesoa = new System.Windows.Forms.TextBox();
            this.txthesob = new System.Windows.Forms.TextBox();
            this.tblhesob = new System.Windows.Forms.Label();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.tblketqua = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.btntiep = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(125, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬT NHẤT";
            // 
            // tblhesoa
            // 
            this.tblhesoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblhesoa.ForeColor = System.Drawing.Color.Red;
            this.tblhesoa.Location = new System.Drawing.Point(129, 108);
            this.tblhesoa.Name = "tblhesoa";
            this.tblhesoa.Size = new System.Drawing.Size(71, 17);
            this.tblhesoa.TabIndex = 1;
            this.tblhesoa.Text = "Hệ số a";
            // 
            // txthesoa
            // 
            this.txthesoa.ForeColor = System.Drawing.Color.Red;
            this.txthesoa.Location = new System.Drawing.Point(206, 108);
            this.txthesoa.Name = "txthesoa";
            this.txthesoa.Size = new System.Drawing.Size(350, 20);
            this.txthesoa.TabIndex = 2;
            this.txthesoa.Text = "2";
            // 
            // txthesob
            // 
            this.txthesob.ForeColor = System.Drawing.Color.Red;
            this.txthesob.Location = new System.Drawing.Point(206, 154);
            this.txthesob.Name = "txthesob";
            this.txthesob.Size = new System.Drawing.Size(350, 20);
            this.txthesob.TabIndex = 4;
            this.txthesob.Text = "-6";
            // 
            // tblhesob
            // 
            this.tblhesob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblhesob.ForeColor = System.Drawing.Color.Red;
            this.tblhesob.Location = new System.Drawing.Point(129, 154);
            this.tblhesob.Name = "tblhesob";
            this.tblhesob.Size = new System.Drawing.Size(71, 17);
            this.tblhesob.TabIndex = 3;
            this.tblhesob.Text = "Hệ số b";
            // 
            // txtketqua
            // 
            this.txtketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtketqua.ForeColor = System.Drawing.Color.Red;
            this.txtketqua.Location = new System.Drawing.Point(206, 222);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(350, 22);
            this.txtketqua.TabIndex = 6;
            this.txtketqua.Text = "Phương trình có nghiệm x = 3";
            // 
            // tblketqua
            // 
            this.tblketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblketqua.ForeColor = System.Drawing.Color.Red;
            this.tblketqua.Location = new System.Drawing.Point(129, 222);
            this.tblketqua.Name = "tblketqua";
            this.tblketqua.Size = new System.Drawing.Size(71, 17);
            this.tblketqua.TabIndex = 5;
            this.tblketqua.Text = "Kết quả";
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.ForeColor = System.Drawing.Color.Red;
            this.btntinh.Location = new System.Drawing.Point(132, 298);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(106, 46);
            this.btntinh.TabIndex = 7;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // btntiep
            // 
            this.btntiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntiep.ForeColor = System.Drawing.Color.Red;
            this.btntiep.Location = new System.Drawing.Point(303, 298);
            this.btntiep.Name = "btntiep";
            this.btntiep.Size = new System.Drawing.Size(106, 46);
            this.btntiep.TabIndex = 8;
            this.btntiep.Text = "Tiếp";
            this.btntiep.UseVisualStyleBackColor = true;
            this.btntiep.Click += new System.EventHandler(this.btntiep_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.Red;
            this.btnthoat.Location = new System.Drawing.Point(465, 298);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(106, 46);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 383);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntiep);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.tblketqua);
            this.Controls.Add(this.txthesob);
            this.Controls.Add(this.tblhesob);
            this.Controls.Add(this.txthesoa);
            this.Controls.Add(this.tblhesoa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tblhesoa;
        private System.Windows.Forms.TextBox txthesoa;
        private System.Windows.Forms.TextBox txthesob;
        private System.Windows.Forms.Label tblhesob;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label tblketqua;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Button btntiep;
        private System.Windows.Forms.Button btnthoat;
    }
}

