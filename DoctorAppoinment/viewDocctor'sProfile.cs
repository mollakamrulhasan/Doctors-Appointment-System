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
    public partial class viewDocctor_sProfile : Form
    {
        public viewDocctor_sProfile()
        {
            InitializeComponent();
        }


        void showx()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True");
            con.Open();

            SqlCommand sc = new SqlCommand("select *from doctorSchedule where id='" + textBox1.Text + "'", con);


            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    label16.Text = sdr["roomNumber"].ToString();
                    label20.Text = sdr["sat"].ToString();
                    label22.Text = sdr["sun"].ToString();
                    label21.Text = sdr["mon"].ToString();
                    label19.Text = sdr["tue"].ToString();
                    label18.Text = sdr["wed"].ToString();
                    label17.Text = sdr["thus"].ToString();
                    label15.Text = sdr["fri"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True");
            con.Open();

            SqlCommand sc = new SqlCommand("select *from doctorInfo where id='" + textBox1.Text + "' or name='"+textBox2.Text+"'", con);


         try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    textBox1.Text = sdr["id"].ToString();
                    textBox2.Text = sdr["name"].ToString();
                    textBox4.Text = sdr["qualification"].ToString();
                    textBox5.Text = sdr["designation"].ToString();
                    comboBox2.Text = sdr["department"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            showx();

        }
    }
}
