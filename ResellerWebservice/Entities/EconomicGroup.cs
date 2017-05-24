using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ResellerWebservice.Entities
{
    public class EconomicGroup
    {
        [DataMember]
        public int CodERP { get; set; }
        [DataMember]
        public string PaymentConditionERP { get; set; }
        [DataMember]
        public long CustomerID { get; set; }
        [DataMember]
        public Company[] Affiliates { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}