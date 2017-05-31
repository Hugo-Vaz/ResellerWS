using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace ResellerWebservice.Entities
{
    [DataContract(IsReference = true)]
    [XmlRoot(Namespace = "Generic", ElementName = "Response")]
    public class Response
    {
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public bool Success { get; set; }

        public Response() { }
        public Response(string message,bool success)
        {
            this.Message = message;
            this.Success = success;
        }
    }
}