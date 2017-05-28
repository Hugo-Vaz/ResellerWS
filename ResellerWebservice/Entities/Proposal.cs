using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "Proposal")]
    public class Proposal
    {
        [DataMember]
        public String CodForecast { get; set; }
        [DataMember]
        public Int32 ProposalId { get; set; }
        [DataMember]
        public Int32 OrderCode { get; set; }
        [DataMember]
        public Int32 Version { get; set; }
        [DataMember]
        public DateTime ExpiryDate { get; set; }
        [DataMember]
        public DateTime ProposalDate { get; set; }
        [DataMember]
        public decimal ICMS { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal ComissionValue { get; set; }
        [DataMember]
        public decimal DollarValue { get; set; }
        [DataMember]
        public decimal TotalWithoutComission { get; }
        [DataMember]
        public decimal TotalWitoutICMS { get; set; }
        [DataMember]
        public decimal TotalWithoutTaxes { get; set; }
        [DataMember]
        public decimal NetAmount{ get; set; }
        [DataMember]
        public decimal SalesTaxesRate{ get; set; }
       
        [DataMember]
        public ProposalOption[] Options { get; set; }
    }
}