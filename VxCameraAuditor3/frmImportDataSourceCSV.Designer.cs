namespace VxCameraAuditor3
{
    partial class frmImportDataSourceCSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportDataSourceCSV));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseDSCSV = new System.Windows.Forms.Button();
            this.olvImportDSPreview = new BrightIdeasSoftware.ObjectListView();
            this.clmDSNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDSName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDSIP = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDSGUID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnContinueDSImport = new System.Windows.Forms.Button();
            this.openCSV_DS_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.olvImportDSPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a properly-formatted CSV file that contains camera information.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Tip: Export the current camera list to get a correct CSV template.";
            // 
            // btnBrowseDSCSV
            // 
            this.btnBrowseDSCSV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseDSCSV.Location = new System.Drawing.Point(351, 69);
            this.btnBrowseDSCSV.Name = "btnBrowseDSCSV";
            this.btnBrowseDSCSV.Size = new System.Drawing.Size(270, 45);
            this.btnBrowseDSCSV.TabIndex = 2;
            this.btnBrowseDSCSV.Text = "Browse...";
            this.btnBrowseDSCSV.UseVisualStyleBackColor = true;
            this.btnBrowseDSCSV.Click += new System.EventHandler(this.btnBrowseDSCSV_Click);
            // 
            // olvImportDSPreview
            // 
            this.olvImportDSPreview.AllColumns.Add(this.clmDSNumber);
            this.olvImportDSPreview.AllColumns.Add(this.clmDSName);
            this.olvImportDSPreview.AllColumns.Add(this.clmDSIP);
            this.olvImportDSPreview.AllColumns.Add(this.clmDSGUID);
            this.olvImportDSPreview.CellEditUseWholeCell = false;
            this.olvImportDSPreview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDSNumber,
            this.clmDSName,
            this.clmDSIP,
            this.clmDSGUID});
            this.olvImportDSPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvImportDSPreview.FullRowSelect = true;
            this.olvImportDSPreview.Location = new System.Drawing.Point(12, 120);
            this.olvImportDSPreview.Name = "olvImportDSPreview";
            this.olvImportDSPreview.ShowGroups = false;
            this.olvImportDSPreview.Size = new System.Drawing.Size(962, 433);
            this.olvImportDSPreview.TabIndex = 3;
            this.olvImportDSPreview.UseCompatibleStateImageBehavior = false;
            this.olvImportDSPreview.View = System.Windows.Forms.View.Details;
            // 
            // clmDSNumber
            // 
            this.clmDSNumber.AspectName = "Camera_Number";
            this.clmDSNumber.Text = "Number";
            this.clmDSNumber.Width = 116;
            // 
            // clmDSName
            // 
            this.clmDSName.AspectName = "Camera_Name";
            this.clmDSName.Text = "Camera Name";
            this.clmDSName.Width = 344;
            // 
            // clmDSIP
            // 
            this.clmDSIP.AspectName = "IP_Address";
            this.clmDSIP.Text = "IP Address";
            this.clmDSIP.Width = 159;
            // 
            // clmDSGUID
            // 
            this.clmDSGUID.AspectName = "Device_GUID";
            this.clmDSGUID.Text = "GUID";
            this.clmDSGUID.Width = 273;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(784, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnContinueDSImport
            // 
            this.btnContinueDSImport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContinueDSImport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueDSImport.Location = new System.Drawing.Point(588, 559);
            this.btnContinueDSImport.Name = "btnContinueDSImport";
            this.btnContinueDSImport.Size = new System.Drawing.Size(190, 40);
            this.btnContinueDSImport.TabIndex = 5;
            this.btnContinueDSImport.Text = "Continue";
            this.btnContinueDSImport.UseVisualStyleBackColor = true;
            // 
            // openCSV_DS_Dialog
            // 
            this.openCSV_DS_Dialog.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(8, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "FOR INTERNATIONAL USERS: CSV File *must* be in UTF-8 Encoding, otherwise all non-" +
    "ASCII characters will show as \"?\"";
            // 
            // frmImportDataSourceCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 611);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContinueDSImport);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.olvImportDSPreview);
            this.Controls.Add(this.btnBrowseDSCSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportDataSourceCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Camera Number and Name from CSV File";
            ((System.ComponentModel.ISupportInitialize)(this.olvImportDSPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseDSCSV;
        private BrightIdeasSoftware.ObjectListView olvImportDSPreview;
        private BrightIdeasSoftware.OLVColumn clmDSNumber;
        private BrightIdeasSoftware.OLVColumn clmDSName;
        private BrightIdeasSoftware.OLVColumn clmDSIP;
        private BrightIdeasSoftware.OLVColumn clmDSGUID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnContinueDSImport;
        private System.Windows.Forms.OpenFileDialog openCSV_DS_Dialog;
        private System.Windows.Forms.Label label3;
    }
}