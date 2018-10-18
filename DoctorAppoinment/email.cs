using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
namespace DoctorAppoinment
{
    public partial class email : Form
    {

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //login = new NetworkCredential(textBox4.Text, textBox6.Text);
            //client = new SmtpClient(textBox8.Text);
            //client.Port = Convert.ToInt32(textBox7.Text);
            //client.EnableSsl = checkBox1.Checked;
            //client.Credentials = login;
            //msg=new
            // msg = new MailMessage{From(textBox4.Text + textBox8.Text.Replace("smtp.", "@"), "Lucy", Encoder.UTF8) };

            // textBox7= "578";
            MailMessage mail = new MailMessage(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text);
            SmtpClient client = new SmtpClient(textBox8.Text);
            client.Port = 578;
            client.Credentials = new System.Net.NetworkCredential(textBox4.Text, textBox6.Text);
            client.EnableSsl = true;
            //try
            //{
            client.Send(mail);
            MessageBox.Show("Mail Send", "Success", MessageBoxButtons.OK);
            //}
            //catch
            //{
            //    MessageBox.Show("error");
            //}
        }
    }
}
