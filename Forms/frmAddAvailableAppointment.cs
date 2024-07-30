using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmAddAvailableAppointment : Form
    {
        public frmAddAvailableAppointment()
        {
            InitializeComponent();
        }

        private void frmAddAvailableAppointment_Load(object sender, EventArgs e)
        {
            DoctorService doctorService = new DoctorService();
            cbxDoctors.DataSource = doctorService.getLicenses();

            cbxTime.DataSource = Helper.listSchedules();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            DoctorService doctorService = new DoctorService();

            var doctorSelected = doctorService.getIdByLicense(cbxDoctors.SelectedValue.ToString());
            appointment.DoctorId = doctorSelected;

            appointment.PatientId = 0;

            DateOnly date = DateOnly.FromDateTime(dtpAppointment.Value);
            TimeOnly hour = TimeOnly.ParseExact(cbxTime.Text, "HH:mm");

            appointment.Schedule = new DateTime(date, hour);

            AppointmentService appointmentService = new AppointmentService();
            if (appointmentService.Add(appointment))
            {
                MessageBox.Show("Turno disponible agregado.");
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo cargar el tupo disponible.");
            }
        }
    }
}
