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
        Response ApproveHold(User user, string order);

        [OperationContract]
        Stock[] CheckStock(User user, string[] partNumbers, bool activeOnly);

        //[OperationContract]
        //Quote GetQuote(User user, Item[] items, string from, string billToCompanyCode);

        [OperationContract]
        Order CreateOrder(User user, Item[] items, OrderRequest proposalData);

        [OperationContract]
        Company GetCompany(User user, string companyCode);

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

        [OperationContract]
        OrderTracking[] OrderTracking(string billToCompanyCode, string orderNumber);
    }
}
