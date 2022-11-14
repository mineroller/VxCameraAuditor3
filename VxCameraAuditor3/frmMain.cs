using FileHelpers;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using NLog;
using NLog.Fluent;

namespace VxCameraAuditor3
{
    public partial class frmMain : Form
    {

        // Initialise the required objects to be shared across methods

        public string connectedSystem { get; set; }
        public string systemID { get; set; }
        public string SerenityVersion { get; set; }
        public List<string> SupportedVersions { get; set; }
        public relLinks vuURI { get; set; }
        public bool largepreview { get; set; }
        public bool SystemIsVxPro { get; set; }

        private static Logger VcaLogger = LogManager.GetCurrentClassLogger();

        private Control parentcontrol;

        // Serenity Objects for Global Access

        List<vxDevice> devicesearchlist = new List<vxDevice>();
        List<Clips> selectedcamclips = new List<Clips>();
        List<vxDataSource> dssearchlist = new List<vxDataSource>();        
        List<DataObject> do_searchlist = new List<DataObject>();
        List<vxRecorder> recordersearchlist = new List<vxRecorder>();
        List<AggMember> aggsysmemberlist = new List<AggMember>();
        List<MultipartSnapshots> snapshots = new List<MultipartSnapshots>();
        List<vxRole> rolelist_users = new List<vxRole>();
        List<vxUser> usersearchlist = new List<vxUser>();

        List<string> utc_endtime = new List<string>();
        List<string> clip_snapshots = new List<string>();


        public frmMain()
        {
            InitializeComponent();

            // Until connectivity test is complete, disable all tabs.
            // Also, disable anything that needs to be disabled by default.

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback +=
                delegate(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                System.Security.Cryptography.X509Certificates.X509Chain chain,
                System.Net.Security.SslPolicyErrors sslPolicyErrors)
                {
                    return true; // **** Always accept
                };

            VcaLogger.Info("------------------------------VCA3 Started--------------------------------");

            ResetConnectivity();

        }

        private void ResetConnectivity()
        {
            tabVUMainGUI.Enabled = false;

            devicesearchlist.Clear();
            dssearchlist.Clear();
            recordersearchlist.Clear();
            do_searchlist.Clear();
            recordersearchlist.Clear();
            aggsysmemberlist.Clear();

            picCamPreviewJPG.Image = Properties.Resources.pelco_msi_logo;

            lblSvrAddr.Text = "https://" + Properties.Settings.Default.vxCore;
            lblCurrentUser.Text = Properties.Settings.Default.vxAdmin;

            btnDSAdvFilter.Enabled = false;
            cmbSelectAggMember.Enabled = false;
            btnAddUser.Enabled = false;
            cmbRoleList.Enabled = false;

            VcaLogger.Info("ResetConnectivity Completed");
        }

       private void ConsoleOutput(ConsoleWindow_Status c_status, string c_message)
        {
            Color _textcolour = new Color();

            switch (c_status)
            {
                case ConsoleWindow_Status.Normal:
                    _textcolour = Color.SpringGreen;                    
                    break;
                case ConsoleWindow_Status.Warning:
                    _textcolour = Color.Red;                    
                    break;
                case ConsoleWindow_Status.Error:
                    _textcolour = Color.OrangeRed;                    
                    break;
            }

            lblConsoleWindow.ForeColor = _textcolour;
            lblConsoleWindow.Text = c_message;
        }


        #region Image Preview Thingamajig

