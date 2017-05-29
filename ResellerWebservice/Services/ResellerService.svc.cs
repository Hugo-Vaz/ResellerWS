using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ResellerWebservice.Entities;
using ResellerWebservice.Mappers;
using ResellerWebservice.Helpers;
using System.Data;

namespace ResellerWebservice.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ResellerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ResellerService.svc or ResellerService.svc.cs at the Solution Explorer and start debugging.
    public class ResellerService : IResellerService
    {
        public Stock[] CheckStock(User user, string[] partNumbers, int erp, bool activeOnly)
        {
            throw new NotImplementedException();
        }

        public Response CompanyInsert(User user, Company company)
        {
            UserValidator.CheckUser(user);
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
            List<ResellerWebservice.Contato> contatos = new List<ResellerWebservice.Contato>();

            ResellerWebservice.Company resp = CompanyMapper.ConvertInterfaceToWebservice(company,ref contatos);

            return CompanyMapper.ConvertWebserviceToInterface(resp.Company, null);
        }

        public Response GenerateProposal(User user, Item[] items, string from, string to, bool directInvoice, string endUserCode, bool sendEmail, string[] cc)
        {
            throw new NotImplementedException();
        }

        public Response GenerateQuote(User user, Item[] items, string from, string to, bool directInvoice, string endUserCode)
        {
            throw new NotImplementedException();
        }

        public Company GetCompany(User user, string companyCode,int codERP)
        {
            UserValidator.CheckUser(user);
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
            ResellerWebservice.CompanyResponse resp = webservice.Company_GetData(companyCode, codERP);

            return CompanyMapper.ConvertWebserviceToInterface(resp.Company, null);
        }

        public User IsUserValid(string login, string password)
        {
            try
            {
                ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
                ResellerWebservice.UserResponse resp = webservice.IsUserValid(login, password);

                return UserMapper.ConvertWebserviceToInterface(resp);

            }
            catch (Exception e)
            {
                FaultCode prionFaultCode = new FaultCode("101");
                throw new FaultException("User Error: " + e.Message, prionFaultCode);
            }
        }

        public Location[] ListCities(User user, string stateCode, string cityName)
        {
            UserValidator.CheckUser(user);
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
            DataTable dt = webservice.Applications_Cities(stateCode, cityName);

            return LocationMapper.ConvertDatatableToModel(dt);
        }

        public Location[] ListCountries(User user,string countryName)
        {
            UserValidator.CheckUser(user);
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
            DataTable dt = webservice.Applications_Countries(countryName);

            return LocationMapper.ConvertDatatableToModel(dt);
        }

        public Location[] ListStates(User user, string countryCode,string stateName)
        {
            UserValidator.CheckUser(user);
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
            DataTable dt = webservice.Applications_Cities(countryCode, stateName);

            return LocationMapper.ConvertDatatableToModel(dt);
        }
    }
}
