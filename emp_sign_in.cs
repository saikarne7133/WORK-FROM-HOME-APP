﻿using MySql.Data.MySqlClient;
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
   
    public partial class emp_sign_in : Form
    {
        string b;
        public emp_sign_in()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Visible = false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new emp_log_in().Show();
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
                comm_str.CommandText = "select *from employee where email='" + this.textBox1.Text + "'  and password ='" + this.textBox2.Text + "' ";
                MySqlDataReader dr = comm_str.ExecuteReader();
                if (dr.Read())
                {


                    new emp_profile().Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
