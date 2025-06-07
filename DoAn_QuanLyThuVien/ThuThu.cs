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
    public partial class ThuThu : Form
    {
        public ThuThu()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mathuthu = this.txtMatt.Text;
            string tenthuthu = this.txtTentt.Text;
            string gioitinh = (this.radioNam.Checked ? radioNam.Text : radioNu.Text);
            DateTime ngaysinh = this.datetimepicngaysinh.Value;
            string diachi = this.txtDiachi.Text;
            string sdt = this.txtsdt.Text;
            string email = this.txtEmail.Text;
            DateTime ngaybatdau = this.dateTimePickerNgaybatdau.Value;
            DateTime ngaynghiviec = this.dateTimePickerngaynghi.Value;
            string trangthai = this.comTrangThai.SelectedItem.ToString();
            string khoa = this.txtKhoa.Text;

            ThongTinThuThu thongTinThuThu = new ThongTinThuThu(mathuthu,tenthuthu,gioitinh,ngaysinh,diachi,sdt,email,ngaybatdau,ngaynghiviec,trangthai,khoa);
            if(modify.insertThuThu(thongTinThuThu))
            {
                dataGridView1.DataSource = modify.getallThuThu();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không thêm vào được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        Modify modify;
        private void ThuThu_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                var dt = modify.getallThuThu();
                dataGridView1.DataSource = dt;
                dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mathuthu = this.txtMatt.Text;
            string tenthuthu = this.txtTentt.Text;
            string gioitinh = (this.radioNam.Checked ? radioNam.Text : radioNu.Text);
            DateTime ngaysinh = this.datetimepicngaysinh.Value;
            string diachi = this.txtDiachi.Text;
            string sdt = this.txtsdt.Text;
            string email = this.txtEmail.Text;
            DateTime ngaybatdau = this.dateTimePickerNgaybatdau.Value;
            DateTime ngaynghiviec = this.dateTimePickerngaynghi.Value;
            string trangthailamviec = this.comTrangThai.SelectedItem.ToString();
            string khoa = this.txtKhoa.Text;

            ThongTinThuThu thongTinThuThu = new ThongTinThuThu(mathuthu, tenthuthu, gioitinh, ngaysinh, diachi, sdt, email, ngaybatdau, ngaynghiviec, trangthailamviec, khoa);
            if (modify.updateThuThu(thongTinThuThu))
            {
                dataGridView1.DataSource = modify.getallThuThu();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không sửa vào được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.deleteThuThu(id))
            {
                dataGridView1.DataSource = modify.getallThuThu();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không xoá được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntimkiemm_Click(object sender, EventArgs e)
        {
            string MaThuThu =txttimkiem.Text.Trim();
            if (MaThuThu.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sách cần tìm kiếm ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string query = "select * from Sach where MaSach like '%" + MaThuThu + "%'";
            dataGridView1.DataSource = modify.Table(query);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                var selectedrow = dataGridView1.SelectedRows[0];
                txtMatt.Text = selectedrow.Cells["MaThuThu"].Value.ToString();
                txtTentt.Text = selectedrow.Cells["TenThuThu"].Value.ToString();
                string gioiTinh = selectedrow.Cells["GioiTinh"].Value.ToString().Trim().ToLower();
                if (gioiTinh == "nam")
                {
                    radioNam.Checked = true;
                   radioNu.Checked = false;
                }
                else if (gioiTinh == "nữ")
                {
                    radioNam.Checked = false;
                    radioNu.Checked = true;
                }
                datetimepicngaysinh.Text = selectedrow.Cells["NgaySinh"].Value.ToString();
                txtDiachi.Text = selectedrow.Cells["DiaChi"].Value.ToString();
                txtsdt.Text = selectedrow.Cells["SDT"].Value.ToString();
                txtEmail.Text = selectedrow.Cells["Email"].Value.ToString();
                dateTimePickerNgaybatdau.Text = selectedrow.Cells["NgayBatDauLam"].Value.ToString();
                dateTimePickerngaynghi.Text = selectedrow.Cells["NgayNghiViec"].Value.ToString();
                comTrangThai.Text = selectedrow.Cells["TrangThaiLamViec"].Value.ToString();
                txtKhoa.Text = selectedrow.Cells["Khoa"].Value.ToString();
            }
        }
    }
}
