using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "Location")]
    public class Location
    {
        [DataMember]
        public long LocationId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string WestconCode { get; set; }
        [DataMember]
        public string Code { get; set; }
    }
}