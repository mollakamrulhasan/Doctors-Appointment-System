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
    public partial class cancelAppo : Form
    {
        public cancelAppo()
        {
            InitializeComponent();
        }


        void updateCancel()
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            //SqlCommand cmd1 = new SqlCommand("update  member set Name='" + textBox2.Text + "',Height='" + textBox3.Text + "',Weight='" + textBox4.Text + "',Contact='" + textBox5.Text + "',Batch='" + comboBox4.Text + "',Member='" + comboBox5.Text + "',Workout='" + comboBox5.Text + "',Fees_mode='" + comboBox5.Text + "' where Rec_no='" + textBox1.Text + "')", cn1);

            SqlCommand cmd1 = new SqlCommand("update  ps set _date='" + dateTimePicker1.Text + "' where id='"+textBox1.Text+"' and _date='"+dateTimePicker1.Text+"'", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully edited");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to update on database");
                cn1.Close();

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            updateCancel();
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            // SqlCommand cmd1 = new SqlCommand("INSERT INTO patientserial (id,serialNumber,patientName,_date) VALUES ('" + textBox1.Text + "' , '" + textBox3.Text + "', '" + textBox4.Text + "', '" + dateTimePicker1.Text + "')", cn1);

            SqlCommand cmd1 = new SqlCommand("INSERT INTO cancelAppo (id,time,newtime) VALUES ('" + textBox1.Text + "' , '" + textBox2.Text + "','"+dateTimePicker2.Text+"'  )", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved");
            }
            catch (Exception ex)
            {
                //Error when save data

                MessageBox.Show(ex.Message);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM cancelAppo where newtime='" + dateTimePicker2.Text + "' and id='"+textBox1.Text+"'", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully remove");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to remove on database");
                cn1.Close();
            }
        }
    }
}
