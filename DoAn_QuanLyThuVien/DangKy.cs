using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;

namespace DoAn_QuanLyThuVien
{
    public partial class DangKy : Form
    {
        private bool passwordVisible = false;
        private Modify modify;
        
        public DangKy()
        {
            InitializeComponent();
            modify = new Modify();
           checkBoxAdmin.Visible = false;
        }
        public bool checkAccount(string acc)
        {
            return Regex.IsMatch(acc, "^[a-zA-Z0-9]{6,24}$");
        }
      
       public bool checkEmailSV(string ema)
        {
            return Regex.IsMatch(ema, @"^[a-zA-Z0-9_.]{3,20}@sv.uneti.edu.vn");
        }
        public bool checkEmailGV(string emai)
        {
            return Regex.IsMatch(emai, @"^[a-zA-Z0-9_.]{3,20}@gv.uneti.edu.vn");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTK.Text;
            string matkhau = txtMatKhau.Text;
            string xnmatkhau = txtXacNhanMK.Text;
            string email = txtEmail.Text;
            bool isadmin = checkBoxAdmin.Checked;
            if(!checkAccount(tentk))
            {
                MessageBox.Show("vui lòng nhập tên tài khoản dài 6 - 24 ký tự và số , chữ hoa ! ");
                return;
            }
            if (!checkAccount(matkhau))
            {
                MessageBox.Show("vui lòng nhập mật khẩu dài 6 - 24 ký tự và số , chữ hoa ! ");
                return;
            }
            if (xnmatkhau != matkhau)
            {
                MessageBox.Show("vui lòng nhập lại xác nhận mật khẩu chính xác ");
                return;

            }
            if(MessageBox.Show("Đăng ký tài khoản thành công! , Bạn có muốn đăng nhập luôn không ?","thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            
            if(modify.TaiKhoans("Select * from TaiKhoan where Email = '"+email+"'") != null )
            {
                MessageBox.Show("Email tồn tại , vui lòng nhập Email khác ");
                return;
            }
            if (checkEmailSV(email) || checkEmailGV(email))
            {
                bool success = modify.Dangky(tentk, matkhau,email, isadmin.ToString());

                if (success)
                {
                    MessageBox.Show("dang ky thanh cong");
                }
                else
                {
                    MessageBox.Show("dang ky that baai");

                }

            }
            else
                MessageBox.Show("email ko dung kieu");

        }

        private void txtTenTK_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text == "Account")
            {
                txtTenTK.Clear();
            }
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == "Password")
            {
                txtMatKhau.Clear();
            }
        }

        private void txtXacNhanMK_Click(object sender, EventArgs e)
        {
            if (txtXacNhanMK.Text == "Comfirm Password")
            {
                txtXacNhanMK.Clear();
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
            }
        }

        private void txtXacNhanMK_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật Khẩu")
            {
                txtMatKhau.Text = " ";
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_MouseClick(object sender, MouseEventArgs e)
        {

           
        }

        private void txtMatKhau_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtMatKhau.PasswordChar = passwordVisible ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;

            txtMatKhau.PasswordChar = passwordVisible ? '\0' : '*';
        }

        private void txtXacNhanMK_MouseClick(object sender, MouseEventArgs e)
        {
            txtXacNhanMK.PasswordChar = passwordVisible ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;

            txtXacNhanMK.PasswordChar = passwordVisible ? '\0' : '*';
        }

        private void txtTenTK_TextChanged(object sender, EventArgs e)
        {
           

            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btncheckemail_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if(checkEmailGV(email))
            {
               checkBoxAdmin.Visible = true;
               checkBoxAdmin.Checked = false;
            }
            else
            {
                checkBoxAdmin.Visible = false;
                checkBoxAdmin.Checked = false;
            }
        }
    }
 }

