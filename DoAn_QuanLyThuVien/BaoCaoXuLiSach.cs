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
    public partial class BaoCaoXuLiSach : Form
    {
        public BaoCaoXuLiSach()
        {
            InitializeComponent();
        }
        Modify modify;
        private void BaoCaoXuLiSach_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView2.DataSource = modify.getallBaoCao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string MaBaoCao = txtTimkiem.Text.Trim();
            if (MaBaoCao == "")
            {
                MessageBox.Show("Vui lòng nhập mã báo cáo cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "SELECT * FROM BaoCao WHERE  MaBaoCao  LIKE N'%" + MaBaoCao + "%'";

            dataGridView2.DataSource = modify.Table(query);
        }

        private void btbQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
