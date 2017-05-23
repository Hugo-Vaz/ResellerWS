using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "Company")]
    public class Company
    {
        [DataMember]
        public long CompanyId { get; set; }
        [DataMember]
        public string AccountManager { get; set; }
        [DataMember]
        public string NomeFantasia { get; set; }
        [DataMember]
        public string RazaoSocial { get; set; }
        [DataMember]
        public string CNPJ { get; set; }
        [DataMember]
        public string InscricaoEstadual { get; set; }
        [DataMember]
        public string InscricaoMunicipal { get; set; }
        [DataMember]
        public string Telefone { get; set; }
        [DataMember]
        public string CustomerId { get; set; }
        [DataMember]
        public Address Address { get; set; }

        [DataMember]
        public Contact[] Contacts { get; set; }
    }
}