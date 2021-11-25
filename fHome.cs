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
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

        private void fHome_Load(object sender, EventArgs e)
        {

        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                fDangNhap t = new fDangNhap();
                t.ShowDialog();
            }
        }
    }
}
