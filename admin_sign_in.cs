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
    public partial class admin_sign_in : Form
    {
        public admin_sign_in()
        {
            InitializeComponent();
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
                comm_str.CommandText = "insert into admin(aemail,apass,afname,alname,ssn) values('" + this.textBox1.Text + "','" + this.textBox5.Text + "','" + this.textBox4.Text + "','" + this.textBox3.Text + "','" + this.textBox5.Text + "')";
                dr = comm_str.ExecuteReader();
                new admin_page().Show();

                dbconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            new admin_page().Show();
            Visible = false;
        }
    }
    }
