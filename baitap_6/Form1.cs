using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtMonAn.Text == "")
            {
                MessageBox.Show("Bạn phải nhập món ăn cần thêm vào LÍtbox", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Them giá tri trong txtMonAn vào lístbox list thuc don
            lstThucDon.Items.Add(txtMonAn.Text);
            txtMonAn.Clear();
            txtMonAn.Focus();

        }

        private void btnLapLai_Click(object sender, EventArgs e)
        {
            lstThucDon.Items.Clear();
            lstThucDon.Items.Add("Cơm gà xối mỡ");
            lstThucDon.Items.Add("Bò xào củ hành");
            lstThucDon.Items.Add("hủ tiếu xào mực");
            lstThucDon.Items.Add("Canh chua cá lóc");
            lstThucDon.Items.Add("Cá lóc kho tộ");
            lstThucDon.Items.Add("Vịt quay tứ xuyên");
            lstThucDon.Items.Add("Heo quay");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstThucDon.SelectedIndex == -1)
                return;
            //kiểm tra chưa có dòng được chọn
          
            //Chức năng: Chuyển các phân tử được chọn trong ListThucDon sang Lstmonan
            //Luw ý:
            //1. Tập hợp các phần tử chọn trong listbox, là: selectedItems
            //2. Tổng số phân tử được chọn trong Listbox, là: selectedItems.count
            //Thuật toán:
            //B1. Thêm các phần tử được chọn trong listTHUCDON sang lstmonan
            for (int i = 0; i < lstThucDon.SelectedItems.Count; i++)
                lstMonAn.Items.Add(lstThucDon.SelectedItems[i]);
            //b2. Xoá các phần tử được chọn trong lstTHUCDON
            while (lstThucDon.SelectedItems.Count > 0)
                lstThucDon.Items.Remove(lstThucDon.SelectedItems[0]);
        }

        private void btnQuaAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstThucDon.Items.Count; i++)
                lstMonAn.Items.Add(lstThucDon.Items[i]);
            //. Xoá
            lstThucDon.Items.Clear();
        }

        private void btnTroLai1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i > lstThucDon.Items.Count; i++)
                lstMonAn.Items.Add(lstThucDon.Items[i]);
        }
    }
}
