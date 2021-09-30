using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workfromhome1221
{
    public partial class rec_sign : Form
    {
        public rec_sign()
        {
            InitializeComponent();
        }

       

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string conn;
                MySqlConnection dbconnection;
                conn = @"server=104.155.188.152; UID=root; PASSWORD=12345;
                 database=newlab";
                //server= Your MySQL IP address
                //UID=user name (i.e., root) and PASSWORD=your root password
                //database= database name (i.e., lab)

                dbconnection = new MySqlConnection();
                dbconnection.ConnectionString = conn;
                dbconnection.Open();
               
                MySqlCommand comm_str = new MySqlCommand();
                MySqlDataReader dr;
                comm_str.Connection = dbconnection;
                comm_str.CommandText = "insert into recruiter(email,password,fname,lname,ssn,type) values('" + this.textBox1.Text + "','" + this.textBox6.Text + "','" + this.textBox5.Text + "','" + this.textBox4.Text + "','" + this.textBox3.Text + "','" + this.textBox2.Text + "')";
                dr = comm_str.ExecuteReader();
                while(dr.Read())
                {

                }
               
                dbconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new recuriter_sin_in().Show();
            Visible = false;
        }
    }
}
