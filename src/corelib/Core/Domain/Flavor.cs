using System.Runtime.Serialization;

namespace net.openstack.Core.Domain
{
    [DataContract]
    public class Flavor
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public Link[] Links { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}