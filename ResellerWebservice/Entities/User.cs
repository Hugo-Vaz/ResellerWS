using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ResellerWebservice.Entities
{
    public class User
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public bool IsBlocked { get; set; }
        [DataMember]
        public string Cellphone { get; set; }
        [DataMember]
        public string UniqueIdentifier { get; set; }
        [DataMember]
        public string VendorCode { get; set; }
        [DataMember]
        public string CustomerID { get; set; }
        [DataMember]
        public EconomicGroup EconomicGroup { get; set; }
        [DataMember]
        public Company Company { get; set; }

    }
}