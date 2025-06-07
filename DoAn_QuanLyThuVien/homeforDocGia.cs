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
    public partial class homeforDocGia : Form
    {
        public homeforDocGia()
        {
            InitializeComponent();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeforDocGia_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuonSach muonSach = new MuonSach();
            muonSach.ShowDialog();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraSach traSach = new TraSach();
            traSach.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string rs = MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

            if (rs == DialogResult.Yes.ToString())
            {
                this.Close();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void muaSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuaSach muaSach = new MuaSach();
            muaSach.ShowDialog();
        }
    }
}
