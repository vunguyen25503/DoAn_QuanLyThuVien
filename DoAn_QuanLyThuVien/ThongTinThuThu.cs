using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyThuVien
{
     class ThongTinThuThu
    {
        private string mathuthu;
        private string tenthuthu;
        private string gioitinh;
        private DateTime ngaysinh;
        private string diachi;
        private string sdt;
        private string email;
        private DateTime ngaybatdaulam;
        private DateTime ngaynghiviec;
        private string trangthailamviec;
        private string khoa;

        public ThongTinThuThu()
        {
        }

        public ThongTinThuThu(string mathuthu, string tenthuthu, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string email, DateTime ngaybatdaulam, DateTime ngaynghiviec, string trangthailamviec, string khoa)
        {
            this.Mathuthu = mathuthu;
            this.Tenthuthu = tenthuthu;
            this.Gioitinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.Diachi = diachi;
            this.Sdt = sdt;
            this.Email = email;
            this.Ngaybatdaulam = ngaybatdaulam;
            this.Ngaynghiviec = ngaynghiviec;
            this.Trangthailamviec = trangthailamviec;
            this.Khoa = khoa;
        }

        public string Mathuthu { get => mathuthu; set => mathuthu = value; }
        public string Tenthuthu { get => tenthuthu; set => tenthuthu = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Ngaybatdaulam { get => ngaybatdaulam; set => ngaybatdaulam = value; }
        public DateTime Ngaynghiviec { get => ngaynghiviec; set => ngaynghiviec = value; }
        public string Trangthailamviec { get => trangthailamviec; set => trangthailamviec = value; }
        public string Khoa { get => khoa; set => khoa = value; }
    }
}
