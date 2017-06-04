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
        Stock[] CheckStock(User user, string[] partNumbers, int erp, bool activeOnly);

        [OperationContract]
        Quote GenerateQuote(User user, Item[] items, string from, string billToCNPJ);

        [OperationContract]
        Response GenerateProposal(User user, Item[] items, ProposalRequest proposalData);

        [OperationContract]
        Company GetCompany(User user, string companyCode, int codERP);

        [OperationContract]
        Response CompanyInsert(User user, Company company);

        [OperationContract]
        Location[] ListCountries(User user,string countryName);
        [OperationContract]
        Location[] ListStates(User user, string countryCode,string stateName);
        [OperationContract]
        Location[] ListCities(User user, string stateCode,string cityName);

        [OperationContract]
        User IsUserValid(string login, string password);
    }
}
