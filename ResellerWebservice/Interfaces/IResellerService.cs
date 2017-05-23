using ResellerWebservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ResellerWebservice.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IResellerService" in both code and config file together.
    [ServiceContract]
    public interface IResellerService
    {
        [OperationContract]
        Stock[] CheckStock(string[] partNumbers, int erp, bool activeOnly);

        [OperationContract]
        Response GenerateQuote(Item[] items, string from,string to, bool directInvoice, string endUserCode);

        [OperationContract]
        Response GenerateProposal(Item[] items, string from, string to, bool directInvoice, string endUserCode,bool sendEmail, string[] cc);

        [OperationContract]
        Company GetCompany(string companyCode);

        [OperationContract]
        Response CompanyInsert(Company company);

        [OperationContract]
        Location[] ListCountries();
        [OperationContract]
        Location[] ListStates(string countryCode);
        [OperationContract]
        Location[] ListCities(string stateCode);

        [OperationContract]
        Response();
    }
}
