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
    public partial class prescriptionInfo : Form
    {
        public prescriptionInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();
            string medicine = textBox1.Text + "  " + textBox2.Text;

            string time = checkBox1.Text + " + " + checkBox2.Text + " + " + checkBox3.Text;

            SqlCommand cmd1 = new SqlCommand("INSERT INTO prescription (date,id,pid,psid,medicineName,time) VALUES ('" + dateTimePicker1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox4.Text + "','" + medicine + "','" + time + "')", cn1);


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

           // showMedicine();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";
            SqlConnection cn1 = new SqlConnection(cns);

            cn1.Open();
            SqlDataAdapter sa = new SqlDataAdapter("select * from prescription", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            // dataGridView1.DataSource = data1;
            dataGridView1.DataSource = data1;
            cn1.Close(); 
            
        }

        private void prescriptionInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doctorDataSet1.prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.doctorDataSet1.prescription);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

           // string medicine = textBox1.Text + "  " + textBox2.Text + "  " +textBox3.Text;
            SqlCommand cmd1 = new SqlCommand("INSERT INTO test (date,id,pid,pcid,Test_Name) VALUES ('" + dateTimePicker1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox4.Text + "','"+textBox3.Text+ "')", cn1);


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
            SqlDataAdapter sa = new SqlDataAdapter("select * from test", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            // dataGridView1.DataSource = data1;
            dataGridView2.DataSource = data1;
            cn1.Close();
        }
    }
}
