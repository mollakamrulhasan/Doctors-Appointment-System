﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DoctorAppoinment
{
    public partial class dclogin : Form
    {
        public dclogin()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                SqlConnection log = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True");
                log.Open();
                SqlDataAdapter sd = new SqlDataAdapter("select count(*) from reg where username='" + textBox1.Text + "' and password='" + textBox3.Text + "'", log);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    docview dd = new docview();
                    dd.Show();

                }
                else
                {
                    MessageBox.Show("Please Check your Username & Password");
                }


            }
        }
    }
}