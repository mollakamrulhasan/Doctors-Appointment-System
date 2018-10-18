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
    public partial class doctorInfo : Form
    {
        public doctorInfo()
        {
            InitializeComponent();
        }

        private void doctorInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO doctorInfo (id,name,gender,qualification,designation,department,mail,contact,contactserial,maxAppo) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', '" + comboBox1.Text + "','" + textBox4.Text + "', '" + textBox5.Text + "', '" + comboBox2.Text + "', '" + textBox6.Text + "', '" + textBox3.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "')", cn1);


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

        private void button2_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();


            SqlCommand cmd1 = new SqlCommand("update  doctorInfo set qualification='" + textBox4.Text + "',designation='" + textBox5.Text + "',mail='" + textBox6.Text + "',contact='" + textBox3.Text + "',contactserial='" + textBox7.Text + "',maxAppo='" + textBox8.Text + "' where id= '" + textBox1.Text + "' ", cn1);


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

        private void button3_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(cns);

            cn1.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select *from doctorInfo", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            // dataGridView1.DataSource = data1;
            dataGridView1.DataSource = data1;
            cn1.Close();  
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM doctorInfo where id='" + textBox1.Text + "'", cn1);


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

        private void button5_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(cns);

            cn1.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from doctorInfo where id='" + textBox1.Text + "' or name='"+textBox2.Text+"' ", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            // dataGridView1.DataSource = data1;
            dataGridView1.DataSource = data1;
            cn1.Close();
        }
    }
}
