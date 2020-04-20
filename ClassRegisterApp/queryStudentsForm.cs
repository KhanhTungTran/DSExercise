using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRegisterApp {
    public partial class queryStudentsForm : Form {
        //Services services = new Services();
        public queryStudentsForm() {
            InitializeComponent();
            Services.OpenConnection();
        }

        private void queryStudentsForm_Load(object sender, EventArgs e)
        {
            DisplayStudents();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Services.CloseConnection();
            this.Close();
        }

        //Đổ danh sách sinh viên ra bảng
        private void DisplayStudents()
        {
            DataTable dt = new DataTable();
            dt.Load(Services.getStudentLists());
            dsSinhVien.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Services.CreateStudent(int.Parse(txtMs.Text), txtHoTen.Text, txtEmail.Text, txtKhoa.Text, txtSdt.Text);
                MessageBox.Show("Thêm sinh viên thành công", "Thành công");
                DisplayStudents();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Services.UpdateStudent(int.Parse(txtMs.Text), txtHoTen.Text, txtEmail.Text, txtKhoa.Text, txtSdt.Text);
                MessageBox.Show("Cập nhật thông tin sinh viên thành công", "Thành công");
                DisplayStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Services.DeleteStudent(int.Parse(txtMs.Text));
                MessageBox.Show("Xoá sinh viên thành công", "Thành công");
                DisplayStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Load(Services.FindStudent(int.Parse(txtTim.Text)));
                dsSinhVien.DataSource = dt;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayStudents();
        }

        private void dsSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dsSinhVien.CurrentRow.Index;
            txtMs.Text = dsSinhVien.Rows[idx].Cells[0].Value.ToString();
            txtHoTen.Text = dsSinhVien.Rows[idx].Cells[1].Value.ToString();
            txtEmail.Text = dsSinhVien.Rows[idx].Cells[2].Value.ToString();
            txtKhoa.Text = dsSinhVien.Rows[idx].Cells[3].Value.ToString();
            txtSdt.Text = dsSinhVien.Rows[idx].Cells[4].Value.ToString();
        }
    }
}
