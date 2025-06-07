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
    public partial class QuenMatKhau : Form
    {
        private bool passwordVisible = false;
        public QuenMatKhau()
        {
            InitializeComponent();
            
        }
        Modify modify = new Modify();
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\ADMIN_MSI;Initial Catalog=QLTV_Last;Integrated Security=True");
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tentk = txtacc.Text;
            string passcu = txtmkcu.Text;
            string passmoi = txtnewpass.Text;
            string xnpassmoi = txtxnmkmoi.Text;

            

           SqlDataAdapter cn = new SqlDataAdapter("Select count (*) from TaiKhoan where TenTaiKhoan = N'" + txtacc.Text + "'and MatKhau = N'" + txtmkcu.Text + "'", conn);
            DataTable dt = new DataTable();
            cn.Fill(dt);
           
            
            if (dt.Rows[0][0].ToString() == "1")
            {
                if(txtnewpass.Text == txtxnmkmoi.Text)
                {
                    SqlDataAdapter cn1 = new SqlDataAdapter("update TaiKhoan set MatKhau = N'" + txtnewpass.Text + "' where TenTaiKhoan = N'"+ txtacc.Text + "'and MatKhau = N'" + txtmkcu.Text + "'" , conn);
                    DataTable dt1 = new DataTable();
                    cn1.Fill(dt1);
                    errorProvider1.Clear();
                   if( MessageBox.Show("Đổi mật khẩu thành công !, Bạn có muốn quay trở lại đăng nhập không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                        this.Close();
                    }
                  
                }
                else
                {
                    errorProvider1.SetError(txtnewpass, "Vui lòng nhập mật khẩu mới");
                    errorProvider1.SetError(txtxnmkmoi, "Mật khẩu mới không trùng khớp");
                   
                }
            }
            else
            {
                errorProvider1.SetError(txtacc, "Tên tài khoản không chính xác");
                errorProvider1.SetError(txtmkcu, "Mật khẩu cũ Không chính xác");

                
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            
        }

        private void txtEmail1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtacc_Click(object sender, EventArgs e)
        {
            if(txtacc.Text == "Account") { txtacc.Clear(); }
        }

        private void txtmkcu_Click(object sender, EventArgs e)
        {
            if(txtmkcu.Text =="Current Password") {  txtmkcu.Clear(); }
        }

        private void txtnewpass_Click(object sender, EventArgs e)
        {
            if(txtnewpass.Text =="New Password") { txtnewpass.Clear(); }
        }

        private void txtxnmkmoi_Click(object sender, EventArgs e)
        {
            if( txtxnmkmoi.Text =="Comfirm Password") { txtxnmkmoi.Clear(); }
        }

        private void txtmkcu_MouseClick(object sender, MouseEventArgs e)
        {
            txtmkcu.PasswordChar = passwordVisible ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            txtmkcu.PasswordChar = passwordVisible ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            txtnewpass.PasswordChar = passwordVisible ? '\0' : '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            txtxnmkmoi.PasswordChar = passwordVisible ? '\0' : '*';
        }

        private void txtnewpass_MouseClick(object sender, MouseEventArgs e)
        {
            txtnewpass.PasswordChar = passwordVisible ? '\0' : '*';
        }

        private void txtxnmkmoi_MouseClick(object sender, MouseEventArgs e)
        {
            txtxnmkmoi.PasswordChar = passwordVisible ? '\0' : '*';
        }
    }
}
