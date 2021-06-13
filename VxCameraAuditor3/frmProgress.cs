using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using RestSharp;

namespace VxCameraAuditor3
{
    public partial class frmProgress : Form
    {

        public relLinks progressURI { get; set; }

        private relLinks itemURI { get; set; }

        List<vxTag> taglist = new List<vxTag>();
        List<vxDevice> devicestodelete = new List<vxDevice>();
        List<ResourceRef> devcamsrscrefs = new List<ResourceRef>();
        List<TagAdd> tagstoadd = new List<TagAdd>();
        List<DataSource_CSV> dstoupdate = new List<DataSource_CSV>();
        List<NewUser> userstoadd = new List<NewUser>();
        List<User_CSV> csvuserstoadd = new List<User_CSV>();
        List<Device_CSV> dev_csvlist = new List<Device_CSV>();
        List<DataSource_CSV> ds_csvlist = new List<DataSource_CSV>();
        List<vxUser> userlist = new List<vxUser>();
        List<vxRole> rolestoadd = new List<vxRole>();

        private string destguid { get; set; }
        private bool ismerge { get; set; }
        private bool isdelete { get; set; }
        private bool islink { get; set; }
        private bool isunlink { get; set; }
        private NewPassword newpassword { get; set; }
        private bool isnewpassword { get; set; }
        private AddRemoveRole arr { get; set; }
        private bool isaddremoverole { get; set; }

        int success = 0;
        int failed = 0;
        int progress = 0;

        private string reason { get; set; }


        public frmProgress()
        {
            InitializeComponent();
        }

        public frmProgress(List<DataSource_CSV> _CSVDSToAdd)
        {
            InitializeComponent();
            dstoupdate = _CSVDSToAdd;
            btnClose.Enabled = false;
            btnCancelOperation.Enabled = true;

            bgwRequestHandler.RunWorkerAsync(dstoupdate);
        }

        public frmProgress(List<vxDevice> _DevicesToDelete)
        {
            InitializeComponent();
            devicestodelete = _DevicesToDelete;
            isdelete = true;

            btnClose.Enabled = false;
            btnCancelOperation.Enabled = true;

            bgwRequestHandler.RunWorkerAsync(devicestodelete);

        }

        public frmProgress(List<NewUser> _UsersToAdd)
        {
            InitializeComponent();
            userstoadd = _UsersToAdd;
            btnClose.Enabled = false;
            btnCancelOperation.Enabled = true;

            bgwRequestHandler.RunWorkerAsync(userstoadd);

        }

        public frmProgress(List<User_CSV> _CSVUsersToAdd)
        {
            InitializeComponent();
            csvuserstoadd = _CSVUsersToAdd;
            btnClose.Enabled = false;
            btnCancelOperation.Enabled = true;

            bgwRequestHandler.RunWorkerAsync(csvuserstoadd);
        }

        public frmProgress(List<vxUser> _UsersToDelete)
        {
            InitializeComponent();
            userlist = _UsersToDelete;
            isdelete = true;

            btnClose.Enabled = false;
            btnCancelOperation.Enabled = true;

            bgwRequestHandler.RunWorkerAsync(userlist);

        }

        public frmProgress(List<vxUser> _UsersToReset, NewPassword _newpassword)
        {
            InitializeComponent();
            userlist = _UsersToReset;
            newpassword = _newpassword;
            isnewpassword = true;

            btnClose.Enabled = false;
            btnCancelOperation.Enabled = true;

            bgwRequestHandler.RunWorkerAsync(userlist);

        }

        public frmProgress(List<vxUser> _UsersToAssignRole, AddRemoveRole _arr)
        {
            InitializeComponent();
            userlist = _UsersToAssignRole;
            arr = _arr;
            isaddremoverole = true;

            btnClose.Enabled = false;
            btnCancelOperation.Enabled = true;

            bgwRequestHandler.RunWorkerAsync(userlist);

        }

        private void bgwRequestHandler_DoWork(object sender, DoWorkEventArgs e)
        {
            /* Starts BackgroundWorker to update progress of what's happening.
             * The type of argument passed to bgwRequestHandler determines
             * what the worker will perform.
             */

            if (e.Argument is List<DataSource_CSV>)
            {

                List<DataSource_CSV> _bgwDStoEdit = e.Argument as List<DataSource_CSV>;

                RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);

                foreach (DataSource_CSV csvrow in _bgwDStoEdit)
                {
                    if (bgwRequestHandler.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }

                    postEditDS newDSName = new postEditDS();
                    newDSName.name = csvrow.Camera_Name;
                    newDSName.number = csvrow.Camera_Number;

                    RestRequest renameReq = SerenityRequest.patchReq(progressURI.pelco_rel_data_sources + "/" + csvrow.Device_GUID);
                    renameReq.AddJsonBody(newDSName);

                    IRestResponse renameResponse = vuClient.Execute(renameReq);

                    if (renameResponse.StatusCode == HttpStatusCode.NoContent)
                    {
                        success++;
                        reason = null;
                    }
                    else
                    {
                        failed++;
                        reason = "Failed to PATCH camera [" + csvrow.Camera_Name + "] because of: [" + renameResponse.StatusCode.ToString() + "]";
                    }

                    progress++;

                    int percent = progress * 100 / _bgwDStoEdit.Count;
                    bgwRequestHandler.ReportProgress(percent);
                }

            }

