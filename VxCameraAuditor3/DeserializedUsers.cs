using System.Collections.Generic;
using RestSharp.Deserializers;

namespace VxCameraAuditor3
{
    public class RoleQuery
    {
        public CollectionHeader3 collection_header { get; set; }
        public List<vxRole> roles { get; set; }
        public relLinks _links { get; set; }
        public string _type { get; set; }
    }

    public class vxRole
    {
        public string _type { get; set; }
        public relLinks _links { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        [DeserializeAs(Name = "internal")]
        public bool @internal { get; set; }
        public Embedded _embedded { get; set; }
    }

    public class AddRemoveRole
    {
        public string _type { get; set; }
        public string value { get; set; }
    }

    public class UserQuery
    {
        public CollectionHeader3 collection_header { get; set; }
        public List<vxUser> users { get; set; }
        public relLinks _links { get; set; }
        public string _type { get; set; }
    }

    public class vxUser
    {
        public string _type { get; set; }
        public string _last_modified { get; set; }
        public string _system_id { get; set; }
        public relLinks _links { get; set; }
        public string id { get; set; }
        public string domain { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string employee_id { get; set; }
        public string note { get; set; }
        public string password_expiration { get; set; }
        public List<vxPhoneNumbers> phone_numbers { get; set; }
        public Embedded _embedded { get; set; }
    }

    public class vxPhoneNumbers
    {
        public string type { get; set; }
        public string number { get; set; }
    }

    public enum vxPhone_Type
    {
        home,
        home_fax,
        mobile,
        other,
        pager,
        work,
        work_fax
    }


    public class NewPassword
    {
        public string _type { get; set; }
        public string new_password { get; set; }
        public bool change_password { get; set; }
    }

    public class NewUser
    {
        public string _type { get; set; }
        public bool change_password { get; set; }
        public string name { get; set; }
        public string password { get; set; }                
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string employee_id { get; set; }
        public string note { get; set; }
        public List<vxPhoneNumbers> phone_numbers { get; set; }        
    }

    public class AuthLinks
    {
        public string _type { get; set; }
        public relLinks _links { get; set; }
    }

    public class PrivilegeQuery
    {
        public CollectionHeader3 collection_header { get; set; }
        public List<vxPrivilege> privileges { get; set; }
        public relLinks _links { get; set; }
        public string _type { get; set; }
    }

    public class vxPrivilege
    {
        public string _type { get; set; }
        public string id { get; set; }
        public string permission { get; set; }
        public int priority { get; set; }
        public bool restricted { get; set; }
        public relLinks _links { get; set; }
    }
}
