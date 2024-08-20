using UI;

namespace Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPatientsDoctors_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            frm.ShowDialog();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            frmDoctorLogin frm = new frmDoctorLogin();
            frm.ShowDialog();
        }

        private void btnAppointmentSection_Click(object sender, EventArgs e)
        {
            frmAppointmentsMain frm = new frmAppointmentsMain();
            frm.ShowDialog();
        }
    }
}
