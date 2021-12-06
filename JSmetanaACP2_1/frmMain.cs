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
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        LinkedList<string> items = new LinkedList<string>();

        private void btnClear_Click(object sender, EventArgs e) {
            lbxItems.Items.Clear();
        }

        private void btnAddItem_Click(object sender, EventArgs e) {
            if(tbxAddItem.Text != String.Empty)
                items.AddLast(tbxAddItem.Text);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e) {
            if (!items.Remove(tbxAddItem.Text))
                MessageBox.Show("Item Not Found.");
        }

        private void btnContains_Click(object sender, EventArgs e) {
            if (items.Contains(tbxAddItem.Text))
                MessageBox.Show("Item Found.");
        }

        private void btnDisplay_Click(object sender, EventArgs e) {
            foreach (string s in items)
                lbxItems.Items.Add(s);
        }

        private void mnuGoToInputOutput_Click(object sender, EventArgs e) {
            frmIO io = new frmIO();
            io.ShowDialog();
        }

        private void mnuGoToMouser_Click(object sender, EventArgs e) {
            frmMouser mouser = new frmMouser();
            mouser.ShowDialog();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e) {
            frmAbout about = new frmAbout();
            about.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
