using System.Collections.Generic;

namespace VxCameraAuditor3
{
    public class ResourceQuery
    {
        public List<vxResource> resources { get; set; }
        public CollectionHeader3 collection_header { get; set; }
        public string _type { get; set; }
    }

    public class vxResource
    {
        public string _type { get; set; }
        public relLinks _links { get; set; }
        public string id { get; set; }
        public string ip { get; set; }
        public string name { get; set; }
        public int number { get; set; }
        public string state { get; set; }
        public string type { get; set; }
        public List<vxDataInterface> data_interfaces { get; set; }
        public bool capturing { get; set; }
        public bool recording { get; set; }
        public bool live { get; set; }
        public bool recorded { get; set; }
        public string _system_id { get; set; }
        public string _last_modified { get; set; }
    }

    public class postRescRef
    {
        public string _type = "Resource.ResourceRefs";
        public List<ResourceRef> value { get; set; }
    }

    public class ResourceRef
    {
        public string _type { get; set; }
        public string id { get; set; }
        public string type { get; set; }
    }

}
