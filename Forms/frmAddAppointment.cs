using Business;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmAddAppointment : Form
    {
        private bool modify = false;
        private DateTime[] availableDatesAndTime;
        private Appointment appointmentToAssign;
        private List<Doctor> doctors;
        private List<Patient> patients;
        private List<Speciality> specialities;
        private DoctorBusiness doctorService;
        private PatientBusiness patientService;
        public frmAddAppointment()
        {
            appointmentToAssign = new Appointment();
            InitializeComponent();
        }

        public frmAddAppointment(Appointment appointmentCharged)
        {
            modify = true;
            appointmentToAssign = appointmentCharged;
            InitializeComponent();
        }

        private void frmAddAvailableAppointment_Load(object sender, EventArgs e)
        {
            SpecialityBusiness specialityService = new SpecialityBusiness();
            PersonBusiness personService = new PersonBusiness();
            patientService = new PatientBusiness();
            doctorService = new DoctorBusiness();
            specialities = specialityService.getAll();
            doctors = doctorService.GetAll();
            patients = patientService.GetAll();

            mcAppointmentDate.MaxSelectionCount = 1;

            //CARGA DE CBX DE ESPECIALIDADES
            cbxSpeciality.DataSource = specialities;
            cbxSpeciality.ValueMember = "Id";
            cbxSpeciality.DisplayMember = "Description";
            
            //CARGA DE CBX DE DOCTORES
            cbxDoctors.DataSource = doctors;
            //cbxDoctors.DataSource = doctors.Select(doctor => new { doctor.FullName, doctor.License }).ToList();
            cbxDoctors.ValueMember = "IdDoctor";
            cbxDoctors.DisplayMember = "FullName";


            if (modify)
            {
                //CARGA DE CBX DE PACIENTES
                cbxPatient.DataSource = patients;
                cbxPatient.ValueMember = "IdPatient";
                cbxPatient.DisplayMember = "FullName";

                if (appointmentToAssign.PatientId > 0)
                {
                    Text = "Modificando Turno";

                    //SE CARGA TODO PARA COMPLETAR LA MODIFICACION
                    cbxSpeciality.SelectedValue = doctors.First(doctor => doctor.License == appointmentToAssign.DoctorLicense).SpecialityType.Id;
                    cbxDoctors.SelectedValue = appointmentToAssign.DoctorId;
                    cbxPatient.SelectedValue = appointmentToAssign.PatientId;
                    cbxTime.SelectedValue = appointmentToAssign.Schedule.TimeOfDay;
                    loadDatesAndTimes();
                    mcAppointmentDate.SelectionStart = appointmentToAssign.Schedule.Date;

                }
                else
                {
                    Text = "Asignando Turno";
                    cbxDoctors.Enabled = false;
                    cbxDoctors.SelectedIndex = -1;

                    mcAppointmentDate.Enabled = false;

                    cbxTime.Enabled = false;
                    cbxTime.SelectedIndex = -1;

                    btnFindDates.Enabled = false;
                }    
            }
            else
            {
                cbxSpeciality.SelectedIndex = -1;
                cbxDoctors.SelectedIndex = -1;
                cbxPatient.Enabled = false;
                cbxPatient.Visible = false;
                lblPatient.Visible = false;

                cbxTime.DataSource = Helper.listSchedules();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AppointmentBusiness appointmentService = new AppointmentBusiness();
            DateOnly date = DateOnly.FromDateTime(mcAppointmentDate.SelectionStart);
            TimeOnly hour = TimeOnly.ParseExact(cbxTime.Text, "HH:mm");
            appointmentToAssign.Schedule = new DateTime(date, hour);
            appointmentToAssign.DoctorId = (int)cbxDoctors.SelectedValue;

            if (modify)
            {
                if (appointmentToAssign.PatientId > 0)
                {
                    //MODIFICACIÓN DEL TURNO.
                    appointmentToAssign.PatientId = (int)cbxPatient.SelectedValue;
                    if (appointmentService.Modify(appointmentToAssign))
                    {
                        MessageBox.Show("Turno modificado exitosamente.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el turno.");
                    }
                }
                else
                {
                    //ASIGNACIÓN DEL TURNO.
                    appointmentToAssign.PatientId = (int)cbxPatient.SelectedValue;
                    appointmentToAssign.Id = appointmentService.GetId(appointmentToAssign.DoctorId, 0, appointmentToAssign.Schedule);

                    if (appointmentService.Modify(appointmentToAssign))
                    {
                        MessageBox.Show("Turno Asigando exitosamente.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo asignar el turno.");
                    }
                }
            }
            else
            {
                //CREACIÓN DEL TURNO SIN PACIENTE.
                appointmentToAssign.PatientId = 0;

                if (appointmentService.Add(appointmentToAssign))
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

        private void cbxSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSpeciality.SelectedIndex > -1)
            {
                Speciality speciality = (Speciality)cbxSpeciality.SelectedItem;
                cbxDoctors.DataSource = doctors.Where(x => x.SpecialityType.Id == speciality.Id).ToList();
                cbxDoctors.ValueMember = "IdDoctor";
                cbxDoctors.DisplayMember = "FullName";

                cbxDoctors.Enabled = true;
                //cbxDoctors.SelectedIndex = -1;
            }
            else
            {
                cbxDoctors.Enabled = false;
            }
        }

        private void loadDatesAndTimes()
        {
            AppointmentBusiness appointmentService = new AppointmentBusiness();
            Doctor doctorSelected = (Doctor)cbxDoctors.SelectedItem;
            List<Appointment> appointmentsDoctor = appointmentService.GetByIdDoctor(doctorSelected.IdDoctor);

            availableDatesAndTime = appointmentsDoctor.Select(appointment => appointment.Schedule).ToArray();
        }

        private void btnFindDates_Click(object sender, EventArgs e)
        {
            if (cbxDoctors.SelectedIndex > -1)
            {
                mcAppointmentDate.Enabled = true;
                loadDatesAndTimes();

                mcAppointmentDate.BoldedDates = availableDatesAndTime.Select(date => date.Date).ToArray();
            }
        }

        private void mcAppointmentDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            if(modify && availableDatesAndTime != null)
            {
                if (availableDatesAndTime.Select(date => date.Date).Contains(mcAppointmentDate.SelectionStart.Date))
                {
                    cbxTime.Enabled = true;
                    cbxTime.DataSource = availableDatesAndTime.Where(date => date.Date == mcAppointmentDate.SelectionStart.Date)
                        .Select(date => date.ToString("HH:mm"))
                        .ToList();
                }
            }
        }

        private void cbxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDoctors.SelectedIndex > -1)
            {
                btnFindDates.Enabled = true;
            }
        }
    }
}
