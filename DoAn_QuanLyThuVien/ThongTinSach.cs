using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyThuVien
{
    class ThongTinSach
    {
        private string masach;
        private string tensach;
        private string theloai;
        private string tacgia;
        private string nhaxuatban;
        private string namsanxuat;
        private string giatien;
        private string soluong;
        private string tinhtrang;
        private string chatluong;

        public ThongTinSach() { }

        public ThongTinSach(string masach, string tensach, string theloai, string tacgia, string nhaxuatban, string namsanxuat, string giatien, string soluong, string tinhtrang, string chatluong)
        {
            this.Masach = masach;
            this.Tensach = tensach;
            this.Theloai = theloai;
            this.Tacgia = tacgia;
            this.Nhaxuatban = nhaxuatban;
            this.Namsanxuat = namsanxuat;
            this.Giatien = giatien;
            this.Soluong = soluong;
            this.Tinhtrang = tinhtrang;
            this.Chatluong = chatluong;
        }

        public string Masach { get => masach; set => masach = value; }
        public string Tensach { get => tensach; set => tensach = value; }
        public string Theloai { get => theloai; set => theloai = value; }
        public string Tacgia { get => tacgia; set => tacgia = value; }
        public string Nhaxuatban { get => nhaxuatban; set => nhaxuatban = value; }
        public string Namsanxuat { get => namsanxuat; set => namsanxuat = value; }
        public string Giatien { get => giatien; set => giatien = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Chatluong { get => chatluong; set => chatluong = value; }
    }    
}
