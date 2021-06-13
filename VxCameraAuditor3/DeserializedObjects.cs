using RestSharp.Deserializers;
using System.Collections.Generic;

/// <summary>
/// DeserialzedObjects: Some of the common objects across different Serenity Resources, 
/// as well as custom object types used for various query and POST operations.
/// </summary>
namespace VxCameraAuditor3
{

    public class CollectionHeader3
    {        
        public int start_index { get; set; }
        public int total_items { get; set; }
        public NextPrevLinks _links { get; set; }
        public string _type { get; set; }
    }


    public class NextPrevLinks
    {
        public string next { get; set; }
        public string prev { get; set; }
    }

    public class Embedded
    {
        [DeserializeAs(Name = "/pelco/rel/data_storages")]
        public RecorderQuery pelco_rel_data_storages { get; set; }
        [DeserializeAs(Name = "/pelco/rel/device")]
        public vxDevice pelco_rel_device { get; set; }
        [DeserializeAs(Name = "/pelco/rel/data_storage")]
        public vxRecorder pelco_rel_data_storage { get; set; }
        [DeserializeAs(Name = "/pelco/rel/data_sources")]
        public DataSourceQuery pelco_rel_data_sources { get; set; }
        [DeserializeAs(Name = "/pelco/rel/users")]
        public UserQuery pelco_rel_users { get; set; }
        [DeserializeAs(Name = "/pelco/rel/privileges")]
        public PrivilegeQuery pelco_rel_privileges { get; set; }
        [DeserializeAs(Name = "/pelco/rel/roles")]
        public RoleQuery pelco_rel_roles { get; set; }
        [DeserializeAs(Name = "/pelco/rel/clips")]
        public ClipQuery pelco_rel_clips { get; set; }
    }


