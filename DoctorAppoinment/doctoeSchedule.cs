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
    public partial class doctoeSchedule : Form
    {
        public doctoeSchedule()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO doctorSchedule (id,name,roomnumber,sat,sun,mon,tue,wed,thus,fri) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "','" + textBox9.Text + "','"+textBox10.Text+"')", cn1);


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
            SqlDataAdapter sa = new SqlDataAdapter("select *from DoctorSchedule", cn1);
            DataTable data1 = new DataTable();
            sa.Fill(data1);
            // dataGridView1.DataSource = data1;
            dataGridView1.DataSource = data1;
            cn1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";
  
            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            //SqlCommand cmd1 = new SqlCommand("update  member set Name='" + textBox2.Text + "',Height='" + textBox3.Text + "',Weight='" + textBox4.Text + "',Contact='" + textBox5.Text + "',Batch='" + comboBox4.Text + "',Member='" + comboBox5.Text + "',Workout='" + comboBox5.Text + "',Fees_mode='" + comboBox5.Text + "' where Rec_no='" + textBox1.Text + "')", cn1);

            SqlCommand cmd1 = new SqlCommand("update  doctorSchedule set Name='" + textBox2.Text + "',roomNumber='" + textBox3.Text + "',sat='" + textBox4.Text + "',sun='" + textBox5.Text + "',mon='" + textBox6.Text + "',tue='" + textBox7.Text + "',wed='" + textBox8.Text + "',thus='" + textBox9.Text + "',fri='" + textBox10.Text + "'  where id='" + textBox1.Text + "'", cn1);


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

        private void doctoeSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
