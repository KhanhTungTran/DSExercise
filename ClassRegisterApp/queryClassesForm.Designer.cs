namespace ClassRegisterApp {
    partial class queryClassesForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label3 = new System.Windows.Forms.Label();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.btnSuaLopHoc = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.comboBuoi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dsLopHoc = new System.Windows.Forms.DataGridView();
            this.comboMonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerNgay = new System.Windows.Forms.DateTimePicker();
            this.checkBoxCoNgay = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.txtBoxMSSV = new System.Windows.Forms.TextBox();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNguoiDay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày:";
            // 
            // btnXemDS
            // 
            this.btnXemDS.Enabled = false;
            this.btnXemDS.Location = new System.Drawing.Point(13, 417);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(140, 23);
            this.btnXemDS.TabIndex = 19;
            this.btnXemDS.Text = "Xem danh sách sinh viên";
            this.btnXemDS.UseVisualStyleBackColor = true;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // btnSuaLopHoc
            // 
            this.btnSuaLopHoc.Enabled = false;
            this.btnSuaLopHoc.Location = new System.Drawing.Point(159, 417);
            this.btnSuaLopHoc.Name = "btnSuaLopHoc";
            this.btnSuaLopHoc.Size = new System.Drawing.Size(140, 23);
            this.btnSuaLopHoc.TabIndex = 18;
            this.btnSuaLopHoc.Text = "Sửa thông tin lớp học";
            this.btnSuaLopHoc.UseVisualStyleBackColor = true;
            this.btnSuaLopHoc.Click += new System.EventHandler(this.btnSuaLopHoc_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(540, 417);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(266, 57);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // comboBuoi
            // 
            this.comboBuoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuoi.FormattingEnabled = true;
            this.comboBuoi.Items.AddRange(new object[] {
            "(None)",
            "Sáng",
            "Chiều"});
            this.comboBuoi.Location = new System.Drawing.Point(231, 11);
            this.comboBuoi.Name = "comboBuoi";
            this.comboBuoi.Size = new System.Drawing.Size(110, 21);
            this.comboBuoi.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buổi:";
            // 
            // dsLopHoc
            // 
            this.dsLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsLopHoc.Location = new System.Drawing.Point(13, 99);
            this.dsLopHoc.Name = "dsLopHoc";
            this.dsLopHoc.Size = new System.Drawing.Size(601, 307);
            this.dsLopHoc.TabIndex = 13;
            // 
            // comboMonHoc
            // 
            this.comboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonHoc.FormattingEnabled = true;
            this.comboMonHoc.Items.AddRange(new object[] {
            "(None)",
            "Giải tích 1",
            "Giải tích 2",
            "Vật lý 1",
            "Vật lý 2",
            "Hóa đại cương",
            "Đại số tuyến tính"});
            this.comboMonHoc.Location = new System.Drawing.Point(69, 11);
            this.comboMonHoc.Name = "comboMonHoc";
            this.comboMonHoc.Size = new System.Drawing.Size(110, 21);
            this.comboMonHoc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Môn học:";
            // 
            // dateTimePickerNgay
            // 
            this.dateTimePickerNgay.CustomFormat = " ";
            this.dateTimePickerNgay.Location = new System.Drawing.Point(403, 10);
            this.dateTimePickerNgay.Name = "dateTimePickerNgay";
            this.dateTimePickerNgay.Size = new System.Drawing.Size(192, 20);
            this.dateTimePickerNgay.TabIndex = 22;
            // 
            // checkBoxCoNgay
            // 
            this.checkBoxCoNgay.AutoSize = true;
            this.checkBoxCoNgay.Location = new System.Drawing.Point(599, 14);
            this.checkBoxCoNgay.Name = "checkBoxCoNgay";
            this.checkBoxCoNgay.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCoNgay.TabIndex = 23;
            this.checkBoxCoNgay.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mã:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(43, 59);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 20);
            this.txtID.TabIndex = 25;
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Location = new System.Drawing.Point(537, 73);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSV.TabIndex = 29;
            this.btnXoaSV.Text = "Xóa SV";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Visible = false;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(451, 73);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(75, 23);
            this.btnThemSV.TabIndex = 28;
            this.btnThemSV.Text = "Thêm SV";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Visible = false;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // txtBoxMSSV
            // 
            this.txtBoxMSSV.Location = new System.Drawing.Point(503, 37);
            this.txtBoxMSSV.Name = "txtBoxMSSV";
            this.txtBoxMSSV.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMSSV.TabIndex = 27;
            this.txtBoxMSSV.Visible = false;
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(457, 40);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(40, 13);
            this.lbMSSV.TabIndex = 26;
            this.lbMSSV.Text = "MSSV:";
            this.lbMSSV.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Người dạy:";
            // 
            // txtNguoiDay
            // 
            this.txtNguoiDay.Location = new System.Drawing.Point(185, 59);
            this.txtNguoiDay.Name = "txtNguoiDay";
            this.txtNguoiDay.Size = new System.Drawing.Size(63, 20);
            this.txtNguoiDay.TabIndex = 31;
            // 
            // queryClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 447);
            this.Controls.Add(this.txtNguoiDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.txtBoxMSSV);
            this.Controls.Add(this.lbMSSV);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxCoNgay);
            this.Controls.Add(this.dateTimePickerNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXemDS);
            this.Controls.Add(this.btnSuaLopHoc);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.comboBuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dsLopHoc);
            this.Controls.Add(this.comboMonHoc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "queryClassesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Truy cập thông tin lớp học";
            this.Load += new System.EventHandler(this.queryClassesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.Button btnSuaLopHoc;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox comboBuoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dsLopHoc;
        private System.Windows.Forms.ComboBox comboMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgay;
        private System.Windows.Forms.CheckBox checkBoxCoNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.TextBox txtBoxMSSV;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNguoiDay;
    }
}