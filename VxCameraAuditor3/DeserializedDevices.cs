using System.Collections.Generic;

namespace VxCameraAuditor3
{
    public class DeviceQuery
    {
        public string _type { get; set; }
        public List<vxDevice> devices { get; set; }
        public CollectionHeader3 collection_header { get; set; }
        public relLinks _links { get; set; }
    }

    public class vxDevice
    {
        public string _type { get; set; }
        public relLinks _links { get; set; }
        public string _system_id { get; set; }
        public bool commissioned { get; set; }
        public string ddid { get; set; }
        public string driver_data { get; set; }
        public string driver_type { get; set; }
        public string id { get; set; }
        public string ip { get; set; }
        public Embedded _embedded { get; set; }
        public bool license_required { get; set; }
        public string model { get; set; }
        public string name { get; set; }        
        public string password_key { get; set; }
        public string serial { get; set; }
        public string state { get; set; }
        public string type { get; set; }
        public string version { get; set; }        
        public string vip { get; set; }
        public string _last_modified { get; set; }
        public string username { get; set; }
        public string vendor { get; set; }
    }

}
