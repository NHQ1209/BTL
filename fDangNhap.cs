using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQuanLyQuanCafe
{
    public partial class fDangNhap : Form
    {
        String tentaikhoan = "MinhThanhQuan";
        String pass = "12345";
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
        bool kiemtradangnhap(string tentaikhoan, string pass)
        {
            if (tentaikhoan == this.tentaikhoan && pass == this.pass)
            {
                return true;
            }
            else return false;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (kiemtradangnhap(txtTen.Text, txtMatkhau.Text))
            {
                fHome f = new fHome();
                f.ShowDialog();
                this.Hide();
            }
            else MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
            txtTen.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void fDangNhap_Load_1(object sender, EventArgs e)
        {

        }
    }
}
