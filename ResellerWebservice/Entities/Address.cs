using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "Company")]
    public class Address
    {
        [DataMember]
        public long AddressId { get; set; }

        [DataMember]
        public string AddressLine { get; set; }

        [DataMember]
        public string Number { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public string Block { get; set; }
        [DataMember]
        public Location City { get; set; }

        [DataMember]
        public Location State { get; set; }

        [DataMember]
        public Location Country { get; set; }

    }
}