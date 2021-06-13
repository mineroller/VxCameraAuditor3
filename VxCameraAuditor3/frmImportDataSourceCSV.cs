using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using FileHelpers;
using System.Text;

namespace VxCameraAuditor3
{
    public partial class frmImportDataSourceCSV : Form
    {
        public List<DataSource_CSV> importCSV_DS_list { get; set; }

        public frmImportDataSourceCSV()
        {
            InitializeComponent();
            btnContinueDSImport.Enabled = false;
        }

        private void btnBrowseDSCSV_Click(object sender, EventArgs e)
        {
            openCSV_DS_Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openCSV_DS_Dialog.Filter = "Comma-Separated Values (*.csv)|*.csv";
            openCSV_DS_Dialog.RestoreDirectory = true;
            openCSV_DS_Dialog.ShowHelp = true;

            if (openCSV_DS_Dialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    var csvwriter = new FileHelperEngine<DataSource_CSV>(Encoding.UTF8);

                    importCSV_DS_list = csvwriter.ReadFile(openCSV_DS_Dialog.FileName).ToList();

                    olvImportDSPreview.SetObjects(importCSV_DS_list);
                    btnContinueDSImport.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File Open Error - " + ex.Message + "\n\nPlease verify if you have selected correct CSV file for CAMERAS.", "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
