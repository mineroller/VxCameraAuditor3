namespace VxCameraAuditor3
{
    partial class frmProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgress));
            this.lstFailedReasons = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblProgressDescription = new System.Windows.Forms.Label();
            this.btnCancelOperation = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bgwRequestHandler = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lstFailedReasons
            // 
            this.lstFailedReasons.FormattingEnabled = true;
            this.lstFailedReasons.HorizontalScrollbar = true;
            this.lstFailedReasons.ItemHeight = 15;
            this.lstFailedReasons.Location = new System.Drawing.Point(17, 211);
            this.lstFailedReasons.Name = "lstFailedReasons";
            this.lstFailedReasons.Size = new System.Drawing.Size(733, 214);
            this.lstFailedReasons.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(14, 44);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(736, 63);
            this.progressBar.TabIndex = 1;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(14, 25);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(229, 15);
            this.lblCurrentStatus.TabIndex = 2;
            this.lblCurrentStatus.Text = "Performing requested actions on VxCore...";
            // 
            // lblProgressDescription
            // 
            this.lblProgressDescription.AutoSize = true;
            this.lblProgressDescription.Location = new System.Drawing.Point(14, 110);
            this.lblProgressDescription.Name = "lblProgressDescription";
            this.lblProgressDescription.Size = new System.Drawing.Size(148, 15);
            this.lblProgressDescription.TabIndex = 3;
            this.lblProgressDescription.Text = "Starting background task...";
            this.lblProgressDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelOperation
            // 
            this.btnCancelOperation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOperation.Location = new System.Drawing.Point(454, 113);
            this.btnCancelOperation.Name = "btnCancelOperation";
            this.btnCancelOperation.Size = new System.Drawing.Size(175, 41);
            this.btnCancelOperation.TabIndex = 4;
            this.btnCancelOperation.Text = "Cancel Operation";
            this.btnCancelOperation.UseVisualStyleBackColor = true;
            this.btnCancelOperation.Click += new System.EventHandler(this.btnCancelOperation_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(635, 113);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 41);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Errors and Failures during task";
            // 
            // bgwRequestHandler
            // 
            this.bgwRequestHandler.WorkerReportsProgress = true;
            this.bgwRequestHandler.WorkerSupportsCancellation = true;
            this.bgwRequestHandler.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRequestHandler_DoWork);
            this.bgwRequestHandler.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwRequestHandler_ProgressChanged);
            this.bgwRequestHandler.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwRequestHandler_RunWorkerCompleted);
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 440);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancelOperation);
            this.Controls.Add(this.lblProgressDescription);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lstFailedReasons);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Progress Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFailedReasons;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblProgressDescription;
        private System.Windows.Forms.Button btnCancelOperation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker bgwRequestHandler;
    }
}