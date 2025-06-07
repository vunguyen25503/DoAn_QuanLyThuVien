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
    public partial class MuaSach : Form
    {
        public MuaSach()
        {
            InitializeComponent();
        }
        Modify modify;
        private void btnMuon_Click(object sender, EventArgs e)
        {

            string magiaodich = modify.GetMaxMuaSachID(); // Tạo mã mượn sách duy nhất
            string maSach = txtMaSach.Text.Trim();
            string maSV = txtMaSinhVien.Text.Trim();
            string hoTen = txtTenSV.Text.Trim();
            string tenSach = txtTenSach.Text.Trim();
            DateTime ngayMua = DateTime.Now;

            int soLuong;
            try
            {
                soLuong = Convert.ToInt32(txtsl.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





            int result = modify.MuaSach(magiaodich, maSach, maSV, hoTen, tenSach, ngayMua, soLuong);
            if (result > 0)
            {
                MessageBox.Show($"Đặt sách thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mượn sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void MuaSach_Load(object sender, EventArgs e)
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

        private void txtGia_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnttinh_Click(object sender, EventArgs e)
        {


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var selectedrow = dataGridView2.SelectedRows[0];
                txtMaSach.Text = selectedrow.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = selectedrow.Cells["TenSach"].Value.ToString();
            }
        }
    }
}

