using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntiep_Click(object sender, EventArgs e)
        {
            txthesoa.Clear();
            txthesob.Clear();
            txtketqua.Clear();
            txtketqua.Focus();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            if (txthesoa.Text == "")
            {
                MessageBox.Show("Hệ số A không được rỗng, mời nhập lại", "Thông báo lỗi");
                txthesoa.Focus();
                return;
            }
            if (txthesob.Text == "")
            {
                MessageBox.Show("Hệ số B không được rỗng, mời nhập lại", "Thông báo lỗi");
                txthesob.Focus();
                return;
            }
            int hsA, hsB;
            string nghiem;
            if(int.TryParse(txthesoa.Text,out hsA) == false)
            {
                MessageBox.Show("Hệ số A không là kiểu số. Mời nhập lại","Báo lỗi kiểu dữ liệu",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txthesoa.Text = "";
                txthesoa.Focus();
                return;
            }
            if (int.TryParse(txthesob.Text, out hsB) == false)
            {
                MessageBox.Show("Hệ số B không là kiểu số. Mời nhập lại", "Báo lỗi kiểu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthesob.Text = "";
                txthesob.Focus();
                return;
            }
            if (hsA == 0)
                if (hsB == 0)
                    nghiem = "Phương trình vô định";
                else
                    nghiem = "Phương trình vô nghiệm";
            else
                nghiem = "Phương trình có nghiệm X = " + -(float)hsB / hsA;
            txtketqua.Text = nghiem;

        }
    }
}
