using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using RestSharp;

namespace VxCameraAuditor3
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }

    /// <summary>
    /// Some Text Related Tools for Settings 
    /// </summary>
    public static class VUStringHelper
    {

        /// Encodes string that can only be accessible from this machine

        public static string Encode(string text)
        {
            return Convert.ToBase64String(
                ProtectedData.Protect(
                    Encoding.Unicode.GetBytes(text), null, DataProtectionScope.LocalMachine));
        }

        /// Decodes the encrypted string, only accessible from this machine

        public static string Decode(string text)
        {
            return Encoding.Unicode.GetString(
                    ProtectedData.Unprotect(
                        Convert.FromBase64String(text), null, DataProtectionScope.LocalMachine));
        }

        public static string EncBase64(string text)
        {
            /// Grabs username and password from setting, decode it, and prepare for Base64 encoding
            byte[] _text2byte = Encoding.UTF8.GetBytes(text);
            string base64_text = Convert.ToBase64String(_text2byte);

            return base64_text;
        }

        /// IP Address Validator. From https://stackoverflow.com/a/29942932

        public static Boolean ValidateIP(string address)
        {
            /// Split string by ".", check that array length is 4
            string[] ipv4octets = address.Split('.');
            if (ipv4octets.Length != 4)
                return false;

            /// Check each substring checking that parses to byte
            byte obyte = 0;
            foreach (string singleOctet in ipv4octets)
                if (!byte.TryParse(singleOctet, out obyte))
                    return false;

            return true;
        }

        /// Vx Response Message Generator
        /// 
        public static string VxCoreSays(string restsharp_response)
        {
            DateTime now = DateTime.Now;
            string _friendlyMsg = "[" + now.ToString(@"dd\/MM\/yyyy HH:mm:ss") + "] VxCore Response: ";
            _friendlyMsg += restsharp_response;
            return _friendlyMsg;
        }

        // Multipart Header Boundary Detector

        public static string getBoundary(string multipart_header)
        {
            int _delimiter = multipart_header.IndexOf("=");
            string _boundary = multipart_header.Remove(0, _delimiter + 1);
            return _boundary;
        }

        public static DateTime getImageTime(string _imageTime)
        {
            int _delimiter = _imageTime.IndexOf(":");
            string _timeString = _imageTime.Remove(0, _delimiter + 1);

            DateTime _convTime = DateTime.Parse(_timeString).ToLocalTime();

            return _convTime;
        }

        // Find linebreaks in MixedJpeg response (Multipart/mixed)
        // Stackoverflow https://stackoverflow.com/a/332667

        public static List<int> IndexOfSequence(this byte[] buffer, byte[] pattern, int startIndex)
        {
            List<int> positions = new List<int>();
            int i = Array.IndexOf<byte>(buffer, pattern[0], startIndex);
            while (i >= 0 && i <= buffer.Length - pattern.Length)
            {
                byte[] segment = new byte[pattern.Length];
                Buffer.BlockCopy(buffer, i, segment, 0, pattern.Length);
                if (segment.SequenceEqual<byte>(pattern))
                    positions.Add(i);
                i = Array.IndexOf<byte>(buffer, pattern[0], i + pattern.Length);
            }
            return positions;
        }

    }

    /// <summary>
    /// Standard Serenity Request Headers
    /// </summary>
    public class SerenityRequest
    {
        public static RestRequest getReq(string uri, bool sort)
        {
            RestRequest req = new RestRequest(uri, Method.GET);

            /// Set Serenity Standard Headers
            req.AddHeader("X-Serenity-User", VUStringHelper.EncBase64(Properties.Settings.Default.vxAdmin));
            req.AddHeader("X-Serenity-Password", VUStringHelper.EncBase64(VUStringHelper.Decode(Properties.Settings.Default.vxPass)));
            req.AddHeader("Content-Type", "application/vnd.pelco.resource+json; version=5.1");
            req.AddHeader("User-Agent", "VxCameraAuditor3/1.0");
            req.AddHeader("Accept", "application/vnd.pelco.resource+json");
            req.AddHeader("Accept-Encoding", "gzip, deflate");
            if (sort)
            {
                req.AddParameter("sort", "name-asc");
            }
            return req;
        }

        public static RestRequest getJpegReq(string uri)
        {
            RestRequest req = new RestRequest(uri, Method.GET);

            /// Set Serenity Standard Headers
            req.AddHeader("X-Serenity-User", VUStringHelper.EncBase64(Properties.Settings.Default.vxAdmin));
            req.AddHeader("X-Serenity-Password", VUStringHelper.EncBase64(VUStringHelper.Decode(Properties.Settings.Default.vxPass)));
            req.AddHeader("Content-Type", "application/vnd.pelco.resource+json; version=5.1");
            req.AddHeader("User-Agent", "VxCameraAuditor3/1.0");
            req.AddHeader("Accept", "image/jpeg");
            req.AddHeader("Accept-Encoding", "gzip, deflate, br");

            return req;
        }

        public static RestRequest getSnapshotReq(string uri)
        {
            RestRequest req = new RestRequest(uri, Method.GET);

            /// Set Serenity Standard Headers
            req.AddHeader("X-Serenity-User", VUStringHelper.EncBase64(Properties.Settings.Default.vxAdmin));
            req.AddHeader("X-Serenity-Password", VUStringHelper.EncBase64(VUStringHelper.Decode(Properties.Settings.Default.vxPass)));
            req.AddHeader("Content-Type", "application/vnd.pelco.resource+json; version=5.1");
            req.AddHeader("User-Agent", "VxCameraAuditor3/1.0");
            req.AddHeader("Accept", "multipart/mixed");
            req.AddHeader("Accept-Encoding", "gzip, deflate, br");

            return req;
        }

        public static RestRequest deleteReq(string uri)
        {
            RestRequest req = new RestRequest(uri, Method.DELETE);

            req.AddHeader("X-Serenity-User", VUStringHelper.EncBase64(Properties.Settings.Default.vxAdmin));
            req.AddHeader("X-Serenity-Password", VUStringHelper.EncBase64(VUStringHelper.Decode(Properties.Settings.Default.vxPass)));
            req.AddHeader("Content-Type", "application/vnd.pelco.resource+json; version=5.1");
            req.AddHeader("User-Agent", "VxCameraAuditor3/1.0");
            req.AddHeader("Accept", "application/vnd.pelco.resource+json");
            req.AddHeader("Accept-Encoding", "gzip, deflate");

            return req;
        }

        public static RestRequest postReq(string uri)
        {

            RestRequest req = new RestRequest(uri, Method.POST);

            req.AddHeader("X-Serenity-User", VUStringHelper.EncBase64(Properties.Settings.Default.vxAdmin));
            req.AddHeader("X-Serenity-Password", VUStringHelper.EncBase64(VUStringHelper.Decode(Properties.Settings.Default.vxPass)));
            req.AddHeader("Content-Type", "application/vnd.pelco.resource+json; version=5.1");
            req.AddHeader("User-Agent", "VxCameraAuditor3/1.0");
            req.AddHeader("Accept", "application/vnd.pelco.resource+json");
            req.AddHeader("Accept-Encoding", "gzip, deflate");

            req.RequestFormat = DataFormat.Json;           
            return req;
        }
        public static RestRequest patchReq(string uri)
        {

            RestRequest req = new RestRequest(uri, Method.PATCH);

            req.AddHeader("X-Serenity-User", VUStringHelper.EncBase64(Properties.Settings.Default.vxAdmin));
            req.AddHeader("X-Serenity-Password", VUStringHelper.EncBase64(VUStringHelper.Decode(Properties.Settings.Default.vxPass)));
            req.AddHeader("Content-Type", "application/vnd.pelco.patch+json; version=5.1");
            req.AddHeader("User-Agent", "VxCameraAuditor3/1.0");
            req.AddHeader("Accept", "application/vnd.pelco.resource+json");
            req.AddHeader("Accept-Encoding", "gzip, deflate");

            req.RequestFormat = DataFormat.Json;            
            return req;
        }

        public static RestRequest vxsGetReq(string uri, string ver)
        {

            RestRequest req = new RestRequest(uri, Method.GET);

            req.AddHeader("X-Serenity-User", VUStringHelper.EncBase64(Properties.Settings.Default.vxsUser));
            req.AddHeader("X-Serenity-Password", VUStringHelper.EncBase64(VUStringHelper.Decode(Properties.Settings.Default.vxsPass)));
            req.AddHeader("Content-Type", "application/vnd.pelco.resource+json; version=5.1");
            req.AddHeader("User-Agent", "VxCameraAuditor3/1.0");
            req.AddHeader("Accept", "application/vnd.pelco.resource+json;version=" + ver);
            req.AddHeader("Accept-Encoding", "gzip, deflate");

            req.RequestFormat = DataFormat.Json;            
            return req;
        }

    }

    /// <summary>
    /// Resource List Comparer
    /// StackOverflow https://stackoverflow.com/a/16825050/6275179
    /// </summary>

    class vxResouceComparer : IEqualityComparer<vxResource>
    {
        public bool Equals(vxResource r1, vxResource r2)
        {
            return r1.name == r2.name;
        }

        public int GetHashCode(vxResource r)
        {
            unchecked
            {
                if (r == null)
                    return 0;
                int hashCode = r.name.GetHashCode();
                hashCode = (hashCode * 397) ^ r.name.GetHashCode();
                return hashCode;
            }
        }
    }

    public enum PostRescRef_Type
    {
        TagLink,
        TagUnlink,
    }

    public enum DataSrcSearch_Type
    {
        General,
        Advanced,
        Offline,
        Online,
        Recording,
        NotRecording,
        DataStorage,
        AllTags        
    }

    public enum DeviceSearch_Type
    {
        General,
        Advanced,
        Offline,
        NotCommissioned,
        Recorder,
        Type
    }

    public enum RoleSearch_Type
    {
        Users,
        Privileges,
        None
    }

    public enum ConsoleWindow_Status
    {
        Normal,
        Warning,
        Error
    }

}
