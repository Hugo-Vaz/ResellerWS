using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ResellerWebservice.Entities;

namespace ResellerWebservice.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ResellerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ResellerService.svc or ResellerService.svc.cs at the Solution Explorer and start debugging.
    public class ResellerService : IResellerService
    {
        public Stock[] CheckStock(string[] partNumbers, int erp, bool activeOnly)
        {
            throw new NotImplementedException();
        }

        public Response CompanyInsert(Company company)
        {
            throw new NotImplementedException();
        }

        public Response GenerateProposal(Item[] items, string from, string to, bool directInvoice, string endUserCode, bool sendEmail, string[] cc)
        {
            throw new NotImplementedException();
        }

        public Response GenerateQuote(Item[] items, string from, string to, bool directInvoice, string endUserCode)
        {
            throw new NotImplementedException();
        }

        public Company GetCompany(string companyCode)
        {
            throw new NotImplementedException();
        }

        public User IsUserValid(string login, string password)
        {
            throw new NotImplementedException();
        }

        public Location[] ListCities(string stateCode)
        {
            throw new NotImplementedException();
        }

        public Location[] ListCountries()
        {
            throw new NotImplementedException();
        }

        public Location[] ListStates(string countryCode)
        {
            throw new NotImplementedException();
        }
    }
}
