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
    public partial class frmDoctorLogin : Form
    {
        public frmDoctorLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoctorBusiness doctorService = new DoctorBusiness();
            int id;
            if ((id = doctorService.getIdByLicense(tbxLicense.Text)) > 0)
            {
                frmDoctorAppointments frm = new frmDoctorAppointments(doctorService.GetById(id));
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("La licencia ingresada no es válida o no existe.", "Warning");
            }
        }
    }
}
