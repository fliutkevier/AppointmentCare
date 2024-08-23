using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Domain;

namespace UI
{
    public partial class frmAdmin : Form
    {
        private Patient patient;
        public frmAdmin()
        {
            InitializeComponent();
        }

        public void loadPatients()
        {
            PatientService patService = new PatientService();
            dgvPatients.DataSource = patService.getAllPatients();
            dgvPatients.Columns["IdPatient"].Visible = false;
            dgvPatients.Columns["IdPerson"].Visible = false;
            dgvPatients.Columns["FullName"].Visible = false;
            dgvPatients.Columns["HealthInsurance"].DisplayIndex = 5;
            dgvPatients.Columns["HealthInsuranceNumber"].DisplayIndex = 5;
        }

        public void loadDoctors()
        {
            DoctorService doctorService = new DoctorService();
            dgvDoctors.DataSource = doctorService.GetAll();
            dgvDoctors.Columns["IdPerson"].Visible = false;
            dgvDoctors.Columns["IdDoctor"].Visible = false;
            dgvDoctors.Columns["FullName"].Visible = false;
            dgvDoctors.Columns["License"].DisplayIndex = 5;
            dgvDoctors.Columns["SpecialityType"].DisplayIndex = 5;
        }

        private void adminFrm_Load(object sender, EventArgs e)
        {
            loadPatients();
            loadDoctors();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmPatientAddAndMod frmAdd = new frmPatientAddAndMod();
            frmAdd.ShowDialog();
            loadPatients();
        }

        private void btnModifyPatient_Click(object sender, EventArgs e)
        {
            patient = (Patient)dgvPatients.CurrentRow.DataBoundItem;

            frmPatientAddAndMod frmAdd = new frmPatientAddAndMod(true, patient);
            frmAdd.ShowDialog();
            loadPatients();
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            patient = (Patient)dgvPatients.CurrentRow.DataBoundItem;
            PatientService patientService = new PatientService();
            DialogResult yesOrNo = MessageBox.Show("¿Está seguro que desea eliminar este paciente?", "ELIMINACIÓN...", MessageBoxButtons.YesNo);
            if (yesOrNo == DialogResult.Yes)
            {
                if (patientService.Delete(patient))
                {
                    MessageBox.Show("Paciente eliminado.");
                    loadPatients();
                }
                else
                {
                    MessageBox.Show("No fue posible eliminar este paciente.");
                }
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            frmDoctorAddAndMod frmAdd = new frmDoctorAddAndMod(doctor);
            frmAdd.ShowDialog();
            loadDoctors();
        }

        private void btnModifyDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = (Doctor)dgvDoctors.CurrentRow.DataBoundItem;
            frmDoctorAddAndMod frmAdd = new frmDoctorAddAndMod(doctor);
            frmAdd.ShowDialog();
            loadDoctors();
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = (Doctor)dgvDoctors.CurrentRow.DataBoundItem;
            DoctorService doctorService = new DoctorService();
            DialogResult yesOrNo = MessageBox.Show("¿Está seguro que desea eliminar este doctor?", "ELIMINACIÓN...", MessageBoxButtons.YesNo);
            if (yesOrNo == DialogResult.Yes)
            {
                try
                {
                    if (doctorService.Delete(doctor))
                    {
                        MessageBox.Show("Doctor eliminado.");
                        loadDoctors();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible eliminar este Doctor.");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
