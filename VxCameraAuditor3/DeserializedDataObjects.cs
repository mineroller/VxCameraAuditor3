using System.Collections.Generic;

namespace VxCameraAuditor3
{
    public class DataObjectQuery
    {
        public CollectionHeader3 collection_header { get; set; }
        public List<DataObject> data_objects { get; set; }
        public relLinks _links { get; set; }
        public string _type { get; set; }
    }

    public class DataObject
    {
        public string _type { get; set; }
        public string client_type { get; set; }
        public string data { get; set; }
        public string id { get; set; }
        public string owner { get; set; }
        public relLinks _links { get; set; }
    }

    public class CommonHeader
    {
        public string data_type { get; set; }
        public string version { get; set; }
    }

    public class patchDataObject
    {
        public string data { get; set; }
    }

}
