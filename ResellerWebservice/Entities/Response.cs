using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "Response")]
    public class Response
    {
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Success { get; set; }
    }
}