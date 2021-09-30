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
    public partial class emp_profile : Form
    {
        public emp_profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new show_bid().Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new emp_sign_in().Show();
            Visible = false;
        }
    }
}
