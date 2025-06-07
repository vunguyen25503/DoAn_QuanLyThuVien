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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn có muốn đăng xuất  không ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
           

        }

        private void cậpNhậtĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocGia docGia = new DocGia();
            docGia.ShowDialog();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.ShowDialog();
        }

        private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thốngKêĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void cậpNhậtThủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoMuonTra soMuonTra = new SoMuonTra();
            soMuonTra.ShowDialog();
        }

        private void làmThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuThu thuThu = new ThuThu();
            thuThu.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậpNhậtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DocGia docGia = new DocGia();
            docGia.ShowDialog();
        }

        private void cậpNhậtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.ShowDialog();
        }

        private void cậpNhậtSổMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoMuonTra soMuonTra = new SoMuonTra();
            soMuonTra.ShowDialog();
        }

        private void cậpNhậtThủThưToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThuThu thuThu = new ThuThu();
            thuThu.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string rs = MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            
            if(rs == DialogResult.Yes.ToString())
            {
                this.Close();
            }
            
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BangMuonSach bangMuonSach = new BangMuonSach();
            bangMuonSach.ShowDialog();
        }

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeSach thongKeSach = new ThongKeSach();
            thongKeSach.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoXuLiSach baoCaoXuLiSach = new BaoCaoXuLiSach();
            baoCaoXuLiSach.ShowDialog();
        }

        private void báoCáoĐộcGiảQuáHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDocGiaQuaHan baoCaoDocGiaQuaHan = new BaoCaoDocGiaQuaHan();
            baoCaoDocGiaQuaHan.ShowDialog();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraSach traSach = new TraSach();
            traSach.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void muaSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMuaSach quanLyMuaSach = new QuanLyMuaSach();  
            quanLyMuaSach.ShowDialog();
        }

        private void thốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDocGia thongKeDocGia = new ThongKeDocGia();
            thongKeDocGia.ShowDialog();
        }

        private void cậpNhậtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCao baoCao = new BaoCao();
            baoCao.ShowDialog();
        }
    }
}
