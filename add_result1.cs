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
    public partial class add_result1 : Form
    {
        public add_result1()
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
                DataTable adt = new DataTable();
                string conn = @"server=104.155.188.152; UID=root; PASSWORD=12345;
                 database=newlab";
                //MySqlConnection dbconnection;

                using (MySqlConnection sqlcon = new MySqlConnection(conn))
                {

                    MySqlCommand cmd = new MySqlCommand("select* from bid where job_id = '" + this.textBox1.Text +"'", sqlcon);
                    sqlcon.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    adt.Load(reader);
                    if (adt.Rows.Count > 0)
                    {
                        dataGridView1.AutoGenerateColumns =true;
                        dataGridView1.DataSource =adt;

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //check the date
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
                
                MySqlCommand comm_str = new MySqlCommand();
                MySqlDataReader dr;
                comm_str.Connection = dbconnection;

                comm_str.CommandText = "(insert value )";
                dr = comm_str.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("");
                }
                dbconnection.Close();
                new final_result().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                comm_str.CommandText = "insert into result(remail,J_id) values('" + this.textBox2.Text + "','" + this.textBox1.Text + "')";
                dr = comm_str.ExecuteReader();
               


                dbconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new show_all_admin().Show();
            Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

