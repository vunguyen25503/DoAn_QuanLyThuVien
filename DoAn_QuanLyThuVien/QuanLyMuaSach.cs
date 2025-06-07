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
    public partial class QuanLyMuaSach : Form
    {
        public QuanLyMuaSach()
        {
            InitializeComponent();
        }
        Modify modify;
        private void QuanLyMuaSach_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getallBangMuaSach();

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string Magiaodich = txtTimkiem.Text.Trim();
            if (Magiaodich == "")
            {
                MessageBox.Show("Vui lòng nhập Mã Mượn sách cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "SELECT * FROM MuaSach WHERE MaGiaoDich  LIKE N'%" + Magiaodich + "%'COLLATE SQL_Latin1_General_CP1_CI_AI";

            dataGridView1.DataSource = modify.Table(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
