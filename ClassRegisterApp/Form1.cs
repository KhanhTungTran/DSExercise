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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void createClassButton_Click(object sender, EventArgs e) {
            createClassForm form = new createClassForm();
            form.ShowDialog();
        }

        private void queryStudentsButton_Click(object sender, EventArgs e) {
            queryStudentsForm form = new queryStudentsForm();
            form.ShowDialog();
        }

        private void queryClassesButton_Click(object sender, EventArgs e) {
            queryClassesForm form = new queryClassesForm();
            form.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                DialogResult ketQua;
                ketQua = MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo);
                if (ketQua != DialogResult.Yes) {
                    e.Cancel = true;
                    this.Activate();
                }
                else { Application.Exit(); }
            }
        }
    }
}
