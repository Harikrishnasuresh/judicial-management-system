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
    public partial class front : Form
    {
        public front()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login obj = new login();
            this.Hide();
            obj.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            search obj = new search();
            this.Hide();
            obj.Show();
        }
    }
}
