using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyThuVien
{
    public partial class BaoCaoDocGiaQuaHan : Form
    {
        public BaoCaoDocGiaQuaHan()
        {
            InitializeComponent();
        }
        Modify modify;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string MaMuonSach = txtTimkiem.Text.Trim();
            if (MaMuonSach == "")
            {
                MessageBox.Show("Vui lòng nhập mã mượn sách cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "SELECT * FROM SoMuonTra WHERE NgayTra < GETDATE() AND TinhTrangMuonTra like N'qua han' COLLATE SQL_Latin1_General_CP1_CI_AI AND MaMuonSach  LIKE N'%" + MaMuonSach + "%'";

            dataGridView1.DataSource = modify.Table(query);
        }

        private void BaoCaoDocGiaQuaHan_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.GetDocGiaQuaHan();

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btbQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
