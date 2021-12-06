using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSmetanaACP2_1 {
    public partial class frmMouser : Form {
        public frmMouser() {
            InitializeComponent();
        }

        private void frmMouser_MouseClick(object sender, MouseEventArgs e) {
            lblMouseClickCoords.Text = e.X + ", " + e.Y;

            if (e.X == 250 && e.Y == 250)
                MessageBox.Show("Awesome Job!");
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
