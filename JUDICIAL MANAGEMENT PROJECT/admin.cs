using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUDICIAL_MANAGEMENT_PROJECT
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            front obj = new front();
            this.Hide();
            obj.Show();
        }

        private void CASE_Click(object sender, EventArgs e)
        {
            caseadm obj = new caseadm();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            courtadd obj = new courtadd();
            this.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addusers obj = new addusers();
            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            detailsadd obj = new detailsadd();
            this.Hide();
            obj.Show();
        }
    }
}
