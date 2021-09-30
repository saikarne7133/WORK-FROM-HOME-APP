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
    public partial class show_all_admin : Form
    {
        public show_all_admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                comm_str.CommandText = "select * from job where jid = '" + this.textBox1.Text + "' and  jend <= CURDATE()";
                dr = comm_str.ExecuteReader();
                if(dr.Read())
                {
                    new add_result1().Show();
                    Visible = false;

                }
                else
                {
                    MessageBox.Show("Bid is in process");
                    new admin_profile().Show();
                    Visible = false;
                    
                }
                

                dbconnection.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string conn = @"server=104.155.188.152; UID=root; PASSWORD=12345;
                 database=newlab";
            //MySqlConnection dbconnection;

            using (MySqlConnection sqlcon = new MySqlConnection(conn))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * from bid", sqlcon);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
