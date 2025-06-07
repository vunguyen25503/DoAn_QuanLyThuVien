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
    public partial class ThongKeDocGia : Form
    {
        public ThongKeDocGia()
        {
            InitializeComponent();
        }
        Modify modify;

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            modify = new Modify();
            DataRow mostFrequentBorrower = modify.GetMostFrequentBorrower();

            if (mostFrequentBorrower != null)
            {
                string borrowerInfo = $"Mã Sinh Viên: {mostFrequentBorrower["MaSV"]}\n" +
                                      $"Tên Sinh Viên: {mostFrequentBorrower["HoTen"]}\n" +
                                      $"Lượt Mượn: {mostFrequentBorrower["LuotMuon"]}";
                lbDocGiaMuonNhieuNhat.Text = borrowerInfo;
            }
            else
            {
                lbDocGiaMuonNhieuNhat.Text = "Không có độc giả nào mượn !";
            }

            DataRow DocGiaMuaNhieuSachNhat = modify.GetTopBuyer();
            if(DocGiaMuaNhieuSachNhat !=null)
            {
                string TopBuyer = $"Mã Sinh Viên: {DocGiaMuaNhieuSachNhat["MaSV"]}\n" +
                                      $"Tên Sinh Viên: {DocGiaMuaNhieuSachNhat["HoTen"]}\n" +
                                      $"Lượt Mua: {DocGiaMuaNhieuSachNhat["TongSoLuong"]}";
                lbDocGiaMuaNhieuNhat.Text = TopBuyer;
            }
            else
            {
                lbDocGiaMuaNhieuNhat.Text = "Không có độc giả nào mua !";
            }

            try
            {
                dataGridView1.DataSource = modify.GetDocGiaQuaHan();

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi:" + ex.Message, "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
