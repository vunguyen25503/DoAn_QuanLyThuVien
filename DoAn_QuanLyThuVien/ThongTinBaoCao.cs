using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QuanLyThuVien
{
    internal class ThongTinBaoCao
    {
        private string mabaocao;
        private string masach;
        private string tensach;
        private string chatluong;
        private string soluong;
        private string bosung;
        private string huysach;

        public ThongTinBaoCao()
        {
        }

        public ThongTinBaoCao(string mabaocao, string masach, string tensach, string chatluong, string soluong, string bosung, string huysach)
        {
            this.Mabaocao = mabaocao;
            this.Masach = masach;
            this.Tensach = tensach;
            this.Chatluong = chatluong;
            this.Soluong = soluong;
            this.Bosung = bosung;
            this.Huysach = huysach;
        }

        public string Mabaocao { get => mabaocao; set => mabaocao = value; }
        public string Masach { get => masach; set => masach = value; }
        public string Tensach { get => tensach; set => tensach = value; }
        public string Chatluong { get => chatluong; set => chatluong = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Bosung { get => bosung; set => bosung = value; }
        public string Huysach { get => huysach; set => huysach = value; }
    }
}
