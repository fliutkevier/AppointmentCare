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
    public partial class frmDoctorAddAndMod : Form
    {
        private Doctor doctor;
        public frmDoctorAddAndMod()
        {
            doctor = new Doctor();
            InitializeComponent();
        }
        private void frmDoctorAddAndMod_Load(object sender, EventArgs e)
        {
            SpecialityService specialityService = new SpecialityService();
            try
            {
                cbxSpeciality.DataSource = specialityService.getAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            doctor.Name = tbxName.Text;
            doctor.Lastname = tbxLastname.Text;
            doctor.Dni = tbxDni.Text;
            doctor.Address = tbxAddress.Text;
            doctor.Phone = tbxPhone.Text;
            doctor.BirthDay = DateOnly.FromDateTime(dtpBirthday.Value);
            doctor.SpecialityType = (Speciality)cbxSpeciality.SelectedItem;
            doctor.License = tbxLicense.Text;
        }

    }
}
