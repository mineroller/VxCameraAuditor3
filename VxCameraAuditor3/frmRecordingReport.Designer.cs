namespace VxCameraAuditor3
{
    partial class frmRecordingReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecordingReport));
            this.label1 = new System.Windows.Forms.Label();
            this.bgwReportGen = new System.ComponentModel.BackgroundWorker();
            this.prgReport = new System.Windows.Forms.ProgressBar();
            this.olvRecReport = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn10 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lstErrors = new System.Windows.Forms.ListBox();
            this.lblErrors = new System.Windows.Forms.Label();
            this.btnCancelReport = new System.Windows.Forms.Button();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.saveVUFilesDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.olvRecReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please wait while report is generated. This will take a while with lots of camera" +
    "s.";
            // 
            // bgwReportGen
            // 
            this.bgwReportGen.WorkerReportsProgress = true;
            this.bgwReportGen.WorkerSupportsCancellation = true;
            this.bgwReportGen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwReportGen_DoWork);
            this.bgwReportGen.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwReportGen_ProgressChanged);
            this.bgwReportGen.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwReportGen_RunWorkerCompleted);
            // 
            // prgReport
            // 
            this.prgReport.Location = new System.Drawing.Point(15, 72);
            this.prgReport.Name = "prgReport";
            this.prgReport.Size = new System.Drawing.Size(1157, 46);
            this.prgReport.TabIndex = 1;
            // 
            // olvRecReport
            // 
            this.olvRecReport.AllColumns.Add(this.olvColumn1);
            this.olvRecReport.AllColumns.Add(this.olvColumn2);
            this.olvRecReport.AllColumns.Add(this.olvColumn9);
            this.olvRecReport.AllColumns.Add(this.olvColumn10);
            this.olvRecReport.AllColumns.Add(this.olvColumn3);
            this.olvRecReport.AllColumns.Add(this.olvColumn4);
            this.olvRecReport.AllColumns.Add(this.olvColumn5);
            this.olvRecReport.AllColumns.Add(this.olvColumn6);
            this.olvRecReport.AllColumns.Add(this.olvColumn7);
            this.olvRecReport.AllColumns.Add(this.olvColumn8);
            this.olvRecReport.CellEditUseWholeCell = false;
            this.olvRecReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn9,
            this.olvColumn10,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7,
            this.olvColumn8});
            this.olvRecReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRecReport.FullRowSelect = true;
            this.olvRecReport.Location = new System.Drawing.Point(15, 124);
            this.olvRecReport.Name = "olvRecReport";
            this.olvRecReport.ShowGroups = false;
            this.olvRecReport.Size = new System.Drawing.Size(1157, 505);
            this.olvRecReport.TabIndex = 2;
            this.olvRecReport.UseCompatibleStateImageBehavior = false;
            this.olvRecReport.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Cam_Number";
            this.olvColumn1.Text = "Number";
            this.olvColumn1.Width = 72;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Cam_Name";
            this.olvColumn2.Text = "Name";
            this.olvColumn2.Width = 145;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "IP_Address";
            this.olvColumn9.Text = "IP";
            this.olvColumn9.Width = 94;
            // 
            // olvColumn10
            // 
            this.olvColumn10.AspectName = "Cam_Status";
            this.olvColumn10.Text = "Status";
            this.olvColumn10.Width = 90;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Earliest_Video";
            this.olvColumn3.Text = "Earliest Video";
            this.olvColumn3.Width = 144;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Latest_Video";
            this.olvColumn4.Text = "Latest Video";
            this.olvColumn4.Width = 122;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Total_Gaps";
            this.olvColumn5.Text = "Total Gaps";
            this.olvColumn5.Width = 72;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Retention_Days";
            this.olvColumn6.Text = "Retention (Day)";
            this.olvColumn6.Width = 100;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "Retention_Hours";
            this.olvColumn7.Text = "Retention (Hours)";
            this.olvColumn7.Width = 118;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "Retention_Minutes";
            this.olvColumn8.Text = "Retention (minute)";
            this.olvColumn8.Width = 125;
            // 
            // lstErrors
            // 
            this.lstErrors.FormattingEnabled = true;
            this.lstErrors.Location = new System.Drawing.Point(15, 648);
            this.lstErrors.Name = "lstErrors";
            this.lstErrors.Size = new System.Drawing.Size(868, 82);
            this.lstErrors.TabIndex = 3;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(12, 632);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(131, 13);
            this.lblErrors.TabIndex = 4;
            this.lblErrors.Text = "Below items have failed:";
            // 
            // btnCancelReport
            // 
            this.btnCancelReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReport.ForeColor = System.Drawing.Color.Red;
            this.btnCancelReport.Location = new System.Drawing.Point(1060, 15);
            this.btnCancelReport.Name = "btnCancelReport";
            this.btnCancelReport.Size = new System.Drawing.Size(112, 35);
            this.btnCancelReport.TabIndex = 5;
            this.btnCancelReport.Text = "CANCEL";
            this.btnCancelReport.UseVisualStyleBackColor = true;
            this.btnCancelReport.Click += new System.EventHandler(this.btnCancelReport_Click);
            // 
            // lblProgressText
            // 
            this.lblProgressText.AutoSize = true;
            this.lblProgressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressText.Location = new System.Drawing.Point(12, 48);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(217, 21);
            this.lblProgressText.TabIndex = 6;
            this.lblProgressText.Text = "Starting Background Task...";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(889, 648);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(283, 82);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export current report as CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(518, 742);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRecordingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 802);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblProgressText);
            this.Controls.Add(this.btnCancelReport);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lstErrors);
            this.Controls.Add(this.olvRecReport);
            this.Controls.Add(this.prgReport);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRecordingReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recording Report Generator";
            ((System.ComponentModel.ISupportInitialize)(this.olvRecReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bgwReportGen;
        private System.Windows.Forms.ProgressBar prgReport;
        private BrightIdeasSoftware.ObjectListView olvRecReport;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private System.Windows.Forms.ListBox lstErrors;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Button btnCancelReport;
        private System.Windows.Forms.Label lblProgressText;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn olvColumn10;
        private System.Windows.Forms.SaveFileDialog saveVUFilesDialog;
    }
}