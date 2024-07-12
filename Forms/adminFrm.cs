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

        private void adminFrm_Load(object sender, EventArgs e)
        {
            PatientService patService = new PatientService();
            dgvPatients.DataSource = patService.getAllPatients();
        }
    }
}
