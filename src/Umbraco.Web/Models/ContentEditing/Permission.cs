using System.Runtime.Serialization;

namespace Umbraco.Web.Models.ContentEditing
{
    [DataContract(Name = "permission", Namespace = "")]
    public class Permission
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "checked")]
        public bool Checked { get; set; }

        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        /// <summary>
        /// We'll use this to map the categories but it wont' be returned in the json
        /// </summary>
        [IgnoreDataMember]
        internal string Category { get; set; }
    }
}