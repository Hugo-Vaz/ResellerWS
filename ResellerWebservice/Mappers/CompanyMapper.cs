using ResellerWebservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResellerWebservice.Mappers
{
    public static class CompanyMapper
    {
        public static Company ConvertWebserviceToInterface(ResellerWebservice.Company wsCompany, ResellerWebservice.Contato[] wsContatos = null)
        {
            Company company = new Company();

            company.Address = new Address();
            company.CNPJ = wsCompany.CNPJ;
            company.CustomerId = wsCompany.CustomerId;
            company.InscricaoEstadual = wsCompany.InscricaoEstadual;
            company.InscricaoMunicipal = wsCompany.InscricaoMunicipal;
            company.NomeFantasia = wsCompany.NomeFantasia;
            company.RazaoSocial = wsCompany.RazaoSocial;
            company.Telephone = wsCompany.Telefone;

            company.Address.AddressLine = wsCompany.Logradouro;
            company.Address.Number = wsCompany.Numero;
            company.Address.Block = wsCompany.Bairro;

            company.Address.City = new Location();
            company.Address.City.WestconCode = wsCompany.ukeyCidade;
            company.Address.City.Name = wsCompany.Cidade;
            company.Address.ZipCode = wsCompany.CEP;
            company.Address.Number = wsCompany.Numero;

            company.Address.State = new Location();
            company.Address.State.WestconCode = wsCompany.ukeyEstado;
            company.Address.State.Name = wsCompany.Estado;

            company.Address.Country = new Location();
            company.Address.Country.WestconCode = wsCompany.ukeyPais;
            company.Address.Country.Name = wsCompany.Pais;

            if (wsContatos != null)
            {
                List<Contact> list = new List<Contact>();

                foreach (ResellerWebservice.Contato contato in wsContatos)
                {
                    Contact c = new Contact();
                    c.Email = contato.Email;
                    c.Name = contato.Nome;
                    c.Phone = contato.Telefone;
                    c.ReceiveFinancialInfo = contato.RecebeInfoFinanceira;
                    c.ReceiveNFe = contato.RecebeNFe;
                    c.ReceiveNFeXML = contato.RecebeXMLNota;

                    list.Add(c);
                }

                company.Contacts = list.ToArray();
            }

            return company;
        }

        public static ResellerWebservice.Company ConvertInterfaceToWebservice(Company company, ref List<ResellerWebservice.Contato> wsContatos)
        {
            ResellerWebservice.Company wsCompany = new ResellerWebservice.Company();

            company.Address = new Address();
            wsCompany.CNPJ = company.CNPJ;
            wsCompany.CustomerId = company.CustomerId ;
            wsCompany.InscricaoEstadual = company.InscricaoEstadual;
            wsCompany.InscricaoMunicipal = company.InscricaoMunicipal;
            wsCompany.NomeFantasia = company.NomeFantasia;
            wsCompany.RazaoSocial = company.RazaoSocial;
            wsCompany.Telefone = company.Telephone;

            wsCompany.Logradouro = company.Address.AddressLine;
            wsCompany.Numero = company.Address.Number;
            wsCompany.Bairro = company.Address.Block;

            wsCompany.ukeyCidade = company.Address.City.WestconCode;
            wsCompany.Cidade = company.Address.City.Name;
            wsCompany.CEP = company.Address.ZipCode;
            wsCompany.Numero = company.Address.Number;

            wsCompany.ukeyEstado = company.Address.State.WestconCode;
            wsCompany.Estado = company.Address.State.Name;

            wsCompany.ukeyPais = company.Address.Country.WestconCode;
            wsCompany.Pais = company.Address.Country.Name;

            List<ResellerWebservice.Contato> list = new List<ResellerWebservice.Contato>();

            foreach (Contact contato in company.Contacts)
            {
                ResellerWebservice.Contato c = new ResellerWebservice.Contato();
                c.Email = contato.Email;
                c.Nome = contato.Name;
                c.Telefone = contato.Phone;
                c.RecebeInfoFinanceira = contato.ReceiveFinancialInfo;
                c.RecebeNFe = contato.ReceiveNFe;
                c.RecebeXMLNota = contato.ReceiveNFeXML;

                list.Add(c);
            }

            wsContatos = list;

            return wsCompany;
        }
    }
}