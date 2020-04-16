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
            this.Close();
        }
    }
}
