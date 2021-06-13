using System;
using System.Windows.Forms;

namespace VxCameraAuditor3
{
    public partial class frmEditCameraInfo : Form
    {
        public int newcamnumber { get; set; }
        public string newcamname { get; set; }

        public frmEditCameraInfo(int _number, string _name)
        {
            InitializeComponent();
            txtNewCamNumber.Text = _number.ToString();
            txtNewCamName.Text = _name;
                        
        }

        private void btnEditOK_Click(object sender, EventArgs e)
        {
            int _na;
            bool isNumberInt = int.TryParse(txtNewCamNumber.Text, out _na);
            if (isNumberInt == false)
            {
                MessageBox.Show("Please check your camera number format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                
            }
            else
            {
                newcamnumber = _na;
                newcamname = txtNewCamName.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
