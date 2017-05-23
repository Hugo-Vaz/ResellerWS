using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "Stock")]
    public class Stock
    {
        [DataMember]
        public string Descricao { get; set; }
        [DataMember]
        public decimal ICMS { get; set; }      
        [DataMember]
        public Int32 LocalStock { get; set; }
        [DataMember]
        public String NCM { get; set; }
        [DataMember]
        public String Partnumber { get; set; }
        [DataMember]
        public decimal ResellerPrice { get; set; }      
        [DataMember]
        public Int32 TransitStock { get; set; }       
        [DataMember]
        public decimal IPI { get; set; } 
        [DataMember]
        public Int32 Type { get; set; }
        [DataMember]
        public decimal FatorVenda { get; set; }
        [DataMember]
        public String FatorVendaCodigo { get; set; }
        [DataMember]
        public decimal NetPrice { get; set; }      
        [DataMember]
        public String CodVendor { get; set; }
        [DataMember]
        public String Fabricante { get; set; }
        [DataMember]
        public decimal Promo { get; set; }
    }
}