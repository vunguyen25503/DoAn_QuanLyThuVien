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
    public partial class ThongKeSach : Form
    {
        public ThongKeSach()
        {
            InitializeComponent();
        }
        Modify modify;
        private void lbSachMuonNhiueNhat_Click(object sender, EventArgs e)
        {
           
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            modify = new Modify();
            DataRow SachDuoMuonNhieuNhat = modify.GetMostBorrowedBook();

            if (SachDuoMuonNhieuNhat != null)
            {
                string bookInfo = $"Mã Sách: {SachDuoMuonNhieuNhat["MaSach"]}\n" +
                         $"Tên Sách: {SachDuoMuonNhieuNhat["TenSach"]}\n" +
                         $"Tác Giả: {SachDuoMuonNhieuNhat["TacGia"]}\n" +
                         $"Lượt Mượn: {SachDuoMuonNhieuNhat["LuotMuon"]}";
                lbSachMuonNhiueNhat.Text = bookInfo;
            }
            else
            {
                lbSachMuonNhiueNhat.Text = "Không có sách nào được mượn.";
            }
            DataRow SachDuocMuaNhieuNhat = modify.GetMostSoldBook();
            if(SachDuocMuaNhieuNhat != null)
            {
                string bookInfo1 = $"Mã Sách: {SachDuocMuaNhieuNhat["MaSach"]}\n" +
                        $"Tên Sách: {SachDuocMuaNhieuNhat["TenSach"]}\n" +
                        $"Tác Giả: {SachDuocMuaNhieuNhat["TacGia"]}\n" +
                        $"Lượt Mua: {SachDuocMuaNhieuNhat["LuotMua"]}";
                lbSachMuaNhieuNhat.Text = bookInfo1;
            }
            else
            {
                lbSachMuaNhieuNhat.Text = "Không có sách nào được mua.";
            }

            DataTable oldBooks = modify.GetOldBooks();

            if (oldBooks.Rows.Count > 0)
            {
                dataGridView2.DataSource = oldBooks;
            }
            else
            {
                MessageBox.Show("Không có sách nào có chất lượng cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ThongKeSach_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
