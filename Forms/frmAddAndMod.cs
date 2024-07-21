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
    public partial class frmAddAndMod : Form
    {
        private bool isModifying;
        private Patient patCharged = null!;
        public frmAddAndMod()
        {
            InitializeComponent();
        }

        public frmAddAndMod(bool isModifying, Patient patientCharged)
        {
            patCharged = patientCharged;
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
            }
            catch (Exception)
            {

                throw;
            }
            if (isModifying)
            {
                lblTitle.Text = "Modificando";
                Text = "Modificando...";
                tbxName.Text = patCharged.Name;
                tbxLastname.Text = patCharged.Lastname;
                tbxDni.Text = patCharged.Dni;
                tbxAddress.Text = patCharged.Address;
                tbxHealthInsuranceNumber.Text = patCharged.HealthInsuranceNumber;
                tbxPhone.Text = patCharged.Phone;
                dtpBirthday.Value = patCharged.BirthDay.ToDateTime(TimeOnly.MinValue);
                cbxHealthInsurance.SelectedItem = patCharged.HealthInsurance.Id;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int isNumber;
            if(!int.TryParse(tbxDni.Text, out isNumber))
            {
                MessageBox.Show("Dni invalido.", "ERROR", MessageBoxButtons.OK);
            }

            Patient pat = new Patient();
            pat.Name = tbxName.Text;
            pat.Lastname = tbxLastname.Text;
            pat.Dni = tbxDni.Text;
            pat.Address = tbxAddress.Text;
            pat.Phone = tbxPhone.Text;
            pat.BirthDay = DateOnly.FromDateTime(dtpBirthday.Value);
            pat.HealthInsurance = (HealthInsurance)cbxHealthInsurance.SelectedItem;
            pat.HealthInsuranceNumber = tbxHealthInsuranceNumber.Text;

            PatientService patService = new PatientService();
            if (isModifying)
            {
                if (patService.ModifyPatient(pat))
                {
                    MessageBox.Show("Paciente modificado con exito.");
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el paciente, revise bien los datos cargados");
                }
            }
            if (patService.addPatient(pat))
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
