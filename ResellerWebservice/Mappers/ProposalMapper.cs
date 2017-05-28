using ResellerWebservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResellerWebservice.Mappers
{
    public class ProposalMapper
    {
        public Proposal ConvertWebserviceToInterface(PartnerPortalWebservice.ProposalResponse wsProposal)
        {
            Proposal proposal = new Proposal();
            proposal.Name = wsProposal.Proposta.NomeProposta;
            proposal.CodForecast = wsProposal.CodForecast;
            proposal.ExpiryDate = wsProposal.DataValidade;
            proposal.NetAmount = wsProposal.Proposta.Valor;
            proposal.ComissionValue = wsProposal.Proposta.ValorComissao;
            proposal.DollarValue = wsProposal.Proposta.ValorDollar;
            proposal.ICMS = wsProposal.Proposta.ICMS;
            proposal.OrderCode = wsProposal.CodPedido;
            proposal.ProposalDate = wsProposal.DataProposta;
            proposal.ProposalId = wsProposal.CodProposta;
            proposal.SalesTaxesRate = wsProposal.Proposta.SalesTaxRate;
            proposal.TotalWithoutTaxes = wsProposal.Proposta.ValorSemImposto;
            proposal.TotalWitoutICMS = wsProposal.Proposta.ValorSemIcms;
            proposal.Version = wsProposal.Proposta.Versao;

            List<ProposalOption> options = new List<ProposalOption>();
            foreach (PartnerPortalWebservice.OptionResponse wsOption in wsProposal.Opcoes)
            {
                options.Add(this.ConvertWebserviceToInterface(wsOption));
            }

            proposal.Options = options.ToArray();
            return proposal;
        }

        public ProposalOption ConvertWebserviceToInterface(PartnerPortalWebservice.OptionResponse wsOption)
        {
            ProposalOption option = new ProposalOption();
            option.DollarValue = wsOption.ValorDollar;
            option.TotalWithoutTaxes = wsOption.TotalSemImposto;
            option.TotalWithoutICMS = wsOption.TotalSemICMS;
            option.NetValue = wsOption.TotalOpcao;
            option.ShowInBRL = wsOption.MostrarEmReal;

            List<Item> items = new List<Item>();
            foreach(PartnerPortalWebservice.OpcaoPart wsItem in wsOption.Itens)
            {
                items.Add(this.ConvertWebserviceToInterface(wsItem));
            }

            option.Items = items.ToArray();
            return option;
        }

        public Item ConvertWebserviceToInterface(PartnerPortalWebservice.OpcaoPart wsItem)
        {
            Item item = new Item();
            item.Discount = wsItem.Desconto;
            item.NetPrice = wsItem.Preco;
            item.SKU = wsItem.SKU;
            item.PurchasePrice = wsItem.PrecoFabricante;
            item.Quantity = (int)wsItem.Quantidade;
            item.Uplift = wsItem.Uplift;
            return item;
        }
    }
}