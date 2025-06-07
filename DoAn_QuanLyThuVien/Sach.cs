using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyThuVien
{
    public partial class Sach : Form
    {
     
            
        public Sach()
        {
            InitializeComponent();
        }
        Modify modify;
        private void Sach_Load(object sender, EventArgs e)
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
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.deleteSach(id))
            {
                dataGridView2.DataSource = modify.getallSach();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không xoá được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masach = this.txtmasach.Text;
            string ten = this.txttensach.Text;
            string theloai = this.txttheloai.Text;
            string tacgia = this.txttacgia.Text;
            string nxb = txtnxb.Text;
            string namxb = this.txtnamsx.Text;
            string giatien = this.txtgia.Text;
            string soluong = this.txtsl.Text;
            string tinhtrang = this.comboBox1.SelectedItem.ToString();
            string chatluong = this.comboBox2.SelectedItem.ToString();
            
            ThongTinSach thongTinSach = new ThongTinSach(masach,ten,theloai,tacgia,nxb,namxb,giatien,soluong,tinhtrang,chatluong);
            if (modify.insertSach(thongTinSach))
            {
                dataGridView2.DataSource = modify.getallSach();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không thêm vào được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string masach = this.txtmasach.Text;
            string ten = this.txttensach.Text;
            string theloai = this.txttheloai.Text;
            string tacgia = this.txttacgia.Text;
            string nxb = txtnxb.Text;
            string namxb = this.txtnamsx.Text;
            string giatien = this.txtgia.Text;
            string soluong = this.txtsl.Text;
            string tinhtrang = this.comboBox1.SelectedItem.ToString();  
            string chatluong = this.comboBox2.SelectedItem.ToString();
            ThongTinSach thongTinSach = new ThongTinSach(masach, ten, theloai, tacgia, nxb, namxb, giatien, soluong, tinhtrang, chatluong);
            if (modify.updateSach(thongTinSach))
            {
                dataGridView2.DataSource = modify.getallSach();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không sua vào được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string MaSach = txttimkiemsach.Text.Trim();
            if (MaSach.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sách cần tìm kiếm ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string query = "select * from Sach where MaSach like N'%" + MaSach + "%' COLLATE SQL_Latin1_General_CP1_CI_AI";
            dataGridView2.DataSource = modify.Table(query);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView2.SelectedRows[0];
                txtmasach.Text = selectedRow.Cells["MaSach"].Value.ToString();
                txttensach.Text = selectedRow.Cells["TenSach"].Value.ToString();
                txttheloai.Text = selectedRow.Cells["TheLoai"].Value.ToString();
                txttacgia.Text = selectedRow.Cells["TacGia"].Value.ToString();
                txtnxb.Text = selectedRow.Cells["NhaXuatBan"].Value.ToString();
                txtnamsx.Text = selectedRow.Cells["NamXuatBan"].Value.ToString();
                txtgia.Text = selectedRow.Cells["GiaTien"].Value.ToString();
                txtsl.Text = selectedRow.Cells["SoLuong"].Value.ToString();

                comboBox1.Text = selectedRow.Cells["TinhTrang"].Value.ToString();
                comboBox2.Text = selectedRow.Cells["ChatLuong"].Value.ToString() ;


            }

        }
    }
}
