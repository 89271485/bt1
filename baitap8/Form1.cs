using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap8
{
    public partial class Form1 : Form
    {
        List<LOPHOC> LOPHOCs;
        List<HOCVIEN> HOCVIENs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khoiTaoDuLieu();
            khoiTaolisthocvien();
        }
        private void khoiTaolisthocvien()
        {
            lstHocvien.DisplayMember = "HoTen";
            lstHocvien.ValueMember = "MaLH";
            cboLopHoc.DataSource = LOPHOCs
        }
        private void khoiTaoDuLieu()
        {
            LOPHOCs = new List<LOPHOC>
            {
                new LOPHOC {MaLH="L01",TenLH="Lập trình Windows",HocPhi=1000000},
                new LOPHOC {MaLH="L02",TenLH="Cở Sở Dữ Liệu",HocPhi=2000000},
                new LOPHOC {MaLH="L03",TenLH="LT Hướng Đối Tượng",HocPhi=3000000},
                new LOPHOC {MaLH="L04",TenLH="Tin Học",HocPhi=4000000},
            };
            HOCVIENs = new List<HOCVIEN>
            {
                new HOCVIEN {MaHV=1,HoTen="Ngyễn Thị Hồng",MaLH="L01"},
                new HOCVIEN {MaHV=2,HoTen="Trần Văn Nguyễn",MaLH="L01"},
                new HOCVIEN {MaHV=3,HoTen="Lê Văn Nghĩa",MaLH="L01"},
                new HOCVIEN {MaHV=4,HoTen="Lý Vĩnh An",MaLH="L02"},
                new HOCVIEN {MaHV=5,HoTen="Tô Hồ Hải",MaLH="L02"},
                new HOCVIEN {MaHV=6,HoTen="Phạm Thị Thu Duy",MaLH="L02"},
                new HOCVIEN {MaHV=7,HoTen="Nguyễn Văn Cường",MaLH="L03"},
                new HOCVIEN {MaHV=8,HoTen="Phạm Minh Thương",MaLH="L03"},
                new HOCVIEN {MaHV=9,HoTen="Nguyễn Thị Thu Hà",MaLH="L04"},
                new HOCVIEN {MaHV=10,HoTen="Nguyễn Thuý Thanh Hằng",MaLH="L04"},
            };
        }
        

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHV_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstBang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
