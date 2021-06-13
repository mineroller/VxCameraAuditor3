using System.Collections.Generic;

namespace VxCameraAuditor3
{

    public class DataSourceQuery
    {
        public CollectionHeader3 collection_header { get; set; }
        public List<vxDataSource> data_sources { get; set; }
        public string _type { get; set; }
    }
    public class vxDataSource
    {
        public string _type { get; set; }
        public relLinks _links { get; set; }
        public string id { get; set; }
        public string ip { get; set; }
        public string name { get; set; }
        public int number { get; set; }
        public string state { get; set; }
        public string type { get; set; }
        public Embedded _embedded { get; set; }
        public List<DataInterface> data_interfaces { get; set; }
        public bool capturing { get; set; }
        public bool recording { get; set; }
        public bool live { get; set; }
        public bool recorded { get; set; }
        public string _system_id { get; set; }
        public string _last_modified { get; set; }
    }

    public class DataInterface
    {
        public string _type { get; set; }
        public relLinks _links { get; set; }
        public string endpoint { get; set; }
        public string protocol { get; set; }
        public bool multicast { get; set; }
    }

}

