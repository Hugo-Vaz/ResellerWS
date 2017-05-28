using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "Quote")]
    public class Quote
    {
        [DataMember]
        public QuoteLine[] QuoteLines { get; set; }
        [DataMember]
        public string Remarks { get; set; }
        [DataMember]
        public string Details { get; set; }
        [DataMember]
        public bool FatorMapeado { get; set; }
        [DataMember]
        public string QuoteId { get; set; }
    }
}