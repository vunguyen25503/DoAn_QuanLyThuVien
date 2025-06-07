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
    public partial class MuonSach : Form
    {
        public MuonSach()
        {
            InitializeComponent();
        }
        Modify modify; 
        private void btnSua_Click(object sender, EventArgs e)
        {
        }

        private void MuonSach_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                var dt = modify.getallSach();
                dataGridView2.DataSource = dt;
                dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string TenSach = txtTimkiem.Text.Trim();
            if (TenSach.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Tên sách cần tìm kiếm ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
            string query = "SELECT * FROM Sach WHERE TenSach LIKE N'%" + TenSach + "%' COLLATE SQL_Latin1_General_CP1_CI_AI";
            dataGridView2.DataSource = modify.Table(query);

        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            string maMuonSach = modify.GetMaxBorrowId(); // Tạo mã mượn sách duy nhất
            string maSach = txtMaSach.Text.Trim();
            string maSinhVien = txtMaSinhVien.Text.Trim();
            string tenSinhVien = txtTenSV.Text.Trim();
            string tenSach = txtTenSach.Text.Trim();
            DateTime ngayMuon = DateTime.Now;
            DateTime ngayTra = ngayMuon.AddDays(30);
            string tinhtrangmuon = "Đang mượn";
            
            int result = modify.AddBorrowRecord(maMuonSach, maSach, maSinhVien, tenSinhVien, tenSach, ngayMuon, ngayTra, tinhtrangmuon);

            if (result > 0)
            {
                MessageBox.Show($"Mượn sách thành công!, Mã mượn sách của bạn là {maMuonSach}  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mượn sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                var selectedrow = dataGridView2.SelectedRows[0];
                txtMaSach.Text = selectedrow.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = selectedrow.Cells["TenSach"].Value.ToString();
            }
        }
    }
}
