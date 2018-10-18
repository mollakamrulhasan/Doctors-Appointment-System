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
    public partial class patientSerial : Form
    {
        public patientSerial()
        {
            InitializeComponent();
        }
        string type;
        private void label1_Click(object sender, EventArgs e)
        {

        }


        int checkk()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True");
            con.Open();


            string qry = "select sum(maxAppo) from doctorInfo where id='" + textBox1.Text + "'";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();
            return a;
          //  string zz = a.ToString();
           /// MessageBox.Show(zz);
        }


       int checkid()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True");
            con.Open();


            string qry = "select count(id) from ps where id='"+textBox1.Text+"' and _date='"+dateTimePicker1.Text+"'";
            SqlCommand sc = new SqlCommand(qry, con);
            int a = 0 + (Int32)sc.ExecuteScalar();
            a = a+1;
          string zz=  a.ToString();
            textBox3.Text = zz;
            return a;
          //  MessageBox.Show(a.ToString());


        }

        private void save_Click(object sender, EventArgs e)
        {
            checkid();
            int xx=checkid()-1;
            int z = checkk();
            if (z > xx)
            {

                string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

                SqlConnection cn1 = new SqlConnection(cns);
                cn1.Open();

                // SqlCommand cmd1 = new SqlCommand("INSERT INTO patientserial (id,serialNumber,patientName,_date) VALUES ('" + textBox1.Text + "' , '" + textBox3.Text + "', '" + textBox4.Text + "', '" + dateTimePicker1.Text + "')", cn1);

                SqlCommand cmd1 = new SqlCommand("INSERT INTO ps (_date,id,serialNum,patientName) VALUES ('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "' )", cn1);


                try
                {
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Successfully Saved");
                    
                }
                catch (Exception ex)
                {
                    //Error when save data

                    MessageBox.Show(ex.Message);
                    cn1.Close();


                }

                if (type == "New")
                {
                    patientinfo p = new patientinfo();
                    p.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Schedule limit reached for today. ");
            }


        }

        private void check_Click(object sender, EventArgs e)
        {
            //checkk();
            //checkid();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = "New";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type = "Old";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkk();
            checkid();
        }
    }
}
