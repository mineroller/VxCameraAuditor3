using System;
using System.Windows.Forms;

namespace VxCameraAuditor3
{
    public partial class frmNewPassword : Form
    {
        public string newpassword { get; set; }

        public frmNewPassword()
        {
            InitializeComponent();
            btnResetPwdOK.Enabled = false;
        }

        private void btnResetPwdOK_Click(object sender, EventArgs e)
        {
            newpassword = txtNewPassword.Text;
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Length < 8)
            {
                btnResetPwdOK.Enabled = false;
            }
            else
            {
                btnResetPwdOK.Enabled = true;
            }
        }
    }
}
