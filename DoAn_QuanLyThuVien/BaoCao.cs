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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void txttimkiemsach_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Modify modify;

        private void BaoCao_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                var dt = modify.getallBaoCao();
                dataGridView2.DataSource = dt;
                dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mabaocao = this.txtmaBaoCao.Text;
            string masach = this.txtmasach.Text;
            string tensach = this.txttensach.Text;
            string chatluong = this.combChatLuong.SelectedItem.ToString();
            string soluong = this.txtsl.Text;
            string bosung = this.txtBoSung.Text;
            string huysach = this.txtHuySach.Text;

            ThongTinBaoCao thongTinBaoCao = new ThongTinBaoCao(mabaocao,masach,tensach,chatluong,soluong,bosung,huysach);
            if (modify.insertBaoCao(thongTinBaoCao))
            {
                dataGridView2.DataSource = modify.getallBaoCao();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không thêm vào được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBaoCao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mabaocao = this.txtmaBaoCao.Text;
            string masach = this.txtmasach.Text;
            string tensach = this.txttensach.Text;
            string chatluong = this.combChatLuong.SelectedItem.ToString();
            string soluong = this.txtsl.Text;
            string bosung = this.txtBoSung.Text;
            string huysach = this.txtHuySach.Text;

            ThongTinBaoCao thongTinBaoCao = new ThongTinBaoCao(mabaocao, masach, tensach, chatluong, soluong, bosung, huysach);
            if (modify.UpdateBaoCao(thongTinBaoCao))
            {
                dataGridView2.DataSource = modify.getallBaoCao();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không thêm vào được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            if (modify.deleteBaoCao(id))
            {
                dataGridView2.DataSource = modify.getallBaoCao();
            }
            else
            {
                MessageBox.Show("lỗi:" + "không xoá được", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

            string MaBaoCao = txttimkiemsach.Text.Trim();
            if (MaBaoCao.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã báo cáo cần tìm kiếm ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string query = "select * from BaoCao where MaBaoCao like N'%" + MaBaoCao + "%' COLLATE SQL_Latin1_General_CP1_CI_AI";
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
                var selectedrow = dataGridView2.SelectedRows[0];
                txtmaBaoCao.Text = selectedrow.Cells["MaBaoCao"].Value.ToString();
                txtmasach.Text = selectedrow.Cells["MaSach"].Value.ToString();
                txttensach.Text = selectedrow.Cells["TenSach"].Value.ToString();
                combChatLuong.Text = selectedrow.Cells["ChatLuong"].Value.ToString();
                txtsl.Text = selectedrow.Cells["SoLuong"].Value.ToString();
                txtBoSung.Text = selectedrow.Cells["BoSung"].Value.ToString();
                txtHuySach.Text = selectedrow.Cells["HuySach"].Value.ToString();
            }

        }
    }
}
