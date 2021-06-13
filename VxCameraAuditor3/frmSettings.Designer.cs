namespace VxCameraAuditor3
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.lblVxCore = new System.Windows.Forms.Label();
            this.lblSettingTitle = new System.Windows.Forms.Label();
            this.lblSettingIntro = new System.Windows.Forms.Label();
            this.txtCoreAddr = new System.Windows.Forms.TextBox();
            this.txtVxAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVxsUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVxsPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSettingCancel = new System.Windows.Forms.Button();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVxsPort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VxCameraAuditor3.Properties.Resources.imgfileSettings;
            this.pictureBox1.Location = new System.Drawing.Point(390, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsSave.Location = new System.Drawing.Point(181, 404);
            this.btnSettingsSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(157, 46);
            this.btnSettingsSave.TabIndex = 1;
            this.btnSettingsSave.Text = "Save and Close";
            this.btnSettingsSave.UseVisualStyleBackColor = true;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // lblVxCore
            // 
            this.lblVxCore.AutoSize = true;
            this.lblVxCore.Location = new System.Drawing.Point(80, 36);
            this.lblVxCore.Name = "lblVxCore";
            this.lblVxCore.Size = new System.Drawing.Size(89, 15);
            this.lblVxCore.TabIndex = 2;
            this.lblVxCore.Text = "VxCore Address";
            // 
            // lblSettingTitle
            // 
            this.lblSettingTitle.AutoSize = true;
            this.lblSettingTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingTitle.Location = new System.Drawing.Point(14, 10);
            this.lblSettingTitle.Name = "lblSettingTitle";
            this.lblSettingTitle.Size = new System.Drawing.Size(212, 30);
            this.lblSettingTitle.TabIndex = 3;
            this.lblSettingTitle.Text = "Connection Settings";
            // 
            // lblSettingIntro
            // 
            this.lblSettingIntro.AutoSize = true;
            this.lblSettingIntro.Location = new System.Drawing.Point(16, 51);
            this.lblSettingIntro.Name = "lblSettingIntro";
            this.lblSettingIntro.Size = new System.Drawing.Size(256, 15);
            this.lblSettingIntro.TabIndex = 4;
            this.lblSettingIntro.Text = "Enter the details of servers and credentials here.";
            // 
            // txtCoreAddr
            // 
            this.txtCoreAddr.Location = new System.Drawing.Point(208, 32);
            this.txtCoreAddr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCoreAddr.MaxLength = 100;
            this.txtCoreAddr.Name = "txtCoreAddr";
            this.txtCoreAddr.Size = new System.Drawing.Size(186, 23);
            this.txtCoreAddr.TabIndex = 5;
            // 
            // txtVxAdmin
            // 
            this.txtVxAdmin.Location = new System.Drawing.Point(208, 62);
            this.txtVxAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVxAdmin.MaxLength = 100;
            this.txtVxAdmin.Name = "txtVxAdmin";
            this.txtVxAdmin.Size = new System.Drawing.Size(186, 23);
            this.txtVxAdmin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vx Admin Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVxPass
            // 
            this.txtVxPass.Location = new System.Drawing.Point(208, 92);
            this.txtVxPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVxPass.MaxLength = 100;
            this.txtVxPass.Name = "txtVxPass";
            this.txtVxPass.Size = new System.Drawing.Size(186, 23);
            this.txtVxPass.TabIndex = 9;
            this.txtVxPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vx Admin Password";
            // 
            // txtVxsUser
            // 
            this.txtVxsUser.Location = new System.Drawing.Point(209, 29);
            this.txtVxsUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVxsUser.MaxLength = 100;
            this.txtVxsUser.Name = "txtVxsUser";
            this.txtVxsUser.Size = new System.Drawing.Size(186, 23);
            this.txtVxsUser.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "VXS Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVxsPass
            // 
            this.txtVxsPass.Location = new System.Drawing.Point(209, 60);
            this.txtVxsPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVxsPass.MaxLength = 100;
            this.txtVxsPass.Name = "txtVxsPass";
            this.txtVxsPass.Size = new System.Drawing.Size(186, 23);
            this.txtVxsPass.TabIndex = 13;
            this.txtVxsPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "VXS Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSettingCancel
            // 
            this.btnSettingCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSettingCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingCancel.Location = new System.Drawing.Point(368, 404);
            this.btnSettingCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettingCancel.Name = "btnSettingCancel";
            this.btnSettingCancel.Size = new System.Drawing.Size(101, 46);
            this.btnSettingCancel.TabIndex = 16;
            this.btnSettingCancel.Text = "Cancel";
            this.btnSettingCancel.UseVisualStyleBackColor = true;
            this.btnSettingCancel.Click += new System.EventHandler(this.btnSettingCancel_Click);
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Location = new System.Drawing.Point(20, 75);
            this.chkShowPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(113, 19);
            this.chkShowPass.TabIndex = 1;
            this.chkShowPass.Text = "Show Passwords";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // btnDefault
            // 
            this.btnDefault.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.Location = new System.Drawing.Point(18, 404);
            this.btnDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(131, 46);
            this.btnDefault.TabIndex = 18;
            this.btnDefault.Text = "Load Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVxPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVxAdmin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCoreAddr);
            this.groupBox1.Controls.Add(this.lblVxCore);
            this.groupBox1.Location = new System.Drawing.Point(20, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(451, 132);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vx Core Settings - for HTTP/Serenity Calls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVxsPort);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtVxsPass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtVxsUser);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(18, 256);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(453, 140);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VxStorage Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "VxS Port";
            // 
            // txtVxsPort
            // 
            this.txtVxsPort.Location = new System.Drawing.Point(209, 90);
            this.txtVxsPort.Name = "txtVxsPort";
            this.txtVxsPort.Size = new System.Drawing.Size(97, 23);
            this.txtVxsPort.TabIndex = 15;
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnSettingsSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSettingCancel;
            this.ClientSize = new System.Drawing.Size(485, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.btnSettingCancel);
            this.Controls.Add(this.lblSettingIntro);
            this.Controls.Add(this.lblSettingTitle);
            this.Controls.Add(this.btnSettingsSave);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Default Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSettingsSave;
        private System.Windows.Forms.Label lblVxCore;
        private System.Windows.Forms.Label lblSettingTitle;
        private System.Windows.Forms.Label lblSettingIntro;
        private System.Windows.Forms.TextBox txtCoreAddr;
        private System.Windows.Forms.TextBox txtVxAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVxsUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVxsPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSettingCancel;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVxsPort;
    }
}