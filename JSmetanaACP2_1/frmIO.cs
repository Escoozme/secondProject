using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JSmetanaACP2_1 {
    public partial class frmIO : Form {
        public frmIO() {
            InitializeComponent();
        }

        StreamReader sr = new StreamReader("numbers.txt");
        double[] nums = new double[6];

        private void frmIO_Load(object sender, EventArgs e) {
            lbxGrades.Items.Add("Grade\tLetter Grade");
            for (int i = 0; i < nums.Length; ++i) {
                nums[i] = double.Parse(sr.ReadLine());
                lbxGrades.Items.Add(nums[i].ToString());
            }
        }

        private void btnGrades_Click(object sender, EventArgs e) {
            double total = 0.0;
            double average = 0.0;

            for (int i = 0; i < nums.Length; ++i) {
                if (nums[i] >= 90)
                    lbxGrades.Items[i + 1] += "\t\tA";
                else if(nums[i] >= 80)
                    lbxGrades.Items[i + 1] += "\t\tB";
                else if(nums[i] >= 70)
                    lbxGrades.Items[i + 1] += "\t\tC";
                else if (nums[i] >= 60)
                    lbxGrades.Items[i + 1] += "\t\tD";
                else
                    lbxGrades.Items[i + 1] += "\t\tF";

                total += nums[i];
            }

            average = total / nums.Length;

            lbxGrades.Items.Add("");
            lbxGrades.Items.Add("Total: " + total.ToString("N2"));
            lbxGrades.Items.Add("Average: " + average.ToString("N2"));
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e) {
            StreamWriter sw = new StreamWriter("grades.txt");
            foreach (string i in lbxGrades.Items)
                sw.WriteLine(i);
            sw.Close();
        }
    }
}
