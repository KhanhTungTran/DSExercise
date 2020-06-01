using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ClassRegisterApp {
    class Services {
        static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Classroom;Integrated Security=True");
        public static void OpenConnection() {
            if (conn.State != System.Data.ConnectionState.Open) {
                conn.Close();
                conn.Open();
            }
        }

        public static void CloseConnection() {
            if (conn.State != System.Data.ConnectionState.Closed) {
                conn.Close();
            }
        }

        // Tìm lớp học theo ngày giờ, tên (ra nhiều lớp học)
        public static SqlDataReader FindClass(int ID, string monHoc, string nguoiDay, bool buoi, bool coBuoi, DateTime ngay) {
            string sqlFind = "SELECT * FROM LopHoc ";

            if (ID != -1) { sqlFind += "WHERE ID = @id"; }

            if (monHoc != "" || coBuoi != false || ngay != default) {
                if (ID != -1) { sqlFind += " AND "; }
                else { sqlFind += "WHERE "; }
                bool and = false;
                if (monHoc != "") {
                    sqlFind += "TenMonHoc = @tenmonhoc"; 
                    and = true;
                }
                if (nguoiDay != "") {
                    if (and) { sqlFind += " AND "; }
                    sqlFind += "NguoiDay = @nguoiday"; 
                    and = true;
                }
                if (coBuoi != false) {
                    if (and) { sqlFind += " AND ";}
                    sqlFind += "Buoi = @buoi";
                    and = true;
                }
                if (ngay != default) {
                    if (and) { sqlFind += " AND "; }
                    sqlFind += "Ngay = @ngay";
                }
            }

            SqlCommand cmd = new SqlCommand(sqlFind, conn);
            if (ID != -1) { cmd.Parameters.AddWithValue("id", ID); }
            if (monHoc != "") { cmd.Parameters.AddWithValue("tenmonhoc", monHoc); }
            if (nguoiDay != "") { cmd.Parameters.AddWithValue("nguoiday", nguoiDay); }
            if (coBuoi != false) { cmd.Parameters.AddWithValue("buoi", buoi); }
            if (ngay != default) { cmd.Parameters.AddWithValue("ngay", SqlDbType.Date).Value = ngay.Date; }
            return cmd.ExecuteReader();
        }

        // Tìm lớp học theo ngày giờ, tên (ra nhiều lớp học)
        public static void UpdateClass(int ID, string monHoc, string nguoiDay, bool buoi, bool coBuoi, DateTime ngay) {
            string sqlFind = "UPDATE LopHoc ";

            if (monHoc != "" || coBuoi != false || ngay != default) {
                sqlFind += "SET ";
                bool comma = false;
                if (monHoc != "") {
                    sqlFind += "TenMonHoc = @tenmonhoc"; comma = true;
                }
                if (nguoiDay != "") {
                    if (comma) { sqlFind += " , "; }
                    sqlFind += "NguoiDay = @nguoiday"; 
                    comma = true;
                }
                if (coBuoi != false) {
                    if (comma) { sqlFind += " , "; }
                    sqlFind += "Buoi = @buoi";
                    comma = true;
                }
                if (ngay != default) {
                    if (comma) { sqlFind += " , "; }
                    sqlFind += "Ngay = @ngay";
                }
            }
            sqlFind += " WHERE ID=@id";

            SqlCommand cmd = new SqlCommand(sqlFind, conn);
            if (monHoc != "") { cmd.Parameters.AddWithValue("tenmonhoc", monHoc); }
            if (nguoiDay != "") { cmd.Parameters.AddWithValue("nguoiday", nguoiDay); }
            if (coBuoi != false) { cmd.Parameters.AddWithValue("buoi", buoi); }
            if (ngay != default) { cmd.Parameters.AddWithValue("ngay", SqlDbType.Date).Value = ngay.Date; }
            cmd.Parameters.AddWithValue("id", ID);

            cmd.ExecuteNonQuery();
        }
        

        // Tìm sinh viên thuộc lớp học theo id của lớp học
        public static SqlDataReader FindStudentsOfClass(int classID) {
            string sqlFind = "SELECT * FROM SinhVien INNER JOIN SV_LH ON SV_LH.ID = @id AND SinhVien.MSSV = SV_LH.MSSV";
            
            SqlCommand cmd = new SqlCommand(sqlFind, conn);
            cmd.Parameters.AddWithValue("id", classID);
            
            return cmd.ExecuteReader();
        }

        // Thêm sinh viên vào lớp học dựa vào mssv
        public static void InsertStudentToClass(int MSSV, int classID, int classNumberOfStudents) {
            string sqlInsert = "INSERT INTO SV_LH (MSSV, ID) VALUES(@mssv, @id)";

            SqlCommand cmd = new SqlCommand(sqlInsert, conn);
            cmd.Parameters.AddWithValue("mssv", MSSV);
            cmd.Parameters.AddWithValue("id", classID);
            cmd.ExecuteNonQuery();

            string sqlUpdate = "UPDATE LopHoc SET SoLuongSinhVien = @slsv WHERE ID = @id";
            cmd = new SqlCommand(sqlUpdate, conn);
            cmd.Parameters.AddWithValue("slsv", classNumberOfStudents + 1);
            cmd.Parameters.AddWithValue("id", classID);
            cmd.ExecuteNonQuery();
        }

        // Xóa sinh viên khỏi lớp học dựa vào mssv
        public static void DeleteStudentFromClass(int MSSV, int classID, int classNumberOfStudents) {
            string sqlInsert = "DELETE FROM SV_LH WHERE MSSV=@mssv AND ID=@id";

            SqlCommand cmd = new SqlCommand(sqlInsert, conn);
            cmd.Parameters.AddWithValue("mssv", MSSV);
            cmd.Parameters.AddWithValue("id", classID);
            cmd.ExecuteNonQuery();

            string sqlUpdate = "UPDATE LopHoc SET SoLuongSinhVien = @slsv WHERE ID = @id";
            cmd = new SqlCommand(sqlUpdate, conn);
            cmd.Parameters.AddWithValue("slsv", classNumberOfStudents - 1);
            cmd.Parameters.AddWithValue("id", classID);
            cmd.ExecuteNonQuery();
        }



        // Tạo lớp học mới
        public static void CreateClass(string subject, string teacher, bool buoi, DateTime date) {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO LopHoc (TenMonHoc,Buoi, Ngay, NguoiDay) VALUES(@TenMonHoc, @Buoi, @Ngay, @NguoiDay)";
            //command.Parameters.AddWithValue("ID", 1);
            command.Parameters.AddWithValue("TenMonHoc", subject);
            command.Parameters.AddWithValue("NguoiDay", teacher);
            command.Parameters.AddWithValue("Buoi", buoi);
            command.Parameters.AddWithValue("Ngay", date);
            command.ExecuteNonQuery();
        }


        // Hien thi danh sach sinh vien
        public static SqlDataReader getStudentLists() {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM SinhVien";
            return command.ExecuteReader();
        }

        // Tạo Sinh viên mới
        public static void CreateStudent(int MSSV, string ten, string email, string khoa, string sdt) {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO SinhVien (MSSV, HoVaTen, Email, Khoa, SDT) VALUES(@MSSV, @ten, @email, @khoa, @sdt)";
            command.Parameters.AddWithValue("MSSV", MSSV);
            command.Parameters.AddWithValue("ten", ten);
            command.Parameters.AddWithValue("email", email);
            command.Parameters.AddWithValue("khoa", khoa);
            command.Parameters.AddWithValue("sdt", sdt);
            command.ExecuteNonQuery();
        }
        // Cập nhật thông tin sinh viên
        public static void UpdateStudent(int MSSV, string ten, string email, string khoa, string sdt) {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE SinhVien SET MSSV = @MSSV , HoVaTen = @ten, Email = @email, Khoa = @khoa, SDT = @sdt WHERE MSSV = @mssv";
            command.Parameters.AddWithValue("MSSV", MSSV);
            command.Parameters.AddWithValue("ten", ten);
            command.Parameters.AddWithValue("email", email);
            command.Parameters.AddWithValue("khoa", khoa);
            command.Parameters.AddWithValue("sdt", sdt);
            command.ExecuteNonQuery();

        }

        // Xoá sinh viên 
        public static void DeleteStudent(int MSSV) {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM SinhVien WHERE MSSV=@MSSV";
            command.Parameters.AddWithValue("MSSV", MSSV);
            command.ExecuteNonQuery();

        }

        public static SqlDataReader FindStudent(int MSSV) {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM SinhVien WHERE MSSV=@MSSV";
            command.Parameters.AddWithValue("MSSV", MSSV);
            return command.ExecuteReader();

        }
    }
}
