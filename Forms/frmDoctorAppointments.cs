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
    public partial class frmDoctorAppointments : Form
    {
        private Doctor doctor;
        public frmDoctorAppointments(Doctor doctor)
        {
            this.doctor = doctor;
            InitializeComponent();
        }

        private void frmDoctorAppointments_Load(object sender, EventArgs e)
        {
            PersonService personService = new PersonService();
            Person doctorPerson = personService.GetById(doctor.IdPerson);
            Text += $"{doctorPerson.FullName}";

            AppointmentService appointmentService = new AppointmentService();
            var appointments = appointmentService.GetByIdDoctor(doctor.IdDoctor).Where(appointment => appointment.PatientId > 0).ToList();

            dgvAppointments.DataSource = appointments;
            dgvAppointments.Columns["Id"].Visible = false;
            dgvAppointments.Columns["DoctorId"].Visible = false;
            dgvAppointments.Columns["PatientId"].Visible = false;
        }
    }
}