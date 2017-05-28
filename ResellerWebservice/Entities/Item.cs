using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "Item")]
    public class Item
    {
        [DataMember]
        public string SKU { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public decimal Uplift{ get; set; }
        [DataMember]
        public decimal NetPrice { get; set; }
        [DataMember]
        public decimal PurchasePrice { get; set; }
        [DataMember]
        public decimal Discount { get; set; }
    }
}