using UI;

namespace Forms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminFrm frm = new adminFrm();
            frm.ShowDialog();

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            frmAppointmentsMain frm = new frmAppointmentsMain();
            frm.ShowDialog();
        }
    }
}