            else if (e.Argument is List<vxDevice>)
            {
                if (isdelete)
                {
                    List<vxDevice> _bgwDevice = e.Argument as List<vxDevice>;

                    foreach (vxDevice d in _bgwDevice)
                    {
                        if (bgwRequestHandler.CancellationPending == true)
                        {
                            e.Cancel = true;
                            return;
                        }

                        itemURI = d._links;

                        RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                        RestRequest delRequest = SerenityRequest.deleteReq(itemURI.edit);
                        IRestResponse delResponse = vuClient.Execute(delRequest);

                        if (delResponse.StatusCode == HttpStatusCode.NoContent)
                        {
                            success++;
                            reason = null;
                        }
                        else
                        {
                            failed++;
                            reason = d.name + " failed to DELETE: [" + delResponse.StatusCode.ToString() + "]";
                        }

                        progress++;

                        int percent = progress * 100 / _bgwDevice.Count;
                        bgwRequestHandler.ReportProgress(percent);

                    }
                }
            }

            else if (e.Argument is List<NewUser>)
            {

                List<NewUser> _bgwUserAdd = e.Argument as List<NewUser>;

                RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                RestRequest uriRequest = SerenityRequest.getReq(progressURI.pelco_rel_users, true);
                uriRequest.AddParameter("count", "0");

                IRestResponse<UserQuery> uriResponse = vuClient.Execute<UserQuery>(uriRequest);

                itemURI = uriResponse.Data._links;

                foreach (NewUser _nu in _bgwUserAdd)
                {

                    if (bgwRequestHandler.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }

                    RestRequest postRequest = SerenityRequest.postReq(itemURI.pelco_rel_add_user);

                    postRequest.AddJsonBody(_nu);

                    IRestResponse postResponse = vuClient.Execute(postRequest);

                    if (postResponse.StatusCode == HttpStatusCode.Created)
                    {
                        success++;
                        reason = null;
                    }
                    else
                    {
                        failed++;
                        reason = "Failed to POST new user [" + _nu.name + "] because of: [" + postResponse.StatusCode.ToString() + "]";
                    }

                    progress++;

                    int percent = progress * 100 / _bgwUserAdd.Count;
                    bgwRequestHandler.ReportProgress(percent);

                }

            }

            else if (e.Argument is List<User_CSV>)
            {

                List<User_CSV> _bgwUserAdd = e.Argument as List<User_CSV>;

                RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                RestRequest uriRequest = SerenityRequest.getReq(progressURI.pelco_rel_users, true);
                uriRequest.AddParameter("count", "0");

                IRestResponse<UserQuery> uriResponse = vuClient.Execute<UserQuery>(uriRequest);

                itemURI = uriResponse.Data._links;

                foreach (User_CSV _csvnu in _bgwUserAdd)
                {

                    if (bgwRequestHandler.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }

                    // 1. Create phone number list first

                    vxPhoneNumbers _csvpn = new vxPhoneNumbers
                    {
                        type = "work",
                        number = _csvnu.Work_Phone
                    };

                    List<vxPhoneNumbers> _csvpnlist = new List<vxPhoneNumbers> { _csvpn };

                    // 2. Convert CSV_User to NewUser

                    NewUser _nu = new NewUser
                    {
                        _type = "NewUser",
                        name = _csvnu.Username,
                        first_name = _csvnu.First_Name,
                        last_name = _csvnu.Last_Name,
                        employee_id = _csvnu.Employee_ID,
                        note = _csvnu.Notes,
                        email = _csvnu.Email_Address,
                        password = "123456789",
                        change_password = true,
                        phone_numbers = _csvpnlist
                    };

                    RestRequest postRequest = SerenityRequest.postReq(itemURI.pelco_rel_add_user);

                    postRequest.AddJsonBody(_nu);

                    IRestResponse postResponse = vuClient.Execute(postRequest);

                    if (postResponse.StatusCode == HttpStatusCode.Created)
                    {
                        success++;
                        reason = null;
                    }
                    else
                    {
                        failed++;
                        reason = "Failed to POST new user [" + _nu.name + "] because of: [" + postResponse.StatusCode.ToString() + "]";
                    }

                    progress++;

                    int percent = progress * 100 / _bgwUserAdd.Count;
                    bgwRequestHandler.ReportProgress(percent);

                }

            }


