using System.Collections.Generic;

namespace VxCameraAuditor3
{
    public class TagQuery
    {
        public string _type { get; set; }
        public List<vxTag> tags { get; set; }
        public CollectionHeader3 collection_header { get; set; }
        public relLinks _links { get; set; }
    }


    public class vxTag
    {
        public string _type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public relLinks _links { get; set; }
    }

}
