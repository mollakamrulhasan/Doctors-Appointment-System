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
    public partial class docview : Form
    {
        public docview()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doctorInfo d = new doctorInfo();
            d.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewDocctor_sProfile sh = new viewDocctor_sProfile();
            sh.Show();
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prescriptionInfo p = new prescriptionInfo();
            p.Show();
        }

        private void viewPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewPrescription sh = new viewPrescription();
            sh.Show();
        }

        private void updatePrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prescriptionUpdate sh = new prescriptionUpdate();
            sh.Show();
        }

        private void addScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctoeSchedule d = new doctoeSchedule();
            d.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            patientSerial p = new patientSerial();
            p.Show();
        }

        private void viewAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAppointment sh = new viewAppointment();
            sh.Show();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancelAppo sh = new cancelAppo();
            sh.Show();
        }

        private void viewCancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewcancelAppo sh = new viewcancelAppo();
            sh.Show();
        }
    }
}
