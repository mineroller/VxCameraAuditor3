using System;
using System.Windows.Forms;
using System.Collections.Generic;
using FileHelpers;
using System.Linq;
using System.Text;

namespace VxCameraAuditor3
{
    public partial class frmImportUserCSV : Form
    {
        public frmImportUserCSV()
        {
            InitializeComponent();
            btnContinueImportCSV.Enabled = false;
        }

        public List<User_CSV> importCSV_Users_list { get; set; }        
    
        private void btnBrowseUserCSV_Click(object sender, EventArgs e)
        {
            openCSV_User_Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openCSV_User_Dialog.Filter = "Comma-Separated Values (*.csv)|*.csv";
            openCSV_User_Dialog.RestoreDirectory = true;
            openCSV_User_Dialog.ShowHelp = true;

            if (openCSV_User_Dialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    var csvwriter = new FileHelperEngine<User_CSV>(Encoding.UTF8);

                    importCSV_Users_list = csvwriter.ReadFile(openCSV_User_Dialog.FileName).ToList();

                    olvImportUserPreview.SetObjects(importCSV_Users_list);
                    btnContinueImportCSV.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File Open Error - " + ex.Message + "\n\nPlease verify if you have selected correct CSV file for USERS.", "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
