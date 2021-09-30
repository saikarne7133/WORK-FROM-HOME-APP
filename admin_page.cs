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
    public partial class admin_page : Form
    {
        public admin_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new admin_sign_in().Show();
            Visible = false;
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

                dbconnection = new MySqlConnection
                {
                    ConnectionString = conn
                };
                dbconnection.Open();
               
                MySqlCommand comm_str = new MySqlCommand();

                comm_str.Connection = dbconnection;
                comm_str.CommandText = "select *from admin where aemail='" + this.textBox1.Text + "'  and apass='" + this.textBox2.Text + "' ";
                MySqlDataReader dr = comm_str.ExecuteReader();
                if (dr.Read())
                {
                   
                    new admin_profile().Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid password and id");

                }
                dbconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void admin_page_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new admin_key().Show();
            Visible = false;
        }
    }
    }

