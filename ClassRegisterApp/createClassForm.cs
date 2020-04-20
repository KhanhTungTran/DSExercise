using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRegisterApp {
    public partial class createClassForm : Form {
        public createClassForm() {
            InitializeComponent();
            Services.OpenConnection();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Services.CloseConnection();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool buoi = comboBuoi.Text == "Sáng" ? true : false;
            try
            {
                Services.CreateClass(this.txtTen.Text, this.txtNguoiDay.Text, buoi, this.dateNgay.Value);
                MessageBox.Show("Thêm lớp học thành công", "Thành công");
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