        private void chkDisplayPreview_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisplayPreview.Checked == false)
            {
                picCamPreviewJPG.Image = picCamPreviewJPG.InitialImage;
                picCamPreviewJPG.Visible = true;
                lblSnapshotStatus.Visible = false;
            }
            else
            {
                lblSnapshotStatus.Visible = true;
                lblSnapshotStatus.Text = "Ready";
            }
        }


        private void picCamPreviewJPG_DoubleClick(object sender, EventArgs e)
        {

            int curWidth = picCamPreviewJPG.Width;
            int curHeight = picCamPreviewJPG.Height;

            if (largepreview == false)
            {
                picCamPreviewJPG.BringToFront();
                lblSnapshotStatus.BringToFront();
                picCamPreviewJPG.Width = curWidth * 2;
                picCamPreviewJPG.Height = curHeight * 2;
                picCamPreviewJPG.SizeMode = PictureBoxSizeMode.StretchImage;
                largepreview = true;
            }
            else
            {
                picCamPreviewJPG.Width = curWidth / 2;
                picCamPreviewJPG.Height = curHeight / 2;
                picCamPreviewJPG.SizeMode = PictureBoxSizeMode.StretchImage;
                largepreview = false;
            }

        }

        #endregion

        #region Behind-the-Scene Stuff

        private void tabVUMainGUI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkDisplayPreview.Checked)
            {
                chkDisplayPreview.Checked = false;
            }
        }

        private void cmbSelectAggMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            AggMember currentsystem = aggsysmemberlist.Find(x => x.name == (string)cmbSelectAggMember.SelectedItem);
            systemID = currentsystem.id;

            lblAuxResultDisplay.Text = "Now filtering result for [" + currentsystem.name + "] (" + currentsystem.id + ")";
        }

        #endregion

        #region Context Menu - Device Tools

        private void ctxDeviceToolkit_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

            ctxCameraMenuGroup.Enabled = false;
            ctxDeviceMenuGroup.Enabled = false;

            parentcontrol = ((ContextMenuStrip)sender).SourceControl;

            if (parentcontrol == olvDatasourceResults || parentcontrol == olvAssocDataSources)
            {
                ctxCameraMenuGroup.Enabled = true;                
            }
            else if (parentcontrol == olvDeviceResults || parentcontrol == olvAssocDevice)
            {                
                ctxDeviceMenuGroup.Enabled = true;
            }
        }

        private void ctxEditCameraInfo2_Click(object sender, EventArgs e)
        {
            if (parentcontrol == olvDatasourceResults)
            {
                if (olvDatasourceResults.SelectedObjects.Count == 1)
                {
                    vxDataSource _ds = (vxDataSource)olvDatasourceResults.SelectedObject;

                    frmEditCameraInfo newCamInfo = new frmEditCameraInfo(_ds.number, _ds.name);
                    DialogResult editCamOK = newCamInfo.ShowDialog(this);

                    if (editCamOK == DialogResult.OK)
                    {
                        postEditDS newDSName = new postEditDS();
                        newDSName.name = newCamInfo.newcamname;
                        newDSName.number = newCamInfo.newcamnumber;

                        RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                        RestRequest renameReq = SerenityRequest.patchReq(vuURI.pelco_rel_data_sources + "/" + _ds.id);
                        renameReq.AddJsonBody(newDSName);

                        IRestResponse renameResponse = vuClient.Execute(renameReq);

                        if (renameResponse.StatusCode == HttpStatusCode.NoContent)
                        {
                            MessageBox.Show("Updated Successfully", "PATCH Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to PATCH camera [" + _ds.name + "] because of: [" + renameResponse.StatusCode.ToString() + "]", "PATCH Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }

            }
        }

        private void ctxDeleteDevice_Click(object sender, EventArgs e)
        {
            if (parentcontrol == olvDeviceResults)
            {
                DialogResult confirmDeleteDev = MessageBox.Show("Total " + olvDeviceResults.SelectedObjects.Count.ToString() + " Devices AND its associated DataSources will be PERMANENTLY deleted from Core. Proceed?", "Delete Devices", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (confirmDeleteDev == DialogResult.OK)
                {

                    List<vxDevice> _dd = new List<vxDevice>();

                    foreach (vxDevice d in olvDeviceResults.SelectedObjects)
                    {
                        _dd.Add(d);
                    }

                    frmProgress assignNewTagProgress = new frmProgress(_dd);
                    assignNewTagProgress.progressURI = vuURI;
                    assignNewTagProgress.ShowDialog(this);

                }
            }
        }

        private void ctxMenuPing_Click(object sender, EventArgs e)
        {
            if (parentcontrol == olvDatasourceResults || parentcontrol == olvRecorderAssocDS)
            {                
                foreach (vxDataSource r in (parentcontrol as BrightIdeasSoftware.ObjectListView).SelectedObjects)
                {
                    Process.Start("ping.exe", "-t " + r.ip);
                }
            }
            else if (parentcontrol == olvRecorderSearchResult || parentcontrol == olvDeviceResults || parentcontrol == olvAssocDevice)
            {
                foreach (vxDevice r in (parentcontrol as BrightIdeasSoftware.ObjectListView).SelectedObjects)
                {
                    Process.Start("ping.exe", "-t " + r.ip);
                }
            }            

        }

        private void ctxMenuOpenWebBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                if (parentcontrol == olvDatasourceResults)
                {
                    foreach (vxDataSource r in olvDatasourceResults.SelectedObjects)
                    {
                        Process.Start("http://" + r.ip);
                    }
                }

                else if (parentcontrol == olvAssocDevice)
                {
                    foreach (vxDevice r in olvAssocDevice.SelectedObjects)
                    {
                        if (r.type == "vxs" || r.type == "all_in_one")
                        {
                            Process.Start("https://" + r.ip + ":" + Properties.Settings.Default.vxsPort);
                        }
                        else
                        {
                            Process.Start("http://" + r.ip);
                        }
                    }
                }

                else if (parentcontrol == olvRecorderSearchResult)
                {
                    foreach (vxDevice r in olvRecorderSearchResult.SelectedObjects)
                    {
                        if (r.type == "vxs" || r.type == "all_in_one")
                        {
                            Process.Start("https://" + r.ip + ":" + Properties.Settings.Default.vxsPort);
                        }
                        else
                        {
                            Process.Start("http://" + r.ip);
                        }
                    }                
                }
                else if (parentcontrol == olvRecorderAssocDS)
                {
                    foreach (vxDataSource r in olvRecorderAssocDS.SelectedObjects)
                    {
                        Process.Start("http://" + r.ip);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to launch web browser! :" + ex.Message, "Error starting browser", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ctxMenuSSH_Click(object sender, EventArgs e)
        {
            try
            {
                if (parentcontrol == olvDatasourceResults)
                {
                    foreach (vxDataSource r in olvDatasourceResults.SelectedObjects)
                    {
                        Process.Start("putty.exe", "-t " + r.ip);
                    }
                }

                else if (parentcontrol == olvAssocDevice)
                {
                    foreach (vxDevice r in olvAssocDevice.SelectedObjects)
                    {
                        Process.Start("putty.exe", "-t " + r.ip);
                    }
                }

                else if (parentcontrol == olvRecorderSearchResult)
                {
                    foreach (vxDevice r in olvRecorderSearchResult.SelectedObjects)
                    {
                        Process.Start("putty.exe", "-t " + r.ip);
                    }
                }
                else if (parentcontrol == olvRecorderAssocDS)
                {
                    foreach (vxDataSource r in olvRecorderAssocDS.SelectedObjects)
                    {
                        Process.Start("putty.exe", "-t " + r.ip);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to launch PuTTY! :" + ex.Message + "\nPlease ensure PuTTY is located within PATH environment variable.", "Error starting SSH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ctxCopyIPAddr_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string copiedtext = null;
            Clipboard.Clear();
            try
            {

                if (parentcontrol == olvDatasourceResults)
                {
                    foreach (vxDataSource r in olvDatasourceResults.SelectedObjects)
                    {
                        copiedtext += r.ip + Environment.NewLine;
                        counter++;
                    }
                }

                else if (parentcontrol == olvAssocDevice)
                {
                    foreach (vxDevice r in olvAssocDevice.SelectedObjects)
                    {
                        copiedtext += r.ip + Environment.NewLine;
                        counter++;
                    }
                }

                else if (parentcontrol == olvDeviceResults)
                {
                    foreach (vxDevice r in olvDeviceResults.SelectedObjects)
                    {
                        copiedtext += r.ip + Environment.NewLine;
                        counter++;
                    }
                }

                Clipboard.SetText(copiedtext);
                MessageBox.Show(counter.ToString() + " IP addresses copied to Clipboard!", "Copy IP Addresses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while copying to Clipboard: " + ex.Message + "\nPlease try again.", "Clipboard Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxCopyGUID_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string copiedtext = null;
            Clipboard.Clear();

            try
            {

                if (parentcontrol == olvDatasourceResults)
                {
                    foreach (vxDataSource r in olvDatasourceResults.SelectedObjects)
                    {
                        copiedtext += r.id + Environment.NewLine;
                        counter++;
                    }
                }

                else if (parentcontrol == olvAssocDevice)
                {
                    foreach (vxDevice r in olvAssocDevice.SelectedObjects)
                    {
                        copiedtext += r.id + Environment.NewLine;
                        counter++;
                    }
                }


                else if (parentcontrol == olvDeviceResults)
                {
                    foreach (vxDevice r in olvDeviceResults.SelectedObjects)
                    {
                        copiedtext += r.id + Environment.NewLine;
                        counter++;
                    }
                }

                Clipboard.SetText(copiedtext);
                MessageBox.Show(counter.ToString() + " GUIDs copied to Clipboard!", "Copy GUIDs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while copying GUID to Clipboard: " + ex.Message + "\nPlease try again.", "Clipboard Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Context Menu - User Tools

        private void ctxUserToolkit_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            parentcontrol = ((ContextMenuStrip)sender).SourceControl;
        }

        private void ctxMenuResetPwd_Click(object sender, EventArgs e)
        {
            if (parentcontrol == olvUserList)
            {
                frmNewPassword asknewpassword = new frmNewPassword();
                DialogResult pwdresetok = asknewpassword.ShowDialog(this);

                if (pwdresetok == DialogResult.OK)
                {
                    string received_password = asknewpassword.newpassword;

                    List<vxUser> reset_userlist = new List<vxUser>();

                    foreach (vxUser u in olvUserList.SelectedObjects)
                    {
                        reset_userlist.Add(u);
                    }

                    DialogResult proceed = MessageBox.Show("Total " + reset_userlist.Count.ToString() + " users will be assigned new password [" + received_password + "].\nAre you sure?", "Reset Passwords", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (proceed == DialogResult.OK)
                    {
                        NewPassword np = new NewPassword
                        {
                            _type = "NewPasswordRequest",
                            new_password = received_password,
                            change_password = true
                        };
                        
                        frmProgress DoActualReset = new frmProgress(reset_userlist, np);
                        DoActualReset.progressURI = vuURI;
                        DoActualReset.ShowDialog(this);
                    }
                }

                btnSearchUser_Click(this, new EventArgs());
            }
        }

        private void ctxMenuAssignNewRole_Click(object sender, EventArgs e)
        {
            if (parentcontrol == olvUserList)
            {
                List<vxRole> fullrolelist = SearchRoles(RoleSearch_Type.None);

                frmSelectRole selectarole = new frmSelectRole(fullrolelist);

                DialogResult selectrole_ok = selectarole.ShowDialog(this);

                if (selectrole_ok == DialogResult.OK)
                {
                    vxRole selected_role = selectarole.selected_role;

                    List<vxUser> assign_userlist = new List<vxUser>();

                    foreach (vxUser u in olvUserList.SelectedObjects)
                    {
                        assign_userlist.Add(u);
                    }

                    DialogResult proceed = MessageBox.Show("Total " + olvUserList.SelectedObjects.Count.ToString() + " users will be assigned new Role [" + selected_role.name + "]", "Assign New Role", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (proceed == DialogResult.OK)
                    {
                        AddRemoveRole ar_role = new AddRemoveRole();
                        ar_role._type = "Resource.String";
                        ar_role.value = selected_role.id;

                        frmProgress DoActualAssign = new frmProgress(assign_userlist, ar_role);
                        DoActualAssign.progressURI = vuURI;
                        DoActualAssign.ShowDialog(this);
                    }
                }

                btnSearchUser_Click(this, new EventArgs());
            }
        }

        private void ctxDeleteUsers_Click(object sender, EventArgs e)
        {
            if (olvUserList.SelectedObjects.Count >= 1)
            {
                int totalusers = olvUserList.SelectedObjects.Count;
                DialogResult confirmDelete = MessageBox.Show("Total " + totalusers.ToString() + " user(s) will be PERMANANTLY deleted. Continue?", "Delete Selected Users", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (confirmDelete == DialogResult.OK)
                {
                    List<vxUser> userlist_pass = new List<vxUser>();

                    foreach (vxUser u in olvUserList.SelectedObjects)
                    {
                        userlist_pass.Add(u);
                    }

                    frmProgress deleteProgress = new frmProgress(userlist_pass);
                    deleteProgress.progressURI = vuURI;
                    deleteProgress.ShowDialog(this);
                }
            }
            btnSearchUser_Click(this, new EventArgs());
        }

        #endregion

        #region Main Menu Operation

        /// <summary>
        /// Checks if VxCore is actually available at the address defined in settings.
        /// All controls are disabled until this check succeeds.
        /// </summary>

        private void connectToVxCoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetConnectivity();

            // Define targeted Serenity Version, so we can see if the system will actually support
            // Vx 2.x = Serenity 4.x
            // Vx 3.x = Serenity 5.x

            string targetVersion = "5.1";
            VcaLogger.Info("Starting connection to Vx system...");
            // Takes cursor into wait mode, in case IP is wrong and there is a connect timeout
            ConsoleOutput(ConsoleWindow_Status.Warning, "Checking connection... Please wait");
            Cursor.Current = Cursors.WaitCursor;

            try
            {

                RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                VcaLogger.Debug("Connecting to https://" + Properties.Settings.Default.vxCore);

                RestRequest askVersion = SerenityRequest.getReq("system/versions", false);
                IRestResponse<Versions> respVersion = vuClient.Execute<Versions>(askVersion);

                toolStripStatusMessage.Text = VUStringHelper.VxCoreSays(respVersion.StatusDescription);

                if (respVersion.StatusCode == HttpStatusCode.OK)
                {
                    VcaLogger.Debug("Server > HTTP 200 OK");
                    if (respVersion.Data.supported_versions.Any(ver => ver.Contains(targetVersion)))
                    {
                        SerenityVersion = targetVersion;

                        RestRequest askSystem = SerenityRequest.getReq("system/", false);
                        askSystem.AddHeader("Accept", "application/vnd.pelco.resource+json; version=" + SerenityVersion);

                        IRestResponse<SystemQuery> respSystem = vuClient.Execute<SystemQuery>(askSystem);

                        toolStripStatusMessage.Text = VUStringHelper.VxCoreSays(respSystem.StatusDescription);

                        if (respSystem.StatusCode == HttpStatusCode.Forbidden)
                        {
                            ConsoleOutput(ConsoleWindow_Status.Warning, "Authentication failed.\nPlease check your admin user credentials.");
                            VcaLogger.Error("Authentication failed. Check credentials");
                        }

                        else
                        {
                            connectedSystem = respSystem.Data.name;
                            systemID = respSystem.Data.id;
                            vuURI = respSystem.Data._links;

                            if (vuURI.pelco_rel_devices != null) // if null, this means System License is expired.
                            {
                                ConsoleOutput(ConsoleWindow_Status.Normal, "Found Vx System [" + connectedSystem + "] at\nhttps://" + Properties.Settings.Default.vxCore + vuURI.self);
                                VcaLogger.Info("Found Vx System [" + connectedSystem + "] (" + systemID + ") at https://" + Properties.Settings.Default.vxCore + vuURI.self);

                                lblAuxResultDisplay.Text = "Connected to [" + connectedSystem + "] (" + systemID + ")";
                                tabVUMainGUI.Enabled = true;

                                if (vuURI.pelco_rel_members != null) // Checks for aggregation
                                {
                                    RestRequest askMember = SerenityRequest.getReq(vuURI.pelco_rel_members, false);
                                    IRestResponse<MemberQuery> respMember = vuClient.Execute<MemberQuery>(askMember);

                                    AggMember parentsystem = new AggMember();
                                    parentsystem.id = systemID;
                                    parentsystem.name = connectedSystem;

                                    aggsysmemberlist.Add(parentsystem);
                                    aggsysmemberlist.AddRange(respMember.Data.members);


                                    foreach (AggMember m in aggsysmemberlist)
                                    {
                                        cmbSelectAggMember.Items.Add(m.name);
                                    }


                                    cmbSelectAggMember.Enabled = true;
                                }
                                else
                                {
                                    cmbSelectAggMember.Items.Clear();
                                    cmbSelectAggMember.Enabled = false;
                                }
                            }
                            else
                            {
                                ConsoleOutput(ConsoleWindow_Status.Warning, "Found Vx System [" + connectedSystem + "]\nHowever, System License appears to be Expired.");                                
                            }
                        }
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        ConsoleOutput(ConsoleWindow_Status.Error, "API Error: Target Vx system does not support Serenity " + targetVersion + ".\nUnable to proceed.");
                    }
                }
                else
                {
                    ConsoleOutput(ConsoleWindow_Status.Error, "Connect Error: " + respVersion.StatusDescription + "\nPlease try again.");
                }
            }

            catch
            {
                ConsoleOutput(ConsoleWindow_Status.Error, "ERROR: VxCore Connection Not Available.\nPlease check connection settings.");
                tabVUMainGUI.Enabled = false;

            }


        }

        /// <summary>
        /// Well.. it exits.
        /// </summary>

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VcaLogger.Info("------------------------------VCA3 Exited--------------------------------");
            Application.Exit();
        }

        /// <summary>
        /// Opens the Setting dialog to configure connections and save settings
        /// </summary>

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingsForm = new frmSettings();
            settingsForm.ShowDialog(this);

            // After form closes, update the server address texts.
            lblSvrAddr.Text = "https://" + Properties.Settings.Default.vxCore;
            // lblMongoAddr.Text = "mongodb://" + Properties.Settings.Default.mongoAddr + ":" + Properties.Settings.Default.mongoPort;
            lblCurrentUser.Text = Properties.Settings.Default.vxAdmin;

        }

        /// <summary>
        /// About ...
        /// </summary>

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new frmAbout();
            aboutForm.ShowDialog(this);
        }
        #endregion

        #region System Overview

        private bool CheckIfVxPro()
        {
            List<vxDevice> _allinone = SearchDevices(DeviceSearch_Type.Type, "all_in_one");

            if (_allinone.Count == 0)
            {
                return false;
            }
            else if (_allinone.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private void btnGetSystemDashboard_Click(object sender, EventArgs e)
        {
            // System Summary

            bool _isvxpro = CheckIfVxPro();

            if (_isvxpro == true)
            {
                lblOverviewSystemType.Text = "Your system is VideoXpert PRO";
            }
            else
            {
                lblOverviewSystemType.Text = "Your system is VideoXpert ENTERPRISE";
            }

            List<vxDevice> _cores = SearchDevices(DeviceSearch_Type.Type, "core");
            lblOverviewCoreQty.Text = _cores.Count.ToString() + " Cores";

            List<vxDevice> _mgs = SearchDevices(DeviceSearch_Type.Type, "mg");
            lblOverviewMGQty.Text = _mgs.Count.ToString() + " Media Gateways";

            List<vxDevice> _allinone = SearchDevices(DeviceSearch_Type.Type, "all_in_one");
            lblOverviewAIOQty.Text = _allinone.Count.ToString() + " VxPro Servers";

            List<vxDevice> _acc = SearchDevices(DeviceSearch_Type.Type, "acc");
            lblOverviewASQty.Text = _acc.Count.ToString() + " Accessory Servers";

            int _totalservers = _cores.Count + _mgs.Count + _allinone.Count + _acc.Count;

            lblOverviewServersQty.Text = _totalservers.ToString() + " System Servers (Core/MG/VxPro/AS)";

            // Recorder Summary

            int _vxs = 0;
            int _nsm = 0;

            List<vxDevice> _recorders = SearchRecorders("(type eq 'recorder')");

            foreach (vxDevice _d in _recorders)
            {
                
                if (_d._embedded.pelco_rel_data_storage.type == "vxs")
                {
                    _vxs++;
                }
                else if (_d._embedded.pelco_rel_data_storage.type == "nsm")
                {
                    _nsm++;
                }

            }

            lblOverviewRecorderQty.Text = (_vxs + _nsm).ToString() + " Recorders (VXS/NSM)";
            lblOverviewVXSQty.Text = _vxs.ToString() + " VxStorage Servers";
            lblOverviewNSMQty.Text = _nsm.ToString() + " Endura NSMs";

            // Client Summary

            List<vxDevice> _ui = SearchDevices(DeviceSearch_Type.Type, "ui");
            lblOverviewUIQty.Text = _ui.Count.ToString() + " VxOpsCenters";

            List<vxDevice> _mon = SearchDevices(DeviceSearch_Type.Type, "monitor");
            lblOverviewMonitorQty.Text = _mon.Count.ToString() + " Shared Displays";

            int _totalclients = _ui.Count + _mon.Count;
            lblOverviewClientsQty.Text = _totalclients.ToString() + " Viewing Devices";


            ConsoleOutput(ConsoleWindow_Status.Normal, "System Summary Generated");            
        }




        #endregion

        #region Enhanced Camera (DataSource) Search

        private void txtDataSrcSearchTerm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchDataSrc_Click(this, new EventArgs());
            }
        }

        private void txtDSAdvFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDSAdvFilter_Click(this, new EventArgs());
            }
        }

        private void btnSearchDataSrc_Click(object sender, EventArgs e)
        {
            dssearchlist.Clear();
            dssearchlist = SearchDataSources(DataSrcSearch_Type.General, "video");
            olvDatasourceResults.SetObjects(dssearchlist);
        }

        private void btnSearchOffline_Click(object sender, EventArgs e)
        {
            dssearchlist.Clear();
            dssearchlist = SearchDataSources(DataSrcSearch_Type.Offline, "video");
            olvDatasourceResults.SetObjects(dssearchlist);
        }

        private void btnNotRec_Click(object sender, EventArgs e)
        {
            dssearchlist.Clear();
            dssearchlist = SearchDataSources(DataSrcSearch_Type.NotRecording, "video");
            olvDatasourceResults.SetObjects(dssearchlist);
        }

        private void btnSearchOnline_Click(object sender, EventArgs e)
        {
            dssearchlist.Clear();
            dssearchlist = SearchDataSources(DataSrcSearch_Type.Online, "video");
            olvDatasourceResults.SetObjects(dssearchlist);
        }

        private void txtDSAdvFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtDSAdvFilter.Text.Length >= 1)
            {
                btnDSAdvFilter.Enabled = true;
            }
            else
            {
                btnDSAdvFilter.Enabled = false;
            }
        }

        private void btnDSAdvFilter_Click(object sender, EventArgs e)
        {
            dssearchlist.Clear();
            dssearchlist = SearchDataSources(DataSrcSearch_Type.Advanced);
            olvDatasourceResults.SetObjects(dssearchlist);
        }

        private void olcDatasourceResults_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<vxDevice> datasource_parents = new List<vxDevice>();
            List<vxRecorder> datasource_recorder = new List<vxRecorder>();

            picCamPreviewJPG.Image = Properties.Resources.pelco_msi_logo;
            lblSnapshotStatus.ForeColor = Color.Yellow;
            lblSnapshotStatus.Text = "Loading Camera...";
            lblClipStartTime.Text = "(Start Time)";
            lblClipEndTime.Text = "(End Time)";
            lblClipRetention.Text = "(Retention)";
            lblClipGaps.Text = "(None)";

            lstClipGaps.Items.Clear();
            clip_snapshots.Clear();
            utc_endtime.Clear();

            Cursor.Current = Cursors.WaitCursor;           

            if (olvDatasourceResults.SelectedObjects.Count == 0)
            {
                lblSnapshotStatus.Text = "(Select one camera)";
                picCamPreviewJPG.Image = Properties.Resources.pelco_msi_logo;
            }
            else if (olvDatasourceResults.SelectedObjects.Count == 1)
            {


                vxDataSource ds = (vxDataSource)olvDatasourceResults.SelectedObject;
                vxDevice d = ds._embedded.pelco_rel_device;
                List<vxDataInterface> list_di = ds.data_interfaces;
                datasource_parents.Add(d);

                RecorderQuery d_rq = ds._embedded.pelco_rel_data_storages;
                datasource_recorder = d_rq.data_storages;

                foreach (vxRecorder r in datasource_recorder)
                {
                    RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                    RestRequest findRecorderReq = SerenityRequest.getReq(r._links.pelco_rel_device, true);
                    IRestResponse<vxDevice> findRecorderResp = vuClient.Execute<vxDevice>(findRecorderReq);

                    datasource_parents.Add(findRecorderResp.Data);
                }

                olvAssocDevice.SetObjects(datasource_parents);

                olvDataInterfaces.SetObjects(list_di);

                // Camera Preview

                if (chkDisplayPreview.Checked)
                {
                    try
                    {

                        RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                        RestRequest reqSnapshot = SerenityRequest.getJpegReq(ds._links.pelco_rel_snapshot);
                        IRestResponse rspSnapshot = vuClient.Execute(reqSnapshot);

                        // Convert response content into image
                        // StackOverflow https://stackoverflow.com/a/14673714 

                        if (rspSnapshot.StatusCode == HttpStatusCode.OK)
                        {
                            Image JpgSnapshot = (Bitmap)((new ImageConverter()).ConvertFrom(rspSnapshot.RawBytes));

                            picCamPreviewJPG.Image = JpgSnapshot;

                            lblSnapshotStatus.ForeColor = Color.SpringGreen;
                            lblSnapshotStatus.Text = "Live Snapshot";
                        }
                        else if (rspSnapshot.StatusCode == HttpStatusCode.NotFound)
                        {
                            MessageBox.Show("Failed to receive Snapshot image from server.\nCheck if camera's associated Recorder is ONLINE", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            picCamPreviewJPG.Image = Properties.Resources.camerror;
                            lblSnapshotStatus.ForeColor = Color.Red;
                            lblSnapshotStatus.Text = "NOT FOUND";
                        }
                        else if (rspSnapshot.StatusCode == HttpStatusCode.ServiceUnavailable)
                        {                            
                            picCamPreviewJPG.Image = Properties.Resources.camerror;
                            lblSnapshotStatus.ForeColor = Color.Red;
                            lblSnapshotStatus.Text = "SERVICE UNAVAILABLE";
                        }
                        else
                        {
                            picCamPreviewJPG.Image = Properties.Resources.kitten;
                            lblSnapshotStatus.ForeColor = Color.Yellow;
                            lblSnapshotStatus.Text = "Unknown Error - Possible Unsupported Source.";
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to display preview image.\n" + ex.Message, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        picCamPreviewJPG.Image = Properties.Resources.camerror;
                    }
                }
                else
                {                    
                    picCamPreviewJPG.Image = Properties.Resources.pelco_msi_logo;
                }

                // Start of Clip Query Operation

                RestClient clipClient = new RestClient("https://" + Properties.Settings.Default.vxCore);                
                RestRequest reqClips = SerenityRequest.getReq(ds._links.pelco_rel_clips, false);

                IRestResponse<ClipQuery> dataSrcClipsResp = clipClient.Execute<ClipQuery>(reqClips);

                ClipQuery cq = dataSrcClipsResp.Data;

                List<DateTime> start_time = new List<DateTime>();
                List<DateTime> end_time = new List<DateTime>();

                selectedcamclips = cq.clips;


                int clipcounter = 0;

                foreach (Clips c in selectedcamclips)
                {
                    utc_endtime.Add(c.end_time);
                    clip_snapshots.Add(c._links.pelco_rel_snapshots);

                    DateTime startlocal = DateTime.Parse(c.start_time);
                    DateTime endlocal = DateTime.Parse(c.end_time);

                    start_time.Add(startlocal.ToLocalTime());
                    end_time.Add(endlocal.ToLocalTime());
                    clipcounter++;
                }

                start_time.Sort();
                end_time.Sort();
                utc_endtime.Sort();

                lblSelectedCamNameNo.Text = "[" + ds.number + "] " + ds.name;

                if (start_time.Count > 0)
                {
                    lblClipStartTime.Text = start_time[0].ToString();
                    lblClipEndTime.Text = end_time[end_time.Count - 1].ToString();

                    TimeSpan retention = end_time[end_time.Count - 1] - start_time[0];

                    lblClipRetention.Text = string.Format("{0:%d} D {0:%h} H {0:%m} M", retention);

                    if (clipcounter <= 1)
                    {
                        lblClipGaps.Text = "(No gaps found.)";
                        lblClipGaps.ForeColor = Color.Black;
                    }
                    else
                    {
                        lblClipGaps.Text = (clipcounter - 1).ToString() + " gap(s) found.";
                        lblClipGaps.ForeColor = Color.OrangeRed;
                        end_time.RemoveAt(end_time.Count - 1);
                        foreach (DateTime time in end_time)
                        {
                            lstClipGaps.Items.Add(time.ToString());
                        }
                    }
                }
                else
                {
                    lblClipStartTime.Text = "(No Recording)";
                    lblClipEndTime.Text = "(No Recording)";
                    lblClipRetention.Text = "(No Recording)";

                    lblClipGaps.Text = "(None)";
                    lblClipGaps.ForeColor = Color.Black;
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private List<vxDataSource> SearchDataSources(DataSrcSearch_Type query, string _dstParam = "Parameter")
        {
            List<vxDataSource> _datasource_list = new List<vxDataSource>();
            _datasource_list.Clear();
            devicesearchlist.Clear();

            ConsoleOutput(ConsoleWindow_Status.Normal, "Querying...");
            Cursor.Current = Cursors.WaitCursor;

            /// Create the usual REST request

            RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
            RestRequest firstRequest = SerenityRequest.getReq(vuURI.pelco_rel_data_sources, true);

            /// Build search query based on the argument passed. 

            string q_filter = null;

            switch (query)
            {
                case DataSrcSearch_Type.General:
                    q_filter = "(name,number,id,ip,type likei '" + txtDataSrcSearchTerm.Text + "')";
                    firstRequest.AddParameter("q", q_filter);
                    firstRequest.AddParameter("type", _dstParam);
                    break;
                case DataSrcSearch_Type.Advanced:
                    q_filter = txtDSAdvFilter.Text;
                    firstRequest.AddParameter("q", q_filter);
                    firstRequest.AddParameter("type", _dstParam);
                    break;
                case DataSrcSearch_Type.Offline:
                    q_filter = "(state eq 'offline')";
                    firstRequest.AddParameter("q", q_filter);
                    firstRequest.AddParameter("type", _dstParam);
                    break;
                case DataSrcSearch_Type.Online:
                    q_filter = "(state eq 'online')";
                    firstRequest.AddParameter("q", q_filter);
                    firstRequest.AddParameter("type", _dstParam);
                    break;
                case DataSrcSearch_Type.NotRecording:
                    firstRequest.AddParameter("recording", false);
                    firstRequest.AddParameter("type", _dstParam);
                    break;
                case DataSrcSearch_Type.DataStorage:
                    firstRequest.AddParameter("data_storage_id", _dstParam);
                    firstRequest.AddParameter("_system_id", systemID);
                    /// firstRequest.AddParameter("type", _dstParam);
                    break;
                case DataSrcSearch_Type.AllTags:
                    firstRequest.AddParameter("all_tags", _dstParam);
                    firstRequest.AddParameter("count", "100");
                    /// firstRequest.AddParameter("type", _dstParam);
                    break;                
            }

            firstRequest.AddParameter("embed", "{\"/pelco/rel/device\":{}, \"/pelco/rel/data_storages\":{} }");
            firstRequest.AddParameter("_system_id", systemID);

            IRestResponse<DataSourceQuery> firstPage = vuClient.Execute<DataSourceQuery>(firstRequest);

            toolStripStatusMessage.Text = VUStringHelper.VxCoreSays(firstPage.StatusDescription);

            if (firstPage.StatusCode != HttpStatusCode.OK)
            {
                ConsoleOutput(ConsoleWindow_Status.Warning, "HTTP " + firstPage.StatusDescription + "!\nPlease check ADVFILTER expression and retry.");
            }
            else
            {
                ConsoleOutput(ConsoleWindow_Status.Normal, Convert.ToString(firstPage.Data.collection_header.total_items) + " DataSources found.");

                /// Build the datasource list

                _datasource_list = firstPage.Data.data_sources;

                /// Now, if there are more result - paginate, and add them to the search result

                if (firstPage.Data.collection_header._links != null)
                {
                    string paginator = firstPage.Data.collection_header._links.next;

                    while (paginator != null)
                    {
                        RestRequest nextRequest = SerenityRequest.getReq(paginator, true);

                        switch (query)
                        {
                            case DataSrcSearch_Type.General:
                                q_filter = "(name,number,id,ip,type likei '" + txtDataSrcSearchTerm.Text + "')";
                                firstRequest.AddParameter("q", q_filter);
                                firstRequest.AddParameter("type", _dstParam);
                                break;
                            case DataSrcSearch_Type.Advanced:
                                q_filter = txtDSAdvFilter.Text;
                                firstRequest.AddParameter("q", q_filter);
                                firstRequest.AddParameter("type", _dstParam);
                                break;
                            case DataSrcSearch_Type.Offline:
                                q_filter = "(state eq 'offline')";
                                firstRequest.AddParameter("q", q_filter);
                                firstRequest.AddParameter("type", _dstParam);
                                break;
                            case DataSrcSearch_Type.Online:
                                q_filter = "(state eq 'offline')";
                                firstRequest.AddParameter("q", q_filter);
                                firstRequest.AddParameter("type", _dstParam);
                                break;
                            case DataSrcSearch_Type.NotRecording:
                                firstRequest.AddParameter("recording", false);
                                firstRequest.AddParameter("type", _dstParam);
                                break;
                            case DataSrcSearch_Type.DataStorage:
                                firstRequest.AddParameter("data_storage_id", _dstParam);
                                firstRequest.AddParameter("_system_id", systemID);
                                firstRequest.AddParameter("type", _dstParam);
                                break;
                            case DataSrcSearch_Type.AllTags:
                                firstRequest.AddParameter("all_tags", _dstParam);
                                firstRequest.AddParameter("count", "100");
                                firstRequest.AddParameter("type", _dstParam);
                                break;
                        }
                        nextRequest.AddParameter("embed", "{\"/pelco/rel/device\":{}, \"/pelco/rel/data_storages\":{} }");
                        nextRequest.AddParameter("_system_id", systemID);
                        IRestResponse<DataSourceQuery> nextPage = vuClient.Execute<DataSourceQuery>(nextRequest);

                        _datasource_list.AddRange(nextPage.Data.data_sources);

                        paginator = nextPage.Data.collection_header._links.next;

                    }
                }                               
            }
            return _datasource_list;
        }

        private void btnGenerateRetentionReport_Click(object sender, EventArgs e)
        {
            if (dssearchlist.Count == 0)
            {
                MessageBox.Show("No cameras to generate report from! Please perform a search first.", "Generate Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult confirmGenReport = MessageBox.Show("Retention Report for total of " + dssearchlist.Count.ToString() + " cameras will be generated. Proceed?", "Generate Report", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (confirmGenReport == DialogResult.OK)
                {

                    frmRecordingReport generateReport = new frmRecordingReport(dssearchlist);
                    generateReport.ShowDialog(this);

                }
            }

        }

        private void btnExportCSV_DS_Click(object sender, EventArgs e)
        {
            List<DataSource_CSV> csv_ds_export = new List<DataSource_CSV>();

            foreach (vxDataSource d in dssearchlist)
            {
                DataSource_CSV csvrow = new DataSource_CSV()
                {
                    Device_GUID = d.id,
                    IP_Address = d.ip,
                    Camera_Name = d.name,
                    Camera_Number = d.number
                };
                csv_ds_export.Add(csvrow);
            }

            saveVUFilesDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveVUFilesDialog.Filter = "Comma-Separated Values (*.csv)|*.csv";
            saveVUFilesDialog.RestoreDirectory = true;
            saveVUFilesDialog.ShowHelp = true;

            if (saveVUFilesDialog.ShowDialog() == DialogResult.OK)
            {
                var csvwriter = new FileHelperEngine<DataSource_CSV>(Encoding.UTF8);

                csvwriter.HeaderText = csvwriter.GetFileHeader();
                csvwriter.WriteFile(saveVUFilesDialog.FileName, csv_ds_export);

                MessageBox.Show("CSV File created in:\n" + saveVUFilesDialog.FileName + "\n\nYou can edit this file to update camera number and names in batch, then import back.", "Export CSV Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnImportCSV_DS_Click(object sender, EventArgs e)
        {
            List<Device_CSV> csv_DS_import = new List<Device_CSV>();
            frmImportDataSourceCSV validateCSVDSFile = new frmImportDataSourceCSV();
            validateCSVDSFile.ShowDialog(this);

            if (validateCSVDSFile.DialogResult == DialogResult.OK)
            {
                csv_DS_import = validateCSVDSFile.importCSV_DS_list;
                DialogResult proceed = MessageBox.Show("Total " + csv_DS_import.Count.ToString() + " cameras will be updated. Proceed?", "Import CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (proceed == DialogResult.OK)
                {
                    frmProgress DoActualImport = new frmProgress(csv_DS_import);
                    DoActualImport.progressURI = vuURI;
                    DoActualImport.ShowDialog(this);
                }

            }
        }

        private void lstClipGaps_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstClipGaps.SelectedItem != null)
            {
                int curindex = lstClipGaps.SelectedIndex;

                if (chkDisplayPreview.Checked)
                {
                    try
                    {

                        // Requesting snapshots on clip's endtime will usually result in No Video error.
                        // So, let's subtract one second from the endtime to ensure HTTP OK.

                        DateTime displayedEnd = DateTime.Parse(utc_endtime[curindex]);
                        DateTime adjustedEnd = displayedEnd.AddSeconds(-(int)numSeconds.Value);

                        RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                        RestRequest reqSnapshot = SerenityRequest.getSnapshotReq(clip_snapshots[curindex]);

                        reqSnapshot.AddParameter("start_time", adjustedEnd.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'"));
                        reqSnapshot.AddParameter("end_time", adjustedEnd.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'"));
                        reqSnapshot.AddParameter("width", "640");

                        IRestResponse rspSnapshot = vuClient.Execute(reqSnapshot);

                        if (rspSnapshot.StatusCode == HttpStatusCode.OK)
                        {

                            byte[] mpData = rspSnapshot.RawBytes;
                            byte[] delimiters = { 0x0d, 0x0a };

                            MultipartSnapshots mpJpeg = new MultipartSnapshots();

                            Stream mpStream = new MemoryStream(mpData);

                            List<int> mpPartPos = VUStringHelper.IndexOfSequence(mpData, delimiters, 0);
                            mpPartPos.Sort();

                            // From the raw mutipart data, extract just the first frame information needed

                            using (BinaryReader br = new BinaryReader(mpStream))
                            {
                                br.BaseStream.Seek(0, SeekOrigin.Begin);

                                byte[] boundary = br.ReadBytes(mpPartPos[0]);

                                br.BaseStream.Seek(2, SeekOrigin.Current);
                                byte[] imagetime = br.ReadBytes(mpPartPos[1] - mpPartPos[0] - 2);
                                string firstHeader = System.Text.Encoding.ASCII.GetString(imagetime);

                                br.BaseStream.Seek(2, SeekOrigin.Current);
                                byte[] contenttype = br.ReadBytes(mpPartPos[2] - mpPartPos[1] - 2);
                                string secondHeader = System.Text.Encoding.ASCII.GetString(contenttype);

                                br.BaseStream.Seek(4, SeekOrigin.Current);
                                byte[] imagedata = br.ReadBytes(mpPartPos[4] - mpPartPos[3] - 4);
                                mpJpeg.imagedata = imagedata;

                                // NSM seems to give headers in different order. 
                                // So check for the initial header and assign to right object.

                                if (firstHeader.Contains("Content-Type"))
                                {
                                    mpJpeg.content = firstHeader;
                                    mpJpeg.timestamp = secondHeader;
                                }
                                else if (firstHeader.Contains("Image-Time"))
                                {
                                    mpJpeg.timestamp = firstHeader;
                                    mpJpeg.content = secondHeader;
                                }

                            }

                            // Convert response content into image
                            // StackOverflow https://stackoverflow.com/a/14673714 

                            Image JpgSnapshot = (Bitmap)((new ImageConverter()).ConvertFrom(mpJpeg.imagedata));
                            DateTime JpgTimeStamp = VUStringHelper.getImageTime(mpJpeg.timestamp);

                            picCamPreviewJPG.Image = JpgSnapshot;

                            lblSnapshotStatus.ForeColor = Color.Yellow;

                            CultureInfo systemLocale = CultureInfo.CurrentCulture;
                            lblSnapshotStatus.Text = JpgTimeStamp.ToLocalTime().ToString("G", systemLocale);

                        }
                        else if (rspSnapshot.StatusCode == HttpStatusCode.InternalServerError)
                        {
                            lblSnapshotStatus.ForeColor = Color.Red;
                            MessageBox.Show("Internal Server Error:\nFailed to load snapshot image for this timestamp.", "Recorder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lblSnapshotStatus.Text = "Server Error";
                            picCamPreviewJPG.Image = Properties.Resources.code_icon;
                        }
                        else
                        {
                            SerenityError error = JsonConvert.DeserializeObject<SerenityError>(rspSnapshot.Content);
                            lblSnapshotStatus.ForeColor = Color.Red;
                            lblSnapshotStatus.Text = error.code;
                            picCamPreviewJPG.Image = Properties.Resources.code_icon;

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to display preview image.\n" + ex.Message, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        picCamPreviewJPG.Image = Properties.Resources.camerror;
                    }
                }
                else
                {
                    picCamPreviewJPG.Image = Properties.Resources.pelco_msi_logo;
                }

            }
        }

        private void olvDataInterfaces_DoubleClick(object sender, EventArgs e)
        {
            if (olvDataInterfaces.SelectedObjects.Count == 1)
            {
                vxDataInterface _di = (vxDataInterface)olvDataInterfaces.SelectedObject;                
                
                string di_description = _di.protocol.ToUpper() + ", ";
                if (_di.protocol != "mjpeg-pull")
                {
                    di_description += _di.data_encoding_id.ToUpper() + ", " + _di.x_resolution.ToString() + "x" + _di.y_resolution.ToString() + ", ";

                    if (_di.format != null)
                    {
                        di_description += _di.format.ToUpper() + " using ";
                    }
                    
                    if (_di.multicast == true)
                    {
                        di_description += "MULTICAST";
                    }
                    else
                    {
                        di_description += "UNICAST";
                    }
                    
                    Clipboard.Clear();
                    Clipboard.SetText(_di._links.pelco_rel_endpoint);

                    string ffplay_args = "-x " + _di.x_resolution + " -y " + _di.y_resolution + " -window_title \"" + di_description + "\" -i \"" + _di._links.pelco_rel_endpoint + "\"";
                    try
                    {
                        Process.Start(@"ffmpeg-bin\ffplay.exe", ffplay_args);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot playback live video: " + ex.Message, "Unable to run FFPLAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    di_description += "MJPEG Stream URL";

                    Clipboard.Clear();
                    Clipboard.SetText(_di._links.pelco_rel_endpoint);

                    MessageBox.Show(di_description + " has been copied to clipboard!", "Copy Endpoint Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                                               
            }
        }

        #endregion

        #region Enhanced Device Search

        private void btnSearchDevice_Click(object sender, EventArgs e)
        {
            devicesearchlist.Clear();
            devicesearchlist = SearchDevices(DeviceSearch_Type.General);
            olvDeviceResults.SetObjects(devicesearchlist);
        }

        private void btnLastModified_Click(object sender, EventArgs e)
        {
            txtDeviceSearchTerm.Clear();
            devicesearchlist.Clear();
            devicesearchlist = SearchDevices(DeviceSearch_Type.General);

            List<vxDevice> modifiedOnList = new List<vxDevice>();

            foreach (vxDevice d in devicesearchlist)
            {
                DateTime modifiedTime = DateTime.Parse(d._last_modified);
                if (modifiedTime.Date == dateTimePicker1.Value.Date)
                {
                    modifiedOnList.Add(d);
                }
            }

            ConsoleOutput(ConsoleWindow_Status.Normal, Convert.ToString(modifiedOnList.Count) + " devices were last modified on " + dateTimePicker1.Value.Date.ToShortDateString());
            olvDeviceResults.SetObjects(modifiedOnList);
        }


        private void btnOfflineDevices_Click(object sender, EventArgs e)
        {
            txtDeviceSearchTerm.Clear();
            devicesearchlist.Clear();
            devicesearchlist = SearchDevices(DeviceSearch_Type.Offline);
            olvDeviceResults.SetObjects(devicesearchlist);
        }

        private void olvDeviceResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<vxDataSource> assocdatasrcs = new List<vxDataSource>();
            assocdatasrcs.Clear();

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (olvDeviceResults.SelectedObjects.Count == 1) // Ignore multi-select cases
                {

                    vxDevice d = (vxDevice)olvDeviceResults.SelectedObject;

                    lblSelectedDevice.Text = d.name + " - " + d.ip;

                    if (d._embedded != null)
                    {
                        DataSourceQuery assocdsquery = d._embedded.pelco_rel_data_sources;
                        assocdatasrcs = assocdsquery.data_sources;
                    }

                    /// Populate the ObjectListview Box

                    olvAssocDataSources.SetObjects(assocdatasrcs);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace + "\nA matching datasource is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                assocdatasrcs.Clear();
                olvAssocDataSources.SetObjects(assocdatasrcs);
            }

            Cursor.Current = Cursors.Default;
        }

        private List<vxDevice> SearchDevices(DeviceSearch_Type query, string _param = "parameter")
        {

            ConsoleOutput(ConsoleWindow_Status.Normal, "Querying...");
            Cursor.Current = Cursors.WaitCursor;

            List<vxDevice> _devicelist = new List<vxDevice>();

            /// Create the usual rest request

            RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
            RestRequest firstRequest = SerenityRequest.getReq(vuURI.pelco_rel_devices, true);

            string q_filter = null;
            string embed_param = null;

            /// Build search query based on the argument passed. 

            switch (query)
            {

                case DeviceSearch_Type.General:
                    q_filter = "(name,model,version,id,ip,type,vendor likei '" + txtDeviceSearchTerm.Text + "')";
                    embed_param = "{\"/pelco/rel/data_sources\":{}}";
                    firstRequest.AddParameter("q", q_filter);
                    firstRequest.AddParameter("embed", embed_param);
                    break;
                case DeviceSearch_Type.Advanced:
                    q_filter = txtDeviceAdvFilter.Text;
                    embed_param = "{\"/pelco/rel/data_sources\":{}}";
                    firstRequest.AddParameter("q", q_filter);
                    firstRequest.AddParameter("embed", embed_param);
                    break;
                case DeviceSearch_Type.Offline:
                    q_filter = "(state eq 'offline')";
                    embed_param = "{\"/pelco/rel/data_sources\":{}}";
                    firstRequest.AddParameter("q", q_filter);
                    firstRequest.AddParameter("embed", embed_param);
                    break;
                case DeviceSearch_Type.NotCommissioned:
                    embed_param = "{\"/pelco/rel/data_sources\":{}}";
                    firstRequest.AddParameter("commissioned", false);
                    firstRequest.AddParameter("embed", embed_param);
                    break;
                case DeviceSearch_Type.Recorder:
                    q_filter = "(type eq 'recorder')";
                    embed_param = "{\"/pelco/rel/data_sources\":{}, \"/pelco/rel/data_storage\":{}}";
                    firstRequest.AddParameter("q", q_filter);
                    firstRequest.AddParameter("embed", embed_param);
                    break;
                case DeviceSearch_Type.Type:
                    q_filter = "(type eq '" + _param + "')";                    
                    firstRequest.AddParameter("q", q_filter);                    
                    break;
            }

            /// Embed associated datasources

            firstRequest.AddParameter("_system_id", systemID);
            IRestResponse<DeviceQuery> firstPage = vuClient.Execute<DeviceQuery>(firstRequest);

            toolStripStatusMessage.Text = VUStringHelper.VxCoreSays(firstPage.StatusDescription);

            if (firstPage.StatusCode != HttpStatusCode.OK)
            {
                ConsoleOutput(ConsoleWindow_Status.Warning, firstPage.StatusDescription + "!\nPlease check ADVFILTER expression and retry.");
            }
            else
            {
                ConsoleOutput(ConsoleWindow_Status.Normal, Convert.ToString(firstPage.Data.collection_header.total_items) + " Devices found.");

                /// Build the device list

                _devicelist = firstPage.Data.devices;

                /// Now, if there are more result - paginate, and add them to the search result

                if (firstPage.Data.collection_header._links != null)
                {
                    string paginator = firstPage.Data.collection_header._links.next;

                    while (paginator != null)
                    {
                        RestRequest nextRequest = SerenityRequest.getReq(paginator, true);
                        switch (query)
                        {
                            case DeviceSearch_Type.General:
                                q_filter = "(name,model,version,id,ip,type,vendor likei '" + txtDeviceSearchTerm.Text + "')";
                                embed_param = "{\"/pelco/rel/data_sources\":{}}";
                                firstRequest.AddParameter("q", q_filter);
                                firstRequest.AddParameter("embed", embed_param);
                                break;
                            case DeviceSearch_Type.Advanced:
                                q_filter = txtDeviceAdvFilter.Text;
                                embed_param = "{\"/pelco/rel/data_sources\":{}}";
                                firstRequest.AddParameter("q", q_filter);
                                firstRequest.AddParameter("embed", embed_param);
                                break;
                            case DeviceSearch_Type.Offline:
                                q_filter = "(state eq 'offline')";
                                embed_param = "{\"/pelco/rel/data_sources\":{}}";
                                firstRequest.AddParameter("q", q_filter);
                                firstRequest.AddParameter("embed", embed_param);
                                break;
                            case DeviceSearch_Type.NotCommissioned:
                                embed_param = "{\"/pelco/rel/data_sources\":{}}";
                                firstRequest.AddParameter("commissioned", false);
                                firstRequest.AddParameter("embed", embed_param);
                                break;
                            case DeviceSearch_Type.Recorder:
                                q_filter = "(type eq '" + _param + "')";
                                embed_param = "{\"/pelco/rel/data_sources\":{}, \"/pelco/rel/data_storage\":{}}";
                                firstRequest.AddParameter("q", q_filter);
                                firstRequest.AddParameter("embed", embed_param);
                                break;
                            case DeviceSearch_Type.Type:
                                q_filter = "(type eq '" + _param + "')";
                                firstRequest.AddParameter("q", q_filter);
                                break;
                        }
                        nextRequest.AddParameter("_system_id", systemID);
                        IRestResponse<DeviceQuery> nextPage = vuClient.Execute<DeviceQuery>(nextRequest);

                        _devicelist.AddRange(nextPage.Data.devices);

                        paginator = nextPage.Data.collection_header._links.next;

                    }
                }
            }

            Cursor.Current = Cursors.Default;

            return _devicelist;

        }


        private void btnExportCSV_Device_Click(object sender, EventArgs e)
        {
            List<Device_CSV> csv_dev_export = new List<Device_CSV>();

            foreach (vxDevice d in devicesearchlist)
            {
                Device_CSV csvrow = new Device_CSV
                {
                    Device_Name = d.name,
                    Device_GUID = d.id,
                    IP_Address = d.ip,
                    MAC_Address = d.mac_address,
                    Model = d.model,
                    Type = d.type,
                    Version = d.version,
                    Serial = d.serial,
                    Status = d.state,
                    Vendor = d.vendor,
                    Commissioned = d.commissioned
                };
                csv_dev_export.Add(csvrow);
            }

            saveVUFilesDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveVUFilesDialog.Filter = "Comma-Separated Values (*.csv)|*.csv";
            saveVUFilesDialog.RestoreDirectory = true;
            saveVUFilesDialog.ShowHelp = true;

            if (saveVUFilesDialog.ShowDialog() == DialogResult.OK)
            {
                var csvwriter = new FileHelperEngine<Device_CSV>(Encoding.UTF8);

                csvwriter.HeaderText = csvwriter.GetFileHeader();
                csvwriter.WriteFile(saveVUFilesDialog.FileName, csv_dev_export);

                MessageBox.Show("CSV File created in:\n" + saveVUFilesDialog.FileName, "Export Device CSV Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }



        #endregion

        #region Recorder Viewer

        private List<vxDevice> SearchRecorders(string _param)
        {

            // Emulates Admin Portal Recorder tab
            // Requests DataStorage, then grabs embedded Device and DataSources.

            ConsoleOutput(ConsoleWindow_Status.Normal, "Querying...");
            Cursor.Current = Cursors.WaitCursor;

            List<vxDevice> _devicelist = new List<vxDevice>();

            /// Create the usual rest request

            RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
            RestRequest firstRequest = SerenityRequest.getReq(vuURI.pelco_rel_devices, true);

            string embed_param = null;

            /// Build search query based on the argument passed. 

            embed_param = "{\"/pelco/rel/data_storage\":{}}";

            firstRequest.AddParameter("q", _param);
            firstRequest.AddParameter("start", "0");
            firstRequest.AddParameter("count", "500");
            firstRequest.AddParameter("embed", embed_param);

            IRestResponse<DeviceQuery> firstPage = vuClient.Execute<DeviceQuery>(firstRequest);

            toolStripStatusMessage.Text = VUStringHelper.VxCoreSays(firstPage.StatusDescription);

            if (firstPage.StatusCode != HttpStatusCode.OK)
            {
                ConsoleOutput(ConsoleWindow_Status.Warning, firstPage.StatusDescription + "!\nIncorrect Query. Please Retry");
            }
            else
            {
                ConsoleOutput(ConsoleWindow_Status.Normal, Convert.ToString(firstPage.Data.collection_header.total_items) + " Devices found.");

                /// Build the device list

                _devicelist = firstPage.Data.devices;

                /// Now, if there are more result - paginate, and add them to the search result

                if (firstPage.Data.collection_header._links != null)
                {
                    string paginator = firstPage.Data.collection_header._links.next;

                    while (paginator != null)
                    {
                        RestRequest nextRequest = SerenityRequest.getReq(paginator, true);

                        embed_param = "{\"/pelco/rel/data_storage\":{}}";

                        firstRequest.AddParameter("type", _param);
                        firstRequest.AddParameter("start", "0");
                        firstRequest.AddParameter("count", "500");
                        firstRequest.AddParameter("embed", embed_param);

                        IRestResponse<DeviceQuery> nextPage = vuClient.Execute<DeviceQuery>(nextRequest);

                        _devicelist.AddRange(nextPage.Data.devices);

                        paginator = nextPage.Data.collection_header._links.next;

                    }
                }                
            }


            Cursor.Current = Cursors.Default;

            return _devicelist;

        }

        private void btnGetAllRecorders_Click(object sender, EventArgs e)
        {
            List<vxDevice> recordersearchlist = SearchRecorders("(type eq 'recorder')or(type eq 'all_in_one')");
            olvRecorderSearchResult.SetObjects(recordersearchlist);
            lblTotalRecorders.Text = "Total " + recordersearchlist.Count.ToString() + " recorders in system.";
        }

        private void olvRecorderSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (olvRecorderSearchResult.SelectedObjects.Count == 1)
            {
                vxDevice recdevice = (vxDevice)olvRecorderSearchResult.SelectedObject;
                olvRecorderAssocDS.ClearObjects();

                if (recdevice._embedded == null)
                {
                    lblRecorderUnitCh.Text = "(N/A)";
                    lblRecorderUnitAssBitrate.Text = "(N/A)";
                    lblRecorderUnitSetRet.Text = "(N/A)";
                    lblRecorderUnitActRet.Text = "(N/A)";
                    lblRecorderUnitXcast.Text = "(N/A)";
                    grpVxsDiag.Enabled = false;
                }
                else
                {
                    vxRecorder recdatastorage = recdevice._embedded.pelco_rel_data_storage;

                    grpBoxRecorderDetail.Text = "Selected Recorder: " + recdevice.ip;

                    List<vxDataSource> recassocDS = SearchDataSources(DataSrcSearch_Type.DataStorage, recdevice.id);

                    olvRecorderAssocDS.SetObjects(recassocDS);
                    lblRecorderAssocDS.Text = "Associated Cameras for recorder [" + recdevice.ip + "]";

                    grpBoxRecorderDetail.Text = "Selected Recorder: " + recdatastorage.name;

                    if (recdatastorage.type == "vxs")
                    {
                        lnkRecorderIP.Text = recdevice.ip + ":" + Properties.Settings.Default.vxsPort;
                    }
                    else
                    {
                        lnkRecorderIP.Text = recdevice.ip;
                    }

                    lblRecorderUnitVersion.Text = recdevice.version;
                    lblRecorderUnitType.Text = recdatastorage.type;
                    lblRecorderUnitGUID.Text = recdatastorage.id;
                    lblRecorderUnitFailover.Text = recdatastorage.failover.ToString();

                    if (recdatastorage.type == "vxs")
                    {
                        if (recdevice.state == "online")
                        {
                            vxsDiagnostic vxsDiag = getVxsDiagnostic(recdevice.ip, Properties.Settings.Default.vxsPort);

                            if (vxsDiag != null)
                            {
                                grpVxsDiag.Enabled = true;
                                cmbVolumes.Items.Clear();
                                vxsConfig vxsConfig = getVxsConfig(recdevice.ip, Properties.Settings.Default.vxsPort);

                                lblRecorderUnitCh.Text = vxsDiag.assignments.data_sources.ToString() + " total channels";
                                lblRecorderUnitAssBitrate.Text = Math.Round((float)vxsDiag.assignments.bitrate / ((float)1024 * (float)1024), 2).ToString() + " Mbps";

                                if (vxsConfig.retention_limit == 0)
                                {
                                    lblRecorderUnitSetRet.Text = "Unlimited";
                                }
                                else
                                {
                                    lblRecorderUnitSetRet.Text = vxsConfig.retention_limit.ToString() + " Hours";
                                }

                                TimeSpan actRet = new TimeSpan(vxsDiag.retention.retention, 0, 0);
                                lblRecorderUnitActRet.Text = string.Format("{0:%d} Days {0:%h} Hours", actRet);
                                lblRecorderUnitXcast.Text = vxsConfig.xcast;
                                lblRecorderUnitEvents.Text = vxsDiag.events.event_rate.ToString();

                                Volumes vxsVolumes = getVxsVolumes(recdevice.ip, Properties.Settings.Default.vxsPort);
                                float totalStorCap = 0;
                                float totalUsedCap = 0;

                                foreach (vxVolume v in vxsVolumes.volumes)
                                {
                                    string volText = v.path + " [" + (v.used/1024).ToString("N") + " GB used/" + (v.total/1024).ToString("N") + " GB avail]";                                    
                                    cmbVolumes.Items.Add(volText);
                                    totalStorCap += v.total;
                                    totalUsedCap += v.used;
                                }

                                cmbVolumes.SelectedIndex = 0;
                                float totalPercent = (totalUsedCap / totalStorCap) * 100;
                                // MessageBox.Show(totalUsedCap.ToString() + "-" + totalStorCap.ToString() + "-" + );
                                prgVolumeSpace.Value = (int)totalPercent;
                                grpVxsDiag.Enabled = true;

                            }

                            else
                            {
                                ConsoleOutput(ConsoleWindow_Status.Error, "Error getting VXS Diagnostics.\nPlease check your VXS login credential or connection.");                                

                                lblRecorderUnitCh.Text = "(N/A)";
                                lblRecorderUnitAssBitrate.Text = "(N/A)";
                                lblRecorderUnitSetRet.Text = "(N/A)";
                                lblRecorderUnitActRet.Text = "(N/A)";
                                lblRecorderUnitXcast.Text = "(N/A)";
                                lblRecorderUnitEvents.Text = "(N/A)";
                                grpVxsDiag.Enabled = false;

                            }
                            grpBoxRecorderDetail.Enabled = true;

                        }
                        else
                        {
                            lblRecorderUnitCh.Text = "(Offline)";
                            lblRecorderUnitAssBitrate.Text = "(Offline)";
                            lblRecorderUnitSetRet.Text = "(Offline)";
                            lblRecorderUnitActRet.Text = "(Offline)";
                            lblRecorderUnitXcast.Text = "(Offline)";
                            lblRecorderUnitEvents.Text = "(Offline)";
                            grpVxsDiag.Enabled = false;
                        }
                    }
                    else
                    {
                        lblRecorderUnitCh.Text = "(N/A)";
                        lblRecorderUnitAssBitrate.Text = "(N/A)";
                        lblRecorderUnitSetRet.Text = "(N/A)";
                        lblRecorderUnitActRet.Text = "(N/A)";
                        lblRecorderUnitXcast.Text = "(N/A)";
                        lblRecorderUnitEvents.Text = "(N/A)";
                        grpVxsDiag.Enabled = false;
                        grpBoxRecorderDetail.Enabled = true;
                    }
                }
            }
        }

        private vxsDiagnostic getVxsDiagnostic(string _vxsIP, string _vxsPort)
        {
            vxsDiagnostic _DiagResult = new vxsDiagnostic();

            // Step 1. Get to /system

            RestClient vuClient = new RestClient("https://" + _vxsIP + ":" + _vxsPort);
            RestRequest reqVxsSystem = SerenityRequest.vxsGetReq("/system", SerenityVersion);

            IRestResponse<SystemQuery> rspVxsSystem = vuClient.Execute<SystemQuery>(reqVxsSystem);

            if (rspVxsSystem.StatusCode == HttpStatusCode.OK)
            {
                relLinks vxsURI = rspVxsSystem.Data._links;

                // Step 2. Get pelco/rel/device

                RestRequest reqVxsDevice = SerenityRequest.vxsGetReq(vxsURI.pelco_rel_device, SerenityVersion);
                IRestResponse<vxDevice> rspVxsDevice = vuClient.Execute<vxDevice>(reqVxsDevice);

                vxsURI = rspVxsDevice.Data._links;

                // Step 3. Get pelco/rel/diagnostics

                RestRequest reqVxsDiag = SerenityRequest.vxsGetReq(vxsURI.pelco_rel_diagnostic, SerenityVersion);
                IRestResponse<vxsDiagnostic> rspVxsDiag = vuClient.Execute<vxsDiagnostic>(reqVxsDiag);

                _DiagResult = rspVxsDiag.Data;
                return _DiagResult;

            }
            else
            {
                return null;
            }

        }

        private vxsConfig getVxsConfig(string _vxsIP, string _vxsPort)
        {
            // Step 1. Get to /system

            RestClient vuClient = new RestClient("https://" + _vxsIP + ":" + _vxsPort);
            RestRequest reqVxsSystem = SerenityRequest.vxsGetReq("/system", SerenityVersion);

            IRestResponse<SystemQuery> rspVxsSystem = vuClient.Execute<SystemQuery>(reqVxsSystem);

            relLinks vxsURI = rspVxsSystem.Data._links;

            // Step 2. Get pelco/rel/device

            RestRequest reqVxsDevice = SerenityRequest.vxsGetReq(vxsURI.pelco_rel_device, SerenityVersion);
            IRestResponse<vxDevice> rspVxsDevice = vuClient.Execute<vxDevice>(reqVxsDevice);

            vxsURI = rspVxsDevice.Data._links;

            // Step 3. Get pelco/rel/configuration

            RestRequest reqConfig = SerenityRequest.vxsGetReq(vxsURI.pelco_rel_configuration, SerenityVersion);
            IRestResponse<SystemQuery> rspConfig = vuClient.Execute<SystemQuery>(reqConfig);

            vxsURI = rspConfig.Data._links;

            // Step 4. Get pelco/rel/vxs

            RestRequest reqVxsConfig = SerenityRequest.vxsGetReq(vxsURI.pelco_rel_vxs, SerenityVersion);
            IRestResponse<vxsConfig> rspVxsConfig = vuClient.Execute<vxsConfig>(reqVxsConfig);

            vxsConfig _ConfigResult = rspVxsConfig.Data;

            return _ConfigResult;
        }

        private Volumes getVxsVolumes(string _vxsIP, string _vxsPort)
        {
            // Step 1. Get to /system

            RestClient vuClient = new RestClient("https://" + _vxsIP + ":" + _vxsPort);
            RestRequest reqVxsSystem = SerenityRequest.vxsGetReq("/system", SerenityVersion);

            IRestResponse<SystemQuery> rspVxsSystem = vuClient.Execute<SystemQuery>(reqVxsSystem);

            relLinks vxsURI = rspVxsSystem.Data._links;

            // Step 2. Get pelco/rel/device

            RestRequest reqVxsDevice = SerenityRequest.vxsGetReq(vxsURI.pelco_rel_device, SerenityVersion);
            IRestResponse<vxDevice> rspVxsDevice = vuClient.Execute<vxDevice>(reqVxsDevice);

            vxsURI = rspVxsDevice.Data._links;

            // Step 3. Get pelco/rel/configuration

            RestRequest reqConfig = SerenityRequest.vxsGetReq(vxsURI.pelco_rel_configuration, SerenityVersion);
            IRestResponse<SystemQuery> rspConfig = vuClient.Execute<SystemQuery>(reqConfig);

            vxsURI = rspConfig.Data._links;

            // Step 4. Get pelco/rel/vxs

            RestRequest reqVxsConfig = SerenityRequest.vxsGetReq(vxsURI.pelco_rel_vxs, SerenityVersion);
            IRestResponse<vxsConfig> rspVxsConfig = vuClient.Execute<vxsConfig>(reqVxsConfig);


            vxsURI = rspVxsConfig.Data._links;

            // Step 5. Get pelco/rel/volumes

            RestRequest reqVxsVolumes = SerenityRequest.vxsGetReq(vxsURI.pelco_rel_volumes, SerenityVersion);
            IRestResponse<Volumes> rspVxsVolumes = vuClient.Execute<Volumes>(reqVxsVolumes);

            Volumes _VolumesResult = rspVxsVolumes.Data;

            return _VolumesResult;
        }



        private void lnkRecorderIP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://" + lnkRecorderIP.Text);
        }

        private void olvRecorderAssocDS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cmbVolumes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Users and Roles

        private void txtQuickAddUser_TextChanged(object sender, EventArgs e)
        {
            if (txtQuickAddUser.Text.Length >= 1)
            {
                btnAddUser.Enabled = true;
            }
            else
            {
                btnAddUser.Enabled = false;
            }
        }

        private void txtQuickAddUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddUser_Click(this, new EventArgs());
            }
        }

        private void txtUserSearchTerm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchUser_Click(this, new EventArgs());
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {

            rolelist_users.Clear();
            cmbRoleList.Items.Clear();

            string _norole = "(None)";
            cmbRoleList.Enabled = false;

            usersearchlist = SearchUsers();

            olvUserList.SetObjects(usersearchlist);

            rolelist_users = SearchRoles(RoleSearch_Type.Users);

            foreach (vxRole r in rolelist_users)
            {
                cmbRoleList.Items.Add(r.name);
            }
            cmbRoleList.Items.Add(_norole);
            cmbRoleList.Enabled = true;
            ConsoleOutput(ConsoleWindow_Status.Normal, usersearchlist.Count().ToString() + " users and " + rolelist_users.Count().ToString() + " roles found.");

        }

        private void cmbRoleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _norole = "(None)";

            if ((string)cmbRoleList.SelectedItem == _norole)
            {
                txtUserSearchTerm.Clear();

                List<vxUser> fulluserlist = SearchUsers();

                List<vxUser> emptyroleuserlist = new List<vxUser>();

                foreach (vxUser u in fulluserlist)
                {
                    RoleQuery rq = u._embedded.pelco_rel_roles;
                    List<vxRole> rl = rq.roles;

                    if (rl.Count < 1)
                    {
                        emptyroleuserlist.Add(u);
                    }

                }
                olvUserList.SetObjects(emptyroleuserlist);
                ConsoleOutput(ConsoleWindow_Status.Normal, emptyroleuserlist.Count().ToString() + " users with NO roles found.");

            }
            else
            {
                vxRole r = rolelist_users.Find(x => x.name == (string)cmbRoleList.SelectedItem);

                UserQuery assocUsers_q = r._embedded.pelco_rel_users;

                List<vxUser> assocUsers = new List<vxUser>();
                foreach (vxUser u in assocUsers_q.users)
                {
                    assocUsers.Add(u);
                }

                olvUserList.SetObjects(assocUsers);
                ConsoleOutput(ConsoleWindow_Status.Normal, assocUsers.Count().ToString() + " users with [" + (string)cmbRoleList.SelectedItem + "] role found.");
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            NewUser u = new NewUser
            {
                _type = "NewUser",
                change_password = true,
                name = txtQuickAddUser.Text,
                password = "123456789"
            };

            RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);

            RestRequest getRelLink = SerenityRequest.getReq(vuURI.pelco_rel_users, true);
            getRelLink.AddParameter("count", 0);
            IRestResponse<TagQuery> respRelLink = vuClient.Execute<TagQuery>(getRelLink);

            relLinks adduserlink = respRelLink.Data._links;

            RestRequest addOneUserReq = SerenityRequest.postReq(adduserlink.pelco_rel_add_user);            
            addOneUserReq.AddJsonBody(u);


            IRestResponse addOneTagResp = vuClient.Execute(addOneUserReq);

            if (addOneTagResp.StatusCode != HttpStatusCode.Created)
            {
                toolStripStatusMessage.Text = VUStringHelper.VxCoreSays(addOneTagResp.StatusDescription);
                MessageBox.Show("Error creating the user. Name may exist already in system.", "Unable to add user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnSearchUser_Click(this, new EventArgs());
        }

        private void btnImportUserTXT_Click(object sender, EventArgs e)
        {
            DialogResult opentxtfile = MessageBox.Show("Please prepare a Text (.txt) file that contains usernames on each line, such as:\n\nbart.simpson\nhomer.simpson\ndarth.vader\nluke.skywalker\n....\n\nClick OK when ready to proceed.", "Open Text Document", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (opentxtfile == DialogResult.OK)
            {
                try
                {
                    openTXTDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    openTXTDialog.Filter = "Text Files (*.txt)|*.txt";
                    openTXTDialog.RestoreDirectory = true;
                    openTXTDialog.ShowHelp = true;

                    if (openTXTDialog.ShowDialog() == DialogResult.OK)
                    {
                        List<NewUser> useraddlist = new List<NewUser>();
                        StreamReader usertxtreader = new StreamReader(openTXTDialog.FileName);
                        int counter = 0;

                        string username = null;
                        while ((username = usertxtreader.ReadLine()) != null)
                        {
                            NewUser u = new NewUser
                            {
                                _type = "NewUser",
                                change_password = true,
                                name = username,
                                password = "123456789"
                            };

                            useraddlist.Add(u);
                            counter++;
                        }

                        DialogResult useraddok = MessageBox.Show("Total " + counter.ToString() + " users will be imported from file:\n" + openTXTDialog.FileName + ".\n\nClick OK to Proceed.", "Confirm User Import", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (useraddok == DialogResult.OK)
                        {
                            frmProgress addUserProgress = new frmProgress(useraddlist);
                            addUserProgress.progressURI = vuURI;
                            addUserProgress.ShowDialog(this);
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Read error occurred:\n" + ex.Message, "TXT Import Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            btnSearchUser_Click(this, new EventArgs());
        }

        private List<vxUser> SearchUsers()
        {
            List<vxUser> _userlist = new List<vxUser>();
            List<vxUser> _filteredUserList = new List<vxUser>();

            ConsoleOutput(ConsoleWindow_Status.Normal, "Querying...");
            Cursor.Current = Cursors.WaitCursor;

            /// Create the usual rest request

            RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
            RestRequest firstRequest = SerenityRequest.getReq(vuURI.pelco_rel_users, true);

            /// Embed associated roles
            if (txtUserSearchTerm.Text != null)
            {
                firstRequest.AddParameter("q", "(name likei '" + txtUserSearchTerm.Text + "')");
            }
            firstRequest.AddParameter("embed", "{\"/pelco/rel/roles\":{}}");
            IRestResponse<UserQuery> firstPage = vuClient.Execute<UserQuery>(firstRequest);

            toolStripStatusMessage.Text = VUStringHelper.VxCoreSays(firstPage.StatusDescription);

            /// Build the global device list

            _userlist = firstPage.Data.users;

            /// Now, if there are more result - paginate, and add them to the search result            

            if (firstPage.Data.collection_header._links != null)
            {

                string paginator = firstPage.Data.collection_header._links.next;

                while (paginator != null)
                {
                    RestRequest nextRequest = SerenityRequest.getReq(paginator, true);

                    if (txtUserSearchTerm.Text != null)
                    {
                        nextRequest.AddParameter("q", "(name likei '" + txtUserSearchTerm.Text + "')");
                    }

                    nextRequest.AddParameter("embed", "{\"/pelco/rel/roles\":{}}");
                    IRestResponse<UserQuery> nextPage = vuClient.Execute<UserQuery>(nextRequest);

                    _userlist.AddRange(nextPage.Data.users);

                    paginator = nextPage.Data.collection_header._links.next;

                }
            }

            Cursor.Current = Cursors.Default;

            /// Filter the master user list to exclude System users

            foreach (vxUser u in _userlist)
            {
                if(u._links.pelco_rel_delete != null)
                {
                    _filteredUserList.Add(u);
                }
            }

            return _filteredUserList;
        }

        private List<vxRole> SearchRoles(RoleSearch_Type query)
        {
            List<vxRole> _rolelist = new List<vxRole>();
            ConsoleOutput(ConsoleWindow_Status.Normal, "Querying...");
            Cursor.Current = Cursors.WaitCursor;

            /// Create the usual rest request

            RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
            RestRequest firstRequest = SerenityRequest.getReq(vuURI.pelco_rel_roles, true);

            /// Embed associated users and privileges

            switch (query)
            {
                case RoleSearch_Type.Users:
                    firstRequest.AddParameter("embed", "{\"/pelco/rel/users\":{}}");
                    break;
                case RoleSearch_Type.Privileges:
                    firstRequest.AddParameter("embed", "{\"/pelco/rel/privileges\":{}}");
                    firstRequest.AddParameter("internal", false);
                    break;
                case RoleSearch_Type.None:
                    break;
            }

            IRestResponse<RoleQuery> firstPage = vuClient.Execute<RoleQuery>(firstRequest);

            toolStripStatusMessage.Text = VUStringHelper.VxCoreSays(firstPage.StatusDescription);

            /// Build the master role list

            _rolelist = firstPage.Data.roles;

            /// Now, if there are more result - paginate, and add them to the search result

            if (firstPage.Data.collection_header._links != null)
            {
                string paginator = firstPage.Data.collection_header._links.next;

                while (paginator != null)
                {
                    RestRequest nextRequest = SerenityRequest.getReq(paginator, true);

                    switch (query)
                    {
                        case RoleSearch_Type.Users:
                            nextRequest.AddParameter("embed", "{\"/pelco/rel/users\":{}}");
                            break;
                        case RoleSearch_Type.Privileges:
                            nextRequest.AddParameter("embed", "{\"/pelco/rel/privileges\":{}}");
                            firstRequest.AddParameter("internal", false);
                            break;
                        case RoleSearch_Type.None:
                            break;
                    }

                    IRestResponse<RoleQuery> nextPage = vuClient.Execute<RoleQuery>(nextRequest);

                    _rolelist.AddRange(nextPage.Data.roles);

                    paginator = nextPage.Data.collection_header._links.next;

                }
            }           

            /// For User-embedded searches, filter out the internal UserRole items.

            List<vxRole> _filteredlist = new List<vxRole>();

            foreach (vxRole r in _rolelist)
            {
                if (r.name.Contains("UserRole") == false)
                {
                    _filteredlist.Add(r);
                }
            }

            Cursor.Current = Cursors.Default;
            _rolelist = null;

            return _filteredlist;
        }

        private void olvUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (olvUserList.SelectedObjects.Count == 1)
            {
                vxUser user = (vxUser)olvUserList.SelectedObject;
                lblSelectedUserName.Text = user.name;

                List<vxRole> assocRoles = new List<vxRole>();
                List<vxPhoneNumbers> assocPN = new List<vxPhoneNumbers>();

                assocPN = user.phone_numbers;
                olvAssocPhoneNumbers.SetObjects(assocPN);

                try
                {
                    RoleQuery assocRoles_q = user._embedded.pelco_rel_roles;

                    foreach (vxRole r in assocRoles_q.roles)
                    {
                        if (r.name.Contains("UserRole") == false)
                        {
                            assocRoles.Add(r);
                        }
                    }
                }
                catch
                {
                    RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                    RestRequest refreshRole = SerenityRequest.getReq(user._links.pelco_rel_roles, true);


                    IRestResponse<RoleQuery> firstPage = vuClient.Execute<RoleQuery>(refreshRole);

                    RoleQuery queryResult = firstPage.Data;

                    foreach (vxRole r in queryResult.roles)
                    {
                        if (r.name.Contains("UserRole") == false)
                        {
                            assocRoles.Add(r);
                        }
                    }
                }

                olvAssocRoles.SetObjects(assocRoles);

                

            }
        }

        private void btnImportUserCSV_Click(object sender, EventArgs e)
        {
            List<User_CSV> csv_user_import = new List<User_CSV>();
            frmImportUserCSV validateUserCSV = new frmImportUserCSV();
            validateUserCSV.ShowDialog(this);

            if (validateUserCSV.DialogResult == DialogResult.OK)
            {
                csv_user_import = validateUserCSV.importCSV_Users_list;
                DialogResult proceed = MessageBox.Show("Total " + csv_user_import.Count.ToString() + " users will be added to the system. Proceed?", "Import CSV", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (proceed == DialogResult.OK)
                {
                    frmProgress DoActualImport = new frmProgress(csv_user_import);
                    DoActualImport.progressURI = vuURI;
                    DoActualImport.ShowDialog(this);
                }

            }
            btnSearchUser_Click(this, new EventArgs());
        }

        private void btnExportUserCSV_Click(object sender, EventArgs e)
        {
            List<User_CSV> csv_user_export = new List<User_CSV>();

            foreach (vxUser u in usersearchlist)
            {
                string u_phonenum0 = "";
                if (u.phone_numbers.Count > 0)
                {
                    u_phonenum0 = u.phone_numbers[0].number;
                }
                User_CSV csvrow = new User_CSV
                {
                    Username = u.name,
                    First_Name = u.first_name,
                    Last_Name = u.last_name,
                    Employee_ID = u.employee_id,                    
                    Work_Phone = u_phonenum0,
                    Email_Address = u.email,
                    Notes = u.note
                };

                csv_user_export.Add(csvrow);
            }

            saveVUFilesDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveVUFilesDialog.Filter = "Comma-Separated Values (*.csv)|*.csv";
            saveVUFilesDialog.RestoreDirectory = true;
            saveVUFilesDialog.ShowHelp = true;

            if (saveVUFilesDialog.ShowDialog() == DialogResult.OK)
            {
                var csvwriter = new FileHelperEngine<User_CSV>(Encoding.UTF8);

                csvwriter.HeaderText = csvwriter.GetFileHeader();
                csvwriter.WriteFile(saveVUFilesDialog.FileName, csv_user_export);

                MessageBox.Show("CSV File created in:\n" + saveVUFilesDialog.FileName + "\n\nYou can edit this file to update users in batch, then import back.", "Export CSV Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        
    }
        #endregion

}