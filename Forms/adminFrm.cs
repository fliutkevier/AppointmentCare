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
            dgvPatients.DataSource = patService.getAllPatients();
            dgvPatients.Columns[0].Visible = false;
            dgvPatients.Columns["HealthInsurance"].DisplayIndex = 5;
            dgvPatients.Columns["HealthInsuranceNumber"].DisplayIndex = 5;
        }

        private void adminFrm_Load(object sender, EventArgs e)
        {
            loadPatients();
        }
    }
}
