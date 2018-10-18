using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        string user;
        private void login_Click(object sender, EventArgs e)
        {

             
            
       }

       

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            patlogin pl = new patlogin();
            pl.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dclogin dl = new dclogin();
            dl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminlogin ad = new adminlogin();
            ad.Show();
        }
    }
}
