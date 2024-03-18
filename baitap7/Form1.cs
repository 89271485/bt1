using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap7
{
    public partial class Form1 : Form
    {
        List<LOPHOC> LOPHOCs;
        List<HOCVIEN> HOCVIENs;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopHoc.SelectedIndex == -1) return;
            string ml = cboLopHoc.SelectedValue.ToString();
            List<HOCVIEN> DsHocVienTheoLop = new List<HOCVIEN>();
            foreach (HOCVIEN hv in HOCVIENs)
                if (hv.MaLH == ml)
                    DsHocVienTheoLop.Add(hv);
            lstBang.DisplayMember = "HoTen";
            lstBang.ValueMember = "MaHV";
            lstBang.DataSource = DsHocVienTheoLop;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khoiTaoDuLieu();
            khoiTaoCombobox();
        }
        private void khoiTaoCombobox()
        {
            cboLopHoc.DisplayMember = "TenLH";
            cboLopHoc.ValueMember = "MaLH";
            cboLopHoc.DataSource = LOPHOCs;
        }
        private void khoiTaoDuLieu()
        {
            LOPHOCs = new List<LOPHOC>
            {
                new LOPHOC {MaLH="L01",TenLH="Lập trình Windows"},
                new LOPHOC {MaLH="L02",TenLH="Cở Sở Dữ Liệu"},
                new LOPHOC {MaLH="L03",TenLH="LT Hướng Đối Tượng"},
                new LOPHOC {MaLH="L04",TenLH="Tin Học"},
            };
            HOCVIENs = new List<HOCVIEN>
            {
                new HOCVIEN {MaHV=1,HoTen="Ngyễn Thị Hồng",Phai=false,Ngaysinh=new DateTime(200,1,1),DiaChi="252 Lý Chính THắng",MaLH="L01"},
                new HOCVIEN {MaHV=2,HoTen="Trần Văn Nguyễn",Phai=false,Ngaysinh=new DateTime(200,1,2),DiaChi="Trần Văn Đang",MaLH="L01"},
                new HOCVIEN {MaHV=3,HoTen="Lê Văn Nghĩa",Phai=false,Ngaysinh=new DateTime(200,1,3),DiaChi="!200 Trường Xa",MaLH="L01"},
                new HOCVIEN {MaHV=4,HoTen="Lý Vĩnh An",Phai=true,Ngaysinh=new DateTime(200,1,4),DiaChi="Lý Thường Kiệt",MaLH="L02"},
                new HOCVIEN {MaHV=5,HoTen="Tô Hồ Hải",Phai=true,Ngaysinh=new DateTime(200,1,5),DiaChi="2 Âu Duongtw Lãn",MaLH="L02"},
                new HOCVIEN {MaHV=6,HoTen="Phạm Thị Thu Duy",Phai=false,Ngaysinh=new DateTime(200,1,6),DiaChi="3 Trần Hưng Đạo",MaLH="L02"},
                new HOCVIEN {MaHV=7,HoTen="Nguyễn Văn Cường",Phai=true,Ngaysinh=new DateTime(200,1,7),DiaChi="4 Trần Văn Đang",MaLH="L03"},
                new HOCVIEN {MaHV=8,HoTen="Phạm Minh Thương",Phai=true,Ngaysinh=new DateTime(200,1,8),DiaChi="5 Cây Keo, .Bình Tân",MaLH="L03"},
                new HOCVIEN {MaHV=9,HoTen="Nguyễn Thị Thu Hà",Phai=false,Ngaysinh=new DateTime(200,1,9),DiaChi="6 Huỳnh Văn Bánh",MaLH="L04"},
                new HOCVIEN {MaHV=10,HoTen="Nguyễn Thuý Thanh Hằng",Phai=false,Ngaysinh=new DateTime(200,1,10),DiaChi="7 Hoàng Diệu, Q4",MaLH="L04"},
            };
        }

        private void lstBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Xét listbox chưa chọn
            if (lstBang.SelectedIndex == -1) return;
            HOCVIEN hv = lstBang.SelectedItem as HOCVIEN;
            txtMaHV.Text = hv.MaHV.ToString();
            txtHoten.Text = hv.HoTen;
            txtPhai.Text = hv.Phai == true ? "Nam" : "Nữ";
            txtNgaysinh.Text = hv.Ngaysinh.ToShortDateString();
            txtDiachi.Text = hv.DiaChi;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            //txtMaHV.Clear();
            //txtHoten.Clear();
            //txtPhai.Clear();
            //txtNgaysinh.Clear();
            //txtDiachi.Clear();
            foreach (Control ctl in this.GrbThongTin.Controls)
                if (ctl is TextBox)
                    (ctl as TextBox).Clear();
            txtMaHV.ReadOnly = false;
            txtMaHV.Focus();

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            HOCVIEN hv;
            if (!txtMaHV.ReadOnly) //Thêm mới học viên
            {
                hv = new HOCVIEN();
                if (txtMaHV.Text == "")
                {
                    ThongBaorong(txtMaHV, "Mã hoc viên");
                    return;
                }
                if (int.TryParse(txtMaHV.Text, out int rerult)== false)
                {
                    MessageBox.Show("Mã HV phải là giá trị số, nhập lại", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaHV.Clear();
                    txtMaHV.Focus();
                    return;
                }
                //hv.MaHV = int.parsrse(txtMaHV.text);
                hv.HoTen = txtHoten.Text;
                hv.Phai = txtPhai.Text.ToUpper() == "NAM" ? true : false;
                hv.DiaChi = txtDiachi.Text;
                hv.MaLH = cboLopHoc.SelectedValue.ToString();
                HOCVIENs.Add(hv);
                txtMaHV.ReadOnly = true;
            }
            else //Cập nhật thông tin cho nv
            {
                //Xử lý sau khi sửa thông tin học viên
                //Trước hết phải xác định được đối tuongj hv dagd sửa
                hv = lstBang.SelectedItem as HOCVIEN;
                hv.HoTen = txtHoten.Text;
                hv.Phai = txtPhai.Text.ToUpper() == "NAM" ? true : false;
                hv.DiaChi = txtDiachi.Text;
            }
            //Làm mới lại dữ liệu thêm hay sửa trên listbox
            comboBox1_SelectedIndexChanged(sender, e);
            //Đánh dấu chọn dòng mà ta mới thêm / sửa
            lstBang.SelectedIndex = lstBang.Items.IndexOf(hv);
            
        }
        private void ThongBaorong(TextBox CTL, string CauTB)
        {
            MessageBox.Show(CauTB + "không được bỏ trống. Mời nhập lại", "Trường CĐ GTVT. Lỗi nhập dữ liệu - Trống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CTL.Clear();
            CTL.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá học viên (y/n", "Xoá học viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                //Xoá thông tin học viên hiện hành trong nguồn dữ liệu
                //=> Làm mới lại dữ liệu
                //=>di chuyển phần tử được chọn trong listbox về phần tử đầu tiên
                HOCVIENs.Remove(lstBang.SelectedItem as HOCVIEN);
                comboBox1_SelectedIndexChanged(sender, e);
                lstBang.SelectedIndex = 0;
            }
        }

        private void txtMaHV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
