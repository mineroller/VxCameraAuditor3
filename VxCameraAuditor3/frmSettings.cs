using System;
using System.Windows.Forms;

namespace VxCameraAuditor3
{
    public partial class frmSettings : Form
    {
        public bool SettingSaved { get; set; }

        public frmSettings()
        {
            InitializeComponent();

            chkShowPass.Checked = false;
            try
            {
                loadPreviousSettings();
            }
            catch
            {
                MessageBox.Show("There was an error while loading application settings.\nThis is normal if this is first time run.\n\nDefault values will be created.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                setDefaultSettings();
                loadPreviousSettings();
            }
            finally
            {
                SettingSaved = false;
            }
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            if (VUStringHelper.ValidateIP(txtCoreAddr.Text))
            {
                Properties.Settings.Default.vxCore = txtCoreAddr.Text;
            }
            else
            {
                MessageBox.Show("Core's IP Address appears to be incorrect format.\nPlease fix and retry", "Invalid IP Format", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Properties.Settings.Default.vxAdmin = txtVxAdmin.Text;
            Properties.Settings.Default.vxPass = VUStringHelper.Encode(txtVxPass.Text);
            Properties.Settings.Default.vxsUser = txtVxsUser.Text;
            Properties.Settings.Default.vxsPass = VUStringHelper.Encode(txtVxsPass.Text);
            Properties.Settings.Default.vxsPort = txtVxsPort.Text;
            Properties.Settings.Default.Save();

            SettingSaved = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked == true)
            {
                txtVxPass.UseSystemPasswordChar = false;
                txtVxsPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtVxPass.UseSystemPasswordChar = true;
                txtVxsPass.UseSystemPasswordChar = true;
            }

        }

        private void btnSettingCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            setDefaultSettings();
            loadPreviousSettings();
        }
        private void loadPreviousSettings()
        {
            txtCoreAddr.Text = Properties.Settings.Default.vxCore;
            txtVxAdmin.Text = Properties.Settings.Default.vxAdmin;
            txtVxPass.Text = VUStringHelper.Decode(Properties.Settings.Default.vxPass);

            txtVxsUser.Text = Properties.Settings.Default.vxsUser;
            txtVxsPass.Text = VUStringHelper.Decode(Properties.Settings.Default.vxsPass);
            txtVxsPort.Text = Properties.Settings.Default.vxsPort;
        }

        private void setDefaultSettings()
        {
            Properties.Settings.Default.vxCore = "192.168.5.10";
            Properties.Settings.Default.vxAdmin = "admin";
            Properties.Settings.Default.vxPass = VUStringHelper.Encode("pel2899100");
            Properties.Settings.Default.vxsUser = "admin";
            Properties.Settings.Default.vxsPass = VUStringHelper.Encode("admin");
            Properties.Settings.Default.vxsPort = "9091";
            Properties.Settings.Default.Save();
        }

    }
}

