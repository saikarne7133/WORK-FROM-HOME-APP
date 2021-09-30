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
    public partial class admin_profile : Form
    {
        public admin_profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            new show_all_admin().Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new admin_page().Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new all_rec().Show();
            Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new all_emp().Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new show_job().Show();
            Visible = false;
        }
    }
}
