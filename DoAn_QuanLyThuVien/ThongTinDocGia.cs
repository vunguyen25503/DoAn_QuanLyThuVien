using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyThuVien
{
    internal class ThongTinDocGia
    {
        private String maSV;
        private String hoTen;
        private DateTime ngaySinh;
        private String gioiTinh;
        private String lop;
        private String khoa;
        private String diaChi;
        private String email1;
        private String sDT1;

      

        public ThongTinDocGia()
        {
        }

        public ThongTinDocGia(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, string lop, string khoa, string diaChi, string email1, string sDT1)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.Lop = lop;
            this.Khoa = khoa;
            this.DiaChi = diaChi;
            this.Email1 = email1;
            this.SDT1 = sDT1;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Lop { get => lop; set => lop = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email1 { get => email1; set => email1 = value; }
        public string SDT1 { get => sDT1; set => sDT1 = value; }
    }
}
