using FileHelpers;

namespace VxCameraAuditor3
{
    [DelimitedRecord(","), IgnoreFirst(1)]
    public class DataSource_CSV
    {
        public int Camera_Number { get; set; }        
        public string Camera_Name { get; set; }
        public string IP_Address { get; set; }
        public string Device_GUID { get; set; }
    }

    [DelimitedRecord(","), IgnoreFirst(1)]
    public class Device_CSV
    {
        public string Device_Name { get; set; }
        public string Device_GUID { get; set; }
        public string IP_Address { get; set; }
        public string MAC_Address { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
        public string Serial { get; set; }
        public string Status { get; set; }
        public string Vendor { get; set; }
        public bool Commissioned { get; set; }  
    }

    public class MultipartSnapshots
    {
        public string timestamp { get; set; }
        public string content { get; set; }
        public byte[] imagedata { get; set; }
    }

    public class SerenityError
    {
        public string _type { get; set; }
        public string code { get; set; }
        public string field { get; set; }
        public string message { get; set; }
        public vxResource resource { get; set; }
    }

    [DelimitedRecord(",")]
    public class RetentionReport
    {
        public int Cam_Number { get; set; }
        public string Cam_Name { get; set; }
        public string IP_Address { get; set; }
        public string Cam_Status { get; set; }
        public string Earliest_Video { get; set; }
        public string Latest_Video { get; set; }
        public int Total_Gaps { get; set; }
        public string Retention_Days { get; set; }
        public string Retention_Hours { get; set; }
        public string Retention_Minutes { get; set; }
    }

    [DelimitedRecord(","), IgnoreFirst(1)]
    public class User_CSV
    {
        public string Username { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Employee_ID { get; set; }
        public string Work_Phone { get; set; }
        public string Email_Address { get; set; }
        public string Notes { get; set; }        
    }
        
}
