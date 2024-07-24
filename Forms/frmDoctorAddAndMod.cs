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
        public frmDoctorAddAndMod(Doctor doctor)
        {
            this.doctor = doctor;
            InitializeComponent();
        }
        private void frmDoctorAddAndMod_Load(object sender, EventArgs e)
        {
            SpecialityService specialityService = new SpecialityService();
            try
            {
                cbxSpeciality.DataSource = specialityService.getAll();
                cbxSpeciality.ValueMember = "Id";
                cbxSpeciality.DisplayMember = "Description";
                if (doctor.IdPerson > 0)
                {
                    tbxName.Text = doctor.Name;
                    tbxLastname.Text = doctor.Lastname;
                    tbxDni.Text = doctor.Dni;
                    tbxAddress.Text = doctor.Address;
                    tbxPhone.Text = doctor.Phone;
                    tbxLicense.Text = doctor.License;
                    dtpBirthday.Value = doctor.BirthDay.ToDateTime(TimeOnly.MinValue);
                    cbxSpeciality.SelectedValue = doctor.SpecialityType.Id;
                }
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

            DoctorService doctorService = new DoctorService();

            if (doctor.IdDoctor > 0)
            {
                if (doctorService.Modify(doctor))
                {
                    MessageBox.Show("Doctor modificado.", "Estado.", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("NO SE PUDO MODIFICAR AL DOCTOR, revise los datos ingresados.", "ERROR.", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (doctorService.Add(doctor))
                {
                    MessageBox.Show("Doctor agregado.", "Estado.", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("NO SE PUDO AGREGAR AL DOCTOR, revise los datos ingresados.", "ERROR.", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
