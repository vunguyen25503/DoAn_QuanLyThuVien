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
    public partial class SoMuonTra : Form
    {
        public SoMuonTra()
        {
            InitializeComponent();
        }
        Modify modify;
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            string mamuonsach = this.txtMaMuonSach.Text;
            string masach = this.txtMaSach.Text;
            string masinhvien = this.txtMaSinhVien.Text;
            string tensinhvien = this.txtTenSV.Text;
            string tensach = this.txtTenSach.Text;
            DateTime ngaymuon = this.dateTimePicker1.Value;
            DateTime ngaytra = this.dateTimePicker2.Value;
            string tinhtrangmuon =this.comTinhTrang.SelectedItem.ToString();
            ThongTinSoMuonTra thongTinSoMuonTra = new ThongTinSoMuonTra(mamuonsach,masach,masinhvien,tensinhvien,tensach,ngaymuon,ngaytra,tinhtrangmuon);
            if (modify.insertSoMuonTra(thongTinSoMuonTra))
            {
                dataGridView1.DataSource = modify.getallSoMuonTra();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không thêm vào được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SoMuonTra_Load(object sender, EventArgs e)
        {
            modify = new Modify();

            try
            {
                var dt = modify.getallSoMuonTra();
                dataGridView1.DataSource= dt;
                dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
             
            string mamuonsach = this.txtMaMuonSach.Text;
            string masach = this.txtMaSach.Text;
            string masinhvien = this.txtMaSinhVien.Text;
            string tensinhvien = this.txtTenSV.Text;
            string tensach = this.txtTenSach.Text;
            DateTime ngaymuon = this.dateTimePicker1.Value;
            DateTime ngaytra = this.dateTimePicker2.Value;
            string tinhtrangmuon = this.comTinhTrang.SelectedItem.ToString();
            ThongTinSoMuonTra thongTinSoMuonTra = new ThongTinSoMuonTra( mamuonsach, masach, masinhvien, tensinhvien, tensach, ngaymuon, ngaytra,tinhtrangmuon);
            if (modify.updateSoMuonTra(thongTinSoMuonTra))
            {
                dataGridView1.DataSource = modify.getallSoMuonTra();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không thêm vào được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.deleteSoMuonTra(id))
            {
                dataGridView1.DataSource = modify.getallSoMuonTra();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không xoá được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string MaMuonSach = txtTimkiem.Text.Trim();
            if (MaMuonSach == "")
            {
                MessageBox.Show("Vui lòng nhập mã mượn sách cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "SELECT * FROM SoMuonTra WHERE MaMuonSach  LIKE N'%" + MaMuonSach + "%'COLLATE SQL_Latin1_General_CP1_CI_AI";

            dataGridView1.DataSource = modify.Table(query);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                txtMaMuonSach.Text = selectedRow.Cells["MaMuonSach"].Value.ToString();
                txtMaSach.Text = selectedRow.Cells["MaSach"].Value.ToString();
                txtMaSinhVien.Text = selectedRow.Cells["MaSV"].Value.ToString();
                txtTenSV.Text = selectedRow.Cells["HoTen"].Value.ToString();
                txtTenSach.Text = selectedRow.Cells["TenSach"].Value.ToString();
                dateTimePicker1.Text =selectedRow.Cells["NgayMuon"].Value.ToString();
                dateTimePicker2.Text = selectedRow.Cells["NgayTra"].Value.ToString();
                comTinhTrang.Text = selectedRow.Cells["TinhTrangMuonTra"].Value.ToString();


            }
        }
    }

 }

