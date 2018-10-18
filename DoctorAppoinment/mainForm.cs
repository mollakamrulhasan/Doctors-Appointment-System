using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoctorAppoinment
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           prescriptionInfo p = new prescriptionInfo();
            p.Show();
        }

        private void addScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctoeSchedule d = new doctoeSchedule();
            d.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doctorInfo d = new doctorInfo();
            d.Show();
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            patientinfo p = new patientinfo();
            p.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewDocctor_sProfile sh = new viewDocctor_sProfile();
            sh.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viewPatientInfo sh = new viewPatientInfo();
          sh.Show();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            viewcancelAppo sh= new viewcancelAppo();
            sh.Show();
        }

        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Message sh = new Message();
            sh.Show();
        }

        private void viewPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewPrescription sh = new viewPrescription();
            sh.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewPrescriptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Phermacy sh = new Phermacy();
            sh.Show();
        }

        private void updatePrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prescriptionUpdate sh = new prescriptionUpdate();
            sh.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration rr = new Registration();
            rr.Show();
        }

        private void mailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            email ee = new email();
            ee.Show();
        }
    }
}
