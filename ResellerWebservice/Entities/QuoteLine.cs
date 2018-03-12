using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "QuoteLine")]
    public class QuoteLine
    {
        [DataMember]
        public string SKU { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Boolean IsActive { get; set; }
        [DataMember]
        public Int32 Type { get; set; }
        [DataMember]
        public string NCM { get; set; }
        [DataMember]
        public String VendorCode { get; set; }
        [DataMember]
        public String Vendor { get; set; }
        [DataMember]
        public decimal VendorDiscout { get; set; }
        [DataMember]
        public decimal VendorDollar { get; set; }
        [DataMember]
        public string Currency { get; set; }
        [DataMember]
        public decimal Discount { get; set; }
        [DataMember]
        public decimal Increase { get; set; }
        [DataMember]
        public decimal SBA { get; set; }
        [DataMember]
        public string RegionCode { get; set; }
        [DataMember]
        public decimal FatorDeVenda { get; set; }
        [DataMember]
        public string FatorDeVendaCode { get; set; }
        [DataMember]
        public decimal ListPrice { get; set; }
        [DataMember]
        public decimal ResellerPrice { get; set; }
        [DataMember]
        public decimal ResellerPriceWithUplift { get; set; }
        [DataMember]
        public decimal GplPrice { get; set; }
        [DataMember]
        public decimal FOBPrice { get; set; }
        [DataMember]
        public decimal ICMS { get; set; }
        [DataMember]
        public decimal IPI { get; set; }
        [DataMember]
        public decimal ICMSSTListPrice { get; set; }
        [DataMember]
        public decimal ICMSSTResellerPrice  { get; set; }
        [DataMember]
        public decimal ICMSSTResellerPriceWithUplift { get; set; }
        [DataMember]
        public int Qty { get; set; }
        [DataMember]
        public int MinQty { get; set; }
    }
}