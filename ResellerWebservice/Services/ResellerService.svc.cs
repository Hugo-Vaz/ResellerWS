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
using ResellerWebservice.Interfaces;

namespace ResellerWebservice.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ResellerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ResellerService.svc or ResellerService.svc.cs at the Solution Explorer and start debugging.
    public class ResellerService : IResellerService
    {
        public Response ApproveHold(User user,string order)
        {
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
            ResellerWebservice.GenericResponse wsResp = webservice.ApproveHold(order);
            Response resp = new Response(wsResp.ErrorMessage, wsResp.Success);

            return resp;
        }

        public Stock[] CheckStock(User user, string[] partNumbers, bool activeOnly)
        {
            UserValidator.CheckUser(user);
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
            ResellerWebservice.Stock wsStock = webservice.CheckStock(partNumbers, user.CodERP);
            List<Stock> stocks = new List<Stock>();

            foreach(ResellerWebservice.StockItem s in wsStock.Items)
            {
                stocks.Add(StockMapper.ConvertWebserviceToInterface(s));
            }

            return stocks.ToArray();
        }

        public Response CompanyInsert(User user, Company company)
        {
            UserValidator.CheckUser(user);
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
            List<ResellerWebservice.Contato> contatos = new List<ResellerWebservice.Contato>();

            ResellerWebservice.Company wsCompany = CompanyMapper.ConvertInterfaceToWebservice(company,ref contatos);
            ResellerWebservice.Retorno ret = webservice.Company_Insert("ResellerAPI", "", wsCompany, "");
            Response resp = new Response(ret.Mensagem, ret.Sucesso);

            return resp;
        }

        public Order CreateOrder(User user, Item[] items,OrderRequest proposalData)
        {
            UserValidator.CheckUser(user);
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();

            string[][] partnumbers = new string[items.Length][];
            for (int i = 0, len = items.Length; i < len; i++)
            {
                partnumbers[i][0] = items[i].SKU;
                partnumbers[i][1] = items[i].Quantity.ToString();
                partnumbers[i][2] = items[i].Uplift.ToString();
            }
            ResellerWebservice.UserResponse wsUser = webservice.IsUserValid(user.Login, user.Password);
            ResellerWebservice.ProposalResponse resp;


            //resp = webservice.GenerateProposalGeneric(wsUser, partnumbers, proposalData.ClientCNPJ, proposalData.ClientClass, proposalData.Order, 
            //        proposalData.DeliveryCNPJ, proposalData.Remarks, proposalData.InHold, proposalData.EndUserCNPJ, proposalData.DirectInvoice);
            if (!proposalData.DirectInvoice)
            {
                resp = webservice.GenerateProposal(partnumbers, proposalData.CustomerCompanyCode, proposalData.CustomerClass, proposalData.Order, proposalData.DeliveryCompanyCode, proposalData.Remarks, proposalData.InHold);
            }else
            {
                resp = webservice.GenerateProposalDirectInvoice(partnumbers, proposalData.CustomerCompanyCode, proposalData.CustomerClass, proposalData.Order, proposalData.DeliveryCompanyCode, proposalData.Remarks, proposalData.InHold, proposalData.EndUserCompanyCode);
            }          
            

            return ProposalMapper.ConvertWebserviceToInterface(resp);
        }

        public Quote GetQuote(User user, Item[] items, string from,string billToCNPJ)
        {
            UserValidator.CheckUser(user);
            PartnerPortalWebservice.PartnerPortal pp = new PartnerPortalWebservice.PartnerPortal();
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();

            ResellerWebservice.UserResponse wsUser = webservice.IsUserValid(user.Login, user.Password);

            string[][] partnumbers = new string[items.Length][];
            for (int i = 0, len = items.Length; i < len; i++)
            {
                partnumbers[i][0] = items[i].SKU;
                partnumbers[i][1] = items[i].Quantity.ToString();
                partnumbers[i][2] = items[i].Uplift.ToString();
            }

            PartnerPortalWebservice.Quotation wsQuote = pp.GenerateQuote(partnumbers, 1, wsUser.User.CodUsuario, from, billToCNPJ, null, null);

            return QuoteMapper.WebserviceToInterface(wsQuote);
        }

        public Company GetCompany(User user, string companyCode)
        {
            UserValidator.CheckUser(user);
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
            ResellerWebservice.CompanyResponse resp = webservice.Company_GetData(companyCode, user.CodERP);

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
            PartnerPortalWebservice.PartnerPortal webservice = new PartnerPortalWebservice.PartnerPortal();
            DataTable dt = webservice.Applications_Countries(countryName);

            return LocationMapper.ConvertDatatableToModel(dt);
        }

        public Location[] ListStates(User user, string countryCode,string stateName)
        {
            UserValidator.CheckUser(user);
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
            DataTable dt = webservice.Applications_States(countryCode, stateName);

            return LocationMapper.ConvertDatatableToModel(dt);
        }

        public OrderTracking[] OrderTracking(string billToCompanyCode, string orderNumber)
        {
            ResellerWebservice.Reseller webservice = new ResellerWebservice.Reseller();
            DataTable dt = webservice.OrderTracking(billToCompanyCode, orderNumber).orders;

            return ResellerTrackingMapper.ConvertDatatableToInterface(dt);
        }
    }
}
