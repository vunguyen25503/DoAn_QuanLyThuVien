using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyThuVien
{
     class ThongTinSoMuonTra
    {
       
        private string mamuonsach;
        private string masach;
        private string masinhvien;
        private string tensinhvien;
        private string tensach;
        private DateTime ngaymuon;
        private DateTime ngaytra;
        private string tinhtrangmuontra;

        public ThongTinSoMuonTra()
        {
        }

        public ThongTinSoMuonTra(string mamuonsach, string masach, string masinhvien, string tensinhvien, string tensach, DateTime ngaymuon, DateTime ngaytra, string tinhtrangmuontra)
        {
            this.Mamuonsach = mamuonsach;
            this.Masach = masach;
            this.Masinhvien = masinhvien;
            this.Tensinhvien = tensinhvien;
            this.Tensach = tensach;
            this.Ngaymuon = ngaymuon;
            this.Ngaytra = ngaytra;
            this.Tinhtrangmuontra = tinhtrangmuontra;
        }

        public string Mamuonsach { get => mamuonsach; set => mamuonsach = value; }
        public string Masach { get => masach; set => masach = value; }
        public string Masinhvien { get => masinhvien; set => masinhvien = value; }
        public string Tensinhvien { get => tensinhvien; set => tensinhvien = value; }
        public string Tensach { get => tensach; set => tensach = value; }
        public DateTime Ngaymuon { get => ngaymuon; set => ngaymuon = value; }
        public DateTime Ngaytra { get => ngaytra; set => ngaytra = value; }
        public string Tinhtrangmuontra { get => tinhtrangmuontra; set => tinhtrangmuontra = value; }
    }
}
