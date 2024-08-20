using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace UI
{
    public partial class frmAppointmentsMain : Form
    {
        public frmAppointmentsMain()
        {
            InitializeComponent();
        }

        private void loadAppointments()
        {
            PersonService personService = new PersonService();
            DoctorService doctorService = new DoctorService();
            AppointmentService appointmentService = new AppointmentService();

            var appointmentsList = appointmentService.GetAll();
            foreach (var appointment in appointmentsList)
            {
                Doctor doctor = doctorService.GetById(appointment.DoctorId);
                Person doctorPerson = new Person();
                doctorPerson = personService.GetById(doctor.IdPerson);
                appointment.DoctorName = doctorPerson.Name;
                appointment.DoctorLastname = doctorPerson.Lastname;
                appointment.DoctorLicense = doctorService.GetLicenseById(appointment.DoctorId);

                if (appointment.PatientId > 0)
                {
                    Person patientPerson = personService.GetById(appointment.PatientId);
                    appointment.PatientName = patientPerson.Name;
                    appointment.PatientLastname = patientPerson.Lastname;
                    appointment.PatientDni = patientPerson.Dni;
                }
            }

            dgvAppointments.DataSource = appointmentsList;
            dgvAppointments.Columns["Id"].Visible = false;
            dgvAppointments.Columns["DoctorId"].Visible = false;
            dgvAppointments.Columns["PatientId"].Visible = false;
        }

        private void frmAppointmentsMain_Load(object sender, EventArgs e)
        {
            loadAppointments();
        }

        private void btnAddAvailable_Click(object sender, EventArgs e)
        {
            frmAddAppointment frm = new frmAddAppointment();
            frm.ShowDialog();
            loadAppointments();
        }

        private void btnAssignateAppointment_Click(object sender, EventArgs e)
        {
            var appointment = new Appointment();
            frmAddAppointment frm = new frmAddAppointment(appointment);
            frm.ShowDialog();
            loadAppointments();
        }

        private void btnChangeAppointment_Click(object sender, EventArgs e)
        {
            var appointment = (Appointment)dgvAppointments.CurrentRow.DataBoundItem;
            frmAddAppointment frm = new frmAddAppointment(appointment);
            frm.ShowDialog();
            loadAppointments();
        }
    }
}
