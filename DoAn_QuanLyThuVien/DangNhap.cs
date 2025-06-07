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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn_QuanLyThuVien
{
    public partial class DangNhap : Form
    {
        private bool passwordVisible = false;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxTenTK.TextAlign = HorizontalAlignment.Left;

        }

        private void linkLabel2QuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();

        }

        private void linkLabelDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void textBoxTenTK_Click(object sender, EventArgs e)
        {
            if(textBoxTenTK.Text == "Account" )
            {
                textBoxTenTK.Clear();
                
            }

               
        }

        private void textBoxMatKhau_Click(object sender, EventArgs e)
        {
            if(textBoxMatKhau.Text == "Password")
            {
                textBoxMatKhau.Clear();
            }
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string tenTK = textBoxTenTK.Text;
            string Matkhau = textBoxMatKhau.Text;
            if(tenTK.Trim() == "" )
            {
                MessageBox.Show("vui long nhap ten tai khoan ! ");
                return;
            }
            else if(Matkhau.Trim() == "" )
            {
                MessageBox.Show("vui long nhap mat khau ! ");
                return;
            }
            else
            {
                string query = " Select * from TaiKhoan where TenTaiKhoan = '" + tenTK + "' and MatKhau = '" + Matkhau + "'";
                TaiKhoan taiKhoans = modify.TaiKhoans(query);
                if (taiKhoans != null)
                {
                    if (taiKhoans.Admin)
                    {
                        MessageBox.Show("Đăng nhập thành công với quyền Admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Home home = new Home();
                        home.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công với quyền Độc Giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        homeforDocGia homeforDocGia = new homeforDocGia();
                        homeforDocGia.ShowDialog();
                        
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;

            textBoxMatKhau.PasswordChar = passwordVisible ? '\0' : '*';
        }

        private void textBoxMatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxMatKhau.PasswordChar = passwordVisible ? '\0' : '*';
        }
    }
}