            else if (e.Argument is List<vxUser>)
            {
                if (isnewpassword)
                {
                    List<vxUser> _bgwUser = e.Argument as List<vxUser>;

                    foreach (vxUser u in _bgwUser)
                    {
                        if (bgwRequestHandler.CancellationPending == true)
                        {
                            e.Cancel = true;
                            return;
                        }

                        itemURI = u._links;


                        RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                        RestRequest rstRequest = SerenityRequest.postReq(itemURI.pelco_rel_new_password);
                        rstRequest.AddJsonBody(newpassword);

                        IRestResponse rstResponse = vuClient.Execute(rstRequest);

                        if (rstResponse.StatusCode == HttpStatusCode.NoContent)
                        {
                            success++;
                            reason = null;
                        }
                        else
                        {
                            failed++;
                            reason = "Failed to POST new password for [" + u.name + "] because of: [" + rstResponse.StatusCode.ToString() + "]";
                        }

                        progress++;

                        int percent = progress * 100 / _bgwUser.Count;
                        bgwRequestHandler.ReportProgress(percent);

                    }
                }

                else if (isaddremoverole)
                {
                    List<vxUser> _bgwUser = e.Argument as List<vxUser>;
                    RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);

                    foreach (vxUser u in _bgwUser)
                    {
                        if (bgwRequestHandler.CancellationPending == true)
                        {
                            e.Cancel = true;
                            return;
                        }

                        itemURI = u._links;

                        if (u.name == Properties.Settings.Default.vxAdmin)
                        {
                            failed++;
                            reason = u.name + " is current user, cannot be modified!";
                        }
                        else
                        {
                            RestRequest authRequest = SerenityRequest.getReq(itemURI.pelco_rel_auth, false);
                            IRestResponse<AuthLinks> authResponse = vuClient.Execute<AuthLinks>(authRequest);

                            itemURI = authResponse.Data._links;


                            RestRequest roleRequest = SerenityRequest.postReq(itemURI.pelco_rel_add_role);
                            roleRequest.AddJsonBody(arr);

                            IRestResponse roleResponse = vuClient.Execute(roleRequest);

                            if (roleResponse.StatusCode == HttpStatusCode.NoContent)
                            {
                                success++;
                                reason = null;
                            }
                            else
                            {
                                failed++;
                                reason = "Failed to POST new role for [" + u.name + "] because of: [" + roleResponse.StatusCode.ToString() + "]";
                            }

                        }
                        progress++;

                        int percent = progress * 100 / _bgwUser.Count;
                        bgwRequestHandler.ReportProgress(percent);
                    }
                }

                else if (isdelete)
                {
                    List<vxUser> _bgwUser = e.Argument as List<vxUser>;

                    foreach (vxUser u in _bgwUser)
                    {
                        if (bgwRequestHandler.CancellationPending == true)
                        {
                            e.Cancel = true;
                            return;
                        }

                        itemURI = u._links;

                        if (u.name == Properties.Settings.Default.vxAdmin)
                        {
                            failed++;
                            reason = u.name + " is current user, cannot perform DELETE!";
                        }
                        else
                        {
                            RestClient vuClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                            RestRequest delRequest = SerenityRequest.deleteReq(itemURI.edit);
                            IRestResponse delResponse = vuClient.Execute(delRequest);

                            if (delResponse.StatusCode == HttpStatusCode.NoContent)
                            {
                                success++;
                                reason = null;
                            }
                            else
                            {
                                failed++;
                                reason = u.name + " failed to DELETE: [" + delResponse.StatusCode.ToString() + "]";
                            }
                        }

                        progress++;

                        int percent = progress * 100 / _bgwUser.Count;
                        bgwRequestHandler.ReportProgress(percent);

                    }
                }
            }
        }    

        private void bgwRequestHandler_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblProgressDescription.Text = success.ToString() + " items succeeded, " + failed.ToString() + " items failed.";
            if (reason != null)
            {
                lstFailedReasons.Items.Add(reason);
            }
        }

        private void bgwRequestHandler_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblCurrentStatus.Text = "Operation was manually cancelled.";
            }
            else if (e.Error != null)
            {
                lblCurrentStatus.Text = "Error during operation: " + e.Error.Message;
            }
            else
            {
                lblCurrentStatus.Text = "Operation complete.";
                btnCancelOperation.Enabled = false;
                btnClose.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelOperation_Click(object sender, EventArgs e)
        {
            if (bgwRequestHandler.IsBusy == true)
            {
                bgwRequestHandler.CancelAsync();
            }
        }

    }
}
