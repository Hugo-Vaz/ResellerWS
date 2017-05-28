using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "Option")]
    public class ProposalOption
    {
        [DataMember]
        public Item[] Items { get; set; }
        public String Name { get; set; }
        public decimal TotalWithoutTaxes { get; set; }
        public decimal NetValue { get; set; }
        public decimal TotalWithoutICMS { get; set; }
        public decimal DollarValue { get; set; }
        public bool ShowInBRL { get; set; }
    }
}