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
    public class Contact
    {
        [DataMember]
        public long ContactId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public bool ReceiveFinancialInfo { get; set; }
        [DataMember]
        public bool ReceiveNFe { get; set; }
        [DataMember]
        public bool ReceiveNFeXML { get; set; }
    }
}