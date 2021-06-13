namespace VxCameraAuditor3
{
    partial class frmSelectRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectRole));
            this.olvRoleListSelector = new BrightIdeasSoftware.ObjectListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clmRoleName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvRoleListSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // olvRoleListSelector
            // 
            this.olvRoleListSelector.AllColumns.Add(this.clmRoleName);
            this.olvRoleListSelector.CellEditUseWholeCell = false;
            this.olvRoleListSelector.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmRoleName});
            this.olvRoleListSelector.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRoleListSelector.FullRowSelect = true;
            this.olvRoleListSelector.Location = new System.Drawing.Point(12, 43);
            this.olvRoleListSelector.MultiSelect = false;
            this.olvRoleListSelector.Name = "olvRoleListSelector";
            this.olvRoleListSelector.ShowGroups = false;
            this.olvRoleListSelector.Size = new System.Drawing.Size(274, 396);
            this.olvRoleListSelector.TabIndex = 0;
            this.olvRoleListSelector.UseCompatibleStateImageBehavior = false;
            this.olvRoleListSelector.View = System.Windows.Forms.View.Details;
            this.olvRoleListSelector.SelectedIndexChanged += new System.EventHandler(this.olvRoleListSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Role from below list:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(292, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(292, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // clmRoleName
            // 
            this.clmRoleName.AspectName = "name";
            this.clmRoleName.Text = "Role Name";
            this.clmRoleName.Width = 232;
            // 
            // frmSelectRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 451);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.olvRoleListSelector);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select a Role";
            ((System.ComponentModel.ISupportInitialize)(this.olvRoleListSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvRoleListSelector;
        private BrightIdeasSoftware.OLVColumn clmRoleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}