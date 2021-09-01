using System.Collections.Generic;
using RestSharp.Deserializers;

namespace VxCameraAuditor3
{
    public class RecorderQuery
    {
        public CollectionHeader3 collection_header { get; set; }
        public List<vxRecorder> data_storages { get; set; }
        public string _type { get; set; }
    }

    public class vxRecorder
    {
        public string _type { get; set; }
        public relLinks _links { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public bool failover { get; set; }
        public Embedded _embedded { get; set; }
        public string _last_modified { get; set; }

    }

    public class ClipQuery
    {
        public CollectionHeader3 collection_header { get; set; }
        public List<Clips> clips { get; set; }
        public string _type { get; set; }
    }

    public class Clips
    {
        public string _type { get; set; }
        public string data_source_id { get; set; }
        public string data_source_name { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        [DeserializeAs(Name = "event")]
        public string @event { get; set; }
        public string priority { get; set; }
        public string type { get; set; }
        public relLinks _links { get; set; }
    }

    public class vxsDiagnostic
    {
        public string _type { get; set; }
        public string _system_id { get; set; }
        public relLinks _links { get; set; }
        public Assignments assignments { get; set; }
        public List<Db> db { get; set; }
        public Events events { get; set; }
        // public List<object> hdd { get; set; }
        // public List<object> network { get; set; }
        public Retention retention { get; set; }
    }

    public class vxsConfig
    {
        public string _type { get; set; }
        public string _system_id { get; set; }
        public relLinks _links { get; set; }
        public bool failover_enabled { get; set; }
        public List<string> failover_group { get; set; }
        public List<string> failover_monitor { get; set; }
        public int retention_limit { get; set; }
        public string video_stream_source { get; set; }
        public string xcast { get; set; }
    }


    public class Assignments
    {
        public string _type { get; set; }
        public int bitrate { get; set; }
        public int data_sources { get; set; }
        public int max_bitrate { get; set; }
        public int max_data_sources { get; set; }
    }

    public class Db
    {
        public string _type { get; set; }
        public string id { get; set; }
        public string status { get; set; }
        public int status_progress { get; set; }
    }

    public class Events
    {
        public string _type { get; set; }
        public int event_rate { get; set; }
    }

    public class Retention
    {
        public string _type { get; set; }
        public int retention { get; set; }
    }

    public class Volumes
    {
        public string _type { get; set; }
        public relLinks _links { get; set; }
        public CollectionHeader3 collection_header { get; set; }
        public List<vxVolume> volumes { get; set; }
    }

    public class vxVolume
    {
        public string _type { get; set; }
        public string _last_modified { get; set; }
        public string _system_id { get; set; }
        public relLinks _links { get; set; }
        public Limits _limits { get; set; }
        public double buffer { get; set; }
        public string id { get; set; }
        public bool online { get; set; }
        public string path { get; set; }
        public bool reserve_bandwidth { get; set; }
        public int total { get; set; }
        public int used { get; set; }
    }

    public class Limits
    {
        public vxsBuffer buffer { get; set; }
    }

    public class vxsBuffer
    {
        public string _type { get; set; }
        public string field_name { get; set; }
        public double max { get; set; }
        public double min { get; set; }
    }


}
