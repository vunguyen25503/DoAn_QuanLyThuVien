using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace DoAn_QuanLyThuVien
{
      class Modify
    {
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand; //dung de truy van cac lenh  , vi du nhu update , delete , insert ...
        public Modify() { }

        
        SqlDataReader dataReader; //dung de doc du lieu trong bang
        public TaiKhoan TaiKhoans(string query)
        {
            TaiKhoan taiKhoan = null;
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);

                dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    string tenTaiKhoan = dataReader.GetString(0);
                    string matKhau = dataReader.GetString(1);
                    bool isAdminString = dataReader.GetBoolean(3);

                    // bool isAdmin;
                    // bool.TryParse(isAdminString, out isAdmin);

                    taiKhoan = new TaiKhoan(tenTaiKhoan,matKhau,isAdminString);
                }
                dataReader.Close();
                sqlConnection.Close();
            }
            return taiKhoan;
        }
        public bool Dangky(string TenTaiKhoan, string MatKhau,string email, string isadmin) //dang ky tai khoan
        {
                using(SqlConnection sqlConnection = connection.GetSqlConnection())
            {

               
                string query = "insert into TaiKhoan (TenTaiKhoan,MatKhau,Email,Admin) values (@TenTaiKhoan,@MatKhau,@Email,@Admin)";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", TenTaiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Admin", isadmin);

                    try
                    {
                        sqlConnection.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine("lỗi:" + ex.Message);
                        return false;
                    }
                }
                sqlCommand = new SqlCommand (query, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }
        public DataTable Table(string query)
        {
            DataTable dt = new DataTable();
            using(SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open ();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public DataTable getallSinhVien()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from SinhVien";
            using (SqlConnection sqlConnection =connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insertSV(ThongTinDocGia thongTinDocGia)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "insert into SinhVien values (@MaSV,@Hoten,@NgaySinh,@GioiTinh,@Lop,@Khoa,@DiaChi,@Email,@SDT)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = thongTinDocGia.MaSV;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = thongTinDocGia.HoTen;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = thongTinDocGia.NgaySinh.ToShortDateString();
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = thongTinDocGia.GioiTinh;
                sqlCommand.Parameters.Add("@Lop", SqlDbType.NVarChar).Value = thongTinDocGia.Lop;
                sqlCommand.Parameters.Add("@Khoa", SqlDbType.NVarChar).Value = thongTinDocGia.Khoa;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = thongTinDocGia.DiaChi;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = thongTinDocGia.Email1;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = thongTinDocGia.SDT1;
                sqlCommand.ExecuteNonQuery();

            }
            catch 
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool updateSV(ThongTinDocGia thongTinDocGia)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "update SinhVien set Hoten= @Hoten,NgaySinh = @NgaySinh,GioiTinh = @GioiTinh,Lop = @Lop, Khoa = @Khoa,DiaChi = @DiaChi, Email = @Email, SDT = @SDT Where MaSV = @MaSV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = thongTinDocGia.MaSV;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = thongTinDocGia.HoTen;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = thongTinDocGia.NgaySinh.ToShortDateString();
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = thongTinDocGia.GioiTinh;
                sqlCommand.Parameters.Add("@Lop", SqlDbType.NVarChar).Value = thongTinDocGia.Lop;
                sqlCommand.Parameters.Add("@Khoa", SqlDbType.NVarChar).Value = thongTinDocGia.Khoa;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = thongTinDocGia.DiaChi;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = thongTinDocGia.Email1;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = thongTinDocGia.SDT1;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool deleteSv(string ma)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "delete SinhVien Where MaSV = @MaSV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = ma;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public DataTable getallSach()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from Sach ";
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insertSach(ThongTinSach thongTinSach)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "insert into Sach values (@MaSach,@TenSach,@Theloai,@TacGia,@NhaXuatBan,@NamXuatBan,@GiaTien,@SoLuong,@TinhTrang,@ChatLuong)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaSach", SqlDbType.Int).Value = thongTinSach.Masach;
                sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = thongTinSach.Tensach;
                sqlCommand.Parameters.Add("@Theloai", SqlDbType.NVarChar).Value = thongTinSach.Theloai;
                sqlCommand.Parameters.Add("@TacGia", SqlDbType.NVarChar).Value = thongTinSach.Tacgia;
                sqlCommand.Parameters.Add("@NhaXuatBan", SqlDbType.NVarChar).Value = thongTinSach.Nhaxuatban;
                sqlCommand.Parameters.Add("@NamXuatBan", SqlDbType.Int).Value = thongTinSach.Namsanxuat;
                sqlCommand.Parameters.Add("@GiaTien", SqlDbType.Decimal).Value = thongTinSach.Giatien;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = thongTinSach.Soluong;
                sqlCommand.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = thongTinSach.Tinhtrang;
                sqlCommand.Parameters.Add("@ChatLuong", SqlDbType.NVarChar).Value = thongTinSach.Chatluong;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool updateSach(ThongTinSach thongTinSach)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "update Sach set TenSach = @TenSach, Theloai = @Theloai, TacGia = @TacGia, NhaXuatBan = @NhaXuatBan, NamXuatBan = @NamXuatBan, GiaTien = @GiaTien, SoLuong = @SoLuong, TinhTrang = @TinhTrang, ChatLuong = @ChatLuong where MaSach = @MaSach";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = thongTinSach.Masach;
                sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = thongTinSach.Tensach;
                sqlCommand.Parameters.Add("@Theloai", SqlDbType.NVarChar).Value = thongTinSach.Theloai;
                sqlCommand.Parameters.Add("@TacGia", SqlDbType.NVarChar).Value = thongTinSach.Tacgia;
                sqlCommand.Parameters.Add("@NhaXuatBan", SqlDbType.NVarChar).Value = thongTinSach.Nhaxuatban;
                sqlCommand.Parameters.Add("@NamXuatBan", SqlDbType.Int).Value = thongTinSach.Namsanxuat;
                sqlCommand.Parameters.Add("@GiaTien", SqlDbType.Decimal).Value = thongTinSach.Giatien;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = thongTinSach.Soluong;
                sqlCommand.Parameters.Add("@TinhTrang",SqlDbType.NVarChar).Value=thongTinSach.Tinhtrang;
                sqlCommand.Parameters.Add("@ChatLuong",SqlDbType.NVarChar).Value = thongTinSach.Chatluong;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool deleteSach(string ma)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "delete Sach where MaSach = @MaSach";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = ma;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public DataTable getallBaoCao()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from BaoCao ";
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insertBaoCao(ThongTinBaoCao thongTinBaoCao)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "insert into BaoCao values (@MaBaoCao,@MaSach,@TenSach,@ChatLuong,@SoLuong,@BoSung,@HuySach)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaBaoCao", SqlDbType.NVarChar).Value = thongTinBaoCao.Mabaocao;
                sqlCommand.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = thongTinBaoCao.Masach;
                sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = thongTinBaoCao.Tensach;
                sqlCommand.Parameters.Add("@ChatLuong", SqlDbType.NVarChar).Value = thongTinBaoCao.Chatluong;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = thongTinBaoCao.Soluong;
                sqlCommand.Parameters.Add("@BoSung", SqlDbType.Int).Value =thongTinBaoCao.Bosung;
                sqlCommand.Parameters.Add("@HuySach", SqlDbType.Int).Value = thongTinBaoCao.Huysach;


                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool UpdateBaoCao(ThongTinBaoCao thongTinBaoCao)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "update BaoCao set MaSach = @MaSach, TenSach = @TenSach,ChatLuong = @ChatLuong, SoLuong = @SoLuong,BoSung = @BoSung,HuySach = @HuySach  where MaBaoCao = @MaBaoCao";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaBaoCao", SqlDbType.NVarChar).Value = thongTinBaoCao.Mabaocao;
                sqlCommand.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = thongTinBaoCao.Masach;
                sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = thongTinBaoCao.Tensach;
                sqlCommand.Parameters.Add("@ChatLuong", SqlDbType.NVarChar).Value = thongTinBaoCao.Chatluong;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = thongTinBaoCao.Soluong;
                sqlCommand.Parameters.Add("@BoSung", SqlDbType.Int).Value = thongTinBaoCao.Bosung;
                sqlCommand.Parameters.Add("@HuySach", SqlDbType.Int).Value = thongTinBaoCao.Huysach;


                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool deleteBaoCao(string ma)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "delete BaoCao where MaBaoCao = @MaBaoCao";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaBaoCao", SqlDbType.NVarChar).Value = ma;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public DataTable getallSoMuonTra()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from SoMuonTra ";
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insertSoMuonTra(ThongTinSoMuonTra thongTinSoMuonTra)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "insert into SoMuonTra values (@MaMuonSach,@MaSach,@MaSV,@HoTen,@TenSach,@NgayMuon,@NgayTra,@TinhTrangMuonTra)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
               
                sqlCommand.Parameters.Add("@MaMuonSach", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Mamuonsach;
                sqlCommand.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Masach;
                sqlCommand.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Masinhvien;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Tensinhvien;
                sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Tensach;
                sqlCommand.Parameters.Add("@NgayMuon", SqlDbType.Date).Value = thongTinSoMuonTra.Ngaymuon.ToShortDateString();
                sqlCommand.Parameters.Add("@NgayTra", SqlDbType.Date).Value = thongTinSoMuonTra.Ngaytra.ToShortDateString();
                sqlCommand.Parameters.Add("@TinhTrangMuonTra", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Tinhtrangmuontra;
               
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool updateSoMuonTra(ThongTinSoMuonTra thongTinSoMuonTra)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "update SoMuonTra set MaSach =@MaSach,MaSV=@MaSV,HoTen = @HoTen,TenSach = @TenSach,NgayMuon=@NgayMuon,NgayTra=@NgayTra,TinhTrangMuonTra = @TinhTrangMuonTra where MaMuonSach = @MaMuonSach";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
               
                sqlCommand.Parameters.Add("@MaMuonSach", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Mamuonsach;
                sqlCommand.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Masach;
                sqlCommand.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Masinhvien;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Tensinhvien;
                sqlCommand.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Tensach;
                sqlCommand.Parameters.Add("@NgayMuon", SqlDbType.Date).Value = thongTinSoMuonTra.Ngaymuon.ToShortDateString();
                sqlCommand.Parameters.Add("@NgayTra", SqlDbType.Date).Value = thongTinSoMuonTra.Ngaytra.ToShortDateString();
                sqlCommand.Parameters.Add("@TinhTrangMuonTra", SqlDbType.NVarChar).Value = thongTinSoMuonTra.Tinhtrangmuontra;


                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool deleteSoMuonTra(string ma)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "delete SoMuonTra where MaMuonSach = @MaMuonSach";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaMuonSach", SqlDbType.NVarChar).Value = ma;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public DataTable getallThuThu()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from ThuThu ";
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insertThuThu(ThongTinThuThu thongTinThuThu)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "insert into ThuThu values (@MaThuThu,@TenThuThu,@GioiTinh,@NgaySinh,@DiaChi,@SDT,@Email,@NgayBatDauLam,@NgayNghiViec,@TrangThaiLamViec,@Khoa)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaThuThu", SqlDbType.Int).Value = thongTinThuThu.Mathuthu;
                sqlCommand.Parameters.Add("@TenThuThu", SqlDbType.NVarChar).Value = thongTinThuThu.Tenthuthu;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = thongTinThuThu.Gioitinh;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = thongTinThuThu.Ngaysinh;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = thongTinThuThu.Diachi;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = thongTinThuThu.Sdt;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = thongTinThuThu.Email;
                sqlCommand.Parameters.Add("@NgayBatDauLam", SqlDbType.Date).Value = thongTinThuThu.Ngaybatdaulam;
                sqlCommand.Parameters.Add("@NgayNghiViec", SqlDbType.Date).Value = thongTinThuThu.Ngaynghiviec;
                sqlCommand.Parameters.Add("@TrangThaiLamViec", SqlDbType.NVarChar).Value = thongTinThuThu.Trangthailamviec;
                sqlCommand.Parameters.Add("@Khoa", SqlDbType.NVarChar).Value = thongTinThuThu.Khoa;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool updateThuThu(ThongTinThuThu thongTinThuThu)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "update ThuThu set TenThuThu=@TenThuThu,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,DiaChi=@DiaChi,SDT=@SDT,Email=@Email,NgayBatDauLam=@NgayBatDauLam,NgayNghiViec=@NgayNghiViec,TrangThaiLamViec=@TrangThaiLamViec,Khoa=@Khoa where MaThuThu = @MaThuThu";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaThuThu", SqlDbType.Int).Value = thongTinThuThu.Mathuthu;
                sqlCommand.Parameters.Add("@TenThuThu", SqlDbType.NVarChar).Value = thongTinThuThu.Tenthuthu;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = thongTinThuThu.Gioitinh;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = thongTinThuThu.Ngaysinh;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = thongTinThuThu.Diachi;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = thongTinThuThu.Sdt;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = thongTinThuThu.Email;
                sqlCommand.Parameters.Add("@NgayBatDauLam", SqlDbType.Date).Value = thongTinThuThu.Ngaybatdaulam;
                sqlCommand.Parameters.Add("@NgayNghiViec", SqlDbType.Date).Value = thongTinThuThu.Ngaynghiviec;
                sqlCommand.Parameters.Add("@TrangThaiLamViec", SqlDbType.NVarChar).Value = thongTinThuThu.Trangthailamviec;
                sqlCommand.Parameters.Add("@Khoa", SqlDbType.NVarChar).Value = thongTinThuThu.Khoa;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool deleteThuThu(string ma)
        {
            SqlConnection sqlConnection = connection.GetSqlConnection();
            string query = "delete ThuThu where MaThuThu = @MaThuThu";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaThuThu", SqlDbType.NVarChar).Value = ma;
                sqlCommand.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public int AddBorrowRecord(string MaMuonSach, string MaSach, string MaSinhVien, string TenSinhVien, string TenSach, DateTime NgayMuon, DateTime NgayTra,string TinhTrangMuonTra)
        {
            int rowsAffected = 0;
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlTransaction transaction = sqlConnection.BeginTransaction();
                try
                {
                    // Thêm bản ghi mượn sách
                    string insertQuery = "INSERT INTO SoMuonTra (MaMuonSach, MaSach, MaSinhVien, TenSinhVien, TenSach, NgayMuon, NgayTra,TinhTrangMuonTra) " +
                                         "VALUES (@MaMuonSach, @MaSach, @MaSinhVien, @TenSinhVien, @TenSach, @NgayMuon, @NgayTra,@TinhTrangMuonTra)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection, transaction);
                    insertCommand.Parameters.AddWithValue("@MaMuonSach", MaMuonSach);
                    insertCommand.Parameters.AddWithValue("@MaSach", MaSach);
                    insertCommand.Parameters.AddWithValue("@MaSinhVien", MaSinhVien);
                    insertCommand.Parameters.AddWithValue("@TenSinhVien", TenSinhVien);
                    insertCommand.Parameters.AddWithValue("@TenSach", TenSach);
                    insertCommand.Parameters.AddWithValue("@NgayMuon", NgayMuon);
                    insertCommand.Parameters.AddWithValue("@NgayTra", NgayTra);
                    insertCommand.Parameters.AddWithValue("@TinhTrangMuonTra", TinhTrangMuonTra);

                    rowsAffected = insertCommand.ExecuteNonQuery();

                    // Giảm số lượng sách
                    string updateQuery = "UPDATE Sach SET SoLuong = SoLuong - 1 WHERE MaSach = @MaSach AND SoLuong > 0";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection, transaction);
                    updateCommand.Parameters.AddWithValue("@MaSach", MaSach);

                    int updateResult = updateCommand.ExecuteNonQuery();
                    if (updateResult == 0)
                    {
                        throw new Exception("Cập nhật sách thất bại vì số lượng sách không hợp lệ.");
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    rowsAffected = 0;
                    
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return rowsAffected;
        }
        public DataTable getallBangMuaSach()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from MuaSach ";
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public int MuaSach(string MaGiaoDich, string MaSach, string MaSV, string HoTen, string TenSach, DateTime NgayMua, int SoLuong)
        {
            int rowsAffected = 0;
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlTransaction transaction = sqlConnection.BeginTransaction();
                try
                {
                    // Thêm bản ghi mua sách
                    string insertQuery = @"
                INSERT INTO MuaSach (MaGiaoDich, MaSach, MaSV, HoTen, TenSach, NgayMua, SoLuong) 
                VALUES (@MaGiaoDich, @MaSach, @MaSV, @HoTen, @TenSach, @NgayMua, @SoLuong)";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection, transaction);
                    insertCommand.Parameters.AddWithValue("@MaGiaoDich", MaGiaoDich);
                    insertCommand.Parameters.AddWithValue("@MaSach", MaSach);
                    insertCommand.Parameters.AddWithValue("@MaSV", MaSV);
                    insertCommand.Parameters.AddWithValue("@HoTen", HoTen);
                    insertCommand.Parameters.AddWithValue("@TenSach", TenSach);
                    insertCommand.Parameters.AddWithValue("@NgayMua", NgayMua);
                  //  insertCommand.Parameters.AddWithValue("@Gia", Gia);
                    insertCommand.Parameters.AddWithValue("@SoLuong", SoLuong);

                    rowsAffected = insertCommand.ExecuteNonQuery();

                    // Cập nhật giá sách trong bảng MuaSach
                    string updatePriceQuery = @"
                UPDATE ms
                SET ms.Gia = ms.SoLuong * s.GiaTien
                FROM MuaSach ms
                INNER JOIN Sach s ON ms.MaSach = s.MaSach
                WHERE ms.MaGiaoDich = @MaGiaoDich";

                    SqlCommand updatePriceCommand = new SqlCommand(updatePriceQuery, sqlConnection, transaction);
                    updatePriceCommand.Parameters.AddWithValue("@MaGiaoDich", MaGiaoDich);

                    updatePriceCommand.ExecuteNonQuery();

                    // Cập nhật số lượng sách trong bảng Sach
                    string updateQuantityQuery = "UPDATE Sach SET SoLuong = SoLuong - @SoLuong WHERE MaSach = @MaSach AND SoLuong >= @SoLuong";
                    SqlCommand updateQuantityCommand = new SqlCommand(updateQuantityQuery, sqlConnection, transaction);
                    updateQuantityCommand.Parameters.AddWithValue("@MaSach", MaSach);
                    updateQuantityCommand.Parameters.AddWithValue("@SoLuong", SoLuong);

                    int updateResult = updateQuantityCommand.ExecuteNonQuery();
                    if (updateResult == 0)
                    {
                        throw new Exception("Cập nhật sách thất bại vì số lượng sách không hợp lệ hoặc không đủ sách.");
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    rowsAffected = 0;

                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return rowsAffected;
        }

       


        public string GetMaxBorrowId()
        {
            string maxBorrowId = "MSS0";
            string query = "SELECT TOP 1 MaMuonSach FROM SoMuonTra ORDER BY MaMuonSach DESC";

            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        maxBorrowId = result.ToString();
                    }
                }
            }

            // Tăng mã mượn sách
            long numPart = long.Parse(maxBorrowId.Substring(3)) + 1;
            return "MSS" + numPart.ToString();
        }
        public string GetMaxMuaSachID()
        {
            string maxBorrowId = "MM01";
            string query = "SELECT TOP 1 MaGiaoDich FROM MuaSach ORDER BY MaGiaoDich DESC";

            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        maxBorrowId = result.ToString();
                    }
                }
            }

            // Tăng mã mượn sách
            long numPart = long.Parse(maxBorrowId.Substring(2)) + 1;
            return "MM" + numPart.ToString();
        }
        public int ReturnBook(string MaMuonSach, DateTime NgayTra,string TinhTrangMuonTra)
        {
            int rowsAffected = 0;
            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlTransaction transaction = sqlConnection.BeginTransaction();
                try
                {
                    // Cập nhật tình trạng mượn trả và ngày trả trong bảng SoMuonTra
                    string updateQuery = "UPDATE SoMuonTra SET TinhTrangMuonTra = @TinhTrangMuonTra, NgayTra = @NgayTra WHERE MaMuonSach = @MaMuonSach";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection, transaction);
                    updateCommand.Parameters.AddWithValue("@MaMuonSach", MaMuonSach);
                    updateCommand.Parameters.AddWithValue("@NgayTra", NgayTra);
                    updateCommand.Parameters.AddWithValue("@TinhTrangMuonTra", TinhTrangMuonTra);


                    rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("Không tìm thấy thông tin mượn sách tương ứng.");
                    }

                    // Tăng số lượng sách lên 1
                    string returnBookQuery = "UPDATE Sach SET SoLuong = SoLuong + 1 WHERE MaSach IN (SELECT MaSach FROM SoMuonTra WHERE MaMuonSach = @MaMuonSach)";
                    SqlCommand returnBookCommand = new SqlCommand(returnBookQuery, sqlConnection, transaction);
                    returnBookCommand.Parameters.AddWithValue("@MaMuonSach", MaMuonSach);

                    int returnBookResult = returnBookCommand.ExecuteNonQuery();
                    if (returnBookResult == 0)
                    {
                        throw new Exception("Cập nhật số lượng sách thất bại.");
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    rowsAffected = 0;

                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return rowsAffected;
        }

        public DataRow GetMostBorrowedBook()
        {
            DataRow row = null;
            string query = @"
            SELECT TOP 1 Sach.MaSach, Sach.TenSach, Sach.TacGia, COUNT(SoMuonTra.MaSach) AS LuotMuon
            FROM SoMuonTra
            INNER JOIN Sach ON SoMuonTra.MaSach = Sach.MaSach
            WHERE SoMuonTra.TinhTrangMuonTra like  N'da tra' COLLATE SQL_Latin1_General_CP1_CI_AI
            GROUP BY Sach.MaSach, Sach.TenSach, Sach.TacGia
            ORDER BY LuotMuon DESC";

            using (SqlConnection sqlConnection = connection.GetSqlConnection()) 
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    row = table.Rows[0];
                }
            }
            return row;
        }

        public DataRow GetMostSoldBook()
        {
            DataRow row = null;
            string query = @"
        SELECT TOP 1 Sach.MaSach, Sach.TenSach, Sach.TacGia, SUM(MuaSach.SoLuong) AS LuotMua
        FROM MuaSach
        INNER JOIN Sach ON MuaSach.MaSach = Sach.MaSach
        GROUP BY Sach.MaSach, Sach.TenSach, Sach.TacGia
        ORDER BY LuotMua DESC";

            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    row = table.Rows[0];
                }
            }
            return row;
        }

        public DataRow GetTopBuyer()
        {
            DataRow row = null;
            string query = @"
                SELECT TOP 1 MuaSach.MaSV, MuaSach.HoTen, SUM(MuaSach.SoLuong) AS TongSoLuong
                FROM MuaSach
                GROUP BY MuaSach.MaSV, MuaSach.HoTen
                ORDER BY TongSoLuong DESC";

            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    row = table.Rows[0];
                }
            }
            return row;
        }


        public DataRow GetMostFrequentBorrower()
        {
            DataRow row = null;
            string query = @"
            SELECT TOP 1 MaSv, HoTen, COUNT(MaSV) AS LuotMuon
            FROM SoMuonTra
            GROUP BY MaSV, HoTen
            ORDER BY COUNT(MaSV) DESC";

            using (SqlConnection sqlConnection = connection.GetSqlConnection() ) 
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    row = table.Rows[0];
                }
            }
            return row;
        }

        public DataTable GetDocGiaQuaHan()
        {
            DataTable table = new DataTable();
            string query = @"
            SELECT MaMuonSach, MaSV, HoTen, MaSach, TenSach, NgayMuon, NgayTra,TinhTrangMuonTra 
            FROM SoMuonTra
            WHERE NgayTra < GETDATE() AND TinhTrangMuonTra like N'qua han' COLLATE SQL_Latin1_General_CP1_CI_AI";

            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(table);
            }
            return table;


        }

        public DataTable GetOldBooks()
        {
            DataTable table = new DataTable();
            string query = @"
        SELECT MaBaoCao, MaSach, TenSach, ChatLuong, SoLuong, Bosung, HuySach
        FROM BaoCao
        WHERE ChatLuong like N'cũ' ";

            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(table);
            }
            return table;
        }


    }
}
