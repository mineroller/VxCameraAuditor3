namespace VxCameraAuditor3
{
    partial class frmEditCameraInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCameraInfo));
            this.btnEditOK = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewCamNumber = new System.Windows.Forms.TextBox();
            this.txtNewCamName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEditOK
            // 
            this.btnEditOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOK.Location = new System.Drawing.Point(432, 133);
            this.btnEditOK.Name = "btnEditOK";
            this.btnEditOK.Size = new System.Drawing.Size(150, 40);
            this.btnEditOK.TabIndex = 3;
            this.btnEditOK.Text = "OK";
            this.btnEditOK.UseVisualStyleBackColor = true;
            this.btnEditOK.Click += new System.EventHandler(this.btnEditOK_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCancel.Location = new System.Drawing.Point(588, 133);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(150, 40);
            this.btnEditCancel.TabIndex = 4;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtNewCamNumber
            // 
            this.txtNewCamNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCamNumber.Location = new System.Drawing.Point(111, 31);
            this.txtNewCamNumber.Name = "txtNewCamNumber";
            this.txtNewCamNumber.Size = new System.Drawing.Size(139, 33);
            this.txtNewCamNumber.TabIndex = 1;
            // 
            // txtNewCamName
            // 
            this.txtNewCamName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCamName.Location = new System.Drawing.Point(111, 70);
            this.txtNewCamName.Name = "txtNewCamName";
            this.txtNewCamName.Size = new System.Drawing.Size(627, 33);
            this.txtNewCamName.TabIndex = 2;
            // 
            // frmEditCameraInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 185);
            this.Controls.Add(this.txtNewCamName);
            this.Controls.Add(this.txtNewCamNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.btnEditOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditCameraInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Camera Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditOK;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewCamNumber;
        private System.Windows.Forms.TextBox txtNewCamName;
    }
}