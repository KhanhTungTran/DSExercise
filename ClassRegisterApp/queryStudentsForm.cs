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
    public partial class queryStudentsForm : Form {
        public queryStudentsForm() {
            InitializeComponent();
        }
        
        private void exitButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
