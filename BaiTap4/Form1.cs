using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapso_Click(object sender, EventArgs e)
        {
            if (txtSo.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá trị số cầ thêm vào LIstbox", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                khoi_tao_Textbox();
                return;
            }
            if(int.TryParse(txtSo.Text, out int rerult) == false)
            {
                MessageBox.Show("Bạn phải nhập giá trị số cầ thêm vào LIstbox", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                khoi_tao_Textbox();
                return;
            }
            lstSo.Items.Add(txtSo.Text);
            khoi_tao_Textbox();
        }
        private void khoi_tao_Textbox()
        {
            txtSo.Clear();
            txtSo.Focus();
        }
        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for(int i = 0;i<lstSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                tong += x;
            }
            MessageBox.Show("Tổng các số trong listbox là: " + tong);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lstSo.Items.Clear();
            lstSo.Items.Add(4);
            lstSo.Items.Add(6);
            lstSo.Items.Add(9);
            lstSo.Items.Add(3);
            lstSo.Items.Add(2);
            lstSo.Items.Add(1);



        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        }

        private void btnXoaPTchon_Click(object sender, EventArgs e)
        {
            if (lstSo.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa có dòng được chọn", "Thông báo chưa chọn");
                return;
            }
            //xoá phần tử được chọn trong listbox là phần tử selecteditem
            //xoá => Remove(SelectedItem) hoặc remonveAt(selectedindex)
            //cách 1;
            //lstSo.Items.Remove(lstSo.SelectedItem);
            //cách 2;
            lstSo.Items.Remove(lstSo.SelectedIndex);

        }

        private void btnTanglenhai_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách chưa có phần tử nào. Mời nhập danh sách");
                return;
            }
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                //lấy gia trị của phần tử thứ [i]
                int x = Convert.ToInt32(lstSo.Items[i]);
                lstSo.Items[i] = x + 2;
            }
        }

        private void btnSochan_Click(object sender, EventArgs e)
        {
            if(lstSo.Items.Count == 0)
            {
                MessageBox.Show("Danh sách chưa có phần tử nào. Mời nhập danh sách");
                return;

            }
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                if (x % 2 == 0)
                    lstSo.SelectedIndex = i;
            }
        }
    }
}
