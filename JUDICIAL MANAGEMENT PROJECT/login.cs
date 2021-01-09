using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JUDICIAL_MANAGEMENT_PROJECT
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            front obj = new front();
            this.Hide();
            obj.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from user_table where username ='" + textBox1.Text.Trim() + "' AND password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dta = new DataTable();
            sda.Fill(dta);
            if (dta.Rows.Count == 1)
            {
                admin obj = new admin();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("wrong credentials");
            }
            con.Close();
        }

    }
    
}
