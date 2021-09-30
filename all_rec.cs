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
    public partial class all_rec : Form
    {
        public all_rec()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            string conn = @"server=104.155.188.152; UID=root; PASSWORD=12345;
                 database=newlab";
            //MySqlConnection dbconnection;

            using (MySqlConnection sqlcon = new MySqlConnection(conn))
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * from recruiter", sqlcon);
                sqlcon.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;


                }
            }
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
                MySqlCommand comm_str1 = new MySqlCommand();
                MySqlDataReader dr;
                comm_str.Connection = dbconnection;

                comm_str.CommandText = "insert into block_rec(remail, reason) values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "')";
                dr = comm_str.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Added");
                }


              

                dbconnection.Close();

                new admin_profile().Show();
                Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new admin_profile().Show();
            Visible = false;
        }
    }
}
