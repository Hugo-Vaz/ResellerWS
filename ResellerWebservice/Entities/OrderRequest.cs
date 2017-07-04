using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ResellerWebservice.Entities
{
    public class OrderRequest
    {
        [DataMember]
        public string CustomerCompanyCode { get; set; }
        [DataMember]
        public int CustomerClass { get; set; }
        [DataMember]
        public string Order { get; set; }
        [DataMember]
        public string DeliveryCompanyCode { get; set; }
        [DataMember]
        public string Remarks { get; set; }
        [DataMember]
        public  bool InHold{ get; set; }
        [DataMember]
        public bool DirectInvoice { get; set; }
        [DataMember]
        public string EndUserCompanyCode { get; set; }
    }
}