    public class relLinks
    {
        public string self { get; set; }
        public string edit { get; set; }
        [DeserializeAs(Name = "/pelco/rel/endpoint")]
        public string pelco_rel_endpoint { get; set; }
        [DeserializeAs(Name = "/pelco/rel/delete")]
        public string pelco_rel_delete { get; set; }
        [DeserializeAs(Name = "/pelco/rel/data_sources")]
        public string pelco_rel_data_sources { get; set; }
        [DeserializeAs(Name = "/pelco/rel/assignments")]
        public string pelco_rel_assignments { get; set; }
        [DeserializeAs(Name = "/pelco/rel/add_device")]
        public string pelco_rel_add_device { get; set; }
        [DeserializeAs(Name = "/pelco/rel/auto_add_devices")]
        public string pelco_rel_auto_add_devices { get; set; }
        [DeserializeAs(Name = "/pelco/rel/clips")]
        public string pelco_rel_clips { get; set; }
        [DeserializeAs(Name = "/pelco/rel/data_storages")]
        public string pelco_rel_data_storages { get; set; }
        [DeserializeAs(Name = "/pelco/rel/snapshot")]
        public string pelco_rel_snapshot { get; set; }
        [DeserializeAs(Name = "/pelco/rel/snapshots")]
        public string pelco_rel_snapshots { get; set; }
        [DeserializeAs(Name = "/pelco/rel/device")]
        public string pelco_rel_device { get; set; }
        [DeserializeAs(Name = "/pelco/rel/devices")]
        public string pelco_rel_devices { get; set; }
        [DeserializeAs(Name = "/pelco/rel/ptz_controller")]
        public string pelco_rel_ptz_controller { get; set; }
        [DeserializeAs(Name = "/pelco/rel/link")]
        public string pelco_rel_link { get; set; }
        [DeserializeAs(Name = "/pelco/rel/unlink")]
        public string pelco_rel_unlink { get; set; }
        [DeserializeAs(Name = "/pelco/rel/merge")]
        public string pelco_rel_merge { get; set; }
        [DeserializeAs(Name = "/pelco/rel/resources")]
        public string pelco_rel_resources { get; set; }
        [DeserializeAs(Name = "/pelco/rel/add_tag")]
        public string pelco_rel_add_tag { get; set; }
        [DeserializeAs(Name = "/pelco/rel/account")]
        public string pelco_rel_account { get; set; }
        [DeserializeAs(Name = "/pelco/rel/auth")]
        public string pelco_rel_auth { get; set; }
        [DeserializeAs(Name = "/pelco/rel/data_objects")]
        public string pelco_rel_data_objects { get; set; }
        [DeserializeAs(Name = "/pelco/rel/new_password")]
        public string pelco_rel_new_password { get; set; }
        [DeserializeAs(Name = "/pelco/rel/roles")]
        public string pelco_rel_roles { get; set; }
        [DeserializeAs(Name = "/pelco/rel/tags")]
        public string pelco_rel_tags { get; set; }
        [DeserializeAs(Name = "/pelco/rel/add_user")]
        public string pelco_rel_add_user { get; set; }
        [DeserializeAs(Name = "/pelco/rel/assign")]
        public string pelco_rel_assign { get; set; }
        [DeserializeAs(Name = "/pelco/rel/drivers")]
        public string pelco_rel_drivers { get; set; }
        [DeserializeAs(Name = "/pelco/rel/unassign")]
        public string pelco_rel_unassign { get; set; }
        [DeserializeAs(Name = "/pelco/rel/add_public_data")]
        public string pelco_rel_add_public_data { get; set; }
        [DeserializeAs(Name = "/pelco/rel/add_private_data")]
        public string pelco_rel_add_private_data { get; set; }
        [DeserializeAs(Name = "/pelco/rel/user")]
        public string pelco_rel_user { get; set; }
        [DeserializeAs(Name = "/pelco/rel/users")]
        public string pelco_rel_users { get; set; }
        [DeserializeAs(Name = "/pelco/rel/events")]
        public string pelco_rel_events { get; set; }
        [DeserializeAs(Name = "/pelco/rel/add_role")]
        public string pelco_rel_add_role { get; set; }
        [DeserializeAs(Name = "/pelco/rel/remove_role")]
        public string pelco_rel_remove_role { get; set; }
        [DeserializeAs(Name = "/pelco/rel/members")]
        public string pelco_rel_members { get; set; }
        [DeserializeAs(Name = "/pelco/rel/diagnostic")]
        public string pelco_rel_diagnostic { get; set; }
        [DeserializeAs(Name = "/pelco/rel/configuration")]
        public string pelco_rel_configuration { get; set; }
        [DeserializeAs(Name = "/pelco/rel/logs")]
        public string pelco_rel_logs { get; set; }
        [DeserializeAs(Name = "/pelco/rel/vxs")]
        public string pelco_rel_vxs { get; set; }
        [DeserializeAs(Name = "/pelco/rel/time")]
        public string pelco_rel_time { get; set; }
        [DeserializeAs(Name = "/pelco/rel/ldap")]
        public string pelco_rel_ldap { get; set; }
        [DeserializeAs(Name = "/pelco/rel/volumes")]
        public string pelco_rel_volumes { get; set; }
        [DeserializeAs(Name = "pelco/rel/add_volume")]
        public string pelco_rel_add_volume { get; set; }

    }


    public class SystemQuery
    {
        public string _type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public relLinks _links { get; set; }
    }

    public class Versions
    {
        public string current_version { get; set; }
        public List<string> supported_versions { get; set; }
        public string _type { get; set; }
    }

    public class MemberQuery
    {
        public CollectionHeader3 collection_header { get; set; }
        public relLinks _links { get; set; }
        public List<AggMember> members { get; set; }
        public string _type { get; set; }
    }

    public class AggMember
    {
        public string _type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int port { get; set; }
        public string host { get; set; }
        public string state { get; set; }
        public string username { get; set; }
        public relLinks _links { get; set; }
        public int bandwidth { get; set; }
    }

    public class postRename
    {
        public string name { get; set; }
    }

    public class postEditDS
    {
        public string name { get; set; }
        public int number { get; set; }
    }

    public class postMerge
    {
        public string value { get; set; }
    }

    public class TagAdd
    {
        public string _type { get; set; }
        public string name { get; set; }
    }

}
