using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ResellerWebservice.Entities
{
    public class ProposalRequest
    {
        [DataMember]
        public string ClientCNPJ { get; set; }
        [DataMember]
        public int ClientClass { get; set; }
        [DataMember]
        public string Order { get; set; }
        [DataMember]
        public string DeliveryCNPJ { get; set; }
        [DataMember]
        public string Remarks { get; set; }
        [DataMember]
        public  bool InHold{ get; set; }
        [DataMember]
        public bool DirectInvoice { get; set; }
        [DataMember]
        public string EndUserCNPJ { get; set; }     
    }
}