using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClassRegisterApp {
    class Services {
        static SqlConnection conn = new SqlConnection(@"");
        private void OpenConnection() {
            if (conn.State != System.Data.ConnectionState.Open) {
                conn.Close();
                conn.Open();
            }
        }

        // Tìm kiếm sinh viên, có thể tìm theo MSSV, Họ tên (có thể ra nhiều sinh viên), email
        public static void FindStudent() {

        }

        // Tìm lớp học theo ngày giờ, tên (ra nhiều lớp học)
        public static void FindClass() {

        }
    }
}
