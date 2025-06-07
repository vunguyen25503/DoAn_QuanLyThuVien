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
    public partial class BangMuonSach : Form
    {
        public BangMuonSach()
        {
            InitializeComponent();
        }
        Modify modify;
        private void BangMuonSach_Load(object sender, EventArgs e)
        {
           modify = new Modify();
            try
            { 
                dataGridView1.DataSource = modify.getallSoMuonTra();

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string MaMuonSach = txtTimkiem.Text.Trim();
            if (MaMuonSach == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Mượn sách cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "SELECT * FROM SoMuonTra WHERE MaMuonSach  LIKE N'%" + MaMuonSach + "%'COLLATE SQL_Latin1_General_CP1_CI_AI";

            dataGridView1.DataSource = modify.Table(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
