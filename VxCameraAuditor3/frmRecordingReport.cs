using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using FileHelpers;

namespace VxCameraAuditor3
{
    public partial class frmRecordingReport : Form
    {

        List<vxDataSource> dsRecReport = new List<vxDataSource>();
        List<RetentionReport> RetentionLists = new List<RetentionReport>();

        int success = 0;
        int failed = 0;
        int progress = 0;

        private string reason { get; set; }

        public frmRecordingReport(List<vxDataSource> _datasources)
        {
            InitializeComponent();
            dsRecReport = _datasources;
            btnClose.Enabled = false;
            btnCancelReport.Enabled = true;
            bgwReportGen.RunWorkerAsync(dsRecReport);
        }

        private void bgwReportGen_DoWork(object sender, DoWorkEventArgs e)
        {

            List<vxDataSource> _dsToReport = e.Argument as List<vxDataSource>;

            foreach (vxDataSource d in _dsToReport)
            {
                if (bgwReportGen.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }

                RetentionReport camreport = new RetentionReport();

                List<DateTime> start_time = new List<DateTime>();
                List<DateTime> end_time = new List<DateTime>();

                RestClient clipClient = new RestClient("https://" + Properties.Settings.Default.vxCore);
                RestRequest reqClips = SerenityRequest.getReq(d._links.pelco_rel_clips, false);

                IRestResponse<ClipQuery> dataSrcClipsResp = clipClient.Execute<ClipQuery>(reqClips);

                if (dataSrcClipsResp.StatusCode == HttpStatusCode.OK)
                {
                    success++;
                    reason = null;

                    ClipQuery cq = dataSrcClipsResp.Data;

                    List<Clips> selectedcamclips = cq.clips;
                    int clipcounter = 0;

                    foreach (Clips c in selectedcamclips)
                    {
                        DateTime startlocal = DateTime.Parse(c.start_time);
                        DateTime endlocal = DateTime.Parse(c.end_time);

                        start_time.Add(startlocal.ToLocalTime());
                        end_time.Add(endlocal.ToLocalTime());
                        clipcounter++;
                    }

                    start_time.Sort();
                    end_time.Sort();

                    camreport.Cam_Name = d.name;
                    camreport.Cam_Number = d.number;
                    camreport.IP_Address = d.ip;
                    camreport.Cam_Status = d.state;

                    if (start_time.Count > 0)
                    {
                        camreport.Earliest_Video = start_time[0].ToString();
                        camreport.Latest_Video = end_time[end_time.Count - 1].ToString();

                        TimeSpan retention = end_time[end_time.Count - 1] - start_time[0];

                        camreport.Retention_Days = string.Format("{0:%d}", retention);
                        camreport.Retention_Hours = string.Format("{0:%h}", retention);
                        camreport.Retention_Minutes = string.Format("{0:%m}", retention);

                        if (clipcounter <= 1)
                        {
                            camreport.Total_Gaps = 0;
                        }
                        else
                        {
                            camreport.Total_Gaps = (clipcounter - 1);
                        }
                    }
                    else
                    {
                        camreport.Earliest_Video = "(No Recording)";
                        camreport.Latest_Video = "(No Recording)";
                        camreport.Total_Gaps = 0;
                        camreport.Retention_Days = "0";
                        camreport.Retention_Hours = "0";
                        camreport.Retention_Minutes = "0";
                    }

                    RetentionLists.Add(camreport);

                }

                else
                {
                    failed++;
                    reason = "Failed to create report for " + d.name + ": [" + dataSrcClipsResp.StatusDescription.ToString() + "]";
                    lstErrors.Items.Add(reason);
                }
                progress++;

                int percent = progress * 100 / _dsToReport.Count;

                olvRecReport.SetObjects(RetentionLists);
                bgwReportGen.ReportProgress(percent);
            }

        }

        private void bgwReportGen_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgReport.Value = e.ProgressPercentage;
            lblProgressText.Text = success.ToString() + " items succeeded, " + failed.ToString() + " items failed.";
        }

        private void bgwReportGen_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblProgressText.Text = "Operation was manually cancelled.";
            }
            else if (e.Error != null)
            {
                lblProgressText.Text = "Error during operation: " + e.Error.Message;
            }
            else
            {
                lblProgressText.Text = "Report Generation Complete.";
                btnCancelReport.Enabled = false;
                btnClose.Enabled = true;
            }
        }

        private void btnCancelReport_Click(object sender, EventArgs e)
        {
            if (bgwReportGen.IsBusy == true)
            {
                bgwReportGen.CancelAsync();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            saveVUFilesDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveVUFilesDialog.Filter = "Comma-Separated Values (*.csv)|*.csv";
            saveVUFilesDialog.RestoreDirectory = true;
            saveVUFilesDialog.ShowHelp = true;

            if (saveVUFilesDialog.ShowDialog() == DialogResult.OK)
            {
                var csvwriter = new FileHelperEngine<RetentionReport>();

                csvwriter.HeaderText = csvwriter.GetFileHeader();
                csvwriter.WriteFile(saveVUFilesDialog.FileName, RetentionLists);

                MessageBox.Show("CSV File created in:\n" + saveVUFilesDialog.FileName, "Export CSV Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
