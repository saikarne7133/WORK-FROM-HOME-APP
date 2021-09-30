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
    public partial class rec_profile : Form
    {
        public rec_profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new post_job().Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            string conn = @"server=104.155.188.152; UID=root; PASSWORD=12345;
                 database=newlab";
            //MySqlConnection dbconnection;

            using (MySqlConnection sqlcon = new MySqlConnection(conn))
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * from job ", sqlcon);
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

        private void button3_Click(object sender, EventArgs e)
        {
            new recuriter_sin_in().Show();
            Visible = false;
        }
    }
}
