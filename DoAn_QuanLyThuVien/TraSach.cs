using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyThuVien
{
    public partial class TraSach : Form
    {
        public TraSach()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            string MaMuonSach = txtMaMuonSach.Text;
            DateTime NgayTra = DateTime.Now;
            string TinhTrangMuonTra = "Đã Trả";

            int result = modify.ReturnBook(MaMuonSach, NgayTra,TinhTrangMuonTra);
            if (result > 0)
            {
                MessageBox.Show("Trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
               
            }
            else
            {
                MessageBox.Show("Trả sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
