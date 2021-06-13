namespace VxCameraAuditor3
{
    partial class frmImportUserCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportUserCSV));
            this.btnBrowseUserCSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.olvImportUserPreview = new BrightIdeasSoftware.ObjectListView();
            this.clmCSVUsername = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmCSVFirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmCSVLastName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmCSVEmpID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmCSVWorkPhone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmCSVEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmCSVNotes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.openCSV_User_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.btnContinueImportCSV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.olvImportUserPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowseUserCSV
            // 
            this.btnBrowseUserCSV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseUserCSV.Location = new System.Drawing.Point(405, 94);
            this.btnBrowseUserCSV.Name = "btnBrowseUserCSV";
            this.btnBrowseUserCSV.Size = new System.Drawing.Size(270, 45);
            this.btnBrowseUserCSV.TabIndex = 0;
            this.btnBrowseUserCSV.Text = "Browse...";
            this.btnBrowseUserCSV.UseVisualStyleBackColor = true;
            this.btnBrowseUserCSV.Click += new System.EventHandler(this.btnBrowseUserCSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a properly-formatted CSV file that contains list of users.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Tip: From Users tab, export the current user list to get a correct CSV template." +
    "";
            // 
            // olvImportUserPreview
            // 
            this.olvImportUserPreview.AllColumns.Add(this.clmCSVUsername);
            this.olvImportUserPreview.AllColumns.Add(this.clmCSVFirstName);
            this.olvImportUserPreview.AllColumns.Add(this.clmCSVLastName);
            this.olvImportUserPreview.AllColumns.Add(this.clmCSVEmpID);
            this.olvImportUserPreview.AllColumns.Add(this.clmCSVWorkPhone);
            this.olvImportUserPreview.AllColumns.Add(this.clmCSVEmail);
            this.olvImportUserPreview.AllColumns.Add(this.clmCSVNotes);
            this.olvImportUserPreview.CellEditUseWholeCell = false;
            this.olvImportUserPreview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCSVUsername,
            this.clmCSVFirstName,
            this.clmCSVLastName,
            this.clmCSVEmpID,
            this.clmCSVWorkPhone,
            this.clmCSVEmail,
            this.clmCSVNotes});
            this.olvImportUserPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvImportUserPreview.FullRowSelect = true;
            this.olvImportUserPreview.Location = new System.Drawing.Point(12, 145);
            this.olvImportUserPreview.Name = "olvImportUserPreview";
            this.olvImportUserPreview.ShowGroups = false;
            this.olvImportUserPreview.Size = new System.Drawing.Size(1099, 435);
            this.olvImportUserPreview.TabIndex = 3;
            this.olvImportUserPreview.UseCompatibleStateImageBehavior = false;
            this.olvImportUserPreview.View = System.Windows.Forms.View.Details;
            // 
            // clmCSVUsername
            // 
            this.clmCSVUsername.AspectName = "Username";
            this.clmCSVUsername.Text = "Username";
            this.clmCSVUsername.Width = 218;
            // 
            // clmCSVFirstName
            // 
            this.clmCSVFirstName.AspectName = "First_Name";
            this.clmCSVFirstName.Text = "First Name";
            this.clmCSVFirstName.Width = 160;
            // 
            // clmCSVLastName
            // 
            this.clmCSVLastName.AspectName = "Last_Name";
            this.clmCSVLastName.Text = "Last Name";
            this.clmCSVLastName.Width = 109;
            // 
            // clmCSVEmpID
            // 
            this.clmCSVEmpID.AspectName = "Employee_ID";
            this.clmCSVEmpID.Text = "Employee ID";
            this.clmCSVEmpID.Width = 112;
            // 
            // clmCSVWorkPhone
            // 
            this.clmCSVWorkPhone.AspectName = "Work_Phone";
            this.clmCSVWorkPhone.Text = "Work Phone";
            this.clmCSVWorkPhone.Width = 131;
            // 
            // clmCSVEmail
            // 
            this.clmCSVEmail.AspectName = "Email_Address";
            this.clmCSVEmail.Text = "Email";
            this.clmCSVEmail.Width = 157;
            // 
            // clmCSVNotes
            // 
            this.clmCSVNotes.AspectName = "Notes";
            this.clmCSVNotes.Text = "Notes";
            this.clmCSVNotes.Width = 228;
            // 
            // openCSV_User_Dialog
            // 
            this.openCSV_User_Dialog.FileName = "openFileDialog1";
            // 
            // btnContinueImportCSV
            // 
            this.btnContinueImportCSV.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnContinueImportCSV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueImportCSV.Location = new System.Drawing.Point(725, 586);
            this.btnContinueImportCSV.Name = "btnContinueImportCSV";
            this.btnContinueImportCSV.Size = new System.Drawing.Size(190, 40);
            this.btnContinueImportCSV.TabIndex = 4;
            this.btnContinueImportCSV.Text = "Continue";
            this.btnContinueImportCSV.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(921, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(12, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "FOR INTERNATIONAL USERS: CSV File *must* be in UTF-8 Encoding, otherwise all non-" +
    "ASCII characters will show as \"?\"";
            // 
            // frmImportUserCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 640);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnContinueImportCSV);
            this.Controls.Add(this.olvImportUserPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseUserCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportUserCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Users from CSV File";
            ((System.ComponentModel.ISupportInitialize)(this.olvImportUserPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseUserCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BrightIdeasSoftware.ObjectListView olvImportUserPreview;
        private BrightIdeasSoftware.OLVColumn clmCSVUsername;
        private BrightIdeasSoftware.OLVColumn clmCSVFirstName;
        private BrightIdeasSoftware.OLVColumn clmCSVLastName;
        private BrightIdeasSoftware.OLVColumn clmCSVEmpID;
        private BrightIdeasSoftware.OLVColumn clmCSVWorkPhone;
        private BrightIdeasSoftware.OLVColumn clmCSVEmail;
        private BrightIdeasSoftware.OLVColumn clmCSVNotes;
        private System.Windows.Forms.OpenFileDialog openCSV_User_Dialog;
        private System.Windows.Forms.Button btnContinueImportCSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}