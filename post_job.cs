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
    public partial class post_job : Form
    {
        string b;
        public post_job()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
        public void email(string a)
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
               
                MySqlCommand comm_str = new MySqlCommand();
                MySqlDataReader dr;
                comm_str.Connection = dbconnection;
                comm_str.CommandText = "insert into job( jdecs,jmin,email,jtype,jend) values('" + this.textBox4.Text + "','" + this.textBox3.Text + "','" +this.textBox1.Text + "','" + this.textBox2.Text + "','" +this.textBox5.Text +"')";
                dr = comm_str.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("Added");
                }

                dr.Close();
                dbconnection.Close();
                new rec_profile().Show();
                Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new rec_profile().Show();
            Visible = false;
        }
    }

        
    }

