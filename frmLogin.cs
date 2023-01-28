namespace DigifyIntegratedSolutions
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pnlUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void pnlPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }
    }
}