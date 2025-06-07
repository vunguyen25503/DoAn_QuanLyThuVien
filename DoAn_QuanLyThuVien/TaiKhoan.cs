using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyThuVien
{
    internal class TaiKhoan
    {
        private String tenTaiKhoan;
        private String MatKhau;
        private bool admin;

        public TaiKhoan()
        { }

        public TaiKhoan(string tenTaiKhoan, string matKhau, bool admin)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            MatKhau1 = matKhau;
            this.Admin = admin;
        }

        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public bool Admin { get => admin; set => admin = value; }
    }
}
