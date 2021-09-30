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
   
    public partial class biding : Form
    {
        string b;
        public biding()
        {
            InitializeComponent();
        }

        private void biding_Load(object sender, EventArgs e)
        {

        }
        public void jobid(string  a)
        {
            b = a.ToString();
            MessageBox.Show(b);
        }
        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Connect Successfully");
                MySqlCommand comm_str = new MySqlCommand();
                MySqlDataReader dr;
                comm_str.Connection = dbconnection;
                
                comm_str.CommandText = "insert into bid(job_id,bid_min,E_email) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "')";
                dr = comm_str.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Added");
                }
                dbconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
