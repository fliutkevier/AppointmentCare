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
            AppointmentService appointmentService = new AppointmentService();
            dgvAppointments.DataSource = appointmentService.GetAll();
            dgvAppointments.Columns["Id"].Visible = false;
        }

        private void frmAppointmentsMain_Load(object sender, EventArgs e)
        {
            loadAppointments();
        }

        private void btnAddAvailable_Click(object sender, EventArgs e)
        {
            frmAddAvailableAppointment frm = new frmAddAvailableAppointment();
            frm.ShowDialog();
        }
    }
}
