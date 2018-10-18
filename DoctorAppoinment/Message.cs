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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True");
            con.Open();

            SqlCommand sc = new SqlCommand("select *from PatientInfo where pid='" + textBox1.Text + "'", con);


            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    textBox2.Text = sdr["phoneNo"].ToString();
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
              //login = new NetworkCredential(textBox4.Text, textBox6.Text);
            //client = new SmtpClient(textBox8.Text);
            //client.Port = Convert.ToInt32(textBox7.Text);
            //client.EnableSsl = checkBox1.Checked;
            //client.Credentials = login;
           //msg=new
           // msg = new Message{From(textBox4.Text + textBox8.Text.Replace("smtp.", "@"), "Lucy", Encoder.UTF8) };

           // textBox7= "578";
            //Message  = new Message(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text);
            //SmtpClient client = new SmtpClient(textBox8.Text);
            //client.Port = 578;
            //client.Credentials = new System.Net.NetworkCredential(textBox4.Text, textBox6.Text);
            //client.EnableSsl = true;
            ////try
            ////{
            //    client.Send(mail);
            //    MessageBox.Show("Message Send", "Success", MessageBoxButtons.OK);
            ////}
            //catch
            //{
            //    MessageBox.Show("error");
            //}


             
             
        }
    }
}
