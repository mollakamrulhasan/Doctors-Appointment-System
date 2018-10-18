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
    public partial class patintview : Form
    {
        public patintview()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            patientinfo p = new patientinfo();
            p.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewPatientInfo sh = new viewPatientInfo();
            sh.Show();
        }

        private void viewPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewPrescription sh = new viewPrescription();
            sh.Show();
        }

        private void viewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAppointment sh = new viewAppointment();
            sh.Show();
        }

        private void viewCancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewcancelAppo sh = new viewcancelAppo();
            sh.Show();
        }

        private void viewPrescriptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Phermacy sh = new Phermacy();
            sh.Show();
        }
    }
}
