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
    public partial class prescriptionUpdate : Form
    {
        public prescriptionUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            string medicine = textBox5.Text + "  " + textBox4.Text;

            string time = checkBox1.Text + " + " + checkBox2.Text + " + " + checkBox3.Text;

            SqlCommand cmd1 = new SqlCommand("INSERT INTO prescription (date,id,pid,psid,medicineName,time) VALUES ('" + dateTimePicker1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox1.Text + "','" + medicine + "','" + time + "')", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                cn1.Close();


            }
        }

        private void deletemedcine_Click(object sender, EventArgs e)
        {

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();


            SqlCommand cmd1 = new SqlCommand("delete  from prescription where date='" + dateTimePicker1.Text + "'and id='" + textBox7.Text + "'and pid='" + textBox6.Text + "' and psid='" + textBox1.Text + "'", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("delete medicine");
            }
            catch(Exception  ex)
            {
                //Error when save data

                MessageBox.Show(ex.Message);
                cn1.Close();


            }
        }

        private void deltetest_Click(object sender, EventArgs e)
        {

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();


            SqlCommand cmd1 = new SqlCommand("delete  from test where date='" + dateTimePicker1.Text + "'and id='" + textBox7.Text + "'and pid='" + textBox6.Text + "'and pcid='" + textBox1.Text + "'", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("delete Test");
            }
            catch (Exception ex)
            {
                //Error when save data

                MessageBox.Show(ex.Message);
                cn1.Close();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(cns);

            cn1.Open();
            try
            {
                SqlDataAdapter sa = new SqlDataAdapter("select * from prescription where date='" + dateTimePicker1.Text + "'and id='" + textBox7.Text + "'and pid='" + textBox6.Text + "' and psid='" + textBox1.Text + "'", cn1);
                DataTable data1 = new DataTable();
                sa.Fill(data1);
                // dataGridView1.DataSource = data1;
                dataGridView1.DataSource = data1;
                cn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();


            SqlCommand cmd1 = new SqlCommand("INSERT INTO test (date,id,pid,pcid,Test_Name) VALUES ('" + dateTimePicker1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox1.Text + "','" + textBox3.Text + "')", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved test");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                cn1.Close();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(cns);

            cn1.Open();
            try
            {
                SqlDataAdapter sa = new SqlDataAdapter("select * from test where date='" + dateTimePicker1.Text + "'and id='" + textBox7.Text + "'and pid='" + textBox6.Text + "'and pcid='" + textBox1.Text + "'", cn1);
                DataTable data1 = new DataTable();
                sa.Fill(data1);
                // dataGridView1.DataSource = data1;
                dataGridView2.DataSource = data1;
                cn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        
    }
}
