namespace ClassRegisterApp {
    partial class Form1 {
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
            this.ChooseOptions = new System.Windows.Forms.Label();
            this.queryClassesButton = new System.Windows.Forms.Button();
            this.queryStudentsButton = new System.Windows.Forms.Button();
            this.createClassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseOptions
            // 
            this.ChooseOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChooseOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseOptions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChooseOptions.Location = new System.Drawing.Point(0, 0);
            this.ChooseOptions.Name = "ChooseOptions";
            this.ChooseOptions.Size = new System.Drawing.Size(422, 194);
            this.ChooseOptions.TabIndex = 0;
            this.ChooseOptions.Text = "Bạn muốn:";
            this.ChooseOptions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // queryClassesButton
            // 
            this.queryClassesButton.Location = new System.Drawing.Point(111, 90);
            this.queryClassesButton.Name = "queryClassesButton";
            this.queryClassesButton.Size = new System.Drawing.Size(187, 23);
            this.queryClassesButton.TabIndex = 2;
            this.queryClassesButton.Text = "2. Truy cập thông tin lớp học.";
            this.queryClassesButton.UseVisualStyleBackColor = true;
            this.queryClassesButton.Click += new System.EventHandler(this.queryClassesButton_Click);
            // 
            // queryStudentsButton
            // 
            this.queryStudentsButton.Location = new System.Drawing.Point(111, 145);
            this.queryStudentsButton.Name = "queryStudentsButton";
            this.queryStudentsButton.Size = new System.Drawing.Size(187, 23);
            this.queryStudentsButton.TabIndex = 3;
            this.queryStudentsButton.Text = "3. Truy cập thông tin sinh viên";
            this.queryStudentsButton.UseVisualStyleBackColor = true;
            this.queryStudentsButton.Click += new System.EventHandler(this.queryStudentsButton_Click);
            // 
            // createClassButton
            // 
            this.createClassButton.Location = new System.Drawing.Point(111, 35);
            this.createClassButton.Name = "createClassButton";
            this.createClassButton.Size = new System.Drawing.Size(187, 23);
            this.createClassButton.TabIndex = 1;
            this.createClassButton.Text = "1. Tạo lớp học mới";
            this.createClassButton.UseVisualStyleBackColor = true;
            this.createClassButton.Click += new System.EventHandler(this.createClassButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 194);
            this.Controls.Add(this.queryStudentsButton);
            this.Controls.Add(this.queryClassesButton);
            this.Controls.Add(this.createClassButton);
            this.Controls.Add(this.ChooseOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí sinh viên và lớp học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ChooseOptions;
        private System.Windows.Forms.Button queryClassesButton;
        private System.Windows.Forms.Button queryStudentsButton;
        private System.Windows.Forms.Button createClassButton;
    }
}

