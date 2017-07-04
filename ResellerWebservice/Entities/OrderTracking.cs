using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "ResellerTracking")]
    public class OrderTracking
    {
        [DataMember]
        public string Vendor { get; set; }
        [DataMember]
        public string SKU { get; set; }
        [DataMember]
        public int Qty { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public DateTime? CurrentForecast { get; set; }
        [DataMember]
        public string Remarks { get; set; }
        [DataMember]
        public string StatusExpediteComstor { get; set; }
        [DataMember]
        public DateTime? OrderApprovalDate { get; set; }
        [DataMember]
        public string SkuSource { get; set; }
        [DataMember]
        public DateTime? CiscoOriginalForecast { get; set; }
        [DataMember]
        public DateTime? CiscoOrderApprovalDate { get; set; }
        [DataMember]
        public DateTime? CurrentBrazilianForecast { get; set; }
        [DataMember]
        public DateTime? BrazilianDate { get; set; }
        [DataMember]
        public string ParametrizCanal { get; set; }
        [DataMember]
        public string Source { get; set; }
        [DataMember]
        public DateTime? CustomCurrentForecast { get; set; }
    }
}