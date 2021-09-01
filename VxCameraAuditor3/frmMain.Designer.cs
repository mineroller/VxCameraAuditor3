namespace VxCameraAuditor3
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAuxResultDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToVxCoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblConsoleWindow = new System.Windows.Forms.Label();
            this.ctxDeviceToolkit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ctxCameraMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxEditCameraInfo2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDeviceMenuGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxEditDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDeleteDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuPing = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuSSH = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuOpenWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCopyIPAddr = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCopyGUID = new System.Windows.Forms.ToolStripMenuItem();
            this.vuImageList = new System.Windows.Forms.ImageList(this.components);
            this.chkDisplayPreview = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSvrAddr = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saveVUFilesDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTipVU = new System.Windows.Forms.ToolTip(this.components);
            this.txtDataSrcSearchTerm = new System.Windows.Forms.TextBox();
            this.txtDSAdvFilter = new System.Windows.Forms.TextBox();
            this.txtDeviceAdvFilter = new System.Windows.Forms.TextBox();
            this.openTXTDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.cmbSelectAggMember = new System.Windows.Forms.ComboBox();
            this.tabRecorder = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.grpVxsDiag = new System.Windows.Forms.GroupBox();
            this.cmbVolumes = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.lblRecorderUnitEvents = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblRecorderUnitXcast = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblRecorderUnitCh = new System.Windows.Forms.Label();
            this.lblRecorderUnitActRet = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblRecorderUnitSetRet = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblRecorderUnitAssBitrate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblRecorderAssocDS = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalRecorders = new System.Windows.Forms.Label();
            this.grpBoxRecorderDetail = new System.Windows.Forms.GroupBox();
            this.lnkRecorderIP = new System.Windows.Forms.LinkLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRecorderUnitType = new System.Windows.Forms.Label();
            this.lblRecorderUnitFailover = new System.Windows.Forms.Label();
            this.lblRecorderUnitVersion = new System.Windows.Forms.Label();
            this.lblRecorderUnitGUID = new System.Windows.Forms.Label();
            this.olvRecorderAssocDS = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn56 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn57 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn58 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn59 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn60 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn61 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn62 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnGetAllRecorders = new System.Windows.Forms.Button();
            this.olvRecorderSearchResult = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn46 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn52 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn53 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn54 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn55 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabCameraSearch = new System.Windows.Forms.TabPage();
            this.btnImportCSV_DS = new System.Windows.Forms.Button();
            this.btnExportCSV_DS = new System.Windows.Forms.Button();
            this.btnSearchOnline = new System.Windows.Forms.Button();
            this.btnDSAdvFilter = new System.Windows.Forms.Button();
            this.lblSelectedCamNameNo = new System.Windows.Forms.Label();
            this.lblSnapshotStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstClipGaps = new System.Windows.Forms.ListBox();
            this.lblClipGaps = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblClipRetention = new System.Windows.Forms.Label();
            this.lblClipEndTime = new System.Windows.Forms.Label();
            this.lblClipStartTime = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnGenerateRetentionReport = new System.Windows.Forms.Button();
            this.btnNotRecording = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchOffline = new System.Windows.Forms.Button();
            this.olvAssocDevice = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn15 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn16 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn17 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn18 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn19 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn20 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn21 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn22 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn23 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label4 = new System.Windows.Forms.Label();
            this.olvDatasourceResults = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn24 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn25 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn26 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn27 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDS_GUID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.picCamPreviewJPG = new System.Windows.Forms.PictureBox();
            this.btnSearchDataSrc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabVUMainGUI = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.lblOverviewMonitorQty = new System.Windows.Forms.Label();
            this.lblOverviewUIQty = new System.Windows.Forms.Label();
            this.lblOverviewClientsQty = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblOverviewASQty = new System.Windows.Forms.Label();
            this.lblOverviewAIOQty = new System.Windows.Forms.Label();
            this.lblOverviewNSMQty = new System.Windows.Forms.Label();
            this.lblOverviewVXSQty = new System.Windows.Forms.Label();
            this.lblOverviewMGQty = new System.Windows.Forms.Label();
            this.lblOverviewCoreQty = new System.Windows.Forms.Label();
            this.lblOverviewRecorderQty = new System.Windows.Forms.Label();
            this.lblOverviewServersQty = new System.Windows.Forms.Label();
            this.lblOverviewSystemType = new System.Windows.Forms.Label();
            this.btnGetSystemDashboard = new System.Windows.Forms.Button();
            this.tabDeviceSearch = new System.Windows.Forms.TabPage();
            this.btnAddDeviceByCSV = new System.Windows.Forms.Button();
            this.btnManualAddOneDevice = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLastModified = new System.Windows.Forms.Button();
            this.btnUncomissioned = new System.Windows.Forms.Button();
            this.btnOfflineDevices = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnExportCSV_Device = new System.Windows.Forms.Button();
            this.btnImportCSV_Device = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.olvAssocDataSources = new BrightIdeasSoftware.ObjectListView();
            this.clmAssocDSNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmAssocDSName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmAssocDSIP = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmAssocDSStatus = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmAssocDSType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmAssocDSCap = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmAssocDSRec = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmAssocDSGUID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label40 = new System.Windows.Forms.Label();
            this.lblSelectedDevice = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.olvDeviceResults = new BrightIdeasSoftware.ObjectListView();
            this.clmDeviceName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDeviceIP = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDeviceModel = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDeviceType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDeviceVersion = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDeviceSerial = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDeviceState = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDeviceVendor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDeviceCommissioned = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmDeviceGUID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label38 = new System.Windows.Forms.Label();
            this.btnSearchDevice = new System.Windows.Forms.Button();
            this.txtDeviceSearchTerm = new System.Windows.Forms.TextBox();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnExportUserCSV = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnImportUserCSV = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.olvAssocPhoneNumbers = new BrightIdeasSoftware.ObjectListView();
            this.clmPhoneType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmPhoneNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvAssocRoles = new BrightIdeasSoftware.ObjectListView();
            this.clmAssocRoles = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label28 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.cmbRoleList = new System.Windows.Forms.ComboBox();
            this.lblSelectedUserName = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtQuickAddUser = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btnImportUserTXT = new System.Windows.Forms.Button();
            this.txtUserSearchTerm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.olvUserList = new BrightIdeasSoftware.ObjectListView();
            this.clmUsername = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmFname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmLname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmEmail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmEmpID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clmNotes = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ctxUserToolkit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuResetPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenuAssignNewRole = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDeleteUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.prgVolumeSpace = new System.Windows.Forms.ProgressBar();
            this.label41 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ctxDeviceToolkit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabRecorder.SuspendLayout();
            this.grpVxsDiag.SuspendLayout();
            this.grpBoxRecorderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRecorderAssocDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvRecorderSearchResult)).BeginInit();
            this.tabCameraSearch.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssocDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvDatasourceResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamPreviewJPG)).BeginInit();
            this.tabVUMainGUI.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabDeviceSearch.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssocDataSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvDeviceResults)).BeginInit();
            this.tabUsers.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssocPhoneNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssocRoles)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvUserList)).BeginInit();
            this.ctxUserToolkit.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusMessage,
            this.lblAuxResultDisplay});
            this.statusStrip1.Location = new System.Drawing.Point(0, 911);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1384, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusMessage
            // 
            this.toolStripStatusMessage.Name = "toolStripStatusMessage";
            this.toolStripStatusMessage.Size = new System.Drawing.Size(684, 17);
            this.toolStripStatusMessage.Spring = true;
            this.toolStripStatusMessage.Text = "VxCore Response";
            // 
            // lblAuxResultDisplay
            // 
            this.lblAuxResultDisplay.Name = "lblAuxResultDisplay";
            this.lblAuxResultDisplay.Size = new System.Drawing.Size(684, 17);
            this.lblAuxResultDisplay.Spring = true;
            this.lblAuxResultDisplay.Text = "(System GUID)";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToVxCoreToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToVxCoreToolStripMenuItem
            // 
            this.connectToVxCoreToolStripMenuItem.Name = "connectToVxCoreToolStripMenuItem";
            this.connectToVxCoreToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.connectToVxCoreToolStripMenuItem.Text = "Initiate Connection to VxCore";
            this.connectToVxCoreToolStripMenuItem.Click += new System.EventHandler(this.connectToVxCoreToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionToolStripMenuItem.Text = "Settings";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.preferencesToolStripMenuItem.Text = "Edit Connection Parameters";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.aboutToolStripMenuItem.Text = "About ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblConsoleWindow);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(576, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection and Query Status";
            // 
            // lblConsoleWindow
            // 
            this.lblConsoleWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblConsoleWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConsoleWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConsoleWindow.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsoleWindow.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblConsoleWindow.Location = new System.Drawing.Point(3, 19);
            this.lblConsoleWindow.Name = "lblConsoleWindow";
            this.lblConsoleWindow.Size = new System.Drawing.Size(792, 53);
            this.lblConsoleWindow.TabIndex = 0;
            this.lblConsoleWindow.Text = "Check connection settings first.";
            this.lblConsoleWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctxDeviceToolkit
            // 
            this.ctxDeviceToolkit.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ctxDeviceToolkit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.ctxCameraMenuGroup,
            this.ctxDeviceMenuGroup,
            this.ctxMenuPing,
            this.ctxMenuSSH,
            this.ctxMenuOpenWeb,
            this.copyToClipboardToolStripMenuItem});
            this.ctxDeviceToolkit.Name = "contextMenuStrip1";
            this.ctxDeviceToolkit.Size = new System.Drawing.Size(181, 165);
            this.ctxDeviceToolkit.Opening += new System.ComponentModel.CancelEventHandler(this.ctxDeviceToolkit_Opening);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.ShortcutsEnabled = false;
            this.toolStripTextBox1.Size = new System.Drawing.Size(120, 27);
            this.toolStripTextBox1.Text = "Device / Camera";
            // 
            // ctxCameraMenuGroup
            // 
            this.ctxCameraMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxEditCameraInfo2});
            this.ctxCameraMenuGroup.Name = "ctxCameraMenuGroup";
            this.ctxCameraMenuGroup.Size = new System.Drawing.Size(180, 22);
            this.ctxCameraMenuGroup.Text = "Camera Tools";
            // 
            // ctxEditCameraInfo2
            // 
            this.ctxEditCameraInfo2.Name = "ctxEditCameraInfo2";
            this.ctxEditCameraInfo2.Size = new System.Drawing.Size(171, 22);
            this.ctxEditCameraInfo2.Text = "Edit Camera Info...";
            this.ctxEditCameraInfo2.Click += new System.EventHandler(this.ctxEditCameraInfo2_Click);
            // 
            // ctxDeviceMenuGroup
            // 
            this.ctxDeviceMenuGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxEditDevice,
            this.ctxDeleteDevice});
            this.ctxDeviceMenuGroup.Name = "ctxDeviceMenuGroup";
            this.ctxDeviceMenuGroup.Size = new System.Drawing.Size(180, 22);
            this.ctxDeviceMenuGroup.Text = "Device Tools";
            // 
            // ctxEditDevice
            // 
            this.ctxEditDevice.Name = "ctxEditDevice";
            this.ctxEditDevice.Size = new System.Drawing.Size(189, 22);
            this.ctxEditDevice.Text = "Edit Device Name...";
            // 
            // ctxDeleteDevice
            // 
            this.ctxDeleteDevice.Name = "ctxDeleteDevice";
            this.ctxDeleteDevice.Size = new System.Drawing.Size(189, 22);
            this.ctxDeleteDevice.Text = "Delete Device from Vx";
            this.ctxDeleteDevice.Click += new System.EventHandler(this.ctxDeleteDevice_Click);
            // 
            // ctxMenuPing
            // 
            this.ctxMenuPing.Name = "ctxMenuPing";
            this.ctxMenuPing.Size = new System.Drawing.Size(180, 22);
            this.ctxMenuPing.Text = "Ping";
            this.ctxMenuPing.Click += new System.EventHandler(this.ctxMenuPing_Click);
            // 
            // ctxMenuSSH
            // 
            this.ctxMenuSSH.Name = "ctxMenuSSH";
            this.ctxMenuSSH.Size = new System.Drawing.Size(180, 22);
            this.ctxMenuSSH.Text = "Open SSH";
            this.ctxMenuSSH.Click += new System.EventHandler(this.ctxMenuSSH_Click);
            // 
            // ctxMenuOpenWeb
            // 
            this.ctxMenuOpenWeb.Name = "ctxMenuOpenWeb";
            this.ctxMenuOpenWeb.Size = new System.Drawing.Size(180, 22);
            this.ctxMenuOpenWeb.Text = "Open Web Page";
            this.ctxMenuOpenWeb.Click += new System.EventHandler(this.ctxMenuOpenWebBrowser_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxCopyIPAddr,
            this.ctxCopyGUID});
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            // 
            // ctxCopyIPAddr
            // 
            this.ctxCopyIPAddr.Name = "ctxCopyIPAddr";
            this.ctxCopyIPAddr.Size = new System.Drawing.Size(140, 22);
            this.ctxCopyIPAddr.Text = "IP Addresses";
            this.ctxCopyIPAddr.Click += new System.EventHandler(this.ctxCopyIPAddr_Click);
            // 
            // ctxCopyGUID
            // 
            this.ctxCopyGUID.Name = "ctxCopyGUID";
            this.ctxCopyGUID.Size = new System.Drawing.Size(140, 22);
            this.ctxCopyGUID.Text = "GUID";
            this.ctxCopyGUID.Click += new System.EventHandler(this.ctxCopyGUID_Click);
            // 
            // vuImageList
            // 
            this.vuImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("vuImageList.ImageStream")));
            this.vuImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.vuImageList.Images.SetKeyName(0, "compare.png");
            this.vuImageList.Images.SetKeyName(1, "pull-requests-128.png");
            this.vuImageList.Images.SetKeyName(2, "tag.png");
            // 
            // chkDisplayPreview
            // 
            this.chkDisplayPreview.AutoSize = true;
            this.chkDisplayPreview.BackColor = System.Drawing.Color.Transparent;
            this.chkDisplayPreview.Location = new System.Drawing.Point(12, 130);
            this.chkDisplayPreview.Name = "chkDisplayPreview";
            this.chkDisplayPreview.Size = new System.Drawing.Size(146, 17);
            this.chkDisplayPreview.TabIndex = 25;
            this.chkDisplayPreview.Text = "Display Camera Preview";
            this.chkDisplayPreview.UseVisualStyleBackColor = false;
            this.chkDisplayPreview.CheckedChanged += new System.EventHandler(this.chkDisplayPreview_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCurrentUser);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblSvrAddr);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 75);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VideoXpert System Connection Settings";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(91, 44);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(55, 20);
            this.lblCurrentUser.TabIndex = 3;
            this.lblCurrentUser.Text = "(none)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Logged in as:";
            // 
            // lblSvrAddr
            // 
            this.lblSvrAddr.AutoSize = true;
            this.lblSvrAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSvrAddr.Location = new System.Drawing.Point(91, 22);
            this.lblSvrAddr.Name = "lblSvrAddr";
            this.lblSvrAddr.Size = new System.Drawing.Size(57, 20);
            this.lblSvrAddr.TabIndex = 1;
            this.lblSvrAddr.Text = "https://";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "VxCore IP:";
            // 
            // saveVUFilesDialog
            // 
            this.saveVUFilesDialog.DefaultExt = "txt";
            // 
            // txtDataSrcSearchTerm
            // 
            this.txtDataSrcSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataSrcSearchTerm.Location = new System.Drawing.Point(9, 44);
            this.txtDataSrcSearchTerm.Name = "txtDataSrcSearchTerm";
            this.txtDataSrcSearchTerm.Size = new System.Drawing.Size(304, 29);
            this.txtDataSrcSearchTerm.TabIndex = 1;
            this.toolTipVU.SetToolTip(this.txtDataSrcSearchTerm, "Searches for matching text in: Name, Number, GUID, IP, Type.");
            this.txtDataSrcSearchTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataSrcSearchTerm_KeyDown);
            // 
            // txtDSAdvFilter
            // 
            this.txtDSAdvFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDSAdvFilter.Location = new System.Drawing.Point(158, 12);
            this.txtDSAdvFilter.Name = "txtDSAdvFilter";
            this.txtDSAdvFilter.Size = new System.Drawing.Size(155, 22);
            this.txtDSAdvFilter.TabIndex = 29;
            this.toolTipVU.SetToolTip(this.txtDSAdvFilter, "Example Filter: (number lt \'101\')and(name likei \'Table\')");
            this.txtDSAdvFilter.Visible = false;
            this.txtDSAdvFilter.TextChanged += new System.EventHandler(this.txtDSAdvFilter_TextChanged);
            this.txtDSAdvFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDSAdvFilter_KeyDown);
            // 
            // txtDeviceAdvFilter
            // 
            this.txtDeviceAdvFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceAdvFilter.Location = new System.Drawing.Point(322, 8);
            this.txtDeviceAdvFilter.Name = "txtDeviceAdvFilter";
            this.txtDeviceAdvFilter.Size = new System.Drawing.Size(155, 22);
            this.txtDeviceAdvFilter.TabIndex = 47;
            this.toolTipVU.SetToolTip(this.txtDeviceAdvFilter, "Example Filter: (number lt \'101\')and(name likei \'Table\')");
            this.txtDeviceAdvFilter.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.cmbSelectAggMember);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(301, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 75);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter for Aggregated System";
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(6, 40);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(257, 31);
            this.label34.TabIndex = 1;
            this.label34.Text = "* Applies to Device and DataSource searches only. Actual search is ONLY performed" +
    " on Parent system.";
            // 
            // cmbSelectAggMember
            // 
            this.cmbSelectAggMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectAggMember.FormattingEnabled = true;
            this.cmbSelectAggMember.Location = new System.Drawing.Point(6, 16);
            this.cmbSelectAggMember.Name = "cmbSelectAggMember";
            this.cmbSelectAggMember.Size = new System.Drawing.Size(257, 23);
            this.cmbSelectAggMember.TabIndex = 0;
            this.cmbSelectAggMember.SelectedIndexChanged += new System.EventHandler(this.cmbSelectAggMember_SelectedIndexChanged);
            // 
            // tabRecorder
            // 
            this.tabRecorder.Controls.Add(this.groupBox13);
            this.tabRecorder.Controls.Add(this.label22);
            this.tabRecorder.Controls.Add(this.grpVxsDiag);
            this.tabRecorder.Controls.Add(this.lblRecorderAssocDS);
            this.tabRecorder.Controls.Add(this.label13);
            this.tabRecorder.Controls.Add(this.lblTotalRecorders);
            this.tabRecorder.Controls.Add(this.grpBoxRecorderDetail);
            this.tabRecorder.Controls.Add(this.olvRecorderAssocDS);
            this.tabRecorder.Controls.Add(this.btnGetAllRecorders);
            this.tabRecorder.Controls.Add(this.olvRecorderSearchResult);
            this.tabRecorder.Location = new System.Drawing.Point(4, 22);
            this.tabRecorder.Name = "tabRecorder";
            this.tabRecorder.Size = new System.Drawing.Size(1351, 771);
            this.tabRecorder.TabIndex = 3;
            this.tabRecorder.Text = "Recorder Information";
            this.tabRecorder.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label22.ForeColor = System.Drawing.Color.OrangeRed;
            this.label22.Location = new System.Drawing.Point(243, 41);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(372, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "NOTE 2: For Endura NSM, please use the Web Interface for diagnostics.";
            // 
            // grpVxsDiag
            // 
            this.grpVxsDiag.Controls.Add(this.lblRecorderUnitEvents);
            this.grpVxsDiag.Controls.Add(this.label33);
            this.grpVxsDiag.Controls.Add(this.lblRecorderUnitXcast);
            this.grpVxsDiag.Controls.Add(this.label15);
            this.grpVxsDiag.Controls.Add(this.label19);
            this.grpVxsDiag.Controls.Add(this.lblRecorderUnitCh);
            this.grpVxsDiag.Controls.Add(this.lblRecorderUnitActRet);
            this.grpVxsDiag.Controls.Add(this.label16);
            this.grpVxsDiag.Controls.Add(this.lblRecorderUnitSetRet);
            this.grpVxsDiag.Controls.Add(this.label17);
            this.grpVxsDiag.Controls.Add(this.lblRecorderUnitAssBitrate);
            this.grpVxsDiag.Controls.Add(this.label18);
            this.grpVxsDiag.Enabled = false;
            this.grpVxsDiag.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grpVxsDiag.Location = new System.Drawing.Point(325, 377);
            this.grpVxsDiag.Name = "grpVxsDiag";
            this.grpVxsDiag.Size = new System.Drawing.Size(341, 218);
            this.grpVxsDiag.TabIndex = 7;
            this.grpVxsDiag.TabStop = false;
            this.grpVxsDiag.Text = "Diagnostics";
            // 
            // cmbVolumes
            // 
            this.cmbVolumes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVolumes.FormattingEnabled = true;
            this.cmbVolumes.Location = new System.Drawing.Point(69, 30);
            this.cmbVolumes.Name = "cmbVolumes";
            this.cmbVolumes.Size = new System.Drawing.Size(264, 29);
            this.cmbVolumes.TabIndex = 21;
            this.cmbVolumes.SelectedIndexChanged += new System.EventHandler(this.cmbVolumes_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(23, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(40, 21);
            this.label27.TabIndex = 20;
            this.label27.Text = "Path";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecorderUnitEvents
            // 
            this.lblRecorderUnitEvents.AutoSize = true;
            this.lblRecorderUnitEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorderUnitEvents.Location = new System.Drawing.Point(169, 181);
            this.lblRecorderUnitEvents.Name = "lblRecorderUnitEvents";
            this.lblRecorderUnitEvents.Size = new System.Drawing.Size(22, 21);
            this.lblRecorderUnitEvents.TabIndex = 19;
            this.lblRecorderUnitEvents.Text = "--";
            this.lblRecorderUnitEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(42, 181);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(121, 21);
            this.label33.TabIndex = 18;
            this.label33.Text = "Events per Hour";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecorderUnitXcast
            // 
            this.lblRecorderUnitXcast.AutoSize = true;
            this.lblRecorderUnitXcast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorderUnitXcast.Location = new System.Drawing.Point(169, 153);
            this.lblRecorderUnitXcast.Name = "lblRecorderUnitXcast";
            this.lblRecorderUnitXcast.Size = new System.Drawing.Size(22, 21);
            this.lblRecorderUnitXcast.TabIndex = 17;
            this.lblRecorderUnitXcast.Text = "--";
            this.lblRecorderUnitXcast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(53, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 21);
            this.label15.TabIndex = 8;
            this.label15.Text = "Total Channels";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(139, 21);
            this.label19.TabIndex = 16;
            this.label19.Text = "Recording Method";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecorderUnitCh
            // 
            this.lblRecorderUnitCh.AutoSize = true;
            this.lblRecorderUnitCh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorderUnitCh.Location = new System.Drawing.Point(169, 36);
            this.lblRecorderUnitCh.Name = "lblRecorderUnitCh";
            this.lblRecorderUnitCh.Size = new System.Drawing.Size(22, 21);
            this.lblRecorderUnitCh.TabIndex = 9;
            this.lblRecorderUnitCh.Text = "--";
            this.lblRecorderUnitCh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecorderUnitActRet
            // 
            this.lblRecorderUnitActRet.AutoSize = true;
            this.lblRecorderUnitActRet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorderUnitActRet.Location = new System.Drawing.Point(169, 124);
            this.lblRecorderUnitActRet.Name = "lblRecorderUnitActRet";
            this.lblRecorderUnitActRet.Size = new System.Drawing.Size(22, 21);
            this.lblRecorderUnitActRet.TabIndex = 15;
            this.lblRecorderUnitActRet.Text = "--";
            this.lblRecorderUnitActRet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(41, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 21);
            this.label16.TabIndex = 10;
            this.label16.Text = "Assigned Bitrate";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecorderUnitSetRet
            // 
            this.lblRecorderUnitSetRet.AutoSize = true;
            this.lblRecorderUnitSetRet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorderUnitSetRet.Location = new System.Drawing.Point(169, 94);
            this.lblRecorderUnitSetRet.Name = "lblRecorderUnitSetRet";
            this.lblRecorderUnitSetRet.Size = new System.Drawing.Size(22, 21);
            this.lblRecorderUnitSetRet.TabIndex = 14;
            this.lblRecorderUnitSetRet.Text = "--";
            this.lblRecorderUnitSetRet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 21);
            this.label17.TabIndex = 11;
            this.label17.Text = "Configured Retention";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecorderUnitAssBitrate
            // 
            this.lblRecorderUnitAssBitrate.AutoSize = true;
            this.lblRecorderUnitAssBitrate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorderUnitAssBitrate.Location = new System.Drawing.Point(169, 65);
            this.lblRecorderUnitAssBitrate.Name = "lblRecorderUnitAssBitrate";
            this.lblRecorderUnitAssBitrate.Size = new System.Drawing.Size(22, 21);
            this.lblRecorderUnitAssBitrate.TabIndex = 13;
            this.lblRecorderUnitAssBitrate.Text = "--";
            this.lblRecorderUnitAssBitrate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(39, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 21);
            this.label18.TabIndex = 12;
            this.label18.Text = "Actual Retention";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecorderAssocDS
            // 
            this.lblRecorderAssocDS.AutoSize = true;
            this.lblRecorderAssocDS.Location = new System.Drawing.Point(669, 23);
            this.lblRecorderAssocDS.Name = "lblRecorderAssocDS";
            this.lblRecorderAssocDS.Size = new System.Drawing.Size(108, 13);
            this.lblRecorderAssocDS.TabIndex = 6;
            this.lblRecorderAssocDS.Text = "Associated Cameras";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label13.ForeColor = System.Drawing.Color.OrangeRed;
            this.label13.Location = new System.Drawing.Point(243, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(361, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "NOTE: Only NSMs working as  Manager will have associated cameras.";
            // 
            // lblTotalRecorders
            // 
            this.lblTotalRecorders.AutoSize = true;
            this.lblTotalRecorders.Location = new System.Drawing.Point(6, 92);
            this.lblTotalRecorders.Name = "lblTotalRecorders";
            this.lblTotalRecorders.Size = new System.Drawing.Size(109, 13);
            this.lblTotalRecorders.TabIndex = 4;
            this.lblTotalRecorders.Text = "Recorders in System";
            // 
            // grpBoxRecorderDetail
            // 
            this.grpBoxRecorderDetail.Controls.Add(this.lnkRecorderIP);
            this.grpBoxRecorderDetail.Controls.Add(this.label20);
            this.grpBoxRecorderDetail.Controls.Add(this.label21);
            this.grpBoxRecorderDetail.Controls.Add(this.label14);
            this.grpBoxRecorderDetail.Controls.Add(this.label8);
            this.grpBoxRecorderDetail.Controls.Add(this.label7);
            this.grpBoxRecorderDetail.Controls.Add(this.lblRecorderUnitType);
            this.grpBoxRecorderDetail.Controls.Add(this.lblRecorderUnitFailover);
            this.grpBoxRecorderDetail.Controls.Add(this.lblRecorderUnitVersion);
            this.grpBoxRecorderDetail.Controls.Add(this.lblRecorderUnitGUID);
            this.grpBoxRecorderDetail.Enabled = false;
            this.grpBoxRecorderDetail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grpBoxRecorderDetail.Location = new System.Drawing.Point(9, 377);
            this.grpBoxRecorderDetail.Name = "grpBoxRecorderDetail";
            this.grpBoxRecorderDetail.Size = new System.Drawing.Size(310, 372);
            this.grpBoxRecorderDetail.TabIndex = 3;
            this.grpBoxRecorderDetail.TabStop = false;
            this.grpBoxRecorderDetail.Text = "Selected Recorder";
            // 
            // lnkRecorderIP
            // 
            this.lnkRecorderIP.AutoSize = true;
            this.lnkRecorderIP.Location = new System.Drawing.Point(122, 49);
            this.lnkRecorderIP.Name = "lnkRecorderIP";
            this.lnkRecorderIP.Size = new System.Drawing.Size(22, 21);
            this.lnkRecorderIP.TabIndex = 10;
            this.lnkRecorderIP.TabStop = true;
            this.lnkRecorderIP.Text = "--";
            this.lnkRecorderIP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecorderIP_LinkClicked);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(36, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 21);
            this.label20.TabIndex = 9;
            this.label20.Text = "IP Address";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(116, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 21);
            this.label21.TabIndex = 8;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(48, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 21);
            this.label14.TabIndex = 7;
            this.label14.Text = "Failover?";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Recorder Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Version";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRecorderUnitType
            // 
            this.lblRecorderUnitType.AutoSize = true;
            this.lblRecorderUnitType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorderUnitType.Location = new System.Drawing.Point(122, 107);
            this.lblRecorderUnitType.Name = "lblRecorderUnitType";
            this.lblRecorderUnitType.Size = new System.Drawing.Size(22, 21);
            this.lblRecorderUnitType.TabIndex = 3;
            this.lblRecorderUnitType.Text = "--";
            this.lblRecorderUnitType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecorderUnitFailover
            // 
            this.lblRecorderUnitFailover.AutoSize = true;
            this.lblRecorderUnitFailover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorderUnitFailover.Location = new System.Drawing.Point(122, 137);
            this.lblRecorderUnitFailover.Name = "lblRecorderUnitFailover";
            this.lblRecorderUnitFailover.Size = new System.Drawing.Size(22, 21);
            this.lblRecorderUnitFailover.TabIndex = 1;
            this.lblRecorderUnitFailover.Text = "--";
            this.lblRecorderUnitFailover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecorderUnitVersion
            // 
            this.lblRecorderUnitVersion.AutoSize = true;
            this.lblRecorderUnitVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorderUnitVersion.Location = new System.Drawing.Point(122, 78);
            this.lblRecorderUnitVersion.Name = "lblRecorderUnitVersion";
            this.lblRecorderUnitVersion.Size = new System.Drawing.Size(22, 21);
            this.lblRecorderUnitVersion.TabIndex = 0;
            this.lblRecorderUnitVersion.Text = "--";
            this.lblRecorderUnitVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecorderUnitGUID
            // 
            this.lblRecorderUnitGUID.AutoSize = true;
            this.lblRecorderUnitGUID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorderUnitGUID.Location = new System.Drawing.Point(9, 23);
            this.lblRecorderUnitGUID.Name = "lblRecorderUnitGUID";
            this.lblRecorderUnitGUID.Size = new System.Drawing.Size(40, 13);
            this.lblRecorderUnitGUID.TabIndex = 2;
            this.lblRecorderUnitGUID.Text = "(GUID)";
            this.lblRecorderUnitGUID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // olvRecorderAssocDS
            // 
            this.olvRecorderAssocDS.AllColumns.Add(this.olvColumn56);
            this.olvRecorderAssocDS.AllColumns.Add(this.olvColumn57);
            this.olvRecorderAssocDS.AllColumns.Add(this.olvColumn58);
            this.olvRecorderAssocDS.AllColumns.Add(this.olvColumn59);
            this.olvRecorderAssocDS.AllColumns.Add(this.olvColumn60);
            this.olvRecorderAssocDS.AllColumns.Add(this.olvColumn61);
            this.olvRecorderAssocDS.AllColumns.Add(this.olvColumn62);
            this.olvRecorderAssocDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvRecorderAssocDS.CellEditUseWholeCell = false;
            this.olvRecorderAssocDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn56,
            this.olvColumn57,
            this.olvColumn58,
            this.olvColumn59,
            this.olvColumn60,
            this.olvColumn61,
            this.olvColumn62});
            this.olvRecorderAssocDS.ContextMenuStrip = this.ctxDeviceToolkit;
            this.olvRecorderAssocDS.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRecorderAssocDS.FullRowSelect = true;
            this.olvRecorderAssocDS.HideSelection = false;
            this.olvRecorderAssocDS.Location = new System.Drawing.Point(672, 40);
            this.olvRecorderAssocDS.Name = "olvRecorderAssocDS";
            this.olvRecorderAssocDS.ShowGroups = false;
            this.olvRecorderAssocDS.Size = new System.Drawing.Size(665, 709);
            this.olvRecorderAssocDS.TabIndex = 2;
            this.olvRecorderAssocDS.UseCompatibleStateImageBehavior = false;
            this.olvRecorderAssocDS.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn56
            // 
            this.olvColumn56.AspectName = "number";
            this.olvColumn56.Text = "Number";
            // 
            // olvColumn57
            // 
            this.olvColumn57.AspectName = "name";
            this.olvColumn57.Text = "Name";
            this.olvColumn57.Width = 126;
            // 
            // olvColumn58
            // 
            this.olvColumn58.AspectName = "ip";
            this.olvColumn58.Text = "IP";
            this.olvColumn58.Width = 72;
            // 
            // olvColumn59
            // 
            this.olvColumn59.AspectName = "state";
            this.olvColumn59.Text = "Status";
            this.olvColumn59.Width = 70;
            // 
            // olvColumn60
            // 
            this.olvColumn60.AspectName = "capturing";
            this.olvColumn60.Text = "CAP";
            // 
            // olvColumn61
            // 
            this.olvColumn61.AspectName = "recording";
            this.olvColumn61.Text = "REC";
            this.olvColumn61.Width = 52;
            // 
            // olvColumn62
            // 
            this.olvColumn62.AspectName = "type";
            this.olvColumn62.Text = "Type";
            // 
            // btnGetAllRecorders
            // 
            this.btnGetAllRecorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllRecorders.Location = new System.Drawing.Point(9, 23);
            this.btnGetAllRecorders.Name = "btnGetAllRecorders";
            this.btnGetAllRecorders.Size = new System.Drawing.Size(214, 46);
            this.btnGetAllRecorders.TabIndex = 1;
            this.btnGetAllRecorders.Text = "Get Recorders";
            this.btnGetAllRecorders.UseVisualStyleBackColor = true;
            this.btnGetAllRecorders.Click += new System.EventHandler(this.btnGetAllRecorders_Click);
            // 
            // olvRecorderSearchResult
            // 
            this.olvRecorderSearchResult.AllColumns.Add(this.olvColumn6);
            this.olvRecorderSearchResult.AllColumns.Add(this.olvColumn46);
            this.olvRecorderSearchResult.AllColumns.Add(this.olvColumn52);
            this.olvRecorderSearchResult.AllColumns.Add(this.olvColumn53);
            this.olvRecorderSearchResult.AllColumns.Add(this.olvColumn54);
            this.olvRecorderSearchResult.AllColumns.Add(this.olvColumn55);
            this.olvRecorderSearchResult.AllColumns.Add(this.olvColumn1);
            this.olvRecorderSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.olvRecorderSearchResult.CellEditUseWholeCell = false;
            this.olvRecorderSearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn6,
            this.olvColumn46,
            this.olvColumn52,
            this.olvColumn53,
            this.olvColumn54,
            this.olvColumn55,
            this.olvColumn1});
            this.olvRecorderSearchResult.ContextMenuStrip = this.ctxDeviceToolkit;
            this.olvRecorderSearchResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvRecorderSearchResult.FullRowSelect = true;
            this.olvRecorderSearchResult.HideSelection = false;
            this.olvRecorderSearchResult.Location = new System.Drawing.Point(7, 108);
            this.olvRecorderSearchResult.Name = "olvRecorderSearchResult";
            this.olvRecorderSearchResult.ShowGroups = false;
            this.olvRecorderSearchResult.Size = new System.Drawing.Size(658, 263);
            this.olvRecorderSearchResult.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.olvRecorderSearchResult.TabIndex = 0;
            this.olvRecorderSearchResult.UseCompatibleStateImageBehavior = false;
            this.olvRecorderSearchResult.View = System.Windows.Forms.View.Details;
            this.olvRecorderSearchResult.SelectedIndexChanged += new System.EventHandler(this.olvRecorderSearchResult_SelectedIndexChanged);
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "model";
            this.olvColumn6.Text = "Model";
            this.olvColumn6.Width = 66;
            // 
            // olvColumn46
            // 
            this.olvColumn46.AspectName = "name";
            this.olvColumn46.Text = "Name";
            this.olvColumn46.Width = 142;
            // 
            // olvColumn52
            // 
            this.olvColumn52.AspectName = "ip";
            this.olvColumn52.Text = "IP";
            this.olvColumn52.Width = 112;
            // 
            // olvColumn53
            // 
            this.olvColumn53.AspectName = "vip";
            this.olvColumn53.Text = "Virtual IP";
            this.olvColumn53.Width = 118;
            // 
            // olvColumn54
            // 
            this.olvColumn54.AspectName = "serial";
            this.olvColumn54.Text = "Serial";
            this.olvColumn54.Width = 77;
            // 
            // olvColumn55
            // 
            this.olvColumn55.AspectName = "state";
            this.olvColumn55.Text = "Status";
            this.olvColumn55.Width = 78;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "pelco_hardware";
            this.olvColumn1.Text = "Pelco HW";
            this.olvColumn1.Width = 84;
            // 
            // tabCameraSearch
            // 
            this.tabCameraSearch.Controls.Add(this.btnImportCSV_DS);
            this.tabCameraSearch.Controls.Add(this.btnExportCSV_DS);
            this.tabCameraSearch.Controls.Add(this.btnSearchOnline);
            this.tabCameraSearch.Controls.Add(this.btnDSAdvFilter);
            this.tabCameraSearch.Controls.Add(this.chkDisplayPreview);
            this.tabCameraSearch.Controls.Add(this.lblSelectedCamNameNo);
            this.tabCameraSearch.Controls.Add(this.lblSnapshotStatus);
            this.tabCameraSearch.Controls.Add(this.txtDSAdvFilter);
            this.tabCameraSearch.Controls.Add(this.groupBox3);
            this.tabCameraSearch.Controls.Add(this.btnGenerateRetentionReport);
            this.tabCameraSearch.Controls.Add(this.btnNotRecording);
            this.tabCameraSearch.Controls.Add(this.label12);
            this.tabCameraSearch.Controls.Add(this.label5);
            this.tabCameraSearch.Controls.Add(this.btnSearchOffline);
            this.tabCameraSearch.Controls.Add(this.olvAssocDevice);
            this.tabCameraSearch.Controls.Add(this.label4);
            this.tabCameraSearch.Controls.Add(this.olvDatasourceResults);
            this.tabCameraSearch.Controls.Add(this.picCamPreviewJPG);
            this.tabCameraSearch.Controls.Add(this.txtDataSrcSearchTerm);
            this.tabCameraSearch.Controls.Add(this.btnSearchDataSrc);
            this.tabCameraSearch.Controls.Add(this.label3);
            this.tabCameraSearch.Location = new System.Drawing.Point(4, 22);
            this.tabCameraSearch.Name = "tabCameraSearch";
            this.tabCameraSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabCameraSearch.Size = new System.Drawing.Size(1351, 771);
            this.tabCameraSearch.TabIndex = 1;
            this.tabCameraSearch.Text = "Camera Manager";
            this.tabCameraSearch.UseVisualStyleBackColor = true;
            // 
            // btnImportCSV_DS
            // 
            this.btnImportCSV_DS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportCSV_DS.Location = new System.Drawing.Point(1114, 6);
            this.btnImportCSV_DS.Name = "btnImportCSV_DS";
            this.btnImportCSV_DS.Size = new System.Drawing.Size(231, 30);
            this.btnImportCSV_DS.TabIndex = 35;
            this.btnImportCSV_DS.Text = "Import CSV File for Batch Update";
            this.btnImportCSV_DS.UseVisualStyleBackColor = true;
            this.btnImportCSV_DS.Click += new System.EventHandler(this.btnImportCSV_DS_Click);
            // 
            // btnExportCSV_DS
            // 
            this.btnExportCSV_DS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCSV_DS.Location = new System.Drawing.Point(878, 6);
            this.btnExportCSV_DS.Name = "btnExportCSV_DS";
            this.btnExportCSV_DS.Size = new System.Drawing.Size(231, 30);
            this.btnExportCSV_DS.TabIndex = 34;
            this.btnExportCSV_DS.Text = "Export current list to CSV File";
            this.btnExportCSV_DS.UseVisualStyleBackColor = true;
            this.btnExportCSV_DS.Click += new System.EventHandler(this.btnExportCSV_DS_Click);
            // 
            // btnSearchOnline
            // 
            this.btnSearchOnline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOnline.Location = new System.Drawing.Point(334, 94);
            this.btnSearchOnline.Name = "btnSearchOnline";
            this.btnSearchOnline.Size = new System.Drawing.Size(155, 30);
            this.btnSearchOnline.TabIndex = 33;
            this.btnSearchOnline.Text = "ONLINE Cameras";
            this.btnSearchOnline.UseVisualStyleBackColor = true;
            this.btnSearchOnline.Click += new System.EventHandler(this.btnSearchOnline_Click);
            // 
            // btnDSAdvFilter
            // 
            this.btnDSAdvFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDSAdvFilter.Enabled = false;
            this.btnDSAdvFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSAdvFilter.Location = new System.Drawing.Point(319, 7);
            this.btnDSAdvFilter.Name = "btnDSAdvFilter";
            this.btnDSAdvFilter.Size = new System.Drawing.Size(155, 30);
            this.btnDSAdvFilter.TabIndex = 30;
            this.btnDSAdvFilter.Text = "ADVFILTER";
            this.btnDSAdvFilter.UseVisualStyleBackColor = true;
            this.btnDSAdvFilter.Visible = false;
            this.btnDSAdvFilter.Click += new System.EventHandler(this.btnDSAdvFilter_Click);
            // 
            // lblSelectedCamNameNo
            // 
            this.lblSelectedCamNameNo.AutoSize = true;
            this.lblSelectedCamNameNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCamNameNo.Location = new System.Drawing.Point(8, 151);
            this.lblSelectedCamNameNo.Name = "lblSelectedCamNameNo";
            this.lblSelectedCamNameNo.Size = new System.Drawing.Size(159, 20);
            this.lblSelectedCamNameNo.TabIndex = 8;
            this.lblSelectedCamNameNo.Text = "(Selected Camera)";
            // 
            // lblSnapshotStatus
            // 
            this.lblSnapshotStatus.AutoSize = true;
            this.lblSnapshotStatus.BackColor = System.Drawing.Color.Black;
            this.lblSnapshotStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnapshotStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lblSnapshotStatus.Location = new System.Drawing.Point(15, 190);
            this.lblSnapshotStatus.Name = "lblSnapshotStatus";
            this.lblSnapshotStatus.Size = new System.Drawing.Size(56, 20);
            this.lblSnapshotStatus.TabIndex = 32;
            this.lblSnapshotStatus.Text = "Status";
            this.lblSnapshotStatus.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.numSeconds);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lstClipGaps);
            this.groupBox3.Controls.Add(this.lblClipGaps);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.lblClipRetention);
            this.groupBox3.Controls.Add(this.lblClipEndTime);
            this.groupBox3.Controls.Add(this.lblClipStartTime);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Location = new System.Drawing.Point(3, 493);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 274);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Video Query";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "before end of clip.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "seconds";
            // 
            // numSeconds
            // 
            this.numSeconds.Location = new System.Drawing.Point(85, 213);
            this.numSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(38, 22);
            this.numSeconds.TabIndex = 35;
            this.numSeconds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(57, 171);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 36);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "Tip: Double-Click to see snapshot of gap ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 33;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // lstClipGaps
            // 
            this.lstClipGaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstClipGaps.FormattingEnabled = true;
            this.lstClipGaps.Location = new System.Drawing.Point(214, 90);
            this.lstClipGaps.Name = "lstClipGaps";
            this.lstClipGaps.Size = new System.Drawing.Size(258, 173);
            this.lstClipGaps.TabIndex = 7;
            this.lstClipGaps.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstClipGaps_MouseDoubleClick);
            // 
            // lblClipGaps
            // 
            this.lblClipGaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClipGaps.AutoSize = true;
            this.lblClipGaps.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClipGaps.Location = new System.Drawing.Point(64, 108);
            this.lblClipGaps.Name = "lblClipGaps";
            this.lblClipGaps.Size = new System.Drawing.Size(44, 13);
            this.lblClipGaps.TabIndex = 7;
            this.lblClipGaps.Text = "(None)";
            this.lblClipGaps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(63, 90);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(129, 13);
            this.label26.TabIndex = 6;
            this.label26.Text = "Recording Gaps Found:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblClipRetention
            // 
            this.lblClipRetention.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClipRetention.AutoSize = true;
            this.lblClipRetention.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClipRetention.Location = new System.Drawing.Point(210, 63);
            this.lblClipRetention.Name = "lblClipRetention";
            this.lblClipRetention.Size = new System.Drawing.Size(66, 13);
            this.lblClipRetention.TabIndex = 5;
            this.lblClipRetention.Text = "(Retention)";
            // 
            // lblClipEndTime
            // 
            this.lblClipEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClipEndTime.AutoSize = true;
            this.lblClipEndTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClipEndTime.Location = new System.Drawing.Point(211, 41);
            this.lblClipEndTime.Name = "lblClipEndTime";
            this.lblClipEndTime.Size = new System.Drawing.Size(63, 13);
            this.lblClipEndTime.TabIndex = 4;
            this.lblClipEndTime.Text = "(End Time)";
            // 
            // lblClipStartTime
            // 
            this.lblClipStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClipStartTime.AutoSize = true;
            this.lblClipStartTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClipStartTime.Location = new System.Drawing.Point(211, 21);
            this.lblClipStartTime.Name = "lblClipStartTime";
            this.lblClipStartTime.Size = new System.Drawing.Size(67, 13);
            this.lblClipStartTime.TabIndex = 3;
            this.lblClipStartTime.Text = "(Start Time)";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(101, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Video Retention";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(122, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Latest Video";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(115, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Earliest Video";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGenerateRetentionReport
            // 
            this.btnGenerateRetentionReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateRetentionReport.Location = new System.Drawing.Point(641, 6);
            this.btnGenerateRetentionReport.Name = "btnGenerateRetentionReport";
            this.btnGenerateRetentionReport.Size = new System.Drawing.Size(231, 30);
            this.btnGenerateRetentionReport.TabIndex = 25;
            this.btnGenerateRetentionReport.Text = "Generate Camera Retention Report";
            this.btnGenerateRetentionReport.UseVisualStyleBackColor = true;
            this.btnGenerateRetentionReport.Click += new System.EventHandler(this.btnGenerateRetentionReport_Click);
            // 
            // btnNotRecording
            // 
            this.btnNotRecording.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotRecording.Location = new System.Drawing.Point(12, 94);
            this.btnNotRecording.Name = "btnNotRecording";
            this.btnNotRecording.Size = new System.Drawing.Size(155, 30);
            this.btnNotRecording.TabIndex = 12;
            this.btnNotRecording.Text = "NOT Recording";
            this.btnNotRecording.UseVisualStyleBackColor = true;
            this.btnNotRecording.Click += new System.EventHandler(this.btnNotRec_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(495, 611);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(319, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Associated Parent Device and Recorders for Selected Camera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Additional Quick Search";
            // 
            // btnSearchOffline
            // 
            this.btnSearchOffline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOffline.Location = new System.Drawing.Point(173, 94);
            this.btnSearchOffline.Name = "btnSearchOffline";
            this.btnSearchOffline.Size = new System.Drawing.Size(155, 30);
            this.btnSearchOffline.TabIndex = 6;
            this.btnSearchOffline.Text = "OFFLINE Cameras";
            this.btnSearchOffline.UseVisualStyleBackColor = true;
            this.btnSearchOffline.Click += new System.EventHandler(this.btnSearchOffline_Click);
            // 
            // olvAssocDevice
            // 
            this.olvAssocDevice.AllColumns.Add(this.olvColumn15);
            this.olvAssocDevice.AllColumns.Add(this.olvColumn16);
            this.olvAssocDevice.AllColumns.Add(this.olvColumn17);
            this.olvAssocDevice.AllColumns.Add(this.olvColumn18);
            this.olvAssocDevice.AllColumns.Add(this.olvColumn19);
            this.olvAssocDevice.AllColumns.Add(this.olvColumn20);
            this.olvAssocDevice.AllColumns.Add(this.olvColumn21);
            this.olvAssocDevice.AllColumns.Add(this.olvColumn22);
            this.olvAssocDevice.AllColumns.Add(this.olvColumn23);
            this.olvAssocDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvAssocDevice.CellEditUseWholeCell = false;
            this.olvAssocDevice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn15,
            this.olvColumn16,
            this.olvColumn17,
            this.olvColumn18,
            this.olvColumn19,
            this.olvColumn20,
            this.olvColumn21,
            this.olvColumn22,
            this.olvColumn23});
            this.olvAssocDevice.ContextMenuStrip = this.ctxDeviceToolkit;
            this.olvAssocDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAssocDevice.FullRowSelect = true;
            this.olvAssocDevice.HideSelection = false;
            this.olvAssocDevice.Location = new System.Drawing.Point(498, 627);
            this.olvAssocDevice.MultiSelect = false;
            this.olvAssocDevice.Name = "olvAssocDevice";
            this.olvAssocDevice.ShowGroups = false;
            this.olvAssocDevice.Size = new System.Drawing.Size(847, 138);
            this.olvAssocDevice.TabIndex = 5;
            this.olvAssocDevice.UseCompatibleStateImageBehavior = false;
            this.olvAssocDevice.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn15
            // 
            this.olvColumn15.AspectName = "name";
            this.olvColumn15.Text = "Name";
            this.olvColumn15.Width = 211;
            // 
            // olvColumn16
            // 
            this.olvColumn16.AspectName = "ip";
            this.olvColumn16.Text = "IP Address";
            this.olvColumn16.Width = 107;
            // 
            // olvColumn17
            // 
            this.olvColumn17.AspectName = "serial";
            this.olvColumn17.Text = "Serial Number";
            this.olvColumn17.Width = 105;
            // 
            // olvColumn18
            // 
            this.olvColumn18.AspectName = "model";
            this.olvColumn18.Text = "Model";
            this.olvColumn18.Width = 71;
            // 
            // olvColumn19
            // 
            this.olvColumn19.AspectName = "state";
            this.olvColumn19.Text = "Status";
            this.olvColumn19.Width = 68;
            // 
            // olvColumn20
            // 
            this.olvColumn20.AspectName = "version";
            this.olvColumn20.Text = "Version";
            this.olvColumn20.Width = 89;
            // 
            // olvColumn21
            // 
            this.olvColumn21.AspectName = "type";
            this.olvColumn21.Text = "Device Type";
            this.olvColumn21.Width = 92;
            // 
            // olvColumn22
            // 
            this.olvColumn22.AspectName = "commissioned";
            this.olvColumn22.Text = "Commissioned";
            this.olvColumn22.Width = 81;
            // 
            // olvColumn23
            // 
            this.olvColumn23.AspectName = "id";
            this.olvColumn23.Text = "GUID";
            this.olvColumn23.Width = 329;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search Result";
            // 
            // olvDatasourceResults
            // 
            this.olvDatasourceResults.AllColumns.Add(this.olvColumn24);
            this.olvDatasourceResults.AllColumns.Add(this.olvColumn4);
            this.olvDatasourceResults.AllColumns.Add(this.olvColumn5);
            this.olvDatasourceResults.AllColumns.Add(this.olvColumn7);
            this.olvDatasourceResults.AllColumns.Add(this.olvColumn25);
            this.olvDatasourceResults.AllColumns.Add(this.olvColumn26);
            this.olvDatasourceResults.AllColumns.Add(this.olvColumn27);
            this.olvDatasourceResults.AllColumns.Add(this.clmDS_GUID);
            this.olvDatasourceResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvDatasourceResults.CellEditUseWholeCell = false;
            this.olvDatasourceResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn24,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn7,
            this.olvColumn25,
            this.olvColumn26,
            this.olvColumn27,
            this.clmDS_GUID});
            this.olvDatasourceResults.ContextMenuStrip = this.ctxDeviceToolkit;
            this.olvDatasourceResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvDatasourceResults.FullRowSelect = true;
            this.olvDatasourceResults.HideSelection = false;
            this.olvDatasourceResults.Location = new System.Drawing.Point(497, 44);
            this.olvDatasourceResults.Name = "olvDatasourceResults";
            this.olvDatasourceResults.ShowGroups = false;
            this.olvDatasourceResults.Size = new System.Drawing.Size(851, 563);
            this.olvDatasourceResults.TabIndex = 3;
            this.olvDatasourceResults.UseAlternatingBackColors = true;
            this.olvDatasourceResults.UseCompatibleStateImageBehavior = false;
            this.olvDatasourceResults.View = System.Windows.Forms.View.Details;
            this.olvDatasourceResults.SelectedIndexChanged += new System.EventHandler(this.olcDatasourceResults_SelectedIndexChanged);
            // 
            // olvColumn24
            // 
            this.olvColumn24.AspectName = "number";
            this.olvColumn24.Text = "Number";
            this.olvColumn24.Width = 138;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "name";
            this.olvColumn4.Text = "Name";
            this.olvColumn4.Width = 136;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "ip";
            this.olvColumn5.Text = "IP Address";
            this.olvColumn5.Width = 144;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "state";
            this.olvColumn7.Text = "Status";
            this.olvColumn7.Width = 142;
            // 
            // olvColumn25
            // 
            this.olvColumn25.AspectName = "type";
            this.olvColumn25.Text = "Type";
            this.olvColumn25.Width = 82;
            // 
            // olvColumn26
            // 
            this.olvColumn26.AspectName = "capturing";
            this.olvColumn26.Text = "CAP";
            // 
            // olvColumn27
            // 
            this.olvColumn27.AspectName = "recording";
            this.olvColumn27.Text = "REC";
            this.olvColumn27.Width = 75;
            // 
            // clmDS_GUID
            // 
            this.clmDS_GUID.AspectName = "id";
            this.clmDS_GUID.Text = "GUID";
            this.clmDS_GUID.Width = 184;
            // 
            // picCamPreviewJPG
            // 
            this.picCamPreviewJPG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picCamPreviewJPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCamPreviewJPG.ErrorImage = global::VxCameraAuditor3.Properties.Resources.code_icon;
            this.picCamPreviewJPG.Image = global::VxCameraAuditor3.Properties.Resources.pelco_msi_logo;
            this.picCamPreviewJPG.InitialImage = global::VxCameraAuditor3.Properties.Resources.pelco_logo;
            this.picCamPreviewJPG.Location = new System.Drawing.Point(9, 174);
            this.picCamPreviewJPG.Name = "picCamPreviewJPG";
            this.picCamPreviewJPG.Size = new System.Drawing.Size(480, 314);
            this.picCamPreviewJPG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCamPreviewJPG.TabIndex = 24;
            this.picCamPreviewJPG.TabStop = false;
            this.picCamPreviewJPG.DoubleClick += new System.EventHandler(this.picCamPreviewJPG_DoubleClick);
            // 
            // btnSearchDataSrc
            // 
            this.btnSearchDataSrc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDataSrc.Location = new System.Drawing.Point(319, 46);
            this.btnSearchDataSrc.Name = "btnSearchDataSrc";
            this.btnSearchDataSrc.Size = new System.Drawing.Size(172, 30);
            this.btnSearchDataSrc.TabIndex = 2;
            this.btnSearchDataSrc.Text = "VX SEARCH";
            this.btnSearchDataSrc.UseVisualStyleBackColor = true;
            this.btnSearchDataSrc.Click += new System.EventHandler(this.btnSearchDataSrc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search for Cameras";
            // 
            // tabVUMainGUI
            // 
            this.tabVUMainGUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabVUMainGUI.Controls.Add(this.tabDashboard);
            this.tabVUMainGUI.Controls.Add(this.tabCameraSearch);
            this.tabVUMainGUI.Controls.Add(this.tabDeviceSearch);
            this.tabVUMainGUI.Controls.Add(this.tabRecorder);
            this.tabVUMainGUI.Controls.Add(this.tabUsers);
            this.tabVUMainGUI.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabVUMainGUI.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVUMainGUI.Location = new System.Drawing.Point(12, 108);
            this.tabVUMainGUI.Name = "tabVUMainGUI";
            this.tabVUMainGUI.SelectedIndex = 0;
            this.tabVUMainGUI.Size = new System.Drawing.Size(1359, 797);
            this.tabVUMainGUI.TabIndex = 11;
            this.tabVUMainGUI.SelectedIndexChanged += new System.EventHandler(this.tabVUMainGUI_SelectedIndexChanged);
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.groupBox12);
            this.tabDashboard.Controls.Add(this.groupBox11);
            this.tabDashboard.Controls.Add(this.lblOverviewSystemType);
            this.tabDashboard.Controls.Add(this.btnGetSystemDashboard);
            this.tabDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(1351, 771);
            this.tabDashboard.TabIndex = 6;
            this.tabDashboard.Text = "System Overview";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lblOverviewMonitorQty);
            this.groupBox12.Controls.Add(this.lblOverviewUIQty);
            this.groupBox12.Controls.Add(this.lblOverviewClientsQty);
            this.groupBox12.Location = new System.Drawing.Point(28, 468);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(403, 149);
            this.groupBox12.TabIndex = 14;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Client Devices";
            // 
            // lblOverviewMonitorQty
            // 
            this.lblOverviewMonitorQty.AutoSize = true;
            this.lblOverviewMonitorQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewMonitorQty.Location = new System.Drawing.Point(93, 103);
            this.lblOverviewMonitorQty.Name = "lblOverviewMonitorQty";
            this.lblOverviewMonitorQty.Size = new System.Drawing.Size(160, 25);
            this.lblOverviewMonitorQty.TabIndex = 9;
            this.lblOverviewMonitorQty.Text = "0 Shared Displays";
            // 
            // lblOverviewUIQty
            // 
            this.lblOverviewUIQty.AutoSize = true;
            this.lblOverviewUIQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewUIQty.Location = new System.Drawing.Point(93, 66);
            this.lblOverviewUIQty.Name = "lblOverviewUIQty";
            this.lblOverviewUIQty.Size = new System.Drawing.Size(145, 25);
            this.lblOverviewUIQty.TabIndex = 8;
            this.lblOverviewUIQty.Text = "0 VxOpsCenters";
            // 
            // lblOverviewClientsQty
            // 
            this.lblOverviewClientsQty.AutoSize = true;
            this.lblOverviewClientsQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewClientsQty.Location = new System.Drawing.Point(25, 28);
            this.lblOverviewClientsQty.Name = "lblOverviewClientsQty";
            this.lblOverviewClientsQty.Size = new System.Drawing.Size(164, 25);
            this.lblOverviewClientsQty.TabIndex = 6;
            this.lblOverviewClientsQty.Text = "0 Viewing Devices";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblOverviewASQty);
            this.groupBox11.Controls.Add(this.lblOverviewAIOQty);
            this.groupBox11.Controls.Add(this.lblOverviewNSMQty);
            this.groupBox11.Controls.Add(this.lblOverviewVXSQty);
            this.groupBox11.Controls.Add(this.lblOverviewMGQty);
            this.groupBox11.Controls.Add(this.lblOverviewCoreQty);
            this.groupBox11.Controls.Add(this.lblOverviewRecorderQty);
            this.groupBox11.Controls.Add(this.lblOverviewServersQty);
            this.groupBox11.Location = new System.Drawing.Point(28, 89);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(403, 362);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "System Servers";
            // 
            // lblOverviewASQty
            // 
            this.lblOverviewASQty.AutoSize = true;
            this.lblOverviewASQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewASQty.Location = new System.Drawing.Point(93, 181);
            this.lblOverviewASQty.Name = "lblOverviewASQty";
            this.lblOverviewASQty.Size = new System.Drawing.Size(176, 25);
            this.lblOverviewASQty.TabIndex = 13;
            this.lblOverviewASQty.Text = "0 Accessory Servers";
            // 
            // lblOverviewAIOQty
            // 
            this.lblOverviewAIOQty.AutoSize = true;
            this.lblOverviewAIOQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewAIOQty.Location = new System.Drawing.Point(93, 142);
            this.lblOverviewAIOQty.Name = "lblOverviewAIOQty";
            this.lblOverviewAIOQty.Size = new System.Drawing.Size(143, 25);
            this.lblOverviewAIOQty.TabIndex = 12;
            this.lblOverviewAIOQty.Text = "0 VxPro Servers";
            // 
            // lblOverviewNSMQty
            // 
            this.lblOverviewNSMQty.AutoSize = true;
            this.lblOverviewNSMQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewNSMQty.Location = new System.Drawing.Point(93, 314);
            this.lblOverviewNSMQty.Name = "lblOverviewNSMQty";
            this.lblOverviewNSMQty.Size = new System.Drawing.Size(141, 25);
            this.lblOverviewNSMQty.TabIndex = 11;
            this.lblOverviewNSMQty.Text = "0 Endura NSMs";
            // 
            // lblOverviewVXSQty
            // 
            this.lblOverviewVXSQty.AutoSize = true;
            this.lblOverviewVXSQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewVXSQty.Location = new System.Drawing.Point(93, 271);
            this.lblOverviewVXSQty.Name = "lblOverviewVXSQty";
            this.lblOverviewVXSQty.Size = new System.Drawing.Size(178, 25);
            this.lblOverviewVXSQty.TabIndex = 10;
            this.lblOverviewVXSQty.Text = "0 VxStorage Servers";
            // 
            // lblOverviewMGQty
            // 
            this.lblOverviewMGQty.AutoSize = true;
            this.lblOverviewMGQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewMGQty.Location = new System.Drawing.Point(93, 103);
            this.lblOverviewMGQty.Name = "lblOverviewMGQty";
            this.lblOverviewMGQty.Size = new System.Drawing.Size(165, 25);
            this.lblOverviewMGQty.TabIndex = 9;
            this.lblOverviewMGQty.Text = "0 Media Gateways";
            // 
            // lblOverviewCoreQty
            // 
            this.lblOverviewCoreQty.AutoSize = true;
            this.lblOverviewCoreQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewCoreQty.Location = new System.Drawing.Point(93, 66);
            this.lblOverviewCoreQty.Name = "lblOverviewCoreQty";
            this.lblOverviewCoreQty.Size = new System.Drawing.Size(75, 25);
            this.lblOverviewCoreQty.TabIndex = 8;
            this.lblOverviewCoreQty.Text = "0 Cores";
            // 
            // lblOverviewRecorderQty
            // 
            this.lblOverviewRecorderQty.AutoSize = true;
            this.lblOverviewRecorderQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewRecorderQty.Location = new System.Drawing.Point(25, 228);
            this.lblOverviewRecorderQty.Name = "lblOverviewRecorderQty";
            this.lblOverviewRecorderQty.Size = new System.Drawing.Size(208, 25);
            this.lblOverviewRecorderQty.TabIndex = 7;
            this.lblOverviewRecorderQty.Text = "0 Recorders (VXS/NSM)";
            // 
            // lblOverviewServersQty
            // 
            this.lblOverviewServersQty.AutoSize = true;
            this.lblOverviewServersQty.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewServersQty.Location = new System.Drawing.Point(25, 28);
            this.lblOverviewServersQty.Name = "lblOverviewServersQty";
            this.lblOverviewServersQty.Size = new System.Drawing.Size(331, 25);
            this.lblOverviewServersQty.TabIndex = 6;
            this.lblOverviewServersQty.Text = "0 System Servers (Core/MG/VxPro/AS)";
            // 
            // lblOverviewSystemType
            // 
            this.lblOverviewSystemType.AutoSize = true;
            this.lblOverviewSystemType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverviewSystemType.Location = new System.Drawing.Point(356, 24);
            this.lblOverviewSystemType.Name = "lblOverviewSystemType";
            this.lblOverviewSystemType.Size = new System.Drawing.Size(275, 30);
            this.lblOverviewSystemType.TabIndex = 2;
            this.lblOverviewSystemType.Text = "Your system is UNKNOWN";
            // 
            // btnGetSystemDashboard
            // 
            this.btnGetSystemDashboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSystemDashboard.Location = new System.Drawing.Point(28, 22);
            this.btnGetSystemDashboard.Name = "btnGetSystemDashboard";
            this.btnGetSystemDashboard.Size = new System.Drawing.Size(305, 37);
            this.btnGetSystemDashboard.TabIndex = 0;
            this.btnGetSystemDashboard.Text = "Get/Refresh System Summary";
            this.btnGetSystemDashboard.UseVisualStyleBackColor = true;
            this.btnGetSystemDashboard.Click += new System.EventHandler(this.btnGetSystemDashboard_Click);
            // 
            // tabDeviceSearch
            // 
            this.tabDeviceSearch.Controls.Add(this.btnAddDeviceByCSV);
            this.tabDeviceSearch.Controls.Add(this.btnManualAddOneDevice);
            this.tabDeviceSearch.Controls.Add(this.groupBox10);
            this.tabDeviceSearch.Controls.Add(this.groupBox9);
            this.tabDeviceSearch.Controls.Add(this.label42);
            this.tabDeviceSearch.Controls.Add(this.olvAssocDataSources);
            this.tabDeviceSearch.Controls.Add(this.txtDeviceAdvFilter);
            this.tabDeviceSearch.Controls.Add(this.label40);
            this.tabDeviceSearch.Controls.Add(this.lblSelectedDevice);
            this.tabDeviceSearch.Controls.Add(this.button4);
            this.tabDeviceSearch.Controls.Add(this.label39);
            this.tabDeviceSearch.Controls.Add(this.olvDeviceResults);
            this.tabDeviceSearch.Controls.Add(this.label38);
            this.tabDeviceSearch.Controls.Add(this.btnSearchDevice);
            this.tabDeviceSearch.Controls.Add(this.txtDeviceSearchTerm);
            this.tabDeviceSearch.Location = new System.Drawing.Point(4, 22);
            this.tabDeviceSearch.Name = "tabDeviceSearch";
            this.tabDeviceSearch.Size = new System.Drawing.Size(1351, 771);
            this.tabDeviceSearch.TabIndex = 5;
            this.tabDeviceSearch.Text = "Device Manager";
            this.tabDeviceSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddDeviceByCSV
            // 
            this.btnAddDeviceByCSV.Location = new System.Drawing.Point(1088, 541);
            this.btnAddDeviceByCSV.Name = "btnAddDeviceByCSV";
            this.btnAddDeviceByCSV.Size = new System.Drawing.Size(250, 30);
            this.btnAddDeviceByCSV.TabIndex = 54;
            this.btnAddDeviceByCSV.Text = "Manually add devices using CSV file...";
            this.btnAddDeviceByCSV.UseVisualStyleBackColor = true;
            // 
            // btnManualAddOneDevice
            // 
            this.btnManualAddOneDevice.Location = new System.Drawing.Point(832, 541);
            this.btnManualAddOneDevice.Name = "btnManualAddOneDevice";
            this.btnManualAddOneDevice.Size = new System.Drawing.Size(250, 30);
            this.btnManualAddOneDevice.TabIndex = 53;
            this.btnManualAddOneDevice.Text = "Manually add ONE device by IP/Hostname";
            this.btnManualAddOneDevice.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.dateTimePicker1);
            this.groupBox10.Controls.Add(this.btnLastModified);
            this.groupBox10.Controls.Add(this.btnUncomissioned);
            this.groupBox10.Controls.Add(this.btnOfflineDevices);
            this.groupBox10.Location = new System.Drawing.Point(663, 7);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(402, 89);
            this.groupBox10.TabIndex = 52;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Additional Quick Search";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 29);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnLastModified
            // 
            this.btnLastModified.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastModified.Location = new System.Drawing.Point(209, 17);
            this.btnLastModified.Name = "btnLastModified";
            this.btnLastModified.Size = new System.Drawing.Size(185, 29);
            this.btnLastModified.TabIndex = 2;
            this.btnLastModified.Text = "Last Modified On";
            this.btnLastModified.UseVisualStyleBackColor = true;
            this.btnLastModified.Click += new System.EventHandler(this.btnLastModified_Click);
            // 
            // btnUncomissioned
            // 
            this.btnUncomissioned.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUncomissioned.Location = new System.Drawing.Point(20, 52);
            this.btnUncomissioned.Name = "btnUncomissioned";
            this.btnUncomissioned.Size = new System.Drawing.Size(180, 30);
            this.btnUncomissioned.TabIndex = 1;
            this.btnUncomissioned.Text = "NOT Commissioned";
            this.btnUncomissioned.UseVisualStyleBackColor = true;
            // 
            // btnOfflineDevices
            // 
            this.btnOfflineDevices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOfflineDevices.Location = new System.Drawing.Point(20, 17);
            this.btnOfflineDevices.Name = "btnOfflineDevices";
            this.btnOfflineDevices.Size = new System.Drawing.Size(180, 30);
            this.btnOfflineDevices.TabIndex = 0;
            this.btnOfflineDevices.Text = "OFFLINE";
            this.btnOfflineDevices.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnExportCSV_Device);
            this.groupBox9.Controls.Add(this.btnImportCSV_Device);
            this.groupBox9.Location = new System.Drawing.Point(1071, 7);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(267, 90);
            this.groupBox9.TabIndex = 51;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Edit Device Names";
            // 
            // btnExportCSV_Device
            // 
            this.btnExportCSV_Device.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCSV_Device.Location = new System.Drawing.Point(19, 18);
            this.btnExportCSV_Device.Name = "btnExportCSV_Device";
            this.btnExportCSV_Device.Size = new System.Drawing.Size(231, 30);
            this.btnExportCSV_Device.TabIndex = 43;
            this.btnExportCSV_Device.Text = "Export current list to CSV File";
            this.btnExportCSV_Device.UseVisualStyleBackColor = true;
            // 
            // btnImportCSV_Device
            // 
            this.btnImportCSV_Device.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportCSV_Device.Location = new System.Drawing.Point(19, 54);
            this.btnImportCSV_Device.Name = "btnImportCSV_Device";
            this.btnImportCSV_Device.Size = new System.Drawing.Size(231, 30);
            this.btnImportCSV_Device.TabIndex = 44;
            this.btnImportCSV_Device.Text = "Import CSV File for Batch Update";
            this.btnImportCSV_Device.UseVisualStyleBackColor = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(5, 589);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(230, 13);
            this.label42.TabIndex = 50;
            this.label42.Text = "Associated DataSources for selected device:";
            // 
            // olvAssocDataSources
            // 
            this.olvAssocDataSources.AllColumns.Add(this.clmAssocDSNumber);
            this.olvAssocDataSources.AllColumns.Add(this.clmAssocDSName);
            this.olvAssocDataSources.AllColumns.Add(this.clmAssocDSIP);
            this.olvAssocDataSources.AllColumns.Add(this.clmAssocDSStatus);
            this.olvAssocDataSources.AllColumns.Add(this.clmAssocDSType);
            this.olvAssocDataSources.AllColumns.Add(this.clmAssocDSCap);
            this.olvAssocDataSources.AllColumns.Add(this.clmAssocDSRec);
            this.olvAssocDataSources.AllColumns.Add(this.clmAssocDSGUID);
            this.olvAssocDataSources.CellEditUseWholeCell = false;
            this.olvAssocDataSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAssocDSNumber,
            this.clmAssocDSName,
            this.clmAssocDSIP,
            this.clmAssocDSStatus,
            this.clmAssocDSType,
            this.clmAssocDSCap,
            this.clmAssocDSRec,
            this.clmAssocDSGUID});
            this.olvAssocDataSources.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAssocDataSources.FullRowSelect = true;
            this.olvAssocDataSources.HideSelection = false;
            this.olvAssocDataSources.Location = new System.Drawing.Point(8, 605);
            this.olvAssocDataSources.Name = "olvAssocDataSources";
            this.olvAssocDataSources.ShowGroups = false;
            this.olvAssocDataSources.Size = new System.Drawing.Size(1330, 140);
            this.olvAssocDataSources.TabIndex = 49;
            this.olvAssocDataSources.UseCompatibleStateImageBehavior = false;
            this.olvAssocDataSources.View = System.Windows.Forms.View.Details;
            // 
            // clmAssocDSNumber
            // 
            this.clmAssocDSNumber.AspectName = "number";
            this.clmAssocDSNumber.Text = "Number";
            this.clmAssocDSNumber.Width = 90;
            // 
            // clmAssocDSName
            // 
            this.clmAssocDSName.AspectName = "name";
            this.clmAssocDSName.Text = "Name";
            this.clmAssocDSName.Width = 117;
            // 
            // clmAssocDSIP
            // 
            this.clmAssocDSIP.AspectName = "ip";
            this.clmAssocDSIP.Text = "IP Address";
            this.clmAssocDSIP.Width = 179;
            // 
            // clmAssocDSStatus
            // 
            this.clmAssocDSStatus.AspectName = "state";
            this.clmAssocDSStatus.Text = "Status";
            this.clmAssocDSStatus.Width = 94;
            // 
            // clmAssocDSType
            // 
            this.clmAssocDSType.AspectName = "type";
            this.clmAssocDSType.Text = "Type";
            this.clmAssocDSType.Width = 88;
            // 
            // clmAssocDSCap
            // 
            this.clmAssocDSCap.AspectName = "capturing";
            this.clmAssocDSCap.Text = "CAP";
            this.clmAssocDSCap.Width = 100;
            // 
            // clmAssocDSRec
            // 
            this.clmAssocDSRec.AspectName = "recording";
            this.clmAssocDSRec.Text = "REC";
            this.clmAssocDSRec.Width = 123;
            // 
            // clmAssocDSGUID
            // 
            this.clmAssocDSGUID.AspectName = "id";
            this.clmAssocDSGUID.Text = "GUID";
            this.clmAssocDSGUID.Width = 145;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(16, 550);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(89, 13);
            this.label40.TabIndex = 46;
            this.label40.Text = "Selected Device:";
            // 
            // lblSelectedDevice
            // 
            this.lblSelectedDevice.AutoSize = true;
            this.lblSelectedDevice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDevice.Location = new System.Drawing.Point(108, 537);
            this.lblSelectedDevice.Name = "lblSelectedDevice";
            this.lblSelectedDevice.Size = new System.Drawing.Size(171, 30);
            this.lblSelectedDevice.TabIndex = 45;
            this.lblSelectedDevice.Text = "(None Selected)";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(616, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 0);
            this.button4.TabIndex = 42;
            this.button4.Text = "Generate Camera Retention Report";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(5, 87);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(76, 13);
            this.label39.TabIndex = 41;
            this.label39.Text = "Search Result";
            // 
            // olvDeviceResults
            // 
            this.olvDeviceResults.AllColumns.Add(this.clmDeviceName);
            this.olvDeviceResults.AllColumns.Add(this.clmDeviceIP);
            this.olvDeviceResults.AllColumns.Add(this.clmDeviceModel);
            this.olvDeviceResults.AllColumns.Add(this.clmDeviceType);
            this.olvDeviceResults.AllColumns.Add(this.clmDeviceVersion);
            this.olvDeviceResults.AllColumns.Add(this.clmDeviceSerial);
            this.olvDeviceResults.AllColumns.Add(this.clmDeviceState);
            this.olvDeviceResults.AllColumns.Add(this.clmDeviceVendor);
            this.olvDeviceResults.AllColumns.Add(this.clmDeviceCommissioned);
            this.olvDeviceResults.AllColumns.Add(this.clmDeviceGUID);
            this.olvDeviceResults.CellEditUseWholeCell = false;
            this.olvDeviceResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmDeviceName,
            this.clmDeviceIP,
            this.clmDeviceModel,
            this.clmDeviceType,
            this.clmDeviceVersion,
            this.clmDeviceSerial,
            this.clmDeviceState,
            this.clmDeviceVendor,
            this.clmDeviceCommissioned,
            this.clmDeviceGUID});
            this.olvDeviceResults.ContextMenuStrip = this.ctxDeviceToolkit;
            this.olvDeviceResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvDeviceResults.FullRowSelect = true;
            this.olvDeviceResults.HideSelection = false;
            this.olvDeviceResults.Location = new System.Drawing.Point(8, 103);
            this.olvDeviceResults.Name = "olvDeviceResults";
            this.olvDeviceResults.ShowGroups = false;
            this.olvDeviceResults.Size = new System.Drawing.Size(1330, 431);
            this.olvDeviceResults.TabIndex = 40;
            this.olvDeviceResults.UseCompatibleStateImageBehavior = false;
            this.olvDeviceResults.View = System.Windows.Forms.View.Details;
            this.olvDeviceResults.SelectedIndexChanged += new System.EventHandler(this.olvDeviceResults_SelectedIndexChanged);
            // 
            // clmDeviceName
            // 
            this.clmDeviceName.AspectName = "name";
            this.clmDeviceName.Text = "Name";
            this.clmDeviceName.Width = 129;
            // 
            // clmDeviceIP
            // 
            this.clmDeviceIP.AspectName = "ip";
            this.clmDeviceIP.Text = "IP Address";
            this.clmDeviceIP.Width = 134;
            // 
            // clmDeviceModel
            // 
            this.clmDeviceModel.AspectName = "model";
            this.clmDeviceModel.Text = "Model";
            this.clmDeviceModel.Width = 151;
            // 
            // clmDeviceType
            // 
            this.clmDeviceType.AspectName = "type";
            this.clmDeviceType.Text = "Type";
            this.clmDeviceType.Width = 193;
            // 
            // clmDeviceVersion
            // 
            this.clmDeviceVersion.AspectName = "version";
            this.clmDeviceVersion.Text = "Version";
            this.clmDeviceVersion.Width = 135;
            // 
            // clmDeviceSerial
            // 
            this.clmDeviceSerial.AspectName = "serial";
            this.clmDeviceSerial.Text = "Serial";
            this.clmDeviceSerial.Width = 121;
            // 
            // clmDeviceState
            // 
            this.clmDeviceState.AspectName = "state";
            this.clmDeviceState.Text = "Status";
            this.clmDeviceState.Width = 70;
            // 
            // clmDeviceVendor
            // 
            this.clmDeviceVendor.AspectName = "vendor";
            this.clmDeviceVendor.Text = "Vendor";
            this.clmDeviceVendor.Width = 85;
            // 
            // clmDeviceCommissioned
            // 
            this.clmDeviceCommissioned.AspectName = "commissioned";
            this.clmDeviceCommissioned.Text = "Commissioned";
            this.clmDeviceCommissioned.Width = 111;
            // 
            // clmDeviceGUID
            // 
            this.clmDeviceGUID.AspectName = "id";
            this.clmDeviceGUID.Text = "GUID";
            this.clmDeviceGUID.Width = 326;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(5, 20);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(169, 13);
            this.label38.TabIndex = 39;
            this.label38.Text = "Search for Devices in Vx System:";
            // 
            // btnSearchDevice
            // 
            this.btnSearchDevice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDevice.Location = new System.Drawing.Point(322, 36);
            this.btnSearchDevice.Name = "btnSearchDevice";
            this.btnSearchDevice.Size = new System.Drawing.Size(186, 33);
            this.btnSearchDevice.TabIndex = 38;
            this.btnSearchDevice.Text = "VX SEARCH";
            this.btnSearchDevice.UseVisualStyleBackColor = true;
            this.btnSearchDevice.Click += new System.EventHandler(this.btnSearchDevice_Click);
            // 
            // txtDeviceSearchTerm
            // 
            this.txtDeviceSearchTerm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceSearchTerm.Location = new System.Drawing.Point(7, 36);
            this.txtDeviceSearchTerm.Name = "txtDeviceSearchTerm";
            this.txtDeviceSearchTerm.Size = new System.Drawing.Size(309, 33);
            this.txtDeviceSearchTerm.TabIndex = 37;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.btnExportUserCSV);
            this.tabUsers.Controls.Add(this.groupBox8);
            this.tabUsers.Controls.Add(this.groupBox7);
            this.tabUsers.Controls.Add(this.label36);
            this.tabUsers.Controls.Add(this.label32);
            this.tabUsers.Controls.Add(this.cmbRoleList);
            this.tabUsers.Controls.Add(this.lblSelectedUserName);
            this.tabUsers.Controls.Add(this.label31);
            this.tabUsers.Controls.Add(this.btnSearchUser);
            this.tabUsers.Controls.Add(this.groupBox6);
            this.tabUsers.Controls.Add(this.groupBox5);
            this.tabUsers.Controls.Add(this.txtUserSearchTerm);
            this.tabUsers.Controls.Add(this.label11);
            this.tabUsers.Controls.Add(this.olvUserList);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(1351, 771);
            this.tabUsers.TabIndex = 4;
            this.tabUsers.Text = "User Manager";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // btnExportUserCSV
            // 
            this.btnExportUserCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportUserCSV.Location = new System.Drawing.Point(1108, 497);
            this.btnExportUserCSV.Name = "btnExportUserCSV";
            this.btnExportUserCSV.Size = new System.Drawing.Size(223, 43);
            this.btnExportUserCSV.TabIndex = 44;
            this.btnExportUserCSV.Text = "Export current user list to CSV";
            this.btnExportUserCSV.UseVisualStyleBackColor = true;
            this.btnExportUserCSV.Click += new System.EventHandler(this.btnExportUserCSV_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnImportUserCSV);
            this.groupBox8.Controls.Add(this.label37);
            this.groupBox8.Location = new System.Drawing.Point(10, 575);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(308, 174);
            this.groupBox8.TabIndex = 43;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Batch Import (CSV)";
            // 
            // btnImportUserCSV
            // 
            this.btnImportUserCSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportUserCSV.Location = new System.Drawing.Point(34, 112);
            this.btnImportUserCSV.Name = "btnImportUserCSV";
            this.btnImportUserCSV.Size = new System.Drawing.Size(243, 40);
            this.btnImportUserCSV.TabIndex = 30;
            this.btnImportUserCSV.Text = "Import Users from CSV File";
            this.btnImportUserCSV.UseVisualStyleBackColor = true;
            this.btnImportUserCSV.Click += new System.EventHandler(this.btnImportUserCSV_Click);
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(31, 18);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(247, 94);
            this.label37.TabIndex = 30;
            this.label37.Text = "Batch import users from a CSV file. CSV must be formatted correctly. The users wi" +
    "ll be asked to change their password at their login. Initial password is set to " +
    "123456789.";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.olvAssocPhoneNumbers);
            this.groupBox7.Controls.Add(this.olvAssocRoles);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Location = new System.Drawing.Point(332, 542);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(831, 208);
            this.groupBox7.TabIndex = 42;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Associated User Properties";
            // 
            // olvAssocPhoneNumbers
            // 
            this.olvAssocPhoneNumbers.AllColumns.Add(this.clmPhoneType);
            this.olvAssocPhoneNumbers.AllColumns.Add(this.clmPhoneNumber);
            this.olvAssocPhoneNumbers.CellEditUseWholeCell = false;
            this.olvAssocPhoneNumbers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmPhoneType,
            this.clmPhoneNumber});
            this.olvAssocPhoneNumbers.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAssocPhoneNumbers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvAssocPhoneNumbers.FullRowSelect = true;
            this.olvAssocPhoneNumbers.HideSelection = false;
            this.olvAssocPhoneNumbers.Location = new System.Drawing.Point(368, 52);
            this.olvAssocPhoneNumbers.Name = "olvAssocPhoneNumbers";
            this.olvAssocPhoneNumbers.ShowGroups = false;
            this.olvAssocPhoneNumbers.Size = new System.Drawing.Size(444, 150);
            this.olvAssocPhoneNumbers.TabIndex = 41;
            this.olvAssocPhoneNumbers.UseCompatibleStateImageBehavior = false;
            this.olvAssocPhoneNumbers.View = System.Windows.Forms.View.Details;
            // 
            // clmPhoneType
            // 
            this.clmPhoneType.AspectName = "type";
            this.clmPhoneType.Text = "Type";
            this.clmPhoneType.Width = 97;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.AspectName = "number";
            this.clmPhoneNumber.Text = "Phone Numbers";
            this.clmPhoneNumber.Width = 194;
            // 
            // olvAssocRoles
            // 
            this.olvAssocRoles.AllColumns.Add(this.clmAssocRoles);
            this.olvAssocRoles.CellEditUseWholeCell = false;
            this.olvAssocRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAssocRoles});
            this.olvAssocRoles.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAssocRoles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvAssocRoles.FullRowSelect = true;
            this.olvAssocRoles.HideSelection = false;
            this.olvAssocRoles.Location = new System.Drawing.Point(6, 52);
            this.olvAssocRoles.Name = "olvAssocRoles";
            this.olvAssocRoles.ShowGroups = false;
            this.olvAssocRoles.Size = new System.Drawing.Size(356, 150);
            this.olvAssocRoles.TabIndex = 29;
            this.olvAssocRoles.UseCompatibleStateImageBehavior = false;
            this.olvAssocRoles.View = System.Windows.Forms.View.Details;
            // 
            // clmAssocRoles
            // 
            this.clmAssocRoles.AspectName = "name";
            this.clmAssocRoles.Text = "Role Name";
            this.clmAssocRoles.Width = 330;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 33);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(99, 13);
            this.label28.TabIndex = 32;
            this.label28.Text = "Associated Role(s)";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(365, 33);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 13);
            this.label35.TabIndex = 40;
            this.label35.Text = "Phone Numbers";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(335, 512);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(79, 13);
            this.label36.TabIndex = 41;
            this.label36.Text = "Selected User:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 174);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(82, 13);
            this.label32.TabIndex = 39;
            this.label32.Text = "Filter by Roles:";
            // 
            // cmbRoleList
            // 
            this.cmbRoleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoleList.Enabled = false;
            this.cmbRoleList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoleList.FormattingEnabled = true;
            this.cmbRoleList.Location = new System.Drawing.Point(12, 190);
            this.cmbRoleList.Name = "cmbRoleList";
            this.cmbRoleList.Size = new System.Drawing.Size(307, 29);
            this.cmbRoleList.Sorted = true;
            this.cmbRoleList.TabIndex = 38;
            this.cmbRoleList.SelectedIndexChanged += new System.EventHandler(this.cmbRoleList_SelectedIndexChanged);
            // 
            // lblSelectedUserName
            // 
            this.lblSelectedUserName.AutoSize = true;
            this.lblSelectedUserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedUserName.Location = new System.Drawing.Point(420, 499);
            this.lblSelectedUserName.Name = "lblSelectedUserName";
            this.lblSelectedUserName.Size = new System.Drawing.Size(171, 30);
            this.lblSelectedUserName.TabIndex = 37;
            this.lblSelectedUserName.Text = "(None Selected)";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 15);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 13);
            this.label31.TabIndex = 36;
            this.label31.Text = "Search for Users";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.Location = new System.Drawing.Point(144, 70);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(175, 40);
            this.btnSearchUser.TabIndex = 35;
            this.btnSearchUser.Text = "VX SEARCH";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.txtQuickAddUser);
            this.groupBox6.Controls.Add(this.btnAddUser);
            this.groupBox6.Location = new System.Drawing.Point(10, 225);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(309, 173);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Quick Add User";
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(30, 18);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(247, 63);
            this.label29.TabIndex = 2;
            this.label29.Text = "Type a desired username, and click Add User. Password is automatically set to 123" +
    "456789.";
            // 
            // txtQuickAddUser
            // 
            this.txtQuickAddUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuickAddUser.Location = new System.Drawing.Point(33, 84);
            this.txtQuickAddUser.Name = "txtQuickAddUser";
            this.txtQuickAddUser.Size = new System.Drawing.Size(243, 33);
            this.txtQuickAddUser.TabIndex = 1;
            this.txtQuickAddUser.TextChanged += new System.EventHandler(this.txtQuickAddUser_TextChanged);
            this.txtQuickAddUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuickAddUser_KeyDown);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(34, 123);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(243, 40);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Quick Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.btnImportUserTXT);
            this.groupBox5.Location = new System.Drawing.Point(10, 404);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(309, 162);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Batch Import (TXT)";
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(31, 27);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(247, 71);
            this.label30.TabIndex = 29;
            this.label30.Text = "Batch import users from a text file, Username ONLY. The users will be asked to ch" +
    "ange their password at their login. Initial password is set to 123456789.";
            // 
            // btnImportUserTXT
            // 
            this.btnImportUserTXT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportUserTXT.Location = new System.Drawing.Point(34, 110);
            this.btnImportUserTXT.Name = "btnImportUserTXT";
            this.btnImportUserTXT.Size = new System.Drawing.Size(243, 40);
            this.btnImportUserTXT.TabIndex = 28;
            this.btnImportUserTXT.Text = "Import Users from TXT File";
            this.btnImportUserTXT.UseVisualStyleBackColor = true;
            this.btnImportUserTXT.Click += new System.EventHandler(this.btnImportUserTXT_Click);
            // 
            // txtUserSearchTerm
            // 
            this.txtUserSearchTerm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserSearchTerm.Location = new System.Drawing.Point(10, 31);
            this.txtUserSearchTerm.Name = "txtUserSearchTerm";
            this.txtUserSearchTerm.Size = new System.Drawing.Size(309, 33);
            this.txtUserSearchTerm.TabIndex = 31;
            this.txtUserSearchTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserSearchTerm_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(322, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "User Search Result";
            // 
            // olvUserList
            // 
            this.olvUserList.AllColumns.Add(this.clmUsername);
            this.olvUserList.AllColumns.Add(this.clmFname);
            this.olvUserList.AllColumns.Add(this.clmLname);
            this.olvUserList.AllColumns.Add(this.clmEmail);
            this.olvUserList.AllColumns.Add(this.clmEmpID);
            this.olvUserList.AllColumns.Add(this.clmNotes);
            this.olvUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvUserList.CellEditUseWholeCell = false;
            this.olvUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmUsername,
            this.clmFname,
            this.clmLname,
            this.clmEmail,
            this.clmEmpID,
            this.clmNotes});
            this.olvUserList.ContextMenuStrip = this.ctxUserToolkit;
            this.olvUserList.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvUserList.FullRowSelect = true;
            this.olvUserList.HideSelection = false;
            this.olvUserList.Location = new System.Drawing.Point(325, 31);
            this.olvUserList.Name = "olvUserList";
            this.olvUserList.ShowGroups = false;
            this.olvUserList.Size = new System.Drawing.Size(1006, 461);
            this.olvUserList.TabIndex = 27;
            this.olvUserList.UseCompatibleStateImageBehavior = false;
            this.olvUserList.View = System.Windows.Forms.View.Details;
            this.olvUserList.SelectedIndexChanged += new System.EventHandler(this.olvUserList_SelectedIndexChanged);
            // 
            // clmUsername
            // 
            this.clmUsername.AspectName = "name";
            this.clmUsername.Text = "Username (Login ID)";
            this.clmUsername.Width = 161;
            // 
            // clmFname
            // 
            this.clmFname.AspectName = "first_name";
            this.clmFname.Text = "First Name";
            this.clmFname.Width = 148;
            // 
            // clmLname
            // 
            this.clmLname.AspectName = "last_name";
            this.clmLname.Text = "Last Name";
            this.clmLname.Width = 151;
            // 
            // clmEmail
            // 
            this.clmEmail.AspectName = "email";
            this.clmEmail.Text = "E-Mail Address";
            this.clmEmail.Width = 166;
            // 
            // clmEmpID
            // 
            this.clmEmpID.AspectName = "employee_id";
            this.clmEmpID.Text = "Employee ID";
            this.clmEmpID.Width = 194;
            // 
            // clmNotes
            // 
            this.clmNotes.AspectName = "note";
            this.clmNotes.Text = "Notes";
            this.clmNotes.Width = 184;
            // 
            // ctxUserToolkit
            // 
            this.ctxUserToolkit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.editToolStripMenuItem,
            this.ctxMenuResetPwd,
            this.ctxMenuAssignNewRole,
            this.ctxDeleteUsers});
            this.ctxUserToolkit.Name = "ctxUserToolkit";
            this.ctxUserToolkit.Size = new System.Drawing.Size(161, 119);
            this.ctxUserToolkit.Opening += new System.ComponentModel.CancelEventHandler(this.ctxUserToolkit_Opening);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox2.Text = "Users";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editToolStripMenuItem.Text = "Edit...";
            // 
            // ctxMenuResetPwd
            // 
            this.ctxMenuResetPwd.Name = "ctxMenuResetPwd";
            this.ctxMenuResetPwd.Size = new System.Drawing.Size(160, 22);
            this.ctxMenuResetPwd.Text = "Reset Password";
            this.ctxMenuResetPwd.Click += new System.EventHandler(this.ctxMenuResetPwd_Click);
            // 
            // ctxMenuAssignNewRole
            // 
            this.ctxMenuAssignNewRole.Name = "ctxMenuAssignNewRole";
            this.ctxMenuAssignNewRole.Size = new System.Drawing.Size(160, 22);
            this.ctxMenuAssignNewRole.Text = "Assign a Role";
            this.ctxMenuAssignNewRole.Click += new System.EventHandler(this.ctxMenuAssignNewRole_Click);
            // 
            // ctxDeleteUsers
            // 
            this.ctxDeleteUsers.Name = "ctxDeleteUsers";
            this.ctxDeleteUsers.Size = new System.Drawing.Size(160, 22);
            this.ctxDeleteUsers.Text = "Delete";
            this.ctxDeleteUsers.Click += new System.EventHandler(this.ctxDeleteUsers_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label44);
            this.groupBox13.Controls.Add(this.label43);
            this.groupBox13.Controls.Add(this.label41);
            this.groupBox13.Controls.Add(this.prgVolumeSpace);
            this.groupBox13.Controls.Add(this.cmbVolumes);
            this.groupBox13.Controls.Add(this.label27);
            this.groupBox13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(326, 601);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(339, 148);
            this.groupBox13.TabIndex = 9;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Recording Volumes";
            // 
            // prgVolumeSpace
            // 
            this.prgVolumeSpace.Location = new System.Drawing.Point(69, 65);
            this.prgVolumeSpace.Name = "prgVolumeSpace";
            this.prgVolumeSpace.Size = new System.Drawing.Size(264, 41);
            this.prgVolumeSpace.TabIndex = 22;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(10, 65);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(53, 21);
            this.label41.TabIndex = 23;
            this.label41.Text = "Usage";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(65, 109);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(61, 21);
            this.label43.TabIndex = 24;
            this.label43.Text = "label43";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(194, 109);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(61, 21);
            this.label44.TabIndex = 25;
            this.label44.Text = "label44";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 933);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabVUMainGUI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vx Quick System Auditor 3";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ctxDeviceToolkit.ResumeLayout(false);
            this.ctxDeviceToolkit.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabRecorder.ResumeLayout(false);
            this.tabRecorder.PerformLayout();
            this.grpVxsDiag.ResumeLayout(false);
            this.grpVxsDiag.PerformLayout();
            this.grpBoxRecorderDetail.ResumeLayout(false);
            this.grpBoxRecorderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvRecorderAssocDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvRecorderSearchResult)).EndInit();
            this.tabCameraSearch.ResumeLayout(false);
            this.tabCameraSearch.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssocDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvDatasourceResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamPreviewJPG)).EndInit();
            this.tabVUMainGUI.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabDeviceSearch.ResumeLayout(false);
            this.tabDeviceSearch.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvAssocDataSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvDeviceResults)).EndInit();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssocPhoneNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olvAssocRoles)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvUserList)).EndInit();
            this.ctxUserToolkit.ResumeLayout(false);
            this.ctxUserToolkit.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMessage;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToVxCoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblConsoleWindow;
        private System.Windows.Forms.ToolStripStatusLabel lblAuxResultDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSvrAddr;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkDisplayPreview;
        private System.Windows.Forms.ContextMenuStrip ctxDeviceToolkit;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuPing;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuSSH;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuOpenWeb;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctxCopyIPAddr;
        private System.Windows.Forms.ToolStripMenuItem ctxCopyGUID;
        private System.Windows.Forms.SaveFileDialog saveVUFilesDialog;
        private System.Windows.Forms.ToolTip toolTipVU;
        private System.Windows.Forms.OpenFileDialog openTXTDialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbSelectAggMember;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ImageList vuImageList;
        private System.Windows.Forms.TabPage tabRecorder;
        private System.Windows.Forms.Label lblRecorderAssocDS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalRecorders;
        private System.Windows.Forms.GroupBox grpBoxRecorderDetail;
        private System.Windows.Forms.Label lblRecorderUnitVersion;
        private BrightIdeasSoftware.ObjectListView olvRecorderAssocDS;
        private BrightIdeasSoftware.OLVColumn olvColumn56;
        private BrightIdeasSoftware.OLVColumn olvColumn57;
        private BrightIdeasSoftware.OLVColumn olvColumn58;
        private BrightIdeasSoftware.OLVColumn olvColumn59;
        private BrightIdeasSoftware.OLVColumn olvColumn60;
        private BrightIdeasSoftware.OLVColumn olvColumn61;
        private BrightIdeasSoftware.OLVColumn olvColumn62;
        private System.Windows.Forms.Button btnGetAllRecorders;
        private BrightIdeasSoftware.ObjectListView olvRecorderSearchResult;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn46;
        private BrightIdeasSoftware.OLVColumn olvColumn52;
        private BrightIdeasSoftware.OLVColumn olvColumn53;
        private BrightIdeasSoftware.OLVColumn olvColumn54;
        private BrightIdeasSoftware.OLVColumn olvColumn55;
        private System.Windows.Forms.TabPage tabCameraSearch;
        private System.Windows.Forms.Button btnDSAdvFilter;
        private System.Windows.Forms.TextBox txtDSAdvFilter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstClipGaps;
        private System.Windows.Forms.Label lblClipGaps;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblClipRetention;
        private System.Windows.Forms.Label lblClipEndTime;
        private System.Windows.Forms.Label lblClipStartTime;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnGenerateRetentionReport;
        private System.Windows.Forms.Button btnNotRecording;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchOffline;
        private System.Windows.Forms.PictureBox picCamPreviewJPG;
        private BrightIdeasSoftware.ObjectListView olvAssocDevice;
        private BrightIdeasSoftware.OLVColumn olvColumn15;
        private BrightIdeasSoftware.OLVColumn olvColumn16;
        private BrightIdeasSoftware.OLVColumn olvColumn17;
        private BrightIdeasSoftware.OLVColumn olvColumn18;
        private BrightIdeasSoftware.OLVColumn olvColumn19;
        private BrightIdeasSoftware.OLVColumn olvColumn20;
        private BrightIdeasSoftware.OLVColumn olvColumn21;
        private BrightIdeasSoftware.OLVColumn olvColumn22;
        private BrightIdeasSoftware.OLVColumn olvColumn23;
        private System.Windows.Forms.Label label4;
        private BrightIdeasSoftware.ObjectListView olvDatasourceResults;
        private BrightIdeasSoftware.OLVColumn olvColumn24;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn25;
        private BrightIdeasSoftware.OLVColumn olvColumn26;
        private BrightIdeasSoftware.OLVColumn olvColumn27;
        private System.Windows.Forms.TextBox txtDataSrcSearchTerm;
        private System.Windows.Forms.Button btnSearchDataSrc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabVUMainGUI;
        private System.Windows.Forms.Label lblSnapshotStatus;
        private System.Windows.Forms.Label lblSelectedCamNameNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private System.Windows.Forms.Label lblRecorderUnitType;
        private System.Windows.Forms.Label lblRecorderUnitGUID;
        private System.Windows.Forms.Label lblRecorderUnitFailover;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRecorderUnitCh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblRecorderUnitXcast;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblRecorderUnitActRet;
        private System.Windows.Forms.Label lblRecorderUnitSetRet;
        private System.Windows.Forms.Label lblRecorderUnitAssBitrate;
        private System.Windows.Forms.GroupBox grpVxsDiag;
        private System.Windows.Forms.LinkLabel lnkRecorderIP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtUserSearchTerm;
        private System.Windows.Forms.Label label11;
        private BrightIdeasSoftware.ObjectListView olvAssocRoles;
        private System.Windows.Forms.Button btnImportUserTXT;
        private BrightIdeasSoftware.ObjectListView olvUserList;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtQuickAddUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label30;
        private BrightIdeasSoftware.OLVColumn clmUsername;
        private BrightIdeasSoftware.OLVColumn clmFname;
        private BrightIdeasSoftware.OLVColumn clmLname;
        private BrightIdeasSoftware.OLVColumn clmNotes;
        private BrightIdeasSoftware.OLVColumn clmAssocRoles;
        private System.Windows.Forms.Label lblSelectedUserName;
        private System.Windows.Forms.ContextMenuStrip ctxUserToolkit;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuResetPwd;
        private System.Windows.Forms.ToolStripMenuItem ctxMenuAssignNewRole;
        private System.Windows.Forms.ToolStripMenuItem ctxDeleteUsers;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cmbRoleList;
        private System.Windows.Forms.Label lblRecorderUnitEvents;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cmbVolumes;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnSearchOnline;
        private BrightIdeasSoftware.OLVColumn clmEmail;
        private System.Windows.Forms.GroupBox groupBox7;
        private BrightIdeasSoftware.ObjectListView olvAssocPhoneNumbers;
        private BrightIdeasSoftware.OLVColumn clmPhoneType;
        private BrightIdeasSoftware.OLVColumn clmPhoneNumber;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private BrightIdeasSoftware.OLVColumn clmEmpID;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnImportUserCSV;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btnImportCSV_DS;
        private System.Windows.Forms.Button btnExportCSV_DS;
        private System.Windows.Forms.Button btnExportUserCSV;
        private System.Windows.Forms.TabPage tabDeviceSearch;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btnSearchDevice;
        private System.Windows.Forms.TextBox txtDeviceSearchTerm;
        private System.Windows.Forms.Button btnImportCSV_Device;
        private System.Windows.Forms.Button btnExportCSV_Device;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label39;
        private BrightIdeasSoftware.ObjectListView olvDeviceResults;
        private BrightIdeasSoftware.OLVColumn clmDeviceName;
        private BrightIdeasSoftware.OLVColumn clmDeviceIP;
        private BrightIdeasSoftware.OLVColumn clmDeviceModel;
        private BrightIdeasSoftware.OLVColumn clmDeviceType;
        private BrightIdeasSoftware.OLVColumn clmDeviceVersion;
        private BrightIdeasSoftware.OLVColumn clmDeviceState;
        private BrightIdeasSoftware.OLVColumn clmDeviceVendor;
        private BrightIdeasSoftware.OLVColumn clmDeviceCommissioned;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lblSelectedDevice;
        private BrightIdeasSoftware.OLVColumn clmDeviceGUID;
        private System.Windows.Forms.TextBox txtDeviceAdvFilter;
        private System.Windows.Forms.Label label42;
        private BrightIdeasSoftware.ObjectListView olvAssocDataSources;
        private BrightIdeasSoftware.OLVColumn clmDeviceSerial;
        private BrightIdeasSoftware.OLVColumn clmDS_GUID;
        private BrightIdeasSoftware.OLVColumn clmAssocDSName;
        private BrightIdeasSoftware.OLVColumn clmAssocDSNumber;
        private BrightIdeasSoftware.OLVColumn clmAssocDSIP;
        private BrightIdeasSoftware.OLVColumn clmAssocDSStatus;
        private BrightIdeasSoftware.OLVColumn clmAssocDSType;
        private BrightIdeasSoftware.OLVColumn clmAssocDSCap;
        private BrightIdeasSoftware.OLVColumn clmAssocDSRec;
        private BrightIdeasSoftware.OLVColumn clmAssocDSGUID;
        private System.Windows.Forms.ToolStripMenuItem ctxCameraMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem ctxEditCameraInfo2;
        private System.Windows.Forms.ToolStripMenuItem ctxDeviceMenuGroup;
        private System.Windows.Forms.ToolStripMenuItem ctxEditDevice;
        private System.Windows.Forms.ToolStripMenuItem ctxDeleteDevice;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.Button btnGetSystemDashboard;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnUncomissioned;
        private System.Windows.Forms.Button btnOfflineDevices;
        private System.Windows.Forms.Button btnLastModified;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAddDeviceByCSV;
        private System.Windows.Forms.Button btnManualAddOneDevice;
        private System.Windows.Forms.Label lblOverviewServersQty;
        private System.Windows.Forms.Label lblOverviewSystemType;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lblOverviewASQty;
        private System.Windows.Forms.Label lblOverviewAIOQty;
        private System.Windows.Forms.Label lblOverviewNSMQty;
        private System.Windows.Forms.Label lblOverviewVXSQty;
        private System.Windows.Forms.Label lblOverviewMGQty;
        private System.Windows.Forms.Label lblOverviewCoreQty;
        private System.Windows.Forms.Label lblOverviewRecorderQty;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label lblOverviewMonitorQty;
        private System.Windows.Forms.Label lblOverviewUIQty;
        private System.Windows.Forms.Label lblOverviewClientsQty;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ProgressBar prgVolumeSpace;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
    }
}

