﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "User")]
    public class User
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public bool IsBlocked { get; set; }      
        [DataMember]
        public string Cellphone { get; set; }
        [DataMember]
        public string UniqueIdentifier { get; set; }
        [DataMember]
        public string AccountManagerCode { get; set; }
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public int CodERP { get; set; }


    }
}