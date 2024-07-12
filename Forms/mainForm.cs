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
    }
}
