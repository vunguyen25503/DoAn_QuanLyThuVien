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
    public partial class DocGia : Form
    {
        public DocGia()
        {
            InitializeComponent();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            string id = this.txtma.Text;
            string ten = this.txtten.Text;
            DateTime ngaysinh = this.dateTimePicker1.Value;
            string gioitinh = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            string lop = this.txtlophoc.Text;
            string khoa = this.txtkhoaa.Text;
            string diachi = this.txtdiachii.Text;
            string email = this.txtemaill.Text;
            string sdt = this.txtsdt.Text;
            ThongTinDocGia thongTinDocGia = new ThongTinDocGia(id,ten,ngaysinh,gioitinh,lop,khoa,diachi,email,sdt);
            if(modify.insertSV(thongTinDocGia))
            {
                dataGridView1.DataSource = modify.getallSinhVien();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không thêm vào được","lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        Modify modify;
        DataTable dt = new DataTable();
        private void DocGia_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                var dt = modify.getallSinhVien();

                dataGridView1.DataSource = dt;

                dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                
            string id = this.txtma.Text;
            string ten = this.txtten.Text;
            DateTime ngaysinh = this.dateTimePicker1.Value;
            string gioitinh = (radioButton1.Checked ? radioButton1.Text : radioButton2.Text);
            string lop = this.txtlophoc.Text;
            string khoa = this.txtkhoaa.Text;
            string diachi = this.txtdiachii.Text;
            string email = this.txtemaill.Text;
            string sdt = this.txtsdt.Text;
            ThongTinDocGia thongTinDocGia = new ThongTinDocGia(id, ten, ngaysinh, gioitinh, lop, khoa, diachi, email, sdt);
            if (modify.updateSV(thongTinDocGia))
            {
                dataGridView1.DataSource = modify.getallSinhVien();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không sửa  được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if(modify.deleteSv(id))
            {
                dataGridView1.DataSource = modify.getallSinhVien();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không xoá được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string MaSV = txtTimkiem.Text.Trim();
            if(MaSV.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã Sinh viên cần tìm kiếm ","Thông báo ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            string query = "select * from SinhVien where MaSV like N'%" + MaSV + "%'COLLATE SQL_Latin1_General_CP1_CI_AI";
            dataGridView1.DataSource = modify.Table(query);
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectionrow = dataGridView1.SelectedRows[0];
                txtma.Text = selectionrow.Cells["MaSV"].Value.ToString();
                txtten.Text = selectionrow.Cells["HoTen"].Value.ToString();
                dateTimePicker1.Text = selectionrow.Cells["NgaySinh"].Value.ToString();
                string gioiTinh = selectionrow.Cells["GioiTinh"].Value.ToString().Trim().ToLower();
                if (gioiTinh == "nam")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else if (gioiTinh == "nữ")
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                txtlophoc.Text = selectionrow.Cells["Lop"].Value.ToString();
                txtkhoaa.Text = selectionrow.Cells["Khoa"].Value.ToString();
                txtdiachii.Text = selectionrow.Cells["DiaChi"].Value.ToString();
                txtemaill.Text = selectionrow.Cells["Email"].Value.ToString();
                txtsdt.Text = selectionrow.Cells["SDT"].Value.ToString();


            }

        }
    }
}
