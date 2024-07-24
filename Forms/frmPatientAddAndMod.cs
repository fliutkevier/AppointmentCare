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
    public partial class frmPatientAddAndMod : Form
    {
        private bool isModifying;
        private Patient patient = null!;
        public frmPatientAddAndMod()
        {
            patient = new Patient();
            InitializeComponent();
        }

        public frmPatientAddAndMod(bool isModifying, Patient patientCharged)
        {
            patient = patientCharged;
            this.isModifying = isModifying;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            HealthInsuranceService hIServ = new HealthInsuranceService();
            try
            {
                cbxHealthInsurance.DataSource = hIServ.getAllInsurances();
                cbxHealthInsurance.ValueMember = "Id";
                cbxHealthInsurance.DisplayMember = "Provider";
            }
            catch (Exception)
            {
                throw;
            }
            if (patient.IdPerson > 0)
            {
                lblTitle.Text = "Modificando";
                Text = "Modificando...";
                tbxName.Text = patient.Name;
                tbxLastname.Text = patient.Lastname;
                tbxDni.Text = patient.Dni;
                tbxAddress.Text = patient.Address;
                tbxHealthInsuranceNumber.Text = patient.HealthInsuranceNumber;
                tbxPhone.Text = patient.Phone;
                dtpBirthday.Value = patient.BirthDay.ToDateTime(TimeOnly.MinValue);
                
                cbxHealthInsurance.SelectedValue = patient.HealthInsurance.Id;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Helper.IsOnlyNumber(tbxDni.Text))
            {
                MessageBox.Show("Dni invalido.", "ERROR", MessageBoxButtons.OK);
            }

            if (patient.IdPerson <= 0)
            {
                patient = new Patient();
            }

            patient.Name = tbxName.Text;
            patient.Lastname = tbxLastname.Text;
            patient.Dni = tbxDni.Text;
            patient.Address = tbxAddress.Text;
            patient.Phone = tbxPhone.Text;
            patient.BirthDay = DateOnly.FromDateTime(dtpBirthday.Value);
            patient.HealthInsurance = (HealthInsurance)cbxHealthInsurance.SelectedItem;
            patient.HealthInsuranceNumber = tbxHealthInsuranceNumber.Text;

            PatientService patService = new PatientService();
            if (isModifying)
            {
                if (patService.ModifyPatient(patient))
                {
                    MessageBox.Show("Paciente modificado con exito.");
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar al paciente, revise bien los datos cargados.");
                }
            }
            else if (patService.addPatient(patient))
            {
                MessageBox.Show("Paciente cargado con exito.");
                Close();
            }
            else
            {
                MessageBox.Show("No se pudo cargar el paciente, revise bien los datos cargados");
                
            }
        }
    }
}
