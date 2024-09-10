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
using Service;

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
            PersonBusiness personService = new PersonBusiness();
            DoctorBusiness doctorService = new DoctorBusiness();
            PatientBusiness patientService = new PatientBusiness();
            AppointmentBusiness appointmentService = new AppointmentBusiness();

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
                    Patient patient = patientService.GetById(appointment.PatientId);
                    appointment.PatientName = patient.Name;
                    appointment.PatientLastname = patient.Lastname;
                    appointment.PatientDni = patient.Dni;
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


        private void btnCancelAppointment_Click_1(object sender, EventArgs e)
        {
            Appointment appointment = (Appointment)dgvAppointments.CurrentRow.DataBoundItem;
            if (AppointmentService.Cancel(appointment.PatientId))
            {
                MessageBox.Show("Turno cancelado, puede asignarle un nuevo paciente.", "EXITO");
            }
            else
            {
                MessageBox.Show("El turno no pudo ser cancelado.", "Warning");
            }

            loadAppointments();
        }
    }
}
