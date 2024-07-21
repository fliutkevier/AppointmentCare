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
    public partial class adminFrm : Form
    {
        public adminFrm()
        {
            InitializeComponent();
        }

        public void loadPatients()
        {
            PatientService patService = new PatientService();
            var lstPatients = patService.getAllPatients();
            dgvPatients.DataSource = lstPatients;
            dgvPatients.Columns["Id"].Visible = false;
            dgvPatients.Columns["HealthInsurance"].DisplayIndex = 5;
            dgvPatients.Columns["HealthInsuranceNumber"].DisplayIndex = 5;
        }

        public void loadDoctors()
        {
            DoctorService doctorService = new DoctorService();
            dgvDoctors.DataSource = doctorService.getAllDoctors();
            dgvDoctors.Columns["Id"].Visible = false;
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

            frmAddAndMod frmAdd = new frmAddAndMod();
            frmAdd.ShowDialog();
            loadPatients();
        }

        private void btnModifyPatient_Click(object sender, EventArgs e)
        {
            Patient patModify = new Patient();
            patModify = (Patient)dgvPatients.CurrentRow.DataBoundItem;

            frmAddAndMod frmAdd = new frmAddAndMod(true, patModify);
            frmAdd.ShowDialog();
            loadPatients();
        }
    }
}
