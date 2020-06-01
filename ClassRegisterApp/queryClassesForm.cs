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
    public partial class queryClassesForm : Form {
        public queryClassesForm() {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            Services.CloseConnection();
            this.Close();
        }


        private void btnTimKiem_Click(object sender, EventArgs e) {
            bool Buoi = default, coBuoi = true;
            if (comboBuoi.Text != "(None)") {
                if (comboBuoi.Text == "Sáng") {
                    Buoi = true;
                }
                else { Buoi = false; }
            }
            else coBuoi = false;

            try {
                DataTable dt = new DataTable();
                dt.Load(Services.FindClass( (txtID.Text != "") ? Int32.Parse(txtID.Text) : -1,
                                            (comboMonHoc.Text != "(None)") ? comboMonHoc.Text : "",
                                            (txtNguoiDay.Text != "") ? txtNguoiDay.Text : "",
                                            Buoi, 
                                            coBuoi,
                                            checkBoxCoNgay.Checked ? dateTimePickerNgay.Value.Date : default)
                                          );
                dsLopHoc.DataSource = dt;
                //MessageBox.Show(dt.ToString());

                btnXemDS.Enabled = true;
                btnSuaLopHoc.Enabled = true;

                txtBoxMSSV.Visible = false;
                lbMSSV.Visible = false;
                btnThemSV.Visible = false;
                btnXoaSV.Visible = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void queryClassesForm_Load(object sender, EventArgs e) {
            Services.OpenConnection();
            comboMonHoc.SelectedIndex = 0;
            comboBuoi.SelectedIndex = 0;
            checkBoxCoNgay.Checked = false;
        }

        static private int currentLopHocID;
        static private int currentLopHocNumbers;
        private void btnXemDS_Click(object sender, EventArgs e) {
            try {
                DataTable dt = new DataTable();
                currentLopHocID = Convert.ToInt32(dsLopHoc.CurrentRow.Cells[0].Value);
                currentLopHocNumbers = Convert.ToInt32(dsLopHoc.CurrentRow.Cells[5].Value);
                dt.Load(Services.FindStudentsOfClass(currentLopHocID));
                dsLopHoc.DataSource = dt;

                txtBoxMSSV.Visible = true;
                lbMSSV.Visible = true;
                btnThemSV.Visible = true;
                btnXoaSV.Visible = true;
                btnXemDS.Enabled = false;

                btnSuaLopHoc.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnThemSV_Click(object sender, EventArgs e) {
            try {
                Services.InsertStudentToClass(Int32.Parse(txtBoxMSSV.Text), currentLopHocID, currentLopHocNumbers);
                currentLopHocNumbers += 1;

                // Tải lại danh sách:
                DataTable dt = new DataTable();
                dt.Load(Services.FindStudentsOfClass(currentLopHocID));
                dsLopHoc.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e) {
            try {
                Services.DeleteStudentFromClass(Int32.Parse(txtBoxMSSV.Text), currentLopHocID, currentLopHocNumbers);
                currentLopHocNumbers -= 1;

                // Tải lại danh sách:
                DataTable dt = new DataTable();
                dt.Load(Services.FindStudentsOfClass(currentLopHocID));
                dsLopHoc.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnSuaLopHoc_Click(object sender, EventArgs e) {
            if (dsLopHoc.Rows.Count != 2) {
                MessageBox.Show("Chỉ được cập nhật thông tin 1 lớp học cùng 1 lúc", "Lỗi");
                return;
            }


            bool Buoi = default, coBuoi = true;
            if (comboBuoi.Text != "(None)") {
                if (comboBuoi.Text == "Sáng") {
                    Buoi = true;
                }
                else { Buoi = false; }
            }
            else coBuoi = false;

            try {
                int ID = Convert.ToInt32(dsLopHoc.Rows[0].Cells[0].Value);
                Services.UpdateClass(ID,
                                     (comboMonHoc.Text != "(None)") ? comboMonHoc.Text : "",
                                     (txtNguoiDay.Text != "") ? txtNguoiDay.Text : "",
                                     Buoi,
                                     coBuoi,
                                     checkBoxCoNgay.Checked ? dateTimePickerNgay.Value.Date : default
                                    );

                DataTable dt = new DataTable();
                dt.Load(Services.FindClass(ID, "", "", default, false, default));

                dsLopHoc.DataSource = dt;

                btnXemDS.Enabled = true;
                btnSuaLopHoc.Enabled = true;

                txtBoxMSSV.Visible = false;
                lbMSSV.Visible = false;
                btnThemSV.Visible = false;
                btnXoaSV.Visible = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
