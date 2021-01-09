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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            front obj = new front();
            this.Hide();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            if (textBox1.Text != " ")
            {
                SqlCommand cmd = new SqlCommand("SELECT d.defence,c.date,d.prosecution,co.court_name,d.judge,c.case_type,d.place,c.case_status,d.FIR FROM details d ,case_table c,court co where d.caseid=@case_id and c.case_id=d.details_id and c.court_id=co.court_id", con);
                cmd.Parameters.AddWithValue("@case_id", int.Parse(textBox1.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while(da.Read())
                {
                    textBox2.Text = da.GetValue(0).ToString();
                    textBox3.Text = da.GetValue(1).ToString();
                    textBox4.Text = da.GetValue(2).ToString();
                    textBox5.Text = da.GetValue(3).ToString();
                   textBox6.Text = da.GetValue(4).ToString();
                    textBox7.Text = da.GetValue(5).ToString();
                    textBox8.Text = da.GetValue(6).ToString();
                  textBox9.Text = da.GetValue(7).ToString();
                  textBox10.Text = da.GetValue(8).ToString();
                }
                con.Close();
            }
        }
    }
}
